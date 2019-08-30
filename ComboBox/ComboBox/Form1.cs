using System;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Cbo_Main : Form
    {
        public Cbo_Main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Thông tin không được để trống.");
                textBox1.Focus();
            }
            else
            {
                listBox2.Items.Add("Thông tin khách hàng.");
               listBox2.Items.Add("Họ Tên: \n" + textBox1.Text);
                listBox2.Items.Add("Số điện thoại: \n" + textBox2.Text);
                listBox2.Items.Add("Sản phẩm đặt mua:\n" + listBox1.SelectedIndices);
                listBox2.Items.Add("Phương thức thanh toán: \n" + comboBox1.SelectedItem);
            }
        }
    }
}
