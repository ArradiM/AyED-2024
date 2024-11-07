using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Ibarra_CreadorPersonajeRol
{
    public partial class Form2 : Form
    {
        public Form2(string nombre, string vida, string raza, string habilidadex)

        {
            InitializeComponent();
            nom.Text = nombre;
            vid.Text = vida;
            raz.Text = raza;
            habilidad.Text = habilidadex;
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
