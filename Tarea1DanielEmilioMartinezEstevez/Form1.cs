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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form2 suma = new Tarea1DanielEmilioMartinezEstevez.Form2();
            suma.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form3 promedio = new Tarea1DanielEmilioMartinezEstevez.Form3();
            promedio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form4 mm = new Tarea1DanielEmilioMartinezEstevez.Form4();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form5 mk = new Tarea1DanielEmilioMartinezEstevez.Form5();
            mk.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form6 lemdol = new Tarea1DanielEmilioMartinezEstevez.Form6();
            lemdol.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form7 lemeur = new Tarea1DanielEmilioMartinezEstevez.Form7();
            lemeur.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form8 llantas = new Tarea1DanielEmilioMartinezEstevez.Form8();
            llantas.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form9 salario = new Tarea1DanielEmilioMartinezEstevez.Form9();
            salario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form10 extra = new Tarea1DanielEmilioMartinezEstevez.Form10();
            extra.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Tarea1DanielEmilioMartinezEstevez.Form11 gallit = new Tarea1DanielEmilioMartinezEstevez.Form11();
            gallit.Show();
        }
    }
}
