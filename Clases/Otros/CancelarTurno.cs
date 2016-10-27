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
    class CancelarTurno
    {
        public TipoCancelacion tipoDeCancelacion { get; set; }
        public string motivoDeCancelacion { get; set; }
        public Afiliado afiliado { get; set; }
        public string mensajeDeError { get; set; }
        public List<TipoCancelacion> tiposDeCancelacion { get; set; }
        public List<Turno> turnosDeAfiliado { get; set; }
        public Turno turnoACancelar { get; set; }
        private TurnoRepository repoTurno = new TurnoRepository();

        public CancelarTurno()
        {
            mensajeDeError = "";

            //inicializarListas();
        }

        public void inicializarListas()
        {
            tiposDeCancelacion = repoTurno.traerTiposDeCancelacion();
            turnosDeAfiliado = repoTurno.traerTurnosDeAfiliado(afiliado);
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
            repoTurno.cancelarTurno(turnoACancelar, motivoDeCancelacion, tipoDeCancelacion);
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
            DateTime fechaActual = DataBase.Instance.getDate();
            return false;//Aca consulta la bd
        }
    }
}
