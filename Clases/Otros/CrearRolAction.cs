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
        public override bool cumpleValidaciones()
        {
            if (yaExisteRolConMismoNombre())
            {
                mensajeDeError = "El nombre del rol ya existe";
                return false;
            }
            return true;
        }

        public override void execute(Rol rol)
        {
            base.execute(rol);

            RolRepository repoRol = new RolRepository();
            repoRol.insertarRol(rol);
        }

        private bool yaExisteRolConMismoNombre()
        {
            RolRepository repoRol = new RolRepository();

            return repoRol.traerRolPorNombre(rol.nombre) != null;
        }
    }
}
