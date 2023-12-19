namespace SonNumber
{
    partial class fDoanhthu
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
            this.panDoanhthu = new System.Windows.Forms.Panel();
            this.panDulieuDT = new System.Windows.Forms.Panel();
            this.dataGridViewDoanhthu = new System.Windows.Forms.DataGridView();
            this.panThaotacDT = new System.Windows.Forms.Panel();
            this.btnThoatDT = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.labTongtien = new System.Windows.Forms.Label();
            this.txbTongtien = new System.Windows.Forms.TextBox();
            this.lbTieudeDoanhthu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbbatdau = new System.Windows.Forms.Label();
            this.lbdenngay = new System.Windows.Forms.Label();
            this.dateketthuc = new System.Windows.Forms.DateTimePicker();
            this.datebatdau = new System.Windows.Forms.DateTimePicker();
            this.panDoanhthu.SuspendLayout();
            this.panDulieuDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhthu)).BeginInit();
            this.panThaotacDT.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDoanhthu
            // 
            this.panDoanhthu.BackColor = System.Drawing.Color.LightPink;
            this.panDoanhthu.Controls.Add(this.panDulieuDT);
            this.panDoanhthu.Controls.Add(this.panThaotacDT);
            this.panDoanhthu.Controls.Add(this.lbTieudeDoanhthu);
            this.panDoanhthu.Controls.Add(this.panel2);
            this.panDoanhthu.Location = new System.Drawing.Point(4, 7);
            this.panDoanhthu.Name = "panDoanhthu";
            this.panDoanhthu.Size = new System.Drawing.Size(793, 543);
            this.panDoanhthu.TabIndex = 0;
            // 
            // panDulieuDT
            // 
            this.panDulieuDT.Controls.Add(this.dataGridViewDoanhthu);
            this.panDulieuDT.Location = new System.Drawing.Point(4, 230);
            this.panDulieuDT.Name = "panDulieuDT";
            this.panDulieuDT.Size = new System.Drawing.Size(787, 312);
            this.panDulieuDT.TabIndex = 3;
            // 
            // dataGridViewDoanhthu
            // 
            this.dataGridViewDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhthu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDoanhthu.Name = "dataGridViewDoanhthu";
            this.dataGridViewDoanhthu.RowHeadersWidth = 51;
            this.dataGridViewDoanhthu.Size = new System.Drawing.Size(786, 310);
            this.dataGridViewDoanhthu.TabIndex = 0;
            // 
            // panThaotacDT
            // 
            this.panThaotacDT.Controls.Add(this.btnThoatDT);
            this.panThaotacDT.Controls.Add(this.btnThongke);
            this.panThaotacDT.Controls.Add(this.labTongtien);
            this.panThaotacDT.Controls.Add(this.txbTongtien);
            this.panThaotacDT.Location = new System.Drawing.Point(2, 128);
            this.panThaotacDT.Name = "panThaotacDT";
            this.panThaotacDT.Size = new System.Drawing.Size(790, 96);
            this.panThaotacDT.TabIndex = 2;
            // 
            // btnThoatDT
            // 
            this.btnThoatDT.Location = new System.Drawing.Point(156, 21);
            this.btnThoatDT.Name = "btnThoatDT";
            this.btnThoatDT.Size = new System.Drawing.Size(125, 43);
            this.btnThoatDT.TabIndex = 2;
            this.btnThoatDT.Text = "Thoát";
            this.btnThoatDT.UseVisualStyleBackColor = true;
            this.btnThoatDT.Click += new System.EventHandler(this.btnThoatDT_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(10, 21);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(125, 43);
            this.btnThongke.TabIndex = 2;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // labTongtien
            // 
            this.labTongtien.AutoSize = true;
            this.labTongtien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTongtien.Location = new System.Drawing.Point(453, 32);
            this.labTongtien.Name = "labTongtien";
            this.labTongtien.Size = new System.Drawing.Size(85, 19);
            this.labTongtien.TabIndex = 1;
            this.labTongtien.Text = "Tổng tiền:";
            // 
            // txbTongtien
            // 
            this.txbTongtien.Location = new System.Drawing.Point(560, 23);
            this.txbTongtien.Multiline = true;
            this.txbTongtien.Name = "txbTongtien";
            this.txbTongtien.ReadOnly = true;
            this.txbTongtien.Size = new System.Drawing.Size(221, 41);
            this.txbTongtien.TabIndex = 0;
            // 
            // lbTieudeDoanhthu
            // 
            this.lbTieudeDoanhthu.AutoSize = true;
            this.lbTieudeDoanhthu.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieudeDoanhthu.Location = new System.Drawing.Point(237, 11);
            this.lbTieudeDoanhthu.Name = "lbTieudeDoanhthu";
            this.lbTieudeDoanhthu.Size = new System.Drawing.Size(317, 42);
            this.lbTieudeDoanhthu.TabIndex = 1;
            this.lbTieudeDoanhthu.Text = "Quản lý doanh thu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbbatdau);
            this.panel2.Controls.Add(this.lbdenngay);
            this.panel2.Controls.Add(this.dateketthuc);
            this.panel2.Controls.Add(this.datebatdau);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 57);
            this.panel2.TabIndex = 0;
            // 
            // lbbatdau
            // 
            this.lbbatdau.AutoSize = true;
            this.lbbatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbatdau.Location = new System.Drawing.Point(3, 27);
            this.lbbatdau.Name = "lbbatdau";
            this.lbbatdau.Size = new System.Drawing.Size(134, 16);
            this.lbbatdau.TabIndex = 2;
            this.lbbatdau.Text = "Doanh thu từ ngày:";
            // 
            // lbdenngay
            // 
            this.lbdenngay.AutoSize = true;
            this.lbdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdenngay.Location = new System.Drawing.Point(439, 27);
            this.lbdenngay.Name = "lbdenngay";
            this.lbdenngay.Size = new System.Drawing.Size(75, 16);
            this.lbdenngay.TabIndex = 1;
            this.lbdenngay.Text = "đến ngày:";
            // 
            // dateketthuc
            // 
            this.dateketthuc.Location = new System.Drawing.Point(537, 22);
            this.dateketthuc.Name = "dateketthuc";
            this.dateketthuc.Size = new System.Drawing.Size(247, 22);
            this.dateketthuc.TabIndex = 0;
            // 
            // datebatdau
            // 
            this.datebatdau.Location = new System.Drawing.Point(158, 22);
            this.datebatdau.Name = "datebatdau";
            this.datebatdau.Size = new System.Drawing.Size(247, 22);
            this.datebatdau.TabIndex = 0;
            // 
            // fDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 553);
            this.Controls.Add(this.panDoanhthu);
            this.Name = "fDoanhthu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.panDoanhthu.ResumeLayout(false);
            this.panDoanhthu.PerformLayout();
            this.panDulieuDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhthu)).EndInit();
            this.panThaotacDT.ResumeLayout(false);
            this.panThaotacDT.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panDoanhthu;
        private System.Windows.Forms.Label lbTieudeDoanhthu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbdenngay;
        private System.Windows.Forms.DateTimePicker dateketthuc;
        private System.Windows.Forms.DateTimePicker datebatdau;
        private System.Windows.Forms.Label lbbatdau;
        private System.Windows.Forms.Panel panDulieuDT;
        private System.Windows.Forms.DataGridView dataGridViewDoanhthu;
        private System.Windows.Forms.Panel panThaotacDT;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Label labTongtien;
        private System.Windows.Forms.TextBox txbTongtien;
        private System.Windows.Forms.Button btnThoatDT;
    }
}