namespace Formularios
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.num_1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.num_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.check_suma = new System.Windows.Forms.CheckBox();
            this.check_resta = new System.Windows.Forms.CheckBox();
            this.check_multi = new System.Windows.Forms.CheckBox();
            this.check_division = new System.Windows.Forms.CheckBox();
            this.check_modulo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // num_1
            // 
            this.num_1.Location = new System.Drawing.Point(135, 119);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(100, 22);
            this.num_1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // num_2
            // 
            this.num_2.Location = new System.Drawing.Point(135, 237);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(100, 22);
            this.num_2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calculadora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero1";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(151, 317);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(117, 381);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(69, 16);
            this.result.TabIndex = 7;
            this.result.Text = "Resultado";
            this.result.Click += new System.EventHandler(this.label4_Click);
            // 
            // check_suma
            // 
            this.check_suma.AutoSize = true;
            this.check_suma.Location = new System.Drawing.Point(26, 278);
            this.check_suma.Name = "check_suma";
            this.check_suma.Size = new System.Drawing.Size(36, 20);
            this.check_suma.TabIndex = 8;
            this.check_suma.Text = "+";
            this.check_suma.UseVisualStyleBackColor = true;
            this.check_suma.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // check_resta
            // 
            this.check_resta.AutoSize = true;
            this.check_resta.Location = new System.Drawing.Point(87, 278);
            this.check_resta.Name = "check_resta";
            this.check_resta.Size = new System.Drawing.Size(33, 20);
            this.check_resta.TabIndex = 9;
            this.check_resta.Text = "-";
            this.check_resta.UseVisualStyleBackColor = true;
            this.check_resta.CheckedChanged += new System.EventHandler(this.check_resta_CheckedChanged);
            // 
            // check_multi
            // 
            this.check_multi.AutoSize = true;
            this.check_multi.Location = new System.Drawing.Point(152, 278);
            this.check_multi.Name = "check_multi";
            this.check_multi.Size = new System.Drawing.Size(34, 20);
            this.check_multi.TabIndex = 10;
            this.check_multi.Text = "*";
            this.check_multi.UseVisualStyleBackColor = true;
            this.check_multi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // check_division
            // 
            this.check_division.AutoSize = true;
            this.check_division.Location = new System.Drawing.Point(211, 278);
            this.check_division.Name = "check_division";
            this.check_division.Size = new System.Drawing.Size(33, 20);
            this.check_division.TabIndex = 11;
            this.check_division.Text = "/";
            this.check_division.UseVisualStyleBackColor = true;
            this.check_division.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_2);
            // 
            // check_modulo
            // 
            this.check_modulo.AutoSize = true;
            this.check_modulo.Location = new System.Drawing.Point(277, 278);
            this.check_modulo.Name = "check_modulo";
            this.check_modulo.Size = new System.Drawing.Size(41, 20);
            this.check_modulo.TabIndex = 12;
            this.check_modulo.Text = "%";
            this.check_modulo.UseVisualStyleBackColor = true;
            this.check_modulo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.check_modulo);
            this.Controls.Add(this.check_division);
            this.Controls.Add(this.check_multi);
            this.Controls.Add(this.check_resta);
            this.Controls.Add(this.check_suma);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Name = "Form1";
            this.Text = "Elementos basicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox num_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.CheckBox check_suma;
        private System.Windows.Forms.CheckBox check_resta;
        private System.Windows.Forms.CheckBox check_multi;
        private System.Windows.Forms.CheckBox check_division;
        private System.Windows.Forms.CheckBox check_modulo;
    }
}

