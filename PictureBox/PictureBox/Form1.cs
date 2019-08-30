using System;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ret =
            MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == false)
            {
                button2.Text = "Mời " + textBox1.Text + " Nhấn nút để bật đèn!!!";
            }
            else
            {
                button2.Text = "Mời " + textBox1.Text + " Nhấn nút để tắt đèn!!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == false)
            {

                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                button2.Text = button2.Text.Replace("bật", "tắt");
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                button2.Text = button2.Text.Replace("tắt", "bật");
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
