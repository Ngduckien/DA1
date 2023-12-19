namespace SonNumber
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cxbAnHien = new System.Windows.Forms.CheckBox();
            this.labTen = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.txbMatkhau = new System.Windows.Forms.TextBox();
            this.txbTaikhoan = new System.Windows.Forms.TextBox();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cxbAnHien);
            this.panel1.Controls.Add(this.labTen);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDangnhap);
            this.panel1.Controls.Add(this.txbMatkhau);
            this.panel1.Controls.Add(this.txbTaikhoan);
            this.panel1.Controls.Add(this.lbmatkhau);
            this.panel1.Controls.Add(this.lbtaikhoan);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 487);
            this.panel1.TabIndex = 0;
            // 
            // cxbAnHien
            // 
            this.cxbAnHien.AutoSize = true;
            this.cxbAnHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbAnHien.Location = new System.Drawing.Point(890, 310);
            this.cxbAnHien.Name = "cxbAnHien";
            this.cxbAnHien.Size = new System.Drawing.Size(150, 20);
            this.cxbAnHien.TabIndex = 5;
            this.cxbAnHien.Text = "Hiện/Ẩn mật khẩu";
            this.cxbAnHien.UseVisualStyleBackColor = true;
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTen.ForeColor = System.Drawing.Color.Black;
            this.labTen.Location = new System.Drawing.Point(636, 76);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(369, 90);
            this.labTen.TabIndex = 4;
            this.labTen.Text = "      Sơn Number\r\nBền bỉ theo thời gian";
            this.labTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labTen.UseMnemonic = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(890, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(739, 352);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(125, 38);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // txbMatkhau
            // 
            this.txbMatkhau.Location = new System.Drawing.Point(728, 280);
            this.txbMatkhau.Name = "txbMatkhau";
            this.txbMatkhau.Size = new System.Drawing.Size(312, 22);
            this.txbMatkhau.TabIndex = 2;
            this.txbMatkhau.UseSystemPasswordChar = true;
            // 
            // txbTaikhoan
            // 
            this.txbTaikhoan.Location = new System.Drawing.Point(728, 243);
            this.txbTaikhoan.Name = "txbTaikhoan";
            this.txbTaikhoan.Size = new System.Drawing.Size(312, 22);
            this.txbTaikhoan.TabIndex = 1;
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(566, 280);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(103, 22);
            this.lbmatkhau.TabIndex = 0;
            this.lbmatkhau.Text = "Mật khẩu: ";
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaikhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbtaikhoan.Location = new System.Drawing.Point(566, 241);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(151, 22);
            this.lbtaikhoan.TabIndex = 0;
            this.lbtaikhoan.Text = "Tên đăng nhập:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SonNumber.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1066, 495);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox txbMatkhau;
        private System.Windows.Forms.TextBox txbTaikhoan;
        private System.Windows.Forms.Label labTen;
        private System.Windows.Forms.CheckBox cxbAnHien;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

