using ClinicaFrba.Clases.POJOS;
using System;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class AgendaRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Agenda);
        }

        public Agenda traerAgendaDelProfesional(Usuario usuario)
        {
            return null;
        }
    }
}
