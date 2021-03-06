USE [BDLIBRERIA1]
GO
/****** Object:  StoredProcedure [dbo].[sp_Ejemplar]    Script Date: 02/02/2022 19:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_Ejemplar]
@tipo				integer
as 
if @tipo=1
	begin
		select	L.Titulo			as Libro,
				E.IdEjemplar		as IdEjemplar,
				EE.Descripcion		as Estado
			from Ejemplar E
			left join Libro L on L.IdLibro = E.IdLibro
			left join EstadoEjemplar EE on EE.IdEstadoE=E.IdEstadoE
	end