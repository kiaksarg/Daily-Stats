using DataLayer.Context;
using DataModel;
using DataServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Daily_Stats
{
    public partial class frmPerson : Form
    {



        IPersonService _personService;
        IPropertyService _PropertyService;
        IUnitOfWork _unitOfWork;
        Person Person;
        ISettingService _settingService;
        public frmPerson(IPersonService PersonService, IPropertyService PropertyService, IUnitOfWork IUnitOfWork, ISettingService SettingService, Person person = null)
        {
            _unitOfWork = IUnitOfWork;
            _personService = PersonService;
            _PropertyService = PropertyService;
            Person = person;
            _settingService = SettingService;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Person == null)
            {
                _personService.Insert(new DataModel.Person()
                {
                    Enabled = !chbEnabled.Checked,
                    Title = txtTitle.Text,
                    FirstName = txtName.Text,
                    LastName = txtFamily.Text,
                    Rank = (cmboRank.SelectedIndex == -1) ? cmboRank.Items.Count : cmboRank.SelectedIndex,
                    Type = Convert.ToByte((rdoPayvar.Checked == true) ? 1 : 0),
                    Property = _PropertyService.Get((long)txtProperty.SelectedValue),

                    // State = 0,
                    //OffEndDate = null,
                    //OffStartDate=null

                });
                if (_unitOfWork.SaveAllChanges() > 0)
                {
                    MessageBox.Show("فرد با موفقیت اضافه شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("فرد اضافه نشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Person.Enabled = !chbEnabled.Checked;

                Person.FirstName = txtName.Text;
                Person.Title = txtTitle.Text;
                Person.LastName = txtFamily.Text;
                Person.Rank = (cmboRank.SelectedIndex == -1) ? cmboRank.Items.Count : cmboRank.SelectedIndex;
                Person.Property_Id = (long?)txtProperty.SelectedValue;
                Person.Type = Convert.ToByte((rdoPayvar.Checked == true) ? 1 : 0);

                _personService.EditPerson(Person);
                _unitOfWork.SaveAllChanges();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            lblDvCount.Text = _personService.GetDvCount() + "";
            var properties = _PropertyService.Get();


            txtProperty.DataSource = properties;
            txtProperty.DisplayMember = "Caption";
            txtProperty.ValueMember = "id";

            cmboRank.Items.AddRange(_settingService.Load().Ranks.Split(Environment.NewLine.ToCharArray()).ToList<string>().Where(x => !string.IsNullOrWhiteSpace(x)).ToArray<object>());
            txtTitle.Items.AddRange(_settingService.Load().Titles.Split(Environment.NewLine.ToCharArray()).ToList<string>().Where(x => !string.IsNullOrWhiteSpace(x)).ToArray<object>());

            if (Person != null)
            {
                chbEnabled.Checked = !Person.Enabled;
                txtName.Text = Person.FirstName;
                txtFamily.Text = Person.LastName;
                cmboRank.SelectedIndex = (Person.Rank >= cmboRank.Items.Count) ? -1 : Person.Rank;
                txtProperty.SelectedValue = Person.Property_Id ?? -1;
                txtTitle.Text = Person.Title;

                if (Person.Type == 1)

                    rdoPayvar.Checked = true;
                else
                    rdoVazife.Checked = true;
            }

        }

        private void txtRank_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmboRank_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    Title = txtTitle.Text,
                    Rank = (cmboRank.SelectedIndex == -1) ? cmboRank.Items.Count : cmboRank.SelectedIndex,
                    Type = Convert.ToByte((rdoPayvar.Checked == true) ? 0 : 1),
                    Property = _PropertyService.Get((long)txtProperty.SelectedValue)
                });
            }
            _unitOfWork.SaveAllChanges();
            lblDvCount.Text = _personService.GetDvCount() + "";
        }

        private void btnIDeleteDV_Click(object sender, EventArgs e)
        {
            _personService.DeleteDv(int.Parse(txtDeleteDvCount.Text));
            _unitOfWork.SaveAllChanges();

            lblDvCount.Text = _personService.GetDvCount() + "";
        }

        private void btnDeleteAllDV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                _personService.DeleteAllDv();
                _unitOfWork.SaveAllChanges();

                lblDvCount.Text = _personService.GetDvCount() + "";
            }
        
        }
    }
}
