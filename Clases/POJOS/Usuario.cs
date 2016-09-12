using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases
{
    public class Usuario
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
    }
}
