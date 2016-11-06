using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name ="BEMVINDO.COMPRA")]
    public class Compra:Serializable
    {
        [Id(name = "id_compra",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "comprador",fetch =FetchType.LAZY)]
        public Afiliado comprador { get; set; }

        [Column(name = "cantidad")]
        public int cantidad { get; set; }

        [Column(name = "monto")]
        public double monto { get; set; }

        [Column(name = "fecha_compra")]
        public DateTime fecha { get; set; }
    }
}
