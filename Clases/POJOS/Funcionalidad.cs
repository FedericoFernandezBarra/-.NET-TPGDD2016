using System;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    public class Funcionalidad:Serializable
    {
        public long id { get; set; }
        public string nombre { get; set; }

        internal override FetchType getFetchType()
        {
            return FetchType.LAZY;
        }

        internal override string getIdPropertyName()
        {
            return "id";
        }

        internal override PrimaryKeyType getPrimaryKeyType()
        {
            return PrimaryKeyType.SURROGATE;
        }

        internal override string getTableName()
        {
            return "funcionalidad";
        }

        internal override void map()
        {
            mappings.Add("id", "id_funcionalidad");
            mappings.Add("nombre", "nombre");
        }
    }
}