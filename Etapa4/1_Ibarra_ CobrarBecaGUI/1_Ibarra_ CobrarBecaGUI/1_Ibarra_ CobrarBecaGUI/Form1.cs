using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Ibarra__CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(edad.Text) >= 19 && salario.Text == "100,001 - 200,000" || salario.Text == "Más de 200,000")
            {
                MessageBox.Show("¡Felicidades!Puedes cobrar la beca");
            }
            else if (int.Parse(edad.Text) <= 18 && salario.Text == "Entre 0 - 50,000" || salario.Text == "50,001 - 100,000")
            {
                MessageBox.Show("No podes cobrar la beca");
            }
            else
            {
                MessageBox.Show("No podes cobrar la beca");
            }

        }
    }
}
