using DataLayer.Context;
using DataModel;
using DataServices.Services;
using DomainClasses;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
namespace Daily_Stats
{
    public partial class frmMain : Form
    {
        long SelectedId;
        IPersonService _personService;
        IStateService _stateService;
        IPropertyService _propertyService;
        ISettingService _settingService;

        IUnitOfWork _unitOfWork;

        string BaseAddress = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";

        public frmMain(IPersonService PersonService, IPropertyService PropertyService, IStateService StateService, IUnitOfWork IUnitOfWork, ISettingService SettingService)
        {
            _unitOfWork = IUnitOfWork;
            _personService = PersonService;
            _stateService = StateService;
            _propertyService = PropertyService;
            _settingService = SettingService;
            InitializeComponent();
            SelectedId = -1;
        }
        void FillGridd(bool enabled = false)
        {
            grdPersones.DataSource = (!enabled) ? _personService.GetEnabledPeople_Grid() : _personService.GetDisabledPeople();
            grdPersones.Columns[0].HeaderText = "شناسه";
            grdPersones.Columns[0].Width = 45;
            grdPersones.Columns[1].HeaderText = "عنوان";
            grdPersones.Columns[2].HeaderText = "نام";
            grdPersones.Columns[3].HeaderText = "نام خانوادگی";
            grdPersones.Columns[4].HeaderText = "ویژگی";
            grdPersones.Columns[5].HeaderText = "اولویت";
            grdPersones.Columns[5].Width = 56;
        }
        public void loadStats()
        {
            lstStates.DataSource = _stateService.Get();

            lstStates.DisplayMember = "Caption";
            lstStates.ValueMember = "id";

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDvCount.Text = _personService.GetDvCount() + "";

            FillGridd();
            dtStartDate.Value = PersianDateTime.Now.ToDateTime();
            loadStats();
        }





        private void بهآمارگرفتنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerson frm = new frmPerson(_personService, _propertyService, _unitOfWork, _settingService);
            frm.ShowDialog();
            FillGridd();
        }

        public void changeState()
        {
            var res = _personService.GetPBState();

            foreach (var item in res)
            {
                if (item.OffEndDate.Date <= DateTime.Now.Date)
                {
                    //_personService.EditState(item.Id, PersonState.Present);
                    _personService.SetDate(item.Id, DateTime.MinValue, DateTime.MinValue);
                    _unitOfWork.SaveAllChanges();
                }
            }

        }

        private void btnBuildReport_Click(object sender, EventArgs e)
        {
            var setting = _settingService.Load();

            if (!File.Exists(setting.ReportFileAddress))
            {
                MessageBox.Show("فایل گزارش پیدا نشد");
                return;
            }
           
            var _excelReportService = StructureMap.Container.For<Program.ConsoleRegistry>().With("path").EqualTo(setting.ReportFileAddress).With("setting").EqualTo(setting).GetInstance<IExcelReportService>();
            var people = _personService.EnabledPeople();

            if (setting.WriteHeader)
                _excelReportService.WriteHeader();

            _excelReportService.Totals(people);
            _excelReportService.WriteStates(people);
            _excelReportService.WriteLists(people);
            _excelReportService.Close();


        }

        private void lstStates_Click(object sender, EventArgs e)
        {
            var item = sender as ListBox;
            if (grdPersones.SelectedRows.Count > 0)
            {
                var selectedPersonId = grdPersones.SelectedRows[0].Cells[0].Value;

                _personService.EditState((long)selectedPersonId, (long)item.SelectedValue);
                _unitOfWork.SaveAllChanges();
            }
        }

        private void grdPersones_SelectionChanged(object sender, EventArgs e)
        {
            var row = sender as System.Windows.Forms.DataGridView;
            if (grdPersones.SelectedRows.Count > 0)
            {
                var selectedPersonId = grdPersones.SelectedRows[0].Cells[0].Value;
                SelectedId = (long)selectedPersonId;
                var person = _personService.Fetch((long)selectedPersonId);
                //PersonState state = (PersonState)person.State;

                lstStates.SelectedValue = person.State_Id ?? 1;

                try
                {
                    dtStartDate.Value = person.OffStartDate;
                    dtEndDate.Value = person.OffEndDate;
                }
                catch (Exception)
                {
                    dtStartDate.Value = null;
                    dtEndDate.Value = null;

                }
            }
        }
        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            //if (SelectedId != -1)
            //{
            //    _personService.SetStartDate(SelectedId, dtStartDate.Value ?? DateTime.Now);
            //}
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            //if (SelectedId != -1)
            //{
            //    _personService.SetEndDate(SelectedId, dtEndDate.Value ?? DateTime.Now);
            //}
        }

        private void lstStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as ListBox;
            if (grdPersones.SelectedRows.Count > 0)
            {
                var selectedPersonId = grdPersones.SelectedRows[0].Cells[0].Value;
                PersonState ps = (PersonState)item.SelectedIndex + 1;


                //if (ps == PersonState.AnnualOff || ps == PersonState.DailyOff || ps == PersonState.LeaveIncentive)
                //{
                //    dtEndDate.Enabled = true;
                //    dtStartDate.Enabled = true;
                //}
                //else
                //{
                //    dtEndDate.Enabled = false;
                //    dtStartDate.Enabled = false;
                //}

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SelectedId != -1)
            {
                _personService.SetDate(SelectedId, dtStartDate.Value.Value, dtEndDate.Value.Value);
                _unitOfWork.SaveAllChanges();

            }
        }

        private void txtDayCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(txtDayCount.Text);
                dtEndDate.Value = dtStartDate.Value.Value.AddDays(count);
            }
            catch (Exception)
            {

            }
        }

        private void btnEnabled_Click(object sender, EventArgs e)
        {
            if (SelectedId != -1)
            {

                _personService.SetEnabled(SelectedId, false);
                _unitOfWork.SaveAllChanges();
                FillGridd();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                FillGridd(true);
            }
            else
            {
                FillGridd(false);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedId != -1)
            {
                var person = _personService.GetPerson(SelectedId);

                frmPerson frm = new frmPerson(_personService, _propertyService, _unitOfWork, _settingService, person);
                frm.ShowDialog();
                if (checkBox1.Checked == true)
                {
                    FillGridd(true);
                }
                else
                {
                    FillGridd(false);
                }

            }
        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void btnInsertDhbkh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtInsertDvCount.Text); i++)
            {
                _personService.Insert(new Person()
                {
                    Enabled = true,
                    FirstName = "dv0102",
                    LastName = "dv0102",
                    Rank = (int)Rank.daneshjoo,
                    //  State = 0,
                    Type = 1,
                    //Property_Id=
                });
            }
            _unitOfWork.SaveAllChanges();
            lblDvCount.Text = _personService.GetDvCount() + "";
            FillGridd();

        }

        private void btnIDeleteDV_Click(object sender, EventArgs e)
        {
            _personService.DeleteDv(int.Parse(txtDeleteDvCount.Text));
            _unitOfWork.SaveAllChanges();

            lblDvCount.Text = _personService.GetDvCount() + "";
            FillGridd();
        }

        private void btnDeleteAllDV_Click(object sender, EventArgs e)
        {
            _personService.DeleteAllDv();
            _unitOfWork.SaveAllChanges();

            lblDvCount.Text = _personService.GetDvCount() + "";
            FillGridd();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mnuStates_Click(object sender, EventArgs e)
        {

            frmState frm = new frmState(_stateService, _unitOfWork);
            frm.ShowDialog();
            loadStats();
        }

        private void grdPersones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mnuProperty_Click(object sender, EventArgs e)
        {

            frmProperty frm = new frmProperty(_propertyService, _unitOfWork);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void grdPersones_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void grdPersones_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SelectedId != -1)
            {
                var person = _personService.GetPerson(SelectedId);

                frmPerson frm = new frmPerson(_personService, _propertyService, _unitOfWork, _settingService, person);
                frm.ShowDialog();
                if (checkBox1.Checked == true)
                {
                    FillGridd(true);
                }
                else
                {
                    FillGridd(false);
                }

            }
        }

        private void mnuSetting_Click(object sender, EventArgs e)
        {
            frmSetting frm = new frmSetting(_settingService);
            frm.ShowDialog();
        }
    }
}
