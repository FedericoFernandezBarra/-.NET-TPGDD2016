using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.Otros
{
    class CancelarDias
    {
        public DateTime fechaInicioCancelacion { get; set; }
        public DateTime fechaFinCancelacion { get; set; }
        public TipoCancelacion tipoDeCancelacion { get; set; }
        public string motivoDeCancelacion{ get; set; }
        public Profesional profesional { get; set; }
        public string mensajeDeError { get; set; }
        public List<TipoCancelacion> tiposDeCancelacion { get; set; }
        private DateTime fechaActual = DataBase.Instance.getDate();
        private TurnoRepository repoTurno = new TurnoRepository();

        public CancelarDias()
        {
            mensajeDeError = "";
            motivoDeCancelacion = "";
            fechaFinCancelacion = fechaActual.AddDays(1);
            fechaInicioCancelacion = fechaActual.AddDays(1);
            inicializarListas();
        }

        private void inicializarListas()
        {
            tiposDeCancelacion = repoTurno.traerTiposDeCancelacion();
        }

        internal bool cancelacionExitosa()
        {
            if (!cumpleValidaciones())
            {
                return false;
            }

            ejecutarCancelacion();
            return true;
        }

        private bool cumpleValidaciones()
        {
            if (fechaFinCancelacion<fechaActual||fechaInicioCancelacion<fechaActual)
            {
                mensajeDeError = "No puede existir una fecha anterior a hoy en el rango de cancelacion";
                return false;
            }
            if (fechaFinCancelacion<fechaInicioCancelacion)
            {
                mensajeDeError = "La fecha de inicio no puede ser mayor a la fecha de finalizacion";
                return false;
            }
            if (motivoDeCancelacion=="")
            {
                mensajeDeError = "Debe completar el motivo de cancelacion";
                return false;
            }
            /*if ((fechaInicioCancelacion==fechaActual||fechaFinCancelacion==fechaActual)&&hayTurnoHoy())
            {
                mensajeDeError = "Se necesita al menos 1 dia de antelacion para cancelar un turno";
                return false;
            }*/
            if (tipoDeCancelacion==null)
            {
                mensajeDeError = "Debe seleccionar un tipo de cancelacion";
                return false;
            }

            return true;
        }

        private void ejecutarCancelacion()
        {
            repoTurno.cancelarTurnoPorRangoFechas(fechaInicioCancelacion,fechaFinCancelacion,profesional,motivoDeCancelacion,tipoDeCancelacion);
        }

        public bool hayTurnoHoy()
        {
            return repoTurno.existeTurno(profesional, fechaActual);
        }
    }
}
