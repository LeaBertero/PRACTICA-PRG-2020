
namespace Ejemplowhile
{
    partial class EjemploWhile
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
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LblMovimiento = new System.Windows.Forms.Label();
            this.BtnSegEjemplo = new System.Windows.Forms.Button();
            this.BtNSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(89, 12);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LblMovimiento
            // 
            this.LblMovimiento.BackColor = System.Drawing.Color.Red;
            this.LblMovimiento.Location = new System.Drawing.Point(0, 122);
            this.LblMovimiento.Name = "LblMovimiento";
            this.LblMovimiento.Size = new System.Drawing.Size(47, 45);
            this.LblMovimiento.TabIndex = 1;
            // 
            // BtnSegEjemplo
            // 
            this.BtnSegEjemplo.Location = new System.Drawing.Point(435, 12);
            this.BtnSegEjemplo.Name = "BtnSegEjemplo";
            this.BtnSegEjemplo.Size = new System.Drawing.Size(75, 23);
            this.BtnSegEjemplo.TabIndex = 2;
            this.BtnSegEjemplo.Text = "Ej - DoWhile";
            this.BtnSegEjemplo.UseVisualStyleBackColor = true;
            this.BtnSegEjemplo.Click += new System.EventHandler(this.BtnSegEjemplo_Click);
            // 
            // BtNSalir
            // 
            this.BtNSalir.Location = new System.Drawing.Point(261, 207);
            this.BtNSalir.Name = "BtNSalir";
            this.BtNSalir.Size = new System.Drawing.Size(75, 23);
            this.BtNSalir.TabIndex = 3;
            this.BtNSalir.Text = "Salir";
            this.BtNSalir.UseVisualStyleBackColor = true;
            this.BtNSalir.Click += new System.EventHandler(this.BtNSalir_Click);
            // 
            // EjemploWhile
            // 
            this.AcceptButton = this.BtnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(600, 242);
            this.Controls.Add(this.BtNSalir);
            this.Controls.Add(this.BtnSegEjemplo);
            this.Controls.Add(this.LblMovimiento);
            this.Controls.Add(this.BtnIniciar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "EjemploWhile";
            this.Text = "EjemploWhile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label LblMovimiento;
        private System.Windows.Forms.Button BtnSegEjemplo;
        private System.Windows.Forms.Button BtNSalir;
    }
}