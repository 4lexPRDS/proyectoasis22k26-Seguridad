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
        ClsSentenciasTablas sentencias = new ClsSentenciasTablas();

        public DataTable ConsutlasFuncLlenarTabla (string NombreTabla, int pagina, int registrosPorPagina)
        {
            OdbcDataAdapter daLlenarTablas = sentencias.ObtenerTabla(NombreTabla, pagina, registrosPorPagina);
            DataTable dtLlenarTablas = new DataTable();
            try { daLlenarTablas.Fill(dtLlenarTablas); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al llenar la tabla: " + ex.Message);
            }

            return dtLlenarTablas;
        }
        public DataTable ConsultasFuncObtenerTablas()
        {
            OdbcDataAdapter daObtenerTablas = sentencias.GetTables();
            DataTable dtObtenerTablas = new DataTable();
            daObtenerTablas.Fill(dtObtenerTablas);
            return dtObtenerTablas;
        }
        public int ConsultasFuncContarRegistros(string NombreTabla)
        {
            return sentencias.ContarRegistros(NombreTabla);
        }
    }
}
