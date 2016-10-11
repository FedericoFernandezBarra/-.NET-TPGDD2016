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
        private AfiliadoRepository repoAfiliado = new AfiliadoRepository();

        public AltaAfiliado()
        {
            nuevoAfiliado = new Afiliado();
            nuevoAfiliado.usuario = new Usuario();

            mensajeDeError = "";

            inicializarListasSistema();
        }

        private void inicializarListasSistema()
        {
            EstadoCivilRepository repoEstadoCivil = new EstadoCivilRepository();
            TipoDocumentoRepository repoTipoDocumento = new TipoDocumentoRepository();
            PlanMedicoRepository repoPlanMedico = new PlanMedicoRepository();

            /*estadosCivilesSistema = repoEstadoCivil.traerEstadosCiviles();
            tiposDeDocumentoSistema = repoTipoDocumento.traerTiposDocumento();
            planesMedicosSistema = repoPlanMedico.traerPlanesMedicos();*/
            sexosSistema = new List<char> { 'M', 'F' };
            EstadoCivil casado = new EstadoCivil();
            casado.descripcion = "casado";
            estadosCivilesSistema = new List<EstadoCivil> { casado };//Hardcodeado por ahora
        }

        internal void ejecutarGuardado()
        {
            guardarAfiliado();
        }

        public bool cumpleValidaciones()
        {
            if (nuevoAfiliado.usuario.fechaDeNacimiento>=Sistema.Instance.getDate())
            {
                mensajeDeError = "La fecha de nacimiento no puede ser mayor o igual a la fecha actual";
                return false;
            }
            if (datosIncompletos())
            {
                mensajeDeError = "Deben completarse todos los campos marcados con *";
                return false;
            }
            if (nuevoAfiliado.cantidadDeHijos<0)
            {
                mensajeDeError = "La cantidad de hijos no puede ser negativa";
                return false;
            }
            return true;
        }

        private bool datosIncompletos()
        {
            return isEmpty(nuevoAfiliado.usuario.nombre) ||
                    isEmpty(nuevoAfiliado.usuario.apellido)||
                    isEmpty(nuevoAfiliado.usuario.documento) ||
                    isEmpty(nuevoAfiliado.usuario.direccion) ||
                    isEmpty(nuevoAfiliado.usuario.telefono) ||
                    isEmpty(nuevoAfiliado.usuario.mail);
        }

        private bool isEmpty(string campo)
        {
            return campo == null || campo == "";
        }

        private void guardarAfiliado()
        {
            repoAfiliado.insertarAfiliado(nuevoAfiliado);

            if (nuevoAfiliado.conyuge!=null)
            {
                repoAfiliado.insertarAfiliado(nuevoAfiliado.conyuge);
            }

            nuevoAfiliado.hijos.ForEach(hijo => repoAfiliado.insertarAfiliado(hijo));
        }

        internal void crearConyuge()
        {
            nuevoAfiliado.conyuge = new Afiliado();
            nuevoAfiliado.conyuge.numeroFamiliar = 2;
            nuevoAfiliado.conyuge.estadoCivil = nuevoAfiliado.estadoCivil;
            nuevoAfiliado.conyuge.planMedico = nuevoAfiliado.planMedico;
            nuevoAfiliado.conyuge.cantidadDeHijos = nuevoAfiliado.cantidadDeHijos;
            nuevoAfiliado.conyuge.usuario.direccion = nuevoAfiliado.usuario.direccion;

            //Esto para mi esta re mal, o tnemos un usuario por afiliado o 
           // migramos los datos de usuario a afiliado
        }

        internal Afiliado crearNuevoHijo()
        {
            if (nuevoAfiliado.cantidadDeHijos<=nuevoAfiliado.hijos.Count)
            {
                mensajeDeError = "No se puede agragar mas hijos de la especificada";
                return null;
            }

            Afiliado nuevoHijo = new Afiliado();
            nuevoHijo.numeroFamiliar = mayorNumeroFamiliar() + 1;
            //Hay que ver que mas se hace

            nuevoAfiliado.hijos.Add(nuevoHijo);

            return nuevoHijo;
        }

        private long mayorNumeroFamiliar()
        {
            long mayorNro = nuevoAfiliado.conyuge == null ? nuevoAfiliado.numeroFamiliar : nuevoAfiliado.conyuge.numeroFamiliar;

            foreach (Afiliado hijo in nuevoAfiliado.hijos)
            {
                if (hijo.numeroFamiliar>mayorNro)
                {
                    mayorNro = hijo.numeroFamiliar;
                }
            }

            return mayorNro;
        }

        internal void borrarHijo(Afiliado hijo)
        {
            nuevoAfiliado.hijos.Remove(hijo);
        }
    }
}
