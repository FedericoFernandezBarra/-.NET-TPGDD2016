CREATE procedure XXX.st_insertar_afiliado

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

@error varchar(3) output
AS
begin
     declare @idUsuario numeric(10,0)
	 declare @id_numerito numeric(10,0)
	 set @error = 't'
	 BEGIN TRANSACTION  
     BEGIN TRY

	  if(@nro_grupo_familiar='01')
	  begin
	       insert into XXX.NUMERITOS(algo)
	       values ('p')
	       select @id_numerito =max(id_numerito) from XXX.NUMERITOS
		   select @idUsuario =  Concat(@id_numerito,@nro_grupo_familiar)
		   
	  end

	  if(@nro_grupo_familiar<>'01')
	  begin
	       select @id_numerito =max(id_numerito) from XXX.NUMERITOS
		   select @idUsuario =  Concat(@id_numerito,@nro_grupo_familiar)
	  end
	  
	 
	 	insert into XXX.USUARIO(id_usuario,nick,pass,intentos_login,activo,nombre,apellido,tipo_documento,
				documento,fecha_nacimiento,direccion,telefono,mail,sexo
					   )
	    values (@idUsuario,@documento,'pass',0,1,@nombre,@apellido,@tipo_documento,@documento,@fecha_nacimiento,@direccion,
		       @telefono,@mail,@sexo)

		

	insert into XXX.AFILIADO(id_afiliado,nro_grupo_familiar,estado_civil,plan_medico,cantidad_hijos)
	values (@idUsuario,@nro_grupo_familiar,@estado_civil,@plan_medico,@cantidad_hijos)

	 COMMIT TRAN  
     END TRY 
     BEGIN CATCH  
     ROLLBACK TRAN 
     set @error = 'e'
     END CATCH 

end


go

create procedure XXX.st_buscar_afiliados
@id_afiliado numeric(10,0)

AS
begin

      select *
      from XXX.USUARIO
      inner join XXX.AFILIADO on id_usuario = id_afiliado
	  where (id_afiliado = @id_afiliado OR @id_afiliado IS NULL) 

end

go

create procedure XXX.st_baja_afiliado
@id_afiliado numeric(10,0),
@fecha_baja date

AS
begin

	 update XXX.AFILIADO SET baja_logica = 1, fecha_baja=@fecha_baja 
	 where id_afiliado = @id_afiliado

end


go


create procedure XXX.st_actualizar_afiliado
@id_afiliado numeric(10,0),
@direccion   nvarchar(255),
@telefono    nvarchar(255),
@mail    nvarchar(255),
@plan_medico numeric(10,0),
@motivo    nvarchar(255),
@fecha date

AS
begin

	 update XXX.USUARIO SET direccion = @direccion, telefono=@telefono,mail=@mail,plan_medico=@plan_medico
	 where id_usuario = @id_afiliado


	 if(@plan_medico is not null)
	 begin
	  	 insert into XXX.HISTORIAL_CAMBIOS_DE_PLAN values
	  	 (@plan_medico,@id_afiliado,@motivo,@fecha)
	     

	  	 update XXX.AFILIADO SET plan_medico=@plan_medico
	     where id_afiliado = @id_afiliado	          
	 end	 

end

go

create procedure XXX.buscar_historial_de_cambios
@id_afiliado numeric(10,0)

AS
begin

	 select * 
	 FROM XXX.HISTORIAL_CAMBIOS_DE_PLAN
	 inner join XXX.PLAN_MEDICO on id_plan_medico = plan_medico
	 where afiliado = @id_afiliado

end
