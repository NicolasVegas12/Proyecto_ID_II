USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[pa_NuevaLista]    Script Date: 02/02/2022 19:05:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[pa_NuevaLista]
(
	@Carnet char(8),
	@IdPrestamo char(10),
	@Idlibro char(4),
	@IdEjemplar char(6)
)
as 
	Insert into ListaLibrosPrestados (NroCarnet,IdLibro,IdEjemplar,IdPrestamo,IdEstadoP)
	VALUES (@Carnet,@Idlibro,@IdEjemplar,@IdPrestamo,2)
