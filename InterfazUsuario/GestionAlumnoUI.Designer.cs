using GestionAlumno;

namespace InterfazUsuario
{
    partial class GestionAlumnoUI
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
            this.tituloMantenimientosAlumnos = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonModificarAlumno = new System.Windows.Forms.Button();
            this.botonBajarAlumno = new System.Windows.Forms.Button();
            this.botonAltaAlumno = new System.Windows.Forms.Button();
            this.listaAlumnos = new System.Windows.Forms.ListView();
            this.entradaNombreAlumno = new System.Windows.Forms.TextBox();
            this.entradaApellidoAlumno = new System.Windows.Forms.TextBox();
            this.entradaCIAlumno = new System.Windows.Forms.TextBox();
            this.tituloNombreAlumno = new System.Windows.Forms.Label();
            this.tituloApellidoAlumno = new System.Windows.Forms.Label();
            this.tituloCIAlumno = new System.Windows.Forms.Label();
            this.panelVentanaAlumno = new System.Windows.Forms.Panel();
            this.panelVentanaAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloMantenimientosAlumnos
            // 
            this.tituloMantenimientosAlumnos.AutoSize = true;
            this.tituloMantenimientosAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientosAlumnos.Location = new System.Drawing.Point(185, 9);
            this.tituloMantenimientosAlumnos.Name = "tituloMantenimientosAlumnos";
            this.tituloMantenimientosAlumnos.Size = new System.Drawing.Size(301, 26);
            this.tituloMantenimientosAlumnos.TabIndex = 23;
            this.tituloMantenimientosAlumnos.Text = "Mantenimiento de Alumnos";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(561, 222);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 18;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // botonModificarAlumno
            // 
            this.botonModificarAlumno.Location = new System.Drawing.Point(561, 138);
            this.botonModificarAlumno.Name = "botonModificarAlumno";
            this.botonModificarAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonModificarAlumno.TabIndex = 26;
            this.botonModificarAlumno.Text = "Modificar";
            this.botonModificarAlumno.UseVisualStyleBackColor = true;
            this.botonModificarAlumno.Click += new System.EventHandler(this.botonModificarAlumno_Click);
            // 
            // botonBajarAlumno
            // 
            this.botonBajarAlumno.Location = new System.Drawing.Point(561, 109);
            this.botonBajarAlumno.Name = "botonBajarAlumno";
            this.botonBajarAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonBajarAlumno.TabIndex = 25;
            this.botonBajarAlumno.Text = "Bajar";
            this.botonBajarAlumno.UseVisualStyleBackColor = true;
            this.botonBajarAlumno.Click += new System.EventHandler(this.botonBajarAlumno_Click);
            // 
            // botonAltaAlumno
            // 
            this.botonAltaAlumno.Location = new System.Drawing.Point(561, 80);
            this.botonAltaAlumno.Name = "botonAltaAlumno";
            this.botonAltaAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonAltaAlumno.TabIndex = 15;
            this.botonAltaAlumno.Text = "Agregar";
            this.botonAltaAlumno.UseVisualStyleBackColor = true;
            this.botonAltaAlumno.Click += new System.EventHandler(this.botonAltaAlumno_Click);
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(56, 84);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.Size = new System.Drawing.Size(349, 177);
            this.listaAlumnos.TabIndex = 0;
            this.listaAlumnos.UseCompatibleStateImageBehavior = false;
            this.listaAlumnos.SelectedIndexChanged += new System.EventHandler(this.listaAlumnos_SelectedIndexChanged);
            // 
            // entradaNombreAlumno
            // 
            this.entradaNombreAlumno.Location = new System.Drawing.Point(56, 48);
            this.entradaNombreAlumno.Name = "entradaNombreAlumno";
            this.entradaNombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.entradaNombreAlumno.TabIndex = 1;
            // 
            // entradaApellidoAlumno
            // 
            this.entradaApellidoAlumno.Location = new System.Drawing.Point(186, 48);
            this.entradaApellidoAlumno.Name = "entradaApellidoAlumno";
            this.entradaApellidoAlumno.Size = new System.Drawing.Size(100, 20);
            this.entradaApellidoAlumno.TabIndex = 2;
            // 
            // entradaCIAlumno
            // 
            this.entradaCIAlumno.Location = new System.Drawing.Point(332, 50);
            this.entradaCIAlumno.Name = "entradaCIAlumno";
            this.entradaCIAlumno.Size = new System.Drawing.Size(100, 20);
            this.entradaCIAlumno.TabIndex = 3;
            // 
            // tituloNombreAlumno
            // 
            this.tituloNombreAlumno.AutoSize = true;
            this.tituloNombreAlumno.Location = new System.Drawing.Point(56, 19);
            this.tituloNombreAlumno.Name = "tituloNombreAlumno";
            this.tituloNombreAlumno.Size = new System.Drawing.Size(44, 13);
            this.tituloNombreAlumno.TabIndex = 4;
            this.tituloNombreAlumno.Text = "Nombre";
            // 
            // tituloApellidoAlumno
            // 
            this.tituloApellidoAlumno.AutoSize = true;
            this.tituloApellidoAlumno.Location = new System.Drawing.Point(186, 18);
            this.tituloApellidoAlumno.Name = "tituloApellidoAlumno";
            this.tituloApellidoAlumno.Size = new System.Drawing.Size(44, 13);
            this.tituloApellidoAlumno.TabIndex = 5;
            this.tituloApellidoAlumno.Text = "Apellido";
            // 
            // tituloCIAlumno
            // 
            this.tituloCIAlumno.AutoSize = true;
            this.tituloCIAlumno.Location = new System.Drawing.Point(332, 18);
            this.tituloCIAlumno.Name = "tituloCIAlumno";
            this.tituloCIAlumno.Size = new System.Drawing.Size(87, 13);
            this.tituloCIAlumno.TabIndex = 6;
            this.tituloCIAlumno.Text = "Cédula Identidad";
            // 
            // panelVentanaAlumno
            // 
            this.panelVentanaAlumno.Controls.Add(this.tituloCIAlumno);
            this.panelVentanaAlumno.Controls.Add(this.tituloApellidoAlumno);
            this.panelVentanaAlumno.Controls.Add(this.tituloNombreAlumno);
            this.panelVentanaAlumno.Controls.Add(this.entradaCIAlumno);
            this.panelVentanaAlumno.Controls.Add(this.entradaApellidoAlumno);
            this.panelVentanaAlumno.Controls.Add(this.entradaNombreAlumno);
            this.panelVentanaAlumno.Controls.Add(this.listaAlumnos);
            this.panelVentanaAlumno.Location = new System.Drawing.Point(45, 61);
            this.panelVentanaAlumno.Name = "panelVentanaAlumno";
            this.panelVentanaAlumno.Size = new System.Drawing.Size(475, 313);
            this.panelVentanaAlumno.TabIndex = 24;
            // 
            // GestionAlumnoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(648, 305);
            this.Controls.Add(this.botonModificarAlumno);
            this.Controls.Add(this.botonBajarAlumno);
            this.Controls.Add(this.panelVentanaAlumno);
            this.Controls.Add(this.tituloMantenimientosAlumnos);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonAltaAlumno);
            this.Name = "GestionAlumnoUI";
            this.Text = "GestionAlumnoUI";
            this.Load += new System.EventHandler(this.GestionAlumnoUI_Load);
            this.panelVentanaAlumno.ResumeLayout(false);
            this.panelVentanaAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloMantenimientosAlumnos;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonModificarAlumno;
        private System.Windows.Forms.Button botonBajarAlumno;
        private System.Windows.Forms.Button botonAltaAlumno;
        private System.Windows.Forms.ListView listaAlumnos;
        private System.Windows.Forms.TextBox entradaNombreAlumno;
        private System.Windows.Forms.TextBox entradaApellidoAlumno;
        private System.Windows.Forms.TextBox entradaCIAlumno;
        private System.Windows.Forms.Label tituloNombreAlumno;
        private System.Windows.Forms.Label tituloApellidoAlumno;
        private System.Windows.Forms.Label tituloCIAlumno;
        private System.Windows.Forms.Panel panelVentanaAlumno;
    }
}