USE GD2C2016

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE PROCEDIMIENTOS, FUNCIONES, ETC ANTSES DE CREARLOS*/
/********************************************************************************************************************************/

--REGSITRAR AGENDA MEDICO
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='sp_agenda_del_profesional') 
drop procedure BEMVINDO.sp_agenda_del_profesional

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='sp_nombre_de_especialidades_del_profesional') 
drop procedure BEMVINDO.sp_nombre_de_especialidades_del_profesional

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='sp_insertar_nueva_agenda') 
drop procedure BEMVINDO.sp_insertar_nueva_agenda

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='sp_insertar_nuevo_dia_agenda') 
drop procedure BEMVINDO.sp_insertar_nuevo_dia_agenda

go
---ABM AFILIADO----------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='st_insertar_afiliado') 
drop procedure BEMVINDO.st_insertar_afiliado

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_baja_afiliado') 
drop procedure BEMVINDO.st_baja_afiliado

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_actualizar_afiliado') 
drop procedure BEMVINDO.st_actualizar_afiliado

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='buscar_historial_de_cambios') 
drop procedure BEMVINDO.buscar_historial_de_cambios

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_buscar_afiliados') 
drop procedure BEMVINDO.st_buscar_afiliados

go

--GRUPO AFILIADO VIEJO
-------------------------------------------------------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects  WHERE name='sp_afiliados_sin_numero_afiliado') 
drop procedure BEMVINDO.sp_afiliados_sin_numero_afiliado

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='sp_agregar_numero_afiliado_a_afiliado_principal_migrado') 
drop procedure BEMVINDO.sp_agregar_numero_afiliado_a_afiliado_principal_migrado

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='sp_agregar_numero_afiliado_a_conyuge_migrado') 
drop procedure BEMVINDO.sp_agregar_numero_afiliado_a_conyuge_migrado

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='sp_agregar_numero_afiliado_a_hijo_migrado') 
drop procedure BEMVINDO.sp_agregar_numero_afiliado_a_hijo_migrado

go


--COMPRAR BONO
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='st_insertar_compra') 
drop procedure BEMVINDO.st_insertar_compra

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_insertar_bono') 
drop procedure BEMVINDO.st_insertar_bono


go

--PEDIDO DE TURNOS
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='st_insertar_turno') 
drop procedure BEMVINDO.st_insertar_turno

go

--REGISTRO DE LLEGADA PARA ATENCION MEDICA
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='st_buscar_profesional') 
drop procedure BEMVINDO.st_buscar_profesional

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_obtener_turnos') 
drop procedure BEMVINDO.st_obtener_turnos

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_registrar_fecha_llegada') 
drop procedure BEMVINDO.st_registrar_fecha_llegada

go


--RESULTADOS PARA ATENCION MEDICA
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='st_registrar_consulta') 
drop procedure BEMVINDO.st_registrar_consulta

go

--CANCELAR ATENCION MEDICA POR PARTE DEL AFILIADO
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='st_cancelar_turno_afiliado') 
drop procedure BEMVINDO.st_cancelar_turno_afiliado

go

--CANCELAR ATENCION MEDICA POR PARTE DEL MEDICO
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='st_cancelar_turno_medico') 
drop procedure BEMVINDO.st_cancelar_turno_medico

go

--USUARIO LOGUIN
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='VERIFICAR_LOGUEO') 
drop procedure BEMVINDO.VERIFICAR_LOGUEO

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_dar_de_baja_usuario') 
drop procedure BEMVINDO.st_dar_de_baja_usuario

go


--LISTADO ESTADISTICO
-------------------------------------------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects  WHERE name='st_top5_especialidades_mas_canceladas') 
drop procedure BEMVINDO.st_top5_especialidades_mas_canceladas

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_top5_profesionales_mas_consultados') 
drop procedure BEMVINDO.st_top5_profesionales_mas_consultados

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_top5_profesionales_menos_horas_trabajdas') 
drop procedure BEMVINDO.st_top5_profesionales_menos_horas_trabajdas

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_top5_afiliados_mas_bonos_comprados') 
drop procedure BEMVINDO.st_top5_afiliados_mas_bonos_comprados

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='st_top5_especialidades_mas_bonos_consulta') 
drop procedure BEMVINDO.st_top5_especialidades_mas_bonos_consulta

go


-------------------------------------------------------------------------------------------------------

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE TABLAS ANTSES DE CREARLAS*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sysobjects  WHERE name='BONO') 
drop table BEMVINDO.BONO

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='CANCELACION') 
drop table BEMVINDO.CANCELACION 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='CONSULTA') 
drop table BEMVINDO.CONSULTA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD_POR_PROFESIONAL') 
drop table BEMVINDO.ESPECIALIDAD_POR_PROFESIONAL 

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

if EXISTS (SELECT * FROM sysobjects  WHERE name='TURNO') 
drop table BEMVINDO.TURNO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='COMPRA') 
drop table BEMVINDO.COMPRA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='AFILIADO') 
drop table BEMVINDO.AFILIADO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='CANCELACION_DIA') 
drop table BEMVINDO.CANCELACION_DIA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='DIA_AGENDA') 
drop table BEMVINDO.DIA_AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='AGENDA') 
drop table BEMVINDO.AGENDA 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESPECIALIDAD') 
drop table BEMVINDO.ESPECIALIDAD 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='ESTADO_CIVIL') 
drop table BEMVINDO.ESTADO_CIVIL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PLAN_MEDICO') 
drop table BEMVINDO.PLAN_MEDICO 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='PROFESIONAL') 
drop table BEMVINDO.PROFESIONAL 

go

if EXISTS (SELECT * FROM sysobjects  WHERE name='TIPO_ESPECIALIDAD') 
drop table BEMVINDO.TIPO_ESPECIALIDAD 

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
/*CREACION DE ESQUEMA*/
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
    id_plan_medico numeric(10,0) identity(1,1),
    descripcion    nvarchar(255),
    precio_bono    numeric(10,2),
    

    PRIMARY KEY (id_plan_medico)
)

go

create table BEMVINDO.PROFESIONAL
(
    id_profesional  numeric(10,0),
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
    numero_afiliado numeric(10,0),

    PRIMARY KEY (id_afiliado),
    FOREIGN KEY (id_afiliado)             references BEMVINDO.USUARIO(id_usuario),
    FOREIGN KEY (estado_civil)            references BEMVINDO.ESTADO_CIVIL(id_estado_civil),
    FOREIGN KEY (plan_medico)             references BEMVINDO.PLAN_MEDICO(id_plan_medico)
)

go

create table BEMVINDO.HISTORIAL_CAMBIOS_DE_PLAN
(
    id_historial  numeric(10,0) identity(1,1),
    plan_medico  numeric(10,0),
    afiliado numeric(10,0),
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
    id_agenda       numeric(10,0) identity(1,1),
    profesional     numeric(10,0),
    fecha_inicial   date,
    fecha_final     date,

    PRIMARY KEY (id_agenda),
    FOREIGN KEY (profesional)   references BEMVINDO.PROFESIONAL(id_profesional),
)

go

create table BEMVINDO.DIA_AGENDA
(
    id_dia_agenda       numeric(10,0) identity(1,1),
    agenda      numeric(10,0),
    especialidad    numeric(10,0),
    dia     nvarchar(10) check (dia in('LUNES','MARTES', 'MIERCOLES','JUEVES', 'VIERNES', 'SABADO')),
    horario_inicial     time,
    horario_final       time,
    

    PRIMARY KEY (id_dia_agenda),
    FOREIGN KEY (agenda)   references BEMVINDO.AGENDA(id_agenda),
    FOREIGN KEY (especialidad)   references BEMVINDO.ESPECIALIDAD(id_especialidad)
)

go

  create table BEMVINDO.CANCELACION_DIA
  (
      id_cancelacion_dia      numeric(10,0) identity(1,1),
      agenda                  numeric(10,0) ,
      cancelacion_desde       date,
      cancelacion_hasta       date,
  
      
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
    id_tipo_cancelacion      numeric(10,0) identity(1,1),
    descripcion              nvarchar(255),

    PRIMARY KEY (id_tipo_cancelacion)
)

go

create table BEMVINDO.CANCELACION
(
    id_cancelacion       numeric(10,0) identity(1,1),
    tipo_cancelacion     numeric(10,0),
    turno                numeric(10,0),
    fecha                date,
    motivo               nvarchar(255),
    tipo_usuario         char check (tipo_usuario in('A','P')),
    

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

--ROL
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.ROL
values 
    ('PROFESIONAL', 1),
    ('AFILIADO', 1),
    ('ADMINISTRADOR', 1)

go

--FUNCIONALIDAD
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.FUNCIONALIDAD
values 
    ('ABM ROL', 1),
    ('LOGIN Y SEGURIDAD',1),
    ('REGISTRO DE USUARIOS',1),
    ('ABM AFILIADO',1),
    ('ABM PROFESIONAL',1),
    ('ABM ESPECIALIDADES MEDICAS',1),
    ('ABM PLANES',1),
    ('REGISTRAR AGENDA DEL MEDICO',1),
    ('COMPRA DE BONOS',1),
    ('PEDIR TURNO', 1),
    ('REGISTRO DE LLEGADA PARA ATENCION MEDICA', 1),
    ('REGISTRO DE RESULTADO PARA ATENCION MEDICA', 1),
    ('CANCELAR ATENCION MEDICA', 1),
    ('LISTADO ESTADISTICO', 1),
    ('ASIGNAR Nº AFILIADOS A AFILIADOS MIGRADOS',1)

go

--FUNCIONALIDAD POR ROL
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.FUNCIONALIDAD_POR_ROL
values 
    (1,3),
    (2,1),
    (2,2),
    (2,3),
    (3,3),
    (4,3),
    (5,3),
    (6,3),
    (7,3),
    (8,1),
    (9,2),
    (10,2),
    (11,3),
    (12,1),
    (13,2),
    (13,1),
    (14,3),
    (15,3)

go

--TIPO DOCUMENTO
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.TIPO_DOCUMENTO
values ('DNI')

go

--TIPO DE CANCELACIONES
-------------------------------------------------------------------------------------------------------
INSERT INTO BEMVINDO.TIPO_CANCELACION
(descripcion)
VALUES ('Licencia')

INSERT INTO BEMVINDO.Tipo_Cancelacion
(descripcion)
VALUES ('Sin justificacion')

INSERT INTO BEMVINDO.Tipo_Cancelacion
(descripcion)
VALUES ('Compromisos Personales')

INSERT INTO BEMVINDO.Tipo_Cancelacion
(descripcion)
VALUES ('Fallecimiento')

INSERT INTO BEMVINDO.Tipo_Cancelacion
(descripcion)
VALUES ('Problemas de salud')

INSERT INTO BEMVINDO.Tipo_Cancelacion
(descripcion)
VALUES ('Conflicto gremial')

INSERT INTO BEMVINDO.Tipo_Cancelacion
(descripcion)
VALUES ('Problemas Renales')

INSERT INTO BEMVINDO.Tipo_Cancelacion
(descripcion)
VALUES ('CIRUGIA ORTOMOLECULAR')

INSERT INTO BEMVINDO.Tipo_Cancelacion
(descripcion)
VALUES ('Otro')

go
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
        1,
        Paciente_Nombre,
        UPPER(Paciente_Apellido),
        1,
        Paciente_Dni,
        Paciente_Fecha_Nac,
        UPPER(Paciente_Direccion),
        Paciente_Telefono,
        Paciente_Mail,
        null    
    from gd_esquema.Maestra
    where 
        Consulta_Sintomas is null and
        Compra_Bono_Fecha is null

go

--profesionales
insert into BEMVINDO.USUARIO
    select distinct
        Medico_Dni,
        Medico_Dni,
        0,
        1,
        Medico_Nombre,
        UPPER(Medico_Apellido),
        1,
        Medico_Dni,
        Medico_Fecha_Nac,
        UPPER(Medico_Direccion),
        Medico_Telefono,
        Medico_Mail,
        null    
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
        0,
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

--PROFESIONAL
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.PROFESIONAL
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

--ESPECIALIDAD_POR_PROFESIONAL
-------------------------------------------------------------------------------------------------------
insert into BEMVINDO.ESPECIALIDAD_POR_PROFESIONAL
    select distinct
        E.id_especialidad,
        P.id_usuario
    from gd_esquema.Maestra as M
    inner join BEMVINDO.USUARIO as P on M.Medico_Dni = P.documento
    inner join BEMVINDO.ESPECIALIDAD as E on M.Especialidad_Codigo = E.especialidad_codigo
    where
        Turno_Numero is not null and
        Consulta_Sintomas is null
go

--TURNO
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.TURNO
add turno_numero numeric(18,0)

go

insert into BEMVINDO.TURNO
    select
        A.id_usuario as afiliado,
        P.id_usuario as profesional,
        E.id_especialidad,
        M.Turno_Fecha,
        M.Turno_Fecha,
        1,
        M.Turno_Numero
    from gd_esquema.Maestra as M
    inner join BEMVINDO.USUARIO as A on M.Paciente_Dni = A.documento
    inner join BEMVINDO.USUARIO as P on M.Medico_Dni = P.documento
    inner join BEMVINDO.ESPECIALIDAD as E on M.Especialidad_Codigo = E.especialidad_codigo
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
        M.Turno_Fecha,
        M.Bono_Consulta_Numero
    from gd_esquema.Maestra as M
    inner join BEMVINDO.TURNO as T on M.Turno_Numero = T.turno_numero
    where 
        M.Bono_Consulta_Numero is not null and
        M.Compra_Bono_Fecha is null

go

--COMPRA
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.COMPRA
add compra_numero numeric(18,0)

go

insert into BEMVINDO.COMPRA
    select 
        U.id_usuario as  afiliado,
        1 as cantidad,
        M.Plan_Med_Precio_Bono_Consulta,
        M.Compra_Bono_Fecha,
        M.Bono_Consulta_Numero
    from gd_esquema.Maestra as M
    inner join BEMVINDO.USUARIO as U
        on U.documento = M.Paciente_Dni
    where 
        M.Turno_Numero is null
go

--BONO
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.BONO
add bono_numero numeric(18,0)

go

insert into BEMVINDO.BONO
    select 
        P.id_plan_medico,
        C.id_compra,
        T.id_turno,
        M.Bono_Consulta_Numero
    from gd_esquema.Maestra as M
    inner join BEMVINDO.PLAN_MEDICO as P on M.Plan_Med_Codigo = P.plan_medico_codigo
    inner join BEMVINDO.COMPRA as C on M.Bono_Consulta_Numero = C.compra_numero
    inner join BEMVINDO.TURNO as T on M.Turno_Numero = T.turno_numero
    where 
        M.Bono_Consulta_Numero is not null and
        M.Compra_Bono_Fecha is null

go

--ROL_POR_USUARIO
-------------------------------------------------------------------------------------------------------

--afiliados
insert into BEMVINDO.ROL_POR_USUARIO
    select 
        2,
        id_afiliado
    from BEMVINDO.AFILIADO

go

--profesionales
insert into BEMVINDO.ROL_POR_USUARIO
    select 
        1,
        id_profesional
    from BEMVINDO.PROFESIONAL

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

--COMPRA
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.COMPRA
drop column compra_numero

go

--BONO
-------------------------------------------------------------------------------------------------------
alter table BEMVINDO.BONO
drop column bono_numero

go

/********************************************************************************************************************************/
/*CREACION DEL USUARIO CON TODOS LOS PERMISOS*/
/********************************************************************************************************************************/

insert into BEMVINDO.USUARIO
values('admin','w23e',0,1,null,null,null,null,null,null,null,null,null)

go

insert into BEMVINDO.AFILIADO
values(5579, null, 1, null, 0, 101)

go

insert into BEMVINDO.PROFESIONAL
values(5579, null)

go

insert into BEMVINDO.ROL_POR_USUARIO
values 
    (1,5579),
    (2,5579),
    (3,5579)

go

/********************************************************************************************************************************/
/*CREACION DE PROCEDIMIENTOS PARA LA APLICACION*/
/********************************************************************************************************************************/

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------ABM AFILIADO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------
create procedure BEMVINDO.st_insertar_afiliado
@nro_grupo_familiar char(4),
@estado_civil numeric(10,0),
@plan_medico numeric(10,0),
@nombre  nvarchar(255),
@apellido    nvarchar(255),
@tipo_documento  numeric(10,0),  
@documento   nvarchar(12),
@fecha_nacimiento    date,
@direccion   nvarchar(255),
@telefono    nvarchar(255),
@mail    nvarchar(255),
@sexo    char,
@nro_raiz numeric(10,0) --cero

AS
begin
     declare @nroAfiliado numeric(10,0)
     declare @id_numerito numeric(10,0)
     declare @error varchar(255) 
     declare @idUsuario numeric(10,0)
     set @error = ''
     BEGIN TRANSACTION  
     BEGIN TRY


     select @id_numerito =max(numero_afiliado) from BEMVINDO.AFILIADO
     set @id_numerito= (@id_numerito/100)

      if(@nro_grupo_familiar='01')
      begin
           set @id_numerito= (@id_numerito+1)
      end

     select @nroAfiliado =  Concat(@id_numerito,@nro_grupo_familiar)
           

    insert into BEMVINDO.USUARIO(nick,pass,intentos_login,activo,nombre,apellido,tipo_documento,
                documento,fecha_nacimiento,direccion,telefono,mail,sexo)
        values (@documento,@documento,0,1,@nombre,@apellido,@tipo_documento,@documento,@fecha_nacimiento,@direccion,
               @telefono,@mail,@sexo)

    select @idUsuario =max(id_usuario) from BEMVINDO.USUARIO

    insert into BEMVINDO.AFILIADO(id_afiliado,estado_civil,plan_medico,baja_logica,numero_afiliado)
        values (@idUsuario,@estado_civil,@plan_medico,0,@nroAfiliado)

    insert into BEMVINDO.ROL_POR_USUARIO
      values 
    (2,@idUsuario)           


     COMMIT TRAN  
     END TRY 
     BEGIN CATCH  
     ROLLBACK TRAN 
     set @error = 'Error, no se pudo cargar el usuario'
     END CATCH 


     select @documento as nick,@documento as pass,@nroAfiliado as id_afiliado,@error as error

end



go

create procedure BEMVINDO.st_baja_afiliado
@id_afiliado numeric(10,0),
@fecha_baja date

AS
begin

     update BEMVINDO.AFILIADO SET baja_logica = 1, fecha_baja=@fecha_baja 
     where numero_afiliado = @id_afiliado

end


go

create procedure BEMVINDO.st_actualizar_afiliado
@id_afiliado numeric(10,0),
@id_usuario     numeric(10,0),
@direccion   nvarchar(255),
@telefono    nvarchar(255),
@mail    nvarchar(255),
@plan_medico numeric(10,0),
@motivo     nvarchar(255),
@fecha_sistema      date

AS
begin

     update BEMVINDO.USUARIO SET direccion = @direccion, telefono=@telefono,mail=@mail
     where id_usuario = @id_usuario


     if(@plan_medico is not null)
     begin
         insert into BEMVINDO.HISTORIAL_CAMBIOS_DE_PLAN values
         (@plan_medico,@id_afiliado,@motivo,@fecha_sistema)
         

         update BEMVINDO.AFILIADO SET plan_medico=@plan_medico
         where id_afiliado = @id_afiliado             
     end     

end

go

create procedure BEMVINDO.buscar_historial_de_cambios
@id_afiliado numeric(10,0)

AS
begin

     select * 
     FROM BEMVINDO.HISTORIAL_CAMBIOS_DE_PLAN
     inner join BEMVINDO.PLAN_MEDICO on id_plan_medico = plan_medico
     where afiliado = @id_afiliado

end


go

create procedure BEMVINDO.st_buscar_afiliados
@nroAfiliado numeric(10,0)=null,
@nombre      nvarchar(255)=null,
@apellido    nvarchar(255)=null,
@dni         nvarchar(12)=null,
@planMedico  numeric(10,0)=null --id_plan_medico

AS
begin

      select *
      from BEMVINDO.USUARIO
      inner join BEMVINDO.AFILIADO on id_usuario = id_afiliado
      where (numero_afiliado = @nroAfiliado OR @nroAfiliado IS NULL) and
            (nombre = @nombre OR @nombre IS NULL) and
            (apellido = @apellido OR @apellido IS NULL) and
            (documento = @dni OR @dni IS NULL) and
            (plan_medico = @planMedico OR @planMedico IS NULL) 

end


go
-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------ABM AFILIADO ----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------REGSITRAR AGENDA MEDICO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

create procedure BEMVINDO.sp_agenda_del_profesional 
    @id_profesional numeric(10,0)
as begin
    select 
        A.id_agenda,
        A.fecha_inicial,
        A.fecha_final,
        E.id_especialidad as id_especialidad,
        E.descripcion as especialidad,
        D.dia,
        D.horario_inicial,
        D.horario_final
    from BEMVINDO.AGENDA as A
    inner join BEMVINDO.DIA_AGENDA as D on A.id_agenda = D.agenda
    inner join BEMVINDO.ESPECIALIDAD as E on D.especialidad = E.id_especialidad
    where 
        A.profesional = @id_profesional
end

go

create procedure BEMVINDO.sp_nombre_de_especialidades_del_profesional
    @id_profesional numeric(10,0)
as begin
    select 
        E.id_especialidad,
        E.descripcion
    from BEMVINDO.ESPECIALIDAD_POR_PROFESIONAL as EP
    inner join BEMVINDO.ESPECIALIDAD as E on E.id_especialidad = EP.id_especialidad
    where 
        Ep.id_profesional = @id_profesional
end

go

create procedure BEMVINDO.sp_insertar_nueva_agenda
    @id_profesional numeric(10,0),
    @fecha_inicial date,
    @fecha_final date
as begin
    insert into BEMVINDO.AGENDA
    values (@id_profesional, @fecha_inicial, @fecha_final)

    select id_agenda
    from BEMVINDO.AGENDA
    where profesional = @id_profesional
end

go

create procedure BEMVINDO.sp_insertar_nuevo_dia_agenda
    @id_agenda numeric(10,0),
    @id_especialidad numeric(10,0),
    @dia nvarchar(10),
    @hora_inicial time,
    @hora_final time
as begin
    insert into BEMVINDO.DIA_AGENDA
    values (@id_agenda, @id_especialidad, @dia, @hora_inicial, @hora_final)
end

go

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------REGSITRAR AGENDA MEDICO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------COMPRAR BONO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

CREATE procedure BEMVINDO.st_insertar_compra

@comprador numeric(10,0),
@cantidad numeric(3,0),
@monto    numeric(5,2),
@fecha_compra  datetime,

@id_compra numeric(10,0) output
AS
begin

        insert into BEMVINDO.COMPRA(comprador,cantidad,monto,fecha_compra )
        values (@comprador,@cantidad,@monto,@fecha_compra)
        SET @id_compra = SCOPE_IDENTITY();



end


go


CREATE procedure BEMVINDO.st_insertar_bono
@plan_medico numeric(10,0),
@compra      numeric(10,0)

AS
begin

        insert into BEMVINDO.BONO(plan_medico,compra)
        values (@plan_medico,@compra)

end


go

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------PEDIDO DE TURNOS-----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------



CREATE procedure BEMVINDO.st_insertar_turno
@id_afiliado    numeric(10,0),
@profesional    numeric(10,0),
@especialidad   numeric(10,0),
@fecha_turno    datetime

AS
begin
     declare @idAgenda numeric(10,0)

     select @idAgenda =id_agenda from BEMVINDO.AGENDA
     where profesional=@profesional


      if EXISTS (SELECT * FROM BEMVINDO.TURNO WHERE
                                                   profesional=@profesional and
                                                   especialidad=@especialidad and
                                                   fecha_turno=@fecha_turno and
                                                   activo=1)
      begin
           select 'ERROR: el turno ya se encuentra ocupado en el horario seleccionado.' as resultado
      end
      else
      if EXISTS (SELECT * FROM BEMVINDO.CANCELACION_DIA WHERE
                                                   agenda = @idAgenda and
                                                   ((CONVERT(date, @fecha_turno) between cancelacion_desde and cancelacion_hasta)))

      begin
           select 'ERROR: El profesional cancelo sus turnos en el dia seleccionado.' as resultado
      end
      else
      begin
          insert into BEMVINDO.TURNO(afiliado,profesional,especialidad,fecha_turno,activo)
          values (@id_afiliado,@profesional,@especialidad,@fecha_turno,1)

          DECLARE @idTurno numeric (10,0) = SCOPE_IDENTITY()
          select Concat('Turno generado exitosamente. ID de turno: ',@idTurno) as resultado

      end

end





go

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------PEDIDO DE TURNOS----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------REGISTRO DE LLEGADA PARA ATENCION MEDICA----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

--store para buscar profesional por nombre,apellido,matricula y especialidad
create procedure BEMVINDO.st_buscar_profesional
@profesional numeric(10,0)=null,
@nombre nvarchar(50)=null,
@apellido nvarchar(255)=null,
@matricula nvarchar(30)=null,
@especialidad numeric(10,0)=null
as
begin

    select * from BEMVINDO.USUARIO as u
    inner join BEMVINDO.PROFESIONAL as p on u.id_usuario=p.id_profesional
    inner join BEMVINDO.ESPECIALIDAD_POR_PROFESIONAL as e on p.id_profesional=e.id_profesional
    where (p.id_profesional=@profesional or @profesional is null) and 
          (u.apellido=@apellido or @apellido is null) and (p.matricula=@matricula or @matricula is null) and
          (e.id_especialidad=@especialidad or @especialidad is null) and (u.nombre=@nombre or @nombre is null)
end

go

create procedure BEMVINDO.st_obtener_turnos
@profesional numeric(10,0),
@especialidad   numeric(10,0)=null,
@fecha_sistema datetime

AS
begin

     select * from BEMVINDO.TURNO
     where profesional =@profesional and CONVERT(date, fecha_turno)= CONVERT(date, @fecha_sistema)
      and (especialidad=@especialidad or @especialidad is null)


end

go

create procedure BEMVINDO.st_registrar_fecha_llegada
@id_turno numeric(10,0),
@id_bono numeric(10,0),
@fecha_llegada datetime

AS
begin

    UPDATE BEMVINDO.TURNO
    SET fecha_llegada = @fecha_llegada
    WHERE id_turno = @id_turno

    UPDATE BEMVINDO.BONO
    SET turno = @id_turno
    WHERE id_bono = @id_bono

end


go

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------REGISTRO DE LLEGADA PARA ATENCION MEDICA----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------RESULTADOS PARA ATENCION MEDICA----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

create procedure BEMVINDO.st_registrar_consulta
@id_turno               numeric(10,0),
@sintoma                nvarchar(255),
@enfermedad             nvarchar(255),
@fecha_diagnostico      datetime

AS
begin

    insert into BEMVINDO.CONSULTA(turno,sintoma,enfermedad,fecha_diagnostico)
     values (@id_turno,@sintoma,@enfermedad,@fecha_diagnostico)

end

go

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------RESULTADOS PARA ATENCION MEDICA----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------CANCELAR ATENCION MEDICA POR PARTE DEL AFILIADO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

create procedure BEMVINDO.st_cancelar_turno_afiliado
@tipo_cancelacion   numeric(10,0),
@turno              numeric(10,0),
@motivo             nvarchar(255),
@fecha_sistema      datetime

AS
begin

       UPDATE BEMVINDO.TURNO
       SET
       activo=0
       where  id_turno=@turno and activo =1

    insert into BEMVINDO.CANCELACION(tipo_cancelacion,turno,fecha,motivo,tipo_usuario)
     values (@tipo_cancelacion,@turno,@fecha_sistema,@motivo,'A')


end

go

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------CANCELAR ATENCION MEDICA POR PARTE DEL AFILIADO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------CANCELAR ATENCION MEDICA POR PARTE DEL MEDICO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------


create procedure BEMVINDO.st_cancelar_turno_medico 
@tipo_cancelacion   numeric(10,0),
@profesional        numeric(10,0),
@motivo             nvarchar(255),
@fecha_sistema      datetime,
@tipo_usuario       char,
@cancelacion_desde  date,
@cancelacion_hasta  date

AS
begin

declare @id_turno numeric(10,0)
declare @id_agenda numeric(10,0)

 declare miCursor cursor
  for select id_turno
  from BEMVINDO.TURNO
  where  profesional=@profesional and (CONVERT(date, fecha_turno) between @cancelacion_desde and @cancelacion_hasta)
         and activo =1

   select @id_agenda =id_agenda from BEMVINDO.AGENDA
    where profesional=@profesional 

  insert into BEMVINDO.CANCELACION_DIA(agenda,cancelacion_desde,cancelacion_hasta)
    values (@id_agenda,@cancelacion_desde,@cancelacion_hasta)
  

  open miCursor
  fetch next from miCursor into @id_turno

 while @@fetch_status=0
 begin
 
    insert into BEMVINDO.CANCELACION(tipo_cancelacion,turno,fecha,motivo,tipo_usuario)
     values (@tipo_cancelacion,@id_turno,@fecha_sistema,@motivo,'M')

    UPDATE BEMVINDO.TURNO
      SET
      activo=0
     where  id_turno=@id_turno and activo =1

    fetch next from miCursor into @id_turno

 end

end

go
-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------CANCELAR ATENCION MEDICA POR PARTE DEL MEDICO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------LISTADO ESTADISTICO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------el enunciado se refiere a que el usuario deberia seleccionar el año, el semestre y luego el mes dentro del mismo.---------------------------------------------------------------------------------------------------------------------


--1
create procedure BEMVINDO.st_top5_especialidades_mas_canceladas
@mes int,
@anio int

AS BEGIN
 
select top 5 id_especialidad,descripcion,count(*) as cant_cancelaciones
FROM BEMVINDO.TURNO
inner join BEMVINDO.CANCELACION on turno = id_turno
inner join BEMVINDO.ESPECIALIDAD on especialidad = id_especialidad
 where year(fecha)= @anio and (month(fecha)=@mes) and activo=0
 group by id_especialidad,descripcion
 order by cant_cancelaciones desc

 end

 go

 --2
 create procedure BEMVINDO.st_top5_profesionales_mas_consultados
@mes int,
@anio int,
@plan_medico numeric(10,0)=null

AS BEGIN
 
select top 5 profesional, nombre, apellido, sum(turno) as cant_de_consultas
FROM BEMVINDO.USUARIO
inner join BEMVINDO.PROFESIONAL on id_usuario = id_profesional
inner join BEMVINDO.TURNO on profesional = id_profesional
inner join BEMVINDO.BONO on id_turno = turno
 where year(fecha_llegada)= @anio and (month(fecha_llegada)=@mes) and (@plan_medico=plan_medico or @plan_medico is null)
 group by profesional, nombre, apellido
 order by cant_de_consultas desc

 end

 go

--3
 create procedure BEMVINDO.st_top5_profesionales_menos_horas_trabajdas
@mes int,
@anio int,
@especialidad numeric(10,0)=null

AS BEGIN
 
select top 5 profesional,nombre, apellido, count(turno)*0.5 as cant_horas_trabajadas
FROM BEMVINDO.USUARIO
inner join BEMVINDO.PROFESIONAL on id_usuario = id_profesional
inner join BEMVINDO.TURNO on profesional = id_profesional
inner join BEMVINDO.CONSULTA on id_turno = turno
 where year(fecha_diagnostico)= @anio and (month(fecha_diagnostico)=@mes) and (@especialidad=especialidad or @especialidad is null)
 group by profesional,nombre, apellido
 order by cant_horas_trabajadas asc

 end


 go

--4
create procedure BEMVINDO.st_top5_afiliados_mas_bonos_comprados
@mes int,
@anio int

AS BEGIN
 
select top 5 comprador,numero_afiliado, nombre, apellido, sum(cantidad) as cant_bonos_comprados
FROM BEMVINDO.USUARIO
inner join BEMVINDO.AFILIADO on id_usuario = id_afiliado
inner join BEMVINDO.COMPRA on id_afiliado = comprador
 where year(fecha_compra)= @anio and (month(fecha_compra)=@mes)
 group by comprador,numero_afiliado, nombre, apellido
 order by cant_bonos_comprados desc

 end


 go

--5
create procedure BEMVINDO.st_top5_especialidades_mas_bonos_consulta
@mes int,
@anio int

AS BEGIN
 
select top 5 id_especialidad,descripcion,count(*) as cant_bonos_utilizados
FROM BEMVINDO.TURNO
inner join BEMVINDO.BONO on turno = id_turno
inner join BEMVINDO.ESPECIALIDAD on especialidad = id_especialidad
 where year(fecha_llegada)= @anio and (month(fecha_llegada)=@mes) and activo=1
 group by id_especialidad,descripcion
 order by cant_bonos_utilizados desc

 end

 go
-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------LISTADO ESTADISTICO----------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------USUARIO LOGUIN----------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------

create procedure BEMVINDO.VERIFICAR_LOGUEO
    @nick nvarchar(255), 
    @pass nvarchar(255)
as begin
    
    declare @filas int;
    declare @intentos_login int

    select top 1 @filas = COUNT(id_usuario)
    from BEMVINDO.USUARIO
    where 
        nick = @nick and 
        pass = BEMVINDO.fn_hashear_pass(@pass);

    if(@filas = 0) begin
        update BEMVINDO.USUARIO
        set intentos_login = (intentos_login +1)
        where nick = @nick;

        update BEMVINDO.USUARIO
        set activo=0
        where nick = @nick and intentos_login>=3
    end
    else begin
        update BEMVINDO.USUARIO
        set intentos_login = 0
        where nick = @nick;
    end

    select *
    from BEMVINDO.USUARIO as u
    where 
        u.nick = @nick and 
        u.pass = BEMVINDO.fn_hashear_pass(@pass)
end

go

    create PROCEDURE BEMVINDO.st_dar_de_baja_usuario(@nick nvarchar(255))
    AS BEGIN
        UPDATE USUARIO SET
        activo = 0
        WHERE nick=@nick
    END
    GO

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------ABM GRUPO AFILIADO VIEJO--------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------


create procedure BEMVINDO.sp_afiliados_sin_numero_afiliado
as begin
    select 
        A.id_afiliado as ID,
        U.documento as DNI,
        U.nombre as NOMBRE,
        U.apellido AS APELLIDO
    from BEMVINDO.USUARIO as U
    inner join BEMVINDO.AFILIADO as A on A.id_afiliado = U.id_usuario
    where A.numero_afiliado is null
end

go

create procedure BEMVINDO.sp_agregar_numero_afiliado_a_afiliado_principal_migrado
    @id_principal numeric(10,0)
as begin 
    
    declare @numero_nuevo_grupo numeric(10,0)

    select @numero_nuevo_grupo = MAX(numero_afiliado)
    from BEMVINDO.AFILIADO
    where numero_afiliado is not null

    update BEMVINDO.AFILIADO
    set numero_afiliado = ((@numero_nuevo_grupo%100) * 100 + 101)
    where id_afiliado = @id_principal
end

go

create procedure BEMVINDO.sp_agregar_numero_afiliado_a_conyuge_migrado
    @id_conyuge numeric(10,0),
    @id_principal numeric(10,0)
as begin 
    
    declare @numero_grupo numeric(10,0)

    select @numero_grupo = numero_afiliado
    from BEMVINDO.AFILIADO
    where id_afiliado = @id_principal

    update BEMVINDO.AFILIADO
    set numero_afiliado = ((@numero_grupo%100)+1)*100 + 2
    where id_afiliado = @id_conyuge
end

go

create procedure BEMVINDO.sp_agregar_numero_afiliado_a_hijo_migrado
    @id_hijo numeric(10,0),
    @id_principal numeric(10,0)
as begin 
    
    declare 
        @numero_principal numeric(10,0),
        @numero_hijo numeric(10,0)

    select @numero_principal = numero_afiliado
    from BEMVINDO.AFILIADO
    where id_afiliado = @id_principal

    select @numero_hijo = MAX(numero_afiliado)
    from BEMVINDO.AFILIADO
    where numero_afiliado between ((@numero_principal%100)+1)*100 and ((@numero_principal%100)+1)*100 +99

    update BEMVINDO.AFILIADO
    set numero_afiliado = 
        case 
            when @numero_hijo+1 = ((@numero_principal%100)+1)*100 +2 then @numero_hijo+2
            else @numero_hijo+1
        end
    where id_afiliado = @id_hijo
end

