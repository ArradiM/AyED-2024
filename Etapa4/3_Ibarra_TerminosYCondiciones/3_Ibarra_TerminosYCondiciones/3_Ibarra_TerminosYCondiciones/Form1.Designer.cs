namespace _3_Ibarra_TerminosYCondiciones
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
            this.texto1 = new System.Windows.Forms.Label();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.ForeColor = System.Drawing.Color.Transparent;
            this.texto1.Location = new System.Drawing.Point(33, 86);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(493, 19);
            this.texto1.TabIndex = 0;
            this.texto1.Text = "Acepta los términos y condiciones del programa sin leer";
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.BackColor = System.Drawing.Color.White;
            this.checkbox1.Checked = true;
            this.checkbox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.ForeColor = System.Drawing.Color.Plum;
            this.checkbox1.Location = new System.Drawing.Point(140, 165);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(284, 21);
            this.checkbox1.TabIndex = 1;
            this.checkbox1.Text = "He leído y acepto los términos y condiciones";
            this.checkbox1.UseVisualStyleBackColor = false;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.checkbox1_CheckedChanged);
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.Color.Thistle;
            this.boton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.boton.Location = new System.Drawing.Point(243, 235);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(78, 45);
            this.boton.TabIndex = 2;
            this.boton.Text = "CERRAR";
            this.boton.UseVisualStyleBackColor = false;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(558, 318);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.texto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.Button boton;
    }
}

