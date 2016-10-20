using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    public class RolRepository:Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Rol);
        }

        internal object traerRolPorNombre(string nombre)
        {
            List<object> roles = selectByProperty("nombre", nombre);

            return roles.Count > 0 ? (Rol)roles[0] : null;
        }

        internal void modificarRol(Rol rol)
        {
            update(rol);
        }

        internal List<Rol> traerRoles()
        {
            List<Rol> roles = new List<Rol>();
            selectAll().ForEach(o => roles.Add((Rol)o));

            return roles;
        }

        internal void insertarRol(Rol rol)
        {
            insert(rol);
            //ejecutar el stored que inserta un rol
        }
    }
}
