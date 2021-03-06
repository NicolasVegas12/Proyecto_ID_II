USE [BDLIBRERIA1]
GO
/****** Object:  Trigger [dbo].[tr_Devolucion]    Script Date: 02/02/2022 19:03:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[tr_Devolucion]
	on [dbo].[ListaLibrosPrestados]
	for Update
AS
begin
begin transaction
	declare 
		@IdEjemplar		char(06),
		@IdLibro		char(04),
		@IdEstadoP		int
	select @IdEjemplar = IdEjemplar from deleted
	select @IdEstadoP = IdEstadoP from inserted
	select @IdLibro = L.IdLibro from Ejemplar E
	inner join Libro L on L.IdLibro = E.IdLibro
	where E.IdEjemplar=@IdEjemplar
if (@IdEstadoP = 1)
	begin
		update LIBRO set Stock+=1 where idLibro=@IdLibro
		commit transaction
	end
if(@IdEstadoP=4)
	begin
		commit transaction
	end
else
	begin
		rollback transaction
		raiserror('El estado no puede actualizarse', 16, 2)
	end
end
