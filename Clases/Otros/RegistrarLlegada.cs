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
        public DateTime fechaLlegada { get; set; }

        public RegistrarLlegada()
        {
            mensajeDeError = "";
            numeroAfiliado = "0";
            turnosFiltrados = new List<Turno>();
            turnosDeProfesional = new List<Turno>();
            profesional = new Profesional();
            fechaLlegada = DataBase.Instance.getDate();
        }

        internal void cargarTurnosFiltrados()
        {
            if (numeroAfiliado=="")
            {
                turnosFiltrados = turnosDeProfesional;
            }

            turnosFiltrados = turnosDeProfesional.FindAll(t => t.afiliado.numeroDeAfiliado.ToString().Contains(numeroAfiliado));
        }

        internal void cargarTurnosDeProfesional()
        {
            if (profesional==null)
            {
                return;
            }
            turnosDeProfesional = (new TurnoRepository()).traerTurnosDeProfesional(profesional, especialidad, fechaLlegada, true);
                
            turnosDeProfesional=turnosDeProfesional.Where(unTurno => unTurno.fechaDeLlegada.Date != unTurno.fechaDeTurno.Date).ToList();
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
            (new TurnoRepository()).registrarLlegada(turnoDeAfiliado, bonoSeleccionado,fechaLlegada);
        }

        private bool cumpleValidaciones()
        {
            if (profesional==null)
            {
                mensajeDeError = "Debe seleccionar un profesional";
                return false;
            }
            if (turnoDeAfiliado == null)
            {
                mensajeDeError = "Debe seleccionar un turno";
                return false;
            }
            if (bonoSeleccionado == null)
            {
                mensajeDeError = "Numero de bono erroneo";
                return false;
            }
            if (!cumpleValidacionesDeBd())
            {
                return false;
            }
            /*if (bonoSeleccionado.planMedico.id!=turnoDeAfiliado.afiliado.planMedico.id)
            {
                bonoSeleccionado = null;
                mensajeDeError = "Debe seleccionar un bono perteneciente al plan actual";
                return false;
            }
            if (bonoSeleccionado.yaFueUsado())
            {
                mensajeDeError = "El bono especificado ya fue gastado";
                return false;
            }
            if (!afiliadoPerteneceAGrupoFamiliarComprador())
            {
                mensajeDeError = "Bono perteneciente a otro grupo familiar";
                return false;
            }*/
            if (llegadaTarde())
            {
                mensajeDeError = "Llegada tarde, el turno ya caduco";
                return false;
            }

            return true;
        }

        private bool cumpleValidacionesDeBd()
        {
            mensajeDeError = (new BonoRepository()).verificarSiBonoPuedeSerGastado(bonoSeleccionado,turnoDeAfiliado.afiliado);

            return mensajeDeError != "";
        }

        private bool llegadaTarde()
        {
            return fechaLlegada.Hour > turnoDeAfiliado.fechaDeTurno.Hour || fechaLlegada.Hour == turnoDeAfiliado.fechaDeTurno.Hour && fechaLlegada.Minute > turnoDeAfiliado.fechaDeTurno.Minute;
        }

        private bool afiliadoPerteneceAGrupoFamiliarComprador()
        {
            long nroAfiliado = turnoDeAfiliado.afiliado.numeroDeAfiliado;//Convert.ToInt64(numeroAfiliado);
            long nroRaiz = nroAfiliado - nroAfiliado % 100;
            long nroComprador = bonoSeleccionado.compra.comprador.numeroDeAfiliado;
            long nroFamiliar = nroComprador - nroComprador % 100;

            return nroRaiz == nroFamiliar || (nroAfiliado == 0 && nroRaiz == 0 && 
                                              turnoDeAfiliado.afiliado.usuario.id == 
                                              bonoSeleccionado.compra.comprador.usuario.id);
        }
    }
}
