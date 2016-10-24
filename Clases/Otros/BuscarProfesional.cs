using System.Collections.Generic;
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
        public bool filtroEspecialidadObligatorio { get; set; }

        public BuscarProfesional()
        {
            filtroEspecialidadObligatorio = false;
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
            if (ningunFiltroSeleccionado())
            {
                mensajeDeError = "Debe especificar al menos 1 filtro de busqueda";
            }
            if (especialidad==null&&filtroEspecialidadObligatorio)
            {
                mensajeDeError = "Debe seleccionar una especialidad";
                return false;
            }

            return true;
        }

        private bool ningunFiltroSeleccionado()
        {
            return (especialidad == null) && (nombre == "") && (apellido == "") && (nroMatricula == 0);
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
