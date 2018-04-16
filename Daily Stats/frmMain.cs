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

namespace Daily_Stats
{
    public partial class frmMain : Form
    {
        long SelectedId;
        IPersonService _personService;
        IStateService _stateService;
        IPropertyService _propertyService;
        IUnitOfWork _unitOfWork;
        string BaseAddress = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";

        public frmMain(IPersonService PersonService, IPropertyService PropertyService, IStateService StateService, IUnitOfWork IUnitOfWork)
        {
            _unitOfWork = IUnitOfWork;
            _personService = PersonService;
            _stateService = StateService;
            _propertyService = PropertyService;
            InitializeComponent();
            SelectedId = -1;
        }
        void FillGridd(bool enabled = false)
        {
            grdPersones.DataSource = (!enabled) ? _personService.GetEnabledPeopleWithRank() : _personService.GetDisabledPeople();
            grdPersones.Columns[0].HeaderText = "شناسه";
            grdPersones.Columns[0].Width = 45;
            grdPersones.Columns[1].HeaderText = "نام";
            grdPersones.Columns[2].HeaderText = "نام خانوادگی";
            grdPersones.Columns[3].HeaderText = "کلاس";
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDvCount.Text = _personService.GetDvCount() + "";
            FillGridd();
            dtStartDate.Value = PersianDateTime.Now.ToDateTime();
        }





        private void بهآمارگرفتنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerson frm = new frmPerson(_personService, _propertyService, _unitOfWork);
            frm.ShowDialog();
            FillGridd();
        }
        public void WriteFarAgents(Word.Document document)
        {
            var FarAgents = _personService.GetFarAgents();

            var gr = from x in FarAgents
                     group x by x.Rank into g
                     select new { Rank = g.Key, People = g.ToList() };

            string farAtext = "مامور دور:";
            List<Person> payvarfarAtext = new List<Person>();
            foreach (var item in gr)
            {
                //if (item.People.Any(x => x.Type == 0) && !item.People.Any(x => x.Type == 1))
                if (item.People.Any(x => x.Type == 1))
                {
                    farAtext += item.Rank.toRank().toRankVazife() + ':';
                }

                foreach (var person in item.People)
                {
                    if (person.Type == 1)
                    {
                        farAtext += person.LastName + '،';
                    }
                    else
                    {
                        payvarfarAtext.Add(person);
                    }
                }
            }
            foreach (var item in payvarfarAtext)
            {
                farAtext += $"{item.Rank.toRank()} {item.FirstName} {item.LastName}،";
            }
            //farAtext.TrimEnd('،');
            document.Content.InsertAfter(farAtext);
            document.Content.InsertAfter(Environment.NewLine);
            //document.Content.InsertAfter(farAtext);


        }
        public void WriteCloseAgents(Word.Document document)
        {
            var CloseAgents = _personService.GetCloseAgents();

            var gr = from x in CloseAgents
                     group x by x.Rank into g
                     select new { Rank = g.Key, People = g.ToList() };

            string CloseAtext = "مامور نزدیک:";
            List<Person> payvarCloseAtext = new List<Person>();
            foreach (var item in gr)
            {

                if (item.People.Any(x => x.Type == 1))
                {
                    CloseAtext += item.Rank.toRank().toRankVazife() + ':';
                }
                foreach (var person in item.People)
                {
                    if (person.Type == 1)
                    {
                        CloseAtext += person.LastName + '،';
                    }
                    else
                    {
                        payvarCloseAtext.Add(person);
                    }
                }
            }
            foreach (var item in payvarCloseAtext)
            {
                CloseAtext += $"{item.Rank.toRank()} {item.FirstName} {item.LastName}،";
            }
            //CloseAtext.TrimEnd('،');
            document.Content.InsertAfter(CloseAtext);
            document.Content.InsertAfter(Environment.NewLine);
            //document.Content.InsertAfter(CloseAtext);


        }
        public void Write_Absent(Word.Document document)
        {
            var people = _personService.GetState(PersonState.Absent).OrderBy(x => x.Rank);
            string txt = "نهست:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            document.Content.InsertAfter(txt);
            document.Content.InsertAfter(Environment.NewLine);
        }
        public void Write_AnnualOff(Word.Document document)
        {
            var people = _personService.GetState(PersonState.AnnualOff).OrderBy(x => x.Rank);
            string txt = "مرخصی سالیانه:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            document.Content.InsertAfter(txt);
            document.Content.InsertAfter(Environment.NewLine);
        }
        public void Write_DailyOff(Word.Document document)
        {

            var people = _personService.GetState(PersonState.DailyOff).OrderBy(x => x.Rank);
            string txt = "مرخصی روزانه:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            document.Content.InsertAfter(txt);
            document.Content.InsertAfter(Environment.NewLine);
        }
        public void Write_RestFridayPrayers(Word.Document document)
        {

            var people = _personService.GetState(PersonState.RestFridayPrayers).OrderBy(x => x.Rank);
            string txt = "استراحت:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            if (people.Any())
            {
                document.Content.InsertAfter(txt);
                document.Content.InsertAfter(Environment.NewLine);
            }
        }

        public void Write_LeaveIncentive(Word.Document document)
        {

            var people = _personService.GetState(PersonState.LeaveIncentive).OrderBy(x => x.Rank);
            string txt = "مرخصی تشویقی:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            if (people.Any())
            {
                document.Content.InsertAfter(txt);
                document.Content.InsertAfter(Environment.NewLine);
            }

        }
        public void Write_(Word.Document document)
        {

            var people = _personService.GetState(PersonState.LeaveIncentive).OrderBy(x => x.Rank);
            string txt = "مرخصی تشویقی:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            document.Content.InsertAfter(txt);
            document.Content.InsertAfter(Environment.NewLine);
        }
        public void Write_Shooting(Word.Document document)
        {

            var people = _personService.GetState(PersonState.Shooting).OrderBy(x => x.Rank);
            string txt = " تیراندازی:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            if (people.Any())
            {
                document.Content.InsertAfter(txt);
                document.Content.InsertAfter(Environment.NewLine);
            }
        }
        public void Write_Guard(Word.Document document)
        {

            var people = _personService.GetState(PersonState.Guard).OrderBy(x => x.Rank);
            string txt = "نگهبان:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            if (people.Any())
            {
                document.Content.InsertAfter(txt);
                document.Content.InsertAfter(Environment.NewLine);
            }
        }
        public void Write_Hospital(Word.Document document)
        {

            var people = _personService.GetState(PersonState.Hospital).OrderBy(x => x.Rank);
            string txt = "بیمارستان:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            if (people.Any())
            {
                document.Content.InsertAfter(txt);
                document.Content.InsertAfter(Environment.NewLine);
            }
        }
        public void Write_Prison(Word.Document document)
        {

            var people = _personService.GetState(PersonState.Prison).OrderBy(x => x.Rank);
            string txt = "زندان:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            if (people.Any())
            {
                document.Content.InsertAfter(txt);
                document.Content.InsertAfter(Environment.NewLine);
            }
        }
        public void Write_GetBede(Word.Document document)
        {

            var people = _personService.GetBede().OrderBy(x => x.Rank);
            string txt = "مامور بعده:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            if (people.Any())
            {
                document.Content.InsertAfter(txt);
                document.Content.InsertAfter(Environment.NewLine);
            }
        }
        public void Write_Escapee(Word.Document document)
        {

            var people = _personService.GetState(PersonState.Escapee).OrderBy(x => x.Rank);
            string txt = "فراری:";
            foreach (var item in people)
            {
                var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

                txt += $"{rank} {item.FirstName} {item.LastName}،";
            }
            if (people.Any())
            {
                document.Content.InsertAfter(txt);
                document.Content.InsertAfter(Environment.NewLine);
            }
        }
        //public void Write_(Word.Document document)
        //{

        //    var people = _personService.GetState(PersonState.LeaveIncentive).OrderBy(x => x.Rank);
        //    string txt = "مرخصی تشویقی:";
        //    foreach (var item in people)
        //    {
        //        var rank = (item.Type == 0) ? item.Rank.toRank() : item.Rank.toRank().toRankVazife();

        //        txt += $"{rank} {item.FirstName} {item.LastName}،";
        //    }
        //    document.Content.InsertAfter(txt);
        //    document.Content.InsertAfter(Environment.NewLine);
        //}


        //public void Write_Absent(Word.Document document)
        //{

        //}

        public void changeState()
        {
            var res = _personService.GetPBState();

            foreach (var item in res)
            {
                if (item.OffEndDate.Date <= DateTime.Now.Date)
                {
                    _personService.EditState(item.Id, PersonState.Present);
                    _personService.SetDate(item.Id, DateTime.MinValue, DateTime.MinValue);
                    _unitOfWork.SaveAllChanges();
                }
            }

        }
        private void btnBuildReport_Click(object sender, EventArgs e)
        {


        }

        private void lstStates_Click(object sender, EventArgs e)
        {
            var item = sender as ListBox;
            if (grdPersones.SelectedRows.Count > 0)
            {
                var selectedPersonId = grdPersones.SelectedRows[0].Cells[0].Value;
                PersonState ps = (item.SelectedIndex == 12) ? PersonState.Present : (PersonState)item.SelectedIndex + 1;
                _personService.EditState((long)selectedPersonId, ps);
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

                //////////////  lstStates.SelectedIndex = (person.State == 0) ? 12 : person.State - 1;

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

        private void txtSave_Click(object sender, EventArgs e)
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

                frmPerson frm = new frmPerson(_personService, _propertyService, _unitOfWork, person);
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
                    Type = 1
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
        }

        private void grdPersones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mnuProperty_Click(object sender, EventArgs e)
        {

            frmProperty frm = new frmProperty(_propertyService, _unitOfWork);
            frm.ShowDialog();
        }
    }
}
