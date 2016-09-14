using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases
{
    public class Usuario:Serializable
    {
        public long id { get; set; }
        public string nick { get; set; }
        public string pass { get; set; }
        public int intentosDeLogin { get; set; }
        public bool activo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public TipoDocumento tipoDeDocumento { get; set; }
        public string documento { get; set; }
        public DateTime fechaDeNacimiento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public char sexo { get; set; }

        internal override void map()
        {
            mappings.Add("id", "");
            mappings.Add("nick","");
            mappings.Add("pass","");
            mappings.Add("intentosDeLogin","");
            mappings.Add("activo","");
            mappings.Add("nombre","");
            mappings.Add("apellido","");
            mappings.Add("tipoDeDocumento","");
            mappings.Add("documento","");
            mappings.Add("fechaDeNacimiento","");
            mappings.Add("direccion","");
            mappings.Add("telefono","");
            mappings.Add("mail","");
            mappings.Add("sexo","");
        }

        internal override void setIdProperty()
        {
            idProperty = "id";
        }

        internal override void setTableNameProperty()
        {
            tableName = "usuario";
        }

        internal override void setPrimaryKeyType()
        {
            primaryKetyType = PrimaryKeyType.SURROGATE;
        }
    }
}
