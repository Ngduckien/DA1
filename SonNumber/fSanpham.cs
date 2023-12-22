using SonNumber.DAO;
using SonNumber.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace SonNumber
{
    public partial class fSanpham : Form
    {
        public fSanpham()
        {
            InitializeComponent();
            Load();

        }
        void Load()
        {
            LoadHanghoa();
            LoadDanhmuc();
            AddHanghoaBinding();
            AddDanhmucBinding();
           
        }
        

        void LoadDanhmuc()
        {
            dataGridViewDMHH.DataSource = DanhmucDAO.Instance.GetListDanhmuc();

        }
        void AddDanhmucBinding()
        {
            txbMaDM.DataBindings.Add(new Binding("text", dataGridViewDMHH.DataSource, "Madanhmuc"));
            txbTenDM.DataBindings.Add(new Binding("text", dataGridViewDMHH.DataSource, "Tendanhmuc"));

        }

        void LoadHanghoa()
        {
            dataGridViewMathang.DataSource = HanghoaDAO.Instance.GetListHanghoa();
        }
       
        void AddHanghoaBinding()
        {
            //Hàng hóa
            txbMahh.DataBindings.Add(new Binding("text", dataGridViewMathang.DataSource, "Mahang"));
            txbTenHH.DataBindings.Add(new Binding("text", dataGridViewMathang.DataSource, "Tenhang"));
            txbTendanhmuchh.DataBindings.Add(new Binding("text", dataGridViewMathang.DataSource, "Madanhmuc"));
            txbGiaban.DataBindings.Add(new Binding("text", dataGridViewMathang.DataSource, "Giaban"));
            txbGianhap.DataBindings.Add(new Binding("text", dataGridViewMathang.DataSource, "Gianhap"));
            txbSoluong.DataBindings.Add(new Binding("text", dataGridViewMathang.DataSource, "Soluongton"));
        }
        
        private void btnThoatDM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoathh_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnThemDM_Click(object sender, EventArgs e)
        {
            int Madanhmuc =  int.Parse(txbMaDM.Text);
            string Tendanhmuc = txbTenDM.Text;
            if (DanhmucDAO.Instance.InsertDanhmuc(Madanhmuc, Tendanhmuc))
            { 
                MessageBox.Show("Thêm thành công!");
                LoadDanhmuc();

            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
            
        }

        private void btnThemhh_Click(object sender, EventArgs e)
        {
            int Mahang = int.Parse(txbMahh.Text);
            int Madanhmuc = int.Parse(txbTendanhmuchh.Text);
            string Tenhang = txbTenHH.Text;
            decimal Gianhap = decimal.Parse(txbGianhap.Text);
            decimal Giaban = decimal.Parse(txbGiaban.Text);
            int Soluongton = int.Parse(txbSoluong.Text);
            if(HanghoaDAO.Instance.InsertHanghoa(Mahang, Madanhmuc, Tenhang, Gianhap, Giaban, Soluongton))
            {
                MessageBox.Show("Thêm thành công!");
                LoadHanghoa();
               
            }    
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            int Madanhmuc = int.Parse(txbMaDM.Text);
            string Tendanhmuc = txbTenDM.Text;
           
            if (DanhmucDAO.Instance.UpdateDanhmuc(Madanhmuc, Tendanhmuc))
            {
                MessageBox.Show("Sửa thành công!");
                LoadDanhmuc();
               
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            int Madanhmuc = int.Parse(txbMaDM.Text);
            if(DanhmucDAO.Instance.DeleteDanhmuc(Madanhmuc))
            {
                MessageBox.Show("Đã xóa thành công!");
                LoadDanhmuc();
                
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }
    }
}
