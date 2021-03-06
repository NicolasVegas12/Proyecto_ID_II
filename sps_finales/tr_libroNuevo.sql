USE [BDLIBRERIA1]
GO
/****** Object:  Trigger [dbo].[tr_LibroNuevo]    Script Date: 02/02/2022 19:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[tr_LibroNuevo]
 on [dbo].[Libro]
 for Insert
AS
begin
    declare 
        @IdLibro                    char(4),
        @Stock                        int,

        @Cuenta                        int

    select @IdLibro=IdLibro, @Stock=Stock from inserted
    set @Cuenta = 1

    while (@Stock>0)
        begin
            insert Ejemplar (IdLibro, IdEjemplar, IdEstadoE)
            values (@IdLibro, CONCAT(@IdLibro, RIGHT('00'+Convert(varchar(2),@Cuenta),2)), FLOOR(RAND()*(5)+1))

            set @Stock -= 1
            set @Cuenta += 1

        end
    end
