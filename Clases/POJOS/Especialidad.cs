﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.ESPECIALIDAD")]
    public class Especialidad:Serializable
    {
        [Id(name = "id_especialidad",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "tipo_especialidad",fetch =FetchType.EAGER)]
        public TipoEspecialidad tipoDeEspecialidad { get; set; }

        [Column(name = "descripcion")]
        public string descripcion { get; set; }
    }
}
