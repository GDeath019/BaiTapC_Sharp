using System;
using System.Collections.Generic;
using System.Windows.Forms;
//dzo
namespace BaiTap1WF
{
    public partial class frm_TienDien : DevExpress.XtraEditors.XtraForm
    {
        List<TienDien> listTienDiens = new List<TienDien>();
        public frm_TienDien()
        {
            InitializeComponent();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult ret =
                MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            TB_MaKH.Text = "";
            Tb_HoTen.Text = "";
            Tb_DiaChi.Text = "";
            tb_SoThangTruoc.Text = "";
            tb_SoThangNay.Text = "";
            TB_MaKH.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                    btn_Thoat_Click(null, null);
                if (e.KeyCode.Equals(Keys.M))
                {
                    btn_ThemMoi_Click(null, null);
                }
            }
        }

        private void lb_MaKH_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (TB_MaKH.TextLength < 6 || TB_MaKH.Text == "")
            {
                MessageBox.Show("Mã khách hàng không được để chống hoặc nhỏ hơn 6 kí tự");
                TB_MaKH.Text = "";
                TB_MaKH.Focus();
                kt = 0;
            }
            else
                        if (Tb_DiaChi.Text == "")
            {
                MessageBox.Show("Địa Chỉ không được để trống");
                Tb_HoTen.Focus();
                kt = 0;
            }
            else
            if (Tb_HoTen.Text == "")
            {
                MessageBox.Show("Tên Khách Hàng không được để trống");
                Tb_DiaChi.Focus();
                kt = 0;
            }
            else if (tb_SoThangTruoc.Text == "")
            {
                MessageBox.Show("Số Điện Tháng Trước không được để trống");
                tb_SoThangTruoc.Focus();
                kt = 0;
            }
            else if(tb_SoThangNay.Text == "")
            {
                MessageBox.Show("Số Điện Tháng Này không được để trống");
                tb_SoThangNay.Focus();
                kt = 0;
            }
            else if (int.Parse(tb_SoThangTruoc.Text) > int.Parse(tb_SoThangNay.Text))
            {
                MessageBox.Show("Số tháng trước phải nhỏ hơn số tháng này.");
                tb_SoThangTruoc.Text = "";
                tb_SoThangNay.Text = "";
                tb_SoThangTruoc.Focus();
                kt = 0;
            }

            if (kt == 1)
            {
                double TienDien = 0;
                int SoDien = int.Parse(tb_SoThangNay.Text) - int.Parse(tb_SoThangTruoc.Text);
                if (SoDien <= 50)
                {
                    TienDien += SoDien * 100;
                }
                else if (SoDien <= 100)
                {
                    TienDien += (SoDien - 50) * 200 + 50 * 100;
                }
                else if (SoDien <= 200)
                {
                    TienDien += 50 * 100 + 50 * 200 + (SoDien - 100) * 300;
                }
                else if (SoDien > 200)
                {
                    TienDien += 50 * 100 + 50 * 200 + 100 * 300 + (SoDien - 200) * 4;
                }
                TienDien = TienDien + TienDien * 0.1;
                string a = "";
                a = TB_MaKH.Text;
                a += " | " + Tb_HoTen.Text;
                a += " | " + Tb_DiaChi.Text;
                a += " | " + Dt_NgayChotSo.Text;
                a += " | " + tb_SoThangTruoc.Text;
                a += " | " + tb_SoThangNay.Text;
                a += " | " + TienDien;
                listB_View.Items.Add(a);
                listTienDiens.Add(new TienDien(TB_MaKH.Text,
                Tb_HoTen.Text, Tb_DiaChi.Text, Dt_NgayChotSo.Text, Convert.ToInt32(tb_SoThangTruoc.Text),
                int.Parse(tb_SoThangNay.Text), TienDien));
                StaticDaTa._TienDien = listTienDiens;
            }
        }
        private void tb_SoThangTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }
        private void tb_SoThangNay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            frm_TimKiem frm = new frm_TimKiem();
            frm.ShowDialog();
        }
    }
}
