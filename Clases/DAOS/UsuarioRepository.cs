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
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataBase.Instance.agregarParametro(parametros, "nick", nick);
            DataBase.Instance.agregarParametro(parametros, "pass", pass);

            List<Usuario> usuarios = (List<Usuario>)executeStored("BEMVINDO.VERIFICAR_LOGUEO", parametros); 

            return usuarios.Count > 0 ? usuarios[0] : null;
        }

        internal void cargarRoles(Usuario usuario)
        {
            completeProperty("roles", usuario);
        }

        internal override Type getModelClassType()
        {
            return typeof(Usuario);
        }

        internal void darDeBajaUsuario(string username)
        {
            DataBase.Instance.ejecutarStoredProcedure("BEMVINDO.st_dar_de_baja_usuario", new List<SqlParameter> { new SqlParameter("@nick", username) });
        }

        internal Usuario traerUsuarioPorId(long id)
        {
            return (Usuario)selectById(id);
        }
    }
}
