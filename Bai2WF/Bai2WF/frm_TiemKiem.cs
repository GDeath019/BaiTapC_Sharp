using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2WF
{
    public partial class frm_TiemKiem
    {
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
        public frm_TiemKiem()
        {
            InitializeComponent();
            listNguoiGuis = StaticDaTa._NguoiGui;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int timkiem = 0;
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.MaKH1 == textBox1.Text)
                {
                    listBox1.Visible = true;
                    timkiem = 1;
                    MessageBox.Show("Tìm Thấy");
                    listBox1.Items.Add("Thông Tin");
                    listBox1.Items.Add("Mã Khách Hàng: " + i.MaKH1);
                    listBox1.Items.Add("Tên Khách Hàng: " + i.TenKH1);
                    listBox1.Items.Add("Số Tiền Lãi: " + i.TienLai1.ToString());

                }

            }
            if (timkiem == 0)
                MessageBox.Show("Không Tìm Thấy Khách Hàng có Mã:  " + textBox1.Text);
        }

        private void frm_TiemKiem_Load(object sender, EventArgs e)
        {

        }
    }
}