using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.FUNCIONALIDAD")]
    public class Funcionalidad:Serializable
    {
        [Id(name = "id_funcionalidad",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "descripcion")]
        public string nombre { get; set; }

        [Column(name = "activo")]
        public bool activo { get; set; }
    }
}