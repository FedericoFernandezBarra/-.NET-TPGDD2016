create table XXX.TIPO_DOCUMENTO
(
    id_tipo_documento  numeric(10,0) identity (1,1) ,
    descripcion     nvarchar(255),

    PRIMARY KEY(id_tipo_documento)
)

go

create table XXX.USUARIO
(
    id_usuario  numeric(10,0) ,
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
    FOREIGN KEY (tipo_documento)   references XXX.TIPO_DOCUMENTO(id_tipo_documento)
)

go

create table XXX.ROL
(
    id_rol  numeric(10,0) identity(1,1) ,
    descripcion nvarchar(30),
    activo  bit,

    PRIMARY KEY (id_rol)
) 

go 

create table XXX.ROL_POR_USUARIO
(
    id_rol  numeric(10,0) ,
    id_usuario  numeric(10,0) ,


    PRIMARY KEY (id_usuario, id_rol), 
    FOREIGN KEY (id_usuario) references XXX.USUARIO(id_usuario), 
    FOREIGN KEY (id_rol)     references XXX.ROL(id_rol) 
)

go

create table XXX.FUNCIONALIDAD
(
    id_funcionalidad  numeric(10,0) identity(1,1),
    descripcion       nvarchar(30),
    activo  bit,

    PRIMARY KEY (id_funcionalidad)
)

go

create table XXX.FUNCIONALIDAD_POR_ROL
(
    id_funcionalidad    numeric(10,0),
    id_rol              numeric(10,0),


    PRIMARY KEY (id_funcionalidad, id_rol), 
    FOREIGN KEY (id_funcionalidad)           references XXX.FUNCIONALIDAD(id_funcionalidad), 
    FOREIGN KEY (id_rol)                     references XXX.ROL(id_rol)
)

go

create table XXX.ESTADO_CIVIL
(
    id_estado_civil  numeric(10,0) identity(1,1),
    descripcion      nvarchar(30),

    PRIMARY KEY (id_estado_civil)
)

go

create table XXX.PLAN_MEDICO
(
    id_plan_medico          numeric(10,0) identity(1,1) ,
    descripcion             nvarchar(255),
    precio_bono    numeric(10,2),
    

    PRIMARY KEY (id_plan_medico)
)

go

create table XXX.PROFESIONAL
(
    id_profesional  numeric(10,0)  ,
    matricula       nvarchar(30), --unique


    PRIMARY KEY (id_profesional),
    FOREIGN KEY (id_profesional)   references XXX.USUARIO(id_usuario)

)

go


create table XXX.AFILIADO
(
    id_afiliado numeric(10,0),
    nro_grupo_familiar char(4),
    estado_civil numeric(10,0),
    plan_medico numeric(10,0),
    cantidad_hijos smallint,
    fecha_baja   date,
    baja_logica  bit,

    PRIMARY KEY (id_afiliado),
    FOREIGN KEY (id_afiliado)             references XXX.USUARIO(id_usuario),
    FOREIGN KEY (estado_civil)            references XXX.ESTADO_CIVIL(id_estado_civil),
    FOREIGN KEY (plan_medico)             references XXX.PLAN_MEDICO(id_plan_medico)
)

go


create table XXX.HISTORIAL_CAMBIOS_DE_PLAN
(
    id_historial  numeric(10,0) identity(1,1),
    plan_medico  numeric(10,0) ,
    afiliado numeric(10,0) ,
    motivo  nvarchar(255),
    fecha   datetime,

    PRIMARY KEY (id_historial), 
    FOREIGN KEY (plan_medico)                  references XXX.PLAN_MEDICO(id_plan_medico),
    FOREIGN KEY (afiliado)                     references XXX.AFILIADO(id_afiliado)
)

go


create table XXX.TIPO_ESPECIALIDAD
(
    id_tipo_especialidad  numeric(10,0) identity(1,1) ,
    descripcion           nvarchar(255),

    PRIMARY KEY (id_tipo_especialidad)
)

go

create table XXX.ESPECIALIDAD
(
    id_especialidad    numeric(10,0) identity(1,1) ,
    tipo_especialidad  numeric(10,0),
    descripcion        nvarchar(255),

    PRIMARY KEY (id_especialidad),
    FOREIGN KEY (tipo_especialidad)    references XXX.TIPO_ESPECIALIDAD(id_tipo_especialidad)
)

go

create table XXX.ESPECIALIDAD_POR_PROFESIONAL
(
    id_especialidad numeric(10,0) ,
    id_profesional     numeric(10,0) ,

    PRIMARY KEY (id_especialidad, id_profesional), 
    FOREIGN KEY (id_especialidad)                references XXX.ESPECIALIDAD(id_especialidad), 
    FOREIGN KEY (id_profesional)                 references XXX.PROFESIONAL(id_profesional)
)

go

create table XXX.TURNO
(
    id_turno          numeric(10,0) identity(1,1) ,
    afiliado          numeric(10,0) ,
    profesional       numeric(10,0) ,
    especialidad      numeric(10,0) ,
    fecha_turno       datetime,
    fecha_llegada     datetime,
    activo            bit, -- 0 si fue cancelado, 1 si esta disponible


    PRIMARY KEY (id_turno), 
    FOREIGN KEY (afiliado)                    references XXX.AFILIADO(id_afiliado), 
    FOREIGN KEY (profesional)                 references XXX.PROFESIONAL(id_profesional),
    FOREIGN KEY (especialidad)                references XXX.ESPECIALIDAD(id_especialidad),
    
)

go

create table XXX.CONSULTA
(
    id_consulta            numeric(10,0) identity(1,1),
    turno                  numeric(10,0),
    sintoma                nvarchar(255),
    enfermedad             nvarchar(255),
    fecha_diagnostico      datetime,

    PRIMARY KEY (id_consulta), 
    FOREIGN KEY (turno)                    references XXX.TURNO(id_turno)
)

go

create table XXX.TIPO_CANCELACION
(
    id_tipo_cancelacion      numeric(10,0) identity(1,1) ,
    descripcion              nvarchar(255),

    PRIMARY KEY (id_tipo_cancelacion)
)

go

create table XXX.CANCELACION
(
    id_cancelacion       numeric(10,0) identity(1,1) ,
    tipo_cancelacion     numeric(10,0),
    turno                numeric(10,0) ,
    fecha                date,
    motivo               nvarchar(255),
    tipo_usuario         char,
    

    PRIMARY KEY (id_cancelacion), 
    FOREIGN KEY (tipo_cancelacion)         references XXX.TIPO_CANCELACION(id_tipo_cancelacion), 
    FOREIGN KEY (turno)                    references XXX.TURNO(id_turno)
)

go


create table XXX.COMPRA
(
    id_compra  numeric(10,0) identity(1,1),
    comprador  numeric(10,0) ,
    cantidad   numeric(3,0) ,
    monto      numeric(5,2),
    fecha_compra      datetime,

    PRIMARY KEY (id_compra), 
    FOREIGN KEY (comprador)                    references XXX.AFILIADO(id_afiliado)
)

go


create table XXX.BONO
(
    id_bono      numeric(10,0) identity(1,1),
    plan_medico  numeric(10,0) ,
    compra       numeric(10,0) ,
    turno        numeric(10,0),

    PRIMARY KEY (id_bono), 
    FOREIGN KEY (plan_medico)             references XXX.PLAN_MEDICO(id_plan_medico),
    FOREIGN KEY (compra)                  references XXX.COMPRA(id_compra),
    FOREIGN KEY (turno)                   references XXX.TURNO(id_turno)
)

go
