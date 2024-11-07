namespace _4_Ibarra_CreadorPersonajeRol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            Form2 pantalla2 = new Form2(nombre.Text, vida.Text, raza.Text, habilidad.Text);
            pantalla2.Show();
            this.Hide();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
