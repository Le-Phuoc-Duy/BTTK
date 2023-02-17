namespace BTTK
{
    partial class Form2
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
            this.lblMssv = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAnh = new System.Windows.Forms.CheckBox();
            this.chkHocBa = new System.Windows.Forms.CheckBox();
            this.chkCCCD = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMssv
            // 
            this.lblMssv.AutoSize = true;
            this.lblMssv.Location = new System.Drawing.Point(31, 30);
            this.lblMssv.Name = "lblMssv";
            this.lblMssv.Size = new System.Drawing.Size(39, 16);
            this.lblMssv.TabIndex = 0;
            this.lblMssv.Text = "Mssv";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(31, 130);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(52, 16);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lop SH";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(31, 176);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngay sinh";
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(94, 38);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(101, 22);
            this.txtMssv.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(95, 170);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(100, 22);
            this.txtNgaySinh.TabIndex = 6;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(94, 130);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 24);
            this.cboLop.TabIndex = 7;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(39, 44);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(59, 20);
            this.chkMale.TabIndex = 8;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFemale);
            this.groupBox1.Controls.Add(this.chkMale);
            this.groupBox1.Location = new System.Drawing.Point(496, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 148);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Location = new System.Drawing.Point(39, 80);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(75, 20);
            this.chkFemale.TabIndex = 9;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCCCD);
            this.groupBox2.Controls.Add(this.chkHocBa);
            this.groupBox2.Controls.Add(this.chkAnh);
            this.groupBox2.Location = new System.Drawing.Point(496, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 162);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ho so";
            // 
            // chkAnh
            // 
            this.chkAnh.AutoSize = true;
            this.chkAnh.Location = new System.Drawing.Point(7, 22);
            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size = new System.Drawing.Size(52, 20);
            this.chkAnh.TabIndex = 0;
            this.chkAnh.Text = "Anh";
            this.chkAnh.UseVisualStyleBackColor = true;
            // 
            // chkHocBa
            // 
            this.chkHocBa.AutoSize = true;
            this.chkHocBa.Location = new System.Drawing.Point(7, 60);
            this.chkHocBa.Name = "chkHocBa";
            this.chkHocBa.Size = new System.Drawing.Size(73, 20);
            this.chkHocBa.TabIndex = 1;
            this.chkHocBa.Text = "Hoc ba";
            this.chkHocBa.UseVisualStyleBackColor = true;
            // 
            // chkCCCD
            // 
            this.chkCCCD.AutoSize = true;
            this.chkCCCD.Location = new System.Drawing.Point(7, 104);
            this.chkCCCD.Name = "chkCCCD";
            this.chkCCCD.Size = new System.Drawing.Size(66, 20);
            this.chkCCCD.TabIndex = 2;
            this.chkCCCD.Text = "CCCD";
            this.chkCCCD.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(430, 379);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMssv);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMssv;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCCCD;
        private System.Windows.Forms.CheckBox chkHocBa;
        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}