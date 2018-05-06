using DataServices.Services;
using DomainClasses;
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
    public partial class frmSetting : Form
    {
        ISettingService _settingService;
        Setting Setting;
        public frmSetting(ISettingService SettingService)
        {
            _settingService = SettingService;
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            Setting = _settingService.Load();
            txtName.Text = Setting.Name;
            txtHeaderDateAddress.Text = Setting.HeaderDateAddress;
            txtHeaderDayAddress.Text = Setting.HeaderDayAddress;
            txtHeaderNameAddress.Text = Setting.HeaderNameAddress;
            txtLstStartAddress.Text = Setting.LstStartAddress;
            txtRanks.Text = Setting.Ranks;
            txtTitles.Text = Setting.Titles;
            txtTotalsAddress.Text = Setting.TotalsAddress;
            chWriteHeader.Checked = Setting.WriteHeader;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Setting.Name = txtName.Text; 
            Setting.HeaderDateAddress = txtHeaderDateAddress.Text;
            Setting.HeaderDayAddress = txtHeaderDayAddress.Text;
            Setting.HeaderNameAddress = txtHeaderNameAddress.Text;
            Setting.LstStartAddress = txtLstStartAddress.Text;
            Setting.Ranks = txtRanks.Text;
            Setting.Titles = txtTitles.Text;
            Setting.TotalsAddress = txtTotalsAddress.Text;
            Setting.WriteHeader = chWriteHeader.Checked;
            _settingService.Save(Setting);
        }
    }
}
