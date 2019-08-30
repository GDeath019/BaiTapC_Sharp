using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHoDem_Click(object sender, EventArgs e)
        {
            lblHoTen.Text= txtHoDem.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHovaTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHoDem.Text + " " + txtTen.Text;
        }

        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret =
                MessageBox.Show("Bạn có muốn thoát?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if(ret == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
