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
            listaAlumnos.Columns.Add("CI");
            listaAlumnos.Columns.Add("Nombre");
            listaAlumnos.Columns.Add("Apellido");


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
                ListViewItem itemAlumno = new ListViewItem(alumno.Ci);
                itemAlumno.SubItems.Add(alumno.Nombre);
                itemAlumno.SubItems.Add(alumno.Apellido);

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

                Console.WriteLine("Ci seleccionado" + alumnoSeleccionado[0].SubItems[1].Text);
                Console.WriteLine("APLLIDO seleccionado" + alumnoSeleccionado[0].SubItems[2].Text);

                entradaCIAlumno.Text = alumnoSeleccionado[0].SubItems[0].Text;
                entradaNombreAlumno.Text = alumnoSeleccionado[0].SubItems[1].Text;
                entradaApellidoAlumno.Text = alumnoSeleccionado[0].SubItems[2].Text;
                ciAlumnoSeleccionado = alumnoSeleccionado[0].SubItems[0].Text;
            }

        }

        private void botonAltaAlumno_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreAlumno.Text;
            string apellido = entradaApellidoAlumno.Text;
            string ci = entradaCIAlumno.Text;
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Ci = ci;
            nuevosValoresAlumno.Nombre = nombre;
            nuevosValoresAlumno.Apellido = apellido;
            if (ValidarDatos(ci, nuevosValoresAlumno))
            {
                mantenimientoAlumno.AltaDatosAlumno(nombre, apellido, ci, new List<string>());
                cargarListaAlumno();
            }
        }

        private void botonBajarAlumno_Click(object sender, EventArgs e)
        {
            // aca o en mantenimiento ? validarCamposIngresados();
            mantenimientoAlumno.BajaAlumno(ciAlumnoSeleccionado);
            limpiarValoresViejos();            
            cargarListaAlumno();
        }
        private void limpiarValoresViejos()
        {
            entradaNombreAlumno.Clear();
            entradaApellidoAlumno.Clear();
            entradaCIAlumno.Clear();
        }
        private Boolean ValidarDatos(string ci, Alumno nuevosValores)
        {
            if ((ci.Length == 0) || (nuevosValores.Apellido.Length == 0) || (nuevosValores.Nombre.Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            if ((ci.Trim().Length == 0) || (nuevosValores.Apellido.Trim().Length == 0) || (nuevosValores.Nombre.Trim().Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            return (true);
        }
        private Boolean ExistenRegistrosRepetidos(string ci, Alumno nuevosValores)
        {
           // Alumno alumnoEncontrado = alumnos.Single(alumno => alumno.Ci == ci);
            //if 
            return true;
        }
        private void botonModificarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumnoModificado = new Alumno();

            alumnoModificado.Nombre = entradaNombreAlumno.Text;
            Console.WriteLine("Nombre alumno modificado " + entradaNombreAlumno.Text);
            alumnoModificado.Apellido = entradaApellidoAlumno.Text;
            Console.WriteLine("Apellido alumno modificado " + entradaApellidoAlumno.Text);
            alumnoModificado.Ci = entradaCIAlumno.Text;
            mantenimientoAlumno.ModificarAlumno(ciAlumnoSeleccionado, alumnoModificado);
            entradaCIAlumno.Clear();
            entradaApellidoAlumno.Clear();
            entradaNombreAlumno.Clear();
            cargarListaAlumno();
        }
    }
 }
