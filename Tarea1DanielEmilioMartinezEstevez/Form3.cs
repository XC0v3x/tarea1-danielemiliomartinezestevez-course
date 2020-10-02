using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1DanielEmilioMartinezEstevez
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = 0, n1 = 0, n2 = 0, n3 = 0, n4 = 0;

            if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("error");
                textBox1.Focus();
                return;
            }

            if(textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("error");
                textBox2.Focus();
                return;
            }

            if(textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("error");
                textBox3.Focus();
                return;
            }

            if(textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("error");
                textBox4.Focus();
                return;
            }

            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            n3 = Convert.ToDouble(textBox3.Text);
            n4 = Convert.ToDouble(textBox4.Text);
            total = (n1 + n2 + n3 + n4) / 4;
            label7.Text = Convert.ToString(total);
        }
    }
}
