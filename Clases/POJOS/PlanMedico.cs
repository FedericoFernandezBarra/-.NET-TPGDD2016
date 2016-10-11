using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.PLAN_MEDICO")]
    public class PlanMedico:Serializable
    {
        [Id(name = "id_plan_medico",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "descripcion")]
        public string descripcion { get; set; }

        [Column(name = "precio_bono_consulta")]
        public double precioDeBonoConsulta { get; set; }

        [Column(name = "precio_bono_farmacia")]
        public double precioDeBonoFarmacia { get; set; }

        [Column(name = "activo")]
        public bool activo { get; set; }
    }
}