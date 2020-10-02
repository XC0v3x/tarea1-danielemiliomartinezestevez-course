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
    public partial class Form2 : Form
    {
        internal static object open;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double total, n1 = 0, n2 = 0, n3 = 0;
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

            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            n3 = Convert.ToDouble(textBox3.Text);
            total = n1 + n2 + n3;
            label2.Text = Convert.ToString(total);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
