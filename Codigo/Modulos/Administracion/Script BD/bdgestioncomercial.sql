-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 30-10-2023 a las 23:41:15
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdgestioncomercial`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cliente`
--

DROP TABLE IF EXISTS `tbl_cliente`;
CREATE TABLE IF NOT EXISTS `tbl_cliente` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `cli_Nombre` varchar(60) NOT NULL,
  `cli_Telefono` int NOT NULL,
  `cli_NIT` int NOT NULL,
  `cli_Estado` varchar(60) NOT NULL,
  `cli_tipo` varchar(60) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_cliente`
--

INSERT INTO `tbl_cliente` (`id_cliente`, `cli_Nombre`, `cli_Telefono`, `cli_NIT`, `cli_Estado`, `cli_tipo`) VALUES
(1, 'Cliente 1', 1234567890, 12345, 'Activo', 'Tipo 1'),
(2, 'Cliente 2', 2147483647, 54321, 'Inactivo', 'Tipo 2'),
(3, 'Cliente 3', 2147483647, 99999, 'Activo', 'Tipo 3'),
(4, 'Cliente 4', 1111111111, 77777, 'Inactivo', 'Tipo 1'),
(5, 'Cliente 5', 2147483647, 22222, 'Activo', 'Tipo 2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cobrador`
--

DROP TABLE IF EXISTS `tbl_cobrador`;
CREATE TABLE IF NOT EXISTS `tbl_cobrador` (
  `id_cobrador` int NOT NULL AUTO_INCREMENT,
  `cob_Nombre` varchar(60) NOT NULL,
  `cob_Domicilio` varchar(60) NOT NULL,
  `cob_Nit` int NOT NULL,
  `cob_Telefono` int NOT NULL,
  `cob_Tipo` varchar(60) NOT NULL,
  `cob_Estado` varchar(60) NOT NULL,
  PRIMARY KEY (`id_cobrador`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_compras`
--

DROP TABLE IF EXISTS `tbl_compras`;
CREATE TABLE IF NOT EXISTS `tbl_compras` (
  `com_id` int NOT NULL AUTO_INCREMENT,
  `com_fechasolicitud` date DEFAULT NULL,
  `com_fechaentrega` date DEFAULT NULL,
  `com_deptosolicitante` varchar(255) DEFAULT NULL,
  `com_recibidopor` varchar(255) DEFAULT NULL,
  `com_subtotal` double DEFAULT NULL,
  `com_iva` double DEFAULT NULL,
  `com_totalcompra` double DEFAULT NULL,
  `com_totalLetras` varchar(255) DEFAULT NULL,
  `fk_empleado_id` int NOT NULL,
  `fk_ord_id` int NOT NULL,
  `fk_proveedor_id` int NOT NULL,
  PRIMARY KEY (`com_id`),
  KEY `fk_tbl_compras_tbl_empleado1` (`fk_empleado_id`),
  KEY `fk_tbl_compras_tbl_ordenesCompra1` (`fk_ord_id`),
  KEY `fk_tbl_compras_tbl_proveedor1` (`fk_proveedor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_concepto`
--

DROP TABLE IF EXISTS `tbl_concepto`;
CREATE TABLE IF NOT EXISTS `tbl_concepto` (
  `id_concepto` int NOT NULL AUTO_INCREMENT,
  `con_Descripcion` varchar(60) NOT NULL,
  `con_Tipo` varchar(60) NOT NULL,
  `con_SerieConcepto` int NOT NULL,
  PRIMARY KEY (`id_concepto`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_concepto`
--

INSERT INTO `tbl_concepto` (`id_concepto`, `con_Descripcion`, `con_Tipo`, `con_SerieConcepto`) VALUES
(1, 'Concepto 1', 'Tipo A', 1001),
(2, 'Concepto 2', 'Tipo B', 1002),
(3, 'Concepto 3', 'Tipo C', 1003),
(4, 'Concepto 4', 'Tipo A', 1004),
(5, 'Concepto 5', 'Tipo B', 1005);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detallemovimientocliente`
--

DROP TABLE IF EXISTS `tbl_detallemovimientocliente`;
CREATE TABLE IF NOT EXISTS `tbl_detallemovimientocliente` (
  `id_DetalleCliente` int NOT NULL AUTO_INCREMENT,
  `CodigoEncabezadoCliente` int NOT NULL,
  `CodigoConceptoCliente` int NOT NULL,
  `Detalle_valor` int NOT NULL,
  PRIMARY KEY (`id_DetalleCliente`),
  KEY `CodigoEncabezadoCliente` (`CodigoEncabezadoCliente`),
  KEY `CodigoConceptoCliente` (`CodigoConceptoCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_detallemovimientocliente`
--

INSERT INTO `tbl_detallemovimientocliente` (`id_DetalleCliente`, `CodigoEncabezadoCliente`, `CodigoConceptoCliente`, `Detalle_valor`) VALUES
(1, 1, 1, 50),
(2, 2, 5, 45);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detallemovimientoproveedor`
--

DROP TABLE IF EXISTS `tbl_detallemovimientoproveedor`;
CREATE TABLE IF NOT EXISTS `tbl_detallemovimientoproveedor` (
  `id_DetalleProveedor` int NOT NULL AUTO_INCREMENT,
  `CodigoEncabezadoProveedor` int NOT NULL,
  `CodigoConceptoProveedor` int NOT NULL,
  `detalleProveedor_valor` int NOT NULL,
  PRIMARY KEY (`id_DetalleProveedor`),
  KEY `CodigoEncabezadoProveedor` (`CodigoEncabezadoProveedor`),
  KEY `CodigoConceptoProveedor` (`CodigoConceptoProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_detallemovimientoproveedor`
--

INSERT INTO `tbl_detallemovimientoproveedor` (`id_DetalleProveedor`, `CodigoEncabezadoProveedor`, `CodigoConceptoProveedor`, `detalleProveedor_valor`) VALUES
(1, 1, 3, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalleordenescompra`
--

DROP TABLE IF EXISTS `tbl_detalleordenescompra`;
CREATE TABLE IF NOT EXISTS `tbl_detalleordenescompra` (
  `det_id_ordenes` int NOT NULL AUTO_INCREMENT,
  `det_cantidad_orde` int NOT NULL,
  `det_totalPorProducto` double NOT NULL,
  `fk_det_ord_id` int NOT NULL,
  `fk_det_producto_id` int NOT NULL,
  PRIMARY KEY (`det_id_ordenes`),
  KEY `fk_tbl_detalleOrdenesCompra_tbl_ordenesCompra1` (`fk_det_ord_id`),
  KEY `fk_tbl_detalleOrdenesCompra_tbl_productos1` (`fk_det_producto_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_compras`
--

DROP TABLE IF EXISTS `tbl_detalle_compras`;
CREATE TABLE IF NOT EXISTS `tbl_detalle_compras` (
  `det_id` int NOT NULL AUTO_INCREMENT,
  `det_cantidad_compra` int NOT NULL,
  `det_totalPorProducto` double DEFAULT NULL,
  `fk_det_compras_id` int NOT NULL,
  `fk_det_producto_id` int NOT NULL,
  PRIMARY KEY (`det_id`),
  KEY `fk_tbl_detalle_compras_tbl_compras1` (`fk_det_compras_id`),
  KEY `fk_tbl_detalle_compras_tbl_productos1` (`fk_det_producto_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_empleado`
--

DROP TABLE IF EXISTS `tbl_empleado`;
CREATE TABLE IF NOT EXISTS `tbl_empleado` (
  `emp_id` int NOT NULL AUTO_INCREMENT,
  `emp_nombre` varchar(255) DEFAULT NULL,
  `emp_departamento` varchar(255) DEFAULT NULL,
  `emp_cargo` varchar(255) DEFAULT NULL,
  `emp_telefono` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`emp_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_encabezadomovimientocliente`
--

DROP TABLE IF EXISTS `tbl_encabezadomovimientocliente`;
CREATE TABLE IF NOT EXISTS `tbl_encabezadomovimientocliente` (
  `id_EncabezadoCliente` int NOT NULL AUTO_INCREMENT,
  `CodigoCliente` int NOT NULL,
  `encabezadoCliente_FechaEmision` date NOT NULL,
  `encabezadoCliente_FechaVencimiento` date NOT NULL,
  PRIMARY KEY (`id_EncabezadoCliente`),
  KEY `CodigoCliente` (`CodigoCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_encabezadomovimientocliente`
--

INSERT INTO `tbl_encabezadomovimientocliente` (`id_EncabezadoCliente`, `CodigoCliente`, `encabezadoCliente_FechaEmision`, `encabezadoCliente_FechaVencimiento`) VALUES
(1, 1, '2023-10-27', '2023-10-31'),
(2, 4, '2023-10-27', '2023-10-27');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_encabezadomovimientoproveedor`
--

DROP TABLE IF EXISTS `tbl_encabezadomovimientoproveedor`;
CREATE TABLE IF NOT EXISTS `tbl_encabezadomovimientoproveedor` (
  `id_EncabezadoProveedor` int NOT NULL AUTO_INCREMENT,
  `CodigoProveedor` int NOT NULL,
  `encabezadoProveedor_FechaEmision` date NOT NULL,
  `encabezadoProveedor_FechaVencimiento` date NOT NULL,
  PRIMARY KEY (`id_EncabezadoProveedor`),
  KEY `CodigoProveedor` (`CodigoProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_encabezadomovimientoproveedor`
--

INSERT INTO `tbl_encabezadomovimientoproveedor` (`id_EncabezadoProveedor`, `CodigoProveedor`, `encabezadoProveedor_FechaEmision`, `encabezadoProveedor_FechaVencimiento`) VALUES
(1, 2, '2023-10-27', '2023-10-27');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ordenescompra`
--

DROP TABLE IF EXISTS `tbl_ordenescompra`;
CREATE TABLE IF NOT EXISTS `tbl_ordenescompra` (
  `ord_id` int NOT NULL AUTO_INCREMENT,
  `ord_FechaSolicitud` date DEFAULT NULL,
  `ord_FechaEntrega` date DEFAULT NULL,
  `ord_deptosolicitante` varchar(255) DEFAULT NULL,
  `ord_subtotal` double NOT NULL,
  `ord_iva` double NOT NULL,
  `ord_totalOrden` double NOT NULL,
  `ord_totalLetras` varchar(255) DEFAULT NULL,
  `fk_proveedor_id` int NOT NULL,
  `fk_empleado_id` int NOT NULL,
  `ord_entregara` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ord_id`),
  KEY `fk_tbl_ordenesCompra_tbl_proveedor1` (`fk_proveedor_id`),
  KEY `fk_tbl_ordenesCompra_tbl_empleado1` (`fk_empleado_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_productos`
--

DROP TABLE IF EXISTS `tbl_productos`;
CREATE TABLE IF NOT EXISTS `tbl_productos` (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `pro_nombre` varchar(255) DEFAULT NULL,
  `pro_descripcion` varchar(255) DEFAULT NULL,
  `pro_preciounitario` double NOT NULL,
  `pro_fecha` date DEFAULT NULL,
  `pro_monto` double DEFAULT NULL,
  `pro_disponibilidad` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_proveedor`
--

DROP TABLE IF EXISTS `tbl_proveedor`;
CREATE TABLE IF NOT EXISTS `tbl_proveedor` (
  `id_proveedor` int NOT NULL AUTO_INCREMENT,
  `pro_Nombre` varchar(60) NOT NULL,
  `pro_Domicilio` varchar(60) NOT NULL,
  `pro_Nit` int NOT NULL,
  `pro_Telefono` int NOT NULL,
  `pro_Tipo` varchar(60) NOT NULL,
  `pro_Estado` varchar(60) NOT NULL,
  `pro_RepresentanteLegal` varchar(60) NOT NULL,
  `pro_Empresa` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_proveedor`
--

INSERT INTO `tbl_proveedor` (`id_proveedor`, `pro_Nombre`, `pro_Domicilio`, `pro_Nit`, `pro_Telefono`, `pro_Tipo`, `pro_Estado`, `pro_RepresentanteLegal`, `pro_Empresa`) VALUES
(1, 'Proveedor 1', 'Domicilio 1', 2147483647, 2147483647, 'Tipo 1', 'Activo', 'Representante 1', 'Empresa 1'),
(2, 'Proveedor 2', 'Domicilio 2', 2147483647, 2147483647, 'Tipo 2', 'Inactivo', 'Representante 2', 'Empresa 2'),
(3, 'Proveedor 3', 'Domicilio 3', 2147483647, 2147483647, 'Tipo 3', 'Activo', 'Representante 3', 'Empresa 3'),
(4, 'Proveedor 4', 'Domicilio 4', 2147483647, 2147483647, 'Tipo 4', 'Inactivo', 'Representante 4', 'Empresa 4'),
(5, 'Proveedor 5', 'Domicilio 5', 2147483647, 2147483647, 'Tipo 5', 'Activo', 'Representante 5', 'Empresa 5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_vendedor`
--

DROP TABLE IF EXISTS `tbl_vendedor`;
CREATE TABLE IF NOT EXISTS `tbl_vendedor` (
  `id_vendedor` int NOT NULL AUTO_INCREMENT,
  `ven_nombre` varchar(255) DEFAULT NULL,
  `ven_Nit` int NOT NULL,
  `ven_cargo` varchar(255) DEFAULT NULL,
  `ven_telefono` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_compras`
--
ALTER TABLE `tbl_compras`
  ADD CONSTRAINT `fk_tbl_compras_tbl_empleado1` FOREIGN KEY (`fk_empleado_id`) REFERENCES `tbl_empleado` (`emp_id`),
  ADD CONSTRAINT `fk_tbl_compras_tbl_ordenesCompra1` FOREIGN KEY (`fk_ord_id`) REFERENCES `tbl_ordenescompra` (`ord_id`),
  ADD CONSTRAINT `fk_tbl_compras_tbl_proveedor1` FOREIGN KEY (`fk_proveedor_id`) REFERENCES `tbl_proveedor` (`id_proveedor`);

--
-- Filtros para la tabla `tbl_detallemovimientocliente`
--
ALTER TABLE `tbl_detallemovimientocliente`
  ADD CONSTRAINT `tbl_detallemovimientocliente_ibfk_1` FOREIGN KEY (`CodigoEncabezadoCliente`) REFERENCES `tbl_encabezadomovimientocliente` (`id_EncabezadoCliente`),
  ADD CONSTRAINT `tbl_detallemovimientocliente_ibfk_2` FOREIGN KEY (`CodigoConceptoCliente`) REFERENCES `tbl_concepto` (`id_concepto`);

--
-- Filtros para la tabla `tbl_detallemovimientoproveedor`
--
ALTER TABLE `tbl_detallemovimientoproveedor`
  ADD CONSTRAINT `tbl_detallemovimientoproveedor_ibfk_1` FOREIGN KEY (`CodigoEncabezadoProveedor`) REFERENCES `tbl_encabezadomovimientoproveedor` (`id_EncabezadoProveedor`),
  ADD CONSTRAINT `tbl_detallemovimientoproveedor_ibfk_2` FOREIGN KEY (`CodigoConceptoProveedor`) REFERENCES `tbl_concepto` (`id_concepto`);

--
-- Filtros para la tabla `tbl_detalleordenescompra`
--
ALTER TABLE `tbl_detalleordenescompra`
  ADD CONSTRAINT `fk_tbl_detalleOrdenesCompra_tbl_ordenesCompra1` FOREIGN KEY (`fk_det_ord_id`) REFERENCES `tbl_ordenescompra` (`ord_id`),
  ADD CONSTRAINT `fk_tbl_detalleOrdenesCompra_tbl_productos1` FOREIGN KEY (`fk_det_producto_id`) REFERENCES `tbl_productos` (`id_producto`);

--
-- Filtros para la tabla `tbl_detalle_compras`
--
ALTER TABLE `tbl_detalle_compras`
  ADD CONSTRAINT `fk_tbl_detalle_compras_tbl_compras1` FOREIGN KEY (`fk_det_compras_id`) REFERENCES `tbl_compras` (`com_id`),
  ADD CONSTRAINT `fk_tbl_detalle_compras_tbl_productos1` FOREIGN KEY (`fk_det_producto_id`) REFERENCES `tbl_productos` (`id_producto`);

--
-- Filtros para la tabla `tbl_encabezadomovimientocliente`
--
ALTER TABLE `tbl_encabezadomovimientocliente`
  ADD CONSTRAINT `tbl_encabezadomovimientocliente_ibfk_1` FOREIGN KEY (`CodigoCliente`) REFERENCES `tbl_cliente` (`id_cliente`);

--
-- Filtros para la tabla `tbl_encabezadomovimientoproveedor`
--
ALTER TABLE `tbl_encabezadomovimientoproveedor`
  ADD CONSTRAINT `tbl_encabezadomovimientoproveedor_ibfk_1` FOREIGN KEY (`CodigoProveedor`) REFERENCES `tbl_proveedor` (`id_proveedor`);

--
-- Filtros para la tabla `tbl_ordenescompra`
--
ALTER TABLE `tbl_ordenescompra`
  ADD CONSTRAINT `fk_tbl_ordenesCompra_tbl_empleado1` FOREIGN KEY (`fk_empleado_id`) REFERENCES `tbl_empleado` (`emp_id`),
  ADD CONSTRAINT `fk_tbl_ordenesCompra_tbl_proveedor1` FOREIGN KEY (`fk_proveedor_id`) REFERENCES `tbl_proveedor` (`id_proveedor`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
