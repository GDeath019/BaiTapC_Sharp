using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai2WF
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            TB_MaKH.Text = "";
            Tb_HoTen.Text = "";
            Tb_DiaChi.Text = "";
            Tb_SoTienGui.Text = "";
            radio_Thuong.Checked = false;
            rdb_PhatLoc.Checked = false;
            cb_timeGui.Text = "";
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

        private void frm_Main_KeyUp(object sender, KeyEventArgs e)
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

            if (kt == 1)
            {
                double TienLai = 0;  
                if(radio_Thuong.Checked == true)
                {
                    if (cb_timeGui.SelectedItem.Equals(1)) ;
                        TienLai = int.Parse(Tb_SoTienGui.Text) * 0.06;
                    if (cb_timeGui.SelectedItem == "3")
                        TienLai = int.Parse(Tb_SoTienGui.Text) * 0.07;
                    if (cb_timeGui.SelectedItem == "6")
                        TienLai = int.Parse(Tb_SoTienGui.Text) * 0.08;
                    if (cb_timeGui.SelectedItem == "12")
                        TienLai = int.Parse(Tb_SoTienGui.Text) * 0.09;
                }
                else if(rdb_PhatLoc.Checked == true)
                {
                    if (cb_timeGui.SelectedItem == "1")
                        TienLai = int.Parse(Tb_SoTienGui.Text) * 0.07;
                    if (cb_timeGui.SelectedItem == "3")
                        TienLai = int.Parse(Tb_SoTienGui.Text) * 0.08;
                    if (cb_timeGui.SelectedItem == "6")
                        TienLai = int.Parse(Tb_SoTienGui.Text) * 0.09;
                    if (cb_timeGui.SelectedItem == "12")
                        TienLai = int.Parse(Tb_SoTienGui.Text) * 0.1;
                }
                string a = "";
                a = TB_MaKH.Text;
                a += " | " + Tb_HoTen.Text;
                a += " | " + Tb_DiaChi.Text;
                a += " | " + Dt_NgayGui.Text;
                a += " | " + Tb_SoTienGui.Text;
                a += " | " + cb_timeGui.SelectedItem.ToString();
                if(radio_Thuong.Checked == true)
                {
                    a += " | Thường";
                }
                if (rdb_PhatLoc.Checked == true)
                {
                    a += " | Phát Lộc";
                }
                a += " | " + TienLai;
                listB_View.Items.Add(a);
                if(radio_Thuong.Checked == true)
                listNguoiGuis.Add(new NguoiGui(TB_MaKH.Text, Tb_HoTen.Text, Tb_DiaChi.Text,Dt_NgayGui.Text, int.Parse(Tb_SoTienGui.Text),cb_timeGui.SelectedItem.ToString(),"Thường",TienLai));
                else if(rdb_PhatLoc.Checked == true)
                    listNguoiGuis.Add(new NguoiGui(TB_MaKH.Text, Tb_HoTen.Text, Tb_DiaChi.Text, Dt_NgayGui.Text, int.Parse(Tb_SoTienGui.Text), cb_timeGui.SelectedItem.ToString(), "Thường", TienLai));
                StaticDaTa._NguoiGui = listNguoiGuis;
            }
        }

        private void Tb_SoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            frm_TiemKiem frm = new frm_TiemKiem();
            frm.ShowDialog();
        }

        //private void TB_MaKH_MouseLeave(object sender, EventArgs e)
        //{
        //    if (TB_MaKH.TextLength < 6)
        //        MessageBox.Show("Mã Khách Hàng không được dưới 6 kí tự");
        //}
    } }
