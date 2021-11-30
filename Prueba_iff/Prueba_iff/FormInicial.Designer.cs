
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
            this.LblEdada.Size = new System.Drawing.Size(83, 13);
            this.LblEdada.TabIndex = 2;
            this.LblEdada.Text = "Ingrese su edad";
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblResultado.Location = new System.Drawing.Point(22, 104);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(83, 29);
            this.LblResultado.TabIndex = 3;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 239);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblEdada);
            this.Controls.Add(this.TxtIngreso);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "FormInicial";
            this.Text = "Prueba Iff";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.Label LblEdada;
        private System.Windows.Forms.Label LblResultado;
    }
}