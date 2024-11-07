using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Ibarra_LoginSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if(usuario.Text == "Admin" && contraseña.Text == "Admin12345")
            {
                MessageBox.Show("Ingreso correctamente");
            } else if(usuario.Text == "Admin" && contraseña.Text != "Admin12345")
            {
                MessageBox.Show("Contraseña incorrecta");
            }else if(usuario.Text != "Admin" && contraseña.Text == "Admin12345")
            {
                MessageBox.Show("Usuario incorrecto");
            }
            else
            {
                MessageBox.Show("La contraseña y el usuario son incorrectos");
            }
            
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
