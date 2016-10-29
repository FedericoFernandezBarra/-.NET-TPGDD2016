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
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@profesional", null);
            DataBase.Instance.agregarParametro(parametros, "@nombre", nombre);
            DataBase.Instance.agregarParametro(parametros, "@apellido", apellido);
            DataBase.Instance.agregarParametro(parametros, "@especialidad", especialidad.id);
            DataBase.Instance.agregarParametro(parametros, "@matricula", nroMatricula);

            return (List<Profesional>)executeStored("BEMVINDO.st_buscar_profesional", parametros);

        }

        internal Profesional traerProfesionalPorUser(Usuario usuario)
        {
            List<Profesional> profesionales = (List<Profesional>)selectByProperty("usuario", usuario.id);

            return profesionales.Count > 0 ? profesionales[0] : null;
        }
    }
}
