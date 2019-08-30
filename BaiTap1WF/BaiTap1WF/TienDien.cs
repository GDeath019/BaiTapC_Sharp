namespace BaiTap1WF
{
    class TienDien
    {
        private string TenKH;
        private string MaKH;
        private string DiaChi;
        private string NgayChot;
        private int SoThangTruoc;
        private int SoThangNay;
        private double TienTra;
        public TienDien(string maKH, string tenKH, string diaChi, string ngayChot, int
        soThangTruoc, int soThangNay, double tienTra)
        {
            TenKH = tenKH;
            MaKH = maKH;
            DiaChi = diaChi;
            NgayChot = ngayChot;
            SoThangNay = soThangNay;
            SoThangTruoc = soThangTruoc;
            TienTra = tienTra;
        }
        public string tenKH
        {
            get { return TenKH; }
            set { TenKH = value; }
        }
        public string maKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public string diaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public int soThangTruoc
        {
            get { return SoThangTruoc; }
            set { SoThangTruoc = value; }
        }
        public int soThangNay
        {
            get { return SoThangNay; }
            set { SoThangNay = value; }
        }
        public string ngayChot
        {
            get { return NgayChot; }
            set { NgayChot = value; }
        }

        public double tienTra
        {
            get { return TienTra; }
            set { TienTra = value; }
        }

    }
}
