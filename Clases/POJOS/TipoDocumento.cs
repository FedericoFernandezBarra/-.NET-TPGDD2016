using System;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases
{
    public class TipoDocumento:Serializable
    {
        public long id { get; set; }
        public string descripcion{ get; set; }

        internal override void map()
        {
            mappings.Add("id", "id");
            mappings.Add("descripcion", "descripcion");
        }

        internal override string getIdPropertyName()
        {
            return "id";
        }

        internal override string getTableName()
        {
            return "tipo_documento";
        }

        internal override PrimaryKeyType getPrimaryKeyType()
        {
            return PrimaryKeyType.SURROGATE;
        }
    }
}