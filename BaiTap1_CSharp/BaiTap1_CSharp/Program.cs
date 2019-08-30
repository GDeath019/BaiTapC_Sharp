using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số Căn Hộ: ");
            int n = int.Parse(Console.ReadLine());
            HinhChuNhat[] a = new HinhChuNhat[n];
            for(int i = 0; i<n;i++)
            {
                a[i] = new HinhChuNhat();
                Console.WriteLine("Nhập thông tin Căn Hộ thứ "+(i+1).ToString());
                a[i].nhap();
            }
            double[] DienTich = new double[n];
            double Max = a[1].TinhDienTich();
            for (int i = 0; i < n; i++)
            {
                DienTich[i] = new double();
                DienTich[i] = a[i].TinhDienTich();
                Max = Max > DienTich[i] ? Max : DienTich[i];
            }
            Console.WriteLine("Căn hộ có diện tích lớn nhất là: "+ Max.ToString());
            Console.WriteLine("Danh sách là: ");
            for (int i = 0; i < n; i++)
            {
                if(a[i].TinhDienTich() == Max)
                {
                    Console.WriteLine("Căn hộ thứ "+ i.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
