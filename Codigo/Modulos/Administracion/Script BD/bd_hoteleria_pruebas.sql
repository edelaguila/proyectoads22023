-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 07-11-2023 a las 03:11:04
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
-- Base de datos: `bd_hoteleria_pruebas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicaciones`
--

DROP TABLE IF EXISTS `tbl_aplicaciones`;
CREATE TABLE IF NOT EXISTS `tbl_aplicaciones` (
  `pk_id_aplicacion` int NOT NULL,
  `nombre_aplicacion` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion_aplicacion` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `estado_aplicacion` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_aplicaciones`
--

INSERT INTO `tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 'Menu', 'Ingreso Login', 1),
(999, 'Cerrar Sesion', 'Cerrar Sesion', 1),
(1000, 'MDI SEGURIDAD', 'PARA SEGURIDAD', 1),
(1001, 'Mant. Usuario', 'PARA SEGURIDAD', 1),
(1002, 'Mant. Aplicación', 'PARA SEGURIDAD', 1),
(1003, 'Mant. Modulo', 'PARA SEGURIDAD', 1),
(1004, 'Mant. Perfil', 'PARA SEGURIDAD', 1),
(1101, 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', 1),
(1102, 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', 1),
(1103, 'Asign. Perfil Usuario', 'PARA SEGURIDAD', 1),
(1201, 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', 1),
(1301, 'Pcs. BITACORA', 'PARA SEGURIDAD', 1),
(3000, 'MDI VENTAS', 'PARA VENTAS', 1),
(3001, 'Clientes', 'PARA VENTAS', 1),
(3002, 'Concepto', 'PARA VENTAS', 1),
(3003, 'Movimiento Cliente', 'PARA VENTAS', 1),
(3004, 'Cotizaciones', 'PARA VENTAS', 1),
(3005, 'Pedidos', 'PARA VENTAS', 1),
(3006, 'Factura', 'PARA VENTAS', 1),
(3007, 'Mant. Clientes', 'PARA VENTAS', 1),
(3008, 'Mant. Concepto', 'PARA VENTAS', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacionesperfilsusuario`
--

DROP TABLE IF EXISTS `tbl_asignacionesperfilsusuario`;
CREATE TABLE IF NOT EXISTS `tbl_asignacionesperfilsusuario` (
  `fk_id_usuario` int NOT NULL,
  `fk_id_perfil` int NOT NULL,
  PRIMARY KEY (`fk_id_usuario`,`fk_id_perfil`),
  KEY `fk_id_perfil` (`fk_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_asignacionesperfilsusuario`
--

INSERT INTO `tbl_asignacionesperfilsusuario` (`fk_id_usuario`, `fk_id_perfil`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacionmoduloaplicacion`
--

DROP TABLE IF EXISTS `tbl_asignacionmoduloaplicacion`;
CREATE TABLE IF NOT EXISTS `tbl_asignacionmoduloaplicacion` (
  `fk_id_modulos` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  PRIMARY KEY (`fk_id_modulos`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_asignacionmoduloaplicacion`
--

INSERT INTO `tbl_asignacionmoduloaplicacion` (`fk_id_modulos`, `fk_id_aplicacion`) VALUES
(1000, 1000),
(1000, 1001),
(1000, 1002),
(1000, 1003),
(1000, 1004),
(1000, 1102),
(1000, 1103),
(1000, 1201),
(1000, 1301),
(3000, 3000),
(3000, 3001),
(3000, 3002),
(3000, 3003),
(3000, 3004),
(3000, 3005),
(3000, 3006),
(3000, 3007),
(3000, 3008);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacoradeeventos`
--

DROP TABLE IF EXISTS `tbl_bitacoradeeventos`;
CREATE TABLE IF NOT EXISTS `tbl_bitacoradeeventos` (
  `pk_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `fk_id_usuario` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_id_bitacora`),
  KEY `fk_id_usuario` (`fk_id_usuario`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_bitacoradeeventos`
--

INSERT INTO `tbl_bitacoradeeventos` (`pk_id_bitacora`, `fk_id_usuario`, `fk_id_aplicacion`, `fecha_bitacora`, `hora_bitacora`, `host_bitacora`, `ip_bitacora`, `accion_bitacora`) VALUES
(1, 1, 1, '2023-11-06', '20:30:47', 'ASPIRECG', '::1c29:f40a:8f98:194', 'Ingreso Login'),
(2, 1, 1, '2023-11-06', '20:35:11', 'ASPIRECG', '::1c29:f40a:8f98:194', 'Ingreso Login');

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
  `fk_ord_id` int NOT NULL,
  `fk_proveedor_id` int NOT NULL,
  PRIMARY KEY (`com_id`),
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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulos`
--

DROP TABLE IF EXISTS `tbl_modulos`;
CREATE TABLE IF NOT EXISTS `tbl_modulos` (
  `pk_id_modulos` int NOT NULL,
  `nombre_modulo` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion_modulo` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `estado_modulo` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_modulos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_modulos`
--

INSERT INTO `tbl_modulos` (`pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1000, 'SEGURIDAD', 'Seguridad', 1),
(3000, 'VENTAS', 'Ventas', 1);

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
  `ord_entregara` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ord_id`),
  KEY `fk_tbl_ordenesCompra_tbl_proveedor1` (`fk_proveedor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfiles`
--

DROP TABLE IF EXISTS `tbl_perfiles`;
CREATE TABLE IF NOT EXISTS `tbl_perfiles` (
  `pk_id_perfil` int NOT NULL AUTO_INCREMENT,
  `nombre_perfil` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion_perfil` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `estado_perfil` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_perfiles`
--

INSERT INTO `tbl_perfiles` (`pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
(2, 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisosaplicacionesusuario`
--

DROP TABLE IF EXISTS `tbl_permisosaplicacionesusuario`;
CREATE TABLE IF NOT EXISTS `tbl_permisosaplicacionesusuario` (
  `fk_id_aplicacion` int NOT NULL,
  `fk_id_usuario` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_aplicacion`,`fk_id_usuario`),
  KEY `fk_id_usuario` (`fk_id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisosaplicacionperfil`
--

DROP TABLE IF EXISTS `tbl_permisosaplicacionperfil`;
CREATE TABLE IF NOT EXISTS `tbl_permisosaplicacionperfil` (
  `fk_id_perfil` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_perfil`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_permisosaplicacionperfil`
--

INSERT INTO `tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES
(1, 1000, 1, 1, 1, 1, 1),
(1, 1001, 1, 1, 1, 1, 1),
(1, 1002, 1, 1, 1, 1, 1),
(1, 1003, 1, 1, 1, 1, 1),
(1, 1004, 1, 1, 1, 1, 1),
(1, 1101, 1, 1, 1, 1, 1),
(1, 1102, 1, 1, 1, 1, 1),
(1, 1103, 1, 1, 1, 1, 1),
(1, 1201, 1, 1, 1, 1, 1),
(1, 1301, 1, 1, 1, 1, 1),
(1, 3000, 1, 1, 1, 1, 1),
(1, 3001, 1, 1, 1, 1, 1),
(1, 3002, 1, 1, 1, 1, 1),
(1, 3003, 1, 1, 1, 1, 1),
(1, 3004, 1, 1, 1, 1, 1),
(1, 3005, 1, 1, 1, 1, 1),
(1, 3006, 1, 1, 1, 1, 1),
(1, 3007, 1, 1, 1, 1, 1),
(1, 3008, 1, 1, 1, 1, 1);

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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuarios`
--

DROP TABLE IF EXISTS `tbl_usuarios`;
CREATE TABLE IF NOT EXISTS `tbl_usuarios` (
  `pk_id_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `apellido_usuario` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `username_usuario` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `password_usuario` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `email_usuario` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `estado_usuario` tinyint NOT NULL DEFAULT '0',
  `pregunta` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `respuesta` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`pk_id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_usuarios`
--

INSERT INTO `tbl_usuarios` (`pk_id_usuario`, `nombre_usuario`, `apellido_usuario`, `username_usuario`, `password_usuario`, `email_usuario`, `estado_usuario`, `pregunta`, `respuesta`) VALUES
(1, 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', 1, 'COLOR FAVORITO', 'X9yc1/l1b2A=');

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

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_aplicacionusuario`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_aplicacionusuario`;
CREATE TABLE IF NOT EXISTS `vista_aplicacionusuario` (
`Aplicacion` int
,`ID` int
,`Usuario` varchar(50)
,`Insertar` tinyint(1)
,`Editar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_aplicacion_perfil`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_aplicacion_perfil`;
CREATE TABLE IF NOT EXISTS `vista_aplicacion_perfil` (
`ID` int
,`Perfil` varchar(50)
,`Aplicacion` int
,`Insertar` tinyint(1)
,`Modificar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_modulo_aplicacion`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_modulo_aplicacion`;
CREATE TABLE IF NOT EXISTS `vista_modulo_aplicacion` (
`ID` int
,`Modulo` varchar(50)
,`Aplicacion` int
,`Nombre` varchar(50)
,`Descripcion` varchar(150)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_perfil_usuario`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_perfil_usuario`;
CREATE TABLE IF NOT EXISTS `vista_perfil_usuario` (
`ID` int
,`Usuario` varchar(50)
,`nickName` varchar(20)
,`perfil` int
,`Nombre` varchar(50)
);

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_aplicacionusuario`
--
DROP TABLE IF EXISTS `vista_aplicacionusuario`;

DROP VIEW IF EXISTS `vista_aplicacionusuario`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_aplicacionusuario`  AS SELECT `b`.`fk_id_aplicacion` AS `Aplicacion`, `b`.`fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Editar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisosaplicacionesusuario` `b` join `tbl_usuarios` `a` on((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_aplicacion_perfil`
--
DROP TABLE IF EXISTS `vista_aplicacion_perfil`;

DROP VIEW IF EXISTS `vista_aplicacion_perfil`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_aplicacion_perfil`  AS SELECT `b`.`fk_id_perfil` AS `ID`, `a`.`nombre_perfil` AS `Perfil`, `b`.`fk_id_aplicacion` AS `Aplicacion`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Modificar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisosaplicacionperfil` `b` join `tbl_perfiles` `a` on((`a`.`pk_id_perfil` = `b`.`fk_id_perfil`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_modulo_aplicacion`
--
DROP TABLE IF EXISTS `vista_modulo_aplicacion`;

DROP VIEW IF EXISTS `vista_modulo_aplicacion`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_modulo_aplicacion`  AS SELECT `b`.`fk_id_modulos` AS `ID`, `a`.`nombre_modulo` AS `Modulo`, `b`.`fk_id_aplicacion` AS `Aplicacion`, `c`.`nombre_aplicacion` AS `Nombre`, `c`.`descripcion_aplicacion` AS `Descripcion` FROM ((`tbl_asignacionmoduloaplicacion` `b` join `tbl_modulos` `a` on((`a`.`pk_id_modulos` = `b`.`fk_id_modulos`))) join `tbl_aplicaciones` `c` on((`c`.`pk_id_aplicacion` = `b`.`fk_id_aplicacion`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_perfil_usuario`
--
DROP TABLE IF EXISTS `vista_perfil_usuario`;

DROP VIEW IF EXISTS `vista_perfil_usuario`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_perfil_usuario`  AS SELECT `b`.`fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `a`.`username_usuario` AS `nickName`, `b`.`fk_id_perfil` AS `perfil`, `c`.`nombre_perfil` AS `Nombre` FROM ((`tbl_asignacionesperfilsusuario` `b` join `tbl_usuarios` `a` on((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`))) join `tbl_perfiles` `c` on((`c`.`pk_id_perfil` = `b`.`fk_id_perfil`)))  ;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_asignacionesperfilsusuario`
--
ALTER TABLE `tbl_asignacionesperfilsusuario`
  ADD CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  ADD CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`);

--
-- Filtros para la tabla `tbl_asignacionmoduloaplicacion`
--
ALTER TABLE `tbl_asignacionmoduloaplicacion`
  ADD CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_1` FOREIGN KEY (`fk_id_modulos`) REFERENCES `tbl_modulos` (`pk_id_modulos`),
  ADD CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_bitacoradeeventos`
--
ALTER TABLE `tbl_bitacoradeeventos`
  ADD CONSTRAINT `tbl_bitacoradeeventos_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  ADD CONSTRAINT `tbl_bitacoradeeventos_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_compras`
--
ALTER TABLE `tbl_compras`
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
  ADD CONSTRAINT `fk_tbl_ordenesCompra_tbl_proveedor1` FOREIGN KEY (`fk_proveedor_id`) REFERENCES `tbl_proveedor` (`id_proveedor`);

--
-- Filtros para la tabla `tbl_permisosaplicacionesusuario`
--
ALTER TABLE `tbl_permisosaplicacionesusuario`
  ADD CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  ADD CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_2` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`);

--
-- Filtros para la tabla `tbl_permisosaplicacionperfil`
--
ALTER TABLE `tbl_permisosaplicacionperfil`
  ADD CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  ADD CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
