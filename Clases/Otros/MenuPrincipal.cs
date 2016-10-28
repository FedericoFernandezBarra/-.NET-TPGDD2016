using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases.Otros
{
    public class MenuPrincipal
    {
        public Rol rol { get; set; }

        public Usuario usuario { get; set; }

        public object usuarioPosta { get; set; }

        internal bool usuarioLogueado()
        {
            return usuario != null;
        }

        internal void cargarDatosDeRol()
        {
            switch (rol.nombre)
            {
                case "AFILIADO": usuarioPosta = (new AfiliadoRepository()).traerAfiliadoPorUser(usuario);
                    break;

                case "PROFESIONAL":
                    usuarioPosta = (new ProfesionalRepository()).traerProfesionalPorUser(usuario);
                    break;

                default:
                    usuarioPosta = usuario;
                    break;
            }
        }

        internal bool usuarioPuedeUsar(string accion)
        {
            return rol.funcionalidades.Exists(f => f.nombre.ToLower()==accion.ToLower());
        }

        internal void cerrarSesion()
        {
            rol = null;
            usuario = null;
            usuarioPosta = null;
        }
    }
}
