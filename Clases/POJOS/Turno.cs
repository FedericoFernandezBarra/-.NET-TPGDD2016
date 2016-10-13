using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;
using static TostadoPersistentKit.Serializable;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.TURNO")]
    public class Turno//:Serializable
    {
        [Id(name ="id_turno",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name ="afiliado",fetch =FetchType.EAGER)]
        public Afiliado afiliado { get; set; }

        [Column(name = "profesional", fetch = FetchType.EAGER)]
        public Profesional profesional { get; set; }

        [Column(name = "especialidad", fetch = FetchType.EAGER)]
        public Especialidad especialidad { get; set; }

        [Column(name = "fecha_turno")]
        public DateTime fechaDeTurno { get; set; }

        [Column(name = "fecha_llegada")]
        public DateTime fechaDeLlegada { get; set; }

        [Column(name = "activo")]
        public bool activo { get; set; }
    }
}
