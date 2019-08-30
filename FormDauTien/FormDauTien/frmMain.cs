using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class APP : Form
    {
        public APP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void APP_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void APP_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void APP_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            button1.Text = "Đổi Màu Rồi";
        }

        private void APP_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(" Bạn chọn đóng cửa sổ");
        }
    }
}
