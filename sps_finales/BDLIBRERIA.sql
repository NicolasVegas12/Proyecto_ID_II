USE MASTER
GO

create database BDLIBRERIA1
GO

use BDLIBRERIA1
GO


CREATE TABLE Alumnos
( 
	NroCarnet            CHAR(8)  NOT NULL ,
	IdCarrera            int  NULL ,
	IdCiclo              int  NULL ,
	DNI                  CHAR(8)  NULL ,
	IdEstadoA            int  NULL 
)
go



ALTER TABLE Alumnos
	ADD CONSTRAINT XPKAlumno PRIMARY KEY  NONCLUSTERED (NroCarnet ASC)
go



CREATE TABLE Area
( 
	IdArea               int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(40)  NULL 
)
go



ALTER TABLE Area
	ADD CONSTRAINT XPKTipo PRIMARY KEY  NONCLUSTERED (IdArea ASC)
go



CREATE TABLE Autor
( 
	IdAutor              int IDENTITY ( 1,1 ) ,
	Nombre               varchar(40)  NULL ,
	Email                varchar(100)  NULL ,
	Nacionalidad         varchar(40)  NULL 
)
go



ALTER TABLE Autor
	ADD CONSTRAINT XPKAutor PRIMARY KEY  NONCLUSTERED (IdAutor ASC)
go



CREATE TABLE Carrera
( 
	IdCarrera            int IDENTITY ( 1,1 ) ,
	Nombre               varchar(40)  NULL ,
	IdFacultad           int  NULL 
)
go



ALTER TABLE Carrera
	ADD CONSTRAINT XPKCarrera PRIMARY KEY  NONCLUSTERED (IdCarrera ASC)
go



CREATE TABLE Ciclo
( 
	IdCiclo              int IDENTITY ( 1,1 ) ,
	Nombre               VARCHAR(40)  NULL 
)
go



ALTER TABLE Ciclo
	ADD CONSTRAINT XPKCiclo PRIMARY KEY  NONCLUSTERED (IdCiclo ASC)
go



CREATE TABLE DatosPersonales
( 
	DNI                  CHAR(8)  NOT NULL ,
	Nombres              varchar(40)  NULL ,
	Email                varchar(100)  NULL ,
	Apellidos            varchar(40)  NULL ,
	Fijo                 varchar(10)  NULL ,
	Celular              varchar(15)  NULL ,
	IdSexo               int  NULL 
)
go



ALTER TABLE DatosPersonales
	ADD CONSTRAINT XPKDatosPersonales PRIMARY KEY  NONCLUSTERED (DNI ASC)
go



CREATE TABLE Editorial
( 
	IdEditorial          int IDENTITY ( 1,1 ) ,
	Nombre               varchar(60)  NULL 
)
go



ALTER TABLE Editorial
	ADD CONSTRAINT XPKEditorial PRIMARY KEY  NONCLUSTERED (IdEditorial ASC)
go



CREATE TABLE Ejemplar
( 
	IdLibro              CHAR(4)  NOT NULL ,
	IdEjemplar           CHAR(6)  NOT NULL ,
	IdEstadoE            int  NULL 
)
go



ALTER TABLE Ejemplar
	ADD CONSTRAINT XPKEjemplar PRIMARY KEY  NONCLUSTERED (IdLibro ASC,IdEjemplar ASC)
go



CREATE TABLE EstadoAlumno
( 
	IdEstadoA            int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(40)  NULL 
)
go



ALTER TABLE EstadoAlumno
	ADD CONSTRAINT XPKEstadoAlumno PRIMARY KEY  NONCLUSTERED (IdEstadoA ASC)
go



CREATE TABLE EstadoEjemplar
( 
	IdEstadoE            int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(40)  NULL 
)
go



ALTER TABLE EstadoEjemplar
	ADD CONSTRAINT XPKEstadoEjemplar PRIMARY KEY  NONCLUSTERED (IdEstadoE ASC)
go



CREATE TABLE EstadoPrestamo
( 
	IdEstadoP            int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(40)  NULL 
)
go



ALTER TABLE EstadoPrestamo
	ADD CONSTRAINT XPKEstadoPrestamo PRIMARY KEY  NONCLUSTERED (IdEstadoP ASC)
go



CREATE TABLE Facultad
( 
	IdFacultad           int IDENTITY ( 1,1 ) ,
	Nombre               varchar(80)  NULL 
)
go



ALTER TABLE Facultad
	ADD CONSTRAINT XPKFacultad PRIMARY KEY  NONCLUSTERED (IdFacultad ASC)
go



CREATE TABLE Idioma
( 
	IdIdioma             int IDENTITY ( 1,1 ) ,
	Nombre               varchar(40)  NULL 
)
go



ALTER TABLE Idioma
	ADD CONSTRAINT XPKIdioma PRIMARY KEY  NONCLUSTERED (IdIdioma ASC)
go



CREATE TABLE Libro
( 
	IdLibro              CHAR(4)  NOT NULL ,
	Titulo               varchar(100)  NULL ,
	FechaEdicion         datetime  NULL ,
	IdEditorial          int  NULL ,
	Stock                int  NULL ,
	IdIdioma             int  NULL ,
	IdAutor              int  NULL ,
	IdArea               int  NULL 
)
go



ALTER TABLE Libro
	ADD CONSTRAINT XPKLibro PRIMARY KEY  NONCLUSTERED (IdLibro ASC)
go



CREATE TABLE ListaLibrosPrestados
( 
	NroCarnet            CHAR(8)  NOT NULL ,
	IdLibro              CHAR(4)  NOT NULL ,
	IdEjemplar           CHAR(6)  NOT NULL ,
	IdPrestamo           CHAR(10)  NOT NULL ,
	IdEstadoP            int  NULL 
)
go



ALTER TABLE ListaLibrosPrestados
	ADD CONSTRAINT XPKListaLibrosPrestados PRIMARY KEY  NONCLUSTERED (NroCarnet ASC,IdLibro ASC,IdEjemplar ASC,IdPrestamo ASC)
go



CREATE TABLE Prestamo
( 
	NroCarnet            CHAR(8)  NOT NULL ,
	FechaPrestamo        datetime  NULL ,
	IdPrestamo           CHAR(10)  NOT NULL ,
	FechaDevolucion      datetime  NULL 
)
go



ALTER TABLE Prestamo
	ADD CONSTRAINT XPKPRESTAMO PRIMARY KEY  NONCLUSTERED (NroCarnet ASC,IdPrestamo ASC)
go



CREATE TABLE Sexo
( 
	IdSexo               int IDENTITY ( 1,1 ) ,
	Descripcion          VARCHAR(40)  NULL 
)
go



ALTER TABLE Sexo
	ADD CONSTRAINT XPKSexo PRIMARY KEY  NONCLUSTERED (IdSexo ASC)
go




ALTER TABLE Alumnos
	ADD CONSTRAINT R_33 FOREIGN KEY (IdCarrera) REFERENCES Carrera(IdCarrera)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Alumnos
	ADD CONSTRAINT R_34 FOREIGN KEY (IdCiclo) REFERENCES Ciclo(IdCiclo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Alumnos
	ADD CONSTRAINT R_35 FOREIGN KEY (DNI) REFERENCES DatosPersonales(DNI)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Alumnos
	ADD CONSTRAINT R_36 FOREIGN KEY (IdEstadoA) REFERENCES EstadoAlumno(IdEstadoA)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Carrera
	ADD CONSTRAINT R_32 FOREIGN KEY (IdFacultad) REFERENCES Facultad(IdFacultad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DatosPersonales
	ADD CONSTRAINT R_43 FOREIGN KEY (IdSexo) REFERENCES Sexo(IdSexo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Ejemplar
	ADD CONSTRAINT R_11 FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Ejemplar
	ADD CONSTRAINT R_40 FOREIGN KEY (IdEstadoE) REFERENCES EstadoEjemplar(IdEstadoE)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Libro
	ADD CONSTRAINT R_15 FOREIGN KEY (IdEditorial) REFERENCES Editorial(IdEditorial)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Libro
	ADD CONSTRAINT R_37 FOREIGN KEY (IdIdioma) REFERENCES Idioma(IdIdioma)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Libro
	ADD CONSTRAINT R_38 FOREIGN KEY (IdAutor) REFERENCES Autor(IdAutor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Libro
	ADD CONSTRAINT R_44 FOREIGN KEY (IdArea) REFERENCES Area(IdArea)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE ListaLibrosPrestados
	ADD CONSTRAINT R_9 FOREIGN KEY (NroCarnet,IdPrestamo) REFERENCES Prestamo(NroCarnet,IdPrestamo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE ListaLibrosPrestados
	ADD CONSTRAINT R_10 FOREIGN KEY (IdLibro,IdEjemplar) REFERENCES Ejemplar(IdLibro,IdEjemplar)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE ListaLibrosPrestados
	ADD CONSTRAINT R_39 FOREIGN KEY (IdEstadoP) REFERENCES EstadoPrestamo(IdEstadoP)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Prestamo
	ADD CONSTRAINT R_7 FOREIGN KEY (NroCarnet) REFERENCES Alumnos(NroCarnet)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
