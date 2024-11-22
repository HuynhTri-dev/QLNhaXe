using System;


namespace ConsoleApp1
{
    internal class Xe
    {
        private string bienSo;
        private DateTime ngaySanXuat;
        private string maTinh;

        public string BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }

        public DateTime NgaySanXuat
        {
            get { return ngaySanXuat; }
            set { ngaySanXuat = value; }
        }

        public string MaTinh
        {
            get { return maTinh; }
            set { maTinh = value; }
        }

        public Xe()
        {
        }

        public Xe(string bienSo, DateTime ngaySanXuat, string maTinh)
        {
            BienSo = bienSo;
            NgaySanXuat = ngaySanXuat;
            MaTinh = maTinh;
        }

        public virtual void ThongTinXe()
        {
            Console.WriteLine($"Bien so: {BienSo}\nNgày san xuat: {NgaySanXuat.ToString("dd/MM/yyyy")}\nMa tinh: {MaTinh}");
        }
    }
}
