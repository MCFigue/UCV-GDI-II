select * from venta;
go
select * from PUBLICACION;
go


select * from EMPLEADO;
go
--tenemos que hacer que el stok se redusca

INSERT INTO venta(idventa, cliente,fecha,idempleado,idpublicacion,cantidad,precio,dcto,subtotal,impuesto,total)
  VALUES (25,'DanielFigueroa',GETDATE(),1,'LIB00001',2,50.00,1.00,100.00,16.00,150.00);
  go

UPDATE PUBLICACION
SET STOCK = 999
WHERE idpublicacion='LIB00001'; 
go

drop procedure usp_registrar_venta;
go

create procedure dbo.usp_registrar_venta
(
	@idventa int out,
	@cliente varchar(50),
	@idempleado int,
	@idpublicacion char(8) ,
	@cantidad int,
	@preciode money,
	@dcto money,	
	@subototal money,
	@impuesto money,
	@codigo int out,
	@mensaje varchar(1000) out
	
)
as
begin
	declare @costo money , @contador int,@total money;
	BEGIN TRY
		--INICIO DE REGISTRAR
		BEGIN TRANSACTION;

		--DATOS DE LA PUBLICACION 
		SELECT @contador = stock
		from PUBLICACION 
		where PUBLICACION.idpublicacion = @idpublicacion;
		if( @@ROWCOUNT = 0 )
		begin
			throw 51000, 'Cuenta no existe.', 1;
		end;
		begin transaction;
			SELECT @idventa=MAX(idventa) FROM VENTA;
		commit transaction;
		----Actualizar stok
		
		update PUBLICACION 
		set stock = @contador -1; 
		
		--
		set @total= @impuesto+@subototal;

		--registrar la venta
		insert into VENTA(idventa,cliente,fecha,idempleado,idpublicacion,cantidad,precio,dcto,subtotal,impuesto,total)
		values((@idventa+1),@cliente,GETDATE(),@idempleado,@idpublicacion,@cantidad,@preciode,@dcto,@subototal,@impuesto,@total);
		-- fin
		set @codigo = 1;
		set @mensaje = 'Proceso ejecutado correctamente';
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		set @codigo = -1;
		set @mensaje = 'Proceso fue abortado';
	END CATCH;
end;
go

begin
	declare @idventa int, @codigo int, @mensaje varchar(2000);
	EXEC usp_registrar_venta @idventa out, 'Mariano Melgar', 3,'LIB00001',3,24.00,25,21,15, @codigo out, @mensaje out;
	print cast(@codigo as varchar(10)) + ' - ' + @mensaje;
end;
go


select * from PUBLICACION WHERE idpublicacion='LIB00001';
go
select * from venta;
go
