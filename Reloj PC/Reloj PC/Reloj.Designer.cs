
namespace Reloj_PC
{
    partial class Reloj
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reloj));
            this.LblReloj = new System.Windows.Forms.Label();
            this.timer1Reloj = new System.Windows.Forms.Timer(this.components);
            this.BtSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblReloj
            // 
            this.LblReloj.AutoSize = true;
            this.LblReloj.Font = new System.Drawing.Font("Old English Text MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReloj.Location = new System.Drawing.Point(57, 53);
            this.LblReloj.Name = "LblReloj";
            this.LblReloj.Size = new System.Drawing.Size(0, 77);
            this.LblReloj.TabIndex = 0;
            // 
            // timer1Reloj
            // 
            this.timer1Reloj.Enabled = true;
            this.timer1Reloj.Tick += new System.EventHandler(this.timer1Reloj_Tick);
            // 
            // BtSalir
            // 
            this.BtSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtSalir.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSalir.Location = new System.Drawing.Point(344, 179);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(77, 27);
            this.BtSalir.TabIndex = 1;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Reloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(433, 218);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.LblReloj);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reloj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblReloj;
        private System.Windows.Forms.Timer timer1Reloj;
        private System.Windows.Forms.Button BtSalir;
    }
}