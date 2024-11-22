using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "22/11/2024";
            DateTime ngaySanXuat = DateTime.ParseExact(input, "dd/MM/yyyy", null);
            Xe x1 = new Xe("123a-1", ngaySanXuat, "101");
            Oto oto1 = new Oto("123a-1", ngaySanXuat, "101", 1, 1);
            Tai tai1 = new Tai("123a-1", ngaySanXuat, "101", 0.5f);
            x1.ThongTinXe();
            oto1.ThongTinXe();
            tai1.ThongTinXe();
            Console.ReadKey();  
        }
    }
}
