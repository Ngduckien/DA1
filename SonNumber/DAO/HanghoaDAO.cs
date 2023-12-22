using SonNumber.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonNumber.DAO
{
    public class HanghoaDAO
    {
       private static HanghoaDAO instance;

        public static HanghoaDAO Instance 
        { 
            get { if (instance == null) instance = new HanghoaDAO() ; return HanghoaDAO.instance; } 
            private  set { HanghoaDAO.instance = value; }
        }
        private HanghoaDAO() { }

        
       public List<Hanghoa> GetListHanghoa()
        {
            List<Hanghoa> list = new List<Hanghoa>();
            string query = "select * from dbo.Mathang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Hanghoa hanghoa = new Hanghoa(item);
                list.Add(hanghoa);
            }

                return list;
        }
        public Hanghoa GetListIdHanghoa(int Madanhmuc)
        {
            Hanghoa hh = null;
            string query = "select * from Mathang where Madanhmuc = " + Madanhmuc;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                hh = new Hanghoa(item);

            }
            return hh;
        }
        public bool InsertHanghoa(int Mahang, int Madanhmuc, string Tenhang, decimal Gianhap, decimal Giaban, int Soluongton)
        {
            string query = string.Format("INSERT INTO Mathang(Mahang,Madanhmuc,Tenhang,Gianhap,Giaban,Soluongton)VALUES({0},{1},N'2',{3},{4},{5})",Mahang, Madanhmuc, Tenhang, Gianhap, Giaban, Soluongton);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
