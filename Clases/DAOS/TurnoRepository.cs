using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clases.POJOS;
using System.Data.SqlClient;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    public class TurnoRepository:Repository
    {
        public bool existeTurno(Profesional profesional, DateTime fecha)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "profesional", profesional.id);
            DataBase.Instance.agregarParametro(parametros, "fecha ", fecha);

            return selectByProperty("fechaDeTurno", fecha).Exists(t => ((Turno)t).profesional.id == profesional.id);
        }

        internal void cancelarTurnoPorRangoFechas(DateTime fechaInicioCancelacion, DateTime fechaFinCancelacion, Profesional profesional, string motivoDeCancelacion, TipoCancelacion tipoDeCancelacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "profesional", profesional.id);
            DataBase.Instance.agregarParametro(parametros, "tipo_cancelacion", tipoDeCancelacion.id);
            DataBase.Instance.agregarParametro(parametros, "motivo", motivoDeCancelacion);
            DataBase.Instance.agregarParametro(parametros, "fecha_cancelar_inicio", fechaInicioCancelacion);
            DataBase.Instance.agregarParametro(parametros, "fecha_cancelar_fin", fechaFinCancelacion);
            DataBase.Instance.agregarParametro(parametros, "tipo_usuario", profesional.usuario.sexo);//no se que es este campo!!

            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_cancelar_turno_medico", parametros);
        }

        internal void cancelarTurno(Turno turnoACancelar, string motivoDeCancelacion, TipoCancelacion tipoDeCancelacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros,"@tipo_cancelacion", tipoDeCancelacion.id);
            DataBase.Instance.agregarParametro(parametros, "@turno", turnoACancelar.id);
            DataBase.Instance.agregarParametro(parametros, "@motivo", motivoDeCancelacion);
            DataBase.Instance.agregarParametro(parametros, "@fecha_sistema", Sistema.Instance.getDate());

            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_cancelar_turno_afiliado", parametros);
        }

        internal List<Turno> traerTurnosDeAfiliado(Afiliado afiliado)
        {
            List<Turno> turnos = new List<Turno>();

            selectByProperty("afiliado", afiliado.id).ForEach(o => turnos.Add((Turno)o));

            return turnos;
        }

        internal override Type getModelClassType()
        {
            return typeof(Turno);
        }

        internal List<TipoCancelacion> traerTiposDeCancelacion()
        {
            List<TipoCancelacion> tiposCancelacion = new List<TipoCancelacion>();

            selectAll(typeof(TipoCancelacion)).ForEach(o => tiposCancelacion.Add((TipoCancelacion)o));

            return tiposCancelacion;
        }
    }
}
