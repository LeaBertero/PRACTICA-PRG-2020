
namespace HolaMundo_2_
{
    partial class HolaMundo2
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
            this.BtnMostrarMateria = new System.Windows.Forms.Button();
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMostrarMateria
            // 
            this.BtnMostrarMateria.Location = new System.Drawing.Point(103, 34);
            this.BtnMostrarMateria.Name = "BtnMostrarMateria";
            this.BtnMostrarMateria.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrarMateria.TabIndex = 0;
            this.BtnMostrarMateria.Text = "Click";
            this.BtnMostrarMateria.UseVisualStyleBackColor = true;
            this.BtnMostrarMateria.Click += new System.EventHandler(this.BtnMostrarMateria_Click);
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.Location = new System.Drawing.Point(12, 9);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(42, 13);
            this.LblEtiqueta.TabIndex = 1;
            this.LblEtiqueta.Text = "Materia";
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Location = new System.Drawing.Point(12, 69);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(29, 13);
            this.LblMensaje.TabIndex = 2;
            this.LblMensaje.Text = "Hola";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(14, 36);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(83, 20);
            this.TxtMateria.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HolaMundo2
            // 
            this.AcceptButton = this.BtnMostrarMateria;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 120);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.LblEtiqueta);
            this.Controls.Add(this.BtnMostrarMateria);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "HolaMundo2";
            this.Text = "Hola gente del aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrarMateria;
        private System.Windows.Forms.Label LblEtiqueta;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Button button2;
    }
}