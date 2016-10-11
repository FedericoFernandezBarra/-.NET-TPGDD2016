using TostadoPersistentKit;

namespace ClinicaFrba.Clases
{
    [Table(name = "BEMVINDO.TIPO_DOCUMENTO")]
    public class TipoDocumento:Serializable
    {
        [Id(name = "id_tipo_documento", type = PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "descripcion")]
        public string descripcion{ get; set; }
    }
}