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
        IUnitOfWork _unitOfWork;
        Person Person;
        public frmPerson(IPersonService PersonService, IUnitOfWork IUnitOfWork, Person person = null)
        {
            _unitOfWork = IUnitOfWork;
            _personService = PersonService;
            Person = person;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Person == null)
            {
                _personService.Insert(new DataModel.Person()
                {
                    Enabled = !chbEnabled.Checked,
                    FirstName = txtName.Text,
                    LastName = txtFamily.Text,
                    Rank = txtRank.SelectedIndex,
                    Type = Convert.ToByte((rdoPayvar.Checked == true) ? 0 : 1),
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
                Person.LastName = txtFamily.Text;
                Person.Rank = txtRank.SelectedIndex;
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
            if (Person != null)
            {
                chbEnabled.Checked = !Person.Enabled;
                txtName.Text = Person.FirstName;
                txtFamily.Text = Person.LastName;
                txtRank.SelectedIndex = Person.Rank;
                rdoPayvar.Checked = (Person.Type == 0) ? true : false;

            }
        }
    }
}
