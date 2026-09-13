using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace CapaControlador_Consultas
{
    public class ClsControladorConsultaSimple
    {
        public string GenerarConsultaDinamica(string tabla, string campo, string operador, string valor, string campoOrden, bool esAscendente)
        {
            string consulta = $"SELECT * FROM {tabla}";

            if (!string.IsNullOrWhiteSpace(campo) && !string.IsNullOrWhiteSpace(valor) && !string.IsNullOrWhiteSpace(operador))
            {
                consulta += $" WHERE {campo} {operador} '{valor}'";
            }

            
            if (!string.IsNullOrWhiteSpace(campoOrden))
            {
                string tipoOrden = esAscendente ? "ASC" : "DESC";
                consulta += $" ORDER BY {campoOrden} {tipoOrden}";
            }

            // Ventana de consulta, muestra la consulta en una ventana emergente, se quita con solo comentar la linea siguiente
            MessageBox.Show("Consulta generada para MySQL:\n\n" + consulta, "Depuración de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return consulta;
        }
    }
}