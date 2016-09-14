USE GD2C2016

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE TABLAS ANTSES DE CREARLAS*/
/********************************************************************************************************************************/
if EXISTS (SELECT * FROM sysobjects  WHERE name='AGENDA') 
drop table CHAR_DE_30.AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='BONO_CONSULTA') 
drop table CHAR_DE_30.BONO_CONSULTA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='BONO_FARMACIA') 
drop table CHAR_DE_30.BONO_FARMACIA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='CANCELACION') 
drop table CHAR_DE_30.CANCELACION 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='COMPRA') 
drop table CHAR_DE_30.COMPRA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD_POR_PERSONAL') 
drop table CHAR_DE_30.ESPECIALIDAD_POR_PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='FUNCIONALIDAD_POR_ROL') 
drop table CHAR_DE_30.FUNCIONALIDAD_POR_ROL

go
if EXISTS (SELECT * FROM sysobjects  WHERE name='MEDICAMENTO_HISTORIA_CLINICA') 
drop table CHAR_DE_30.MEDICAMENTO_HISTORIA_CLINICA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='MODIFICACIONES_GRUPO_FAMILIAR') 
drop table CHAR_DE_30.MODIFICACIONES_GRUPO_FAMILIAR 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PLAN_MEDICO') 
drop table CHAR_DE_30.PLAN_MEDICO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='RANGO') 
drop table CHAR_DE_30.RANGO 

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


if EXISTS (SELECT * FROM sysobjects  WHERE name='TURNO') 
drop table CHAR_DE_30.TURNO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='FUNCIONALIDAD') 
drop table CHAR_DE_30.FUNCIONALIDAD 

go


if EXISTS (SELECT * FROM sysobjects  WHERE name='HISTORIA_CLINICA') 
drop table CHAR_DE_30.HISTORIA_CLINICA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='MEDICAMENTO') 
drop table CHAR_DE_30.MEDICAMENTO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PERSONAL') 
drop table CHAR_DE_30.PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='AFILIADO') 
drop table CHAR_DE_30.AFILIADO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD') 
drop table CHAR_DE_30.ESPECIALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESTADO_CIVIL') 
drop table CHAR_DE_30.ESTADO_CIVIL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='GRUPO_FAMILIAR') 
drop table CHAR_DE_30.GRUPO_FAMILIAR 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_ESPECIALIDAD') 
drop table CHAR_DE_30.TIPO_ESPECIALIDAD 

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

create table CHAR_DE_30.GRUPO_FAMILIAR
(
	id	numeric(10,0) identity(1,1) primary key,
	plan_medico nvarchar(255)
)

go


create table CHAR_DE_30.ESTADO_CIVIL
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion	nvarchar(30)
)

go

create table CHAR_DE_30.TIPO_DOCUMENTO
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion		nvarchar(255)
)

go

create table CHAR_DE_30.USUARIO
(
	id	numeric(10,0) identity(1,1) primary key,
	nick    nvarchar(255) unique,
	pass	nvarchar(255),
	intentos_login   smallint,
	activo	bit,
	nombre	nvarchar(255),
	apellido	nvarchar(255),
	tipo_documento	numeric(10,0) references CHAR_DE_30.TIPO_DOCUMENTO(id),  
	documento	nvarchar(12),
	fecha_nacimiento	date,
	direccion	nvarchar(255),
	telefono	nvarchar(255),
	mail	nvarchar(255),
	sexo	char check (sexo in('F','M'))
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
	id_grupo_familiar numeric(10,0) references CHAR_DE_30.GRUPO_FAMILIAR(id),
	numero_familiar numeric(10,0),
	cantidad_hijos smallint,
	activo	bit
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
	descripcion		nvarchar(30)
)

go

create table CHAR_DE_30.FUNCIONALIDAD_POR_ROL
(
	id_funcionalidad	numeric(10,0) references CHAR_DE_30.FUNCIONALIDAD(id),
	id_rol	numeric(10,0) references CHAR_DE_30.ROL(id)
)

go

create table CHAR_DE_30.TIPO_CANCELACION
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion	nvarchar(30)
)

go

create table CHAR_DE_30.CANCELACION
(
	id_tipo	numeric(10,0) references CHAR_DE_30.TIPO_CANCELACION(id),
	id	numeric(10,0) references CHAR_DE_30.USUARIO(id),
	motivo		nvarchar(255)
)

go

create table CHAR_DE_30.RANGO
(
	id	numeric(10,0) identity(1,1) primary key,
	id_personal numeric(10,0) references CHAR_DE_30.PERSONAL(id),
	dia	date,
	hora_desde time,
	hora_hasta time
)

go

create table CHAR_DE_30.AGENDA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_personal numeric(10,0) references CHAR_DE_30.PERSONAL(id),
	desde	date,
	hasta date
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

-------

go

create table CHAR_DE_30.HISTORIA_CLINICA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_afiliado numeric(10,0) references CHAR_DE_30.AFILIADO(id),
	id_personal numeric(10,0) references CHAR_DE_30.PERSONAL(id),
	id_especialidad	numeric(10,0) references CHAR_DE_30.ESPECIALIDAD(id),
	hora_atencion	date,
	sintomas	nvarchar(255),
	diagnostico	nvarchar(255)
)

go

create table CHAR_DE_30.MEDICAMENTO
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion	nvarchar(50)	 
)

go

create table CHAR_DE_30.MEDICAMENTO_HISTORIA_CLINICA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_medicamento numeric(10,0) references CHAR_DE_30.MEDICAMENTO(id),
	id_historia_clinica numeric(10,0) references CHAR_DE_30.HISTORIA_CLINICA(id),
	cantidad	int,
	bono_farmacia	numeric(12,2)
)

go

create table CHAR_DE_30.TURNO
(
	id	numeric(10,0) identity(1,1) primary key,
	id_afiliado	numeric(10,0) references CHAR_DE_30.AFILIADO(id),
	id_personal	numeric(10,0) references CHAR_DE_30.PERSONAL(id),
	id_especialidad	numeric(10,0) references CHAR_DE_30.ESPECIALIDAD(id),
	activo		bit,
	horario		datetime,
	horario_llegada		datetime
)

go

create table CHAR_DE_30.PLAN_MEDICO
(
	id	numeric(10,0) identity(1,1) primary key,
	descripcion	nvarchar(50),
	precio_bono_consulta	numeric(12,2),
	precio_bono_farmacia	numeric(12,2)
)

go

create table CHAR_DE_30.COMPRA
(
	id	numeric(10,0) identity(1,1) primary key,
	fecha	date,
	id_afiliado	numeric(10,0) references CHAR_DE_30.AFILIADO(id),
	id_plan_medico	numeric(10,0) references CHAR_DE_30.PLAN_MEDICO(id)
)

go

create table CHAR_DE_30.BONO_FARMACIA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_compra	numeric(10,0) references CHAR_DE_30.COMPRA(id),
	id_plan_medico	numeric(10,0) references CHAR_DE_30.PLAN_MEDICO(id),
	activo	bit
)

go

create table CHAR_DE_30.BONO_CONSULTA
(
	id	numeric(10,0) identity(1,1) primary key,
	id_compra	numeric(10,0) references CHAR_DE_30.COMPRA(id),
	id_turno numeric(10,0) references CHAR_DE_30.TURNO(id),
	id_plan_medico	numeric(10,0) references CHAR_DE_30.PLAN_MEDICO(id)
)

go

create table CHAR_DE_30.MODIFICACIONES_GRUPO_FAMILIAR
(
	id_grupo_familiar	numeric(10,0) references CHAR_DE_30.GRUPO_FAMILIAR(id),
	id_plan_medico numeric(10,0) references CHAR_DE_30.PLAN_MEDICO(id),
	fecha	date,
	motivo	nvarchar(255)
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