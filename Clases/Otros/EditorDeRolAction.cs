using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases.Otros
{
    public abstract class EditorDeRolAction
    {
        public Rol rol { get; set; }

        public string mensajeDeError { get; set; }

        public EditorDeRolAction()
        {
            mensajeDeError = "";
        }

        public virtual void execute(Rol rol)
        {
            (new RolRepository()).borrarFuncionalidades(rol);
        }

        public abstract bool cumpleValidaciones();
    }
}
