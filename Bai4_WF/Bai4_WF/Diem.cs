using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_WF
{
    class Diem
    {
        private string TenMonHoc;
        private int SoTinChi;
        private double DiemSo;

        public Diem(string tenMonHoc, int soTinChi, double diemSo)
        {
            TenMonHoc = tenMonHoc;
            SoTinChi = soTinChi;
            DiemSo = diemSo;
        }

        public string TenMonHoc1 { get => TenMonHoc; set => TenMonHoc = value; }
        public int SoTinChi1 { get => SoTinChi; set => SoTinChi = value; }
        public double DiemSo1 { get => DiemSo; set => DiemSo = value; }
    }
}
