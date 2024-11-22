using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Oto : Xe
    {
        private int soChoNgoi;
        private int dangKyKinhDoanh;

        public int SoChoNgoi
        {
            get { return soChoNgoi; }
            set { soChoNgoi = value; }
        }

        public int DangKyKinhDoanh
        {
            get { return dangKyKinhDoanh; }
            set { if (dangKyKinhDoanh == 1 || dangKyKinhDoanh == 0) 
                  {
                    dangKyKinhDoanh = value;
                  }  
                }
        }

        public Oto() : base()
        {
        }

        public Oto(string bienSo, DateTime ngaySanXuat, string maTinh, int soChoNgoi, int dangKyKinhDoanh) : base(bienSo, ngaySanXuat, maTinh)
        {

      
            SoChoNgoi = soChoNgoi;
            DangKyKinhDoanh = dangKyKinhDoanh;  
        }

        public override void ThongTinXe()
        {
            base.ThongTinXe();
            string dangKy = (DangKyKinhDoanh == 1) ? "Co" : "Khong";
            Console.WriteLine($"So cho ngoi: {SoChoNgoi}\nDang ký kinh doanh: {dangKy}");
        }
    }
}
