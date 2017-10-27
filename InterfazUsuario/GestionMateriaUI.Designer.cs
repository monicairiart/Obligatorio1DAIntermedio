namespace InterfazUsuario
{
    partial class GestionMateriaUI
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
            this.tituloMantenimientoMateria = new System.Windows.Forms.Label();
            this.botonModificarMateria = new System.Windows.Forms.Button();
            this.botonBajarMateria = new System.Windows.Forms.Button();
            this.panelVentanaMateria = new System.Windows.Forms.Panel();
            this.tituloCodigoMateria = new System.Windows.Forms.Label();
            this.tituloNombreMateria = new System.Windows.Forms.Label();
            this.entradaNombreMateria = new System.Windows.Forms.TextBox();
            this.listaMaterias = new System.Windows.Forms.ListView();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonAltaMateria = new System.Windows.Forms.Button();
            this.entradaCodigoMateria = new System.Windows.Forms.TextBox();
            this.panelVentanaMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloMantenimientoMateria
            // 
            this.tituloMantenimientoMateria.AutoSize = true;
            this.tituloMantenimientoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientoMateria.Location = new System.Drawing.Point(189, 9);
            this.tituloMantenimientoMateria.Name = "tituloMantenimientoMateria";
            this.tituloMantenimientoMateria.Size = new System.Drawing.Size(299, 26);
            this.tituloMantenimientoMateria.TabIndex = 23;
            this.tituloMantenimientoMateria.Text = "Mantenimiento de Materias";
            this.tituloMantenimientoMateria.Click += new System.EventHandler(this.tituloMantenimientoAlumnos_Click);
            // 
            // botonModificarMateria
            // 
            this.botonModificarMateria.Location = new System.Drawing.Point(556, 141);
            this.botonModificarMateria.Name = "botonModificarMateria";
            this.botonModificarMateria.Size = new System.Drawing.Size(75, 23);
            this.botonModificarMateria.TabIndex = 31;
            this.botonModificarMateria.Text = "Modificar";
            this.botonModificarMateria.UseVisualStyleBackColor = true;
            this.botonModificarMateria.Click += new System.EventHandler(this.botonModificarMateria_Click);
            // 
            // botonBajarMateria
            // 
            this.botonBajarMateria.Location = new System.Drawing.Point(556, 112);
            this.botonBajarMateria.Name = "botonBajarMateria";
            this.botonBajarMateria.Size = new System.Drawing.Size(75, 23);
            this.botonBajarMateria.TabIndex = 30;
            this.botonBajarMateria.Text = "Bajar";
            this.botonBajarMateria.UseVisualStyleBackColor = true;
            this.botonBajarMateria.Click += new System.EventHandler(this.botonBajarMateria_Click);
            // 
            // panelVentanaMateria
            // 
            this.panelVentanaMateria.Controls.Add(this.tituloCodigoMateria);
            this.panelVentanaMateria.Controls.Add(this.tituloNombreMateria);
            this.panelVentanaMateria.Controls.Add(this.entradaCodigoMateria);
            this.panelVentanaMateria.Controls.Add(this.entradaNombreMateria);
            this.panelVentanaMateria.Controls.Add(this.listaMaterias);
            this.panelVentanaMateria.Location = new System.Drawing.Point(40, 64);
            this.panelVentanaMateria.Name = "panelVentanaMateria";
            this.panelVentanaMateria.Size = new System.Drawing.Size(475, 313);
            this.panelVentanaMateria.TabIndex = 29;
            // 
            // tituloCodigoMateria
            // 
            this.tituloCodigoMateria.AutoSize = true;
            this.tituloCodigoMateria.Location = new System.Drawing.Point(53, 18);
            this.tituloCodigoMateria.Name = "tituloCodigoMateria";
            this.tituloCodigoMateria.Size = new System.Drawing.Size(78, 13);
            this.tituloCodigoMateria.TabIndex = 6;
            this.tituloCodigoMateria.Text = "Código Materia";
            // 
            // tituloNombreMateria
            // 
            this.tituloNombreMateria.AutoSize = true;
            this.tituloNombreMateria.Location = new System.Drawing.Point(186, 18);
            this.tituloNombreMateria.Name = "tituloNombreMateria";
            this.tituloNombreMateria.Size = new System.Drawing.Size(44, 13);
            this.tituloNombreMateria.TabIndex = 4;
            this.tituloNombreMateria.Text = "Nombre";
            // 
            // entradaNombreMateria
            // 
            this.entradaNombreMateria.Location = new System.Drawing.Point(189, 48);
            this.entradaNombreMateria.Name = "entradaNombreMateria";
            this.entradaNombreMateria.Size = new System.Drawing.Size(100, 20);
            this.entradaNombreMateria.TabIndex = 1;
            // 
            // listaMaterias
            // 
            this.listaMaterias.Location = new System.Drawing.Point(56, 84);
            this.listaMaterias.Name = "listaMaterias";
            this.listaMaterias.Size = new System.Drawing.Size(349, 177);
            this.listaMaterias.TabIndex = 0;
            this.listaMaterias.UseCompatibleStateImageBehavior = false;
            this.listaMaterias.SelectedIndexChanged += new System.EventHandler(this.listaMaterias_SelectedIndexChanged);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(556, 225);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 28;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // botonAltaMateria
            // 
            this.botonAltaMateria.Location = new System.Drawing.Point(556, 83);
            this.botonAltaMateria.Name = "botonAltaMateria";
            this.botonAltaMateria.Size = new System.Drawing.Size(75, 23);
            this.botonAltaMateria.TabIndex = 27;
            this.botonAltaMateria.Text = "Agregar";
            this.botonAltaMateria.UseVisualStyleBackColor = true;
            this.botonAltaMateria.Click += new System.EventHandler(this.botonAltaMateria_Click);
            // 
            // entradaCodigoMateria
            // 
            this.entradaCodigoMateria.Location = new System.Drawing.Point(56, 50);
            this.entradaCodigoMateria.Name = "entradaCodigoMateria";
            this.entradaCodigoMateria.Size = new System.Drawing.Size(100, 20);
            this.entradaCodigoMateria.TabIndex = 3;
            // 
            // GestionMateriaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(648, 305);
            this.Controls.Add(this.botonModificarMateria);
            this.Controls.Add(this.botonBajarMateria);
            this.Controls.Add(this.panelVentanaMateria);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonAltaMateria);
            this.Controls.Add(this.tituloMantenimientoMateria);
            this.Name = "GestionMateriaUI";
            this.Text = "GestionMateria";
            this.Load += new System.EventHandler(this.GestionMateriaUI_Load);
            this.panelVentanaMateria.ResumeLayout(false);
            this.panelVentanaMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloMantenimientoMateria;
        private System.Windows.Forms.Button botonModificarMateria;
        private System.Windows.Forms.Button botonBajarMateria;
        private System.Windows.Forms.Panel panelVentanaMateria;
        private System.Windows.Forms.Label tituloCodigoMateria;
        private System.Windows.Forms.Label tituloNombreMateria;
        private System.Windows.Forms.TextBox entradaCodigoMateria;
        private System.Windows.Forms.TextBox entradaNombreMateria;
        private System.Windows.Forms.ListView listaMaterias;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonAltaMateria;
    }
}