using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class SwitchProjectWinForms : Form
    {
        public SwitchProjectWinForms()
        {
            InitializeComponent();
        }

        private void SwitchProjectWinForms_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A;
            if (!int.TryParse(textBox1.Text, out A))
            {
                MessageBox.Show("New number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // A = int.Parse(textBox1.Text, out A);
            if (A < 1 || A > 7)
            {
                MessageBox.Show("New number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (A == 1)
            {
                label1.Text = "Понедеьник ";
            }
            if (A == 2)
            {
                label1.Text = " Вторник ";
            }
            if (A == 3)
            {
                label1.Text = "Среда";
            }
            if (A == 4)
            {
                label1.Text = "Четверг";
            }
            if (A == 5)
            {
                label1.Text = "Пятница ";
            }
            if (A == 6)
            {
                label1.Text = "Субота ";
            }
            if (A == 7)
            {
                label1.Text = "Воскресенье";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int B;
            if (!int.TryParse(textBox2.Text, out B))
            {
                MessageBox.Show("New number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // A = int.Parse(textBox1.Text, out A);
            if (B < 1 || B > 12)
            {
                MessageBox.Show("New number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (B == 1)
            {
                label2.Text = "Январь ";
            }
            if (B == 2)
            {
                label2.Text = "Февраль ";
            }
            if (B == 3)
            {
                label2.Text = "Март ";
            }
            if (B == 4)
            {
                label2.Text = "Апрель ";
            }
            if (B == 5)
            {
                label2.Text = "Май ";
            }
            if (B == 6)
            {
                label2.Text = "Июнь ";
            }
            if (B == 7)
            {
                label2.Text = "Июль ";
            }
            if (B == 8)
            {
                label2.Text = "Август ";
            }
            if (B == 9)
            {
                label2.Text = "Сентябрь ";
            }
            if (B == 10)
            {
                label2.Text = "Октябрь ";
            }
            if (B == 11)
            {
                label2.Text = "Ноябрь ";
            }
            if (B == 12)
            {
                label2.Text = "Декабрь ";
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double B;
            if (!double.TryParse(textBox2.Text, out B))
            {
                MessageBox.Show("New number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double C;
            if (!double.TryParse(textBox3.Text, out C))
            {
                MessageBox.Show("New number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var strin = textBox4.Text;
           
                if (strin[0] != '+' && strin[0] != '-' && strin[0] != '*' && strin[0] != '/')
                {
                    MessageBox.Show("New sumbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(strin[0] == '+')
            {
                double x = B + C;
                label3.Text = ($"{x}"); 
            }
            if (strin[0] == '-')
            {
                double x = B - C;
                label3.Text = ($"{x}");
            }
            if (strin[0] == '*')
            {
                double x = B * C;
                label3.Text = ($"{x}");
            }
            if (strin[0] == '/')
            {
                double x = B / C;
                label3.Text = ($"{x}");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
