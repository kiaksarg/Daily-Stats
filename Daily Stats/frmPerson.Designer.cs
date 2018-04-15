namespace Daily_Stats
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
            this.txtRank = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRank);
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
            this.groupBox1.Size = new System.Drawing.Size(512, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فرد";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRank
            // 
            this.txtRank.FormattingEnabled = true;
            this.txtRank.Items.AddRange(new object[] {
            "سرباز3",
            "سرباز2",
            "سرباز1",
            "سرجوخه",
            "دانشجو",
            "گروهبان3",
            "گروهبان2",
            "گروهبان1",
            "استوار2",
            "استوار1",
            "ستوان3",
            "ستوان2",
            "ستوان1",
            "سروان",
            "سرگرد",
            "سرهنگ2",
            "سرهنگ"});
            this.txtRank.Location = new System.Drawing.Point(302, 73);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(141, 28);
            this.txtRank.TabIndex = 20;
            // 
            // chbEnabled
            // 
            this.chbEnabled.AutoSize = true;
            this.chbEnabled.Location = new System.Drawing.Point(390, 128);
            this.chbEnabled.Name = "chbEnabled";
            this.chbEnabled.Size = new System.Drawing.Size(81, 24);
            this.chbEnabled.TabIndex = 19;
            this.chbEnabled.Text = "کسر شده";
            this.chbEnabled.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoVazife);
            this.panel2.Controls.Add(this.rdoPayvar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(15, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 42);
            this.panel2.TabIndex = 17;
            // 
            // rdoVazife
            // 
            this.rdoVazife.AutoSize = true;
            this.rdoVazife.Location = new System.Drawing.Point(15, 12);
            this.rdoVazife.Name = "rdoVazife";
            this.rdoVazife.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoVazife.Size = new System.Drawing.Size(43, 24);
            this.rdoVazife.TabIndex = 15;
            this.rdoVazife.TabStop = true;
            this.rdoVazife.Text = "0";
            this.rdoVazife.UseVisualStyleBackColor = true;
            // 
            // rdoPayvar
            // 
            this.rdoPayvar.AutoSize = true;
            this.rdoPayvar.Location = new System.Drawing.Point(101, 11);
            this.rdoPayvar.Name = "rdoPayvar";
            this.rdoPayvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoPayvar.Size = new System.Drawing.Size(43, 24);
            this.rdoPayvar.TabIndex = 14;
            this.rdoPayvar.TabStop = true;
            this.rdoPayvar.Text = "1";
            this.rdoPayvar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "کلاس:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ویژگی";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(36, 25);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(141, 26);
            this.txtFamily.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "نام خانوادی";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(302, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 26);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام";
            // 
            // frmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 200);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPerson";
            this.Text = "frmPerson";
            this.Load += new System.EventHandler(this.frmPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ComboBox txtRank;
    }
}