using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases.Otros
{
    public class AbmRol
    {
        public List<Rol> rolesSistema { get; set; }
        public Rol rolSeleccionado { get; set; }

        public AbmRol()
        {
            rolSeleccionado = null;
            cargarRolesSistema();
        }

        private void cargarRolesSistema()
        {
            RolRepository repoRol = new RolRepository();
            rolesSistema = repoRol.traerRoles();
        }
    }
}
