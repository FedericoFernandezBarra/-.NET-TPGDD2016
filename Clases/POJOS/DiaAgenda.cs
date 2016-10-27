using System;

namespace ClinicaFrba.Clases.POJOS
{
    class DiaAgenda
    {
        public string nombreDia { get; set; }

        public long idEspecialidad { get; set; }

        public string nombreEspecialidad {get; set;}

        public TimeSpan horaInicial { get; set; }

        public TimeSpan horaFinal { get; set; }

        public DiaAgenda(string nomDia, long idEsp, string nomEsp, TimeSpan hIni, TimeSpan hFin)
        {
            nombreDia = nomDia;
            nombreEspecialidad = nomEsp;
            idEspecialidad = idEsp;
            horaInicial = hIni;
            horaFinal = hFin;
        }
    }

}
