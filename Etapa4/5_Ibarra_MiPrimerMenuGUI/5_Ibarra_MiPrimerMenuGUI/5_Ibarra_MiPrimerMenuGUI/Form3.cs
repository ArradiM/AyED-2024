using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Ibarra_MiPrimerMenuGUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se acreditó "+ checkedListBox1.Text + " correctamente!!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();
        }
    }
}
