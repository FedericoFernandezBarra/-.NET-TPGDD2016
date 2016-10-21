using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class EspecialidadRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Especialidad);
        }

        public List<Especialidad> traerEspecialidades()
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            selectAll().ForEach(o => especialidades.Add((Especialidad)o));

            return especialidades;
        }
    }
}
