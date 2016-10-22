drop database gdd
go
create database gdd
go
use gdd
go

if EXISTS (SELECT * FROM sys.schemas  WHERE name='BEMVINDO') 
drop schema BEMVINDO 

go
create schema BEMVINDO

go





create table BEMVINDO.TIPO_DOCUMENTO
(
    id_tipo_documento  numeric(10,0) identity (1,1) ,
    descripcion     nvarchar(255),

    PRIMARY KEY(id_tipo_documento)
)

go

create table BEMVINDO.USUARIO
(
    id_usuario  numeric(10,0) identity(1,1),
    nick    nvarchar(255) ,
    pass    nvarchar(255),
    intentos_login   smallint,
    activo  bit,
    nombre  nvarchar(255),
    apellido    nvarchar(255),
    tipo_documento  numeric(10,0),  
    documento   nvarchar(12),
    fecha_nacimiento    date,
    direccion   nvarchar(255),
    telefono    nvarchar(255),
    mail    nvarchar(255),
    sexo    char check (sexo in('F','M')),

    PRIMARY KEY(id_usuario),
    FOREIGN KEY (tipo_documento)   references BEMVINDO.TIPO_DOCUMENTO(id_tipo_documento)
)

go

create table BEMVINDO.ROL
(
    id_rol  numeric(10,0) identity(1,1) ,
    descripcion nvarchar(30),
    activo  bit,

    PRIMARY KEY (id_rol)
) 

go 

create table BEMVINDO.ROL_POR_USUARIO
(
    id_rol  numeric(10,0) ,
    id_usuario  numeric(10,0) ,


    PRIMARY KEY (id_usuario, id_rol), 
    FOREIGN KEY (id_usuario) references BEMVINDO.USUARIO(id_usuario), 
    FOREIGN KEY (id_rol)     references BEMVINDO.ROL(id_rol) 
)

go

create table BEMVINDO.FUNCIONALIDAD
(
    id_funcionalidad  numeric(10,0) identity(1,1),
    descripcion       nvarchar(255),
    activo  bit,

    PRIMARY KEY (id_funcionalidad)
)

go

create table BEMVINDO.FUNCIONALIDAD_POR_ROL
(
    id_funcionalidad    numeric(10,0),
    id_rol              numeric(10,0),


    PRIMARY KEY (id_funcionalidad, id_rol), 
    FOREIGN KEY (id_funcionalidad)           references BEMVINDO.FUNCIONALIDAD(id_funcionalidad), 
    FOREIGN KEY (id_rol)                     references BEMVINDO.ROL(id_rol)
)

go

create table BEMVINDO.ESTADO_CIVIL
(
    id_estado_civil  numeric(10,0) identity(1,1),
    descripcion      nvarchar(30),

    PRIMARY KEY (id_estado_civil)
)

go

create table BEMVINDO.PLAN_MEDICO
(
    id_plan_medico          numeric(10,0) identity(1,1) ,
    descripcion             nvarchar(255),
    precio_bono    numeric(10,2),
    

    PRIMARY KEY (id_plan_medico)
)

go

create table BEMVINDO.PROFESIONAL
(
    id_profesional  numeric(10,0)  ,
    matricula       nvarchar(30), --unique


    PRIMARY KEY (id_profesional),
    FOREIGN KEY (id_profesional)   references BEMVINDO.USUARIO(id_usuario)
)

go

create table BEMVINDO.AFILIADO
(
    id_afiliado numeric(10,0),
    estado_civil numeric(10,0),
    plan_medico numeric(10,0),
    fecha_baja   date,
    baja_logica  bit,
    cantidad_hijos smallint,

    PRIMARY KEY (id_afiliado),
    FOREIGN KEY (id_afiliado)             references BEMVINDO.USUARIO(id_usuario),
    FOREIGN KEY (estado_civil)            references BEMVINDO.ESTADO_CIVIL(id_estado_civil),
    FOREIGN KEY (plan_medico)             references BEMVINDO.PLAN_MEDICO(id_plan_medico)
)

go

create table BEMVINDO.HISTORIAL_CAMBIOS_DE_PLAN
(
    id_historial  numeric(10,0) identity(1,1),
    plan_medico  numeric(10,0) ,
    afiliado numeric(10,0) ,
    motivo  nvarchar(255),
    fecha   datetime,

    PRIMARY KEY (id_historial), 
    FOREIGN KEY (plan_medico)                  references BEMVINDO.PLAN_MEDICO(id_plan_medico),
    FOREIGN KEY (afiliado)                     references BEMVINDO.AFILIADO(id_afiliado)
)

go

create table BEMVINDO.TIPO_ESPECIALIDAD
(
    id_tipo_especialidad  numeric(10,0) identity(1,1) ,
    descripcion           nvarchar(255),

    PRIMARY KEY (id_tipo_especialidad)
)

go

create table BEMVINDO.ESPECIALIDAD
(
    id_especialidad    numeric(10,0) identity(1,1) ,
    tipo_especialidad  numeric(10,0),
    descripcion        nvarchar(255),

    PRIMARY KEY (id_especialidad),
    FOREIGN KEY (tipo_especialidad)    references BEMVINDO.TIPO_ESPECIALIDAD(id_tipo_especialidad)
)

go

create table BEMVINDO.ESPECIALIDAD_POR_PROFESIONAL
(
    id_especialidad numeric(10,0) ,
    id_profesional     numeric(10,0) ,

    PRIMARY KEY (id_especialidad, id_profesional), 
    FOREIGN KEY (id_especialidad)                references BEMVINDO.ESPECIALIDAD(id_especialidad), 
    FOREIGN KEY (id_profesional)                 references BEMVINDO.PROFESIONAL(id_profesional)
)

go

 create table BEMVINDO.AGENDA
  (
      id_agenda    numeric(10,0)   identity(1,1) ,
      profesional     numeric(10,0),
      fecha_desde  date,
      fecha_hasta  date,
  
      PRIMARY KEY (id_agenda),
      FOREIGN KEY (profesional)             references BEMVINDO.PROFESIONAL(id_profesional)
  
  )
  
  go
  
  create table BEMVINDO.DIA_AGENDA
  (
      id_dia_agenda numeric(10,0) identity(1,1),
      agenda        numeric(10,0),
      especialidad  numeric(10,0),
      dia           nvarchar(10) check (dia in('LUNES','MARTES', 'MIERCOLES','JUEVES', 'VIERNES', 'SABADO')),
      hora_desde    time,
      hora_hasta    time,
  
      PRIMARY KEY (id_dia_agenda),
      FOREIGN KEY (agenda)             references BEMVINDO.AGENDA(id_agenda),
      FOREIGN KEY (especialidad)       references BEMVINDO.ESPECIALIDAD(id_especialidad)
  
  )
  
  go
  
  create table BEMVINDO.CANCELACION_DIA
  (
      id_cancelacion_dia      numeric(10,0) identity(1,1),
      agenda                  numeric(10,0) ,
      dia                     date,
  
      
      PRIMARY KEY (id_cancelacion_dia),
      FOREIGN KEY (agenda)             references BEMVINDO.AGENDA(id_agenda)
  )
  

go

create table BEMVINDO.TURNO
(
    id_turno          numeric(10,0) identity(1,1) ,
    afiliado          numeric(10,0) ,
    profesional       numeric(10,0) ,
    especialidad      numeric(10,0) ,
    fecha_turno       datetime,
    fecha_llegada     datetime,
    activo            bit,


    PRIMARY KEY (id_turno), 
    FOREIGN KEY (afiliado)                    references BEMVINDO.AFILIADO(id_afiliado), 
    FOREIGN KEY (profesional)                 references BEMVINDO.PROFESIONAL(id_profesional),
    FOREIGN KEY (especialidad)                references BEMVINDO.ESPECIALIDAD(id_especialidad),
    
)

go

create table BEMVINDO.CONSULTA
(
    id_consulta            numeric(10,0) identity(1,1),
    turno                  numeric(10,0),
    sintoma                nvarchar(255),
    enfermedad             nvarchar(255),
    fecha_diagnostico      datetime,

    PRIMARY KEY (id_consulta), 
    FOREIGN KEY (turno)                    references BEMVINDO.TURNO(id_turno)
)

go

create table BEMVINDO.TIPO_CANCELACION
(
    id_tipo_cancelacion      numeric(10,0) identity(1,1) ,
    descripcion              nvarchar(255),

    PRIMARY KEY (id_tipo_cancelacion)
)

go

create table BEMVINDO.CANCELACION
(
    id_cancelacion       numeric(10,0) identity(1,1) ,
    tipo_cancelacion     numeric(10,0),
    turno                numeric(10,0) ,
    fecha                date,
    motivo               nvarchar(255),
    tipo_usuario         char,
    

    PRIMARY KEY (id_cancelacion), 
    FOREIGN KEY (tipo_cancelacion)         references BEMVINDO.TIPO_CANCELACION(id_tipo_cancelacion), 
    FOREIGN KEY (turno)                    references BEMVINDO.TURNO(id_turno)
)

go

create table BEMVINDO.COMPRA
(
    id_compra  numeric(10,0) identity(1,1),
    comprador  numeric(10,0) ,
    cantidad numeric(3,0) ,
    monto  numeric(5,2),
    fecha_compra      datetime,

    PRIMARY KEY (id_compra), 
    FOREIGN KEY (comprador)                    references BEMVINDO.AFILIADO(id_afiliado)
)

go

create table BEMVINDO.BONO
(
    id_bono  numeric(10,0) identity(1,1),
    plan_medico  numeric(10,0) ,
    compra numeric(10,0) ,
    turno  numeric(10,0),

    PRIMARY KEY (id_bono), 
    FOREIGN KEY (plan_medico)             references BEMVINDO.PLAN_MEDICO(id_plan_medico),
    FOREIGN KEY (compra)                  references BEMVINDO.COMPRA(id_compra),
    FOREIGN KEY (turno)                   references BEMVINDO.TURNO(id_turno)
)

go
