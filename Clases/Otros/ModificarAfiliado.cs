using ClinicaFrba.Clases.DAOS;
using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases.Otros
{
    public class ModificarAfiliado
    {
        public Afiliado afiliado { get; set; }
        public string mensajeDeError { get; set; }
        public string motivo { get; set; }
        public List<EstadoCivil> estadosCivilesSistema { get; set; }
        public List<PlanMedico> planesMedicosSistema { get; set; }

        public PlanMedico planMedicoActual { get; set; }
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

            repoAfiliado.modificarAfiliado(afiliado,motivo);
            return true;//Esto es por si despues se agregan validaciones
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

        private bool hayCambioDePlan()
        {
            return planMedicoActual.id != afiliado.planMedico.id;
        }

        internal void cargarPlanMedicoActual()
        {
            planMedicoActual = new PlanMedico();
            planMedicoActual.id = afiliado.planMedico.id;
            planMedicoActual.descripcion = afiliado.planMedico.descripcion;
            planMedicoActual.precioDeBonoConsulta = afiliado.planMedico.precioDeBonoConsulta;
        }
    }
}
