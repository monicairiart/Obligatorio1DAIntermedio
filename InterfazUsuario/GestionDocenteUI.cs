using GestionDocente;
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
    public partial class GestionDocenteUI : Form
    {
        MantenimientoDocente mantenimientoDocente = new MantenimientoDocente();
        string ciDocenteSeleccionado;
        public GestionDocenteUI()
        {
            InitializeComponent();
        }

        private void GestionDocenteUI_Load(object sender, EventArgs e)
        {
            mantenimientoDocente.GenerarDatos();
            //Console.WriteLine("count docentes " + mantenimientoDocente.GetDocentes().Count());
            listaDocentes.Columns.Add("Nombre");
            listaDocentes.Columns.Add("Apellido");
            listaDocentes.Columns.Add("CI");

            /*ListViewItem itemDocente = new ListViewItem("Jose");
            //itemDocente.SubItems.Add("Jose");
            itemDocente.SubItems.Add("Perez");
            itemDocente.SubItems.Add("1111");

            listaDocentes.View = View.Details;
            listaDocentes.Items.Add(itemDocente);*/
            cargarListaDocente();
        }

        private void cargarListaDocente()
        {
            listaDocentes.Items.Clear();
            listaDocentes.View = View.Details;
            foreach (Docente docente in mantenimientoDocente.GetDocentes())
            {
                ListViewItem itemDocente = new ListViewItem(docente.Nombre);
                itemDocente.SubItems.Add(docente.Apellido);
                itemDocente.SubItems.Add(docente.Ci);

                listaDocentes.Items.Add(itemDocente);
            }
        }
        private void listaDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection docenteSeleccionado = listaDocentes.SelectedItems;
            if (docenteSeleccionado.Count > 0)
            {
                Console.WriteLine("docente seleccionado count" + docenteSeleccionado.Count);
                Console.WriteLine("docente seleccionado" + docenteSeleccionado[0].Text);

                Console.WriteLine("APLLIDO seleccionado" + docenteSeleccionado[0].SubItems[1].Text);
                Console.WriteLine("CI seleccionado" + docenteSeleccionado[0].SubItems[2].Text);

                entradaNombreDocente.Text = docenteSeleccionado[0].SubItems[0].Text;
                entradaApellidoDocente.Text = docenteSeleccionado[0].SubItems[1].Text;
                entradaCIDocente.Text = docenteSeleccionado[0].SubItems[2].Text;
                ciDocenteSeleccionado = docenteSeleccionado[0].SubItems[2].Text;
            }

        }

        private void botonAltaDocente_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreDocente.Text;
            string apellido = entradaApellidoDocente.Text;
            string ci = entradaCIDocente.Text;
            mantenimientoDocente.AltaDatosDocente(nombre, apellido, ci, new List<string>());
            cargarListaDocente();
        }

        private void botonModificarDocente_Click(object sender, EventArgs e)
        {
            Docente docenteModificado = new Docente();
            docenteModificado.Nombre = entradaNombreDocente.Text;
            docenteModificado.Apellido = entradaApellidoDocente.Text;
            docenteModificado.Ci = entradaCIDocente.Text;
            mantenimientoDocente.ModificarDocente(ciDocenteSeleccionado, docenteModificado);
            cargarListaDocente();
        }

        private void botonBajarDocente_Click(object sender, EventArgs e)
        {
            mantenimientoDocente.BajaDocente(ciDocenteSeleccionado);
            cargarListaDocente();
        }
    }
 }
