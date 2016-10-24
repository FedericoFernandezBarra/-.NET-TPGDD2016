using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Clases.DAOS;

namespace ClinicaFrba.Clases.Otros
{
    public class BuscarAfiliado
    {
        public Afiliado afiliado { get; set; }
        public List<Afiliado> afiliados { get; set; }
        public string mensajeDeError { get; set; }
        public PlanMedico planMedico { get; set; }
        public List<PlanMedico> planesMedicosSistema { get;set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public long nroAfiliado { get; set; }

        public BuscarAfiliado()
        {
            inicializarListas();
            mensajeDeError = "";
            afiliado = null;
        }

        private void inicializarListas()
        {
            planesMedicosSistema = (new PlanMedicoRepository()).traerPlanesMedicos();
            afiliados = new List<Afiliado>();
        }

        internal bool busquedaExitosa()
        {
            if (!cumpleValidaciones())
            {
                return false;
            }

            buscar();

            return true;
        }

        private void buscar()
        {
            afiliados = (new AfiliadoRepository()).buscarAfiliados(nroAfiliado, nombre, apellido, dni, planMedico);
        }

        private bool cumpleValidaciones()
        {
            if (ningunFiltroSeleccionado())
            {
                mensajeDeError = "Debe especificar al menos 1 filtro de busqueda";
            }

            return true;
        }

        private bool ningunFiltroSeleccionado()
        {
            return (planMedico == null) && (nombre == "") && (apellido == "") && (nroAfiliado == 0)&& (dni == "");
        }
    }
}
