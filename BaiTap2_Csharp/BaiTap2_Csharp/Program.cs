using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DsThiSinh a = new DsThiSinh();
            a.nhap();
            a.xuat();
            a.TrungTuyen();
            Console.ReadLine();
        }
    }
}
