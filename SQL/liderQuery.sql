
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
@sexo    char

AS
begin
     declare @idUsuario numeric(10,0)
	 declare @id_numerito numeric(10,0)
	 declare @error varchar(255) 
	 set @error = ''
	 BEGIN TRANSACTION  
     BEGIN TRY


     select @id_numerito =max(id_usuario) from BEMVINDO.USUARIO
     set @id_numerito= (@id_numerito/100)

	  if(@nro_grupo_familiar='01')
	  begin
	       set @id_numerito= (@id_numerito+1)
	  end
	       
	    
	 select @idUsuario =  Concat(@id_numerito,@nro_grupo_familiar)
		   
	  
	 
	 	insert into BEMVINDO.USUARIO(id_usuario,nick,pass,intentos_login,activo,nombre,apellido,tipo_documento,
				documento,fecha_nacimiento,direccion,telefono,mail,sexo
					   )
	    values (@idUsuario,@documento,@documento,0,1,@nombre,@apellido,@tipo_documento,@documento,@fecha_nacimiento,@direccion,
		       @telefono,@mail,@sexo)

		

	insert into BEMVINDO.AFILIADO(id_afiliado,nro_grupo_familiar,estado_civil,plan_medico,cantidad_hijos)
	values (@idUsuario,@nro_grupo_familiar,@estado_civil,@plan_medico,@cantidad_hijos)

	 COMMIT TRAN  
     END TRY 
     BEGIN CATCH  
     ROLLBACK TRAN 
     set @error = 'Error, no se pudo cargar el usuario'
     END CATCH 


     select @documento as nick,@documento as pass,@idUsuario as id_afiliado,@error as error

end


go

go

create procedure BEMVINDO.st_buscar_afiliados
@id_afiliado numeric(10,0)

AS
begin

      select *
      from BEMVINDO.USUARIO
      inner join BEMVINDO.AFILIADO on id_usuario = id_afiliado
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
@direccion   nvarchar(255),
@telefono    nvarchar(255),
@mail    nvarchar(255),
@plan_medico numeric(10,0),
@motivo    nvarchar(255),
@fecha date

AS
begin

	 update BEMVINDO.USUARIO SET direccion = @direccion, telefono=@telefono,mail=@mail
	 where id_usuario = @id_afiliado


	 if(@plan_medico is not null)
	 begin
	  	 insert into BEMVINDO.HISTORIAL_CAMBIOS_DE_PLAN values
	  	 (@plan_medico,@id_afiliado,@motivo,@fecha)
	     

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

CREATE procedure BEMVINDO.st_insertar_turno
@profesional    numeric(10,0),
@especialidad   numeric(10,0),
@fecha_turno    datetime

AS
begin
	 
	 	insert into BEMVINDO.TURNO(profesional,especialidad,fecha_turno,activo)
	    values (@profesional,@especialidad,@fecha_turno,1)

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

CREATE procedure BEMVINDO.st_buscar_turnos_disponibles

@especialidad   numeric(10,0),
@profesional    numeric(10,0),
@fecha_sistema  datetime

AS
begin

	 	select * 
	 	from BEMVINDO.TURNO
	 	where profesional = @profesional and especialidad= @especialidad 
	 	and fecha_turno>= @fecha_sistema and activo= 1 and afiliado is null


end


go


CREATE procedure BEMVINDO.st_actualizar_turno
@id_turno      numeric(10,0),
@afiliado      numeric(10,0)

AS
begin

	UPDATE BEMVINDO.TURNO
	SET afiliado = @afiliado
	WHERE id_turno = @id_turno

end


go

-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------PEDIDO DE TURNOS----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------REGISTRO DE LLEGADA PARA ATENCION MEDICA----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

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

create procedure BEMVINDO.st_cancelar_turno_medico
@tipo_cancelacion   numeric(10,0),
@profesional        numeric(10,0),
@motivo             nvarchar(255),
@fecha_sistema      datetime,
@fecha_cancelar     date,
@tipo_usuario       char

AS
begin

declare @id_turno numeric(10,0)

 declare miCursor cursor
  for select id_turno
  from BEMVINDO.TURNO
  where  profesional=@profesional and CONVERT(date, fecha_turno) =@fecha_cancelar and activo =1

  	   UPDATE BEMVINDO.TURNO
	   SET
	   activo=0
	   where  profesional=@profesional and CONVERT(date, fecha_turno) =@fecha_cancelar and activo =1

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
