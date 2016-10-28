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
    public class AfiliadoRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Afiliado);
        }

        public string insertarAfiliado(Afiliado afiliado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            //DataBase.Instance.agregarParametro(parametros, "error", "");

            autoMapping = false;

            Dictionary<string, object> result = ((List<Dictionary<string, object>>)
                                                executeStored("BEMVINDO.st_insertar_afiliado",
                                                afiliado, parametros))[0];

            autoMapping = true;

            afiliado.usuario.nick = result["nick"].ToString();
            afiliado.usuario.pass = result["pass"].ToString();
            afiliado.numeroDeAfiliado = Convert.ToInt64(result["id_afiliado"]);//Seteo las nuevas propiedades

            return result["error"].ToString();
        }

        internal Afiliado traerAfiliadoPorUser(Usuario usuario)
        {
            List<Afiliado> afiliados = (List<Afiliado>)selectByProperty("usuario", usuario.id);

            return afiliados.Count > 0 ? afiliados[0] : null;
        }

        internal void darDeBajaAfiliado(Afiliado afiliado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            DataBase.Instance.agregarParametro(parametros, "id_afiliado", afiliado.numeroDeAfiliado);
            DataBase.Instance.agregarParametro(parametros, "fecha_baja", DataBase.Instance.getDate());

            executeStored("BEMVINDO.st_baja_afiliado", parametros);
        }

        internal List<Afiliado> buscarAfiliados(long nroAfiliado, string nombre, string apellido, string dni, PlanMedico planMedico)
        {
            throw new NotImplementedException();
        }

        internal void modificarAfiliado(Afiliado afiliado,string motivo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "motivo", motivo);
            DataBase.Instance.agregarParametro(parametros, "fecha", DataBase.Instance.getDate());

            executeStored("BEMVINDO.st_actualizar_afiliado", afiliado, parametros);
        }

        internal Afiliado traerAfiliadoPorId(long id)
        {
            return (Afiliado)selectById(id);
        }
    }
}
