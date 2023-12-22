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

            LoginAccount = acc;
            LoadHangtong();
            LoadNhanvien();
            LoadKhachhang();
            AddNguoiBinding();
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
        void AddNguoiBinding()
        {
            //Khách hàng
            txbMakh.DataBindings.Add(new Binding("text", dataGridViewKhachhang.DataSource, "MaKH"));
            txbTenKH.DataBindings.Add(new Binding("text", dataGridViewKhachhang.DataSource, "TenKH"));
            txbSDTkhachhang.DataBindings.Add(new Binding("text", dataGridViewKhachhang.DataSource, "SoDT"));
            txbDiachiKH.DataBindings.Add(new Binding("text", dataGridViewKhachhang.DataSource, "Diachi"));
            //Hãng tổng
            txbmaht.DataBindings.Add(new Binding("text", dataGridViewHangtong.DataSource, "Mahangtong"));
            txbTenht.DataBindings.Add(new Binding("text", dataGridViewHangtong.DataSource, "Tenhangtong"));
            txbSDTht.DataBindings.Add(new Binding("text", dataGridViewHangtong.DataSource, "SoDT"));
            txbDiachiht.DataBindings.Add(new Binding("text", dataGridViewHangtong.DataSource, "Diachi"));
            //Nhân viên
            txbManv.DataBindings.Add(new Binding("text", dataGridViewNhanvien.DataSource, "MaNV"));
            txbTennv.DataBindings.Add(new Binding("text", dataGridViewNhanvien.DataSource, "TenNV"));
            txbSDTnv.DataBindings.Add(new Binding("text", dataGridViewNhanvien.DataSource, "SoDT"));
            txbDiachinv.DataBindings.Add(new Binding("text", dataGridViewNhanvien.DataSource, "Diachi"));
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
