using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMateria
{
    public static class AsignacionMateria
    {
        public static List<Materia> AsignarDocenteAMateria(List<Materia> materias, string ciDocente, string codigoMateria)
        {
            Console.WriteLine("cantidad materias en asignardocentemateria " + materias.Count);

            foreach (Materia materia in materias)
            {
                Console.WriteLine("entra for each asigna docentemat " + (materia.CodigoMateria == codigoMateria));
                Console.WriteLine("materia: " + materia.Nombre + materia.CodigoMateria);

                if (materia.CodigoMateria == codigoMateria)
                {
                    materia.Docentes.Add(ciDocente);
                    break;
                }
            }
            return materias;
        }
        public static List<Materia> AsignarAlumnoAMateria(List<Materia> materias, string ciAlumno, string codigoMateria)
        {
            Console.WriteLine("cantidad materias en asignaralumnomateria " + materias.Count);
            foreach (Materia materia in materias)
            {
                Console.WriteLine("entra for each asignar alumnmat " + (materia.CodigoMateria == codigoMateria));
                Console.WriteLine("materia: " + materia.Nombre + materia.CodigoMateria);
                if (materia.CodigoMateria == codigoMateria)
                {
                    materia.Alumnos.Add(ciAlumno);
                    break;
                }
            }
            return materias;
        }
    }
}
