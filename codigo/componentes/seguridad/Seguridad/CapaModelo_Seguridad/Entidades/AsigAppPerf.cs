using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class AsigAppPerf
    {
        //IMPORTANTE TODOS ESTOS CAMPOS DEBEN SER IGUAL A COMO
        //LO TENGAN EN SU BASE DE DATOS PARA QUE HAGAN MATCH
        public int idRol { get; set; }
        public int idModulo { get; set; }
        public int idAplicacion { get; set; }

        public bool derInsertarRolModuloAplicacion { get; set; }
        public bool derEditarRolModuloAplicacion { get; set; }
        public bool derEliminarRolModuloAplicacion { get; set; }
        public bool derImprimirRolModuloAplicacion { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

}
