using SonNumber.DAO;
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

namespace SonNumber
{
    public partial class fSanpham : Form
    {
        public fSanpham()
        {
            InitializeComponent();

            LoadSanpham();
            LoadMathang();
        }

        private void btnThoatDM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoathh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadSanpham()
        {
            string query = "exec dbo.USP_GetDanhmucByMadanhmuc @Madanhmuc ";

            dataGridViewDMHH.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"1"});

        }
        void LoadMathang()
        {
            string query = "select * from dbo.Mathang";
            dataGridViewMathang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
