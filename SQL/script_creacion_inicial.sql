USE GD2C2016

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE TABLAS ANTSES DE CREARLAS*/
/********************************************************************************************************************************/
if EXISTS (SELECT * FROM sysobjects  WHERE name='CANCELACION') 
drop table CHAR_DE_30.CANCELACION 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD_POR_PERSONAL') 
drop table CHAR_DE_30.ESPECIALIDAD_POR_PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD') 
drop table CHAR_DE_30.ESPECIALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='FUNCIONALIDAD_POR_ROL') 
drop table CHAR_DE_30.FUNCIONALIDAD_POR_ROL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='FUNCIONALIDAD') 
drop table CHAR_DE_30.FUNCIONALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ITEM_RECETA') 
drop table CHAR_DE_30.ITEM_RECETA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='MEDICAMENTO') 
drop table CHAR_DE_30.MEDICAMENTO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PLAN_HISTORICO_AFILIADO') 
drop table CHAR_DE_30.PLAN_HISTORICO_AFILIADO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PLAN_MEDICO') 
drop table CHAR_DE_30.PLAN_MEDICO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ROL_POR_USUARIO') 
drop table CHAR_DE_30.ROL_POR_USUARIO 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='ROL') 
drop table CHAR_DE_30.ROL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_CANCELACION') 
drop table CHAR_DE_30.TIPO_CANCELACION 

go


if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_ESPECIALIDAD') 
drop table CHAR_DE_30.TIPO_ESPECIALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='DIA_AGENDA') 
drop table CHAR_DE_30.DIA_AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='DIA_AGENDA_EXCEPCION') 
drop table CHAR_DE_30.DIA_AGENDA_EXCEPCION 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='AGENDA') 
drop table CHAR_DE_30.AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='BONO_CONSULTA') 
drop table CHAR_DE_30.BONO_CONSULTA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='BONO_FARMACIA') 
drop table CHAR_DE_30.BONO_FARMACIA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='COMPRA') 
drop table CHAR_DE_30.COMPRA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='RECETA') 
drop table CHAR_DE_30.RECETA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='RESULTADO_TURNO') 
drop table CHAR_DE_30.RESULTADO_TURNO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TURNO') 
drop table CHAR_DE_30.TURNO 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='AFILIADO') 
drop table CHAR_DE_30.AFILIADO 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='ESTADO_CIVIL') 
drop table CHAR_DE_30.ESTADO_CIVIL 

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='PERSONAL') 
drop table CHAR_DE_30.PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='USUARIO') 
drop table CHAR_DE_30.USUARIO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_DOCUMENTO') 
drop table CHAR_DE_30.TIPO_DOCUMENTO 

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE OBJETOS ANTSES DE CREARLOS*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sysobjects WHERE name='fn_hashear_pass') 
drop function CHAR_DE_30.fn_hashear_pass

go

if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass_insert') 
drop trigger CHAR_DE_30.tg_hashear_pass_insert

go

if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass_update') 
drop trigger CHAR_DE_30.tg_hashear_pass_update

go


/********************************************************************************************************************************/
/*CREO ESQUEMA*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sys.schemas  WHERE name='CHAR_DE_30') 
drop schema CHAR_DE_30 

go

create schema CHAR_DE_30 authorization gd

go

/********************************************************************************************************************************/
/*CREACION DE TABLAS*/
/********************************************************************************************************************************/

create table CHAR_DE_30.TIPO_DOCUMENTO
(
    id_tipo_documento  numeric(10,0) identity (1,1) ,
    descripcion     nvarchar(255),

    PRIMARY KEY(id_tipo_documento)
)

go


create table CHAR_DE_30.USUARIO
(
    id_usuario  numeric(10,0) identity(1,1) primary key,
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

    PRIMARY KEY(id_tipo_documento),
    FOREIGN KEY (tipo_documento)   references CHAR_DE_30.TIPO_DOCUMENTO(id_tipo_documento)
)

go

create table CHAR_DE_30.ROL
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion	nvarchar(30),
	activo	bit
) 

go 

create table CHAR_DE_30.ROL_POR_USUARIO
(
	id_rol	numeric(10,0) references CHAR_DE_30.ROL(id),
	id	numeric(10,0) references CHAR_DE_30.USUARIO(id)
)

go


create table CHAR_DE_30.FUNCIONALIDAD
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion		nvarchar(30),
	activo	bit
)

go

create table CHAR_DE_30.FUNCIONALIDAD_POR_ROL
(
	id_funcionalidad	numeric(10,0) references CHAR_DE_30.FUNCIONALIDAD(id),
	id_rol	numeric(10,0) references CHAR_DE_30.ROL(id)
)

go

create table CHAR_DE_30.ESTADO_CIVIL
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion	nvarchar(30)
)

go

create table CHAR_DE_30.PERSONAL
(
	id	numeric(10,0) references CHAR_DE_30.USUARIO(id) primary key,
	matricula	nvarchar(30) unique
)

go

create table CHAR_DE_30.AFILIADO
(
	id numeric(10,0) references CHAR_DE_30.USUARIO(id) primary key,
	id_estado_civil	numeric(10,0) references CHAR_DE_30.ESTADO_CIVIL(id),
	numero_familiar numeric(10,0),
	cantidad_hijos smallint,
	activo	bit
)

go

create table CHAR_DE_30.AGENDA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_personal numeric(10,0) references CHAR_DE_30.PERSONAL(id),
	fecha_desde	date,
	fecha_hasta date
)

go

create table CHAR_DE_30.DIA_AGENDA
(
	id	numeric(10,0) identity(1,1) primary key,
	dia	date,
	hora_desde	time,
	hora_hasta	time,
	activo	bit
)

go

create table CHAR_DE_30.DIA_AGENDA_EXCEPCION
(
	id	numeric(10,0) identity(1,1) primary key,
	id_agenda	numeric(10,0) references CHAR_DE_30.AGENDA(id),
	dia date
)

go

create table CHAR_DE_30.TIPO_ESPECIALIDAD
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion	nvarchar(30)
)

go

create table CHAR_DE_30.ESPECIALIDAD
(
	id	numeric(10,0) identity(1,1) primary key,
	id_tipo_especialidad numeric(10,0) references CHAR_DE_30.TIPO_ESPECIALIDAD(id),
	descripcion	nvarchar(30)
)

go

create table CHAR_DE_30.ESPECIALIDAD_POR_PERSONAL
(
	id_especialidad numeric(10,0) references CHAR_DE_30.ESPECIALIDAD(id),
	id_personal numeric(10,0) references CHAR_DE_30.PERSONAL(id)
)

go

create table CHAR_DE_30.TURNO
(
	id	numeric(10,0) identity(1,1) primary key,
	id_afiliado	numeric(10,0) references CHAR_DE_30.AFILIADO(id),
	id_personal	numeric(10,0) references CHAR_DE_30.PERSONAL(id),
	horario_turno		time,
	horario_llegada		time,
	activo		bit
)

go

create table CHAR_DE_30.RESULTADO_TURNO
(
	id		numeric(10,0) identity(1,1) primary key,
	id_turno	numeric(10,0) references CHAR_DE_30.TURNO(id),
	diagnostico		nvarchar(255),
	sintoma		nvarchar(50),
	fecha_diagnostico	date,
	activo		bit
)

go

create table CHAR_DE_30.TIPO_CANCELACION
(
	id		numeric(10,0) identity(1,1) primary key,
	descripcion		nvarchar(255)
)

go

create table CHAR_DE_30.CANCELACION
(
	id		numeric(10,0) identity(1,1) primary key,
	id_tipo_cancelacion		numeric(10,0) references CHAR_DE_30.TIPO_CANCELACION(id),
	id_turno	numeric(10,0) references CHAR_DE_30.TURNO(id),
	fecha	date,
	motivo	nvarchar(255),
	id_usuario	numeric(10,0) references CHAR_DE_30.USUARIO(id),
	activo	bit
)

go

create table CHAR_DE_30.MEDICAMENTO
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion	nvarchar(50),
	activo	bit	 
)

go

create table CHAR_DE_30.RECETA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_resultado_turno	numeric(10,0) references CHAR_DE_30.RESULTADO_TURNO(id),
	activo	bit
)

go

create table CHAR_DE_30.ITEM_RECETA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_receta	numeric(10,0) references CHAR_DE_30.RECETA(id),
	id_medicamento	numeric(10,0) references CHAR_DE_30.MEDICAMENTO(id),
	cantidad	int,
	activo	bit
)

go

create table CHAR_DE_30.COMPRA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_afiliado		numeric(10,0) references CHAR_DE_30.AFILIADO(id),
	fecha_compra	date,
	costo	numeric(10,2),
	activo	bit
)

go

create table CHAR_DE_30.BONO_CONSULTA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_compra	numeric(10,0) references CHAR_DE_30.COMPRA(id),
	id_turno	numeric(10,0) references CHAR_DE_30.TURNO(id),
	fecha_impresion		date,
	activo	bit
)

go

create table CHAR_DE_30.BONO_FARMACIA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_receta	numeric(10,0) references CHAR_DE_30.RECETA(id),
	id_turno	numeric(10,0) references CHAR_DE_30.TURNO(id),
	fecha_vencimiento	date,
	fecha_impresion		date,
	fecha_prescripcion		date,
	activo	bit
)

go

create table CHAR_DE_30.PLAN_MEDICO
(
	id	numeric(10,0) identity(1,1) primary key,
	id_bono_farmacia	numeric(10,0) references CHAR_DE_30.BONO_FARMACIA(id),
	id_bono_consulta	numeric(10,0) references CHAR_DE_30.BONO_CONSULTA(id),
	descripcion		nvarchar(255),
	activo		bit
)

go

create table CHAR_DE_30.PLAN_HISTORICO_AFILIADO
(
	id	numeric(10,0) identity(1,1) primary key,
	id_plan_medico	numeric(10,0) references CHAR_DE_30.PLAN_MEDICO(id),
	id_afiliado	numeric(10,0) references CHAR_DE_30.AFILIADO(id),
	fecha	date,
	activo	bit
)

go

/********************************************************************************************************************************/
/*FUNCION HASH Y TRIGGER PARA LA CONTRASEÑA*/
/********************************************************************************************************************************/
create function CHAR_DE_30.fn_hashear_pass (@pass nvarchar(255))
returns nvarchar(255)
as begin
	return(
		SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_256', @pass)), 3, 255)
	)
end

go

create trigger CHAR_DE_30.tg_hashear_pass_insert  
on CHAR_DE_30.USUARIO  
instead of insert  
as begin  
    
  insert into CHAR_DE_30.USUARIO  
    select  
      nick,  
      CHAR_DE_30.fn_hashear_pass(pass),  
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

create trigger CHAR_DE_30.tg_hashear_pass_update  
on CHAR_DE_30.USUARIO  
after update
as begin

declare @id_insertado numeric(18,0);  
 
  select @id_insertado = id  
  from inserted

  if(update(pass))
  begin
	update CHAR_DE_30.USUARIO  
    set pass = CHAR_DE_30.fn_hashear_pass(pass)  
	where id = @id_insertado 
  end
 
end
 
go  

/********************************************************************************************************************************/
/*MIGRACION*/
/********************************************************************************************************************************/
