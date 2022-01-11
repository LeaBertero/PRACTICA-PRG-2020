
namespace Pruebe_while
{
    partial class Prueba_While_movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba_While_movimientos));
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.BtnComenzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic1
            // 
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.Location = new System.Drawing.Point(41, 139);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(146, 165);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            // 
            // Pic2
            // 
            this.Pic2.Image = ((System.Drawing.Image)(resources.GetObject("Pic2.Image")));
            this.Pic2.Location = new System.Drawing.Point(580, 139);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(146, 165);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic2.TabIndex = 1;
            this.Pic2.TabStop = false;
            // 
            // BtnComenzar
            // 
            this.BtnComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComenzar.Location = new System.Drawing.Point(41, 12);
            this.BtnComenzar.Name = "BtnComenzar";
            this.BtnComenzar.Size = new System.Drawing.Size(685, 67);
            this.BtnComenzar.TabIndex = 2;
            this.BtnComenzar.Text = "Comenzar";
            this.BtnComenzar.UseVisualStyleBackColor = true;
            // 
            // Prueba_While_movimientos
            // 
            this.AcceptButton = this.BtnComenzar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnComenzar);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic1);
            this.Name = "Prueba_While_movimientos";
            this.Text = "Prueba_While_movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.Button BtnComenzar;
    }
}