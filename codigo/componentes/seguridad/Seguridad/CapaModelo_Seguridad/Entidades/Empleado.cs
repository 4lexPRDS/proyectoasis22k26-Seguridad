using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaModelo_Seguridad.Entidades
{
    public class Empleado
    {
        //IMPORTANTE TODOS ESTOS CAMPOS DEBEN SER IGUAL A COMO
        //LO TENGAN EN SU BASE DE DATOS PARA QUE HAGAN MATCH
        public int idEmpleado { get; set; }
        public string codigoEmpleado { get; set; }
        public string dpiEmpleado { get; set; }
        public string nitEmpleado { get; set; }
        public string nombresEmpleado { get; set; }
        public string apellidosEmpleado { get; set; }
        public string puestoEmpleado { get; set; }
        public string generoEmpleado { get; set; }
        public DateTime fechaNacimientoEmpleado { get; set; }
        public DateTime fechaContratacionEmpleado { get; set; }
        public string telefonoEmpleado { get; set; }
        public string correoEmpleado { get; set; }
        public bool isActive { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}