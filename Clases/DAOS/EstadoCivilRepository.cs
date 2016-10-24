using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class EstadoCivilRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(EstadoCivil);
        }

        internal List<EstadoCivil> traerEstadosCiviles()
        {
            return (List<EstadoCivil>)selectAll();
        }
    }
}
