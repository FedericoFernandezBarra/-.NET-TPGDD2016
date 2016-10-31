using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Clases.DAOS;

namespace ClinicaFrba.Clases.Otros
{
    public class ModificarRolAction : EditorDeRolAction
    {
        public override bool cumpleValidaciones()
        {
            return true;
        }

        public override void execute(Rol rol)
        {
            base.execute(rol);

            RolRepository repoRol = new RolRepository();
            repoRol.modificarRol(rol);
        }
    }
}
