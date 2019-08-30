using System;
using System.Windows.Forms;

namespace ThucHanh1_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (textBox1.Text == "")
            {
                MessageBox.Show("a không được để trống!");
                textBox1.Focus();
                kt = 0;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("b không được để trống!");
                kt = 0;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("c không được để trống");
                kt = 0;
            }
            if (kt == 1)
            {
                if (IsNumber(textBox1.Text) == false || IsNumber(textBox2.Text) == false || IsNumber(textBox3.Text) == false )
                {
                    MessageBox.Show("Phải nhập số nguyên!");
                    textBox1.Focus();
                    kt = 0;
                }
            if(kt == 1)
                {
                    double delta = 0;
                    int a, b, c;
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    c = int.Parse(textBox3.Text);
                    delta = b * b - 4 * a * c;
                    if(delta < 0)
                    {
                        textBox4.Text = "Phương trình vô nghiệm.";
                    }
                    if(delta == 0)
                    {
                        textBox4.Text = "Phương trình có nghiệm kép.";
                    }
                    if(delta > 0)
                    {
                        textBox4.Text = "Phương trình có 2 nghiệm phân biệt.";
                    }
                }
            }
        }
    }
}