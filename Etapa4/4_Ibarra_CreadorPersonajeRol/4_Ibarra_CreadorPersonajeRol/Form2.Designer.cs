namespace _4_Ibarra_CreadorPersonajeRol
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cerrar = new Button();
            nom = new TextBox();
            vid = new TextBox();
            siguiente = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            raz = new TextBox();
            habilidad = new TextBox();
            SuspendLayout();
            // 
            // cerrar
            // 
            cerrar.BackColor = SystemColors.InactiveCaption;
            cerrar.Location = new Point(480, 261);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(81, 35);
            cerrar.TabIndex = 21;
            cerrar.Text = "CERRAR";
            cerrar.UseVisualStyleBackColor = false;
            cerrar.Click += cerrar_Click;
            // 
            // nom
            // 
            nom.Location = new Point(150, 123);
            nom.Name = "nom";
            nom.Size = new Size(100, 23);
            nom.TabIndex = 20;
            // 
            // vid
            // 
            vid.Location = new Point(387, 123);
            vid.Name = "vid";
            vid.Size = new Size(100, 23);
            vid.TabIndex = 17;
            // 
            // siguiente
            // 
            siguiente.BackColor = SystemColors.InactiveCaption;
            siguiente.Location = new Point(80, 261);
            siguiente.Name = "siguiente";
            siguiente.Size = new Size(89, 35);
            siguiente.TabIndex = 16;
            siguiente.Text = "ATRAS";
            siguiente.UseVisualStyleBackColor = false;
            siguiente.Click += siguiente_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(381, 168);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 15;
            label5.Text = "Habilidades Extra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(145, 168);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 14;
            label4.Text = "Raza:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(381, 105);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 13;
            label3.Text = "Vida:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(145, 105);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(207, 19);
            label1.Name = "label1";
            label1.Size = new Size(239, 27);
            label1.TabIndex = 11;
            label1.Text = "Datos del Personaje";
            // 
            // raz
            // 
            raz.Location = new Point(150, 186);
            raz.Name = "raz";
            raz.Size = new Size(100, 23);
            raz.TabIndex = 22;
            // 
            // habilidad
            // 
            habilidad.Location = new Point(387, 186);
            habilidad.Name = "habilidad";
            habilidad.Size = new Size(100, 23);
            habilidad.TabIndex = 23;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(645, 330);
            Controls.Add(habilidad);
            Controls.Add(raz);
            Controls.Add(cerrar);
            Controls.Add(nom);
            Controls.Add(vid);
            Controls.Add(siguiente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cerrar;
        private TextBox nom;
        private TextBox vid;
        private Button siguiente;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox raz;
        private TextBox habilidad;
    }
}