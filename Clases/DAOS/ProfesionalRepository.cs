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
            object especialidadValue = especialidad.id==0 ? null : (object)especialidad.id;

            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", null);
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
    }
}
