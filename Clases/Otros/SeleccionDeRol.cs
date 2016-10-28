using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases.Otros
{
    public class SeleccionDeRol
    {
        public Rol rolSeleccionado { get; set; }
        public Usuario usuario { get; set; }

        public SeleccionDeRol()
        {
            rolSeleccionado = null;
        }

        public void cargarRolesDeUsuario()
        {
            (new UsuarioRepository()).cargarRoles(usuario);
        }
    }
}
