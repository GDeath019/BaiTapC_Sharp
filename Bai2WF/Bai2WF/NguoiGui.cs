using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2WF
{
    class NguoiGui
    {
        private string TenKH;
        private string MaKH;
        private string DiaChi;
        private string NgayGui;
        private int SoTienGui;
        private string ThoiGianGui;
        private string LoaiGui;
        private double TienLai;

        public NguoiGui(string tenKH, string maKH, string diaChi, string ngayGui, int soTienGui, string thoiGianGui, string loaiGui, double tienLai)
        {
            TenKH = tenKH;
            MaKH = maKH;
            DiaChi = diaChi;
            NgayGui = ngayGui;
            SoTienGui = soTienGui;
            ThoiGianGui = thoiGianGui;
            LoaiGui = loaiGui;
            TienLai = tienLai;
        }

        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string NgayGui1 { get => NgayGui; set => NgayGui = value; }
        public int SoTienGui1 { get => SoTienGui; set => SoTienGui = value; }
        public string ThoiGianGui1 { get => ThoiGianGui; set => ThoiGianGui = value; }
        public string LoaiGui1 { get => LoaiGui; set => LoaiGui = value; }
        public double TienLai1 { get => TienLai; set => TienLai = value; }
    }
}
