using System.Collections.Generic;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.ROL")]
    public class Rol:Serializable
    {
        [Id(name = "id_rol",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "descripcion")]
        public string nombre { get; set; }

        [OneToMany(pkName ="id_rol",tableName = "BEMVINDO.FUNCIONALIDAD_POR_ROL",fkName ="id_funcionalidad",fetch =FetchType.EAGER)]
        public List<Funcionalidad> funcionalidades { get; set; }

        [Column(name = "activo")]
        public bool habilitado { get; set; }

        public Rol()
        {
            funcionalidades = new List<Funcionalidad>();
            nombre = "";
            habilitado = true;
        }
    }
}
