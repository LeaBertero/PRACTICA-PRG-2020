
namespace Operadores_practica
{
    partial class Operadores
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
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.LblContador = new System.Windows.Forms.Label();
            this.Bt_op_log = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtCorto = new System.Windows.Forms.Button();
            this.LblResOpLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEjecutar.Location = new System.Drawing.Point(31, 37);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(164, 39);
            this.BtnEjecutar.TabIndex = 0;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // LblContador
            // 
            this.LblContador.BackColor = System.Drawing.Color.Red;
            this.LblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContador.Location = new System.Drawing.Point(68, 115);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(79, 69);
            this.LblContador.TabIndex = 1;
            this.LblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_op_log
            // 
            this.Bt_op_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_op_log.Location = new System.Drawing.Point(329, 37);
            this.Bt_op_log.Name = "Bt_op_log";
            this.Bt_op_log.Size = new System.Drawing.Size(214, 39);
            this.Bt_op_log.TabIndex = 2;
            this.Bt_op_log.Text = "Operacion logica";
            this.Bt_op_log.UseVisualStyleBackColor = true;
            this.Bt_op_log.Click += new System.EventHandler(this.Bt_op_log_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.Color.Turquoise;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(393, 115);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(79, 69);
            this.LblResultado.TabIndex = 3;
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(329, 215);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(214, 39);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtCorto
            // 
            this.BtCorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCorto.Location = new System.Drawing.Point(593, 37);
            this.BtCorto.Name = "BtCorto";
            this.BtCorto.Size = new System.Drawing.Size(214, 39);
            this.BtCorto.TabIndex = 5;
            this.BtCorto.Text = "Operacion logica";
            this.BtCorto.UseVisualStyleBackColor = true;
            this.BtCorto.Click += new System.EventHandler(this.BtCorto_Click);
            // 
            // LblResOpLog
            // 
            this.LblResOpLog.BackColor = System.Drawing.Color.Gold;
            this.LblResOpLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResOpLog.Location = new System.Drawing.Point(657, 115);
            this.LblResOpLog.Name = "LblResOpLog";
            this.LblResOpLog.Size = new System.Drawing.Size(79, 69);
            this.LblResOpLog.TabIndex = 6;
            this.LblResOpLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Operadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(840, 275);
            this.Controls.Add(this.LblResOpLog);
            this.Controls.Add(this.BtCorto);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.Bt_op_log);
            this.Controls.Add(this.LblContador);
            this.Controls.Add(this.BtnEjecutar);
            this.Name = "Operadores";
            this.Text = "Operadores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.Label LblContador;
        private System.Windows.Forms.Button Bt_op_log;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtCorto;
        private System.Windows.Forms.Label LblResOpLog;
    }
}