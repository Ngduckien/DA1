using SonNumber.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonNumber.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
       public static AccountDAO Instance
        { 
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; } 
        }
        private AccountDAO() { }

        public bool Login(string tennguoidung, string matkhau) 
        {
            string query = "USP_Login @tennguoidung , @matkhau";
             DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {tennguoidung, matkhau});

            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string tennguoidung, string ten, string matkhau, string matkhaumoi)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @tennguoidung , @matkhau , @ten , @matkhaumoi", new object[] { tennguoidung, matkhau, ten, matkhaumoi });

            return result > 0;
        }
        public Account GetDangnhapByTennguoidung(string tennguoidung)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.Dangnhap where tennguoidung = '" + tennguoidung + "' ");
            foreach (DataRow  item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
    }
}
