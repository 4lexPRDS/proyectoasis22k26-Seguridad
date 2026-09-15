using System;

namespace CapaModelo_Seguridad.Contratos
{
    // No hereda de IRepositorioGenerico<T>: el flujo de recuperación de
    // contraseña no es un CRUD clásico (Agregar/Editar/Remover/ObtenerTodos),
    // son pasos propios del proceso de recuperación.
    public interface IRepositorioRecuperacionContrasena
    {
        // Cruza tblUsuario + tblEmpleado. Devuelve null si el usuario y el
        // correo no coinciden con el mismo empleado (o si está inactivo).
        int? SeguridadMetBuscarIdUsuarioPorUsuarioYCorreo(string NombreUsuario, string CorreoEmpleado);

        // Fecha de la última solicitud de código de ese usuario (o null si
        // nunca ha pedido uno / ya se le borró). Se usa para el cooldown de
        // 1 minuto entre solicitudes.
        DateTime? SeguridadMetBuscarFechaUltimaSolicitud(int IdUsuario);

        // Borra cualquier código pendiente de ese usuario (para que, si pide
        // uno nuevo, el anterior deje de servir de inmediato).
        void SeguridadMetEliminarPorUsuario(int IdUsuario);

        // Limpieza general: borra códigos ya vencidos de cualquier usuario.
        void SeguridadMetEliminarVencidos();

        void SeguridadMetGuardarToken(int IdUsuario, string Token, DateTime FechaExpiracion);

        // El token es UNIQUE en la tabla, así que basta con el código para
        // encontrar al usuario (no hace falta pedir usuario en el paso 2).
        // Devuelve el idUsuario si el token es válido (no vencido, no usado).
        int? SeguridadMetBuscarIdUsuarioPorToken(string Token);
    }
}
