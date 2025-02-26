namespace Formularios
{
    partial class Persona1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_persona = new System.Windows.Forms.TextBox();
            this.edad_persona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registrar_persona = new System.Windows.Forms.Button();
            this.email_persona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mostrar_lista_persona = new System.Windows.Forms.Button();
            this.cedula_persona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tiposangre_persona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre";
            // 
            // nombre_persona
            // 
            this.nombre_persona.Location = new System.Drawing.Point(221, 97);
            this.nombre_persona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre_persona.Name = "nombre_persona";
            this.nombre_persona.Size = new System.Drawing.Size(136, 29);
            this.nombre_persona.TabIndex = 1;
            // 
            // edad_persona
            // 
            this.edad_persona.Location = new System.Drawing.Point(221, 173);
            this.edad_persona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edad_persona.Name = "edad_persona";
            this.edad_persona.Size = new System.Drawing.Size(136, 29);
            this.edad_persona.TabIndex = 3;
            this.edad_persona.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese edad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // registrar_persona
            // 
            this.registrar_persona.Location = new System.Drawing.Point(458, 259);
            this.registrar_persona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrar_persona.Name = "registrar_persona";
            this.registrar_persona.Size = new System.Drawing.Size(103, 35);
            this.registrar_persona.TabIndex = 4;
            this.registrar_persona.Text = "Registrar";
            this.registrar_persona.UseVisualStyleBackColor = true;
            this.registrar_persona.Click += new System.EventHandler(this.registrar_persona_Click);
            // 
            // email_persona
            // 
            this.email_persona.Location = new System.Drawing.Point(221, 259);
            this.email_persona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email_persona.Name = "email_persona";
            this.email_persona.Size = new System.Drawing.Size(136, 29);
            this.email_persona.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese email";
            // 
            // mostrar_lista_persona
            // 
            this.mostrar_lista_persona.Location = new System.Drawing.Point(25, 372);
            this.mostrar_lista_persona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mostrar_lista_persona.Name = "mostrar_lista_persona";
            this.mostrar_lista_persona.Size = new System.Drawing.Size(103, 35);
            this.mostrar_lista_persona.TabIndex = 7;
            this.mostrar_lista_persona.Text = "Mostrar persona";
            this.mostrar_lista_persona.UseVisualStyleBackColor = true;
            this.mostrar_lista_persona.Click += new System.EventHandler(this.button1_Click);
            // 
            // cedula_persona
            // 
            this.cedula_persona.Location = new System.Drawing.Point(591, 97);
            this.cedula_persona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cedula_persona.Name = "cedula_persona";
            this.cedula_persona.Size = new System.Drawing.Size(136, 29);
            this.cedula_persona.TabIndex = 9;
            this.cedula_persona.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ceedula";
            // 
            // tiposangre_persona
            // 
            this.tiposangre_persona.Location = new System.Drawing.Point(600, 170);
            this.tiposangre_persona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tiposangre_persona.Name = "tiposangre_persona";
            this.tiposangre_persona.Size = new System.Drawing.Size(136, 29);
            this.tiposangre_persona.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo sangre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.label6.Location = new System.Drawing.Point(29, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Registrar nombre";
            // 
            // Persona1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(791, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tiposangre_persona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cedula_persona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mostrar_lista_persona);
            this.Controls.Add(this.email_persona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registrar_persona);
            this.Controls.Add(this.edad_persona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre_persona);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Persona1";
            this.Text = "Ingrese edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_persona;
        private System.Windows.Forms.TextBox edad_persona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registrar_persona;
        private System.Windows.Forms.TextBox email_persona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mostrar_lista_persona;
        private System.Windows.Forms.TextBox cedula_persona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tiposangre_persona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}