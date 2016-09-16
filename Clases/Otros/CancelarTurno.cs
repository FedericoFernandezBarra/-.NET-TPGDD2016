using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.Otros
{
    class CancelarTurno
    {
        public object tipoDeCancelacion { get; set; }
        public string motivoDeCancelacion { get; set; }
        public Afiliado afiliado { get; set; }
        public string mensajeDeError { get; set; }
        public List<object> tiposDeCancelacion { get; set; }
        public Turno turnoACancelar { get; set; }

        public CancelarTurno()
        {
            mensajeDeError = "";
            tiposDeCancelacion = new List<object>();
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

        private void ejecutarCancelacion()
        {
            //Aca deberia de hacer el insert
        }

        private bool cumpleValidaciones()
        {
            if (motivoDeCancelacion == "")
            {
                mensajeDeError = "Debe completar el motivo de cancelacion";
                return false;
            }
            if (hayTurnoHoy())
            {
                mensajeDeError = "Se necesita al menos 1 dia de antelacion para cancelar un turno";
                return false;
            }

            return true;
        }

        public bool hayTurnoHoy()
        {
            DateTime fechaActual = Sistema.Instance.getDate();
            return false;//Aca consulta la bd
        }
    }
}
