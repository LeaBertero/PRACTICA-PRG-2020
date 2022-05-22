
namespace Prueba_For
{
    partial class Ejemplo2
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
            this.TxtValInicial = new System.Windows.Forms.TextBox();
            this.LblRojo = new System.Windows.Forms.Label();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.PicImag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicImag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese el valor inicial";
            // 
            // TxtValInicial
            // 
            this.TxtValInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValInicial.Location = new System.Drawing.Point(22, 42);
            this.TxtValInicial.Name = "TxtValInicial";
            this.TxtValInicial.Size = new System.Drawing.Size(94, 23);
            this.TxtValInicial.TabIndex = 9;
            // 
            // LblRojo
            // 
            this.LblRojo.BackColor = System.Drawing.Color.Red;
            this.LblRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRojo.Location = new System.Drawing.Point(0, 108);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(48, 41);
            this.LblRojo.TabIndex = 8;
            this.LblRojo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEjecutar.Location = new System.Drawing.Point(138, 38);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(81, 30);
            this.BtnEjecutar.TabIndex = 7;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // PicImag
            // 
            this.PicImag.Image = global::Prueba_For.Properties.Resources.Pájaro_Loco;
            this.PicImag.Location = new System.Drawing.Point(36, 177);
            this.PicImag.Name = "PicImag";
            this.PicImag.Size = new System.Drawing.Size(104, 122);
            this.PicImag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicImag.TabIndex = 11;
            this.PicImag.TabStop = false;
            // 
            // Ejemplo2
            // 
            this.AcceptButton = this.BtnEjecutar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicImag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtValInicial);
            this.Controls.Add(this.LblRojo);
            this.Controls.Add(this.BtnEjecutar);
            this.Name = "Ejemplo2";
            this.Text = "Ejemplo2";
            ((System.ComponentModel.ISupportInitialize)(this.PicImag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtValInicial;
        private System.Windows.Forms.Label LblRojo;
        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.PictureBox PicImag;
    }
}