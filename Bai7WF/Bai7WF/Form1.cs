using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Bai7WF
{
    public partial class Form1 : Form
    {
        string arr_number;
        string[] number;
        int am = 0;
        int kt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            textBox1.Text = "";
            lb_ketqua.Visible = false;
            label2.Visible = false;
            comboBox1.Text = "";
            comboBox1.Items.Add("Trung bình cộng của dãy.");
            comboBox1.Items.Add("Đếm số phần tử âm.");
            comboBox1.SelectedIndex = -1;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                {
                    btn_close_Click(null, null);
                }
            }
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            double tong = 0;
            int dem = 0;
            int a;

            if (int.TryParse(textBox1.Text, out a) == false)
            {
                MessageBox.Show("Bạn cần nhập số");
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                arr_number = Interaction.InputBox("Nhập dãy số", "inputBox Nhập số", "", -1, -1);
                number = arr_number.Split(' ');

                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    label2.Visible = true;
                    label2.Text = "Dãy là: " + arr_number;
                    tong += double.Parse(number[i]);
                    if (double.Parse(number[i]) < 0)
                        am++;
                }

                comboBox1_SelectedIndexChanged(null, null);
                MessageBox.Show(kt.ToString());
                if (kt == 1)
                {
                    lb_ketqua.Visible = true;
                    lb_ketqua.Text = "trung bình cộng của dãy là: " + (tong / int.Parse(textBox1.Text)).ToString();

                }
                if (kt == 2)
                {
                    lb_ketqua.Visible = true;
                    lb_ketqua.Text = "số phàn tử âm là: " + am.ToString();
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                kt = 1;
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                kt = 2;
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lb_ketqua.Visible = false;
            comboBox1.SelectedIndex = -1;
            label2.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult ret =
                MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
