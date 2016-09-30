using TostadoPersistentKit;
using UsingTostadoPersistentKit.TostadoPersistentKit;
using static TostadoPersistentKit.Serializable;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.ESTADO_CIVIL")]
    public class EstadoCivil:Serializable
    {
        [Id(name = "id_estado_civil",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "descripcion")]
        public string descripcion { get; set; }
    }
}