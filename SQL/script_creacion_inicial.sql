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

if EXISTS (SELECT * FROM sys.schemas  WHERE name='CHAR_DE_30') 
drop schema CHAR_DE_30 

go

create schema CHAR_DE_30 authorization gd

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
    FOREIGN KEY (tipo_documento)   references XXX.TIPO_DOCUMENTO(id_tipo_documento)
)

go

create table XXX.ROL
(
    id  numeric(10,0) identity(1,1) primary key,
    descripcion nvarchar(30),
    activo  bit
) 

go 

create table XXX.ROL_POR_USUARIO
(
    id_rol  numeric(10,0) references XXX.ROL(id),
    id  numeric(10,0) references XXX.USUARIO(id)
)

go


create table XXX.FUNCIONALIDAD
(
    id  numeric(10,0) identity(1,1) primary key,
    descripcion     nvarchar(30),
    activo  bit
)

go

create table XXX.FUNCIONALIDAD_POR_ROL
(
    id_funcionalidad    numeric(10,0) references XXX.FUNCIONALIDAD(id),
    id_rol  numeric(10,0) references XXX.ROL(id)
)

go

create table XXX.ESTADO_CIVIL
(
    id  numeric(10,0) identity(1,1) primary key,
    descripcion nvarchar(30)
)

go

create table XXX.PERSONAL
(
    id  numeric(10,0) references XXX.USUARIO(id) primary key,
    matricula   nvarchar(30) unique
)

go

create table XXX.AFILIADO
(
    id numeric(10,0) references XXX.USUARIO(id) primary key,
    id_estado_civil numeric(10,0) references XXX.ESTADO_CIVIL(id),
    numero_familiar numeric(10,0),
    cantidad_hijos smallint,
    activo  bit
)

go

create table XXX.AGENDA
(
    id  numeric(10,0) identity(1,1) primary key,
    id_personal numeric(10,0) references XXX.PERSONAL(id),
    fecha_desde date,
    fecha_hasta date
)

go

create table XXX.DIA_AGENDA
(
    id  numeric(10,0) identity(1,1) primary key,
    dia date,
    hora_desde  time,
    hora_hasta  time,
    activo  bit
)

go

create table XXX.DIA_AGENDA_EXCEPCION
(
    id  numeric(10,0) identity(1,1) primary key,
    id_agenda   numeric(10,0) references XXX.AGENDA(id),
    dia date
)

go

create table XXX.TIPO_ESPECIALIDAD
(
    id  numeric(10,0) identity(1,1) primary key,
    descripcion nvarchar(30)
)

go

create table XXX.ESPECIALIDAD
(
    id  numeric(10,0) identity(1,1) primary key,
    id_tipo_especialidad numeric(10,0) references XXX.TIPO_ESPECIALIDAD(id),
    descripcion nvarchar(30)
)

go

create table XXX.ESPECIALIDAD_POR_PERSONAL
(
    id_especialidad numeric(10,0) references XXX.ESPECIALIDAD(id),
    id_personal numeric(10,0) references XXX.PERSONAL(id)
)

go

create table XXX.TURNO
(
    id  numeric(10,0) identity(1,1) primary key,
    id_afiliado numeric(10,0) references XXX.AFILIADO(id),
    id_personal numeric(10,0) references XXX.PERSONAL(id),
    horario_turno       time,
    horario_llegada     time,
    activo      bit
)

go

create table XXX.RESULTADO_TURNO
(
    id      numeric(10,0) identity(1,1) primary key,
    id_turno    numeric(10,0) references XXX.TURNO(id),
    diagnostico     nvarchar(255),
    sintoma     nvarchar(50),
    fecha_diagnostico   date,
    activo      bit
)

go

create table XXX.TIPO_CANCELACION
(
    id      numeric(10,0) identity(1,1) primary key,
    descripcion     nvarchar(255)
)

go

create table XXX.CANCELACION
(
    id      numeric(10,0) identity(1,1) primary key,
    id_tipo_cancelacion     numeric(10,0) references XXX.TIPO_CANCELACION(id),
    id_turno    numeric(10,0) references XXX.TURNO(id),
    fecha   date,
    motivo  nvarchar(255),
    id_usuario  numeric(10,0) references XXX.USUARIO(id),
    activo  bit
)

go

create table XXX.MEDICAMENTO
(
    id  numeric(10,0) identity(1,1) primary key,
    descripcion nvarchar(50),
    activo  bit  
)

go

create table XXX.RECETA
(
    id  numeric(10,0) identity(1,1) primary key,
    id_resultado_turno  numeric(10,0) references XXX.RESULTADO_TURNO(id),
    activo  bit
)

go

create table XXX.ITEM_RECETA
(
    id  numeric(10,0) identity(1,1) primary key,
    id_receta   numeric(10,0) references XXX.RECETA(id),
    id_medicamento  numeric(10,0) references XXX.MEDICAMENTO(id),
    cantidad    int,
    activo  bit
)

go

create table XXX.COMPRA
(
    id  numeric(10,0) identity(1,1) primary key,
    id_afiliado     numeric(10,0) references XXX.AFILIADO(id),
    fecha_compra    date,
    costo   numeric(10,2),
    activo  bit
)

go

create table XXX.BONO_CONSULTA
(
    id  numeric(10,0) identity(1,1) primary key,
    id_compra   numeric(10,0) references XXX.COMPRA(id),
    id_turno    numeric(10,0) references XXX.TURNO(id),
    fecha_impresion     date,
    activo  bit
)

go

create table XXX.BONO_FARMACIA
(
    id  numeric(10,0) identity(1,1) primary key,
    id_receta   numeric(10,0) references XXX.RECETA(id),
    id_turno    numeric(10,0) references XXX.TURNO(id),
    fecha_vencimiento   date,
    fecha_impresion     date,
    fecha_prescripcion      date,
    activo  bit
)

go

create table XXX.PLAN_MEDICO
(
    id  numeric(10,0) identity(1,1) primary key,
    id_bono_farmacia    numeric(10,0) references XXX.BONO_FARMACIA(id),
    id_bono_consulta    numeric(10,0) references XXX.BONO_CONSULTA(id),
    descripcion     nvarchar(255),
    activo      bit
)

go

create table XXX.PLAN_HISTORICO_AFILIADO
(
    id  numeric(10,0) identity(1,1) primary key,
    id_plan_medico  numeric(10,0) references XXX.PLAN_MEDICO(id),
    id_afiliado numeric(10,0) references XXX.AFILIADO(id),
    fecha   date,
    activo  bit
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
 
  select @id_insertado = id  
  from inserted

  if(update(pass))
  begin
    update XXX.USUARIO  
    set pass = XXX.fn_hashear_pass(pass)  
    where id = @id_insertado 
  end
 
end
 
go  

/********************************************************************************************************************************/
/*MIGRACION*/
/********************************************************************************************************************************/
