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
   
    public partial class fDoitac : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount.Vaitro); }
        }
        public fDoitac(Account acc)
        {
            InitializeComponent();
            LoadHangtong();
            LoadNhanvien();
            LoadKhachhang();
            LoginAccount = acc;
        }
        void changeAccount(int vaitro)
        {
            tabNhanvien.Enabled = vaitro == 1;
            
        }
        private void btnThoatKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoatht_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitnv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadHangtong()
        {
            string query = "select * from dbo.Hangtong";
            dataGridViewHangtong.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadNhanvien()
        {
            string query = "select * from dbo.Nhanvien";
            dataGridViewNhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadKhachhang()
        {
            string query = "select * from dbo.Khachhang";
            dataGridViewKhachhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
