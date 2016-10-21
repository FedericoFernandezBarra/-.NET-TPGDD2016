using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases.Otros
{
    public class RegistrarLlegada
    {
        public Profesional profesional { get; set; }
        public List<Turno> turnosDeProfesional { get; set; }
        public Turno turnoDeAfiliado { get; set; }

        public RegistrarLlegada()
        {
            profesional = new Profesional();
        }
    }
}
