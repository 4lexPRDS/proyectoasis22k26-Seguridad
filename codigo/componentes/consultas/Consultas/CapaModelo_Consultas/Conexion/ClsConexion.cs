using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Consultas
{
    internal class ClsConexion
    {
        public OdbcConnection ConsultasFuncConexion()
        {
            OdbcConnection Conn = new OdbcConnection("Dsn=umg_didactica");
            try
            {
                Conn.Open();
            }
            catch (OdbcException Ex)
            {
                Console.WriteLine("Conexion fallida. Error: " + Ex.Message);
            }
            return Conn;
        }

        public void ConsultasProcDesconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException Ex)
            {
                Console.WriteLine("Error al cerrar la conexión. Error: " + Ex.Message);
            }
        }
    }
}
