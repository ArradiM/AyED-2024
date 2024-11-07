using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Ibarra_TerminosYCondiciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox1.Checked == true)
            {
                boton.Enabled = true;
            }
            else
            {
                boton.Enabled = false;
            }
        }

        private void boton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
