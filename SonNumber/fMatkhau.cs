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
    public partial class fMatkhau : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount); }
        }
        public fMatkhau(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void changeAccount(Account acc) 
        {
            txbTendn.Text = LoginAccount.Tennguoidung;
            txbTennguoisudung.Text = LoginAccount.Ten;
        }
        void UpdateAccountInfo()
        {

            string ten = txbTennguoisudung.Text;
            string matkhau = txbMKcu.Text;
            string matkhaumoi = txbMKmoi.Text;
            string nhaplaiMKmoi = txbNhaplaiMKmoi.Text;
            string tennguoidung = txbTendn.Text;

            if (!matkhaumoi.Equals(nhaplaiMKmoi))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu giống mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(tennguoidung, ten, matkhau, matkhaumoi))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetDangnhapByTennguoidung(tennguoidung)));

                    }
                }
                else
                {
                    MessageBox.Show("vui lòng điền đúng mật khẩu!");
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }

    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public AccountEvent(Account acc)
        { 
            this.Acc = acc; 
        }
    }
}
