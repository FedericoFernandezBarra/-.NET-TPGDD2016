﻿using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    public class FuncionalidadRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(Funcionalidad);
        }

        internal List<Funcionalidad> traerFuncionalidades()
        {
            return (List<Funcionalidad>)selectAll();
        }
    }
}
