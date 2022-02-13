
namespace Prg_Lista_clases_2020
{
    partial class Prg_lista_2020_práctica_con_Clases
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
            this.BtIngreso = new System.Windows.Forms.Button();
            this.TxIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLista = new System.Windows.Forms.Label();
            this.BtVer = new System.Windows.Forms.Button();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtIngreso
            // 
            this.BtIngreso.Location = new System.Drawing.Point(181, 68);
            this.BtIngreso.Name = "BtIngreso";
            this.BtIngreso.Size = new System.Drawing.Size(131, 32);
            this.BtIngreso.TabIndex = 0;
            this.BtIngreso.Text = "Ingresar";
            this.BtIngreso.UseVisualStyleBackColor = true;
            this.BtIngreso.Click += new System.EventHandler(this.BtIngreso_Click);
            // 
            // TxIngreso
            // 
            this.TxIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxIngreso.Location = new System.Drawing.Point(46, 68);
            this.TxIngreso.Name = "TxIngreso";
            this.TxIngreso.Size = new System.Drawing.Size(100, 32);
            this.TxIngreso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre ";
            // 
            // lbLista
            // 
            this.lbLista.AutoSize = true;
            this.lbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLista.Location = new System.Drawing.Point(42, 150);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(43, 20);
            this.lbLista.TabIndex = 3;
            this.lbLista.Text = "Lista";
            // 
            // BtVer
            // 
            this.BtVer.Location = new System.Drawing.Point(319, 68);
            this.BtVer.Name = "BtVer";
            this.BtVer.Size = new System.Drawing.Size(131, 32);
            this.BtVer.TabIndex = 4;
            this.BtVer.Text = "Ver Lista";
            this.BtVer.UseVisualStyleBackColor = true;
            this.BtVer.Click += new System.EventHandler(this.BtVer_Click);
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Location = new System.Drawing.Point(181, 488);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(131, 32);
            this.BtLimpiar.TabIndex = 5;
            this.BtLimpiar.Text = "Limpiar datos";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(330, 488);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(131, 32);
            this.BtSalir.TabIndex = 6;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Prg_lista_2020_práctica_con_Clases
            // 
            this.AcceptButton = this.BtIngreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(462, 522);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtVer);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxIngreso);
            this.Controls.Add(this.BtIngreso);
            this.Name = "Prg_lista_2020_práctica_con_Clases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prg_lista_2020_práctica_con_Clases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtIngreso;
        private System.Windows.Forms.TextBox TxIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLista;
        private System.Windows.Forms.Button BtVer;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Button BtSalir;
    }
}