using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class ProfesionalRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Profesional);
        }

        internal List<Profesional> buscarProfesionales(long nroMatricula, string nombre, string apellido, Especialidad especialidad)
        {
            throw new NotImplementedException();
        }
    }
}
