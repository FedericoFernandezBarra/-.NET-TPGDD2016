USE GD2C2016

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE TABLAS ANTSES DE CREARLAS*/
/********************************************************************************************************************************/
if EXISTS (SELECT * FROM sysobjects  WHERE name='CANCELACION') 
drop table XXX.CANCELACION 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD_POR_PERSONAL') 
drop table XXX.ESPECIALIDAD_POR_PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD') 
drop table XXX.ESPECIALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='FUNCIONALIDAD_POR_ROL') 
drop table XXX.FUNCIONALIDAD_POR_ROL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='FUNCIONALIDAD') 
drop table XXX.FUNCIONALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ITEM_RECETA') 
drop table XXX.ITEM_RECETA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='MEDICAMENTO') 
drop table XXX.MEDICAMENTO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PLAN_HISTORICO_AFILIADO') 
drop table XXX.PLAN_HISTORICO_AFILIADO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PLAN_MEDICO') 
drop table XXX.PLAN_MEDICO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ROL_POR_USUARIO') 
drop table XXX.ROL_POR_USUARIO 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='ROL') 
drop table XXX.ROL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_CANCELACION') 
drop table XXX.TIPO_CANCELACION 

go


if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_ESPECIALIDAD') 
drop table XXX.TIPO_ESPECIALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='DIA_AGENDA') 
drop table XXX.DIA_AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='DIA_AGENDA_EXCEPCION') 
drop table XXX.DIA_AGENDA_EXCEPCION 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='AGENDA') 
drop table XXX.AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='BONO_CONSULTA') 
drop table XXX.BONO_CONSULTA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='BONO_FARMACIA') 
drop table XXX.BONO_FARMACIA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='COMPRA') 
drop table XXX.COMPRA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='RECETA') 
drop table XXX.RECETA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='RESULTADO_TURNO') 
drop table XXX.RESULTADO_TURNO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TURNO') 
drop table XXX.TURNO 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='AFILIADO') 
drop table XXX.AFILIADO 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='ESTADO_CIVIL') 
drop table XXX.ESTADO_CIVIL 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='PERSONAL') 
drop table XXX.PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='USUARIO') 
drop table XXX.USUARIO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_DOCUMENTO') 
drop table XXX.TIPO_DOCUMENTO 

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE OBJETOS ANTSES DE CREARLOS*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sysobjects WHERE name='fn_hashear_pass') 
drop function XXX.fn_hashear_pass

go

if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass_insert') 
drop trigger XXX.tg_hashear_pass_insert

go

if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass_update') 
drop trigger XXX.tg_hashear_pass_update

go


/********************************************************************************************************************************/
/*CREO ESQUEMA*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sys.schemas  WHERE name='XXX') 
drop schema XXX 

go

create schema XXX authorization gd

go

/********************************************************************************************************************************/
/*CREACION DE TABLAS*/
/********************************************************************************************************************************/

create table XXX.TIPO_DOCUMENTO
(
    id_tipo_documento  numeric(10,0) identity (1,1) ,
    descripcion     nvarchar(255),

    PRIMARY KEY(id_tipo_documento)
)

go

create table XXX.USUARIO
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
    FOREIGN KEY (tipo_documento)   references XXX.TIPO_DOCUMENTO(id_tipo_documento)
)

go

create table XXX.ROL
(
    id_rol  numeric(10,0) identity(1,1) ,
    descripcion nvarchar(30),
    activo  bit

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
    descripcion     nvarchar(30),
    activo  bit

    PRIMARY KEY (id_funcionalidad)
)

go

create table XXX.FUNCIONALIDAD_POR_ROL
(
    id_funcionalidad    numeric(10,0),
    id_rol  numeric(10,0),


    PRIMARY KEY (id_funcionalidad, id_rol), 
    FOREIGN KEY (id_funcionalidad)           references XXX.FUNCIONALIDAD(id_funcionalidad), 
    FOREIGN KEY (id_rol)                     references XXX.ROL(id_rol)
)

go

create table XXX.ESTADO_CIVIL
(
    id_estado_civil  numeric(10,0) identity(1,1),
    descripcion nvarchar(30),

    PRIMARY KEY (id_estado_civil)
)

go

create table XXX.PLAN_MEDICO
(
    id_plan_medico   numeric(10,0) identity(1,1) ,
    descripcion      nvarchar(255),
	precio_bono_consulta    numeric(18,2),
    precio_bono_farmacia    numeric(18,2),
    activo           bit,

    PRIMARY KEY (id_plan_medico)
)

go

create table XXX.PERSONAL
(
    id_personal  numeric(10,0) references XXX.USUARIO(id_usuario) ,
    matricula   nvarchar(30) --unique,

    PRIMARY KEY (id_personal)
)

go

create table XXX.AFILIADO
(
    id_afiliado numeric(10,0),
    estado_civil numeric(10,0),
	plan_medico numeric(10,0),
    numero_familiar numeric(10,0),
    cantidad_hijos smallint

    PRIMARY KEY (id_afiliado)
    FOREIGN KEY (id_afiliado)             references XXX.USUARIO(id_usuario),
    FOREIGN KEY (estado_civil)            references XXX.ESTADO_CIVIL(id_estado_civil),
	FOREIGN KEY (plan_medico)            references XXX.PLAN_MEDICO(id_plan_medico)
)

go

create table XXX.AGENDA
(
    id_agenda  numeric(10,0) identity(1,1) ,
    personal numeric(10,0),
    fecha_desde date,
    fecha_hasta date

    PRIMARY KEY (id_agenda),
    FOREIGN KEY (personal)             references XXX.PERSONAL(id_personal)

)

go

create table XXX.DIA_AGENDA
(
    id_dia_agenda numeric(10,0) identity(1,1),
    dia date,
    hora_desde  time,
    hora_hasta  time,
    activo  bit

    PRIMARY KEY (id_dia_agenda),

)

go

create table XXX.DIA_AGENDA_EXCEPCION
(
    id_dia_agenda_exepcion  numeric(10,0) identity(1,1),
    agenda   numeric(10,0) ,
    dia date

    
    PRIMARY KEY (id_dia_agenda_exepcion),
    FOREIGN KEY (agenda)             references XXX.AGENDA(id_agenda)
)

go

create table XXX.TIPO_ESPECIALIDAD
(
    id_tipo_especialidad  numeric(10,0) identity(1,1) ,
    descripcion nvarchar(255)

    PRIMARY KEY (id_tipo_especialidad)
)

go

create table XXX.ESPECIALIDAD
(
    id_especialidad  numeric(10,0) identity(1,1) ,
    tipo_especialidad numeric(10,0),
    descripcion nvarchar(255),

    PRIMARY KEY (id_especialidad),
    FOREIGN KEY (tipo_especialidad)                   references XXX.TIPO_ESPECIALIDAD(id_tipo_especialidad)
)

go

create table XXX.ESPECIALIDAD_POR_PERSONAL
(
    id_especialidad numeric(10,0) ,
    id_personal numeric(10,0) 

    PRIMARY KEY (id_especialidad, id_personal), 
    FOREIGN KEY (id_especialidad)                references XXX.ESPECIALIDAD(id_especialidad), 
    FOREIGN KEY (id_personal)                    references XXX.PERSONAL(id_personal)
)

go

create table XXX.TURNO
(
    id_turno  numeric(10,0) identity(1,1) ,
    afiliado numeric(10,0) ,
    personal numeric(10,0) ,
    horario_turno       time,
    horario_llegada     time,
    activo      bit,


    PRIMARY KEY (id_turno), 
    FOREIGN KEY (afiliado)                    references XXX.AFILIADO(id_afiliado), 
    FOREIGN KEY (personal)                    references XXX.PERSONAL(id_personal)
)

go

create table XXX.RESULTADO_TURNO
(
    id_resultado_turno     numeric(10,0) identity(1,1),
    turno                  numeric(10,0) ,
    diagnostico            nvarchar(255),
    sintoma                nvarchar(50),
    fecha_diagnostico      date,
    activo                 bit

    PRIMARY KEY (id_resultado_turno), 
    FOREIGN KEY (turno)                    references XXX.TURNO(id_turno), 
)

go

go

create table XXX.TIPO_CANCELACION
(
    id_tipo_cancelacion      numeric(10,0) identity(1,1) ,
    descripcion              nvarchar(255),

    PRIMARY KEY (id_tipo_cancelacion)
)

go

go

create table XXX.CANCELACION
(
    id_cancelacion          numeric(10,0) identity(1,1) ,
    tipo_cancelacion     numeric(10,0),
    turno                numeric(10,0) ,
    fecha   date,
    motivo  nvarchar(255),
    usuario  numeric(10,0),
    activo  bit,


    PRIMARY KEY (id_cancelacion), 
    FOREIGN KEY (tipo_cancelacion)         references XXX.TIPO_CANCELACION(id_tipo_cancelacion), 
    FOREIGN KEY (turno)                    references XXX.TURNO(id_turno),
    FOREIGN KEY (usuario)                    references XXX.USUARIO(id_usuario)
)

go

create table XXX.MEDICAMENTO
(
    id_medicamento  numeric(10,0) identity(1,1),
    descripcion nvarchar(50),
    activo  bit 

    PRIMARY KEY (id_medicamento), 
)


go

create table XXX.RECETA
(
    id_receta  numeric(10,0) identity(1,1),
    resultado_turno  numeric(10,0) ,
    activo  bit

    PRIMARY KEY (id_receta), 
    FOREIGN KEY (resultado_turno)         references XXX.RESULTADO_TURNO(id_resultado_turno)
)

create table XXX.ITEM_RECETA
(
    id_item_receta  numeric(10,0) identity(1,1),
    receta   numeric(10,0) ,
    medicamento  numeric(10,0) ,
    cantidad    int,
    activo  bit,


    PRIMARY KEY (id_item_receta), 
    FOREIGN KEY (receta)              references XXX.RECETA(id_receta),
    FOREIGN KEY (medicamento)         references XXX.MEDICAMENTO(id_medicamento)
)

go

create table XXX.COMPRA
(
    id_compra  numeric(10,0) identity(1,1) ,
    afiliado     numeric(10,0),
    fecha_compra    date,
    costo   numeric(10,2),
    activo  bit

    
    PRIMARY KEY (id_compra), 
    FOREIGN KEY (afiliado)              references XXX.AFILIADO(id_afiliado)
)

go

create table XXX.BONO_CONSULTA
(
    id_bono_consulta  numeric(10,0) identity(1,1),
    compra   numeric(10,0) ,
    turno    numeric(10,0) ,
    fecha_impresion     date,
    activo  bit

    PRIMARY KEY (id_bono_consulta), 
    FOREIGN KEY (compra)              references XXX.COMPRA(id_compra),
    FOREIGN KEY (turno)               references XXX.TURNO(id_turno)
)


go

create table XXX.BONO_FARMACIA
(
    id_bono_farmacia  numeric(10,0) identity(1,1),
    receta   numeric(10,0) ,
    turno    numeric(10,0) ,
    fecha_vencimiento   date,
    fecha_impresion     date,
    fecha_prescripcion      date,
    activo  bit,


    PRIMARY KEY (id_bono_farmacia), 
    FOREIGN KEY (receta)              references XXX.RECETA(id_receta),
    FOREIGN KEY (turno)               references XXX.TURNO(id_turno)
)

go


create table XXX.PLAN_HISTORICO_AFILIADO
(
    id_plan_historico_afiliado  numeric(10,0) identity(1,1),
    plan_medico  numeric(10,0) ,
    afiliado numeric(10,0) ,
    fecha   date,
    activo  bit

    PRIMARY KEY (id_plan_historico_afiliado), 
    FOREIGN KEY (plan_medico)                  references XXX.PLAN_MEDICO(id_plan_medico),
    FOREIGN KEY (afiliado)                     references XXX.AFILIADO(id_afiliado)
)

go


/********************************************************************************************************************************/
/*FUNCION HASH Y TRIGGER PARA LA CONTRASEÑA*/
/********************************************************************************************************************************/
create function XXX.fn_hashear_pass (@pass nvarchar(255))
returns nvarchar(255)
as begin
    return(
        SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_256', @pass)), 3, 255)
    )
end

go

create trigger XXX.tg_hashear_pass_insert  
on XXX.USUARIO  
instead of insert  
as begin  
    
  insert into XXX.USUARIO  
    select  
      nick,  
      XXX.fn_hashear_pass(pass),  
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

create trigger XXX.tg_hashear_pass_update  
on XXX.USUARIO  
after update
as begin

declare @id_insertado numeric(18,0);  
 
  select @id_insertado = id_usuario 
  from inserted

  if(update(pass))
  begin
    update XXX.USUARIO  
    set pass = XXX.fn_hashear_pass(pass)  
    where id_usuario = @id_insertado 
  end
 
end
 
go  

/********************************************************************************************************************************/
/*MIGRACION*/
/********************************************************************************************************************************/

--TIPO DOCUMENTO
-------------------------------------------------------------------------------------------------------
insert into XXX.TIPO_DOCUMENTO
values ('DNI')

go

--ESTADO CIVIL
-------------------------------------------------------------------------------------------------------
insert into XXX.ESTADO_CIVIL
values 
	('SOLTERO/A'),
	('CASADO/A'),
	('VIUDO/A'),
	('CONCUBINATO'),
	('DIVORCIADO/A')

go

--PLAN MEDICO
-------------------------------------------------------------------------------------------------------
alter table XXX.PLAN_MEDICO
add plan_medico_codigo numeric(18,0)

go

insert into XXX.PLAN_MEDICO
	select distinct
		Plan_Med_Descripcion,
		Plan_Med_Precio_Bono_Consulta,
		Plan_Med_Precio_Bono_Farmacia,
		1,
		Plan_Med_Codigo
	from gd_esquema.Maestra 

go

--USUARIOS
-------------------------------------------------------------------------------------------------------

--afiliados
insert into XXX.USUARIO
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
insert into XXX.USUARIO
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
insert into XXX.AFILIADO
	select distinct
		U.id_usuario,
		null,
		P.id_plan_medico,
		null,
		null
	from gd_esquema.Maestra as M
	inner join XXX.USUARIO as U 
		on M.Paciente_Dni = U.documento
	inner join XXX.PLAN_MEDICO as P
		on M.Plan_Med_Codigo = P.plan_medico_codigo
	where 
		M.Consulta_Sintomas is null and
		M.Compra_Bono_Fecha is null

go

--PERSONAL
-------------------------------------------------------------------------------------------------------
insert into XXX.PERSONAL
	select distinct
		U.id_usuario,
		null
	from gd_esquema.Maestra as M
	inner join XXX.USUARIO as U 
		on M.Medico_Dni = U.documento
	where 
		M.Consulta_Sintomas is null and
		M.Compra_Bono_Fecha is null

go

--TIPO ESPECIALIDAD
-------------------------------------------------------------------------------------------------------
alter table XXX.TIPO_ESPECIALIDAD
add tipo_especialidad_codigo numeric(18,0)

go

insert into XXX.TIPO_ESPECIALIDAD
	select distinct
		UPPER(Tipo_Especialidad_Descripcion),
		Tipo_Especialidad_Codigo
	from gd_esquema.Maestra 
	where 
		Tipo_Especialidad_Codigo is not null

go

--ESPECIALIDAD
-------------------------------------------------------------------------------------------------------
alter table XXX.ESPECIALIDAD
add especialidad_codigo numeric(18,0)

go

insert into XXX.ESPECIALIDAD
	select distinct
		T.id_tipo_especialidad,
		UPPER(M.Especialidad_Descripcion),
		M.Especialidad_Codigo
	from gd_esquema.Maestra as M
	inner join XXX.TIPO_ESPECIALIDAD as T
		on T.tipo_especialidad_codigo = M.Tipo_Especialidad_Codigo
	where 
		Especialidad_Codigo is not null

go
