USE GD2C2016

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE TABLAS ANTSES DE CREARLAS*/
/********************************************************************************************************************************/
if EXISTS (SELECT * FROM sysobjects  WHERE name='CANCELACION') 
drop table BEMVINDO.CANCELACION 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD_POR_PERSONAL') 
drop table BEMVINDO.ESPECIALIDAD_POR_PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD') 
drop table BEMVINDO.ESPECIALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='FUNCIONALIDAD_POR_ROL') 
drop table BEMVINDO.FUNCIONALIDAD_POR_ROL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='FUNCIONALIDAD') 
drop table BEMVINDO.FUNCIONALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='HISTORIAL_CAMBIOS_DE_PLAN') 
drop table BEMVINDO.HISTORIAL_CAMBIOS_DE_PLAN 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ROL_POR_USUARIO') 
drop table BEMVINDO.ROL_POR_USUARIO 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='ROL') 
drop table BEMVINDO.ROL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_CANCELACION') 
drop table BEMVINDO.TIPO_CANCELACION 

go


if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_ESPECIALIDAD') 
drop table BEMVINDO.TIPO_ESPECIALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='DIA_AGENDA') 
drop table BEMVINDO.DIA_AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='DIA_AGENDA_EXCEPCION') 
drop table BEMVINDO.DIA_AGENDA_EXCEPCION 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='AGENDA') 
drop table BEMVINDO.AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='CONSULTA') 
drop table BEMVINDO.CONSULTA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TURNO') 
drop table BEMVINDO.TURNO 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='AFILIADO') 
drop table BEMVINDO.AFILIADO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PLAN_MEDICO') 
drop table BEMVINDO.PLAN_MEDICO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESTADO_CIVIL') 
drop table BEMVINDO.ESTADO_CIVIL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PERSONAL') 
drop table BEMVINDO.PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='USUARIO') 
drop table BEMVINDO.USUARIO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_DOCUMENTO') 
drop table BEMVINDO.TIPO_DOCUMENTO 

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE OBJETOS ANTSES DE CREARLOS*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sysobjects WHERE name='fn_hashear_pass') 
drop function BEMVINDO.fn_hashear_pass

go

if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass_insert') 
drop trigger BEMVINDO.tg_hashear_pass_insert

go

if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass_update') 
drop trigger BEMVINDO.tg_hashear_pass_update

go


/********************************************************************************************************************************/
/*CREO ESQUEMA*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sys.schemas  WHERE name='BEMVINDO') 
drop schema BEMVINDO 

go

create schema BEMVINDO authorization gd

go

/********************************************************************************************************************************/
/*CREACION DE TABLAS*/
/********************************************************************************************************************************/

create table BEMVINDO.TIPO_DOCUMENTO
(
    id_tipo_documento  numeric(10,0) identity (1,1) ,
    descripcion     nvarchar(255),

    PRIMARY KEY(id_tipo_documento)
)

go

create table BEMVINDO.USUARIO
(
    id_usuario  numeric(10,0) identity(1,1) ,
    nick    nvarchar(255) unique,
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
    descripcion     nvarchar(30),
    activo  bit,

    PRIMARY KEY (id_funcionalidad)
)

go

create table BEMVINDO.FUNCIONALIDAD_POR_ROL
(
    id_funcionalidad    numeric(10,0),
    id_rol  numeric(10,0),


    PRIMARY KEY (id_funcionalidad, id_rol), 
    FOREIGN KEY (id_funcionalidad)           references BEMVINDO.FUNCIONALIDAD(id_funcionalidad), 
    FOREIGN KEY (id_rol)                     references BEMVINDO.ROL(id_rol)
)

go

create table BEMVINDO.ESTADO_CIVIL
(
    id_estado_civil  numeric(10,0) identity(1,1),
    descripcion nvarchar(30),

    PRIMARY KEY (id_estado_civil)
)

go

create table BEMVINDO.PLAN_MEDICO
(
    id_plan_medico   numeric(10,0) identity(1,1) ,
    descripcion      nvarchar(255),
	precio_bono_consulta    numeric(18,2),
    activo           bit,

    PRIMARY KEY (id_plan_medico)
)

go

create table BEMVINDO.PERSONAL
(
    id_personal  numeric(10,0) references BEMVINDO.USUARIO(id_usuario) ,
    matricula   nvarchar(30), --unique

    PRIMARY KEY (id_personal)
)

go

create table BEMVINDO.AFILIADO
(
    id_afiliado numeric(10,0),
    nro_afiliado numeric(10,0),
    nro_grupo_familiar numeric(10,0),
    estado_civil numeric(10,0),
	plan_medico numeric(10,0),
    numero_familiar numeric(10,0),
    cantidad_hijos smallint,

    PRIMARY KEY (id_afiliado),
    FOREIGN KEY (id_afiliado)             references BEMVINDO.USUARIO(id_usuario),
    FOREIGN KEY (estado_civil)            references BEMVINDO.ESTADO_CIVIL(id_estado_civil),
	FOREIGN KEY (plan_medico)            references BEMVINDO.PLAN_MEDICO(id_plan_medico)
)

go

create table BEMVINDO.AGENDA
(
    id_agenda  numeric(10,0) identity(1,1) ,
    personal numeric(10,0),
    fecha_desde date,
    fecha_hasta date,

    PRIMARY KEY (id_agenda),
    FOREIGN KEY (personal)             references BEMVINDO.PERSONAL(id_personal)

)

go

create table BEMVINDO.DIA_AGENDA
(
    id_dia_agenda numeric(10,0) identity(1,1),
	agenda numeric(10,0),
    dia date,
    hora_desde  time,
    hora_hasta  time,
    activo  bit,

    PRIMARY KEY (id_dia_agenda),
	FOREIGN KEY (agenda)             references BEMVINDO.AGENDA(id_agenda)

)

go

create table BEMVINDO.DIA_AGENDA_EXCEPCION
(
    id_dia_agenda_exepcion  numeric(10,0) identity(1,1),
    agenda   numeric(10,0) ,
    dia date,

    
    PRIMARY KEY (id_dia_agenda_exepcion),
    FOREIGN KEY (agenda)             references BEMVINDO.AGENDA(id_agenda)
)

go

create table BEMVINDO.TIPO_ESPECIALIDAD
(
    id_tipo_especialidad  numeric(10,0) identity(1,1) ,
    descripcion nvarchar(255),

    PRIMARY KEY (id_tipo_especialidad)
)

go

create table BEMVINDO.ESPECIALIDAD
(
    id_especialidad  numeric(10,0) identity(1,1) ,
    tipo_especialidad numeric(10,0),
    descripcion nvarchar(255),

    PRIMARY KEY (id_especialidad),
    FOREIGN KEY (tipo_especialidad)                   references BEMVINDO.TIPO_ESPECIALIDAD(id_tipo_especialidad)
)

go

create table BEMVINDO.ESPECIALIDAD_POR_PERSONAL
(
    id_especialidad numeric(10,0) ,
    id_personal numeric(10,0) ,

    PRIMARY KEY (id_especialidad, id_personal), 
    FOREIGN KEY (id_especialidad)                references BEMVINDO.ESPECIALIDAD(id_especialidad), 
    FOREIGN KEY (id_personal)                    references BEMVINDO.PERSONAL(id_personal)
)

go

create table BEMVINDO.TURNO
(
    id_turno  numeric(10,0) identity(1,1) ,
    afiliado numeric(10,0) ,
    personal numeric(10,0) ,
    horario_turno       datetime,
    horario_llegada     datetime,
    activo      bit,


    PRIMARY KEY (id_turno), 
    FOREIGN KEY (afiliado)                    references BEMVINDO.AFILIADO(id_afiliado), 
    FOREIGN KEY (personal)                    references BEMVINDO.PERSONAL(id_personal)
)

go

create table BEMVINDO.CONSULTA
(
    id_resultado_turno     numeric(10,0) identity(1,1),
    turno                  numeric(10,0),
	sintoma                nvarchar(255),
    enfermedad            nvarchar(255),
    fecha_bono			datetime,
	fecha_compra_bono	datetime,
    activo                 bit,

    PRIMARY KEY (id_resultado_turno), 
    FOREIGN KEY (turno)                    references BEMVINDO.TURNO(id_turno), 
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
    id_cancelacion          numeric(10,0) identity(1,1) ,
    tipo_cancelacion     numeric(10,0),
    turno                numeric(10,0) ,
    fecha   date,
    motivo  nvarchar(255),
    usuario  numeric(10,0),
    activo  bit,


    PRIMARY KEY (id_cancelacion), 
    FOREIGN KEY (tipo_cancelacion)         references BEMVINDO.TIPO_CANCELACION(id_tipo_cancelacion), 
    FOREIGN KEY (turno)                    references BEMVINDO.TURNO(id_turno),
    FOREIGN KEY (usuario)                    references BEMVINDO.USUARIO(id_usuario)
)

go

create table BEMVINDO.HISTORIAL_CAMBIOS_DE_PLAN
(
    id_historial  numeric(10,0) identity(1,1),
    plan_medico  numeric(10,0) ,
    afiliado numeric(10,0) ,
	motivo	nvarchar(255),
    fecha   datetime,
    activo  bit,

    PRIMARY KEY (id_historial), 
    FOREIGN KEY (plan_medico)                  references BEMVINDO.PLAN_MEDICO(id_plan_medico),
    FOREIGN KEY (afiliado)                     references BEMVINDO.AFILIADO(id_afiliado)
)

go


/********************************************************************************************************************************/
/*FUNCION HASH Y TRIGGER PARA LA CONTRASEÑA*/
/********************************************************************************************************************************/
create function BEMVINDO.fn_hashear_pass (@pass nvarchar(255))
returns nvarchar(255)
as begin
    return(
        SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_256', @pass)), 3, 255)
    )
end

go

create trigger BEMVINDO.tg_hashear_pass_insert  
on BEMVINDO.USUARIO  
instead of insert  
as begin  
    
  insert into BEMVINDO.USUARIO  
    select  
      nick,  
      BEMVINDO.fn_hashear_pass(pass),  
      intentos_login,
      activo,
      nombre, 
      apellido,
      tipo_documento,
      documento,
      fecha_nacimiento,  
      direccion, 
      telefono,
      mail,  
      sexo
    from inserted   
end  
 
go  

create trigger BEMVINDO.tg_hashear_pass_update  
on BEMVINDO.USUARIO  
after update
as begin

declare @id_insertado numeric(18,0);  
 
  select @id_insertado = id_usuario 
  from inserted

  if(update(pass))
  begin
    update BEMVINDO.USUARIO  
    set pass = BEMVINDO.fn_hashear_pass(pass)  
    where id_usuario = @id_insertado 
  end
 
end
 
go  

/********************************************************************************************************************************/
/*MIGRACION*/
/********************************************************************************************************************************/

--TIPO DOCUMENTO
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.TIPO_DOCUMENTO
values ('DNI')

go

--ESTADO CIVIL
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.ESTADO_CIVIL
values 
	('SOLTERO/A'),
	('CASADO/A'),
	('VIUDO/A'),
	('CONCUBINATO'),
	('DIVORCIADO/A')

go

--PLAN MEDICO
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.PLAN_MEDICO
add plan_medico_codigo numeric(18,0)

go

insert into BEMVINDO.PLAN_MEDICO
	select distinct
		Plan_Med_Descripcion,
		Plan_Med_Precio_Bono_Consulta,
		1,
		Plan_Med_Codigo
	from gd_esquema.Maestra 

go

--USUARIOS
-------------------------------------------------------------------------------------------------------

--afiliados
insert into BEMVINDO.USUARIO
	select distinct
		Paciente_Dni,
		Paciente_Dni,
		0,
		0,
		Paciente_Nombre,
		UPPER(Paciente_Apellido),
		1,
		Paciente_Dni,
		Paciente_Fecha_Nac,
		UPPER(Paciente_Direccion),
		Paciente_Telefono,
		Paciente_Mail,
		null	--no tiene sexo la tabla maestra
	from gd_esquema.Maestra
	where 
		Consulta_Sintomas is null and
		Compra_Bono_Fecha is null

go

--personal
insert into BEMVINDO.USUARIO
	select distinct
		Medico_Dni,
		Medico_Dni,
		0,
		0,
		Medico_Nombre,
		UPPER(Medico_Apellido),
		1,
		Medico_Dni,
		Medico_Fecha_Nac,
		UPPER(Medico_Direccion),
		Medico_Telefono,
		Medico_Mail,
		null	--no tiene sexo la tabla maestra
	from gd_esquema.Maestra
	where 
		Consulta_Sintomas is null and
		Compra_Bono_Fecha is null

go

--AFILIADOS
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.AFILIADO
	select distinct
		U.id_usuario,
		null,
		P.id_plan_medico,
		null,
		null
	from gd_esquema.Maestra as M
	inner join BEMVINDO.USUARIO as U 
		on M.Paciente_Dni = U.documento
	inner join BEMVINDO.PLAN_MEDICO as P
		on M.Plan_Med_Codigo = P.plan_medico_codigo
	where 
		M.Consulta_Sintomas is null and
		M.Compra_Bono_Fecha is null

go

--PERSONAL
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.PERSONAL
	select distinct
		U.id_usuario,
		null
	from gd_esquema.Maestra as M
	inner join BEMVINDO.USUARIO as U 
		on M.Medico_Dni = U.documento
	where 
		M.Consulta_Sintomas is null and
		M.Compra_Bono_Fecha is null

go

--TIPO ESPECIALIDAD
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.TIPO_ESPECIALIDAD
add tipo_especialidad_codigo numeric(18,0)

go

insert into BEMVINDO.TIPO_ESPECIALIDAD
	select distinct
		UPPER(Tipo_Especialidad_Descripcion),
		Tipo_Especialidad_Codigo
	from gd_esquema.Maestra 
	where 
		Tipo_Especialidad_Codigo is not null

go

--ESPECIALIDAD
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.ESPECIALIDAD
add especialidad_codigo numeric(18,0)

go

insert into BEMVINDO.ESPECIALIDAD
	select distinct
		T.id_tipo_especialidad,
		UPPER(M.Especialidad_Descripcion),
		M.Especialidad_Codigo
	from gd_esquema.Maestra as M
	inner join BEMVINDO.TIPO_ESPECIALIDAD as T
		on T.tipo_especialidad_codigo = M.Tipo_Especialidad_Codigo
	where 
		Especialidad_Codigo is not null

go

--TURNO
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.TURNO
add turno_numero numeric(18,0)

go

insert into BEMVINDO.TURNO
	select
		A.id_usuario as afiliado,
		P.id_usuario as personal,
		M.Turno_Fecha,
		null,
		1,
		M.Turno_Numero
	from gd_esquema.Maestra as M
	inner join BEMVINDO.USUARIO as A on M.Paciente_Dni = A.documento
	inner join BEMVINDO.USUARIO as P on M.Medico_Dni = P.documento
	where
		Turno_Numero is not null and
		Consulta_Sintomas is null

go

--CONSULTA
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.CONSULTA
add consulta_numero numeric(18,0)

go

insert into BEMVINDO.CONSULTA
	select 
		T.id_turno,
		UPPER(M.Consulta_Sintomas),
		UPPER(M.Consulta_Enfermedades),
		M.Bono_Consulta_Fecha_Impresion,
		M.Bono_Consulta_Fecha_Impresion,
		1,
		M.Bono_Consulta_Numero
	from gd_esquema.Maestra as M
	inner join BEMVINDO.TURNO as T on M.Turno_Numero = T.turno_numero
	where 
		M.Bono_Consulta_Numero is not null and
		M.Compra_Bono_Fecha is null

go


/********************************************************************************************************************************/
/*BORRADO DE CAMPOS QUE FUERON REEMPLAZADOS POR ID'S AUTOGENERADOS EN LA MIGRACION*/
/********************************************************************************************************************************/

--PLAN MEDICO
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.PLAN_MEDICO
drop column plan_medico_codigo 

go

--TIPO ESPECIALIDAD
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.TIPO_ESPECIALIDAD
drop column tipo_especialidad_codigo

go

--ESPECIALIDAD
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.ESPECIALIDAD
drop column especialidad_codigo 

go

--TURNO
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.TURNO
drop column turno_numero

go

--CONSULTA
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.CONSULTA
drop column consulta_numero

go
