namespace Daily_Stats
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdPersones = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.عملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بهآمارگرفتنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکسرشدههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.lstStates = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEnabled = new System.Windows.Forms.Button();
            this.btnBuildReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtStartDate = new Atf.UI.DateTimeSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndDate = new Atf.UI.DateTimeSelector();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDayCount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPersones
            // 
            this.grdPersones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersones.Dock = System.Windows.Forms.DockStyle.Right;
            this.grdPersones.Location = new System.Drawing.Point(431, 33);
            this.grdPersones.MultiSelect = false;
            this.grdPersones.Name = "grdPersones";
            this.grdPersones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdPersones.RowTemplate.Height = 28;
            this.grdPersones.Size = new System.Drawing.Size(844, 623);
            this.grdPersones.TabIndex = 2;
            this.grdPersones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPersones_CellContentClick);
            this.grdPersones.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.grdPersones_RowDividerDoubleClick);
            this.grdPersones.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdPersones_RowHeaderMouseDoubleClick);
            this.grdPersones.SelectionChanged += new System.EventHandler(this.grdPersones_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عملیاتToolStripMenuItem,
            this.mnuSetting,
            this.دربارهToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1275, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // عملیاتToolStripMenuItem
            // 
            this.عملیاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بهآمارگرفتنToolStripMenuItem,
            this.لیستکسرشدههاToolStripMenuItem,
            this.mnuStates,
            this.mnuProperty});
            this.عملیاتToolStripMenuItem.Name = "عملیاتToolStripMenuItem";
            this.عملیاتToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.عملیاتToolStripMenuItem.Text = "عملیات";
            // 
            // بهآمارگرفتنToolStripMenuItem
            // 
            this.بهآمارگرفتنToolStripMenuItem.Name = "بهآمارگرفتنToolStripMenuItem";
            this.بهآمارگرفتنToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.بهآمارگرفتنToolStripMenuItem.Text = "به آمار گرفتن";
            this.بهآمارگرفتنToolStripMenuItem.Click += new System.EventHandler(this.بهآمارگرفتنToolStripMenuItem_Click);
            // 
            // لیستکسرشدههاToolStripMenuItem
            // 
            this.لیستکسرشدههاToolStripMenuItem.Name = "لیستکسرشدههاToolStripMenuItem";
            this.لیستکسرشدههاToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.لیستکسرشدههاToolStripMenuItem.Text = "لیست کسر شده ها";
            // 
            // mnuStates
            // 
            this.mnuStates.Name = "mnuStates";
            this.mnuStates.Size = new System.Drawing.Size(236, 30);
            this.mnuStates.Text = "حالت ها";
            this.mnuStates.Click += new System.EventHandler(this.mnuStates_Click);
            // 
            // mnuProperty
            // 
            this.mnuProperty.Name = "mnuProperty";
            this.mnuProperty.Size = new System.Drawing.Size(236, 30);
            this.mnuProperty.Text = "ویژگی";
            this.mnuProperty.Click += new System.EventHandler(this.mnuProperty_Click);
            // 
            // دربارهToolStripMenuItem
            // 
            this.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem";
            this.دربارهToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.دربارهToolStripMenuItem.Text = "درباره";
            this.دربارهToolStripMenuItem.Click += new System.EventHandler(this.دربارهToolStripMenuItem_Click);
            // 
            // mnuSetting
            // 
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(90, 29);
            this.mnuSetting.Text = "تنظیمات";
            this.mnuSetting.Click += new System.EventHandler(this.mnuSetting_Click);
            // 
            // lstStates
            // 
            this.lstStates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStates.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStates.FormattingEnabled = true;
            this.lstStates.ItemHeight = 25;
            this.lstStates.Location = new System.Drawing.Point(245, 35);
            this.lstStates.Margin = new System.Windows.Forms.Padding(6);
            this.lstStates.Name = "lstStates";
            this.lstStates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstStates.Size = new System.Drawing.Size(186, 622);
            this.lstStates.TabIndex = 5;
            this.lstStates.Click += new System.EventHandler(this.lstStates_Click);
            this.lstStates.SelectedIndexChanged += new System.EventHandler(this.lstStates_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(44, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 33);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEnabled
            // 
            this.btnEnabled.Location = new System.Drawing.Point(44, 60);
            this.btnEnabled.Name = "btnEnabled";
            this.btnEnabled.Size = new System.Drawing.Size(108, 33);
            this.btnEnabled.TabIndex = 7;
            this.btnEnabled.Text = "کسر";
            this.btnEnabled.UseVisualStyleBackColor = true;
            this.btnEnabled.Click += new System.EventHandler(this.btnEnabled_Click);
            // 
            // btnBuildReport
            // 
            this.btnBuildReport.Location = new System.Drawing.Point(44, 99);
            this.btnBuildReport.Name = "btnBuildReport";
            this.btnBuildReport.Size = new System.Drawing.Size(108, 33);
            this.btnBuildReport.TabIndex = 8;
            this.btnBuildReport.Text = "گزارش";
            this.btnBuildReport.UseVisualStyleBackColor = true;
            this.btnBuildReport.Click += new System.EventHandler(this.btnBuildReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuildReport);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnEnabled);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(208, 138);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(23, 384);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(121, 27);
            this.dtStartDate.TabIndex = 9;
            this.dtStartDate.UsePersianFormat = true;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "پایان";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "شروع";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(23, 477);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(121, 27);
            this.dtEndDate.TabIndex = 19;
            this.dtEndDate.UsePersianFormat = true;
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "تعداد روز:";
            // 
            // txtDayCount
            // 
            this.txtDayCount.Location = new System.Drawing.Point(23, 429);
            this.txtDayCount.Name = "txtDayCount";
            this.txtDayCount.Size = new System.Drawing.Size(121, 26);
            this.txtDayCount.TabIndex = 21;
            this.txtDayCount.TextChanged += new System.EventHandler(this.txtDayCount_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 522);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 24);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "لیست کسر";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::Daily_Stats.Properties.Resources.analytics;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1275, 656);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDayCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStates);
            this.Controls.Add(this.grdPersones);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "آمار روزانه";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPersones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem عملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بهآمارگرفتنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهToolStripMenuItem;
        private System.Windows.Forms.ListBox lstStates;
        private System.Windows.Forms.ToolStripMenuItem لیستکسرشدههاToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEnabled;
        private System.Windows.Forms.Button btnBuildReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private Atf.UI.DateTimeSelector dtStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Atf.UI.DateTimeSelector dtEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDayCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuStates;
        private System.Windows.Forms.ToolStripMenuItem mnuProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
    }
}