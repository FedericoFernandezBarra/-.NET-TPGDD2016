using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.BONO")]
    public class Bono:Serializable
    {
        [Id(name = "id_bono",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "plan_medico",fetch =FetchType.EAGER)]
        public PlanMedico planMedico { get; set; }

        //[Column(name = "compra",fetch =FetchType.LAZY)]
        //public Compra compra { get; set; }

        [Column(name = "turno",fetch =FetchType.EAGER)]
        public Turno turno { get; set; }
    }
}
