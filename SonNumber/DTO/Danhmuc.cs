using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonNumber.DTO
{
    internal class Danhmuc
    {
        public Danhmuc(int madanhmuc, string tendanhmuc)
        {
            this.Madanhmuc = madanhmuc;
            this.Tendanhmuc = tendanhmuc;
        }
        public Danhmuc(DataRow row)
        {
            this.Madanhmuc = (int)row["madanhmuc"];
            this.Tendanhmuc = row["tendanhmuc"].ToString();
        }
        private int madanhmuc;
        private string tendanhmuc;
        public int Madanhmuc { get => madanhmuc; set => madanhmuc = value; }    
        public string Tendanhmuc { get => tendanhmuc; set => tendanhmuc = value; }
    }
}
