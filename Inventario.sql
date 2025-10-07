CREATE DATABASE Inventario;
GO

USE Inventario;
GO



/*Noé David Saravia Siliezar   - 20250065
  Rodrigo Alejandro Tisnado Corpeño  - 20250488*/


  /*Enunciado 3 : Sistema de inventario*/


CREATE TABLE Rol (
    idRol INT IDENTITY(1,1) PRIMARY KEY,
    nombreRol VARCHAR(25) NOT NULL UNIQUE
);
GO

/*Tablas padres*/

CREATE TABLE Usuario (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreUsuario VARCHAR(100) UNIQUE NOT NULL,
    clave VARCHAR(100) NOT NULL UNIQUE,
    estadoUsuario BIT NOT NULL DEFAULT 0,
    id_Rol INT NOT NULL,
    primerLogin BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Usuario_Rol FOREIGN KEY (id_Rol)
        REFERENCES Rol(idRol) ON DELETE CASCADE
);
GO

CREATE TABLE Productos (
    ProductoID INT IDENTITY(1,1) PRIMARY KEY,
    NombreProducto VARCHAR(100) NOT NULL UNIQUE,
    DescripcionProducto VARCHAR(200) NULL ,
    PrecioProducto DECIMAL(18,2) NOT NULL CHECK (PrecioProducto >= 0),
    CantidadProducto int not null
);
GO

CREATE TABLE Empleados (
    EmpleadoID INT IDENTITY(1,1) PRIMARY KEY,
    NombreEmpleado VARCHAR(50) NOT NULL,
    Apellidos VARCHAR(50) NOT NULL,
    Telefono VARCHAR(20)  UNIQUE,
    Correo NVARCHAR(50) NULL UNIQUE
);
GO

CREATE TABLE Cliente (
    idCliente INT IDENTITY(1,1) PRIMARY KEY,
    nombreCliente NVARCHAR(100) NOT NULL,
    direccionCliente NVARCHAR(200) NOT NULL,
    telefonoCliente VARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE Ventas (
    VentaID INT IDENTITY(1,1) PRIMARY KEY,
    ProductoID INT NOT NULL,
    EmpleadoID INT NOT NULL,
    ClienteID INT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    Total DECIMAL(18,2) NOT NULL CHECK (Total >= 0),
    CONSTRAINT FK_Ventas_Producto FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID),
    CONSTRAINT FK_Ventas_Empleado FOREIGN KEY (EmpleadoID) REFERENCES Empleados(EmpleadoID),
    CONSTRAINT FK_Ventas_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(idCliente)
);
GO
   

   /*Roles*/



INSERT INTO Rol (nombreRol) VALUES
('Administrador'),
('Almacenista'),
('Vendedor');
GO



/*Select de cada tabla*/

SELECT * FROM Rol;
GO
SELECT * FROM Usuario;
GO
SELECT * FROM Productos;
GO
SELECT * FROM Empleados;
GO
SELECT * FROM Cliente;
GO
SELECT * FROM Ventas;
GO



