using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Clases.DAOS;

namespace ClinicaFrba.Clases.Otros
{
    public class CrearRolAction : EditorDeRolAction
    {
        public void execute(Rol rol)
        {
            RolRepository repoRol = new RolRepository();
            repoRol.insertarRol(rol);
        }
    }
}
