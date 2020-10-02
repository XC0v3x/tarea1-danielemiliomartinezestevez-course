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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0, n1 = 0;
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error");
                textBox1.Focus();
                return;
            }

            n1 = Convert.ToDouble(textBox1.Text);
            total = n1 * 4.54609;
            label4.Text = Convert.ToString(total);
        }
    }
}
