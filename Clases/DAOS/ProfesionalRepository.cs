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
    class ProfesionalRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Profesional);
        }

        internal List<Profesional> buscarProfesionales(long nroMatricula, string nombre, string apellido, Especialidad especialidad)
        {
            object nroMatriculaValue = nroMatricula == 0 ? null : (object)nroMatricula;
            object nombreValue = nombre == "" ? null : nombre;
            object apellidoValue = apellido == "" ? null : apellido;
            object especialidadValue = especialidad == null ? null : (object)especialidad.id;

            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@nombre", nombreValue);
            DataBase.Instance.agregarParametro(parametros, "@apellido", apellidoValue);
            DataBase.Instance.agregarParametro(parametros, "@especialidad", especialidadValue);
            DataBase.Instance.agregarParametro(parametros, "@matricula", nroMatriculaValue);

            return (List<Profesional>)executeStored("BEMVINDO.st_buscar_profesional", parametros);

        }

        internal Profesional traerProfesionalPorUser(Usuario usuario)
        {
            List<Profesional> profesionales = (List<Profesional>)selectByProperty("usuario", usuario.id);

            return profesionales.Count > 0 ? profesionales[0] : null;
        }

        internal List<Dictionary<string, object>> top5ProfesionalesMasConsultas(int mes, int anio, PlanMedico filtroPlan)
        {
            object planValue = filtroPlan == null ? null : (object)filtroPlan.id;

            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "mes", mes);
            DataBase.Instance.agregarParametro(parametros, "anio", anio);
            DataBase.Instance.agregarParametro(parametros, "@plan_medico", planValue);

            List<Dictionary<string, object>> lista = new List<Dictionary<string, object>>();

            autoMapping = false;

            List<Dictionary<string, object>> result = (List<Dictionary<string, object>>)executeStored("BEMVINDO.st_top5_profesionales_mas_consultados", parametros);

            autoMapping = true;

            foreach (Dictionary<string, object> item in result)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                Profesional profesional = (Profesional)unSerialize(item);
                dictionary.Add("profesional", profesional);
                dictionary.Add("consultas", item["cant_de_consultas"]);
                lista.Add(dictionary);
            }

            return lista;
        }

        internal List<Dictionary<string, object>> top5ProfesionalesMenosHorasTRabajadas(int mes, int anio, Especialidad filtroEspecialidad)
        {
            object especialidadValue = filtroEspecialidad == null ? null : (object)filtroEspecialidad.id;

            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "mes", mes);
            DataBase.Instance.agregarParametro(parametros, "anio", anio);
            DataBase.Instance.agregarParametro(parametros, "@especialidad", especialidadValue);

            List<Dictionary<string, object>> lista = new List<Dictionary<string, object>>();

            autoMapping = false;

            List<Dictionary<string, object>> result = (List<Dictionary<string, object>>)executeStored("BEMVINDO.st_top5_profesionales_menos_horas_trabajdas", parametros);

            autoMapping = true;

            foreach (Dictionary<string, object> item in result)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                Profesional profesional = (Profesional)unSerialize(item);
                dictionary.Add("profesional", profesional);
                dictionary.Add("horas", item["cant_horas_trabajadas"]);
                lista.Add(dictionary);
            }

            return lista;
        }
    }
}
