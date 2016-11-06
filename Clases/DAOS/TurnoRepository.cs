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
            properties.Add("profesional", profesional.usuario.id);

            return selectByProperties(properties).Count > 0;
        }

        public bool existeTurnoActivo(Profesional profesional, DateTime fecha)
        {

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("fechaDeTurno", fecha);
            properties.Add("activo", true);
            properties.Add("profesional", profesional.usuario.id);

            return selectByProperties(properties).Count > 0;
        }

        public String reservarTurno(Turno turno) {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "id_afiliado", turno.afiliado.usuario.id);
            DataBase.Instance.agregarParametro(parametros, "profesional", turno.profesional.usuario.id);
            DataBase.Instance.agregarParametro(parametros, "especialidad", turno.especialidad.id);
            DataBase.Instance.agregarParametro(parametros, "fecha_turno", turno.fechaDeTurno);

            return DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_insertar_turno", parametros).First()["resultado"].ToString();
        }

        internal void cancelarTurnoPorRangoFechas(DateTime fechaInicioCancelacion, DateTime fechaFinCancelacion, Profesional profesional, string motivoDeCancelacion, TipoCancelacion tipoDeCancelacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "profesional", profesional.usuario.id);
            DataBase.Instance.agregarParametro(parametros, "tipo_cancelacion", tipoDeCancelacion.id);
            DataBase.Instance.agregarParametro(parametros, "motivo", motivoDeCancelacion);
            DataBase.Instance.agregarParametro(parametros, "@cancelacion_desde", fechaInicioCancelacion);
            DataBase.Instance.agregarParametro(parametros, "@cancelacion_hasta", fechaFinCancelacion);
            DataBase.Instance.agregarParametro(parametros, "@fecha_sistema", DataBase.Instance.getDate()); 

            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_cancelar_turno_medico", parametros);
        }

        internal List<Turno> traerTurnosDeProfesional(Profesional profesional, Especialidad especialidad, DateTime fecha,bool activo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.usuario.id);
            DataBase.Instance.agregarParametro(parametros, "@especialidad", especialidad.id);
            DataBase.Instance.agregarParametro(parametros, "@fecha_sistema", fecha);
            DataBase.Instance.agregarParametro(parametros, "@activo", activo);

            return (List<Turno>)executeStored("BEMVINDO.st_obtener_turnos", parametros);

        }

        internal List<Turno> traerTurnosDeProfesional(Profesional profesional, DateTime fecha)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.usuario.id);
            DataBase.Instance.agregarParametro(parametros, "@fecha_sistema", fecha);

            return (List<Turno>)executeStored("BEMVINDO.st_obtener_turnos", parametros);
        }

        internal List<Turno> traerTurnosDeProfesional(Profesional profesional)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.usuario.id);

            return (List<Turno>)executeStored("BEMVINDO.st_obtener_turnos", parametros);
        }

        internal DateTime obtenerFechaMinimaDeTurnoDe(Profesional profesional)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.usuario.id);

            return DateTime.Parse(DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_obtener_fecha_minima_turno", parametros).First()["fechaMinima"].ToString());
        }

        internal DateTime obtenerFechaMaximaDeTurnoDe(Profesional profesional)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.usuario.id);

            return DateTime.Parse(DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_obtener_fecha_maxima_turno", parametros).First()["fechaMaxima"].ToString());
        }

        public bool tieneTurno(Profesional profesional)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.usuario.id);

            return Convert.ToInt32(DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_cantidad_turnos", parametros).First()["cantidad"].ToString()) > 0;
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
            //return (List<Turno>)selectByProperty("afiliado", afiliado.usuario.id);
            return (List<Turno>)executeStored("BEMVINDO.st_obtener_turnos_afiliado", afiliado);
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
