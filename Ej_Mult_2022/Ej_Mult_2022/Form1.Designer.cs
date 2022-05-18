namespace Ej_Mult_2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxOp1 = new System.Windows.Forms.TextBox();
            this.TxOp2 = new System.Windows.Forms.TextBox();
            this.TxRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtMult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxOp1
            // 
            this.TxOp1.Location = new System.Drawing.Point(301, 119);
            this.TxOp1.Name = "TxOp1";
            this.TxOp1.Size = new System.Drawing.Size(100, 23);
            this.TxOp1.TabIndex = 0;
            // 
            // TxOp2
            // 
            this.TxOp2.Location = new System.Drawing.Point(301, 181);
            this.TxOp2.Name = "TxOp2";
            this.TxOp2.Size = new System.Drawing.Size(100, 23);
            this.TxOp2.TabIndex = 1;
            // 
            // TxRes
            // 
            this.TxRes.Location = new System.Drawing.Point(301, 237);
            this.TxRes.Name = "TxRes";
            this.TxRes.Size = new System.Drawing.Size(100, 23);
            this.TxRes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Operador 2";
            // 
            // BtMult
            // 
            this.BtMult.Location = new System.Drawing.Point(190, 237);
            this.BtMult.Name = "BtMult";
            this.BtMult.Size = new System.Drawing.Size(75, 23);
            this.BtMult.TabIndex = 5;
            this.BtMult.Text = "Multiplicar";
            this.BtMult.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ejercicio - Multiplicación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtMult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxRes);
            this.Controls.Add(this.TxOp2);
            this.Controls.Add(this.TxOp1);
            this.Name = "Form1";
            this.Text = "Multuplicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxOp1;
        private TextBox TxOp2;
        private TextBox TxRes;
        private Label label1;
        private Label label2;
        private Button BtMult;
        private Label label3;
    }
}