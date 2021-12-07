
namespace Ejemplowhile
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
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LblMovimiento = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnIniciar.Location = new System.Drawing.Point(201, 43);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LblMovimiento
            // 
            this.LblMovimiento.AutoSize = true;
            this.LblMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMovimiento.Location = new System.Drawing.Point(175, 105);
            this.LblMovimiento.Name = "LblMovimiento";
            this.LblMovimiento.Size = new System.Drawing.Size(125, 24);
            this.LblMovimiento.TabIndex = 1;
            this.LblMovimiento.Text = "voy y vuelvo";
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Location = new System.Drawing.Point(191, 238);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(99, 31);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Ejemplo - while";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Presione el boton para iniciar";
            // 
            // EjemploDoWhile
            // 
            this.AcceptButton = this.BtnSalir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(477, 313);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMovimiento);
            this.Controls.Add(this.BtnIniciar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EjemploDoWhile";
            this.Text = "EjemploDoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label LblMovimiento;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
    }
}