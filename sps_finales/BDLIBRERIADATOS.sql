use MASTER
go

use BDLIBRERIA1 
go

INSERT INTO area VALUES('Ingeniería');
INSERT INTO area VALUES('Biología');
INSERT INTO area VALUES('Matemática');
INSERT INTO area VALUES('Física');
INSERT INTO area VALUES('Química');
INSERT INTO area VALUES('Medicina');
INSERT INTO area VALUES('Derecho');
INSERT INTO area VALUES('Contabilidad y Finanzas');
INSERT INTO area VALUES('Historia');

INSERT INTO estadoalumno VALUES('Matriculado');
INSERT INTO estadoalumno VALUES('Atrasado');
INSERT INTO estadoalumno VALUES('Retirado');
INSERT INTO estadoalumno VALUES('Expulsado');

INSERT INTO estadoejemplar VALUES('Nuevo');
INSERT INTO estadoejemplar VALUES('Bueno');
INSERT INTO estadoejemplar VALUES('Regular');
INSERT INTO estadoejemplar VALUES('Malo');
INSERT INTO estadoejemplar VALUES('Pésimo');

INSERT INTO estadoprestamo VALUES('Devuelto');
INSERT INTO estadoprestamo VALUES('Prestado');
INSERT INTO estadoprestamo VALUES('Atrasado');
INSERT INTO estadoprestamo VALUES('Perdido');

INSERT INTO facultad VALUES('Facultad de Ciencias Agropecuarias');
INSERT INTO facultad VALUES('Facultad de Ciencias Biológicas');
INSERT INTO facultad VALUES('Facultad de Ciencias Económicas');
INSERT INTO facultad VALUES('Facultad de Estomatología');
INSERT INTO facultad VALUES('Facultad de Ciencias Físicas y Matemáticas');
INSERT INTO facultad VALUES('Facultad de Ciencias Sociales');
INSERT INTO facultad VALUES('Facultad de Derecho y Ciencias Políticas');
INSERT INTO facultad VALUES('Facultad de Educación y Ciencias de la Comunicación');
INSERT INTO facultad VALUES('Facultad de Enfermería');
INSERT INTO facultad VALUES('Facultad de Farmacia y Bioquímica');
INSERT INTO facultad VALUES('Facultad de Ingeniería');
INSERT INTO facultad VALUES('Facultad de Ingeniería Química');
INSERT INTO facultad VALUES('Facultad de Medicina');

INSERT INTO idioma VALUES('Español');
INSERT INTO idioma VALUES('Inglés');
INSERT INTO idioma VALUES('Portugués');
INSERT INTO idioma VALUES('Francés');
INSERT INTO idioma VALUES('Ruso');

INSERT INTO sexo VALUES('Masculino');
INSERT INTO sexo VALUES('Femenino');

INSERT INTO ciclo VALUES('I');
INSERT INTO ciclo VALUES('II');
INSERT INTO ciclo VALUES('III');
INSERT INTO ciclo VALUES('IV');
INSERT INTO ciclo VALUES('V');
INSERT INTO ciclo VALUES('VI');
INSERT INTO ciclo VALUES('VII');
INSERT INTO ciclo VALUES('VIII');
INSERT INTO ciclo VALUES('IX');
INSERT INTO ciclo VALUES('X');

INSERT INTO autor VALUES('Elisea Aparicio Ordóñez', 'eliseaaparicio@gmail.com', 'Español');
INSERT INTO autor VALUES('Ludwiq Valladares Ocampo', 'ludwiqvalladares@gmail.com', 'Brasileño');
INSERT INTO autor VALUES('Michaela Gutiérrez Burgos', 'michaelagutierrez@gmail.com', 'Peruano');
INSERT INTO autor VALUES('Columba Valenzuela Armijo', 'columbavalenzuela@gmail.com', 'Argentina');
INSERT INTO autor VALUES('Arduino Zambrano Segovia', 'arduinozambrano@gmail.com', 'Boliviano');
INSERT INTO autor VALUES('Linda E. Fishburn', 'lindaefishburn@gmail.com', 'Estadounidense');
INSERT INTO autor VALUES('Cory D. Schwartz', 'corydschwartz@gmail.com', 'Estadounidense');
INSERT INTO autor VALUES('Osmundo Rosario Peres', 'osmundorosario@gmail.com', 'Español');
INSERT INTO autor VALUES('Eliezer Arce Luevano', 'eliezerarce@gmail.com', 'Peruano');
INSERT INTO autor VALUES('Livino Rosas Collado', 'livinorosas@gmail.com', 'Peruano');
INSERT INTO autor VALUES('Agar Naranjo Yáñez', 'agarnaranjo@gmail.com', 'Argentino');
INSERT INTO autor VALUES('Anisa Abakumova', 'anisaabakumova@gmail.com', 'Ruso');
INSERT INTO autor VALUES('Caio Ribeiro Azevedo', 'caioribeiro@gmail.com', 'Brasileño');

INSERT INTO autor VALUES('Martina Ordóñez', 'adasdasf@gmail.com', 'Chileno');
INSERT INTO autor VALUES('Ruben Ocampo', 'rubeoca@gmail.com', 'Brasileño');
INSERT INTO autor VALUES('José Gutiérrez ', 'gutjose@gmail.com', 'Peruano');
INSERT INTO autor VALUES('Anthony Mio', 'mioanthony@gmail.com', 'Uruguayo');
INSERT INTO autor VALUES('Marcelo Malca', 'malmar@gmail.com', 'Boliviano');
INSERT INTO autor VALUES('Washinton', 'dc@gmail.com', 'Estadounidense');
INSERT INTO autor VALUES('Dencel Schwartz', 'denschwar@gmail.com', 'Estadounidense');
INSERT INTO autor VALUES('Oswaldo Saldivar', 'oswalS@gmail.com', 'Español');
INSERT INTO autor VALUES('Elise Rosas', 'elisas@gmail.com', 'Argentino');
INSERT INTO autor VALUES('Fernanda Gallego', 'fergo@gmail.com', 'Peruano');
INSERT INTO autor VALUES('Samara Llamoga', 'llasam@gmail.com', 'Argentino');
INSERT INTO autor VALUES('Steven Cavero', 'caseven@gmail.com', 'Chileno');
INSERT INTO autor VALUES('Astrid Rojas', 'astrojas@gmail.com', 'Peruano');

INSERT INTO carrera VALUES('Agronomía', 1);
INSERT INTO carrera VALUES('Ingeniería Agroindustrial', 1);
INSERT INTO carrera VALUES('Ingeniería Agrícola', 1);
INSERT INTO carrera VALUES('Zootecnia', 1);
INSERT INTO carrera VALUES('Biología Pesquera', 2);
INSERT INTO carrera VALUES('Ciencias Biológicas', 2);
INSERT INTO carrera VALUES('Microbiología y Parasitología', 2);
INSERT INTO carrera VALUES('Administración', 3);
INSERT INTO carrera VALUES('Contabilidad y Finanzas', 3);
INSERT INTO carrera VALUES('Economía', 3);
INSERT INTO carrera VALUES('Estomatología', 4);
INSERT INTO carrera VALUES('Física y Química', 5);
INSERT INTO carrera VALUES('Informática e Información', 5);
INSERT INTO carrera VALUES('Matemática, Economía y Finanzas', 5);
INSERT INTO carrera VALUES('Ciencias Sociales y Humanidades', 6);
INSERT INTO carrera VALUES('Historia y Geografía', 6);
INSERT INTO carrera VALUES('Hotelería, Gastronomía y Turismo', 6);
INSERT INTO carrera VALUES('Ciencias Políticas', 7);
INSERT INTO carrera VALUES('Derecho y Leyes', 7);
INSERT INTO carrera VALUES('Educación y Pedagogía', 8);
INSERT INTO carrera VALUES('Publicidad, Mercadotecnia y RRPP', 8);
INSERT INTO carrera VALUES('Enfermería', 9);
INSERT INTO carrera VALUES('Farmacia y Bioquímica', 10);
INSERT INTO carrera VALUES('Arquitectura y Urbanismo', 11);
INSERT INTO carrera VALUES('Ingeniería Civil', 11);
INSERT INTO carrera VALUES('Ingeniería Industrial', 11);
INSERT INTO carrera VALUES('Ingeniería Mecánica', 11);
INSERT INTO carrera VALUES('Ingeniería Mecatrónica', 11);
INSERT INTO carrera VALUES('Ingeniería Materiales', 11);
INSERT INTO carrera VALUES('Ingeniería Metalúrgica', 11);
INSERT INTO carrera VALUES('Ingeniería de Minas', 11);
INSERT INTO carrera VALUES('Ingeniería de Sistemas', 11);
INSERT INTO carrera VALUES('Ingeniería Química', 12);
INSERT INTO carrera VALUES('Medicina', 13);

INSERT INTO datospersonales VALUES('49537649', 'Vital Kenner', 'Dávila Robledo', 'vitaldavilarobledo@gmail.com', '245392', '999703997', 1);
INSERT INTO datospersonales VALUES('61529863', 'Luis Abram', 'Aguayo Villanueva', 'luisaguayovillan@gmail.com', '263596', '981543597', 1);
INSERT INTO datospersonales VALUES('71629437', 'Gadiela Alexandra', 'Cavazos Terán', 'gadielacavazost@gmail.com', '264319', '933649044', 2);
INSERT INTO datospersonales VALUES('91253686', 'Marisel Gabriela', 'Alba Zambrano', 'mariselalbazambrano@gmail.com', '281963', '946439739', 2);
INSERT INTO datospersonales VALUES('92648239', 'Maria Elena', 'Riojas Carreón', 'mariariojascarreon@gmail.com', '216396', '952214245', 2);

INSERT INTO Alumnos values('11112222',1,2,'49537649',1);
INSERT INTO Alumnos values('22223333',2,2,'61529863',2);
INSERT INTO Alumnos values('33334444',3,3,'71629437',2);
INSERT INTO Alumnos values('44445555',3,3,'91253686',2);
INSERT INTO Alumnos values('55556666',5,4,'92648239',4);

INSERT INTO datospersonales VALUES('25874593', 'Diana Maria', 'Robledo Dávila ', 'asdas@gmail.com', '142546', '96785412', 2);
INSERT INTO datospersonales VALUES('14529876', 'Brandon Marlo', 'Torres Salas', 'awwwqqq@gmail.com', '15236', '95412378', 1);
INSERT INTO datospersonales VALUES('65498732', 'Alessandra Ada', 'Mendoza Galvez', 'aas12@gmail.com', '36524', '98741325', 2);
INSERT INTO datospersonales VALUES('15935784', 'Manuel Carlos', 'Galvan Gonzales', 'adsaqq65@gmail.com', '748512', '91245637', 1);
INSERT INTO datospersonales VALUES('14796325', 'Fernanda Diana', 'Malca Marino', 'pahjsdb1452@gmail.com', '143987', '91214567', 2);

INSERT INTO Alumnos values('66667777',2,2,'25874593',1);
INSERT INTO Alumnos values('77778888',2,2,'14529876',1);
INSERT INTO Alumnos values('11221122',7,10,'65498732',1);
INSERT INTO Alumnos values('22332233',8,8,'15935784',2);
INSERT INTO Alumnos values('33443344',9,8,'14796325',1);

INSERT INTO datospersonales VALUES('98732164', 'Nicol Mercedez', 'Ramirez Torres', 'psjd45@gmail.com', '741852', '96661112', 2);
INSERT INTO datospersonales VALUES('24587136', 'Junior Anthony', 'Mio Zambrano', 'fbcg@gmail.com', '2514436', '93265412', 1);
INSERT INTO datospersonales VALUES('24178963', 'Gabriela Alexandra', 'Terán Cavazos', 'bcshdf@gmail.com', '748513', '98123698', 2);
INSERT INTO datospersonales VALUES('32165497', 'Marisel Gabriela', 'Alba Zambrano', 'mbcnvj@gmail.com', '716354', '97316458', 2);
INSERT INTO datospersonales VALUES('33665577', 'Hilary Eleane', 'Aguayo Carreón', 'sdjhvsdv@gmail.com', '964185', '93178942', 2);

INSERT INTO Alumnos values('44554455',5,2,'98732164',1);
INSERT INTO Alumnos values('55665566',6,2,'24587136',1);
INSERT INTO Alumnos values('66776677',6,3,'24178963',1);
INSERT INTO Alumnos values('77887788',8,3,'32165497',2);
INSERT INTO Alumnos values('88998899',9,4,'33665577',4);

INSERT INTO datospersonales VALUES('78451223', 'Marcelino Ricardo', 'Lazaro Robledo', '254pop@gmail.com', '857432', '93479658', 1);
INSERT INTO datospersonales VALUES('66554477', 'Jose Mario', 'Arteaga Muñoz', 'bgch123@gmail.com', '748516', '92543687', 1);
INSERT INTO datospersonales VALUES('12451245', 'Marlene Gabriela', 'Terán Sanchez', 'jkfdnb@gmail.com', '85743', '96583241', 2);
INSERT INTO datospersonales VALUES('36365858', 'Marisol Elena', 'Moras Alba', 'laslap@gmail.com', '236548', '98787965', 2);
INSERT INTO datospersonales VALUES('32321545', 'Fernanda Estrella', 'Bardarles Esparza', 'mvjshe@gmail.com', '123987', '95956262', 2);

INSERT INTO Alumnos values('12121212',6,2,'78451223',1);
INSERT INTO Alumnos values('23232323',8,2,'66554477',1);
INSERT INTO Alumnos values('34343434',9,5,'12451245',3);
INSERT INTO Alumnos values('45454545',10,5,'36365858',1);
INSERT INTO Alumnos values('56565656',11,8,'32321545',3);

INSERT INTO datospersonales VALUES('74185296', 'Luis Eduardo', 'Espinoza Cercado', '1254jhgn@gmail.com', '662233', '98765432', 1);
INSERT INTO datospersonales VALUES('75486325', 'Abram Marcelo', 'Quispe Aliaga', 'bjdfbnjd@gmail.com', '445566', '99887722', 1);
INSERT INTO datospersonales VALUES('85479632', 'Alejandro Renzo', 'Herrera Flores', '74asdas@gmail.com', '256111', '96331122', 1);
INSERT INTO datospersonales VALUES('12453678', 'Fernando Robin', 'Estela Bazan', '564156@gmail.com', '445577', '97556633', 1);
INSERT INTO datospersonales VALUES('19876598', 'Flavia Carolina', 'Marin Diaz', 'mbfdk@gmail.com', '335588', '92546688', 2);

INSERT INTO Alumnos values('67676767',8,2,'74185296',1);
INSERT INTO Alumnos values('78787878',7,2,'75486325',2);
INSERT INTO Alumnos values('89898989',12,3,'85479632',2);
INSERT INTO Alumnos values('61616161',12,3,'12453678',3);
INSERT INTO Alumnos values('71717171',11,4,'19876598',1);

INSERT INTO Editorial values ('Animal de Invierno');
INSERT INTO Editorial values ('Grupo Editorial Caja Negra');
INSERT INTO Editorial values ('Colmena Editores');
INSERT INTO Editorial values ('Editorial Ambar');
INSERT INTO Editorial values ('Editorial Futura');
INSERT INTO Editorial values ('Editorial Macro');
INSERT INTO Editorial values ('Editorial María Trinidad');
INSERT INTO Editorial values ('Editorial Pesopluma');
INSERT INTO Editorial values ('Grupo Editorial Gato Viejo');
INSERT INTO Editorial values ('Khalamos');
INSERT INTO Editorial values ('La Travesía Editora');
INSERT INTO Editorial values ('Letra Grupo Editorial');
INSERT INTO Editorial values ('Manoalzada Editores');
INSERT INTO Editorial values ('Mesa Redonda Editorial');
INSERT INTO Editorial values ('Nova Casa Editorial');
INSERT INTO Editorial values ('Paracaídas Editores');
INSERT INTO Editorial values ('Polifonía Editora');

SET DATEFORMAT dmy;

INSERT INTO Libro values ('AB12','Programacion 1','10-11-2001',2,10,1,14,1);
INSERT INTO Libro values ('BC23','Matematica 1','14-01-2001',2,10,3,12,3);
INSERT INTO Libro values ('CD34','Biologia 1','09-12-2010',2,10,5,11,2);
INSERT INTO Libro values ('DE45','Redaccion 1','05-11-2002',1,10,4,1,7);
INSERT INTO Libro values ('MN56','Programacion 2','20-02-2002',1,10,4,10,1);
INSERT INTO Libro values ('PO67','Java 1','15-02-2001',3,10,2,9,1);
INSERT INTO Libro values ('QW78','Java 2','19-10-2001',3,10,2,4,1);
INSERT INTO Libro values ('AX14','Entomologia 1','28-12-2000',7,10,1,13,2);
INSERT INTO Libro values ('MB25','Entomologia 2','15-01-2001',8,10,1,4,2);
INSERT INTO Libro values ('PA41','Entomologia 3','11-09-2001',7,10,3,5,2);
INSERT INTO Libro values ('TQ98','Cinetica','12-06-2008',10,10,3,6,4);
INSERT INTO Libro values ('KJ47','Carbono 1','02-09-2003',4,10,3,7,5);
INSERT INTO Libro values ('LA12','Reacciones quimicas 1','18-02-2006',5,10,5,17,5);
INSERT INTO Libro values ('FV65','Gases Ideales 1','14-02-2000',6,10,5,20,4);

INSERT INTO Libro values ('DX45','Gases Ideales 2','28-10-2001',1,10,5,21,4);
INSERT INTO Libro values ('PL89','Carbono 2','26-07-2001',2,10,4,22,5);
INSERT INTO Libro values ('KA68','Cuentas Contables','25-07-1998',3,10,4,19,8);
INSERT INTO Libro values ('MC42','Riesgo Sistematico','18-03-2004',3,10,4,18,8);
INSERT INTO Libro values ('GH74','Riesgo no Sistematico','19-12-2004',4,10,2,25,8);
INSERT INTO Libro values ('HY87','Reacciones quimicas 2','28-02-2001',4,10,2,26,5);
INSERT INTO Libro values ('KQ23','Enlace Covalente','19-08-2004',7,10,2,10,5);
INSERT INTO Libro values ('QM32','Leyes Penales','19-06-2002',7,10,3,24,7);
INSERT INTO Libro values ('PL21','Leyes Tributarias','10-02-2000',6,10,3,23,7);
INSERT INTO Libro values ('PK87','Guerra del Pacifico','02-08-2000',8,10,3,26,9);
INSERT INTO Libro values ('AQ29','Combate de angamos','02-06-1998',11,10,3,10,9);
INSERT INTO Libro values ('ZD19','Historia del virreinato 1','20-08-1999',17,10,1,12,9);
INSERT INTO Libro values ('ZQ95','Historia del virreinato 2','04-07-1999',12,10,1,13,9);
INSERT INTO Libro values ('XM47','Biologia Celular 1','14-03-2000',13,10,1,19,2);
