using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class UsuarioRepository : Repository
    {
        internal override void setModelClassType()
        {
            modelClassType = typeof(Usuario);
        }

        public Usuario traerUserPorNickYPass(string nick,string pass)
        {
            /*string loginStored = "asd<asdsaasdads";//Nombre del stored

            List<SqlParameter> parametros = new List<SqlParameter>();

            DataBase.Instance.agregarParametro(parametros, "nombreNickStored", nick);
            DataBase.Instance.agregarParametro(parametros, "nombrePassStored", pass);

            object resultado = executeStored(loginStored, parametros);

            return resultado == null ? null : (Usuario)resultado;*/

            Usuario usuarioHard = new Usuario();
            usuarioHard.nick = nick;
            usuarioHard.pass = pass;

            return usuarioHard;
        }
    }
}
