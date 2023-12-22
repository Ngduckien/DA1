using SonNumber.DTO;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace SonNumber.DAO
{
    internal class DanhmucDAO
    {
        private static DanhmucDAO instance;

        public static DanhmucDAO Instance
        {
            get { if (instance == null) instance = new DanhmucDAO(); return DanhmucDAO.instance; }
            private set { DanhmucDAO.instance = value; }
        }
        private DanhmucDAO() { }

        public bool InsertDanhmuc(int Madanhmuc, string Tendanhmuc)
        {
            string query = string.Format("insert into dbo.Danhmuc (Madanhmuc, Tendanhmuc) values ({0}, N'{1}')", Madanhmuc, Tendanhmuc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateDanhmuc(int Madanhmuc, string Tendanhmuc )
        {
            string query = string.Format("UPDATE Danhmuc SET Madanhmuc = {0}, Tendanhmuc = N'{1}' WHERE Madanhmuc = {0}", Madanhmuc, Tendanhmuc);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteDanhmuc(int Madanhmuc)
        {
            string query = string.Format("DELETE Danhmuc WHERE Madanhmuc = {0}", Madanhmuc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Danhmuc> GetListDanhmuc()
        {
            List<Danhmuc> list = new List<Danhmuc>();
            string query = "select * from dbo.Danhmuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Danhmuc sanpham = new Danhmuc(item);
                list.Add(sanpham);
            }
            return list;
        }
        
      

       
    }
}
