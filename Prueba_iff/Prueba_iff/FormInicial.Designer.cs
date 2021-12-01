
namespace Prueba_iff
{
    partial class FormInicial
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.LblEdada = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(149, 51);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(89, 27);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Location = new System.Drawing.Point(25, 55);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(100, 20);
            this.TxtIngreso.TabIndex = 1;
            // 
            // LblEdada
            // 
            this.LblEdada.AutoSize = true;
            this.LblEdada.Location = new System.Drawing.Point(22, 22);
            this.LblEdada.Name = "LblEdada";
            this.LblEdada.Size = new System.Drawing.Size(155, 13);
            this.LblEdada.TabIndex = 2;
            this.LblEdada.Text = "Ingrese una edad entre 12 y 60";
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblResultado.Location = new System.Drawing.Point(22, 104);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(83, 29);
            this.LblResultado.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 239);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblEdada);
            this.Controls.Add(this.TxtIngreso);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "FormInicial";
            this.Text = "Prueba Iff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.Label LblEdada;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}