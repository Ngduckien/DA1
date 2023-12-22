using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonNumber.DTO
{
    public class Hanghoa
    {

        //Mặt hàng
        public Hanghoa(int mahang, string tenhang, int madanhmuc, decimal gianhap, decimal giaban, int soluongton)
        {
            this.Mahang = mahang;
            this.Tenhang = tenhang;
            this.Madanhmuc = madanhmuc;
            this.Gianhap = gianhap;
            this.Giaban = giaban;
            this.Soluongton = soluongton;

        }
        public Hanghoa(DataRow row)
        {
            this.Mahang = (int)row["mahang"];
            this.Tenhang = row["tenhang"].ToString();
            this.Madanhmuc = (int)row["madanhmuc"];
            this.Gianhap = (decimal)row["gianhap"];
            this.Giaban = (decimal)row["giaban"];
            this.Soluongton = (int)row["soluongton"];
        }
        private int soluongton;
        private decimal giaban;
        private decimal gianhap;
        private int madanhmuc;
        private string tenhang;
        private int mahang;

        public int Mahang
        {
            get { return mahang; }
            set { mahang = value; }
        }

        public string Tenhang 
        {
            get { return tenhang; }
            set { tenhang = value; }
        }
        public int Madanhmuc
        {                 get { return madanhmuc; }
                set { madanhmuc = value; }
        }
        public decimal Gianhap
        {
            get { return gianhap; }
            set { gianhap = value; }
        }
        public decimal Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }
        public int Soluongton
        {
            get { return soluongton; }
            set { soluongton = value; }
        }

    }
}
