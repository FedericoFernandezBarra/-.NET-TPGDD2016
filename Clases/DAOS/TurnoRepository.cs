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
            /*List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "profesional", profesional.id);
            DataBase.Instance.agregarParametro(parametros, "fecha ", fecha);*/

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("fechaDeTurno", fecha);
            properties.Add("profesional", profesional.id);

            return selectByProperties(properties).Count > 0;
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

        internal List<Turno> traerTurnosDeProfesional(Profesional profesional, Especialidad especialidad, DateTime fecha)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.id);
            DataBase.Instance.agregarParametro(parametros, "@especialidad", especialidad.id);
            DataBase.Instance.agregarParametro(parametros, "@fecha_sistema", fecha);

            return (List<Turno>)executeStored("BEMVINDO.st_obtener_turnos", parametros);

        }

        internal void registrarLlegada(Turno turno, Bono bono, DateTime fecha)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@id_turno", turno.id);
            DataBase.Instance.agregarParametro(parametros, "@id_bono", bono.id);
            DataBase.Instance.agregarParametro(parametros, "@fecha_llegada", fecha);

            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_registrar_fecha_llegada", parametros);
        }

        internal void cancelarTurno(Turno turnoACancelar, string motivoDeCancelacion, TipoCancelacion tipoDeCancelacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros,"@tipo_cancelacion", tipoDeCancelacion.id);
            DataBase.Instance.agregarParametro(parametros, "@turno", turnoACancelar.id);
            DataBase.Instance.agregarParametro(parametros, "@motivo", motivoDeCancelacion);
            DataBase.Instance.agregarParametro(parametros, "@fecha_sistema", DataBase.Instance.getDate());

            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_cancelar_turno_afiliado", parametros);
        }

        internal List<Turno> traerTurnosDeAfiliado(Afiliado afiliado)
        {
            return (List<Turno>)selectByProperty("afiliado", afiliado.id);
        }

        internal override Type getModelClassType()
        {
            return typeof(Turno);
        }

        internal List<TipoCancelacion> traerTiposDeCancelacion()
        {
            return (List<TipoCancelacion>)selectAll(typeof(TipoCancelacion));
        }
    }
}
