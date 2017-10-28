using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Collections;

namespace GestionMateria
{
    public class MantenimientoMateria : IModuloGestion
    {
        public string CodigoMateria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        private static List<Materia> materias = new List<Materia>();
        public List<Materia> materiasPrueba = new List<Materia>();
        private string ciDocenteAFiltrar;
        private string ciAlumnoAFiltrar;
        public List<Materia> GetMaterias()
        {
            return materias;
        }
        // cambiar todos lo metodos a static - public static
        // cambiar todas las instancias, en donde dice new, borrar
        //y donde dice mantenimientoMAteria ahora es MAntenimientoMAteria
        //cambiar en pruebas, mantenimientos docente y materia, interfaces, y las referencias a la clase entodo.
        public MantenimientoMateria()
        {
            Console.WriteLine();
            Nombre = "Gestion Materia";
            Descripcion = "Alta, Baja y Modificación de Materias";
        }
        public Materia AltaDatosMateria(string codigoMateria, string nombreMateria, List<string> docentes, List<string>alumnos)
        {
            Materia materia = new Materia();
            materia.CodigoMateria = codigoMateria;
            materia.Nombre = nombreMateria;
            materia.Docentes = docentes;
            materia.Alumnos = alumnos;
            materias.Add(materia);
            return materia;
        }
        public void BajaMateria(string codigoMateria)
        {
            Console.WriteLine("Código de Materia a bajar de Materia > " + codigoMateria);

            try
            {
                // Filtro los docentes por la ci que recibo por parametro
                // Single es un metodo iterativo que recibe una funcion anonima por cada
                // elemento de la lista y retorna el elemento que cumpla con el filtro
                Materia materiaAEliminar = materias.Single(materia => materia.CodigoMateria == codigoMateria);

                // Removemos la materiaAEliminar de la lista de materias
                materias.Remove(materiaAEliminar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar materia > " + e.ToString());
            }
        }
        public void ModificarMateria(string codigoMateria, Materia nuevosValores)
        {
            Console.WriteLine("Materia a modificar > " + codigoMateria);
            try
            {
                Materia materiaAModificar = materias.Single(materia => materia.CodigoMateria == codigoMateria);
                Console.WriteLine("materia nomnbre materia a modif. " + materiaAModificar.Nombre);
                int indiceDelaMateriaAModificar = materias.IndexOf(materiaAModificar);
                Console.WriteLine("indice a modificar" + indiceDelaMateriaAModificar);
                materias[indiceDelaMateriaAModificar].Nombre = nuevosValores.Nombre != "" ? nuevosValores.Nombre : materiaAModificar.Nombre;
                Console.WriteLine("nuevos valores instancia de materia" + nuevosValores.GetType());
                Console.WriteLine("count de nuevos valores " + nuevosValores.Docentes.Count);

                if (nuevosValores.Docentes.Count > 0)
                {
                    materias[indiceDelaMateriaAModificar].Docentes = nuevosValores.Docentes[0] != "" ? nuevosValores.Docentes : materiaAModificar.Docentes;
                }
                if (nuevosValores.Alumnos.Count > 0)
                { 
                    materias[indiceDelaMateriaAModificar].Alumnos = nuevosValores.Alumnos[0] != "" ? nuevosValores.Alumnos : materiaAModificar.Docentes;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar materia > " + e.ToString());
            }
        }
        public Materia obtenerMateriaPorCodigo(string codigoMateria)
        {
            Materia materiaARetornar = materias.Single(materia => materia.CodigoMateria== codigoMateria);
            return materiaARetornar;
        }
        public List<Materia> ObtenerMateriasPorDocente(string ciDocente)
        {
            Console.WriteLine("ci docente de obtener materias xdoc " + ciDocente);
            ciDocenteAFiltrar = ciDocente;
            Console.WriteLine("cantidad materias " + materias.Count);
            List<Materia> materiasARetornar = materias.FindAll(BuscarMateriaPorDocente);
            
            return materiasARetornar;
        }
        private Boolean ExisteDocente(string ciDocente)
        {
            Console.WriteLine("ci docente existe " + ciDocente);
            return ciDocente == ciDocenteAFiltrar;
        }
        private Boolean BuscarMateriaPorDocente(Materia materia)
        {
            return materia.Docentes.Exists(ExisteDocente);
        }
        public void GenerarDatos()
        {
            // Agrego Docentes con AltaDatosDocente para tener una lista
            materiasPrueba.Add(AltaDatosMateria("Matemáticas", "111", new List<string>(), new List<string>()));
            materiasPrueba.Add(AltaDatosMateria("Programacion", "1231", new List<string>(), new List<string>()));
            materiasPrueba.Add(AltaDatosMateria("Etica", "1234", new List<string>(), new List<string>()));
            materiasPrueba.Add(AltaDatosMateria("Logica", "333", new List<string>(), new List<string>()));

            materias = GetMaterias();
            materias = AsignacionMateria.AsignarDocenteAMateria(materias, "111", "111");

        }

    }
}