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

        [Column(name = "id_afiliado",fetch =FetchType.LAZY)]
        public Usuario usuario { get; set; }

        [Column(name = "estado_civil", fetch = FetchType.EAGER)]
        public EstadoCivil estadoCivil { get; set; }

        [Column(name = "plan_medico", fetch = FetchType.EAGER)]
        public PlanMedico planMedico { get; set; }

        [Column(name = "nro_grupo_familiar")]
        public long numeroFamiliar { get; set; }

        [Column(name = "baja_logica")]
        public bool bajaLogica { get; set; }

        [Column(name = "cantidad_hijos")]
        public int cantidadDeHijos { get; set; }

        [Column(name = "fecha_baja")]
        public DateTime fechaDeBaja { get; set; }

        public List<Afiliado> hijos { get; set; }
        public Afiliado conyuge { get; set; }

        public Afiliado()
        {
            hijos = new List<Afiliado>();
            numeroFamiliar = 1;
        }
    }
}