using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.HISTORIAL_CAMBIOS_DE_PLAN")]
    public class HistorialCambiosDePlan:Serializable
    {
        [Id(name = "id_historial",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "plan_medico",fetch =FetchType.EAGER)]
        public PlanMedico plan { get; set; }

        [Column(name = "afiliado",fetch =FetchType.LAZY)]
        public Afiliado afiliado { get; set; }

        [Column(name = "motivo")]
        public string motivo { get; set; }

        [Column(name ="fecha")]
        public DateTime fecha { get; set; }
    }
}
