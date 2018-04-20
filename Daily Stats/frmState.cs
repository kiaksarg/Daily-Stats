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
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Daily_Stats
{
    public partial class frmState : Form
    {
        IStateService _steteService;
        IUnitOfWork _unitOfWork;
        State State;
        long SelectedgrdStateId = -1;
        public frmState(IStateService SteteService, IUnitOfWork IUnitOfWork, State state = null)
        {
            State = state;
            _steteService = SteteService;
            _unitOfWork = IUnitOfWork;
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _steteService.Insert(new DataModel.State()
            {
                Address = txtAdress.Text,
                Caption = txtCaption.Text,
                Showable = !chShowable.Checked,
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
            FillGrid();
        }

        void FillGrid()
        {
            grdState.DataSource = _steteService.Get();

            grdState.Columns[0].HeaderText = "شناسه";
            grdState.Columns[0].Width = 44;
            grdState.Columns[1].HeaderText = "آدرس";
            grdState.Columns[1].Width = 44;
            grdState.Columns[2].Width =99;
            grdState.Columns[2].HeaderText = "کپشن";
            grdState.Columns[3].HeaderText = "نمایش";
            grdState.Columns[3].Width = 44;
            grdState.Columns[4].HeaderText = "فعال";
            grdState.Columns[4].Width = 44;
        }
        private void frmState_Load(object sender, EventArgs e)
        {
            FillGrid();

        }
        private void grdState_SelectionChanged(object sender, EventArgs e)
        {
            var row = sender as System.Windows.Forms.DataGridView;
            if (grdState.SelectedRows.Count > 0)
            {
                var selectedStateId = grdState.SelectedRows[0].Cells[0].Value;
                SelectedgrdStateId = (long)selectedStateId;
                var state = _steteService.Get((long)selectedStateId);


                txtAdress.Text = state.Address;
                txtCaption.Text = state.Caption;

                chShowable.Checked = !state.Showable;
                chEnabled.Checked = state.Enabled;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedgrdStateId != -1)
            {
                State state = _steteService.Get(SelectedgrdStateId);


                state.Address = txtAdress.Text;
                state.Caption = txtCaption.Text;
                state.Showable = !chShowable.Checked;
                state.Enabled = chEnabled.Enabled;

                _steteService.Edit(state);

                _unitOfWork.SaveAllChanges();
                FillGrid();
            }
            else
            {
                MessageBox.Show("رکوردی برای ویرایش وجود ندارد.");
            }
        }

        private void grdState_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
