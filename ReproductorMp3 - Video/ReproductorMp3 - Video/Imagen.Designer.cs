namespace ReproductorMp3___Video
{
    partial class FrmImagen
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PicImage = new System.Windows.Forms.PictureBox();
            this.BtCargarImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Black;
            this.BtnCerrar.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrar.Location = new System.Drawing.Point(622, 264);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(151, 76);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar programa";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PicImage
            // 
            this.PicImage.Location = new System.Drawing.Point(139, 77);
            this.PicImage.Name = "PicImage";
            this.PicImage.Size = new System.Drawing.Size(477, 285);
            this.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicImage.TabIndex = 1;
            this.PicImage.TabStop = false;
            // 
            // BtCargarImagen
            // 
            this.BtCargarImagen.BackColor = System.Drawing.Color.Gold;
            this.BtCargarImagen.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCargarImagen.Location = new System.Drawing.Point(148, 387);
            this.BtCargarImagen.Name = "BtCargarImagen";
            this.BtCargarImagen.Size = new System.Drawing.Size(109, 62);
            this.BtCargarImagen.TabIndex = 2;
            this.BtCargarImagen.Text = "Abrir Imagen";
            this.BtCargarImagen.UseVisualStyleBackColor = false;
            this.BtCargarImagen.Click += new System.EventHandler(this.BtCargarImagen_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(251, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cargue aquí sus imagenes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(263, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "<--- Click aquí para iniciar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // BtGuardar
            // 
            this.BtGuardar.BackColor = System.Drawing.Color.Red;
            this.BtGuardar.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGuardar.Location = new System.Drawing.Point(527, 393);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(130, 52);
            this.BtGuardar.TabIndex = 9;
            this.BtGuardar.Text = "Guardar imagen";
            this.BtGuardar.UseVisualStyleBackColor = false;
            // 
            // FrmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtCargarImagen);
            this.Controls.Add(this.PicImage);
            this.Controls.Add(this.BtnCerrar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image_charge";
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.PictureBox PicImage;
        private System.Windows.Forms.Button BtCargarImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtGuardar;
    }
}