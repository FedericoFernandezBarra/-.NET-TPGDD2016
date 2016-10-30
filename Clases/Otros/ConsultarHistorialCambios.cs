using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Clases.POJOS;
using ClinicaFrba.Clases.DAOS;

namespace ClinicaFrba.Clases.Otros
{
    public class ConsultarHistorialCambios
    {
        public Afiliado afiliado { get; set; }
        public List<HistorialCambiosDePlan> historiales { get; set; }
        public string mensajeDeError { get; set; }
        private HistorialCambiosDePlanRepository repoCambiosDePlan = new HistorialCambiosDePlanRepository();

        public ConsultarHistorialCambios()
        {
            mensajeDeError = "";
        }

        public void buscarHistorialDeCambios()
        {
            historiales = repoCambiosDePlan.buscarHistorialDeCambios(afiliado);
        }
    }
}
