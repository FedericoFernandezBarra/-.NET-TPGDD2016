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
    class ResultadoAtencionMedicaRepository
    {
        public void registrarConsultaMedica(ResultadoAtencionMedica resultadoAtencionMedica)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "turno", resultadoAtencionMedica.turnoID);
            DataBase.Instance.agregarParametro(parametros, "sintoma", resultadoAtencionMedica.sintomas);
            DataBase.Instance.agregarParametro(parametros, "enfermedad", resultadoAtencionMedica.diagnostico);
            DataBase.Instance.agregarParametro(parametros, "fecha_diagnostico", resultadoAtencionMedica.fechaDeDiagnostico);

            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_registrar_consulta", parametros);
        }

    }
}
