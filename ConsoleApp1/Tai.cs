using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tai : Xe
    {
        private float trongTai;

        public float TrongTai
        {
            get { return trongTai; }
            set { trongTai = value; }
        }

        // Constructor mặc định
        public Tai() : base()
        {
        }

        // Constructor có tham số
        public Tai(string bienSo, DateTime ngaySanXuat, string maTinh, float trongTai)
            : base(bienSo, ngaySanXuat, maTinh)
        {
            this.trongTai = trongTai;
        }

        public override void ThongTinXe()
        {
            base.ThongTinXe();
            Console.WriteLine($"Trong tai: {TrongTai} tan");
        }
    }
}
