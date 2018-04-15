namespace Daily_Stats
{
    partial class frmState
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.chShowable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdState = new System.Windows.Forms.DataGridView();
            this.chEnabled = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(6, 117);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(76, 38);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "ایجاد";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "آدرس:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "کپشن:";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(122, 24);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(236, 26);
            this.txtAdress.TabIndex = 3;
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(122, 56);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(236, 26);
            this.txtCaption.TabIndex = 4;
            // 
            // chShowable
            // 
            this.chShowable.AutoSize = true;
            this.chShowable.Location = new System.Drawing.Point(192, 100);
            this.chShowable.Name = "chShowable";
            this.chShowable.Size = new System.Drawing.Size(166, 24);
            this.chShowable.TabIndex = 5;
            this.chShowable.Text = "در جدول نماش داده نشود.";
            this.chShowable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.chEnabled);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.chShowable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCaption);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(462, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حالت ها";
            // 
            // grdState
            // 
            this.grdState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdState.Location = new System.Drawing.Point(0, 203);
            this.grdState.Name = "grdState";
            this.grdState.RowTemplate.Height = 28;
            this.grdState.Size = new System.Drawing.Size(486, 290);
            this.grdState.TabIndex = 7;
            this.grdState.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdState_CellContentClick);
            this.grdState.SelectionChanged += new System.EventHandler(this.grdState_SelectionChanged);
            // 
            // chEnabled
            // 
            this.chEnabled.AutoSize = true;
            this.chEnabled.Checked = true;
            this.chEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chEnabled.Location = new System.Drawing.Point(301, 131);
            this.chEnabled.Name = "chEnabled";
            this.chEnabled.Size = new System.Drawing.Size(57, 24);
            this.chEnabled.TabIndex = 6;
            this.chEnabled.Text = "فعال";
            this.chEnabled.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(88, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 38);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 493);
            this.Controls.Add(this.grdState);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmState";
            this.Text = "frmState";
            this.Load += new System.EventHandler(this.frmState_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.CheckBox chShowable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdState;
        private System.Windows.Forms.CheckBox chEnabled;
        private System.Windows.Forms.Button btnEdit;
    }
}