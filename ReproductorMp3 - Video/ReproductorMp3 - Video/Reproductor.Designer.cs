﻿
namespace ReproductorMp3___Video
{
    partial class Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnRep = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.WinMedaP = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WinMedaP)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(12, 354);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnRep
            // 
            this.BtnRep.Location = new System.Drawing.Point(117, 354);
            this.BtnRep.Name = "BtnRep";
            this.BtnRep.Size = new System.Drawing.Size(75, 23);
            this.BtnRep.TabIndex = 1;
            this.BtnRep.Text = "Reproducir";
            this.BtnRep.UseVisualStyleBackColor = true;
            this.BtnRep.Click += new System.EventHandler(this.BtnRep_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(226, 354);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(331, 354);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 23);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Location = new System.Drawing.Point(9, 399);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(0, 13);
            this.LblMensaje.TabIndex = 4;
            // 
            // WinMedaP
            // 
            this.WinMedaP.Enabled = true;
            this.WinMedaP.Location = new System.Drawing.Point(12, 86);
            this.WinMedaP.Name = "WinMedaP";
            this.WinMedaP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMedaP.OcxState")));
            this.WinMedaP.Size = new System.Drawing.Size(500, 243);
            this.WinMedaP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "REPRODUCTOR DE MP3 / MP4";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(432, 352);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 25);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Close";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Reproductor
            // 
            this.AcceptButton = this.BtnCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(633, 420);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WinMedaP);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnRep);
            this.Controls.Add(this.BtnCargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reproductor";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.WinMedaP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnRep;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Label LblMensaje;
        private AxWMPLib.AxWindowsMediaPlayer WinMedaP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSalir;
    }
}