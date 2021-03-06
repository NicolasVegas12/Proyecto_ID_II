USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[sp_DatosPersonales]    Script Date: 02/02/2022 19:07:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_DatosPersonales] 
@tipo			integer
as
if @tipo=1
	begin
		select	Dp.DNI			as DNI,
				DP.Nombres		as Nombre,
				DP.Email		as Email,
				DP.Apellidos	as Apellidos,
				DP.Fijo			as Fijo,
				DP.Celular		as Celular,
				SX.Descripcion	as Sexo
			from DatosPersonales DP
			left join Sexo SX on SX.IdSexo=DP.IdSexo
	end