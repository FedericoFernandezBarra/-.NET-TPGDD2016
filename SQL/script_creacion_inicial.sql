USE GD2C2016

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE TABLAS ANTSES DE CREARLAS*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sysobjects  WHERE name='AFILIADO') 
drop table CHAR_DE_30.AFILIADO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PERSONAL') 
drop table CHAR_DE_30.PERSONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='USUARIO') 
drop table CHAR_DE_30.USUARIO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='GRUPO_FAMILIAR') 
drop table CHAR_DE_30.GRUPO_FAMILIAR 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESTADO_CIVIL') 
drop table CHAR_DE_30.ESTADO_CIVIL 

go


if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_DOCUMENTO') 
drop table CHAR_DE_30.TIPO_DOCUMENTO 

go
/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE OBJETOS ANTSES DE CREARLOS*/
/********************************************************************************************************************************/


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
	id	numeric(10,0) identity(1,1) primary key,
	matricula	nvarchar(30) unique,
	id_usuario	numeric(10,0) references CHAR_DE_30.USUARIO(id)
)

go

create table CHAR_DE_30.AFILIADO
(
	id numeric(10,0) identity(1,1) primary key,
	id_usuario numeric(10,0) references CHAR_DE_30.USUARIO(id),
	id_estado_civil	numeric(10,0) references CHAR_DE_30.ESTADO_CIVIL(id),
	id_grupo_familiar numeric(10,0) references CHAR_DE_30.GRUPO_FAMILIAR(id),
	numero_familiar numeric(10,0),
	cantidad_hijos smallint,
	activo	bit
)

go
