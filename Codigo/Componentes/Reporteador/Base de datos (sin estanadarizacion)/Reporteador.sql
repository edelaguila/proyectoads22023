-- Crear la base de datos si no existe
CREATE DATABASE IF NOT EXISTS Reporteador;

-- Usar la base de datos
USE Reporteador;

-- Crear la tabla Estados
CREATE TABLE Estados (
    id_estado INT AUTO_INCREMENT PRIMARY KEY,
    info_estado VARCHAR(255),
    num_estado INT
);

-- Crear la tabla Reportes
CREATE TABLE Reportes (
    id_reporte INT AUTO_INCREMENT PRIMARY KEY,
    correlativo VARCHAR(255),
    nombre VARCHAR(255),
    estado INT,
    fecha DATETIME,
    archivo longblob,
    fechaMod datetime,
    FOREIGN KEY (estado) REFERENCES Estados(id_estado)
);
insert into `Estados` (`id_estado`, `info_estado`, `num_estado`) VALUES 
(1, 'Activo', 1),(2, 'Eliminado', 2), (3, 'Modificado', 3) ;
insert into `Reportes` (`id_reporte`, `correlativo`, `nombre`, `estado`, `fecha`) VALUES 
(2, 2120923, 'planilla.txt', 1, 2023-09-12);
select * from reportes;