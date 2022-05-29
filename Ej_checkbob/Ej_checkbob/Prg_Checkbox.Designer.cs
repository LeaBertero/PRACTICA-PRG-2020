namespace Ej_checkbob
{
    partial class Prg_Checkbox
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btlimpiar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxNomApellido = new System.Windows.Forms.TextBox();
            this.TxDirección = new System.Windows.Forms.TextBox();
            this.TxTel = new System.Windows.Forms.TextBox();
            this.TxEdad = new System.Windows.Forms.TextBox();
            this.TxDocu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DgDatosPersonles = new System.Windows.Forms.DataGridView();
            this.NomApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.Btborrar = new System.Windows.Forms.Button();
            this.LbInfo = new System.Windows.Forms.Label();
            this.BtLimp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgDatosPersonles)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(72, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Hombre";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(72, 130);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mujer";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // BtAceptar
            // 
            this.BtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAceptar.Location = new System.Drawing.Point(72, 169);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtAceptar.TabIndex = 2;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // Btlimpiar
            // 
            this.Btlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btlimpiar.Location = new System.Drawing.Point(153, 169);
            this.Btlimpiar.Name = "Btlimpiar";
            this.Btlimpiar.Size = new System.Drawing.Size(112, 23);
            this.Btlimpiar.TabIndex = 4;
            this.Btlimpiar.Text = "Limpiar controles";
            this.Btlimpiar.UseVisualStyleBackColor = true;
            this.Btlimpiar.Click += new System.EventHandler(this.Btlimpiar_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(610, 574);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(95, 34);
            this.BtSalir.TabIndex = 5;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione una de las opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datos personales";
            // 
            // TxNomApellido
            // 
            this.TxNomApellido.Location = new System.Drawing.Point(514, 100);
            this.TxNomApellido.Name = "TxNomApellido";
            this.TxNomApellido.Size = new System.Drawing.Size(100, 20);
            this.TxNomApellido.TabIndex = 8;
            // 
            // TxDirección
            // 
            this.TxDirección.Location = new System.Drawing.Point(514, 134);
            this.TxDirección.Name = "TxDirección";
            this.TxDirección.Size = new System.Drawing.Size(100, 20);
            this.TxDirección.TabIndex = 9;
            // 
            // TxTel
            // 
            this.TxTel.Location = new System.Drawing.Point(514, 247);
            this.TxTel.Name = "TxTel";
            this.TxTel.Size = new System.Drawing.Size(100, 20);
            this.TxTel.TabIndex = 10;
            // 
            // TxEdad
            // 
            this.TxEdad.Location = new System.Drawing.Point(514, 209);
            this.TxEdad.Name = "TxEdad";
            this.TxEdad.Size = new System.Drawing.Size(100, 20);
            this.TxEdad.TabIndex = 11;
            // 
            // TxDocu
            // 
            this.TxDocu.Location = new System.Drawing.Point(514, 169);
            this.TxDocu.Name = "TxDocu";
            this.TxDocu.Size = new System.Drawing.Size(100, 20);
            this.TxDocu.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre y apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Edad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "D.N.I";
            // 
            // DgDatosPersonles
            // 
            this.DgDatosPersonles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDatosPersonles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomApe,
            this.Dir,
            this.Tel,
            this.Ed,
            this.Doc});
            this.DgDatosPersonles.Location = new System.Drawing.Point(44, 316);
            this.DgDatosPersonles.Name = "DgDatosPersonles";
            this.DgDatosPersonles.Size = new System.Drawing.Size(535, 216);
            this.DgDatosPersonles.TabIndex = 18;
            this.DgDatosPersonles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Carga_datos_personales);
            // 
            // NomApe
            // 
            this.NomApe.HeaderText = "Nombre y apellido";
            this.NomApe.Name = "NomApe";
            // 
            // Dir
            // 
            this.Dir.HeaderText = "Dirección";
            this.Dir.Name = "Dir";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Teléfono";
            this.Tel.Name = "Tel";
            // 
            // Ed
            // 
            this.Ed.HeaderText = "Edad";
            this.Ed.Name = "Ed";
            // 
            // Doc
            // 
            this.Doc.HeaderText = "DNI";
            this.Doc.Name = "Doc";
            // 
            // BtAgregar
            // 
            this.BtAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAgregar.Location = new System.Drawing.Point(610, 446);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(95, 40);
            this.BtAgregar.TabIndex = 19;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // Btborrar
            // 
            this.Btborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btborrar.Location = new System.Drawing.Point(610, 492);
            this.Btborrar.Name = "Btborrar";
            this.Btborrar.Size = new System.Drawing.Size(95, 40);
            this.Btborrar.TabIndex = 20;
            this.Btborrar.Text = "Borrar";
            this.Btborrar.UseVisualStyleBackColor = true;
            this.Btborrar.Click += new System.EventHandler(this.Btborrar_Click);
            // 
            // LbInfo
            // 
            this.LbInfo.AutoSize = true;
            this.LbInfo.Location = new System.Drawing.Point(41, 586);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(62, 13);
            this.LbInfo.TabIndex = 21;
            this.LbInfo.Text = "Informacion";
            // 
            // BtLimp
            // 
            this.BtLimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLimp.Location = new System.Drawing.Point(610, 400);
            this.BtLimp.Name = "BtLimp";
            this.BtLimp.Size = new System.Drawing.Size(95, 40);
            this.BtLimp.TabIndex = 22;
            this.BtLimp.Text = "Limpiar";
            this.BtLimp.UseVisualStyleBackColor = true;
            this.BtLimp.Click += new System.EventHandler(this.BtLimp_Click);
            // 
            // Prg_Checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(717, 620);
            this.Controls.Add(this.BtLimp);
            this.Controls.Add(this.LbInfo);
            this.Controls.Add(this.Btborrar);
            this.Controls.Add(this.BtAgregar);
            this.Controls.Add(this.DgDatosPersonles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxDocu);
            this.Controls.Add(this.TxEdad);
            this.Controls.Add(this.TxTel);
            this.Controls.Add(this.TxDirección);
            this.Controls.Add(this.TxNomApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.Btlimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtAceptar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Prg_Checkbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos personales";
            ((System.ComponentModel.ISupportInitialize)(this.DgDatosPersonles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btlimpiar;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxNomApellido;
        private System.Windows.Forms.TextBox TxDirección;
        private System.Windows.Forms.TextBox TxTel;
        private System.Windows.Forms.TextBox TxEdad;
        private System.Windows.Forms.TextBox TxDocu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgDatosPersonles;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Button Btborrar;
        private System.Windows.Forms.Label LbInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.Button BtLimp;
    }
}

