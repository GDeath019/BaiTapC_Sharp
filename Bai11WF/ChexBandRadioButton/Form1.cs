using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChexBandRadioButton
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
                MessageBox.Show("Bạn có muốn thoát.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (ret == DialogResult.OK)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.ForeColor = radioButton1.ForeColor;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox1.ForeColor = radioButton2.ForeColor;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                textBox1.ForeColor = radioButton4.ForeColor;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Bold);
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Italic);
            }
            else if (checkBox2.CheckState == CheckState.Unchecked)
            {
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Underline);
            }
            else if (checkBox3.CheckState == CheckState.Unchecked)
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                FontFamily f = new FontFamily(".VnTime");
                textBox1.Font = new Font(f, textBox1.Font.Size);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                FontFamily f = new FontFamily(".VnTimeH");
                textBox1.Font = new Font(f, textBox1.Font.Size);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                FontFamily f = new FontFamily(".VnArial");
                textBox1.Font = new Font(f, textBox1.Font.Size);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                FontFamily f = new FontFamily(".VnArialH");
                textBox1.Font = new Font(f, textBox1.Font.Size);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                FontFamily f = new FontFamily(".VnUniverse");
                textBox1.Font = new Font(f, textBox1.Font.Size);
            }
            if (comboBox1.SelectedIndex == 5)
            {
                FontFamily f = new FontFamily(".VnUniverseH");
                textBox1.Font = new Font(f, textBox1.Font.Size);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Microsoft Sans Serif", 8.5f);
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton4.Checked = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, int.Parse(comboBox2.SelectedItem.ToString()));
        }
    }
}

