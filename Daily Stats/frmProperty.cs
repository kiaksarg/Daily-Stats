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
    public partial class frmProperty : Form
    {
        IPropertyService _propertyService;
        IUnitOfWork _unitOfWork;
        Property Property;
        long SelectedgrdPropertyId = -1;
        public frmProperty(IPropertyService SteteService, IUnitOfWork IUnitOfWork, Property property = null)
        {
            Property = property;
            _propertyService = SteteService;
            _unitOfWork = IUnitOfWork;
            InitializeComponent();
        }

        void FillGrid()
        {
            grdProperty.DataSource = _propertyService.Get();

            grdProperty.Columns[0].HeaderText = "شناسه";
            grdProperty.Columns[0].Width = 44;
            grdProperty.Columns[1].HeaderText = "آدرس";
            grdProperty.Columns[1].Width = 44;
            grdProperty.Columns[2].Width = 60;
            grdProperty.Columns[2].HeaderText = "کپشن";
            grdProperty.Columns[3].HeaderText = "نمایش";
            grdProperty.Columns[3].Width = 44;
         
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            _propertyService.Insert(new DataModel.Property()
            {
                Address = txtAdress.Text,
                Caption = txtCaption.Text,     
                Enabled = chEnabled.Checked

            });

            if (_unitOfWork.SaveAllChanges() > 0)
            {
                MessageBox.Show("حالت با موفقیت اضافه شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("حالت اضافه نشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Property property = _propertyService.Get(SelectedgrdPropertyId);


            property.Address = txtAdress.Text;
            property.Caption = txtCaption.Text;
            property.Enabled = chEnabled.Enabled;

            _propertyService.Edit(property);

            _unitOfWork.SaveAllChanges();
            FillGrid();
        }

        private void grdProperty_SelectionChanged(object sender, EventArgs e)
        {

            var row = sender as System.Windows.Forms.DataGridView;
            if (grdProperty.SelectedRows.Count > 0)
            {
                var selectedPropertyId = grdProperty.SelectedRows[0].Cells[0].Value;
                SelectedgrdPropertyId = (long)selectedPropertyId;
                var property = _propertyService.Get((long)selectedPropertyId);


                txtAdress.Text = property.Address;
                txtCaption.Text = property.Caption;

            
                chEnabled.Checked = property.Enabled;

            }
        }

        private void frmProperty_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
