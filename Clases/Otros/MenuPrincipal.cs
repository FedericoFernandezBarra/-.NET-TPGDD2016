using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Clases.Otros
{
    public class MenuPrincipal
    {
        public Rol rol { get; set; }

        public Usuario usuario { get; set; }

        public object usuarioPosta { get; set; }

        private const string AFILIADO = "afiliado";
        private const string PROFESIONAL = "profesional";
        private const string ADMINISTRATIVO = "administrativo";

        internal bool usuarioLogueado()
        {
            return usuario != null;
        }

        internal void cargarDatosDeRol()
        {
            if (rol==null)
            {
                return;
            }

            switch (rol.nombre.ToLower())
            {
                case AFILIADO: usuarioPosta = (new AfiliadoRepository()).traerAfiliadoPorUser(usuario);
                    break;

                case PROFESIONAL:
                    usuarioPosta = (new ProfesionalRepository()).traerProfesionalPorUser(usuario);
                    break;

                default:
                    usuarioPosta = usuario;
                    break;
            }
        }

        internal bool usuarioPuedeUsar(string accion)
        {
            if (rol==null)
            {
                return false;
            }
            return rol.funcionalidades.Exists(f => f.nombre.ToLower()==accion.ToLower());
        }

        internal void cerrarSesion()
        {
            rol = null;
            usuario = null;
            usuarioPosta = null;
        }

        internal bool userEsAfiliado()
        {
            return rol.nombre.ToLower() == AFILIADO.ToLower();
        }

        internal bool userEsProfesional()
        {
            return rol.nombre.ToLower() == PROFESIONAL.ToLower();
        }

        internal bool userEsAdministrativo()
        {
            return rol.nombre.ToLower() == ADMINISTRATIVO.ToLower();
        }
    }
}
