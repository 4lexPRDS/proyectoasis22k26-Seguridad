using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Consultas
{
    public class ClsConstructorConsultas
    {
        private string tabla;

        private List<string> condiciones;
        private List<string> operadoresLogicos;

        public ClsConstructorConsultas(string tabla)
        {
            this.tabla = tabla;

            condiciones = new List<string>();
            operadoresLogicos = new List<string>();
        }

    
        public void AgregarCondicion(
            string condicion,
            string operadorLogico)
        {
         
            condiciones.Add(condicion);

           
            if (condiciones.Count > 1)
            {
                operadoresLogicos.Add(operadorLogico);
            }
        }

      
        public string ObtenerConsultaActual()
        {
            string query = $"SELECT * FROM {tabla}";

            if (condiciones.Count == 0)
            {
                return query + ";";
            }

            query += " WHERE ";

            for (int i = 0; i < condiciones.Count; i++)
            {
                query += condiciones[i];

                if (i < condiciones.Count - 1)
                {
                    query += $" {operadoresLogicos[i]} ";
                }
            }

            return query + ";";
        }

   
        public void Limpiar()
        {
            condiciones.Clear();
            operadoresLogicos.Clear();
        }
    }
}
