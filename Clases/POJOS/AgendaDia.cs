using System;

namespace ClinicaFrba.Clases.POJOS
{
    class AgendaDia
    {
        public string nombreDia { get; set; }

        public long idEspecialidad { get; set; }

        public string nombreEspecialidad {get; set;}

        public TimeSpan horaInicial { get; set; }

        public TimeSpan horaFinal { get; set; }
    }

}
