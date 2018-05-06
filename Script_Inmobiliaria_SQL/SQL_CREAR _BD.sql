/*Crear Base de datos*/

create database Inmobiliaria_Desarrollo
GO

Use Inmobiliaria_Desarrollo
create table TypeListThings(
Id int identity (1,1)  primary key NOT NULL,
Name varchar(200) Not null,
)
GO
/*Modulo de Estados*/
GO
create table ListThings(
Id int identity (1,1)  primary key NOT NULL,
NAme varchar(200) Not null,
IdTypeListThings Int Not null References TypeListThings(Id)
)
GO



/*Modulo de Inmobiliaria*/

GO
create table Inmobiliaria(
Id int identity (1,1)  primary key NOT NULL,
Nombre varchar(200) Not null,
Documento varchar(50),
Telefono varchar (30),
Celular varchar(30),
Email varchar(80),
Direccion varchar (200),
Observacion varchar(500)
)
GO

/*Modulo de Propietarios*/
GO
create table Propietarios(
Id int identity (1,1)  primary key NOT NULL,
Nombre varchar(200) not null,
Documento varchar(50),
Telefono varchar (30),
Celular varchar(30) not null,
Email varchar(80),
Direccion varchar (200),
Observacion varchar(500),
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO

Create Table CategoriaInmuebles(
Id int identity (1,1)  primary key NOT NULL,
Nombre varchar(200) not null,
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO

GO
Create Table Municipios(
Id int Identity(1,1) primary key NOT NULL,
Nombre varchar(100) not null,
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO

GO
Create Table ZonasMunicipios(
Id int identity (1,1)  primary key NOT NULL,
Nombre varchar(200) not null,
IdMunicipio int not null references Municipios(Id),
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO
Create Table Estados(
Id int identity (1,1)  primary key NOT NULL,
Nombre varchar(200) not null
)
GO
Create Table llaves(
Id int identity (1,1)  primary key NOT NULL,
Nombre varchar(200) not null
)
GO
Create Table Iva(
Id int identity (1,1)  primary key NOT NULL,
Valor Float not null
)
GO
Create Table Inmuebles(
Id Int Identity (1,1) primary key Not null,
IdEstado int references Estados(Id) not null,
IdLlaves int references Llaves(Id),
IdIva int references Iva(Id),
Codigo varchar(100) not null,
Titulo varchar(100),
Descripcion varchar(500),
Direccion varchar (200) not null,
PrecioPropietario decimal(18,2) not null,
Porcentaje decimal(18,2),
Honorarios decimal(18,2), 
FechaCaptacion date,
PrecioFinal decimal(18,2) not null,
Habitaciones Int,
Banos int,
Porteria bit,
Piscina bit,
Area Decimal(18,2),
IdMunicipio int not null references Municipios(Id),
IdZonaMunicipio int not null references ZonasMunicipios(Id),
IdPropietario Int Not null references propietarios(Id),
Observacion varchar(500),
IdCategoria Int Not null references CategoriaInmuebles(Id),
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO
Create Table Imagenes(
Id Int Identity (1,1) Primary Key Not null,
Nombre varchar(50),
Ruta varchar(150) not null,
IdInmueble Int not null References Inmuebles(Id),
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)

/*Modulo de Arredadores*/
GO
Create Table Arrendatarios(
Id int identity (1,1)  primary key NOT NULL,
Nombre varchar(200) not null,
Documento varchar(50),
Telefono varchar (30),
Celular varchar(30) not null,
Email varchar(80),
Direccion varchar (200),
Observacion varchar(500),
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)

/*Modulo de contrqtos de arrendamiento*/
GO
Create Table Contratos(
Id int identity(1,1) primary key not null ,
FechaContrato Date not null,
FechaInicio Date Not Null,
CantidadMeses Int Not Null,
ValorMensual decimal(18,2) not null,
Observacion varchar(300),
IdInmueble Int references Inmuebles(Id),
IdArrendatario int references Arrendatarios(id) not null,
IdCoArrendatario int references Arrendatarios(id),
IdFiador1 int references Arrendatarios(id),
IdFiador2 int references Arrendatarios(id),
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO
/*Tabla Maestra No tiene Id de Inmobiliara son iguales apra todos los clientes */
Create Table EstadosCuentas(
Id Int Identity(1,1) Primary Key Not Null,
Nombre Varchar (50)
)
GO
Create Table CuentasxPagarContratos(
Id Int Identity(1,1) primary key not null,
Numerocuota Int not null,
Valor Decimal(18,2) not null,
FechaVencimiento Date not null,
IdEstado int References EstadosCuentas(Id),
IdContrato Int References Contratos(Id) not null,
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO
Create Table CuentasxCobrarContratos(
Id Int Identity(1,1) primary key not null,
Numerocuota Int not null,
Valor Decimal(18,2) not null,
FechaVencimiento Date not null,
IdEstado int References EstadosCuentas(Id),
IdContrato Int References Contratos(Id) not null,
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO
/*Modulo de Pagos*/
Create Table CajaBanco(
Id Int Identity (1,1) Primary Key Not null,
Nombre Varchar(50) Not null,
IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO
/*Tipos de pagos*/
Create Table TipoPago(
Id Int Identity (1,1) Primary Key Not null,
Nombre varchar(50) Not Null,IdInmobiliaria Int Not null References Inmobiliaria(Id)
)
GO
Create Table RegistroIngresos(
Id Int Identity (1,1) Primary Key Not null,
Fecha Date Not null,
Tipo Int References TipoPago(Id) Not null,
Valor Decimal(18,2) Not Null,
Mora Decimal(18,2) Not Null,
Descuento Decimal(18,2) Not Null,
Iva Decimal(18,2) Not Null,
Total Decimal(18,2) Not Null,
IdCajaBanco Int References CajaBanco(Id) Not null,
IdCuentasxPagarContratos Int References CuentasxPagarContratos(Id),
IdCuentasxCobrarContratos Int References CuentasxCobrarContratos(Id),
Nombre varchar(50) Not Null,IdInmobiliaria Int Not null References Inmobiliaria(Id)

)
GO
Create Table RegistroEgresos(
Id Int Identity (1,1) Primary Key Not null,
Fecha Date Not null,
Tipo Int References TipoPago(Id) Not null,
Valor Decimal(18,2) Not Null,
Mora Decimal(18,2) Not Null,
Descuento Decimal(18,2) Not Null,
Iva Decimal(18,2) Not Null,
Total Decimal(18,2) Not Null,
IdCajaBanco Int References CajaBanco(Id) Not null,
IdCuentasxPagarContratos Int References CuentasxPagarContratos(Id),
IdCuentasxCobrarContratos Int References CuentasxCobrarContratos(Id),
Nombre varchar(50) Not Null,IdInmobiliaria Int Not null References Inmobiliaria(Id)

)
GO

/*Modulo de Usuarios -- Es maestra no necesita Id de Inmobiliaria*/
GO
Create Table RolesUsuarios(
Id Int Identity (1,1) Primary Key Not null,
Nombre varchar(50) Not Null
)
GO
Create Table Usuarios(
Id Int Identity (1,1) Primary Key Not null,
Nombre Varchar(50),
Email Varchar(200) Not null,
Pass Varchar(50) Not null,
Estado Varchar(50) Not null,
Rol Int References RolesUsuarios(Id) Not Null,
FechaAdd Date,
IdInmobiliaria Int Not null References Inmobiliaria(Id)

)