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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0, n1 = 0;
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error");
                return;
            }

            n1 = Convert.ToDouble(textBox1.Text);
            total = n1 / 24.64;
            label4.Text = Convert.ToString(total);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
