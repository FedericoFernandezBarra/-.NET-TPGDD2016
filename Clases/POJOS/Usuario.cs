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

        public Usuario()
        {
            fechaDeNacimiento = Sistema.Instance.getDate();
        }

        internal override void map()
        {
            mappings.Add("id", "id_usuario");
            mappings.Add("nick", "nick");
            mappings.Add("pass","pass");
            mappings.Add("intentosDeLogin", "intentos_login");
            mappings.Add("activo", "activo");
            mappings.Add("nombre", "nombre");
            mappings.Add("apellido", "apellido");
            mappings.Add("tipoDeDocumento", "tipo_documento");
            mappings.Add("documento", "documento");
            mappings.Add("fechaDeNacimiento", "fecha_nacimiento");
            mappings.Add("direccion", "direccion");
            mappings.Add("telefono", "telefono");
            mappings.Add("mail", "mail");
            mappings.Add("sexo", "sexo");
        }

        internal override string getIdPropertyName()
        {
            return "id";
        }

        internal override string getTableName()
        {
            return "usuario";
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
