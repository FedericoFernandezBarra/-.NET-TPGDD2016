using System;
using System.Collections.Generic;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.AFILIADO")]
    public class Afiliado:Serializable
    {
        [Id(name = "id_afiliado", type = PrimaryKeyType.NATURAL)]
        public long id { get; set; }

        [Column(name = "id_afiliado", fetch =FetchType.EAGER)]
        public Usuario usuario { get; set; }

        [Column(name = "estado_civil", fetch = FetchType.EAGER)]
        public EstadoCivil estadoCivil { get; set; }

        [Column(name = "plan_medico", fetch = FetchType.EAGER)]
        public PlanMedico planMedico { get; set; }

        [Column(name = "numero_afiliado")]
        public long numeroDeAfiliado { get; set; }

        [Column(name = "baja_logica")]
        public bool bajaLogica { get; set; }

        [Column(name = "fecha_baja")]
        public DateTime fechaDeBaja { get; set; }

        public int numeroFamiliar { get; set; }
        public int cantidadDeHijos { get; set; }
        public List<Afiliado> hijos { get; set; }
        public Afiliado conyuge { get; set; }

        public Afiliado()
        {
            cantidadDeHijos = 0;
            numeroFamiliar = 1;
        }
    }
}