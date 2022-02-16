
namespace PrgCargaPersonas2022_Practica_
{
    partial class Prg_IngresoDe_Datos
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
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtMostrar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblMostrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDim = new System.Windows.Forms.TextBox();
            this.BtDim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtFinalizar = new System.Windows.Forms.Button();
            this.BtDatosKill = new System.Windows.Forms.Button();
            this.LbLista = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.BtEdad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCargar
            // 
            this.BtnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(211, 209);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(96, 32);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtMostrar
            // 
            this.BtMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMostrar.Location = new System.Drawing.Point(649, 471);
            this.BtMostrar.Name = "BtMostrar";
            this.BtMostrar.Size = new System.Drawing.Size(247, 32);
            this.BtMostrar.TabIndex = 1;
            this.BtMostrar.Text = "Mostrar datos cargados";
            this.BtMostrar.UseVisualStyleBackColor = true;
            this.BtMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(16, 209);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(189, 32);
            this.TxtNombre.TabIndex = 2;
            // 
            // LblMostrar
            // 
            this.LblMostrar.AutoSize = true;
            this.LblMostrar.Location = new System.Drawing.Point(12, 316);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(0, 13);
            this.LblMostrar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Programa - Carga de datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDim
            // 
            this.TxtDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDim.Location = new System.Drawing.Point(146, 122);
            this.TxtDim.Name = "TxtDim";
            this.TxtDim.Size = new System.Drawing.Size(81, 32);
            this.TxtDim.TabIndex = 7;
            // 
            // BtDim
            // 
            this.BtDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDim.Location = new System.Drawing.Point(15, 122);
            this.BtDim.Name = "BtDim";
            this.BtDim.Size = new System.Drawing.Size(121, 32);
            this.BtDim.TabIndex = 6;
            this.BtDim.Text = "Dimensionar";
            this.BtDim.UseVisualStyleBackColor = true;
            this.BtDim.Click += new System.EventHandler(this.BtDim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingrese la cantidad de personas a cargar (Debe expresar en números)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese nombre completo de la persona";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtFinalizar
            // 
            this.BtFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFinalizar.Location = new System.Drawing.Point(422, 473);
            this.BtFinalizar.Name = "BtFinalizar";
            this.BtFinalizar.Size = new System.Drawing.Size(69, 30);
            this.BtFinalizar.TabIndex = 11;
            this.BtFinalizar.Text = "Finalizar";
            this.BtFinalizar.UseVisualStyleBackColor = true;
            this.BtFinalizar.Click += new System.EventHandler(this.BtFinalizar_Click);
            // 
            // BtDatosKill
            // 
            this.BtDatosKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDatosKill.Location = new System.Drawing.Point(57, 22);
            this.BtDatosKill.Name = "BtDatosKill";
            this.BtDatosKill.Size = new System.Drawing.Size(165, 34);
            this.BtDatosKill.TabIndex = 12;
            this.BtDatosKill.Text = "Borrar datos cargados";
            this.BtDatosKill.UseVisualStyleBackColor = true;
            this.BtDatosKill.Click += new System.EventHandler(this.BtDatosKill_Click);
            // 
            // LbLista
            // 
            this.LbLista.AutoSize = true;
            this.LbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLista.Location = new System.Drawing.Point(188, 265);
            this.LbLista.Name = "LbLista";
            this.LbLista.Size = new System.Drawing.Size(0, 17);
            this.LbLista.TabIndex = 13;
            this.LbLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(16, 280);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(189, 32);
            this.TxtEdad.TabIndex = 15;
            // 
            // BtEdad
            // 
            this.BtEdad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEdad.Location = new System.Drawing.Point(211, 280);
            this.BtEdad.Name = "BtEdad";
            this.BtEdad.Size = new System.Drawing.Size(96, 32);
            this.BtEdad.TabIndex = 14;
            this.BtEdad.Text = "Cargar";
            this.BtEdad.UseVisualStyleBackColor = true;
            this.BtEdad.Click += new System.EventHandler(this.BtEdad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Edad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prg_IngresoDe_Datos
            // 
            this.AcceptButton = this.BtnCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(935, 515);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.BtEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbLista);
            this.Controls.Add(this.BtDatosKill);
            this.Controls.Add(this.BtFinalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDim);
            this.Controls.Add(this.BtDim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMostrar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtMostrar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.label3);
            this.Name = "Prg_IngresoDe_Datos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prg_IngresoDe_Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtMostrar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDim;
        private System.Windows.Forms.Button BtDim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtFinalizar;
        private System.Windows.Forms.Button BtDatosKill;
        private System.Windows.Forms.Label LbLista;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Button BtEdad;
        private System.Windows.Forms.Label label4;
    }
}