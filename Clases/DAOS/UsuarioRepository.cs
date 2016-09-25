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
        public Usuario traerUserPorNickYPass(string nick, string pass)
        {
            /*string loginStored = "asd<asdsaasdads";//Nombre del stored

            List<SqlParameter> parametros = new List<SqlParameter>();

            DataBase.Instance.agregarParametro(parametros, "nombreNickStored", nick);
            DataBase.Instance.agregarParametro(parametros, "nombrePassStored", pass);

            object resultado = executeStored(loginStored, parametros);*/

            Usuario user = new Usuario();

            string query = "select * from usuario where nick='" + nick + "' and pass='" + pass+"'";

            List<object> resultado = (List<object>)executeQuery(query, null);

            return resultado.Count > 0 ? (Usuario)resultado[0] : null;

            /*Usuario usuarioHard = new Usuario();
            usuarioHard.nick = nick;
            usuarioHard.pass = pass;

            return nick == "" || pass == "" ? null : usuarioHard;*/
        }

        internal override Type getModelClassType()
        {
            return typeof(Usuario);
        }

    }
}
