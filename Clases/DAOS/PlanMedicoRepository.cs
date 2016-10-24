using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class PlanMedicoRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(PlanMedico);
        }

        internal List<PlanMedico> traerPlanesMedicos()
        {
            return (List<PlanMedico>)selectAll();
        }
    }
}
