
namespace Ejemplo_switch
{
    partial class EjemploSwitch2
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
            this.LblRes = new System.Windows.Forms.Label();
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.TxtNota = new System.Windows.Forms.TextBox();
            this.BtnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(497, 286);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(133, 49);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblRes
            // 
            this.LblRes.BackColor = System.Drawing.Color.GreenYellow;
            this.LblRes.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblRes.Location = new System.Drawing.Point(206, 133);
            this.LblRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(137, 43);
            this.LblRes.TabIndex = 8;
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.Location = new System.Drawing.Point(206, 57);
            this.LblEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(148, 16);
            this.LblEtiqueta.TabIndex = 7;
            this.LblEtiqueta.Text = "Ingrese nota de materia";
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(210, 91);
            this.TxtNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(132, 22);
            this.TxtNota.TabIndex = 6;
            // 
            // BtnClick
            // 
            this.BtnClick.Location = new System.Drawing.Point(366, 89);
            this.BtnClick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(100, 28);
            this.BtnClick.TabIndex = 5;
            this.BtnClick.Text = "Aceptar";
            this.BtnClick.UseVisualStyleBackColor = true;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // EjemploSwitch2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 348);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.LblEtiqueta);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.BtnClick);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EjemploSwitch2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EjemploSwitch2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label LblEtiqueta;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.Button BtnClick;
    }
}