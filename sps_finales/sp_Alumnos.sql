USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[sp_alumnos]    Script Date: 02/02/2022 19:07:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_alumnos]
@tipo			integer,
@nroCarnet		char(10) = null
as
if @tipo=1
	begin
		select	A.NroCarnet as NroCarnet,
				C.Nombre	as Carrera,
				Cl.Nombre	as Ciclo,
				A.DNI		as DNI,
				EA.Descripcion as Descripcion
			from Alumnos A
			left join Carrera C on C.IdCarrera=A.IdCarrera
			left join Ciclo Cl on Cl.IdCiclo = A.IdCiclo
			left join EstadoAlumno EA on EA.IdEstadoA=A.IdEstadoA
	end
if @tipo=2
	begin
		select	A.NroCarnet as NroCarnet,
				Cl.Nombre	as Ciclo,
				C.Nombre	as Carrera,
				dp.Nombres	as Nombres,
				EA.Descripcion as Descripcion
			from Alumnos A
			left join DatosPersonales DP on DP.DNI = A.DNI
			left join Carrera C on C.IdCarrera=A.IdCarrera
			left join Ciclo Cl on Cl.IdCiclo = A.IdCiclo
			left join EstadoAlumno EA on EA.IdEstadoA=A.IdEstadoA
			where A.NroCarnet=@nroCarnet
	end
