using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public bool IsNumber(string pText)
        //{
        //    Regex regex = new Regex(@"^[-+]?[0 - 9] *\.?[0 - 9] +$");
        //    return regex.IsMatch(pText);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            btn_sum.Enabled = false;
            btn_max.Enabled = false;
            btn_delete.Enabled = false;
            lb_sum.Visible = false;
            lb_max.Visible = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Alt)
            {
                if(e.KeyCode.Equals(Keys.H))
                {
                    button2_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.L))
                {
                    button6_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.D))
                {
                    button1_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.X))
                {
                    button3_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.N))
                {
                    button4_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.A))
                {
                    button5_Click(null, null);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ret =
                MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int kt = 1;
            double a;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Hãy nhập số trước");
                kt = 0;
                textBox1.Focus();
            }
            if(kt == 1)
            {
                if (double.TryParse(textBox1.Text, out a) == false)
                {
                    MessageBox.Show("Phải nhập số!");
                    kt = 0;
                    textBox1.Focus();
                }
            }
            if(kt == 1)
            {
                listBox1.Items.Add(double.Parse(textBox1.Text));
                textBox1.Text = "";
                btn_sum.Enabled = true;
                btn_max.Enabled = true;
                btn_delete.Enabled = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int kt = 1;
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn 1 phần từ trong list");
                kt = 0;
            }
            if(kt == 1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            if(listBox1.Items.Count == 0)
            {
                btn_sum.Enabled = false;
                btn_max.Enabled = false;
                btn_delete.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double max = (double)listBox1.Items[0];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                max = max > (double)listBox1.Items[i] ? max : (double)listBox1.Items[i];
            }
            lb_max.Visible = true;
            lb_max.Text = "Max là: " + max.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double tong = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                tong += (double)listBox1.Items[i];
            }
            lb_sum.Visible = true;
            lb_sum.Text = "Tổng là: " + tong.ToString();
        }
    }
}
