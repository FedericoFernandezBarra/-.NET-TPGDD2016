using ClinicaFrba.Clases.POJOS;
using System;
using System.Collections.Generic;
using TostadoPersistentKit;

namespace ClinicaFrba.Clases
{
    [Table(name = "BEMVINDO.USUARIO")]
    public class Usuario:Serializable
    {
        [Id(name = "id_usuario",type =PrimaryKeyType.NATURAL)]
        public long id { get; set; }

        [Column(name = "nick")]
        public string nick { get; set; }

        [Column(name = "pass")]
        public string pass { get; set; }

        [Column(name = "intentos_login")]
        public int intentosDeLogin { get; set; }

        [Column(name = "activo")]
        public bool activo { get; set; }

        [Column(name = "nombre")]
        public string nombre { get; set; }

        [Column(name = "apellido")]
        public string apellido { get; set; }

        [Column(name = "tipo_documento",fetch =FetchType.EAGER)]
        public TipoDocumento tipoDeDocumento { get; set; }

        [Column(name = "documento")]
        public string documento { get; set; }

        [Column(name = "fecha_nacimiento")]
        public DateTime fechaDeNacimiento { get; set; }

        [Column(name = "direccion")]
        public string direccion { get; set; }

        [Column(name = "telefono")]
        public string telefono { get; set; }

        [Column(name = "mail")]
        public string mail { get; set; }

        [Column(name = "sexo")]
        public char sexo { get; set; }

        [OneToMany(pkName = "id_usuario",tableName = "BEMVINDO.ROL_POR_USUARIO",fkName = "id_rol",fetch =FetchType.LAZY)]
        public List<Rol> roles { get; set; }

        public String nombreCompleto { get { return apellido + " " + nombre; } }

        public Usuario()
        {
            fechaDeNacimiento = DataBase.Instance.getDate().AddDays(-1);//nacio ayer :P
        }
    }
}
