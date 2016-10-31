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
    public class BonoRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Bono);
        }

        internal Bono traerPorId(long numeroBono)
        {
            return (Bono)selectById(numeroBono);
        }

        internal void insertarBono(Compra compra)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "@plan_medico", compra.comprador.planMedico.id);
            DataBase.Instance.agregarParametro(parametros, "@compra", compra.id);

            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_insertar_bono", parametros);
        }
    }
}
