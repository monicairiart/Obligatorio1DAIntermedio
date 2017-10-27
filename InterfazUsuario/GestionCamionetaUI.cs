using GestionCamioneta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class GestionCamionetaUI : Form
    {
        MantenimientoCamioneta mantenimientoCamioneta = new MantenimientoCamioneta();
        string matriculaCamionetaSeleccionada;
        public GestionCamionetaUI()
        {
            InitializeComponent();
        }
        private void GestionCamionetaUI_Load(object sender, EventArgs e)
        {
            mantenimientoCamioneta.GenerarDatos();
            //Console.WriteLine("count camionetas " + mantenimientoCamioneta.GetCamionetas().Count());
            listaCamionetas.Columns.Add("Matricula");
            listaCamionetas.Columns.Add("Capacidad");
            listaCamionetas.Columns.Add("Estado");

            /*ListViewItem itemCamioneta = new ListViewItem("ASF3333");
            //itemCamioneta.SubItems.Add("ASF3333");
            itemCamioneta.SubItems.Add("40");
            itemCamioneta.SubItems.Add("Disponible");

            listaCamionetas.View = View.Details;
            listaCamionetas.Items.Add(itemCamioneta);*/
            cargarListaCamioneta();
        }
        private void cargarListaCamioneta()
        {
            listaCamionetas.Items.Clear();
            listaCamionetas.View = View.Details;
            foreach (Camioneta camioneta in mantenimientoCamioneta.GetCamionetas())
            {
                ListViewItem itemCamioneta = new ListViewItem(camioneta.Matricula);
                itemCamioneta.SubItems.Add(camioneta.Capacidad.ToString());
                itemCamioneta.SubItems.Add(camioneta.Estado);

                listaCamionetas.Items.Add(itemCamioneta);
            }
        }
        private void listaCamionetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection camionetaSeleccionada = listaCamionetas.SelectedItems;
            if (camionetaSeleccionada.Count > 0)
            {
                Console.WriteLine("camioneta seleccionada count" + camionetaSeleccionada.Count);
                Console.WriteLine("camioneta seleccionada" + camionetaSeleccionada[0].Text);

                Console.WriteLine("capacidad seleccionada" + camionetaSeleccionada[0].SubItems[1].Text);
                Console.WriteLine("estado seleccionado" + camionetaSeleccionada[0].SubItems[2].Text);

                entradaMatriculaCamioneta.Text = camionetaSeleccionada[0].SubItems[0].Text;
                entradaCapacidadCamioneta.Text = camionetaSeleccionada[0].SubItems[1].Text;
                entradaMatriculaCamioneta.Text = camionetaSeleccionada[0].SubItems[2].Text;
                matriculaCamionetaSeleccionada = camionetaSeleccionada[0].SubItems[2].Text;
            }
        }
        private void botonAltaCamioneta_Click(object sender, EventArgs e)
        {
            string matricula = entradaMatriculaCamioneta.Text;
            int capacidad = Int32.Parse(entradaCapacidadCamioneta.Text);
            string estado = entradaEstadoCamioneta.Text;
            mantenimientoCamioneta.AltaDatosCamioneta(matricula, capacidad, estado);
            cargarListaCamioneta();
        }
        private void tituloMantenimientosAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {

        }

        private void botonModificarCamioneta_Click(object sender, EventArgs e)
        {
            Camioneta camionetaModificada = new Camioneta();
            camionetaModificada.Matricula = entradaMatriculaCamioneta.Text;
            camionetaModificada.Capacidad = Int32.Parse(entradaCapacidadCamioneta.Text);
            camionetaModificada.Estado = entradaEstadoCamioneta.Text;
            mantenimientoCamioneta.ModificarCamioneta(matriculaCamionetaSeleccionada, camionetaModificada);
            cargarListaCamioneta();
        }

        private void botonBajarCamioneta_Click(object sender, EventArgs e)
        {
            mantenimientoCamioneta.BajaCamioneta(matriculaCamionetaSeleccionada);
            cargarListaCamioneta();
        }
    }
}
