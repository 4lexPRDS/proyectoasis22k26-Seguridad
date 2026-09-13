using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Consultas
{
    public class ClsCondicionComparacion
    {
        public string Campo { get; set; }
        public string OperadorComparacion { get; set; }
        public string Valor { get; set; }
        public string OperadorLogico { get; set; }

        public ClsCondicionComparacion(
            string campo,
            string operadorComparacion,
            string valor
            )
        {
            Campo = campo;
            OperadorComparacion = operadorComparacion;
            Valor = valor;
          
        }

        public string GenerarCondicion()
        {
            return $"{Campo} {OperadorComparacion} '{Valor}'";
        }
    }
}
