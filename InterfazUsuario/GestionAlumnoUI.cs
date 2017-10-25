using GestionAlumno;
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
    public partial class GestionAlumnoUI : Form
    {
        MantenimientoAlumno mantenimientoAlumno = new MantenimientoAlumno();
        string ciAlumnoSeleccionado;
        public GestionAlumnoUI()
        {
            InitializeComponent();
        }

        private void GestionAlumnoUI_Load(object sender, EventArgs e)
        {
            mantenimientoAlumno.GenerarDatos();
            //Console.WriteLine("count alumnos " + mantenimientoAlumno.GetAlumnos().Count());
            listaAlumnos.Columns.Add("Nombre");
            listaAlumnos.Columns.Add("Apellido");
            listaAlumnos.Columns.Add("CI");

            /*ListViewItem itemAlumno = new ListViewItem("Jose");
            //itemAlumno.SubItems.Add("Jose");
            itemAlumno.SubItems.Add("Perez");
            itemAlumno.SubItems.Add("1111");

            listaAlumnos.View = View.Details;
            listaAlumnos.Items.Add(itemAlumno);*/
            cargarListaAlumno();
        }

        private void cargarListaAlumno()
        {
            listaAlumnos.Items.Clear();
            listaAlumnos.View = View.Details;
            foreach (Alumno alumno in mantenimientoAlumno.GetAlumnos())
            {
                ListViewItem itemAlumno = new ListViewItem(alumno.Nombre);
                itemAlumno.SubItems.Add(alumno.Apellido);
                itemAlumno.SubItems.Add(alumno.Ci);

                listaAlumnos.Items.Add(itemAlumno);
            }
        }
        private void listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection alumnoSeleccionado = listaAlumnos.SelectedItems;
            if (alumnoSeleccionado.Count > 0)
            {
                Console.WriteLine("alumno seleccionado count" + alumnoSeleccionado.Count);
                Console.WriteLine("alumno seleccionado" + alumnoSeleccionado[0].Text);

                Console.WriteLine("APLLIDO seleccionado" + alumnoSeleccionado[0].SubItems[1].Text);
                Console.WriteLine("CI seleccionado" + alumnoSeleccionado[0].SubItems[2].Text);

                entradaNombreAlumno.Text = alumnoSeleccionado[0].SubItems[0].Text;
                entradaApellidoAlumno.Text = alumnoSeleccionado[0].SubItems[1].Text;
                entradaCIAlumno.Text = alumnoSeleccionado[0].SubItems[2].Text;
                ciAlumnoSeleccionado = alumnoSeleccionado[0].SubItems[2].Text;
            }

        }

        private void botonAltaAlumno_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreAlumno.Text;
            string apellido = entradaApellidoAlumno.Text;
            string ci = entradaCIAlumno.Text;
            mantenimientoAlumno.AltaDatosAlumno(nombre, apellido, ci, new List<string>());
            cargarListaAlumno();
        }

        private void botonModificarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumnoModificado = new Alumno();
            alumnoModificado.Nombre = entradaNombreAlumno.Text;
            alumnoModificado.Apellido = entradaApellidoAlumno.Text;
            alumnoModificado.Ci = entradaCIAlumno.Text;
            mantenimientoAlumno.ModificarAlumno(ciAlumnoSeleccionado, alumnoModificado);
            cargarListaAlumno();
        }

        private void botonBajarAlumno_Click(object sender, EventArgs e)
        {
            mantenimientoAlumno.BajaAlumno(ciAlumnoSeleccionado);
            cargarListaAlumno();
        }
    }
 }
