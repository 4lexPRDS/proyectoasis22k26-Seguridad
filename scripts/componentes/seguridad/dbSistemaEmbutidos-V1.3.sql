CREATE DATABASE IF NOT EXISTS dbSistemaEmbutidos
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE dbSistemaEmbutidos;


-- tabla de empleados

CREATE TABLE tblEmpleado (
idEmpleado INT AUTO_INCREMENT NOT NULL,
codigoEmpleado VARCHAR(30) NOT NULL,
dpiEmpleado CHAR(13) NOT NULL,
nitEmpleado CHAR(10) NULL,
nombresEmpleado VARCHAR(100) NOT NULL,
apellidosEmpleado VARCHAR(100) NOT NULL,
puestoEmpleado VARCHAR(255) NOT NULL,
generoEmpleado CHAR(1) NOT NULL COMMENT 'M = Masculino, F = Femenino',
fechaNacimientoEmpleado DATE NOT NULL,
fechaContratacionEmpleado DATE NOT NULL,
telefonoEmpleado VARCHAR(30) NULL,
correoEmpleado VARCHAR(150) NULL,
is_active BOOLEAN NOT NULL DEFAULT TRUE,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_Empleado PRIMARY KEY (idEmpleado),
CONSTRAINT uqCodigoEmpleado UNIQUE (codigoEmpleado),
CONSTRAINT uqDpiEmpleado UNIQUE (dpiEmpleado),
CONSTRAINT uqNitEmpleado UNIQUE (nitEmpleado),
CONSTRAINT uqCorreoEmpleado UNIQUE (correoEmpleado)
) ENGINE=InnoDB;


-- tabla de roles

CREATE TABLE tblRol (
idRol INT AUTO_INCREMENT NOT NULL,
nombreRol VARCHAR(100) NOT NULL,
descripcionRol VARCHAR(255) NULL,
is_active BOOLEAN NOT NULL DEFAULT TRUE,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_Rol PRIMARY KEY (idRol),
CONSTRAINT uqNombreRol UNIQUE (nombreRol)
) ENGINE=InnoDB;


-- tabla de modulo

CREATE TABLE tblModulo (
idModulo INT AUTO_INCREMENT NOT NULL,
nombreModulo VARCHAR(100) NOT NULL,
is_active BOOLEAN NOT NULL DEFAULT TRUE,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_Modulo PRIMARY KEY (idModulo),
CONSTRAINT uqNombreModulo UNIQUE (nombreModulo)
) ENGINE=InnoDB;

ALTER TABLE tblModulo
ADD COLUMN descripcionModulo VARCHAR(255) NULL AFTER nombreModulo;




SET FOREIGN_KEY_CHECKS = 0;
SET SQL_SAFE_UPDATES = 0;


TRUNCATE TABLE tblmodulo;

ALTER TABLE tblmodulo AUTO_INCREMENT = 1;

SET SQL_SAFE_UPDATES = 1;
SET FOREIGN_KEY_CHECKS = 1;

COMMIT;

SELECT * FROM tblmodulo;



-- 1. Vaciar la tabla y reiniciar el AUTO_INCREMENT a 1
SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE tblModulo;
SET FOREIGN_KEY_CHECKS = 1;

-- 2. Insertar catálogo inicial de módulos (Iniciando estrictamente en ID = 1)
INSERT INTO tblModulo (nombreModulo, descripcionModulo, is_active) VALUES
('Seguridad', 'Gestión de usuarios, roles, perfiles y permisos del sistema', 1),
('Contabilidad', 'Módulo de contabilidad general, libro mayor y estados financieros', 1),
('Bancos', 'Gestión de cuentas bancarias, cheques y conciliaciones', 1),
('Cuentas por Cobrar', 'Administración de clientes, facturación y cobros', 1),
('Cuentas por Pagar', 'Gestión de proveedores, facturas de compra y pagos', 1),
('Inventarios', 'Control de existencias, bodegas y movimientos de productos', 1),
('Ventas', 'Control de pedidos, cotizaciones y facturación de venta', 1),
('Compras', 'Gestión de órdenes de compra y recepción de mercadería', 1),
('Nómina', 'Administración de empleados, sueldos, horas extras y planilla', 1),
('Administración', 'Parámetros generales del sistema y configuración global', 1);


SELECT * FROM tblModulo;
-- tabla de aplicacion

CREATE TABLE tblAplicacion (
idAplicacion INT AUTO_INCREMENT NOT NULL,
idModulo INT NOT NULL,
nombreAplicacion VARCHAR(100) NOT NULL,
descripcionAplicacion VARCHAR(255) NULL,
is_active BOOLEAN NOT NULL DEFAULT TRUE,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_Aplicacion PRIMARY KEY (idAplicacion),
CONSTRAINT Fk_Aplicacion_Modulo FOREIGN KEY (idModulo)
REFERENCES tblModulo (idModulo) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;


-- tabla de usuario

CREATE TABLE tblUsuario (
idUsuario INT AUTO_INCREMENT NOT NULL,
idEmpleado INT NOT NULL,
usuarioUsuario VARCHAR(30) NOT NULL,
contrasenaUsuario VARCHAR(255) NOT NULL,
ultimoAccesoUsuario DATETIME NULL,
is_active BOOLEAN NOT NULL DEFAULT TRUE,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_Usuario PRIMARY KEY (idUsuario),
CONSTRAINT uqIdEmpleadoUsuario UNIQUE (idEmpleado),
CONSTRAINT uqUsuarioUsuario UNIQUE (usuarioUsuario),
CONSTRAINT Fk_Usuario_Empleado FOREIGN KEY (idEmpleado)
REFERENCES tblEmpleado (idEmpleado) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;


-- tabla de recuperacion de contrasena

CREATE TABLE tblRecuperacionContrasena (
idRecuperacionContrasena INT AUTO_INCREMENT NOT NULL,
idUsuario INT NOT NULL,
tokenRecuperacionContrasena VARCHAR(255) NOT NULL,
fechaExpiracionRecuperacionContrasena DATETIME NOT NULL,
usadoRecuperacionContrasena BOOLEAN NOT NULL DEFAULT FALSE,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_RecuperacionContrasena PRIMARY KEY (idRecuperacionContrasena),
CONSTRAINT uqTokenRecuperacionContrasena UNIQUE (tokenRecuperacionContrasena),
CONSTRAINT Fk_RecuperacionContrasena_Usuario FOREIGN KEY (idUsuario)
REFERENCES tblUsuario (idUsuario) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;


-- tabla de usuario rol

CREATE TABLE tblUsuarioRol (
idUsuario INT NOT NULL,
idRol INT NOT NULL,
fechaAsignacionUsuarioRol DATE NOT NULL,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_UsuarioRol PRIMARY KEY (idUsuario, idRol),
CONSTRAINT Fk_UsuarioRol_Usuario FOREIGN KEY (idUsuario) REFERENCES tblUsuario (idUsuario) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT Fk_UsuarioRol_Rol FOREIGN KEY (idRol) REFERENCES tblRol (idRol) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;


-- tabla de rol modulo aplicacion

CREATE TABLE tblRolModuloAplicacion (
idRol INT NOT NULL,
idModulo INT NOT NULL,
idAplicacion INT NOT NULL,
derInsertarRolModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
derEditarRolModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
derEliminarRolModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
derImprimirRolModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_RolModuloAplicacion PRIMARY KEY (idRol, idModulo, idAplicacion),
CONSTRAINT Fk_RolModuloAplicacion_Rol FOREIGN KEY (idRol) REFERENCES tblRol (idRol) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT Fk_RolModuloAplicacion_Modulo FOREIGN KEY (idModulo) REFERENCES tblModulo (idModulo) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT Fk_RolModuloAplicacion_Aplicacion FOREIGN KEY (idAplicacion) REFERENCES tblAplicacion (idAplicacion) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;


-- tabla de usuario modulo aplicacion

CREATE TABLE tblUsuarioModuloAplicacion (
idUsuario INT NOT NULL,
idModulo INT NOT NULL,
idAplicacion INT NOT NULL,
derInsertarUsuarioModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
derEditarUsuarioModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
derEliminarUsuarioModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
derImprimirUsuarioModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CONSTRAINT Pk_UsuarioModuloAplicacion PRIMARY KEY (idUsuario, idModulo, idAplicacion),
CONSTRAINT Fk_UsuarioModuloAplicacion_Usuario FOREIGN KEY (idUsuario) REFERENCES tblUsuario (idUsuario) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT Fk_UsuarioModuloAplicacion_Modulo FOREIGN KEY (idModulo) REFERENCES tblModulo (idModulo) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT Fk_UsuarioModuloAplicacion_Aplicacion FOREIGN KEY (idAplicacion) REFERENCES tblAplicacion (idAplicacion) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;


-- tabla de bitacora

CREATE TABLE tblBitacora (
idBitacora INT AUTO_INCREMENT NOT NULL,
idUsuario INT NULL,
accionBitacora VARCHAR(30) NOT NULL,
tablaBitacora VARCHAR(100) NOT NULL,
idRegistroBitacora INT NULL,
detallesBitacora TEXT NULL,
ipBitacora VARCHAR(50) NOT NULL,
fechaHoraBitacora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
CONSTRAINT Pk_Bitacora PRIMARY KEY (idBitacora),
CONSTRAINT Fk_Bitacora_Usuario FOREIGN KEY (idUsuario)
REFERENCES tblUsuario (idUsuario) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB;


-- indices

CREATE INDEX idxUsuarioIdEmpleado ON tblUsuario (idEmpleado);

CREATE INDEX idxRecuperacionContrasenaIdUsuario ON tblRecuperacionContrasena (idUsuario);

CREATE INDEX idxUsuarioRolIdRol ON tblUsuarioRol (idRol);

CREATE INDEX idxAplicacionIdModulo ON tblAplicacion (idModulo);

CREATE INDEX idxRolModAplIdModulo ON tblRolModuloAplicacion (idModulo);

CREATE INDEX idxRolModAplIdAplicacion ON tblRolModuloAplicacion (idAplicacion);

CREATE INDEX idxUsrModAplIdModulo ON tblUsuarioModuloAplicacion (idModulo);

CREATE INDEX idxUsrModAplIdAplicacion ON tblUsuarioModuloAplicacion (idAplicacion);

CREATE INDEX idxBitacoraIdUsuario ON tblBitacora (idUsuario);

CREATE INDEX idxBitacoraFechaHora ON tblBitacora (fechaHoraBitacora);

CREATE INDEX idxBitacoraTabla ON tblBitacora (tablaBitacora);