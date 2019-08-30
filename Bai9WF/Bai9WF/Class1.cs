using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9WF
{
    class Class1
    {
            private string TenSach;
            private double GiaSach;
            private int SoLuong;
            private double ThanhTien;

            public Class1(string tenSach, double giaSach, int soLuong, double thanhTien)
            {
                TenSach = tenSach;
                GiaSach = giaSach;
                SoLuong = soLuong;
                ThanhTien = thanhTien;
            }

            public string TenSach1 { get => TenSach; set => TenSach = value; }
            public double GiaSach1 { get => GiaSach; set => GiaSach = value; }
            public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
            public double ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
    }
}
