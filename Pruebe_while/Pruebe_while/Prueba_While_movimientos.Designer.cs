
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
            this.PicCoyote = new System.Windows.Forms.PictureBox();
            this.PicBeep = new System.Windows.Forms.PictureBox();
            this.BtnMovCoyote = new System.Windows.Forms.Button();
            this.BtnMovMicMic = new System.Windows.Forms.Button();
            this.BtnReac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicCoyote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBeep)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCoyote
            // 
            this.PicCoyote.Image = ((System.Drawing.Image)(resources.GetObject("PicCoyote.Image")));
            this.PicCoyote.Location = new System.Drawing.Point(275, 83);
            this.PicCoyote.Name = "PicCoyote";
            this.PicCoyote.Size = new System.Drawing.Size(110, 112);
            this.PicCoyote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCoyote.TabIndex = 0;
            this.PicCoyote.TabStop = false;
            this.PicCoyote.Click += new System.EventHandler(this.PicCoyote_Click);
            // 
            // PicBeep
            // 
            this.PicBeep.Image = ((System.Drawing.Image)(resources.GetObject("PicBeep.Image")));
            this.PicBeep.Location = new System.Drawing.Point(500, 290);
            this.PicBeep.Name = "PicBeep";
            this.PicBeep.Size = new System.Drawing.Size(110, 112);
            this.PicBeep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBeep.TabIndex = 1;
            this.PicBeep.TabStop = false;
            // 
            // BtnMovCoyote
            // 
            this.BtnMovCoyote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMovCoyote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovCoyote.Location = new System.Drawing.Point(28, 479);
            this.BtnMovCoyote.Name = "BtnMovCoyote";
            this.BtnMovCoyote.Size = new System.Drawing.Size(97, 37);
            this.BtnMovCoyote.TabIndex = 2;
            this.BtnMovCoyote.Text = "Coyote";
            this.BtnMovCoyote.UseVisualStyleBackColor = true;
            this.BtnMovCoyote.Click += new System.EventHandler(this.BtnMovCoyote_Click);
            // 
            // BtnMovMicMic
            // 
            this.BtnMovMicMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMovMicMic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovMicMic.Location = new System.Drawing.Point(824, 479);
            this.BtnMovMicMic.Name = "BtnMovMicMic";
            this.BtnMovMicMic.Size = new System.Drawing.Size(121, 37);
            this.BtnMovMicMic.TabIndex = 3;
            this.BtnMovMicMic.Text = "CorreCaminos";
            this.BtnMovMicMic.UseVisualStyleBackColor = true;
            this.BtnMovMicMic.Click += new System.EventHandler(this.BtnMovMicMic_Click);
            // 
            // BtnReac
            // 
            this.BtnReac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReac.Location = new System.Drawing.Point(466, 12);
            this.BtnReac.Name = "BtnReac";
            this.BtnReac.Size = new System.Drawing.Size(113, 29);
            this.BtnReac.TabIndex = 4;
            this.BtnReac.Text = "Reacomodar";
            this.BtnReac.UseVisualStyleBackColor = true;
            this.BtnReac.Click += new System.EventHandler(this.BtnReac_Click);
            // 
            // Prueba_While_movimientos
            // 
            this.AcceptButton = this.BtnMovCoyote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 528);
            this.Controls.Add(this.BtnReac);
            this.Controls.Add(this.PicBeep);
            this.Controls.Add(this.PicCoyote);
            this.Controls.Add(this.BtnMovMicMic);
            this.Controls.Add(this.BtnMovCoyote);
            this.Name = "Prueba_While_movimientos";
            this.Text = "Prueba_While_movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.PicCoyote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBeep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicCoyote;
        private System.Windows.Forms.PictureBox PicBeep;
        private System.Windows.Forms.Button BtnMovCoyote;
        private System.Windows.Forms.Button BtnMovMicMic;
        private System.Windows.Forms.Button BtnReac;
    }
}