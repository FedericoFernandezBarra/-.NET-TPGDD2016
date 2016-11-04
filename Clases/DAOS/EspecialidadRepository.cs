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
    class EspecialidadRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Especialidad);
        }

        public List<Especialidad> traerEspecialidades()
        {
            return (List<Especialidad>)selectAll();
        }

        internal List<Dictionary<string,object>> top5EspecialidadesCanceladas(int mes, int anio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "mes", mes);
            DataBase.Instance.agregarParametro(parametros, "anio", anio);

            List<Dictionary<string, object>> lista = new List<Dictionary<string, object>>();

            autoMapping = false;

            List<Dictionary<string, object>> result = (List<Dictionary<string, object>>)executeStored("BEMVINDO.st_top5_especialidades_mas_canceladas", parametros);

            autoMapping = true;

            foreach (Dictionary<string,object> item in result)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                Especialidad especialidad = (Especialidad)unSerialize(item);
                completeProperty("tipoDeEspecialidad", especialidad);
                dictionary.Add("especialidad", especialidad);
                dictionary.Add("cancelaciones", item["cant_cancelaciones"]);
                lista.Add(dictionary);
            }

            return lista;
        }

        internal List<Dictionary<string, object>> top5EspecialidadesConMasBonos(int mes, int anio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "mes", mes);
            DataBase.Instance.agregarParametro(parametros, "anio", anio);

            List<Dictionary<string, object>> lista = new List<Dictionary<string, object>>();

            autoMapping = false;

            List<Dictionary<string, object>> result = (List<Dictionary<string, object>>)executeStored("BEMVINDO.st_top5_especialidades_mas_bonos_consulta", parametros);

            autoMapping = true;

            foreach (Dictionary<string, object> item in result)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                Especialidad especialidad = (Especialidad)unSerialize(item);
                completeProperty("tipoDeEspecialidad", especialidad);
                dictionary.Add("especialidad", especialidad);
                dictionary.Add("bonos", item["cant_bonos_utilizados"]);
                lista.Add(dictionary);
            }

            return lista;
        }
    }
}
