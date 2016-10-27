
-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------ABM AFILIADO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------
create procedure BEMVINDO.st_insertar_afiliado
@nro_grupo_familiar char(4),
@estado_civil numeric(10,0),
@plan_medico numeric(10,0),
@cantidad_hijos smallint,
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
     declare @idAfiliado numeric(10,0)
	 declare @id_numerito numeric(10,0)
	 declare @error varchar(255) 
	 declare @idUsuario numeric(10,0)
	 set @error = ''
	 BEGIN TRANSACTION  
     BEGIN TRY


     select @id_numerito =max(id_afiliado) from BEMVINDO.AFILIADO
     set @id_numerito= (@id_numerito/100)

	  if(@nro_grupo_familiar='01')
	  begin
	       set @id_numerito= (@id_numerito+1)
	  end

	 select @idAfiliado =  Concat(@id_numerito,@nro_grupo_familiar)
		   

	insert into BEMVINDO.USUARIO(nick,pass,intentos_login,activo,nombre,apellido,tipo_documento,
				documento,fecha_nacimiento,direccion,telefono,mail,sexo)
	    values (@documento,@documento,0,1,@nombre,@apellido,@tipo_documento,@documento,@fecha_nacimiento,@direccion,
		       @telefono,@mail,@sexo)

	select @idUsuario =max(id_usuario) from BEMVINDO.USUARIO

		
	insert into BEMVINDO.AFILIADO(id_afiliado,usuario,estado_civil,plan_medico,cantidad_hijos)
	    values (@idAfiliado,@idUsuario,@estado_civil,@plan_medico,@cantidad_hijos)


	 COMMIT TRAN  
     END TRY 
     BEGIN CATCH  
     ROLLBACK TRAN 
     set @error = 'Error, no se pudo cargar el usuario'
     END CATCH 


     select @documento as nick,@documento as pass,@idAfiliado as id_afiliado,@error as error

end


go

create procedure BEMVINDO.st_buscar_afiliados
@id_afiliado numeric(10,0)

AS
begin

      select *
      from BEMVINDO.USUARIO
      inner join BEMVINDO.AFILIADO on id_usuario = usuario
	  where (id_afiliado = @id_afiliado OR @id_afiliado IS NULL) 

end

go

create procedure BEMVINDO.st_baja_afiliado
@id_afiliado numeric(10,0),
@fecha_baja date

AS
begin

	 update BEMVINDO.AFILIADO SET baja_logica = 1, fecha_baja=@fecha_baja 
	 where id_afiliado = @id_afiliado

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
-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------ABM AFILIADO AGENDA PROFESIONAL----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------REGISTRAR AGENDA PROFESIONAL----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

CREATE procedure BEMVINDO.st_insertar_agenda
@profesional    numeric(10,0),
@fecha_desde    date,
@fecha_hasta    date,
@id_agenda      numeric(10,0) out
AS
begin
	 
	 	insert into BEMVINDO.AGENDA(profesional,fecha_desde,fecha_hasta)
	    values (@profesional,@fecha_desde,@fecha_hasta)

	    set @id_agenda = scope_identity()

end


go

CREATE procedure BEMVINDO.st_insertar_dia
@id_agenda      numeric(10,0),
@especialidad   numeric(10,0),
@dia            nvarchar(10),
@hora_desde     time,
@hora_hasta     time

AS
begin
	 
	 	insert into BEMVINDO.DIA_AGENDA(especialidad,dia,hora_desde,hora_hasta)
	    values (@especialidad,@dia,@hora_desde,@hora_hasta)

end


go


-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------REGISTRAR AGENDA PROFESIONAL----------------------------------------------------------------------------------------------
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
@compra      numeric(10,0),
@turno       numeric(10,0)

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
@afiliado       numeric(10,0),
@profesional    numeric(10,0),
@especialidad   numeric(10,0),
@fecha_turno    datetime

AS
begin
	 
	 	insert into BEMVINDO.TURNO(afiliado,profesional,especialidad,fecha_turno,activo)
	    values (@afiliado,@profesional,@especialidad,@fecha_turno,1)

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
@profesional numeric(10,0),
@nombre nvarchar(50),
@apellido nvarchar(255),
@matricula nvarchar(30),
@especialidad numeric(10,0)
as
begin

	select * from BEMVINDO.USUARIO as u
	inner join BEMVINDO.PROFESIONAL as p on u.id_usuario=p.usuario
	inner join BEMVINDO.ESPECIALIDAD_POR_PROFESIONAL as e on p.id_profesional=e.id_profesional
	where (p.id_profesional=@profesional or @profesional is null) and 
		  (u.apellido=@apellido or @apellido is null) and (p.matricula=@matricula or @matricula is null) and
		  (e.id_especialidad=@especialidad or @especialidad is null) and (u.nombre=@nombre or @nombre is null)
end

go

create procedure BEMVINDO.st_obtener_turnos
@profesional numeric(10,0),
@especialidad   numeric(10,0),
@fecha_sistema datetime

AS
begin

	 select * from BEMVINDO.TURNO
	 where profesional =@profesional and CONVERT(date, fecha_turno)= CONVERT(date, @fecha_sistema)
	  and especialidad=@especialidad


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


create procedure BEMVINDO.st_cancelar_turno_medico -- hay q cambiarlo para q sea por un rango de fechas
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

    fetch next from miCursor into @id_turno

 end

end

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------CANCELAR ATENCION MEDICA POR PARTE DEL MEDICO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------LISTADO ESTADISTICO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------LISTADO ESTADISTICO----------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------USUARIO----------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------

create procedure BEMVINDO.VERIFICAR_LOGUEO
	@nick nvarchar(255), 
	@pass nvarchar(255)
as begin
	
	declare @filas int;

	select top 1 @filas = COUNT(id_usuario)
	from BEMVINDO.USUARIO
	where 
		nick = @nick and 
		pass = BEMVINDO.fn_hashear_pass(@pass);

	if(@filas = 0) begin
		update BEMVINDO.USUARIO
		set intentos_login = (intentos_login +1)
		where nick = @nick;
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
		u.pass = BEMVINDO.fn_hashear_pass(@pass) and
		u.activo = 1;
end

go

	CREATE PROCEDURE BEMVINDO.st_dar_de_baja_usuario(@nick nvarchar(255))
	AS BEGIN
		UPDATE USUARIO SET
		activo = 0
		WHERE nick=@nick
	END
	GO

