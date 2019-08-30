using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ret
                = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                tb_gia.Text = "";
            }
            else if(comboBox1.SelectedIndex == 0)
            {
                tb_gia.Text = "22000";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                tb_gia.Text = "27000";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                tb_gia.Text = "25000";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                tb_gia.Text = "26000";
            }
        }

        private void rdo_TienMat_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_TienMat.Checked == true)
            {
                tb_GiamGia.Text = "5";
            }
        }

        private void rdo_ATM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_ATM.Checked == true)
                tb_GiamGia.Text = "10";        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
           int kt = 1;
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn loại sách");
                comboBox1.Focus();
                kt = 0;
            }
            if(tb_SoLunog.Text == "")
            {
                MessageBox.Show("Hãy Nhập số lượng mua");
                tb_SoLunog.Focus();
                kt = 0;
            }
            if(kt == 1)
            {
                
            }
        }
    }
}
