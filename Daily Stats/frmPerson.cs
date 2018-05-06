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
                    Type = Convert.ToByte((rdoPayvar.Checked == true) ? 0 : 1),
                    Property = _PropertyService.Get((long)txtRank.SelectedValue),

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
                Person.Property_Id = (long?)txtRank.SelectedValue;
                Person.Type = Convert.ToByte((rdoPayvar.Checked == true) ? 0 : 1);

                _personService.EditPerson(Person);
                _unitOfWork.SaveAllChanges();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            var properties = _PropertyService.Get();


            txtRank.DataSource = properties;
            txtRank.DisplayMember = "Caption";
            txtRank.ValueMember = "id";

            cmboRank.Items.AddRange(_settingService.Load().Ranks.Split(Environment.NewLine.ToCharArray()).ToList<string>().Where(x => !string.IsNullOrWhiteSpace(x)).ToArray<object>());

            if (Person != null)
            {
                chbEnabled.Checked = !Person.Enabled;
                txtName.Text = Person.FirstName;
                txtFamily.Text = Person.LastName;
                cmboRank.SelectedIndex = (Person.Rank >= cmboRank.Items.Count) ? -1 : Person.Rank;
                txtRank.SelectedValue = Person.Property_Id ?? -1;
                txtTitle.Text = Person.Title;
                rdoPayvar.Checked = (Person.Type == 1) ? true : rdoVazife.Checked = true;
            }

        }

        private void txtRank_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmboRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
