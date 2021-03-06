USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[paBuscarAlumnoDNI]    Script Date: 02/02/2022 19:06:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[paBuscarAlumnoDNI] (@DNI char(8))
AS
	select distinct D.Nombres+' '+D.Apellidos as 'Nombre' from Alumnos A
	inner join DatosPersonales D on A.DNI = D.DNI
	where A.DNI = @DNI
