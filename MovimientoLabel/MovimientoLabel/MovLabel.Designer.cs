
namespace MovimientoLabel
{
    partial class MovLabel
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
            this.LbMov1 = new System.Windows.Forms.Label();
            this.BtIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbMov1
            // 
            this.LbMov1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LbMov1.Location = new System.Drawing.Point(12, 12);
            this.LbMov1.Name = "LbMov1";
            this.LbMov1.Size = new System.Drawing.Size(74, 71);
            this.LbMov1.TabIndex = 0;
            // 
            // BtIniciar
            // 
            this.BtIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIniciar.Location = new System.Drawing.Point(271, 12);
            this.BtIniciar.Name = "BtIniciar";
            this.BtIniciar.Size = new System.Drawing.Size(86, 49);
            this.BtIniciar.TabIndex = 1;
            this.BtIniciar.Text = "Iniciar";
            this.BtIniciar.UseVisualStyleBackColor = true;
            this.BtIniciar.Click += new System.EventHandler(this.BtIniciar_Click);
            // 
            // MovLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 427);
            this.Controls.Add(this.BtIniciar);
            this.Controls.Add(this.LbMov1);
            this.Name = "MovLabel";
            this.Text = "MovLabel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbMov1;
        private System.Windows.Forms.Button BtIniciar;
    }
}