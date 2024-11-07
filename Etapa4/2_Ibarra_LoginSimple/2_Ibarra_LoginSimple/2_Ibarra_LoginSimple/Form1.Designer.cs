namespace _2_Ibarra_LoginSimple
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textusuario = new System.Windows.Forms.Label();
            this.textcontraseña = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textusuario
            // 
            this.textusuario.AutoSize = true;
            this.textusuario.BackColor = System.Drawing.Color.White;
            this.textusuario.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textusuario.ForeColor = System.Drawing.Color.Olive;
            this.textusuario.Location = new System.Drawing.Point(165, 104);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(247, 23);
            this.textusuario.TabIndex = 0;
            this.textusuario.Text = "Ingrese nombre de Usuario:";
            // 
            // textcontraseña
            // 
            this.textcontraseña.AutoSize = true;
            this.textcontraseña.BackColor = System.Drawing.Color.White;
            this.textcontraseña.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcontraseña.ForeColor = System.Drawing.Color.Olive;
            this.textcontraseña.Location = new System.Drawing.Point(199, 185);
            this.textcontraseña.Name = "textcontraseña";
            this.textcontraseña.Size = new System.Drawing.Size(178, 23);
            this.textcontraseña.TabIndex = 1;
            this.textcontraseña.Text = "Ingrese Contraseña:";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(243, 145);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 2;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(243, 222);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 3;
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(297, 355);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 4;
            this.boton.Text = "INGRESAR";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(558, 317);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.textcontraseña);
            this.Controls.Add(this.textusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textusuario;
        private System.Windows.Forms.Label textcontraseña;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button boton;
    }
}

