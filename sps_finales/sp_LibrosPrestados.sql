USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[sp_LibrosPrestados]    Script Date: 02/02/2022 19:08:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_LibrosPrestados]
@NroCarnet			char(08)=null,
@IdLibro			char(04)=null,
@IdPrestamo			char(10)=null,
@IdEstadoP			integer=null,
@tipo				integer
as
if @tipo=1
	begin
		declare @IdEjemplar		char(06)
		,@stock			integer

		select @stock=Stock
		from Libro L
		where IdLibro=@IdLibro

		select @IdEjemplar=IdEjemplar
			from(
				select ROW_NUMBER() Over(order by IdEjemplar) as orden,E.IdEjemplar
				from Ejemplar  E
				where E.IdLibro=@IdLibro
			)T1
			where orden=@stock

		select top 1 
				@IdPrestamo=P.IdPrestamo
			from Prestamo P 
			order by FechaPrestamo desc

		insert into ListaLibrosPrestados(NroCarnet,IdLibro,IdEjemplar,IdPrestamo,IdEstadoP) values(@NroCarnet,convert(varchar,@IdLibro),@IdEjemplar,@IdPrestamo,2)
	end
if @tipo=2 ---- IdPrestamo, IdLibro
	begin
		update ListaLibrosPrestados
			set IdEstadoP= 1
			where IdPrestamo= @IdPrestamo and NroCarnet= @NroCarnet

		update Prestamo
			set FechaDevolucion=GETDATE()
			where IdPrestamo=@IdPrestamo
	end
if @tipo=3
	begin 
		select	LP.NroCarnet as Alumno,
				L.Titulo	as Titulo,
				lp.IdEjemplar as Ejemplar,
				P.IdPrestamo as Prestamo,
				E.Descripcion as Estado,
				P.FechaDevolucion as 'Fecha de Devolucion'
			from ListaLibrosPrestados LP
			left join Prestamo P on P.IdPrestamo = lp.IdPrestamo
			left join EstadoPrestamo E on E.IdEstadoP = LP.IdEstadoP
			left join Libro L on L.IdLibro = LP.IdLibro
			left join Ejemplar EJ on EJ.IdEjemplar = LP.IdEjemplar
	end
if @tipo=4 ----Seleccionar unicamente los ejemplares que estan prestados
	begin
		select	LP.NroCarnet as Alumno,
				L.Titulo	as Titulo,
				lp.IdEjemplar as Ejemplar,
				P.IdPrestamo as Prestamo,
				E.Descripcion as Estado,
				P.FechaDevolucion as 'Fecha de Devolucion'
			from ListaLibrosPrestados LP
			left join Prestamo P on P.IdPrestamo = lp.IdPrestamo
			left join EstadoPrestamo E on E.IdEstadoP = LP.IdEstadoP
			left join Libro L on L.IdLibro = LP.IdLibro
			left join Ejemplar EJ on EJ.IdEjemplar = LP.IdEjemplar
		where E.IdEstadoP = 2
	end
if @tipo=5
	begin
		Update ListaLibrosPrestados
			set IdEstadoP=4
			where IdLibro=@IdLibro and IdPrestamo = @IdPrestamo
	end
if @tipo=6
	begin
		select P.IdPrestamo
			from Prestamo P
		where P.NroCarnet=@NroCarnet and P.FechaDevolucion>GETDATE()
	end
if @tipo=7
	begin
		update ListaLibrosPrestados
			set IdEstadoP=1
			where NroCarnet=@NroCarnet and IdPrestamo=@IdPrestamo and IdEstadoP!=4
		
	end
if @tipo=8
	begin
		select	l.Titulo as Titulo,
				lp.IdPrestamo as Prestamo,
				l.IdLibro as IdLibro
			from ListaLibrosPrestados lp
			inner join Libro l on l.IdLibro=lp.IdLibro
		where NroCarnet=@NroCarnet and lp.IdEstadoP=2
	end
