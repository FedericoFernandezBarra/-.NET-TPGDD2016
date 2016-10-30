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
    class HistorialCambiosDePlanRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(HistorialCambiosDePlan);
        }

        internal List<HistorialCambiosDePlan> buscarHistorialDeCambios(Afiliado afiliado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "id_afiliado", afiliado.usuario.id);

            return (List<HistorialCambiosDePlan>)executeStored("BEMVINDO.buscar_historial_de_cambios", parametros);
        }
    }
}
