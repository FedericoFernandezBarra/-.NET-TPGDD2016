using System.Collections.Generic;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Clases.DAOS;
using System;

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
            if (especialidadNoSeleccionada()&&filtroEspecialidadObligatorio)
            {
                mensajeDeError = "Debe seleccionar una especialidad";
                return false;
            }

            return true;
        }

        private bool ningunFiltroSeleccionado()
        {
            return especialidadNoSeleccionada() && (nombre == "") && (apellido == "") && (nroMatricula == 0);
        }

        private bool especialidadNoSeleccionada()
        {
            if (especialidad==null)
            {
                return true;
            }

            return especialidad.id == 0;
        }

        private void inicializarListas()
        {
            profesionales = new List<Profesional>();
            especialidadesSistema = new List<Especialidad> { new Especialidad() };
            (new EspecialidadRepository()).traerEspecialidades().ForEach(e => especialidadesSistema.Add(e));
        }

        internal void buscar()
        {
            List<Profesional> result = (new ProfesionalRepository()).buscarProfesionales(nroMatricula, nombre, apellido, especialidad);

            profesionales = new List<Profesional>();

            foreach (Profesional p in result)
            {
                if (!profesionales.Exists(pr => pr.matricula == p.matricula))
                {
                    profesionales.Add(p);
                }
            }
        }
    }
}
