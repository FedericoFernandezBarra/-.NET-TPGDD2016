using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Clases.Otros
{
    public class ModificarAfiliado
    {
        public Afiliado afiliado { get; set; }
        public string mensajeDeError { get; set; }
        public string motivo { get; set; }
        public List<EstadoCivil> estadosCivilesSistema { get; set; }
        public List<PlanMedico> planesMedicosSistema { get; set; }

        private int mayorNumeroFamiliar = 0;

        public PlanMedico planMedicoActual { get; set; }

        public EstadoCivil estadoCivilActual { get; set; }

        private AfiliadoRepository repoAfiliado = new AfiliadoRepository();

        public ModificarAfiliado()
        {
            motivo = "";
            mensajeDeError = "";
            inicializarListasSistema();
        }

        private void inicializarListasSistema()
        {
            EstadoCivilRepository repoEstadoCivil = new EstadoCivilRepository();
            PlanMedicoRepository repoPlanMedico = new PlanMedicoRepository();

            estadosCivilesSistema = repoEstadoCivil.traerEstadosCiviles();
            planesMedicosSistema = repoPlanMedico.traerPlanesMedicos();
        }

        internal bool ejecutarModificacionesExitosamente()
        {
            if (!cumpleValidaciones())
            {
                return false;
            }

            modificar();

            return true;//Esto es por si despues se agregan validaciones
        }

        private void modificar()
        {
            if (afiliado.conyuge!=null)
            {
                repoAfiliado.insertarAfiliado(afiliado.conyuge, afiliado.numeroDeAfiliado);
            }

            foreach (Afiliado hijo in afiliado.hijos)
            {
                mayorNumeroFamiliar++;
                hijo.numeroFamiliar = mayorNumeroFamiliar;
                repoAfiliado.insertarAfiliado(hijo, afiliado.numeroDeAfiliado);
            } 

            repoAfiliado.modificarAfiliado(afiliado, motivo);
        }

        private bool cumpleValidaciones()
        {
            if (motivo==""&&hayCambioDePlan())
            {
                mensajeDeError = "Se debe especificar un motivo de cambio de plan";
                return false;
            }

            return true;
        }

        public bool hayCambioDePlan()
        {
            return planMedicoActual.id != afiliado.planMedico.id;
        }

        internal void cargarDatosActuales()
        {
            afiliado.hijos = new List<Afiliado>();
            cargarPlanMedicoActual();
            cargarEstadoCivilActual();
            mayorNumeroFamiliar = cantidadDeHijos()+2;//Obtengo el mayor desplazamiento del grupo
        }

        private void cargarEstadoCivilActual()
        {
            if (afiliado.estadoCivil!=null)
            {
                estadoCivilActual = new EstadoCivil();
                estadoCivilActual.id = afiliado.estadoCivil.id;
                estadoCivilActual.descripcion = afiliado.estadoCivil.descripcion;
            }
        }

        private void cargarPlanMedicoActual()
        {
            planMedicoActual = new PlanMedico();
            planMedicoActual.id = afiliado.planMedico.id;
            planMedicoActual.descripcion = afiliado.planMedico.descripcion;
            planMedicoActual.precioDeBonoConsulta = afiliado.planMedico.precioDeBonoConsulta;
        }

        internal void crearConyuge()
        {
            afiliado.conyuge = new Afiliado();
            afiliado.conyuge.usuario = new Usuario();
            afiliado.conyuge.numeroFamiliar = 2;
            afiliado.conyuge.estadoCivil = afiliado.estadoCivil;
            afiliado.conyuge.planMedico = afiliado.planMedico;
            afiliado.conyuge.cantidadDeHijos = afiliado.cantidadDeHijos;
            afiliado.conyuge.usuario.direccion = afiliado.usuario.direccion;
        }

        internal Afiliado crearHijo()
        {
            Afiliado nuevoHijo = new Afiliado();
            nuevoHijo.usuario = new Usuario();
            nuevoHijo.planMedico = afiliado.planMedico;
            nuevoHijo.usuario.direccion = afiliado.usuario.direccion;

            return nuevoHijo;
        }

        internal bool afiliadoTieneConyuge()
        {
            if (afiliado.estadoCivil == null)
            {
                return false;
            }

            string descripcionEstadoCivil = afiliado.estadoCivil.descripcion.ToLower();

            return descripcionEstadoCivil == "casado/a" || descripcionEstadoCivil == "concubinato";
        }

        private int cantidadDeHijos()
        {
            return repoAfiliado.obtenerCantidadDeHijos(afiliado);
        }
    }
}
