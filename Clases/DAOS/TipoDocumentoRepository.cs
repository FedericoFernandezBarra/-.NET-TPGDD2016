﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.DAOS
{
    class TipoDocumentoRepository : Repository
    {
        internal override Type getModelClassType()
        {
            return typeof(TipoDocumento);
        }

        internal List<TipoDocumento> traerTiposDocumento()
        {
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>();

            selectAll().ForEach(o => tiposDocumento.Add((TipoDocumento)o));

            return tiposDocumento;
        }
    }
}
