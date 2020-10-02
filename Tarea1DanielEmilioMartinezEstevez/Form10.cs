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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0, hr = 0, pagoh = 0, pago = 0, dia = 0, totalh = 0, totald = 0;
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error");
                textBox4.Focus();
                return;
            }

            dia = Convert.ToDouble(textBox1.Text);
            hr = Convert.ToDouble(textBox2.Text);
            pago = Convert.ToDouble(textBox3.Text);
            pagoh = Convert.ToDouble(textBox4.Text);
            totalh = hr * pagoh;
            totald = pago * dia;
            total = totald + totalh;
            label7.Text = Convert.ToString(total);
        }
    }
}
