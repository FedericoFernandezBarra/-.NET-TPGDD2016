using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
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
        public object tipoDeCancelacion { get; set; }
        public string motiovoDeCancelacion{ get; set; }
        public Profesional profesional { get; set; }
        public string mensajeDeError { get; set; }
        public List<object> tiposDeCancelacion { get; set; }
        private DateTime fechaActual = Sistema.Instance.getDate();

        public CancelarDias()
        {
            mensajeDeError = "";
            tiposDeCancelacion = new List<object>();
            fechaFinCancelacion = fechaActual;
            fechaInicioCancelacion = fechaActual;
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
            if (motiovoDeCancelacion=="")
            {
                mensajeDeError = "Debe completar el motivo de cancelacion";
                return false;
            }
            if ((fechaInicioCancelacion==fechaActual||fechaFinCancelacion==fechaActual)&&hayTurnoHoy())
            {
                mensajeDeError = "Se necesita al menos 1 dia de antelacion para cancelar un turno";
                return false;
            }

            return true;
        }

        private void ejecutarCancelacion()
        {
            //Esto ejecuta la cancelacion contra la bd
        }

        public bool hayTurnoHoy()
        {
            //Aca hay que consultar a un repo
            return false;
        }
    }
}
