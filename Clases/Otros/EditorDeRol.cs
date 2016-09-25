using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases.Otros
{
    public class EditorDeRol
    {
        public Rol rol { get; set;}
        public string mensajeDeError { get; set; }
        public EditorDeRolAction accion { get; set; }
        public List<Funcionalidad> funcionalidadesSistema { get; set; }

        public EditorDeRol()
        {
            cargarFuncionalidadesSistema();
        }

        private void cargarFuncionalidadesSistema()
        {
            FuncionalidadRepository repoFuncionalidad = new FuncionalidadRepository();
            funcionalidadesSistema = repoFuncionalidad.traerFuncionalidades();
        }

        public bool ejecutarAccion()
        {
            mensajeDeError = "";

            if (!cumpleValidaciones())
            {
                return false;
            }

            accion.execute(rol);
            return true;
        }

        private bool cumpleValidaciones()
        {
            if (rol.nombre=="")
            {
                mensajeDeError = "El rol debe tener un nombre";
                return false;
            }
            if (yaExisteRolConMismoNombre())
            {
                mensajeDeError = "El nombre del rol ya existe";
                return false;
            }
            if (rol.funcionalidades.Count==0)
            {
                mensajeDeError = "Un rol debe tener al menos 1 funcionalidad";
                return false;
            }

            return true;
        }

        private bool yaExisteRolConMismoNombre()
        {
            RolRepository repoRol = new RolRepository();

            return repoRol.traerRolPorNombre(rol.nombre) != null;
        }
    }
}
