using System;
using System.Collections.Generic;

namespace ClinicaFrba.Clases.POJOS
{
    class DiaAgenda
    {
        public long idDiaAgenda { get; set; }

        public string nombreDia { get; set; }

        public Dictionary<string, long> especialidades { get; set; }
        
        public TimeSpan horaInicial { get; set; }

        public TimeSpan horaFinal { get; set; }

        public DiaAgenda(long id, string nomDia, Dictionary<string, long> esp, TimeSpan hIni, TimeSpan hFin)
        {
            idDiaAgenda = id;
            nombreDia = nomDia;
            especialidades = esp;
            horaInicial = hIni;
            horaFinal = hFin;
        }

        public TimeSpan horasTrabajadasEnElDia()
        {
            return horaFinal.Subtract(horaInicial);
        }
    }

}
