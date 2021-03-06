USE [BDLIBRERIA1]
GO
/****** Object:  Trigger [dbo].[tr_Prestamo]    Script Date: 02/02/2022 19:03:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[tr_Prestamo]
 on [dbo].[ListaLibrosPrestados]
 for Insert
AS
begin
Begin transaction
	declare @IdLibro					char(04)
	declare @Stock						int
	select @IdLibro=IdLibro from inserted
	select @Stock=Stock from Libro where IdLibro=@IdLibro
if @Stock>0 
	begin
		update Libro
		set Stock-=1
		where IdLibro=@IdLibro
		commit transaction
	end
else
	begin
		rollback transaction
		raiserror('No hay libro disponible', 16, 2)
	end
end
