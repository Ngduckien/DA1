using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SonNumber.DTO
{ 
    public class Account
    {
        public Account(string tennguoidung, string ten, int vaitro, string matkhau = null) 
        {
            this.Tennguoidung = tennguoidung;
            this.Ten = ten;
            this.Vaitro = vaitro;
            this.Matkhau = matkhau;
        }
        public Account(DataRow row)
        {
            this.Tennguoidung = row["tennguoidung"].ToString();
            this.Ten = row["ten"].ToString();
            this.Vaitro = (int)row["vaitro"];
            this.Matkhau = row["matkhau"].ToString();
        }
        private int vaitro;
        public int Vaitro
        {
            get { return vaitro; }
            set { vaitro = value; }
        }

        private string ten;
        public string Ten
        {
            get { return ten;}
            set { ten = value; }
        }


        private string matkhau;
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value;} 
        }


        private string tennguoidung;
        public string Tennguoidung
        {
            get { return tennguoidung; }
            set { tennguoidung = value; } 
        }

         
    }
}
