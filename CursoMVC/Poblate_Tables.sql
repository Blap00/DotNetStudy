

select * from USUARIO


--insert into USUARIO(Nombres, Apellidos, Correo, Clave) values ('test nombre', 'test apellido', 'test@example.com', 'ecd71870d1963316a97e3ac3408c9835ad8cf0f3c1bc703527c30265534f75ae')


select * from CATEGORIA;

/*insert into CATEGORIA(Descripcon) values
('Tecnologia'),
('Muebles'),
('Dormitorio'),
('Deportes')
*/
Select * from Marca;

--insert into MARCA(Descripcion) values
--('SONYTE'),
--('HPTE'),
--('LGTE'),
--('HYUNDAITE'),
--('CANONTE'),
--('ROBERTA ALLENTE')

Select * from DEPARTAMENTO;

--insert into DEPARTAMENTO(IdDepartamento,Descripcion)
--values
--('0l', 'Santiagmo'),
--('02', 'Iquique'),
--('03', 'Pto Montt' )

SELECT * FROM PROVINCIA;

--insert into PROVINCIA(IdProvincia, Descripcion, IdDepartamento)
--values
---- SANTIAGO - PROVINCIAS
--('0101', 'Maipu', '01'),
--('0102', 'Santiago' , '01'),

---- Iquique - PROVINCIAS
--('0201', 'Tarapacá ', '02'),
--('0202', 'Tamarugal ', '02'),
--('0203', 'Tocopilla ', '02'),

---- Pto Montt - PROVINCIAS
--('0301', 'Llanquihue  ', '03'),
--('0302', 'Osorno ', '03')

select * from DISTRITO;

----------delete from DISTRITO;
--insert into DISTRITO(IdDistrito,Descripcion, IdProvincia, IdDepartamento) values
---- Maipu - Distrito
--('010101', '8vo Distrito', '0101', '01'),
---- Santiago - Distrito
--('010201', '8vo Distrito', '0102', '01'),
---- Tarapacá - Distrito
--('020101', '2do Distrito', '0201', '02'),
---- Tamarugal - Distrito
--('020201', '2do Distrito', '0202', '02'),
---- Tocopilla - Distrito
--('020301', '3er Distrito', '0203', '02'),
---- Llanquihue - Distrito
--('030101', '25vo Distrito', '0301', '03'),
---- Osorno - Distrito
--('030201', '25vo Distrito', '0302', '03')

