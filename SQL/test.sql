-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------ABM AFILIADO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------

exec BEMVINDO.st_insertar_afiliado 
'02' --nro_grupo_familiar
,3 --estado_civil
,NULL--plan_medico
,'roli'--nombre
,'bergara'--apellido
,1--tipo_documento
,'434'--documento
,'2016-10-02 02:01:54.560'--fecha_nacimiento
,'sara sara'--direccion
,'4392-3945'--telefono
,'roli76@hotmail.com'--mail
,'F'--sexo
,4


exec BEMVINDO.st_baja_afiliado
202 --nroAfilado
,'2016-10-07 02:01:54.560'--fecha_baja


exec BEMVINDO.st_actualizar_afiliado
3,--@id_afiliado 
3,--@id_usuario     
'CALLE ACTUALIZAR',--@direccion   
'XXXX-XXXX',--@telefono    
'@@@@@@@@@@',--@mail    
1,--@plan_medico 
'PORQUE SE ME CANTA',--@motivo     
'2016-10-02 02:01:54.560'--@fecha_sistema 


exec BEMVINDO.buscar_historial_de_cambios
3 --@id_afiliado

select * FROM BEMVINDO.AFILIADO
select * FROM BEMVINDO.USUARIO



-----------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------ABM AFILIADO----------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------
