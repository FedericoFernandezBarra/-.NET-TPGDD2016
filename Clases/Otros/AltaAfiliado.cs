using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.Otros
{
    public class AltaAfiliado
    {
        public string mensajeDeError { get; set; }
        public Afiliado nuevoAfiliado { get; set; }
        public List<EstadoCivil> estadosCivilesSistema { get; set; }
        public List<TipoDocumento> tiposDeDocumentoSistema { get; set; }
        public List<char> sexosSistema { get; set; }
        public List<PlanMedico> planesMedicosSistema { get; set; }

        public AltaAfiliado()
        {
            nuevoAfiliado = new Afiliado();
            nuevoAfiliado.usuario = new Usuario();

            mensajeDeError = "";

            //inicializarListasSistema();
        }

        private void inicializarListasSistema()
        {
            EstadoCivilRepository repoEstadoCivil = new EstadoCivilRepository();
            TipoDocumentoRepository repoTipoDocumento = new TipoDocumentoRepository();
            PlanMedicoRepository repoPlanMedico = new PlanMedicoRepository();

            estadosCivilesSistema = repoEstadoCivil.traerEstadosCiviles();
            tiposDeDocumentoSistema = repoTipoDocumento.traerTiposDocumento();
            planesMedicosSistema = repoPlanMedico.traerPlanesMedicos();
            sexosSistema = new List<char> { 'M', 'F' };
        }

        internal bool ejecutarGuardadoExitoso()
        {
            if (!cumpleValidaciones())
            {
                return false;
            }

            guardarAfiliado();
            return true;
        }

        private bool cumpleValidaciones()
        {
            if (nuevoAfiliado.usuario.fechaDeNacimiento==Sistema.Instance.getDate())
            {
                mensajeDeError = "La fecha de nacimiento no puede ser igual a la fecha actual";
                return false;
            }
            if (datosIncompletos())
            {
                mensajeDeError = "Deben completarse todos los campos marcados con *";
            }
            return true;
        }

        private bool datosIncompletos()
        {
            return nuevoAfiliado.usuario.nombre == "" || 
                    nuevoAfiliado.usuario.apellido == "" || 
                    nuevoAfiliado.usuario.documento == "" || 
                    nuevoAfiliado.usuario.direccion == "" || 
                    nuevoAfiliado.usuario.telefono == "" || 
                    nuevoAfiliado.usuario.mail == "";
        }

        private void guardarAfiliado()
        {
            //guardar afiliado
        }
    }
}
