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
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("nick", nick);
            properties.Add("pass", pass);

            List<Usuario> usuarios = (List<Usuario>)selectByProperties(properties);

            return usuarios.Count > 0 ? usuarios[0] : null;
        }

        internal override Type getModelClassType()
        {
            return typeof(Usuario);
        }

    }
}
