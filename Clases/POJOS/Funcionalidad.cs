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
            throw new NotImplementedException();
        }

        internal override string getIdPropertyName()
        {
            throw new NotImplementedException();
        }

        internal override PrimaryKeyType getPrimaryKeyType()
        {
            throw new NotImplementedException();
        }

        internal override string getTableName()
        {
            throw new NotImplementedException();
        }

        internal override void map()
        {
            throw new NotImplementedException();
        }
    }
}