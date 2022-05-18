namespace GradosCelciusAFarenheitViceversa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxTemp = new System.Windows.Forms.TextBox();
            this.TxRes = new System.Windows.Forms.TextBox();
            this.BtCelcius = new System.Windows.Forms.Button();
            this.BtFar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado";
            // 
            // TxTemp
            // 
            this.TxTemp.Location = new System.Drawing.Point(289, 119);
            this.TxTemp.Name = "TxTemp";
            this.TxTemp.Size = new System.Drawing.Size(135, 23);
            this.TxTemp.TabIndex = 2;
            // 
            // TxRes
            // 
            this.TxRes.Location = new System.Drawing.Point(289, 167);
            this.TxRes.Name = "TxRes";
            this.TxRes.Size = new System.Drawing.Size(135, 23);
            this.TxRes.TabIndex = 3;
            // 
            // BtCelcius
            // 
            this.BtCelcius.Location = new System.Drawing.Point(289, 233);
            this.BtCelcius.Name = "BtCelcius";
            this.BtCelcius.Size = new System.Drawing.Size(135, 23);
            this.BtCelcius.TabIndex = 4;
            this.BtCelcius.Text = "Celcius a Farenheit";
            this.BtCelcius.UseVisualStyleBackColor = true;
            this.BtCelcius.Click += new System.EventHandler(this.BtCelcius_Click);
            // 
            // BtFar
            // 
            this.BtFar.Location = new System.Drawing.Point(129, 233);
            this.BtFar.Name = "BtFar";
            this.BtFar.Size = new System.Drawing.Size(135, 23);
            this.BtFar.TabIndex = 5;
            this.BtFar.Text = "Farenheit a Celcius";
            this.BtFar.UseVisualStyleBackColor = true;
            this.BtFar.Click += new System.EventHandler(this.BtFar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Programa de paso de temperaturas";
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Location = new System.Drawing.Point(129, 304);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(135, 23);
            this.BtLimpiar.TabIndex = 7;
            this.BtLimpiar.Text = "Limpiar";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(289, 304);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(135, 23);
            this.BtSalir.TabIndex = 8;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtFar);
            this.Controls.Add(this.BtCelcius);
            this.Controls.Add(this.TxRes);
            this.Controls.Add(this.TxTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celcuis a Farenheit y viceversa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxTemp;
        private TextBox TxRes;
        private Button BtCelcius;
        private Button BtFar;
        private Label label3;
        private Button BtLimpiar;
        private Button BtSalir;
    }
}