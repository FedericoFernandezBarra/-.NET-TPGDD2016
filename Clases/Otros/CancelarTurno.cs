using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
