using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.TIPO_ESPECIALIDAD")]
    public class TipoEspecialidad:Serializable
    {
        [Id(name = "id_tipo_especialidad", type = PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "descripcion")]
        public string descripcion { get; set; }
    }
}
