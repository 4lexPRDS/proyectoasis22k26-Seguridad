using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
        public class Roles
        {
            public int idRol { get; set; }
            public string nombreRol { get; set; }
            public string descripcionRol { get; set; }
            public bool is_active { get; set; }

            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }
    
}
