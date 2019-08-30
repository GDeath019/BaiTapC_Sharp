using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int kt = 1;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Hãy nhập số");
                kt = 0;
                textBox1.Focus();
                textBox1.Text = "";
            }else
            if(int.TryParse(textBox1.Text, out a) == false)
            {
                MessageBox.Show("Bạn cần nhập số nguyên");
                textBox1.Focus();
                textBox1.Text = "";
                kt = 0;
            }
            if(kt == 1)
            {
                listBox1.Items.Add(double.Parse(textBox1.Text));
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1 )
            {
                MessageBox.Show("Bạn cần chọn một phần tử");
            }
            else
            {
                DialogResult ret =
                MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (ret == DialogResult.Yes)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
               listBox1.Items[i] = (double)listBox1.Items[i] + 3;
            }
            else
            {
                MessageBox.Show("Dãy không có phần tử nào");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (listBox1.Items.Count < 0)
            {
                MessageBox.Show("Dãy không có phần tử nào");
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if ((double)listBox1.Items[i] % 2 == 0)
                    {
                        listBox1.SelectedIndex = i;
                        check++;
                        break;
                    }
                }
                if (check == 0)
                {
                    MessageBox.Show("Dãy không có phần tử chẵn nào");
                }
            }
        }
    }
}
