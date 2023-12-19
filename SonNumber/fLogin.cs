using SonNumber.DAO;
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
    public partial class fLogin : Form
    {
        

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tennguoidung = txbTaikhoan.Text;
            string matkhau = txbMatkhau.Text;
            if(Login (tennguoidung, matkhau))
            {
                Account loginAccout = AccountDAO.Instance.GetDangnhapByTennguoidung(tennguoidung);
                fHethongchung f = new fHethongchung(loginAccout);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
            }
            
        }

        bool Login(string tennguoidung, string matkhau )
        {
            return AccountDAO.Instance.Login(tennguoidung, matkhau);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
