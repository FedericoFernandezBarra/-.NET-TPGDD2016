using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases.POJOS
{
    class ResultadoAtencionMedica
    {
        public long consultaID { get; set; }

        public long turnoID { get; set; }

        public String sintomas { get; set; }

        public String diagnostico { get; set; }

        public DateTime fechaDeDiagnostico { get; set; }

    }
}
