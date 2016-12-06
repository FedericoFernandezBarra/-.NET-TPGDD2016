using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.CONSULTA")]
    class ResultadoAtencionMedica:Serializable
    {
        [Id(name = "id_consulta", type = PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "turno", fetch = FetchType.EAGER)]
        public Turno turno { get; set; }

        [Column(name = "sintoma")]
        public String sintomas { get; set; }

        [Column(name = "enfermedad")]
        public String diagnostico { get; set; }

        [Column(name = "fecha_diagnostico")]
        public DateTime fechaDeDiagnostico { get; set; }

        public String nombreAfiliadoCompleto { get { return turno.afiliado.usuario.nombreCompleto; } }

        public ResultadoAtencionMedica()
        {
            turno = new Turno();
        }
    }
}