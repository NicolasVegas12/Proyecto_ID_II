USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[sp_carrera]    Script Date: 02/02/2022 19:07:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_carrera]
@tipo			integer
as
if @tipo=1
	begin
		select	C.IdCarrera	as IdCarrera,
				C.Nombre	as Nombre,
				F.Nombre	as Facultad
			from Carrera C
			inner join Facultad F on F.IdFacultad=C.IdFacultad
	end