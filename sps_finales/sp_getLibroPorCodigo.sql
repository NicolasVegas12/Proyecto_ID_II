USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetLibroPorCodigo]    Script Date: 02/02/2022 19:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_GetLibroPorCodigo]
	@Codigo char(04)
AS
BEGIN
	SELECT P.Titulo			as Titulo,
		   P.IdEditorial	as IdEditorial,
		   P.Stock			as Stock,
		   P.IdIdioma		as IdIdioma,
		   P.IdAutor		as IdAutor,
		   P.IdArea			as IdArea,
		   E.Nombre			as NombreEditorial,
		   I.Nombre			as NombreIdioma,
		   A.Nombre			as NombreAutor,
		   Ar.Descripcion	as NombreArea
	FROM Libro P
	inner join Editorial E
		on E.IdEditorial = P.IdEditorial
	inner join Idioma I
		on I.IdIdioma = P.IdIdioma
	inner join Autor A
		on A.IdAutor = P.IdAutor
	inner join Area Ar
		on Ar.IdArea = P.IdArea
	WHERE P.IdLibro = @Codigo
END
