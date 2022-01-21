
namespace Try_catch_Prueba_de_errores_
{
    partial class TryCatch_Prueba_de_errores_
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.BtnRes = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            this.Lblres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnclean = new System.Windows.Forms.Button();
            this.BtnCleanRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(182, 85);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 20);
            this.TxtNum1.TabIndex = 1;
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(390, 85);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 20);
            this.TxtNum2.TabIndex = 2;
            // 
            // BtnRes
            // 
            this.BtnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.Location = new System.Drawing.Point(526, 81);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(82, 27);
            this.BtnRes.TabIndex = 3;
            this.BtnRes.Text = "=";
            this.BtnRes.UseVisualStyleBackColor = true;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.Location = new System.Drawing.Point(21, 150);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 22);
            this.LblError.TabIndex = 4;
            // 
            // Lblres
            // 
            this.Lblres.AutoSize = true;
            this.Lblres.Location = new System.Drawing.Point(659, 88);
            this.Lblres.Name = "Lblres";
            this.Lblres.Size = new System.Drawing.Size(0, 13);
            this.Lblres.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ejemplo de Try Catch - (Prueba de errores)";
            // 
            // Btnclean
            // 
            this.Btnclean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnclean.Location = new System.Drawing.Point(12, 12);
            this.Btnclean.Name = "Btnclean";
            this.Btnclean.Size = new System.Drawing.Size(107, 45);
            this.Btnclean.TabIndex = 7;
            this.Btnclean.Text = "Limpiar operaciones";
            this.Btnclean.UseVisualStyleBackColor = true;
            this.Btnclean.Click += new System.EventHandler(this.Btnclean_Click);
            // 
            // BtnCleanRes
            // 
            this.BtnCleanRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCleanRes.Location = new System.Drawing.Point(12, 102);
            this.BtnCleanRes.Name = "BtnCleanRes";
            this.BtnCleanRes.Size = new System.Drawing.Size(107, 45);
            this.BtnCleanRes.TabIndex = 8;
            this.BtnCleanRes.Text = "Limpiar Resultado";
            this.BtnCleanRes.UseVisualStyleBackColor = true;
            this.BtnCleanRes.Click += new System.EventHandler(this.BtnCleanRes_Click);
            // 
            // TryCatch_Prueba_de_errores_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 181);
            this.Controls.Add(this.BtnCleanRes);
            this.Controls.Add(this.Btnclean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lblres);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnRes);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TryCatch_Prueba_de_errores_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TryCatch_Prueba_de_errores_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Label Lblres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnclean;
        private System.Windows.Forms.Button BtnCleanRes;
    }
}