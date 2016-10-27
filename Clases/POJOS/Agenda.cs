using ClinicaFrba.Clases.DAOS;
using System;
using System.Collections.Generic;

namespace ClinicaFrba.Clases.POJOS
{
    class Agenda
    {
        public long idAgenda { get; set; }

        public long idProfesional { get; set; }

        public DateTime fecha_inicial { get; set; }

        public DateTime fecha_final { get; set; }

        public List<DiaAgenda> listaDeDiasAgenda { get; set; }


        public Agenda(long idAge, long idProf, DateTime fecha_ini, DateTime fecha_fin, List<DiaAgenda> listaDias)
        {
            idAgenda = idAge;
            idProfesional = idProf;
            fecha_inicial = fecha_ini;
            fecha_final = fecha_fin;
            listaDeDiasAgenda = listaDias;
        }
        
        public List<DiaAgenda> diasAgendaDelDia(string dia)
        {
            return listaDeDiasAgenda.FindAll(diaAgenda => diaAgenda.nombreDia == dia);
        }

        public bool esteHorarioEstaOcupado(string dia, TimeSpan horario)
        {
            return listaDeDiasAgenda.Exists(diaAgenda => (diaAgenda.horaInicial <= horario && horario <= diaAgenda.horaFinal) && diaAgenda.nombreDia == dia);
        }
    }
}
