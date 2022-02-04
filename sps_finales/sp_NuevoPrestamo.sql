USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[pa_NuevoPrestamo]    Script Date: 02/02/2022 19:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pa_NuevoPrestamo]
(
	@Carnet char(8)
)
as 
	Insert into Prestamo (NroCarnet,FechaPrestamo,IdPrestamo,FechaDevolucion)
	VALUES (@Carnet,GETDATE(),dbo.fnCustomPass(10,'N'), DATEADD(MM, 2, getdate()))
