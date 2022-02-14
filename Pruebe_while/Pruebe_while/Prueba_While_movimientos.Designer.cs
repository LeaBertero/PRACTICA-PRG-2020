
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
            this.BtnReac = new System.Windows.Forms.Button();
            this.BtnAparecer = new System.Windows.Forms.Button();
            this.BntAparecer2 = new System.Windows.Forms.Button();
            this.BtnBorrarPers1 = new System.Windows.Forms.Button();
            this.BtnBorrarPers2 = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicCoyote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBeep)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCoyote
            // 
            this.PicCoyote.Image = ((System.Drawing.Image)(resources.GetObject("PicCoyote.Image")));
            this.PicCoyote.Location = new System.Drawing.Point(438, 371);
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
            this.PicBeep.Location = new System.Drawing.Point(923, 55);
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
            this.BtnMovCoyote.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnMovCoyote.FlatAppearance.BorderSize = 5;
            this.BtnMovCoyote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMovCoyote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovCoyote.Location = new System.Drawing.Point(286, 575);
            this.BtnMovCoyote.Name = "BtnMovCoyote";
            this.BtnMovCoyote.Size = new System.Drawing.Size(594, 50);
            this.BtnMovCoyote.TabIndex = 2;
            this.BtnMovCoyote.Text = "Mover";
            this.BtnMovCoyote.UseVisualStyleBackColor = true;
            this.BtnMovCoyote.Click += new System.EventHandler(this.BtnMovCoyote_Click);
            // 
            // BtnReac
            // 
            this.BtnReac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReac.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnReac.FlatAppearance.BorderSize = 5;
            this.BtnReac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReac.Location = new System.Drawing.Point(483, 12);
            this.BtnReac.Name = "BtnReac";
            this.BtnReac.Size = new System.Drawing.Size(194, 58);
            this.BtnReac.TabIndex = 4;
            this.BtnReac.Text = "Reacomodar personajes";
            this.BtnReac.UseVisualStyleBackColor = true;
            this.BtnReac.Click += new System.EventHandler(this.BtnReac_Click);
            // 
            // BtnAparecer
            // 
            this.BtnAparecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAparecer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnAparecer.FlatAppearance.BorderSize = 5;
            this.BtnAparecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAparecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAparecer.Location = new System.Drawing.Point(249, 12);
            this.BtnAparecer.Name = "BtnAparecer";
            this.BtnAparecer.Size = new System.Drawing.Size(194, 58);
            this.BtnAparecer.TabIndex = 6;
            this.BtnAparecer.Text = "Aparecer personaje 1";
            this.BtnAparecer.UseVisualStyleBackColor = true;
            this.BtnAparecer.Click += new System.EventHandler(this.BtnAparecer_Click);
            // 
            // BntAparecer2
            // 
            this.BntAparecer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntAparecer2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BntAparecer2.FlatAppearance.BorderSize = 5;
            this.BntAparecer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntAparecer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntAparecer2.Location = new System.Drawing.Point(711, 12);
            this.BntAparecer2.Name = "BntAparecer2";
            this.BntAparecer2.Size = new System.Drawing.Size(194, 58);
            this.BntAparecer2.TabIndex = 7;
            this.BntAparecer2.Text = "Aparecer personaje 2";
            this.BntAparecer2.UseVisualStyleBackColor = true;
            this.BntAparecer2.Click += new System.EventHandler(this.BntAparecer2_Click);
            // 
            // BtnBorrarPers1
            // 
            this.BtnBorrarPers1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrarPers1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnBorrarPers1.FlatAppearance.BorderSize = 5;
            this.BtnBorrarPers1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarPers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarPers1.Location = new System.Drawing.Point(286, 76);
            this.BtnBorrarPers1.Name = "BtnBorrarPers1";
            this.BtnBorrarPers1.Size = new System.Drawing.Size(132, 58);
            this.BtnBorrarPers1.TabIndex = 8;
            this.BtnBorrarPers1.Text = "Borrar personaje 1";
            this.BtnBorrarPers1.UseVisualStyleBackColor = true;
            this.BtnBorrarPers1.Click += new System.EventHandler(this.BtnBorrarPers1_Click);
            // 
            // BtnBorrarPers2
            // 
            this.BtnBorrarPers2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrarPers2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnBorrarPers2.FlatAppearance.BorderSize = 5;
            this.BtnBorrarPers2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarPers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarPers2.Location = new System.Drawing.Point(748, 76);
            this.BtnBorrarPers2.Name = "BtnBorrarPers2";
            this.BtnBorrarPers2.Size = new System.Drawing.Size(132, 58);
            this.BtnBorrarPers2.TabIndex = 9;
            this.BtnBorrarPers2.Text = "Borrar personaje 2";
            this.BtnBorrarPers2.UseVisualStyleBackColor = true;
            this.BtnBorrarPers2.Click += new System.EventHandler(this.BtnBorrarPers2_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(370, 400);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(0, 20);
            this.LblMensaje.TabIndex = 10;
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMensaje.Visible = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 5;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalir.Location = new System.Drawing.Point(1033, 575);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(145, 50);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 60);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pulse \"Mover\", para iniciar ...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prueba_While_movimientos
            // 
            this.AcceptButton = this.BtnMovCoyote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1190, 654);
            this.Controls.Add(this.PicCoyote);
            this.Controls.Add(this.PicBeep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.BtnBorrarPers2);
            this.Controls.Add(this.BtnBorrarPers1);
            this.Controls.Add(this.BntAparecer2);
            this.Controls.Add(this.BtnAparecer);
            this.Controls.Add(this.BtnMovCoyote);
            this.Controls.Add(this.BtnReac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button BtnReac;
        private System.Windows.Forms.Button BtnAparecer;
        private System.Windows.Forms.Button BntAparecer2;
        private System.Windows.Forms.Button BtnBorrarPers1;
        private System.Windows.Forms.Button BtnBorrarPers2;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
    }
}