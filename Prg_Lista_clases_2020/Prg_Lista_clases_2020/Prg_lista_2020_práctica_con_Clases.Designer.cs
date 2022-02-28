
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblista = new System.Windows.Forms.Label();
            this.BtMostrar = new System.Windows.Forms.Button();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtIngreso
            // 
            this.BtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIngreso.Location = new System.Drawing.Point(181, 68);
            this.BtIngreso.Name = "BtIngreso";
            this.BtIngreso.Size = new System.Drawing.Size(131, 32);
            this.BtIngreso.TabIndex = 0;
            this.BtIngreso.Text = "Cargar";
            this.BtIngreso.UseVisualStyleBackColor = true;
            this.BtIngreso.Click += new System.EventHandler(this.BtIngreso_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(46, 68);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 32);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese nombre";
            // 
            // Lblista
            // 
            this.Lblista.AutoSize = true;
            this.Lblista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblista.Location = new System.Drawing.Point(133, 255);
            this.Lblista.Name = "Lblista";
            this.Lblista.Size = new System.Drawing.Size(43, 20);
            this.Lblista.TabIndex = 3;
            this.Lblista.Text = "Lista";
            // 
            // BtMostrar
            // 
            this.BtMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrar.Location = new System.Drawing.Point(318, 68);
            this.BtMostrar.Name = "BtMostrar";
            this.BtMostrar.Size = new System.Drawing.Size(131, 32);
            this.BtMostrar.TabIndex = 4;
            this.BtMostrar.Text = "Mostrar lista";
            this.BtMostrar.UseVisualStyleBackColor = true;
            this.BtMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLimpiar.Location = new System.Drawing.Point(181, 113);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(131, 47);
            this.BtLimpiar.TabIndex = 5;
            this.BtLimpiar.Text = "Limpiar datos cargados";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(204, 489);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(89, 32);
            this.BtSalir.TabIndex = 6;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista de personas cargadas";
            // 
            // Prg_lista_2020_práctica_con_Clases
            // 
            this.AcceptButton = this.BtIngreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(469, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtMostrar);
            this.Controls.Add(this.Lblista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtIngreso);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Prg_lista_2020_práctica_con_Clases";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prg_lista_2020_práctica_con_Clases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtIngreso;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblista;
        private System.Windows.Forms.Button BtMostrar;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Label label2;
    }
}