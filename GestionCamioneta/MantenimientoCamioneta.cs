using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Collections;

namespace GestionCamioneta
{
    public class MantenimientoCamioneta : IModuloGestion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        private List<Camioneta> camionetas = new List<Camioneta>();
        private List<Camioneta> camionetasPrueba = new List<Camioneta>();
        public List<Camioneta> GetCamionetas()
        {
            return camionetas;
        }
        public MantenimientoCamioneta()
        {
            Console.WriteLine();
            Nombre = "Gestion Camioneta";
            Descripcion = "Alta, Baja y Modificación de Camionetas";
        }

        public void GenerarDatos()
        {
            //throw new NotImplementedException();
            // Agrego Docentes con AltaDatosDocente para tener una lista
            camionetasPrueba.Add(AltaDatosCamioneta("SAF3333", 111, "Disponible"));
            camionetasPrueba.Add(AltaDatosCamioneta("SAF4444", 1231,"No Disponible"));
            camionetasPrueba.Add(AltaDatosCamioneta("SBE", 1234, "Disponible"));
        }

        public Camioneta AltaDatosCamioneta(string matriculaCamioneta, int capacidadCamioneta, string estadoCamioneta)
        {
            Camioneta camioneta = new Camioneta();
            camioneta.Matricula = matriculaCamioneta;
            camioneta.Capacidad = capacidadCamioneta;
            camioneta.Estado = estadoCamioneta;
            camionetas.Add(camioneta);
            return camioneta;
        }

        public void ModificarCamioneta(string matriculaCamionetaSeleccionada, Camioneta camionetaModificada)
        {
            throw new NotImplementedException();
        }

        public void BajaCamioneta(string matriculaCamionetaSeleccionada)
        {
            throw new NotImplementedException();
        }
    }
}
