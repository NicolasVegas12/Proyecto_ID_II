USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[sp_AccionesLibros]    Script Date: 02/02/2022 19:07:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_AccionesLibros]
@IdLibro			char(04)=null,
@Titulo				varchar(80)=null,
@FechaEdicion		char(04)=null,
@IdEditorial		Integer=null,
@Stock				Integer=null,
@IdIdioma			Integer=null,
@IdAutor			Integer=null,
@IdArea				Integer=null,
@tipoAccion				integer
as	
if @tipoAccion = 1
	begin
		select	L.IdLibro as IdLibro,
				L.Titulo as Titulo,
				L.FechaEdicion as 'Fecha Edicion',
				E.Nombre as Editorial,
				L.Stock as Stock,
				I.Nombre as Idioma,
				AU.Nombre as Autor,
				A.Descripcion as Area
			from Libro L
			left join Editorial E on E.IdEditorial=L.IdEditorial
			left join Area A on A.IdArea = L.IdArea
			left join Autor AU on AU.IdAutor=L.IdAutor
			left join Idioma I on I.IdIdioma=L.IdIdioma
	end
if @tipoAccion = 2
	 begin
		insert into Libro values(@IdLibro, @Titulo,@FechaEdicion,@IdEditorial,@Stock,@IdIdioma, @IdAutor, @IdArea)
	 end
if @tipoAccion = 3
	begin
		update Libro
			set Titulo = @Titulo,
				FechaEdicion= @FechaEdicion,
				IdEditorial=@IdEditorial,
				IdIdioma=@IdIdioma,
				IdAutor=@IdAutor,
				IdArea=@IdArea
		where IdLibro = @IdLibro
	end
if @tipoAccion = 4
	begin
		select	*
			from Libro L
			where IdLibro = @IdLibro
	end
if @tipoAccion = 5
	begin
		set @IdEditorial=nullif(@IdEditorial,0)
		set @IdArea=nullif(@IdArea,0)
		set @IdAutor=nullif(@IdAutor,0)
		set @IdIdioma=nullif(@IdIdioma,0)

		select	idLibro,
				Titulo
		from Libro 
		where IdEditorial = IIF(@IdEditorial is null, IdEditorial, @IdEditorial) 
			and IdIdioma = IIF(@IdIdioma is null, IdIdioma, @IdIdioma)
			and IdAutor = IIF(@IdAutor is null, IdAutor, @IdAutor)
			and IdArea = IIF(@IdArea is null, IdArea, @IdArea)
			and Stock>0
	end
