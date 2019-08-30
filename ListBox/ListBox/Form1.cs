using System;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double x = double.Parse(textBox1.Text);
                listBox1.Items.Add(x);
            }
            else
            {
                MessageBox.Show("Bạn phải nhập một giá trị trước", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tong = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                tong += (double)listBox1.Items[i];
            }
            MessageBox.Show("Tổng của list là: " + tong, "Thông Báo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                MessageBox.Show("Trong list không có phần tử nào.");
            else if (listBox1.Items.Count == 1)
            {
                MessageBox.Show("Trong list chỉ còn một phần tử. Không thể xóa.");
            }
            else
            {
                listBox1.Items.RemoveAt(0);
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                MessageBox.Show("Xóa phần tử đầu và cuối thành công.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("Xóa phần tử đã chọn thành công.");
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 phần tử trong list!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (listBox1.Items.Count > 0)
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.Items[i] = (double)listBox1.Items[i] + 2;
                }
            else
            {
                MessageBox.Show("Trong list không có phần tử nào.");
                check = false;
            }
            if (check == true)
            {
                MessageBox.Show("Tăng thành công.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (listBox1.Items.Count > 0)
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.Items[i] = Math.Pow((double)listBox1.Items[i], 2);

                }
            else
            {
                MessageBox.Show("Trong list không có phần tử nào.");
                check = false;
            }
            if (check == true)
            {
                MessageBox.Show("Tăng thành công.");
            }
        }
    }
}
