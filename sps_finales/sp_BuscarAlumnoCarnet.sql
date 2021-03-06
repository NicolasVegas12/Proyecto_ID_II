USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[paBuscarAlumnoCarnet]    Script Date: 02/02/2022 19:06:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[paBuscarAlumnoCarnet] (@NroCarnet char(8))
AS
	select distinct D.Nombres+' '+D.Apellidos as 'Nombre' from Alumnos A
	inner join DatosPersonales D on A.DNI = D.DNI
	where A.NroCarnet = @NroCarnet
