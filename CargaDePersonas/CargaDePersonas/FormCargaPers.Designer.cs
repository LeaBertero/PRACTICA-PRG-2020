
namespace CargaDePersonas
{
    partial class FormCargaPers
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblMostrarLista = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtBorrar = new System.Windows.Forms.Button();
            this.BtCleanLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnInscripcion = new System.Windows.Forms.Button();
            this.TxtInsMateria = new System.Windows.Forms.TextBox();
            this.TxtAñoMateria = new System.Windows.Forms.TextBox();
            this.LblInsMateria = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Khaki;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnAgregar.Location = new System.Drawing.Point(420, 67);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(121, 34);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Inscribir Alumno";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(18, 81);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(184, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indique el nombre de cada uno de los estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre y Apellido";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.Location = new System.Drawing.Point(15, 349);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 16);
            this.LblError.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edad";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(216, 81);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(184, 20);
            this.TxtEdad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mensaje de error de carga - (En caso de que exista), aparecerá aquí abajo";
            // 
            // LblMostrarLista
            // 
            this.LblMostrarLista.AutoSize = true;
            this.LblMostrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarLista.Location = new System.Drawing.Point(637, 114);
            this.LblMostrarLista.Name = "LblMostrarLista";
            this.LblMostrarLista.Size = new System.Drawing.Size(0, 16);
            this.LblMostrarLista.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(628, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lista de personas cargadas";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Khaki;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnLimpiar.Location = new System.Drawing.Point(345, 206);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(131, 49);
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.Text = "Limpiar errores";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(628, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre  -  Apellido  -  Edad";
            // 
            // BtSalir
            // 
            this.BtSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(1044, 438);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(108, 48);
            this.BtSalir.TabIndex = 14;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtBorrar
            // 
            this.BtBorrar.BackColor = System.Drawing.Color.Khaki;
            this.BtBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBorrar.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtBorrar.Location = new System.Drawing.Point(18, 206);
            this.BtBorrar.Name = "BtBorrar";
            this.BtBorrar.Size = new System.Drawing.Size(131, 49);
            this.BtBorrar.TabIndex = 15;
            this.BtBorrar.Text = "Borrar datos cargados";
            this.BtBorrar.UseVisualStyleBackColor = false;
            this.BtBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // BtCleanLista
            // 
            this.BtCleanLista.BackColor = System.Drawing.Color.Khaki;
            this.BtCleanLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCleanLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCleanLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCleanLista.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtCleanLista.Location = new System.Drawing.Point(185, 206);
            this.BtCleanLista.Name = "BtCleanLista";
            this.BtCleanLista.Size = new System.Drawing.Size(131, 49);
            this.BtCleanLista.TabIndex = 16;
            this.BtCleanLista.Text = "Borrar lista";
            this.BtCleanLista.UseVisualStyleBackColor = false;
            this.BtCleanLista.Click += new System.EventHandler(this.BtCleanLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Año de cursado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre materia";
            // 
            // BtnInscripcion
            // 
            this.BtnInscripcion.BackColor = System.Drawing.Color.Khaki;
            this.BtnInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInscripcion.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnInscripcion.Location = new System.Drawing.Point(420, 145);
            this.BtnInscripcion.Name = "BtnInscripcion";
            this.BtnInscripcion.Size = new System.Drawing.Size(121, 34);
            this.BtnInscripcion.TabIndex = 19;
            this.BtnInscripcion.Text = "Inscribir Materia";
            this.BtnInscripcion.UseVisualStyleBackColor = false;
            this.BtnInscripcion.Click += new System.EventHandler(this.BtnInscripcion_Click);
            // 
            // TxtInsMateria
            // 
            this.TxtInsMateria.Location = new System.Drawing.Point(18, 153);
            this.TxtInsMateria.Name = "TxtInsMateria";
            this.TxtInsMateria.Size = new System.Drawing.Size(184, 20);
            this.TxtInsMateria.TabIndex = 20;
            // 
            // TxtAñoMateria
            // 
            this.TxtAñoMateria.Location = new System.Drawing.Point(216, 153);
            this.TxtAñoMateria.Name = "TxtAñoMateria";
            this.TxtAñoMateria.Size = new System.Drawing.Size(184, 20);
            this.TxtAñoMateria.TabIndex = 21;
            // 
            // LblInsMateria
            // 
            this.LblInsMateria.AutoSize = true;
            this.LblInsMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInsMateria.Location = new System.Drawing.Point(887, 114);
            this.LblInsMateria.Name = "LblInsMateria";
            this.LblInsMateria.Size = new System.Drawing.Size(0, 16);
            this.LblInsMateria.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(876, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Inscripcion en materia";
            // 
            // FormCargaPers
            // 
            this.AcceptButton = this.BtnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1161, 495);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblInsMateria);
            this.Controls.Add(this.TxtAñoMateria);
            this.Controls.Add(this.TxtInsMateria);
            this.Controls.Add(this.BtnInscripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtCleanLista);
            this.Controls.Add(this.BtBorrar);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblMostrarLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "FormCargaPers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCargaPers";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblMostrarLista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtBorrar;
        private System.Windows.Forms.Button BtCleanLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnInscripcion;
        private System.Windows.Forms.TextBox TxtInsMateria;
        private System.Windows.Forms.TextBox TxtAñoMateria;
        private System.Windows.Forms.Label LblInsMateria;
        private System.Windows.Forms.Label label9;
    }
}