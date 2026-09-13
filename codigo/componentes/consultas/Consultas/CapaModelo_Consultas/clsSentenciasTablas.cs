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
        ClsConexion con = new ClsConexion();
        public OdbcDataAdapter ObtenerTabla(string Tabla, int pagina, int registrosPorPagina)
        {
            try
            {
                int inicio = (pagina - 1) * registrosPorPagina;

                string consulta =
                    "SELECT * FROM " + Tabla +
                    " LIMIT ? OFFSET ?;";

                OdbcCommand cmd = new OdbcCommand(consulta, con.conexion());

                cmd.Parameters.AddWithValue("?", registrosPorPagina);
                cmd.Parameters.AddWithValue("?", inicio);

                OdbcDataAdapter daTabla = new OdbcDataAdapter(cmd);

                return daTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter GetTables() { 
            string consulta = "SHOW TABLES;"; 
            OdbcDataAdapter daTablas = new OdbcDataAdapter(consulta, con.conexion()); 
            return daTablas; 
        }
        public int ContarRegistros(string NombreTabla)
        {
            string consulta =
                "SELECT COUNT(*) FROM " + NombreTabla;

            OdbcCommand cmd = new OdbcCommand(
                consulta,
                con.conexion()
            );

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    } 
}