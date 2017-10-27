namespace InterfazUsuario
{
    partial class GestionCamionetaUI
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
            this.botonModificarCamioneta = new System.Windows.Forms.Button();
            this.botonBajarCamioneta = new System.Windows.Forms.Button();
            this.panelVentanaCamioneta = new System.Windows.Forms.Panel();
            this.tituloEstadoCamioneta = new System.Windows.Forms.Label();
            this.tituloCapacidadCamioneta = new System.Windows.Forms.Label();
            this.tituloMatriculaCamioneta = new System.Windows.Forms.Label();
            this.entradaEstadoCamioneta = new System.Windows.Forms.TextBox();
            this.entradaCapacidadCamioneta = new System.Windows.Forms.TextBox();
            this.entradaMatriculaCamioneta = new System.Windows.Forms.TextBox();
            this.listaCamionetas = new System.Windows.Forms.ListView();
            this.tituloMantenimientosCamionetas = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonAltaCamioneta = new System.Windows.Forms.Button();
            this.panelVentanaCamioneta.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonModificarCamioneta
            // 
            this.botonModificarCamioneta.Location = new System.Drawing.Point(561, 136);
            this.botonModificarCamioneta.Name = "botonModificarCamioneta";
            this.botonModificarCamioneta.Size = new System.Drawing.Size(75, 23);
            this.botonModificarCamioneta.TabIndex = 32;
            this.botonModificarCamioneta.Text = "Modificar";
            this.botonModificarCamioneta.UseVisualStyleBackColor = true;
            this.botonModificarCamioneta.Click += new System.EventHandler(this.botonModificarCamioneta_Click);
            // 
            // botonBajarCamioneta
            // 
            this.botonBajarCamioneta.Location = new System.Drawing.Point(561, 107);
            this.botonBajarCamioneta.Name = "botonBajarCamioneta";
            this.botonBajarCamioneta.Size = new System.Drawing.Size(75, 23);
            this.botonBajarCamioneta.TabIndex = 31;
            this.botonBajarCamioneta.Text = "Bajar";
            this.botonBajarCamioneta.UseVisualStyleBackColor = true;
            this.botonBajarCamioneta.Click += new System.EventHandler(this.botonBajarCamioneta_Click);
            // 
            // panelVentanaCamioneta
            // 
            this.panelVentanaCamioneta.Controls.Add(this.tituloEstadoCamioneta);
            this.panelVentanaCamioneta.Controls.Add(this.tituloCapacidadCamioneta);
            this.panelVentanaCamioneta.Controls.Add(this.tituloMatriculaCamioneta);
            this.panelVentanaCamioneta.Controls.Add(this.entradaEstadoCamioneta);
            this.panelVentanaCamioneta.Controls.Add(this.entradaCapacidadCamioneta);
            this.panelVentanaCamioneta.Controls.Add(this.entradaMatriculaCamioneta);
            this.panelVentanaCamioneta.Controls.Add(this.listaCamionetas);
            this.panelVentanaCamioneta.Location = new System.Drawing.Point(45, 59);
            this.panelVentanaCamioneta.Name = "panelVentanaCamioneta";
            this.panelVentanaCamioneta.Size = new System.Drawing.Size(475, 313);
            this.panelVentanaCamioneta.TabIndex = 30;
            // 
            // tituloEstadoCamioneta
            // 
            this.tituloEstadoCamioneta.AutoSize = true;
            this.tituloEstadoCamioneta.Location = new System.Drawing.Point(332, 18);
            this.tituloEstadoCamioneta.Name = "tituloEstadoCamioneta";
            this.tituloEstadoCamioneta.Size = new System.Drawing.Size(40, 13);
            this.tituloEstadoCamioneta.TabIndex = 6;
            this.tituloEstadoCamioneta.Text = "Estado";
            // 
            // tituloCapacidadCamioneta
            // 
            this.tituloCapacidadCamioneta.AutoSize = true;
            this.tituloCapacidadCamioneta.Location = new System.Drawing.Point(186, 18);
            this.tituloCapacidadCamioneta.Name = "tituloCapacidadCamioneta";
            this.tituloCapacidadCamioneta.Size = new System.Drawing.Size(58, 13);
            this.tituloCapacidadCamioneta.TabIndex = 5;
            this.tituloCapacidadCamioneta.Text = "Capacidad";
            // 
            // tituloMatriculaCamioneta
            // 
            this.tituloMatriculaCamioneta.AutoSize = true;
            this.tituloMatriculaCamioneta.Location = new System.Drawing.Point(56, 19);
            this.tituloMatriculaCamioneta.Name = "tituloMatriculaCamioneta";
            this.tituloMatriculaCamioneta.Size = new System.Drawing.Size(52, 13);
            this.tituloMatriculaCamioneta.TabIndex = 4;
            this.tituloMatriculaCamioneta.Text = "Matrícula";
            // 
            // entradaEstadoCamioneta
            // 
            this.entradaEstadoCamioneta.Location = new System.Drawing.Point(332, 50);
            this.entradaEstadoCamioneta.Name = "entradaEstadoCamioneta";
            this.entradaEstadoCamioneta.Size = new System.Drawing.Size(100, 20);
            this.entradaEstadoCamioneta.TabIndex = 3;
            // 
            // entradaCapacidadCamioneta
            // 
            this.entradaCapacidadCamioneta.Location = new System.Drawing.Point(186, 48);
            this.entradaCapacidadCamioneta.Name = "entradaCapacidadCamioneta";
            this.entradaCapacidadCamioneta.Size = new System.Drawing.Size(100, 20);
            this.entradaCapacidadCamioneta.TabIndex = 2;
            // 
            // entradaMatriculaCamioneta
            // 
            this.entradaMatriculaCamioneta.Location = new System.Drawing.Point(56, 48);
            this.entradaMatriculaCamioneta.Name = "entradaMatriculaCamioneta";
            this.entradaMatriculaCamioneta.Size = new System.Drawing.Size(100, 20);
            this.entradaMatriculaCamioneta.TabIndex = 1;
            // 
            // listaCamionetas
            // 
            this.listaCamionetas.Location = new System.Drawing.Point(56, 84);
            this.listaCamionetas.Name = "listaCamionetas";
            this.listaCamionetas.Size = new System.Drawing.Size(349, 177);
            this.listaCamionetas.TabIndex = 0;
            this.listaCamionetas.UseCompatibleStateImageBehavior = false;
            this.listaCamionetas.SelectedIndexChanged += new System.EventHandler(this.listaCamionetas_SelectedIndexChanged);
            // 
            // tituloMantenimientosCamionetas
            // 
            this.tituloMantenimientosCamionetas.AutoSize = true;
            this.tituloMantenimientosCamionetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientosCamionetas.Location = new System.Drawing.Point(185, 7);
            this.tituloMantenimientosCamionetas.Name = "tituloMantenimientosCamionetas";
            this.tituloMantenimientosCamionetas.Size = new System.Drawing.Size(335, 26);
            this.tituloMantenimientosCamionetas.TabIndex = 29;
            this.tituloMantenimientosCamionetas.Text = "Mantenimiento de Camionetas";
            this.tituloMantenimientosCamionetas.Click += new System.EventHandler(this.tituloMantenimientosAlumnos_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(561, 220);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 28;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonAltaCamioneta
            // 
            this.botonAltaCamioneta.Location = new System.Drawing.Point(561, 78);
            this.botonAltaCamioneta.Name = "botonAltaCamioneta";
            this.botonAltaCamioneta.Size = new System.Drawing.Size(75, 23);
            this.botonAltaCamioneta.TabIndex = 27;
            this.botonAltaCamioneta.Text = "Agregar";
            this.botonAltaCamioneta.UseVisualStyleBackColor = true;
            this.botonAltaCamioneta.Click += new System.EventHandler(this.botonAltaCamioneta_Click);
            // 
            // GestionCamionetaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(697, 369);
            this.Controls.Add(this.botonModificarCamioneta);
            this.Controls.Add(this.botonBajarCamioneta);
            this.Controls.Add(this.panelVentanaCamioneta);
            this.Controls.Add(this.tituloMantenimientosCamionetas);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonAltaCamioneta);
            this.Name = "GestionCamionetaUI";
            this.Text = "GestionCamionetaUI";
            this.Load += new System.EventHandler(this.GestionCamionetaUI_Load);
            this.panelVentanaCamioneta.ResumeLayout(false);
            this.panelVentanaCamioneta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonModificarCamioneta;
        private System.Windows.Forms.Button botonBajarCamioneta;
        private System.Windows.Forms.Panel panelVentanaCamioneta;
        private System.Windows.Forms.Label tituloEstadoCamioneta;
        private System.Windows.Forms.Label tituloCapacidadCamioneta;
        private System.Windows.Forms.Label tituloMatriculaCamioneta;
        private System.Windows.Forms.TextBox entradaEstadoCamioneta;
        private System.Windows.Forms.TextBox entradaCapacidadCamioneta;
        private System.Windows.Forms.TextBox entradaMatriculaCamioneta;
        private System.Windows.Forms.ListView listaCamionetas;
        private System.Windows.Forms.Label tituloMantenimientosCamionetas;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonAltaCamioneta;
    }
}