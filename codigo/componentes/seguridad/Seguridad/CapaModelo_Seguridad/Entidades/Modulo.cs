using System;

namespace CapaModelo_Seguridad.Entidades
{
    public class Modulo
    {
        // Deben hacer match con los campos de tu base de datos
        public int idModulo { get; set; }
        public string nombreModulo { get; set; }
        public string descripcionModulo { get; set; } 
        public bool is_active { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}