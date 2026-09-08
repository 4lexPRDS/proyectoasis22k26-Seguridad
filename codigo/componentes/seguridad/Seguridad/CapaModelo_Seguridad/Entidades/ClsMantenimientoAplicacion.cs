using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsMantenimientoAplicacion
    {
        public int idAplicacion {  get; set; }
        public int idModulo { get; set; }
        public string nombreAplicacion { get; set; }
        public string descripcionAplicacion { get; set; }
        public bool is_active { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
