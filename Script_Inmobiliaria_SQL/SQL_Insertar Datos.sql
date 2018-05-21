GO
USe Inmobiliaria_Desarrollo


GO
/*Se crea una empresa de pruebas por defecto*/
Insert Into Inmobiliaria (Nombre, Documento, Telefono, Celular, Email, Direccion, Observacion) 
					Values ('Empresa_Pruebas', '12345', '3147149858', '3147149858', 'EmpresaPruebas@gmail.com', 'Calle 3B N', 'No tenemos Observacion')
GO
GO
Insert Into Estados (Nombre) Values ('Disponible'),
('No Disponible'),
('Ocupado'),
('Para Vender')
GO
Insert Into Llaves (Nombre) Values ('Propietario'),
('Agencia')
GO
Insert Into Iva (Valor) Values ('0'),
('12'),
('16'),
('19')
GO

GO
Insert Into TypeListThings (Name) Values ('EstadosInmuebles'),
('EstadosCuentas'),
('EstadosUsuarios'),
('EstadosInmobiliarias'),
('EstadosPropietarios'),
('EstadosContratos'),
('Llaves'),
('Iva')
GO
Insert Into ListThings (Name, IdTypeListThings) Values ('Disponible', 1),
('No Disponible', 1),
('Ocupado', 1),
('Propietario', 7),
('Agencia', 7),
('0', 8),
('19', 8)

GO

GO
Insert Into CategoriaInmuebles (Nombre, IdInmobiliaria) Values ('Apartamento', 1),
('Casa', 1), 
('Apartaestudio', 1), 
('Bodega', 1), 
('Finca', 1),
('Local', 1), 
('Oficina', 1)
GO
GO

Insert Into Municipios (Nombre, IdInmobiliaria) Values 
('Medellin', 1),
('Bello' , 1),
('Caldas' , 1),
('Envigado' , 1),
('Itagui', 1),
('La estrella', 1)
GO

Insert Into ZonasMunicipios (Nombre, IdMunicipio, IdInmobiliaria) Values 
('Barrio Popular',1,1),
('Santa Cruz',1,1),
('Manrique',1,1),
('Aranjuez',1,1),
('Castilla',1,1),
('Doce de Octubre',1,1),
('Robledo',1,1),
('Villa Hermosa',1,1),
('Buenos Aires',1,1),
('La Candelaria',1,1),
('Laureles-Estadio',1,1),
('La América',1,1),
('San Javier',1,1),
('El Poblado',1,1),
('Bello General',2,1),
('Niquia',2,1),
('Quitasol',2,1),
('Caldas General',3,1),
('Parque',3,1),
('Parque de Envigado',4,1),
('Centro',4,1),
('Parque de la estrela',5,1)

GO

Insert Into EstadosCuentas values 
('Pagada'),
('Por Pagar'),
('Anulada')
GO

Insert Into RolesUsuarios values 
('Agente'),
('Caja'),
('Admin'),
('SuperAdmin')
GO



