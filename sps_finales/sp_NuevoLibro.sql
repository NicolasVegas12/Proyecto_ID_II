USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[pa_NuevoLibro]    Script Date: 02/02/2022 19:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pa_NuevoLibro]
(
	@Titulo				varchar(100),
	@IdEditorial		int,
	@IdAutor			int,
	@IdArea				int,
	@IdIdioma			int,
	@Stock				int,
	@FechaEdicion		char(04)
)
As	
	Insert into Libro (IdLibro,Titulo,IdEditorial,IdAutor,IdArea,IdIdioma,Stock,FechaEdicion)
	values (dbo.fnCustomPass(4,'CN'),@Titulo, @IdEditorial, @IdAutor,@IdArea,@IdIdioma,@Stock,@FechaEdicion)
