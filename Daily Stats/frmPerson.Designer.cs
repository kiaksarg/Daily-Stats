﻿namespace Daily_Stats
{
    partial class frmPerson
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboRank = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProperty = new System.Windows.Forms.ComboBox();
            this.chbEnabled = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoVazife = new System.Windows.Forms.RadioButton();
            this.rdoPayvar = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDvCount = new System.Windows.Forms.Label();
            this.btnIDeleteDV = new System.Windows.Forms.Button();
            this.txtDeleteDvCount = new System.Windows.Forms.TextBox();
            this.btnDeleteAllDV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertDhbkh = new System.Windows.Forms.Button();
            this.txtInsertDvCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmboRank);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProperty);
            this.groupBox1.Controls.Add(this.chbEnabled);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFamily);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(476, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فرد";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmboRank
            // 
            this.cmboRank.FormattingEnabled = true;
            this.cmboRank.Location = new System.Drawing.Point(27, 66);
            this.cmboRank.Name = "cmboRank";
            this.cmboRank.Size = new System.Drawing.Size(141, 28);
            this.cmboRank.TabIndex = 4;
            this.cmboRank.SelectedIndexChanged += new System.EventHandler(this.cmboRank_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "رتبه";
            // 
            // txtProperty
            // 
            this.txtProperty.FormattingEnabled = true;
            this.txtProperty.Location = new System.Drawing.Point(27, 21);
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.Size = new System.Drawing.Size(141, 28);
            this.txtProperty.TabIndex = 3;
            this.txtProperty.SelectedIndexChanged += new System.EventHandler(this.txtRank_SelectedIndexChanged);
            // 
            // chbEnabled
            // 
            this.chbEnabled.AutoSize = true;
            this.chbEnabled.Location = new System.Drawing.Point(108, 158);
            this.chbEnabled.Name = "chbEnabled";
            this.chbEnabled.Size = new System.Drawing.Size(81, 24);
            this.chbEnabled.TabIndex = 19;
            this.chbEnabled.Text = "کسر شده";
            this.chbEnabled.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoVazife);
            this.panel2.Controls.Add(this.rdoPayvar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(221, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 39);
            this.panel2.TabIndex = 5;
            // 
            // rdoVazife
            // 
            this.rdoVazife.AutoSize = true;
            this.rdoVazife.Location = new System.Drawing.Point(15, 12);
            this.rdoVazife.Name = "rdoVazife";
            this.rdoVazife.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoVazife.Size = new System.Drawing.Size(51, 24);
            this.rdoVazife.TabIndex = 5;
            this.rdoVazife.TabStop = true;
            this.rdoVazife.Text = "دوم";
            this.rdoVazife.UseVisualStyleBackColor = true;
            // 
            // rdoPayvar
            // 
            this.rdoPayvar.AutoSize = true;
            this.rdoPayvar.Location = new System.Drawing.Point(101, 11);
            this.rdoPayvar.Name = "rdoPayvar";
            this.rdoPayvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoPayvar.Size = new System.Drawing.Size(53, 24);
            this.rdoPayvar.TabIndex = 5;
            this.rdoPayvar.TabStop = true;
            this.rdoPayvar.Text = "اول";
            this.rdoPayvar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "اولویت:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ویژگی";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(253, 108);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(141, 26);
            this.txtFamily.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "نام خانوادی";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(253, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "عنوان";
            // 
            // txtTitle
            // 
            this.txtTitle.FormattingEnabled = true;
            this.txtTitle.Location = new System.Drawing.Point(253, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(141, 28);
            this.txtTitle.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDvCount);
            this.groupBox2.Controls.Add(this.btnIDeleteDV);
            this.groupBox2.Controls.Add(this.txtDeleteDvCount);
            this.groupBox2.Controls.Add(this.btnDeleteAllDV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnInsertDhbkh);
            this.groupBox2.Controls.Add(this.txtInsertDvCount);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(476, 140);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "درج گروهی";
            // 
            // lblDvCount
            // 
            this.lblDvCount.AutoSize = true;
            this.lblDvCount.Location = new System.Drawing.Point(151, 61);
            this.lblDvCount.Name = "lblDvCount";
            this.lblDvCount.Size = new System.Drawing.Size(18, 20);
            this.lblDvCount.TabIndex = 31;
            this.lblDvCount.Text = "0";
            // 
            // btnIDeleteDV
            // 
            this.btnIDeleteDV.Location = new System.Drawing.Point(362, 36);
            this.btnIDeleteDV.Name = "btnIDeleteDV";
            this.btnIDeleteDV.Size = new System.Drawing.Size(96, 32);
            this.btnIDeleteDV.TabIndex = 30;
            this.btnIDeleteDV.Text = "حذف";
            this.btnIDeleteDV.UseVisualStyleBackColor = true;
            this.btnIDeleteDV.Click += new System.EventHandler(this.btnIDeleteDV_Click);
            // 
            // txtDeleteDvCount
            // 
            this.txtDeleteDvCount.Location = new System.Drawing.Point(279, 36);
            this.txtDeleteDvCount.Name = "txtDeleteDvCount";
            this.txtDeleteDvCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeleteDvCount.Size = new System.Drawing.Size(67, 26);
            this.txtDeleteDvCount.TabIndex = 29;
            this.txtDeleteDvCount.Text = "0";
            // 
            // btnDeleteAllDV
            // 
            this.btnDeleteAllDV.Location = new System.Drawing.Point(28, 53);
            this.btnDeleteAllDV.Name = "btnDeleteAllDV";
            this.btnDeleteAllDV.Size = new System.Drawing.Size(74, 37);
            this.btnDeleteAllDV.TabIndex = 28;
            this.btnDeleteAllDV.Text = "حذف همه";
            this.btnDeleteAllDV.UseVisualStyleBackColor = true;
            this.btnDeleteAllDV.Click += new System.EventHandler(this.btnDeleteAllDV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "تعداد";
            // 
            // btnInsertDhbkh
            // 
            this.btnInsertDhbkh.Location = new System.Drawing.Point(362, 74);
            this.btnInsertDhbkh.Name = "btnInsertDhbkh";
            this.btnInsertDhbkh.Size = new System.Drawing.Size(96, 32);
            this.btnInsertDhbkh.TabIndex = 27;
            this.btnInsertDhbkh.Text = "درج";
            this.btnInsertDhbkh.UseVisualStyleBackColor = true;
            this.btnInsertDhbkh.Click += new System.EventHandler(this.btnInsertDhbkh_Click);
            // 
            // txtInsertDvCount
            // 
            this.txtInsertDvCount.Location = new System.Drawing.Point(279, 80);
            this.txtInsertDvCount.Name = "txtInsertDvCount";
            this.txtInsertDvCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInsertDvCount.Size = new System.Drawing.Size(67, 26);
            this.txtInsertDvCount.TabIndex = 25;
            this.txtInsertDvCount.Text = "0";
            // 
            // frmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPerson";
            this.Text = "frmPerson";
            this.Load += new System.EventHandler(this.frmPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoVazife;
        private System.Windows.Forms.RadioButton rdoPayvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbEnabled;
        private System.Windows.Forms.ComboBox txtProperty;
        private System.Windows.Forms.ComboBox cmboRank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDvCount;
        private System.Windows.Forms.Button btnIDeleteDV;
        private System.Windows.Forms.TextBox txtDeleteDvCount;
        private System.Windows.Forms.Button btnDeleteAllDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertDhbkh;
        private System.Windows.Forms.TextBox txtInsertDvCount;
    }
}