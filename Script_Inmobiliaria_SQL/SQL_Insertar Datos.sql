GO
USe Inmobiliaria_Desarrollo


GO
/*Se crea una empresa de pruebas por defecto*/
Insert Into Inmobiliaria (Nombre, Documento, Telefono, Celular, Email, Direccion, Observacion) 
					Values ('Empresa_Pruebas', '12345', '3147149858', '3147149858', 'EmpresaPruebas@gmail.com', 'Calle 3B N', 'No tenemos Observacion')



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
('La Am�rica',1,1),
('San Javier',1,1),
('El Poblado',1,1),
('Guayabal',1,1)

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



