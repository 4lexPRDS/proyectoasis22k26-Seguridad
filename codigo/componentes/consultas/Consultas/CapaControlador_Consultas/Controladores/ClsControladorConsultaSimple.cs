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
        public string ConsultasMetGenerarConsultaDinamica(string tabla, string campo, string operador, string valor, string campoOrden, bool esAscendente)
        {
            string Consulta = $"SELECT * FROM {tabla}";

            if (!string.IsNullOrWhiteSpace(campo) && !string.IsNullOrWhiteSpace(valor) && !string.IsNullOrWhiteSpace(operador))
            {
                Consulta += $" WHERE {campo} {operador} '{valor}'";
            }

            
            if (!string.IsNullOrWhiteSpace(campoOrden))
            {
                string TipoOrden = esAscendente ? "ASC" : "DESC";
                Consulta += $" ORDER BY {campoOrden} {TipoOrden}";
            }

            // Ventana de Consulta, muestra la Consulta en una ventana emergente, se quita con solo comentar la linea siguiente
            MessageBox.Show("Consulta generada para MySQL:\n\n" + Consulta, "Depuración de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return Consulta;
        }
    }
}