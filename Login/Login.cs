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

        public Login()
        {
            username = "";
            password = "";
            mensajeDeError = "";
            bajaLogica = false;
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
            return true;
        }
    }
}
