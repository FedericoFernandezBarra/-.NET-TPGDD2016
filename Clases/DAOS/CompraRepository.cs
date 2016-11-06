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
    public class CompraRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Compra);
        }

        internal void insertarCompra(Compra compra)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@comprador", compra.comprador.usuario.id);
            /*SqlParameter parametroCantidad = new SqlParameter();
            parametroCantidad.Value = compra.cantidad.ToString();
            parametroCantidad.SqlDbType = System.Data.SqlDbType.NVarChar;
            parametroCantidad.ParameterName = "@cantidad";
            parametros.Add(parametroCantidad);*/
            DataBase.Instance.agregarParametro(parametros, "@cantidad", compra.cantidad);
            DataBase.Instance.agregarParametro(parametros, "@monto", compra.monto);
            DataBase.Instance.agregarParametro(parametros, "@fecha_compra", compra.fecha);

            compra.id = Convert.ToInt64(DataBase.Instance.ejecutarStoredConRetorno("BEMVINDO.st_insertar_compra", parametros, "@id_compra", compra.id));
        }
    }
}
