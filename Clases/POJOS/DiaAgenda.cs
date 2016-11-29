using ClinicaFrba.Clases.Otros;
using System;

namespace ClinicaFrba.Clases.POJOS
{
    class DiaAgenda
    {
        public long idDiaAgenda { get; set; }

        public string nombreDia { get; set; }

        public long idEspecialidad { get; set; }

        public string nombreEspecialidad {get; set;}

        public TimeSpan horaInicial { get; set; }

        public TimeSpan horaFinal { get; set; }

        public TipoDiaAgenda tipoDiaAgenda { get; set; }

        public DiaAgenda(long id, string nomDia, long idEsp, string nomEsp, TimeSpan hIni, TimeSpan hFin, TipoDiaAgenda t)
        {
            idDiaAgenda = id;
            nombreDia = nomDia;
            nombreEspecialidad = nomEsp;
            idEspecialidad = idEsp;
            horaInicial = hIni;
            horaFinal = hFin;
            tipoDiaAgenda = t;
        }

        public TimeSpan horasTrabajadasEnElDia()
        {
            return horaFinal.Subtract(horaInicial);
        }
    }

}
