using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo_Consultas { 
    public class ClsSentenciasTablas { 
        ClsConexion _Conexion = new ClsConexion();
        public OdbcDataAdapter ConsultasFuncObtenerTabla(string Tabla, int pagina, int registrosPorPagina)
        {
            try
            {
                int Inicio = (pagina - 1) * registrosPorPagina;

                string Consulta =
                    "SELECT * FROM " + Tabla +
                    " LIMIT ? OFFSET ?;";

                OdbcCommand Cmd = new OdbcCommand(Consulta, _Conexion.ConsultasFuncConexion());

                Cmd.Parameters.AddWithValue("?", registrosPorPagina);
                Cmd.Parameters.AddWithValue("?", Inicio);

                OdbcDataAdapter DaTabla = new OdbcDataAdapter(Cmd);

                return DaTabla;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error al cargar la tabla: " + Ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter ConsultasFuncObtenerTablas() { 
            string Consulta = "SHOW TABLES;"; 
            OdbcDataAdapter DaTablas = new OdbcDataAdapter(Consulta, _Conexion.ConsultasFuncConexion()); 
            return DaTablas; 
        }
        public int ConsultasFuncContarRegistros(string NombreTabla)
        {
            string Consulta =
                "SELECT COUNT(*) FROM " + NombreTabla;

            OdbcCommand Cmd = new OdbcCommand(
                Consulta,
                _Conexion.ConsultasFuncConexion()
            );

            return Convert.ToInt32(Cmd.ExecuteScalar());
        }
    } 
}