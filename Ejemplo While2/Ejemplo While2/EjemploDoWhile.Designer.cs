
namespace Ejemplo_While2
{
    partial class EjemploDoWhile
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnWhile = new System.Windows.Forms.Button();
            this.LblRiv = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(524, 274);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(77, 32);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnWhile
            // 
            this.BtnWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWhile.Location = new System.Drawing.Point(521, 12);
            this.BtnWhile.Name = "BtnWhile";
            this.BtnWhile.Size = new System.Drawing.Size(80, 53);
            this.BtnWhile.TabIndex = 5;
            this.BtnWhile.Text = "Ejemplo While";
            this.BtnWhile.UseVisualStyleBackColor = true;
            this.BtnWhile.Click += new System.EventHandler(this.BtnWhile_Click);
            // 
            // LblRiv
            // 
            this.LblRiv.BackColor = System.Drawing.Color.Red;
            this.LblRiv.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblRiv.Location = new System.Drawing.Point(1, 91);
            this.LblRiv.Name = "LblRiv";
            this.LblRiv.Size = new System.Drawing.Size(149, 66);
            this.LblRiv.TabIndex = 6;
            this.LblRiv.Text = "River Plate";
            this.LblRiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(253, 257);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(89, 49);
            this.BtnIniciar.TabIndex = 7;
            this.BtnIniciar.Text = "Iniciar Movimiento";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // EjemploDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 318);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LblRiv);
            this.Controls.Add(this.BtnWhile);
            this.Controls.Add(this.BtnSalir);
            this.Name = "EjemploDoWhile";
            this.Text = "EjemploDoWhile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnWhile;
        private System.Windows.Forms.Label LblRiv;
        private System.Windows.Forms.Button BtnIniciar;
    }
}