
namespace Contador
{
    partial class Contador
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
            this.BtnContar = new System.Windows.Forms.Button();
            this.Lblcontador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnContar
            // 
            this.BtnContar.Location = new System.Drawing.Point(56, 49);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(96, 33);
            this.BtnContar.TabIndex = 0;
            this.BtnContar.Text = "Contar";
            this.BtnContar.UseVisualStyleBackColor = true;
            this.BtnContar.Click += new System.EventHandler(this.BtnContar_Click);
            // 
            // Lblcontador
            // 
            this.Lblcontador.AutoSize = true;
            this.Lblcontador.Location = new System.Drawing.Point(53, 144);
            this.Lblcontador.Name = "Lblcontador";
            this.Lblcontador.Size = new System.Drawing.Size(0, 13);
            this.Lblcontador.TabIndex = 1;
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 216);
            this.Controls.Add(this.Lblcontador);
            this.Controls.Add(this.BtnContar);
            this.Name = "Contador";
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnContar;
        private System.Windows.Forms.Label Lblcontador;
    }
}