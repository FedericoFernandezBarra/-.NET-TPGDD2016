using ClinicaFrba.Clases.Otros;
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

        public TipoAgenda tipoAgenda { get; set; }
        
        public Agenda(long idAge, long idProf, DateTime fecha_ini, DateTime fecha_fin, List<DiaAgenda> listaDias, TipoAgenda tA)
        {
            idAgenda = idAge;
            idProfesional = idProf;
            fecha_inicial = fecha_ini;
            fecha_final = fecha_fin;
            listaDeDiasAgenda = listaDias;
            tipoAgenda = tA;
        }
        
        public bool esteHorarioEstaOcupado(string dia, TimeSpan horario)
        {
            return listaDeDiasAgenda.Exists(diaAgenda => (diaAgenda.horaInicial <= horario && horario <= diaAgenda.horaFinal) && diaAgenda.nombreDia == dia);
        }

        public double horasTrabajadasEnLaSemana()
        {
            double horasTrabajadas = 0;

            foreach (DiaAgenda dia in listaDeDiasAgenda)
            {
                horasTrabajadas += dia.horasTrabajadasEnElDia().Hours;

                if (dia.horasTrabajadasEnElDia().Minutes != 0) horasTrabajadas += 0.5;
            }
            return horasTrabajadas;
        }

        public List<DiaAgenda> diasAgendaDelDia(string nombreDia)
        {
            return listaDeDiasAgenda.FindAll(x => x.nombreDia == nombreDia);
        }
    }
}
