using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Consultas
{
    public class ClsConstructorConsultas
    {
        private string _Tabla;

        private List<string> _Condiciones;
        private List<string> _OperadoresLogicos;

        public ClsConstructorConsultas(string tabla)
        {
            this._Tabla = tabla;

            _Condiciones = new List<string>();
            _OperadoresLogicos = new List<string>();
        }

    
        public void ConsultasMetAgregarCondicion(
            string condicion,
            string operadorLogico)
        {
         
            _Condiciones.Add(condicion);

           
            if (_Condiciones.Count > 1)
            {
                _OperadoresLogicos.Add(operadorLogico);
            }
        }

      
        public string ConsultasMetObtenerConsultaActual()
        {
            string Query = $"SELECT * FROM {_Tabla}";

            if (_Condiciones.Count == 0)
            {
                return Query + ";";
            }

            Query += " WHERE ";

            for (int Indice = 0; Indice < _Condiciones.Count; Indice++)
            {
                Query += _Condiciones[Indice];

                if (Indice < _Condiciones.Count - 1)
                {
                    Query += $" {_OperadoresLogicos[Indice]} ";
                }
            }

            return Query + ";";
        }

   
        public void ConsultasMetLimpiar()
        {
            _Condiciones.Clear();
            _OperadoresLogicos.Clear();
        }
    }
}
