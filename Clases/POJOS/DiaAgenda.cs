using System;

namespace ClinicaFrba.Clases.POJOS
{
    class DiaAgenda
    {
        public string nombreDia { get; set; }

        public string nombreEspecialidad {get; set;}

        public TimeSpan horaInicial { get; set; }

        public TimeSpan horaFinal { get; set; }

        public DiaAgenda(string nomDia, string nomEsp, TimeSpan hIni, TimeSpan hFin)
        {
            nombreDia = nomDia;
            nombreEspecialidad = nomEsp;
            horaInicial = hIni;
            horaFinal = hFin;
        }
    }

}
