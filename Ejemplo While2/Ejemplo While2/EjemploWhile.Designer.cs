
namespace Ejemplo_While2
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
            this.BtnArranque = new System.Windows.Forms.Button();
            this.Lblrojo = new System.Windows.Forms.Label();
            this.BtnEjDw = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnArranque
            // 
            this.BtnArranque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArranque.Location = new System.Drawing.Point(292, 264);
            this.BtnArranque.Name = "BtnArranque";
            this.BtnArranque.Size = new System.Drawing.Size(80, 32);
            this.BtnArranque.TabIndex = 0;
            this.BtnArranque.Text = "Iniciar";
            this.BtnArranque.UseVisualStyleBackColor = true;
            this.BtnArranque.Click += new System.EventHandler(this.BtnArranque_Click);
            // 
            // Lblrojo
            // 
            this.Lblrojo.BackColor = System.Drawing.Color.Red;
            this.Lblrojo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblrojo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblrojo.Location = new System.Drawing.Point(-2, 48);
            this.Lblrojo.Name = "Lblrojo";
            this.Lblrojo.Size = new System.Drawing.Size(149, 66);
            this.Lblrojo.TabIndex = 1;
            this.Lblrojo.Text = "River Plate";
            this.Lblrojo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEjDw
            // 
            this.BtnEjDw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEjDw.Location = new System.Drawing.Point(1, 243);
            this.BtnEjDw.Name = "BtnEjDw";
            this.BtnEjDw.Size = new System.Drawing.Size(80, 53);
            this.BtnEjDw.TabIndex = 2;
            this.BtnEjDw.Text = "Ejemplo DoWhile";
            this.BtnEjDw.UseVisualStyleBackColor = true;
            this.BtnEjDw.Click += new System.EventHandler(this.BtnEjDw_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(584, 264);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 32);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // EjemploWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 298);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEjDw);
            this.Controls.Add(this.Lblrojo);
            this.Controls.Add(this.BtnArranque);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "EjemploWhile";
            this.Text = "EjemploWhile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnArranque;
        private System.Windows.Forms.Label Lblrojo;
        private System.Windows.Forms.Button BtnEjDw;
        private System.Windows.Forms.Button BtnSalir;
    }
}