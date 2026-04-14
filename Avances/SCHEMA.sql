Create database SmartTechShop;

USE SmartTechShop;
CREATE TABLE Clientes(
IdCliente INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR (100) NOT NULL,
Telefono VARCHAR (20) NOT NULL,
Correo Varchar (100),
Direccion Varchar (150)
);
select * from Clientes;
USE SmartTechShop;
CREATE TABLE Ordenes (
IdOrden INT IDENTITY(1,1) PRIMARY KEY,
IdCliente INT NOT NULL,
Fecha VARCHAR(20) NOT NULL,
Total Decimal(10,2) NOT NULL,
Descripcion VARCHAR(150),
Cantidad INT,
Precio DECIMAL(10,2),
Estado VARCHAR(50),
Entrega VARCHAR(100),
FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);
select * from Ordenes;

