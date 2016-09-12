using ClinicaFrba.Clases;
using ClinicaFrba.Clases.DAOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Login
{
    public class Login
    {
        private bool bajaLogica;

        public string username { get; set; }

        public string password { get; set; }

        public string mensajeDeError { get; set; }

        private int intentosDeLogueo;

        private const int MAX_CANTIDAD_INTENTOS = 3;

        private UsuarioRepository repoUsuario = new UsuarioRepository();

        public Usuario usuarioLogueado { get; set; }

        public Login()
        {
            username = "";
            password = "";
            mensajeDeError = "";
            bajaLogica = false;
            usuarioLogueado = null;
            intentosDeLogueo = 0;
        }

        internal bool cumpleValidaciones()
        {
            if (username == "" || password == "")
            {
                mensajeDeError = "Debe completar todos los campos";
                return false;
            }

            return true;
        }

        public bool logueoExitoso()
        {
            if (!existeUserNameYPass())
            {
                mensajeDeError = "El Nick o el Pass son incorrectos";
                return false;
            }
            if (bajaLogica)
            {
                mensajeDeError = "Ha sido bloqueado, comuniquese con el Administrador";
                return false;
            }

            return true;
        }

        private bool existeUserNameYPass()
        {
            usuarioLogueado = repoUsuario.traerUserPorNickYPass(username, password);

            if (usuarioLogueado==null)
            {
                intentosDeLogueo = intentosDeLogueo >= MAX_CANTIDAD_INTENTOS ? MAX_CANTIDAD_INTENTOS : intentosDeLogueo + 1;

                if (intentosDeLogueo>=MAX_CANTIDAD_INTENTOS)
                {
                    bajaLogica = true;
                }

                return false;
            }

            return true;
        }
    }
}
