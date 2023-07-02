
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
            this.BtSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnContar
            // 
            this.BtnContar.Location = new System.Drawing.Point(75, 60);
            this.BtnContar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(128, 41);
            this.BtnContar.TabIndex = 0;
            this.BtnContar.Text = "Contar";
            this.BtnContar.UseVisualStyleBackColor = true;
            this.BtnContar.Click += new System.EventHandler(this.BtnContar_Click);
            // 
            // Lblcontador
            // 
            this.Lblcontador.AutoSize = true;
            this.Lblcontador.Location = new System.Drawing.Point(71, 177);
            this.Lblcontador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblcontador.Name = "Lblcontador";
            this.Lblcontador.Size = new System.Drawing.Size(0, 16);
            this.Lblcontador.TabIndex = 1;
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(331, 183);
            this.BtSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(128, 41);
            this.BtSalir.TabIndex = 2;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 406);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.Lblcontador);
            this.Controls.Add(this.BtnContar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Contador";
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnContar;
        private System.Windows.Forms.Label Lblcontador;
        private System.Windows.Forms.Button BtSalir;
    }
}