using System;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsRecuperacionContrasena
    {
        //IMPORTANTE TODOS ESTOS CAMPOS DEBEN SER IGUAL A COMO
        //LO TENGAN EN SU BASE DE DATOS PARA QUE HAGAN MATCH
        public int IdRecuperacionContrasena { get; set; }
        public int IdUsuario { get; set; }
        public string TokenRecuperacionContrasena { get; set; }
        public DateTime FechaExpiracionRecuperacionContrasena { get; set; }
        public bool UsadoRecuperacionContrasena { get; set; }
    }
}
