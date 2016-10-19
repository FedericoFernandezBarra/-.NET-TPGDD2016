using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.PROFESIONAL")]
    public class Profesional //: Serializable
    {
        [Id(name = "id_profesional", type = PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "id_profesional", fetch = FetchType.EAGER)]
        public Usuario usuario { get; set; }

        [Column(name = "matricula")]
        public string matricula { get; set; }

        [OneToMany(pkName = "id_profesional", tableName = "ESPECIALIDAD_POR_PROFESIONAL", fkName = "id_especialidad", fetch = FetchType.EAGER)]
        public List<Especialidad> especialidades { get; set; }

        public Profesional()
        {
            especialidades = new List<Especialidad>();
        }
    }
}
