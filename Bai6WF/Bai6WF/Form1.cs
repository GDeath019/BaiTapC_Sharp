using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void random(ListBox a)
        {
            double[] x = new double[3];
            Random rd = new Random();
            for (int i = 0; i < 3; i++)
            {
                x[i] = rd.Next(1, 100);
                a.Items.Add(x[i]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            btn_delete.Enabled = false;
            lb_Max.Visible = false;
            tb_Nhap.Text = "";
            random(listBox1);
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
            lb_Max.Visible = false;
            tb_Nhap.Text = "";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Alt)
            {
                if(e.KeyCode.Equals(Keys.L))
                {
                    btn_refesh_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.H))
                {
                    btn_close_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.T))
                {
                    btn_add_Click(null, null);
                }
                if(e.KeyCode.Equals(Keys.X))
                {
                    btn_delete_Click(null, null);
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult ret
                = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult ret
            = MessageBox.Show("Bạn có muốn xóa phần tử không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(ret == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double a;
            int kt = 1;
            if(double.TryParse(tb_Nhap.Text, out a) == false)
            {
                MessageBox.Show("Bạn cần nhận số.");
                tb_Nhap.Focus();
                kt = 0;
            }
            if(kt == 1)
            {
                listBox1.Items.Add(double.Parse(tb_Nhap.Text));
                tb_Nhap.Text = "";
                tb_Nhap.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                btn_delete.Enabled = true;
            }
            else if(listBox1.SelectedIndex == -1)
            {
                btn_delete.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double max = (double)listBox1.Items[0];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                max = max > (double)listBox1.Items[i] ? max : (double)listBox1.Items[i];
            }
            lb_Max.Visible = true;
            lb_Max.Text = "Giá trị lớn nhât của dãy là: " + max.ToString();
        }
    }
}
