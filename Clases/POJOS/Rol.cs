using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    public class Rol:Serializable
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public List<Funcionalidad> funcionalidades { get; set; }
        public bool habilitado { get; set; }

        public Rol()
        {
            nombre = "";
            funcionalidades = new List<Funcionalidad>();
            habilitado = true;
        }

        internal override void map()
        {
            mappings.Add("id", "id_rol");
            mappings.Add("nombre", "nombre");
            mappings.Add("habilitado", "habilitado");
        }

        internal override string getIdPropertyName()
        {
            return "id";
        }

        internal override string getTableName()
        {
            return "rol";
        }

        internal override PrimaryKeyType getPrimaryKeyType()
        {
            return PrimaryKeyType.SURROGATE;
        }

        internal override FetchType getFetchType()
        {
            return FetchType.LAZY;
        }
    }
}
