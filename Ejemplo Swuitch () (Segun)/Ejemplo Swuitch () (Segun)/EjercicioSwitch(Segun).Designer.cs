
namespace Ejemplo_Swuitch_____Segun_
{
    partial class Ejercicio_Switch_Segun_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOper1 = new System.Windows.Forms.TextBox();
            this.TxtSigno = new System.Windows.Forms.TextBox();
            this.TxtOper2 = new System.Windows.Forms.TextBox();
            this.BtnRes = new System.Windows.Forms.Button();
            this.TxtRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operador 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operador 1";
            // 
            // TxtOper1
            // 
            this.TxtOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOper1.Location = new System.Drawing.Point(45, 78);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 29);
            this.TxtOper1.TabIndex = 2;
            // 
            // TxtSigno
            // 
            this.TxtSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSigno.Location = new System.Drawing.Point(211, 78);
            this.TxtSigno.Name = "TxtSigno";
            this.TxtSigno.Size = new System.Drawing.Size(100, 29);
            this.TxtSigno.TabIndex = 3;
            this.TxtSigno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtOper2
            // 
            this.TxtOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOper2.Location = new System.Drawing.Point(368, 78);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 29);
            this.TxtOper2.TabIndex = 4;
            // 
            // BtnRes
            // 
            this.BtnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.Location = new System.Drawing.Point(497, 73);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(75, 41);
            this.BtnRes.TabIndex = 5;
            this.BtnRes.Text = "=";
            this.BtnRes.UseVisualStyleBackColor = true;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // TxtRes
            // 
            this.TxtRes.BackColor = System.Drawing.Color.White;
            this.TxtRes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtRes.Enabled = false;
            this.TxtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRes.Location = new System.Drawing.Point(637, 78);
            this.TxtRes.Name = "TxtRes";
            this.TxtRes.Size = new System.Drawing.Size(132, 29);
            this.TxtRes.TabIndex = 6;
            this.TxtRes.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado de la operación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingrese signo";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(21, 130);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(93, 41);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLimpiar.Location = new System.Drawing.Point(637, 130);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(243, 41);
            this.BtLimpiar.TabIndex = 12;
            this.BtLimpiar.Text = "Limpiar operación";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // Ejercicio_Switch_Segun_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 183);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtRes);
            this.Controls.Add(this.BtnRes);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.TxtSigno);
            this.Controls.Add(this.TxtOper1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio_Switch_Segun_";
            this.Text = "Ejercicio_Switch_Segun_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOper1;
        private System.Windows.Forms.TextBox TxtSigno;
        private System.Windows.Forms.TextBox TxtOper2;
        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.TextBox TxtRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtLimpiar;
    }
}