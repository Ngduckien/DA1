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

            LoginAccount = acc;
        }

        void changeAccount(int vaitro)
        {
            mnuDoanhthu.Enabled = vaitro == 1; 
            mnSanpham.Enabled = vaitro == 1;
            xinChàoToolStripMenuItem.Text += "" + LoginAccount.Ten + "!";
        }

        private void mnSanpham_Click(object sender, EventArgs e)
        {
            fSanpham f = new fSanpham();
            f.ShowDialog();
            this.Show();

        }

        private void mnuDoitac_Click(object sender, EventArgs e)
        {
            fDoitac f = new fDoitac(LoginAccount);
            f.ShowDialog();
            this.Show();
        }

        private void mnuHoadon_Click(object sender, EventArgs e)
        {
            fHoadon f = new fHoadon();
            f.ShowDialog();
            this.Show();
        }

        private void mnuDoanhthu_Click(object sender, EventArgs e)
        {
            fDoanhthu f =new fDoanhthu();
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
            f.UpdateAccount += F_UpdateAccount;
            f.ShowDialog();
            this.Show();
        }

        private void F_UpdateAccount(object sender, AccountEvent e)
        {
            xinChàoToolStripMenuItem.Text = "Xin Chào: " + e.Acc.Ten +" !";
        }
    }
}
