using SonNumber.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonNumber
{
    public partial class fHethongchung : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount.Vaitro); }
        }
        public fHethongchung(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
        }

        void changeAccount(int vaitro)
        {
            mnuDoanhthu.Enabled = vaitro == 1;
            xinchaoToolStripMenuItem.Text = "Xin Chào: "+ LoginAccount.Ten +" !";
        }

       

        private void mnuHoadon_Click(object sender, EventArgs e)
        {
            fHoadon f = new fHoadon();
            f.ShowDialog();
            this.Show();
        }

        private void mnuDoanhthu_Click(object sender, EventArgs e)
        {
            fDoanhthu f = new fDoanhthu();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fHethongchung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void capnhatTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMatkhau f = new fMatkhau(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void f_UpdateAccount(object sender, AccountEvent e)
        {
            xinchaoToolStripMenuItem.Text = "Xin Chào: " + e.Acc.Ten + " !";
        }

       

        private void đốiTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoitac f = new fDoitac(LoginAccount);
            f.ShowDialog();
            this.Show();
        }

        private void CapnhatloaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSanpham f = new fSanpham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
