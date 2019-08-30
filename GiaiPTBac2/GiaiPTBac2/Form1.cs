using System;
using System.Windows.Forms;

namespace GiaiPTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double delta = 0, a, b, c;
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Hãy nhập 3 hệ số!");
            }
            else
            {
                a = double.Parse(textBox1.Text);
                while (a == 0)
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    
                }

                listBox1.Items.Clear();
                if (textBox1.Text == "" || a == 0)
                    MessageBox.Show("Hệ số 1 không được để trống hoặc bằng 0.");
                if (!double.TryParse((textBox2.Text), out b))
                {
                    MessageBox.Show("Hãy Nhập số");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
                if (!double.TryParse((textBox3.Text), out c))
                {
                    MessageBox.Show("Hãy Nhập số");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    listBox1.Items.Add("Delta của phương trình là: " + delta.ToString());
                    listBox1.Items.Add("Phương trình vô nghiệm");
                }
                if (delta == 0)
                {
                    listBox1.Items.Add("Delta của phương trình là: " + delta.ToString());
                    listBox1.Items.Add("Phương trình có nghiệm kép: ");
                    double nghiem;
                    nghiem = -b / (2 * a);
                    listBox1.Items.Add("X =: " + nghiem.ToString());
                }
                if (delta > 0)
                {
                    double x1, x2;
                    x1 = Math.Round(((-(b) + Math.Sqrt(delta)) / (2 * a)), 2);
                    x2 = Math.Round(((-b) - Math.Sqrt(delta)) / (2 * a), 2);
                    listBox1.Items.Add("Delta của phương trình là: " + delta.ToString());
                    listBox1.Items.Add("X1:= " + x1);
                    listBox1.Items.Add("X2:= " + x2);
                }
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ret =
            MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(ret == DialogResult.OK)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
        }
    }
}
