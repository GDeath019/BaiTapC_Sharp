using System;
using System.Windows.Forms;

namespace Bai3WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            comboBox1.Items.Add("Coca cola");
            comboBox1.Items.Add("Pepsi");
            comboBox1.Items.Add("Senven Up");
            for (int i = 1; i <= 10; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                    button2_Click(null, null);
                if (e.KeyCode.Equals(Keys.M))
                    button2_Click(null, null);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ret =
                MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (ret == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "";
            if (radioButton1.Checked == true)
            {
                a += textBox1.Text;
                a += " Cả Ngày " + textBox2.Text + "$";
                a += " | " + comboBox1.SelectedItem;
                a += " |Số lượng: " + comboBox2.SelectedItem + " " + textBox3.Text;
                a += " |Tổng:  " + (int.Parse(textBox2.Text) + int.Parse(textBox3.Text)).ToString();
                listBox1.Items.Add(a);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox2.Text = "200";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                textBox2.Text = "100";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { comboBox2.Text = "";
            textBox3.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                        int SoLuong = int.Parse(comboBox2.SelectedItem.ToString());
            if (comboBox1.SelectedItem == "Coca cola")
                textBox3.Text = (0.5 * SoLuong).ToString();
            if (comboBox1.SelectedItem == "Pepsi")
                textBox3.Text = (0.8 * SoLuong).ToString();
            if (comboBox1.SelectedItem == "Senven Up")
                textBox3.Text = (1 * SoLuong).ToString();
        }
    }
}
