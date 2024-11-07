namespace _4_Ibarra_CreadorPersonajeRol
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            vida = new TextBox();
            raza = new ComboBox();
            habilidad = new CheckedListBox();
            nombre = new TextBox();
            cancelar = new Button();
            siguiente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 27);
            label1.TabIndex = 0;
            label1.Text = "CARGA DE DATOS DE PERSONAJE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(152, 83);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(388, 83);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Vida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(152, 146);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Raza:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(388, 146);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Habilidades Extra:";
            // 
            // vida
            // 
            vida.Location = new Point(394, 101);
            vida.Name = "vida";
            vida.Size = new Size(100, 23);
            vida.TabIndex = 6;
            // 
            // raza
            // 
            raza.FormattingEnabled = true;
            raza.Items.AddRange(new object[] { "Humano", "Enano", "Hobbit" });
            raza.Location = new Point(157, 164);
            raza.Name = "raza";
            raza.Size = new Size(121, 23);
            raza.TabIndex = 7;
            // 
            // habilidad
            // 
            habilidad.FormattingEnabled = true;
            habilidad.Items.AddRange(new object[] { "Invisibilidad", "Fuerza Sobrehumana", "Curación Rápida" });
            habilidad.Location = new Point(394, 164);
            habilidad.Name = "habilidad";
            habilidad.Size = new Size(120, 58);
            habilidad.TabIndex = 8;
            // 
            // nombre
            // 
            nombre.Location = new Point(157, 101);
            nombre.Name = "nombre";
            nombre.Size = new Size(100, 23);
            nombre.TabIndex = 9;
            // 
            // cancelar
            // 
            cancelar.BackColor = SystemColors.InactiveCaption;
            cancelar.Location = new Point(506, 248);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(76, 33);
            cancelar.TabIndex = 10;
            cancelar.Text = "CANCELAR";
            cancelar.UseVisualStyleBackColor = false;
            cancelar.Click += cancelar_Click;
            // 
            // siguiente
            // 
            siguiente.BackColor = SystemColors.InactiveCaption;
            siguiente.Location = new Point(72, 248);
            siguiente.Name = "siguiente";
            siguiente.Size = new Size(76, 33);
            siguiente.TabIndex = 11;
            siguiente.Text = "SIGUIENTE";
            siguiente.UseVisualStyleBackColor = false;
            siguiente.Click += siguiente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(675, 304);
            Controls.Add(siguiente);
            Controls.Add(cancelar);
            Controls.Add(nombre);
            Controls.Add(habilidad);
            Controls.Add(raza);
            Controls.Add(vida);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox vida;
        private ComboBox raza;
        private CheckedListBox habilidad;
        private TextBox nombre;
        private Button cancelar;
        private Button siguiente;
    }
}
