-- Autores:Luis Franco 0901-20-23979
-- IMPORTANTE: ESTO NO ES LA BASE DE DATOS FINAL DEL AREA DE REPORTEADOR, AQUI SOLO SE IMPLEMENTA LA TABLA APLICACION DEL AREA
-- DE SEGURIDAD PARA PODER HACER LAS PRUEBAS PERTINENTES
-- USAR EN ODBC LO SIGUIENTE: name: bd_reporteador_pruebas BD: BD_reporteador_pruebas
-- Cualquier duda escribirme (Luis Franco)





-- Crear la base de datos si no existe
CREATE DATABASE IF NOT EXISTS BD_reporteador_pruebas;
-- LA CONEXION A ODBC DEBE DE IR CON EL NOMBRE "BD_reporteador"
-- Usar la base de datos
USE BD_reporteador_pruebas;

-- Crear la tabla Estados
CREATE TABLE tbl_estados (
    pk_id_estado INT AUTO_INCREMENT PRIMARY KEY,
    nbr_info_estado VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
    nbr_num_estado INT
);

-- Crear la tabla Reportes
CREATE TABLE tbl_reportes (
    pk_id_reporte INT AUTO_INCREMENT PRIMARY KEY,
    nbr_correlativo INT UNIQUE,
    nbr_nombre VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
    fk_estado INT,
    nbr_fecha DATETIME,
    nbr_archivo VARCHAR(120) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
    nbr_fechaMod datetime,
    FOREIGN KEY (fk_estado) REFERENCES tbl_estados(pk_id_estado)
)ENGINE = InnoDB CHARACTER SET = utf8 collate = utf8_general_ci;

CREATE TABLE tbl_APLICACION(
  PK_id_aplicacion INT NOT NULL AUTO_INCREMENT primary key,
  nbr_nombre_aplicacion VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
  nbr_descripcion_aplicacion VARCHAR(200) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  fk_no_reporteAsociado INT NULL DEFAULT NULL,
  nbr_estado_aplicacion INT NULL DEFAULT NULL,
  foreign key (fk_no_reporteAsociado) references tbl_reportes(nbr_correlativo)

)ENGINE = InnoDB CHARACTER SET = utf8 collate = utf8_general_ci;



-- HACER PRIMERO LA CREACION DE LAS TABLAS
-- DESPUES DE CREARLAS, INGRESAR DATOS DE LA TABLA ESTADOS DEFINIDOS A CONTINUACION
insert into `tbl_estados` (`pk_id_estado`, `nbr_info_estado`, `nbr_num_estado`) VALUES 
(1, 'Activo', 1),(2, 'Eliminado', 2), (3, 'Modificado', 3) ;

-- CUANDO YA ESTEN LOS DATOS CREADOS DENTRO DE LA TABLA DE ESTADOS, CREAR LOS DATOS INICIALES PARA LA TABLA REPORTES
insert into `tbl_reportes` (`pk_id_reporte`, `nbr_correlativo`, `nbr_nombre`, `fk_estado`) VALUES 
(10, 10002, 'planilssla.txt', 1);

insert into `tbl_APLICACION` ( `PK_id_aplicacion`, `nbr_nombre_aplicacion`,   `nbr_descripcion_aplicacion`, `fk_no_reporteAsociado`, `nbr_estado_aplicacion`) 
VALUES (
1, "App pagos", "Aplicacion para manejar pagos", 10001, 1
);


-- TENIENDO YA TODO CREADO E INGRESADO, HACER EL SELECT DE LA TABLA REPORTES Y YA SE PUEDE TRABAJAR CON EL PROGRAMA EN CONJUNTO
select * from tbl_reportes;
select * from tbl_APLICACION;