using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Consultas;

namespace CapaControlador_Consultas
{
    public class ClsTablas
    {
        ClsSentenciasTablas _Sentencias = new ClsSentenciasTablas();

        public DataTable ConsultasFuncLlenarTabla (string NombreTabla, int pagina, int registrosPorPagina)
        {
            OdbcDataAdapter DaLlenarTablas = _Sentencias.ConsultasFuncObtenerTabla(NombreTabla, pagina, registrosPorPagina);
            DataTable DtLlenarTablas = new DataTable();
            try { DaLlenarTablas.Fill(DtLlenarTablas); 
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error al llenar la tabla: " + Ex.Message);
            }

            return DtLlenarTablas;
        }
        public DataTable ConsultasFuncObtenerTablas()
        {
            OdbcDataAdapter DaObtenerTablas = _Sentencias.ConsultasFuncObtenerTablas();
            DataTable DtObtenerTablas = new DataTable();
            DaObtenerTablas.Fill(DtObtenerTablas);
            return DtObtenerTablas;
        }
        public int ConsultasFuncContarRegistros(string NombreTabla)
        {
            return _Sentencias.ConsultasFuncContarRegistros(NombreTabla);
        }
    }
}
