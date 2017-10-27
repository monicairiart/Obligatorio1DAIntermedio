using GestionMateria;
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
    public partial class GestionMateriaUI : Form
    {
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        string codigoMateriaSeleccionada;
        public GestionMateriaUI()
        {
            InitializeComponent();
        }

        private void tituloMantenimientoAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void botonAltaAlumno_Click(object sender, EventArgs e)
        {

        }

        private void GestionMateriaUI_Load(object sender, EventArgs e)
        {
            mantenimientoMateria.GenerarDatos();
            //Console.WriteLine("count alumnos " + mantenimientoAlumno.GetAlumnos().Count());
            listaMaterias.Columns.Add("Nombre");
            listaMaterias.Columns.Add("Código Materia");

            /*ListViewItem itemMateria = new ListViewItem("Matematicas");
            //itemAlumno.SubItems.Add("Matematicas");
            itemAlumno.SubItems.Add("1MA");

            listaMaterias.View = View.Details;
            listaMaterias.Items.Add(itemMateria);*/
            cargarListaMateria();
        }
        private void cargarListaMateria()
        {
            listaMaterias.Items.Clear();
            listaMaterias.View = View.Details;
            foreach (Materia materia in mantenimientoMateria.GetMaterias())
            {
                ListViewItem itemMateria = new ListViewItem(materia.Nombre);
                itemMateria.SubItems.Add(materia.CodigoMateria);

                listaMaterias.Items.Add(itemMateria);
            }
        }

        private void listaMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection materiaSeleccionada = listaMaterias.SelectedItems;
            if (materiaSeleccionada.Count > 0)
            {
                Console.WriteLine("materia seleccionado count" + materiaSeleccionada.Count);
                Console.WriteLine("materia seleccionado" + materiaSeleccionada[0].Text);

                Console.WriteLine("Código materia seleccionado" + materiaSeleccionada[0].SubItems[1].Text);

                entradaNombreMateria.Text = materiaSeleccionada[0].SubItems[0].Text;
                entradaCodigoMateria.Text = materiaSeleccionada[0].SubItems[1].Text;
                codigoMateriaSeleccionada = materiaSeleccionada[0].SubItems[1].Text;
            }
        }

        private void botonAltaMateria_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreMateria.Text;
            string codigoMateria = entradaCodigoMateria.Text;
            mantenimientoMateria.AltaDatosMateria(nombre, codigoMateria, new List<string>(), new List<string>());
            cargarListaMateria();
        }

        private void botonBajarMateria_Click(object sender, EventArgs e)
        {
            mantenimientoMateria.BajaMateria(codigoMateriaSeleccionada);
            cargarListaMateria();
        }

        private void botonModificarMateria_Click(object sender, EventArgs e)
        {
            Materia materiaModificada = new Materia();
            materiaModificada.Nombre = entradaNombreMateria.Text;
            materiaModificada.CodigoMateria = entradaCodigoMateria.Text;
            mantenimientoMateria.ModificarMateria(codigoMateriaSeleccionada, materiaModificada);
            cargarListaMateria();
        }
    }
}
