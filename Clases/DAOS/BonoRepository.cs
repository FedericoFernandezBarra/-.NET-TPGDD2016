using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    public class BonoRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Bono);
        }

        internal Bono traerPorId(long numeroBono)
        {
            return (Bono)selectById(numeroBono);
        }
    }
}
