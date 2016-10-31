using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class GrupoAfiliadoViejoRepository : Repository
    {
        DataBase db = DataBase.Instance;

        internal override Type getModelClassType()
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, object>> traerAfiliadosSinNumero()
        {
            string procedimiento = "BEMVINDO.sp_afiliados_sin_numero_afiliado";

            return db.ejecutarStoredProcedure(procedimiento, null);
        }

        public void asignarNuerosDeUsuario(long idPrincipal, long idConyuge, List<long> hijos)
        {
            //principal
            string procedimiento = "BEMVINDO.sp_agregar_numero_afiliado_a_afiliado_principal_migrado";

            SqlParameter p1 = new SqlParameter("@id_principal", idPrincipal);
            List<SqlParameter> parametros1 = new List<SqlParameter> {p1};

            db.ejecutarStoredProcedure(procedimiento, parametros1);

            
            //conyuge
            if (idConyuge != 0)
            {
                procedimiento = "BEMVINDO.sp_agregar_numero_afiliado_a_conyuge_migrado";

                SqlParameter p2 = new SqlParameter("@id_principal", idPrincipal);
                SqlParameter p3 = new SqlParameter("@id_conyuge", idConyuge);
                List<SqlParameter> parametros2 = new List<SqlParameter> { p2 , p3}; 

                db.ejecutarStoredProcedure(procedimiento, parametros2);
            }
            
            //hijos o familiares
            if (hijos.Count != 0)
            {
                procedimiento = "BEMVINDO.sp_agregar_numero_afiliado_a_hijo_migrado";

                foreach (long id_hijo in hijos)
                {
                    SqlParameter p4 = new SqlParameter("@id_principal", idPrincipal);
                    SqlParameter p5 = new SqlParameter("@id_hijo", id_hijo);
                    List<SqlParameter> parametros3 = new List<SqlParameter> { p4, p5 };

                    db.ejecutarStoredProcedure(procedimiento, parametros3);
                }
            }
        }


    }
}
