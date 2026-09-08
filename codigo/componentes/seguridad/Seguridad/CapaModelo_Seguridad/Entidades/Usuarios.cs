using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public int idEmpleado { get; set; }
        public string usuarioUsuario { get; set; }
        public int is_active { get; set; }
        public string contrasenaUsuario { get; set; }
        public DateTime ultimoAccesoUsuario { get; set; }
    }
}
