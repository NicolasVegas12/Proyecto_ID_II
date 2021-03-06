USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[sp_Prestamo]    Script Date: 02/02/2022 19:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Prestamo]
@nroCarnet		char(8)=null,
@IdPrestamo		char(4)=null,
@tipo			integer
as
if @tipo=1
	begin
		set @IdPrestamo=nullif(@IdPrestamo,dbo.fnCustomPass(4,'CN'))
		insert Prestamo(NroCarnet,FechaPrestamo,IdPrestamo,FechaDevolucion) values(@nroCarnet,GETDATE(),iif(@IdPrestamo is null,dbo.fnCustomPass(4,'CN'),@IdPrestamo),GETDATE()+30)
	end
if @tipo=2
	begin
		update Prestamo
			set FechaDevolucion=GETDATE()
		where IdPrestamo=@IdPrestamo
	end
if @tipo=3
	begin
		select	IdPrestamo,
				NroCarnet,
				FechaPrestamo,
				FechaDevolucion
			from Prestamo
	end
