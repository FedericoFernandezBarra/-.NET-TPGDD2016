using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class ResultadoAtencionMedicaRepository:Repository
    {
        public void registrarConsultaMedica(ResultadoAtencionMedica resultadoAtencionMedica)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "turno", resultadoAtencionMedica.turno.id);
            DataBase.Instance.agregarParametro(parametros, "sintoma", resultadoAtencionMedica.sintomas);
            DataBase.Instance.agregarParametro(parametros, "enfermedad", resultadoAtencionMedica.diagnostico);
            DataBase.Instance.agregarParametro(parametros, "fecha_diagnostico", resultadoAtencionMedica.fechaDeDiagnostico);

            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_registrar_consulta", parametros);
        }

        public List<ResultadoAtencionMedica> obtenerConsultasMedicasDe(Profesional unProfesional, DateTime enUnDia)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "profesional", unProfesional.usuario.id);
            DataBase.Instance.agregarParametro(parametros, "fecha", enUnDia);
            return (List<ResultadoAtencionMedica>)executeStored("BEMVINDO.st_obtener_consultas", parametros);
        }

        public DateTime obtenerFechaMinimaDeConsultaDe(Profesional profesional)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.usuario.id);

            return DateTime.Parse(DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_obtener_fecha_minima_consulta", parametros).First()["fechaMinima"].ToString());
        }

        public DateTime obtenerFechaMaximaDeConsultaDe(Profesional profesional)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", profesional.usuario.id);

            return DateTime.Parse(DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_obtener_fecha_maxima_consulta", parametros).First()["fechaMaxima"].ToString());
        }

        internal override Type getModelClassType()
        {
            return typeof(ResultadoAtencionMedica);
        }
    }
}
