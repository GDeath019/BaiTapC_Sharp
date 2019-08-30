using System;
using System.Text;

namespace BaiTap2_Csharp
{
    class ThiSinh
    {
        private string SBD;
        private string HoTen;
        private double Toan;
        private double Ly;
        private double Hoa;
        public ThiSinh()
        {
            SBD = "";
            HoTen = "";
            Toan = 0;
            Ly = 0;
            Hoa = 0;
        }
        public double toan { get; set; }
        public double ly { get; set; }
        public double hoa { get; set; }
        public void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số báo danh: ");
            SBD = Console.ReadLine();
            Console.WriteLine("Nhập Họ Tên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập điểm Toán: ");
            Toan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm Lý: ");
            Ly = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm Hóa: ");
            Hoa = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Số báo danh: "+SBD);
            Console.WriteLine("Họ Tên: "+HoTen);
            Console.WriteLine("Nhập điểm Toán: "+Toan.ToString());
            Console.WriteLine("Nhập điểm Lý: "+Ly.ToString());
            Console.WriteLine("Nhập điểm Hóa: "+Hoa.ToString());
        }
        public double TongDiem()
        {
            return Toan + Ly + Hoa;
        }
    }
    class TuyenSinh : ThiSinh
    {
        private int KhuVuc;
        public int khuvuc { get; set; }
        public void NhapKhuVuc()
        {
            base.nhap();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập Mã Khu Vực: ");
            KhuVuc = int.Parse(Console.ReadLine());
        }
        public void XuatKhuVuc()
        {
            base.xuat();
            Console.WriteLine("Mã Khu Vực: "+KhuVuc.ToString());
        }
        public double DiemUuTien()
        {
            if (KhuVuc == 1)
                return base.TongDiem();
            else if (KhuVuc == 2)
                return base.TongDiem() + 1;
            else if (KhuVuc == 3)
                return base.TongDiem() + 2;
            else return 0;
        }
    }
    public class DsThiSinh
    {
        private int n;
        private TuyenSinh[] a;
        public DsThiSinh()
        {
            n = 0;
            a = null;
        }
        public void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số sinh viên: ");
            n = int.Parse(Console.ReadLine());
            a = new TuyenSinh[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập sinh viên thứ " + (i + 1).ToString());
                a[i] = new TuyenSinh();
                a[i].NhapKhuVuc();
            }
        }
        public void xuat() {
            Console.WriteLine("Danh sách Sinh viên là: ");
            for (int i = 0; i < n; i++)
            {
                a[i].XuatKhuVuc();
            } }
        public void TrungTuyen()
        {
            double DiemChuan = 0;
            Console.WriteLine("Nhập Điểm Chuẩn: ");
            DiemChuan = double.Parse(Console.ReadLine());
            Console.WriteLine("Diểm chuẩn là: " + DiemChuan.ToString());
            Console.WriteLine("Danh sách trúng tuyển là: ");
            for (int i = 0; i < n; i++)
            {
                if (a[i].DiemUuTien() == DiemChuan)
                {
                    a[i].XuatKhuVuc();
                }
            }
        }
    }
}