-- 1. tblEmpleado
INSERT INTO tblEmpleado (codigoEmpleado, dpiEmpleado, nitEmpleado, nombresEmpleado, apellidosEmpleado, puestoEmpleado, generoEmpleado, fechaNacimientoEmpleado, fechaContratacionEmpleado, telefonoEmpleado, correoEmpleado)
VALUES
('EMP001', '1234567890123', '1234567K', 'Carlos Andrés', 'Pérez López', 'Encargado de Producción', 'M', '1990-04-12', '2020-01-15', '55512345', 'carlos.perez@embutidos.com'),
('EMP002', '9876543210987', '7654321K', 'María José', 'García Ruiz', 'Administradora', 'F', '1988-11-03', '2019-06-01', '55598765', 'maria.garcia@embutidos.com'),
('EMP003', '4567891234560', '4567891K', 'Luis Fernando', 'Morales Díaz', 'Vendedor', 'M', '1995-07-22', '2022-03-10', '55511122', 'luis.morales@embutidos.com');

-- 2. tblRol
INSERT INTO tblRol (nombreRol, descripcionRol)
VALUES
('Administrador', 'Rol con acceso total al sistema'),
('Vendedor', 'Rol con acceso al módulo de ventas'),
('Bodeguero', 'Rol con acceso al módulo de inventario');

-- 3. tblModulo
INSERT INTO tblModulo (nombreModulo)
VALUES
('Ventas'),
('Inventario'),
('Recursos Humanos');

-- 4. tblAplicacion (depende de tblModulo)
INSERT INTO tblAplicacion (idModulo, nombreAplicacion, descripcionAplicacion)
VALUES
(1, 'Facturación', 'Gestión de facturas de venta'),
(2, 'Control de Stock', 'Gestión de existencias de producto'),
(3, 'Gestión de Empleados', 'Administración de personal');

-- 5. tblUsuario (depende de tblEmpleado)
INSERT INTO tblUsuario (idEmpleado, usuarioUsuario, correoUsuario, contrasenaUsuario)
VALUES
(1, 'cperez', 'cperez@embutidos.com', '$2y$10$ejemploHashUno'),
(2, 'mgarcia', 'mgarcia@embutidos.com', '$2y$10$ejemploHashDos'),
(3, 'lmorales', 'lmorales@embutidos.com', '$2y$10$ejemploHashTres');

-- 6. tblRecuperacionContrasena (depende de tblUsuario)
INSERT INTO tblRecuperacionContrasena (idUsuario, tokenRecuperacionContrasena, fechaExpiracionRecuperacionContrasena, usadoRecuperacionContrasena)
VALUES
(1, 'tok_a1b2c3d4e5f6', '2026-09-10 12:00:00', FALSE),
(2, 'tok_b2c3d4e5f6a1', '2026-09-11 15:30:00', FALSE),
(3, 'tok_c3d4e5f6a1b2', '2026-09-12 09:00:00', TRUE);

-- 7. tblUsuarioRol (depende de tblUsuario y tblRol)
INSERT INTO tblUsuarioRol (idUsuario, idRol, fechaAsignacionUsuarioRol)
VALUES
(1, 1, '2026-01-15'),
(2, 2, '2026-02-01'),
(3, 3, '2026-03-10');

-- 8. tblRolModuloAplicacion (depende de tblRol, tblModulo, tblAplicacion)
INSERT INTO tblRolModuloAplicacion (idRol, idModulo, idAplicacion, derInsertarRolModuloAplicacion, derEditarRolModuloAplicacion, derEliminarRolModuloAplicacion, derImprimirRolModuloAplicacion)
VALUES
(1, 1, 1, TRUE, TRUE, TRUE, TRUE),
(2, 1, 1, TRUE, FALSE, FALSE, TRUE),
(3, 2, 2, TRUE, TRUE, FALSE, TRUE);

-- 9. tblUsuarioModuloAplicacion (depende de tblUsuario, tblModulo, tblAplicacion)
INSERT INTO tblUsuarioModuloAplicacion (idUsuario, idModulo, idAplicacion, derInsertarUsuarioModuloAplicacion, derEditarUsuarioModuloAplicacion, derEliminarUsuarioModuloAplicacion, derImprimirUsuarioModuloAplicacion)
VALUES
(2, 1, 1, TRUE, FALSE, FALSE, TRUE),
(3, 2, 2, TRUE, TRUE, FALSE, TRUE),
(1, 3, 3, TRUE, TRUE, TRUE, TRUE);

-- 10. tblBitacora (depende de tblUsuario, aunque idUsuario puede ser NULL)
INSERT INTO tblBitacora (idUsuario, accionBitacora, tablaBitacora, idRegistroBitacora, detallesBitacora, ipBitacora)
VALUES
(1, 'INSERT', 'tblEmpleado', 1, 'Se registró un nuevo empleado', '192.168.1.10'),
(2, 'LOGIN', 'tblUsuario', 2, 'Inicio de sesión exitoso', '192.168.1.20'),
(3, 'UPDATE', 'tblRol', 3, 'Se actualizó el rol Bodeguero', '192.168.1.30');