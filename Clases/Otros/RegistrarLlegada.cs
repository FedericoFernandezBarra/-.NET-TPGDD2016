using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.Otros
{
    public class RegistrarLlegada
    {
        public Profesional profesional { get; set; }
        public List<Turno> turnosDeProfesional { get; set; }
        public List<Turno> turnosFiltrados { get; set; }
        public Turno turnoDeAfiliado { get; set; }
        public Especialidad especialidad { get; set; }
        public string numeroAfiliado { get; set; }
        public long numeroBono { get; set; }
        private Bono bonoSeleccionado = null;
        public string mensajeDeError { get; set; }

        public RegistrarLlegada()
        {
            mensajeDeError = "";
            numeroAfiliado = "";
            turnosFiltrados = new List<Turno>();
            profesional = new Profesional();
        }

        internal void cargarTurnosFiltrados()
        {
            turnosFiltrados = turnosDeProfesional.FindAll(t => t.afiliado.id.ToString().Contains(numeroAfiliado));
        }

        internal void cargarTurnosDeProfesional()
        {
            turnosDeProfesional = (new TurnoRepository()).traerTurnosDeProfesional(profesional, especialidad, DataBase.Instance.getDate());
        }

        internal bool ejecutarExitosamente()
        {
            buscarBono();

            if (!cumpleValidaciones())
            {
                return false;
            }

            registrarLlegada();

            return true;
        }

        private void buscarBono()
        {
            bonoSeleccionado = (new BonoRepository()).traerPorId(numeroBono);
        }

        private void registrarLlegada()
        {
            (new TurnoRepository()).registrarLlegada(turnoDeAfiliado, bonoSeleccionado, DataBase.Instance.getDate());
        }

        private bool cumpleValidaciones()
        {
            if (turnoDeAfiliado == null)
            {
                mensajeDeError = "Debe seleccionar un turno";
                return false;
            }
            if (bonoSeleccionado.planMedico.id!=turnoDeAfiliado.afiliado.planMedico.id)
            {
                bonoSeleccionado = null;
                mensajeDeError = "Debe seleccionar un bono perteneciente al plan actual";
                return false;
            }
            if (bonoSeleccionado==null)//No se si el bono es obligatorio
            {
                mensajeDeError = "Numero de bono erroneo";
                return false;
            }

            return true;
        }
    }
}
