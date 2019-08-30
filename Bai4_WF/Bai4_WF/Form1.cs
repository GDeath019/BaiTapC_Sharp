using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai4_WF
{
    public partial class Form1 : Form
    {
        List<Diem> Diems = new List<Diem>();
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0 - 9] *\.?[0 - 9] +$");
            return regex.IsMatch(pText);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            comboBox1.Items.Add("Tin học đại cương");
            comboBox1.Items.Add("Giải tích F1");
            comboBox1.Items.Add("Tiếng anh A0");
            comboBox1.Items.Add("Triết học Mac - Lenin");
            comboBox1.Items.Add("Vật lý F1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ret =
                MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                {
                    button3_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.D))
                {
                    button1_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.T))
                {
                    button2_Click(null, null);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Tin học đại cương")
                textBox1.Text = "2";
            if (comboBox1.SelectedItem == "Giải tích F1")
                textBox1.Text = "3";
            if (comboBox1.SelectedItem == "Tiếng anh A0")
                textBox1.Text = "3";
            if (comboBox1.SelectedItem == "Triết học Mac - Lenin")
                textBox1.Text = "2";
            if (comboBox1.SelectedItem == "Vật lý F1")
                textBox1.Text = "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kt = 1;
            double x;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Bạn phải chọn môn học trước.");
                kt = 0;
            }else
            if (textBox3.Text == "")
            {
                MessageBox.Show("Hãy nhập Điểm.");
                textBox3.Focus();
                kt = 0;
            }
            else
            if (double.TryParse(textBox3.Text, out x) == false)
            {
                MessageBox.Show("Điểm phải nhập kiểu số.");
                textBox3.Focus();
                kt = 0;
            }
            if (kt == 1)
            {
                string a = "";
                a += "Tên Môn: " + comboBox1.SelectedItem;
                a += " | Số tín chỉ: " + textBox1.Text;
                a += " | Điểm: " + textBox3.Text;
                listBox1.Items.Add(a);
                Diems.Add(new Diem(comboBox1.SelectedItem.ToString(), int.Parse(textBox1.Text), double.Parse(textBox3.Text)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int TongSoTinChi = 0;
            double TongDiem = 0;
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống. Bạn hãy nhập Môn Học.");
            }

            else
            {

                foreach (Diem item in Diems)
                {
                    TongSoTinChi += item.SoTinChi1;
                    TongDiem += (item.DiemSo1 * item.SoTinChi1);
                }
            }
            textBox2.Text = TongSoTinChi.ToString();
            textBox4.Text = TongDiem.ToString();
            textBox5.Text =(TongDiem / TongSoTinChi).ToString();
            textBox5.MaxLength = 3;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
