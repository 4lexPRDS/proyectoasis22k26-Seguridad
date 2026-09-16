using System;

namespace CapaModelo_Seguridad.Entidades
{
    // IMPORTANTE: todos estos campos deben ser iguales a como están en la
    // base de datos (tblUsuarioRol) para que hagan match, igual que en las
    // demás entidades del componente Seguridad (ver ClsAsigAppPerf).
    public class ClsAsignacionPerfiles
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaAsignacionUsuarioRol { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Campos de apoyo (no existen como columna propia, vienen del JOIN
        // con tblUsuario / tblRol) para mostrarlos en la Vista sin
        // necesidad de otra consulta.
        public string NombreUsuario { get; set; }
        public string NombreRol { get; set; }
    }
}
