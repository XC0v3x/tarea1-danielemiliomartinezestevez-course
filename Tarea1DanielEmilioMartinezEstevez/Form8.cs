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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0, cantidad = 0, precio = 0;
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

            cantidad = Convert.ToDouble(textBox1.Text);
            precio = Convert.ToDouble(textBox2.Text);
            total = cantidad * precio;
            label4.Text = Convert.ToString(total);
        }
    }
}
