﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TostadoPersistentKit;
using UsingTostadoPersistentKit.TostadoPersistentKit;

namespace ClinicaFrba.Clases.POJOS
{
    [Table(name = "BEMVINDO.ROL")]
    public class Rol:Serializable
    {
        [Id(name = "id_rol",type =PrimaryKeyType.SURROGATE)]
        public long id { get; set; }

        [Column(name = "nombre")]
        public string nombre { get; set; }

        [OneToMany(pkName ="id_rol",tableName = "BEMVINDO.FUNCIONALIDAD_POR_ROL",fkName ="id_funcionalidad",fetch =FetchType.EAGER)]
        public List<Funcionalidad> funcionalidades { get; set; }

        [Column(name = "habilitado")]
        public bool habilitado { get; set; }

        public Rol()
        {
            nombre = "";
            funcionalidades = new List<Funcionalidad>();
            habilitado = true;
        }
    }
}