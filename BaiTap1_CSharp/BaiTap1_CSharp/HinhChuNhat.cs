using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_CSharp
{
    class HinhChuNhat
    {
        private double chieudai;
        private double chieurong;
        public HinhChuNhat()
        {
            chieudai = 0;
            chieurong = 0;
        }
        public HinhChuNhat(double x, double y)
        {
            chieudai = x;
            chieurong = y;
        }
        public double Chieudai { get; set; }
        public double Chieurong { get; set; }
        public void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều dài: ");
            chieudai = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng: ");
            chieurong = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Chiều dài là: "+ chieudai.ToString());
            Console.WriteLine("Chiều rộng là: "+chieurong.ToString());
        }
        public double TinhDienTich()
        {
            return chieudai * chieurong;
        }
    }
}
