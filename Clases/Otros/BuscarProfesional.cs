using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Clases.DAOS;

namespace ClinicaFrba.Clases.Otros
{
    public class BuscarProfesional
    {
        public Profesional profesional { get; set; }
        public long nroMatricula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Especialidad especialidad { get; set; }
        public List<Especialidad> especialidadesSistema { get; set; }
        public string mensajeDeError { get; set; }
        public List<Profesional> profesionales { get; set; }

        public BuscarProfesional()
        {
            mensajeDeError = "";
            inicializarListas();
        }

        internal bool busquedaExitosa()
        {
            if (!cumpleValidaciones())
            {
                return false;
            }

            buscar();

            return true;
        }

        private bool cumpleValidaciones()
        {

            if (especialidad==null)
            {
                mensajeDeError = "Debe seleccionar una especialidad";
                return false;
            }

            return true;
        }

        private void inicializarListas()
        {
            profesionales = new List<Profesional>();
            especialidadesSistema = (new EspecialidadRepository()).traerEspecialidades();
        }

        internal void buscar()
        {
            profesionales = (new ProfesionalRepository()).buscarProfesionales(nroMatricula, nombre, apellido, especialidad);
        }
    }
}
