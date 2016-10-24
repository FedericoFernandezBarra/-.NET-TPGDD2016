using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
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
            List<Rol> roles = (List<Rol>)selectByProperty("nombre", nombre);

            return roles.Count > 0 ? roles[0] : null;
        }

        internal void modificarRol(Rol rol)
        {
            update(rol);
        }

        internal List<Rol> traerRoles()
        {
            return (List<Rol>)selectAll();
        }

        internal void insertarRol(Rol rol)
        {
            insert(rol);
            //ejecutar el stored que inserta un rol
        }
    }
}
