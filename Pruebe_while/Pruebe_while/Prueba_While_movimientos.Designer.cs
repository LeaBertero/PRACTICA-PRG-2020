
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
            this.LblMensaje = new System.Windows.Forms.Label();
            this.BtnAparecer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicCoyote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBeep)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCoyote
            // 
            this.PicCoyote.Image = ((System.Drawing.Image)(resources.GetObject("PicCoyote.Image")));
            this.PicCoyote.Location = new System.Drawing.Point(180, 404);
            this.PicCoyote.Name = "PicCoyote";
            this.PicCoyote.Size = new System.Drawing.Size(110, 112);
            this.PicCoyote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCoyote.TabIndex = 0;
            this.PicCoyote.TabStop = false;
            this.PicCoyote.Visible = false;
            
            // 
            // PicBeep
            // 
            this.PicBeep.Image = ((System.Drawing.Image)(resources.GetObject("PicBeep.Image")));
            this.PicBeep.Location = new System.Drawing.Point(779, 71);
            this.PicBeep.Name = "PicBeep";
            this.PicBeep.Size = new System.Drawing.Size(110, 112);
            this.PicBeep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBeep.TabIndex = 1;
            this.PicBeep.TabStop = false;
            this.PicBeep.Visible = false;
            // 
            // BtnMovCoyote
            // 
            this.BtnMovCoyote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMovCoyote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovCoyote.Location = new System.Drawing.Point(12, 247);
            this.BtnMovCoyote.Name = "BtnMovCoyote";
            this.BtnMovCoyote.Size = new System.Drawing.Size(140, 269);
            this.BtnMovCoyote.TabIndex = 2;
            this.BtnMovCoyote.Text = "Coyote";
            this.BtnMovCoyote.UseVisualStyleBackColor = true;
            this.BtnMovCoyote.Click += new System.EventHandler(this.BtnMovCoyote_Click);
            // 
            // BtnMovMicMic
            // 
            this.BtnMovMicMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMovMicMic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovMicMic.Location = new System.Drawing.Point(1140, 257);
            this.BtnMovMicMic.Name = "BtnMovMicMic";
            this.BtnMovMicMic.Size = new System.Drawing.Size(140, 269);
            this.BtnMovMicMic.TabIndex = 3;
            this.BtnMovMicMic.Text = "CorreCaminos";
            this.BtnMovMicMic.UseVisualStyleBackColor = true;
            this.BtnMovMicMic.Click += new System.EventHandler(this.BtnMovMicMic_Click);
            // 
            // BtnReac
            // 
            this.BtnReac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReac.Location = new System.Drawing.Point(332, 441);
            this.BtnReac.Name = "BtnReac";
            this.BtnReac.Size = new System.Drawing.Size(692, 53);
            this.BtnReac.TabIndex = 4;
            this.BtnReac.Text = "Reacomodar";
            this.BtnReac.UseVisualStyleBackColor = true;
            this.BtnReac.Click += new System.EventHandler(this.BtnReac_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(605, 404);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(0, 17);
            this.LblMensaje.TabIndex = 5;
            this.LblMensaje.Visible = false;
            // 
            // BtnAparecer
            // 
            this.BtnAparecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAparecer.Location = new System.Drawing.Point(332, 12);
            this.BtnAparecer.Name = "BtnAparecer";
            this.BtnAparecer.Size = new System.Drawing.Size(692, 53);
            this.BtnAparecer.TabIndex = 6;
            this.BtnAparecer.Text = "Aparecer personajes";
            this.BtnAparecer.UseVisualStyleBackColor = true;
            this.BtnAparecer.Click += new System.EventHandler(this.BtnAparecer_Click);
            // 
            // Prueba_While_movimientos
            // 
            this.AcceptButton = this.BtnMovCoyote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pruebe_while.Properties.Resources.f86a954f550c45a3af14a2b645732022__bugs_bunny_looney_tunes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1292, 528);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.BtnAparecer);
            this.Controls.Add(this.PicBeep);
            this.Controls.Add(this.PicCoyote);
            this.Controls.Add(this.BtnMovMicMic);
            this.Controls.Add(this.BtnMovCoyote);
            this.Controls.Add(this.BtnReac);
            this.Name = "Prueba_While_movimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba_While_movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.PicCoyote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBeep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicCoyote;
        private System.Windows.Forms.PictureBox PicBeep;
        private System.Windows.Forms.Button BtnMovCoyote;
        private System.Windows.Forms.Button BtnMovMicMic;
        private System.Windows.Forms.Button BtnReac;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Button BtnAparecer;
    }
}