using System.Collections.Generic;

namespace ClinicaFrba.Clases.POJOS
{
    class Agenda
    {
        public long idAgenda { get; set; }

        public long idProfesional { get; set; }

        public List<AgendaDia> listaDeDiasAgenda { get; set; }


        public List<string> obtenerNombresDeDiasAgenda()
        {
            List<string> nombres = new List<string>();

            foreach (var diaAgenda in listaDeDiasAgenda)
            {
                nombres.Add(diaAgenda.nombreDia);
            }

            return nombres;
        }
    }
}
