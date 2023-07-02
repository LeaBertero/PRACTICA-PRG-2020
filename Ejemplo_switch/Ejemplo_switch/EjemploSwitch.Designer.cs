
namespace Ejemplo_switch
{
    partial class EjemploSwitch
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNota = new System.Windows.Forms.TextBox();
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(101, 128);
            this.TxtNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(132, 22);
            this.TxtNota.TabIndex = 1;
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.Location = new System.Drawing.Point(97, 94);
            this.LblEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(148, 16);
            this.LblEtiqueta.TabIndex = 2;
            this.LblEtiqueta.Text = "Ingrese nota de materia";
            // 
            // LblRes
            // 
            this.LblRes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblRes.Location = new System.Drawing.Point(97, 170);
            this.LblRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(137, 43);
            this.LblRes.TabIndex = 3;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(569, 375);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 28);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Otro ejemplo Switch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "NO PODRÁ INGRESAR TEXTO, DE LO CONTRARIO LE GENERARÁ UN ERROR";
            // 
            // EjemploSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.LblEtiqueta);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EjemploSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplo Switc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.Label LblEtiqueta;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

