using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad
{
    
        public abstract class Conexion
        {
            public readonly string connectionString;
            public Conexion()
            {
                connectionString = "Dsn=EmbutidosS.A";
            }
            protected OdbcConnection ObtenerConexion()
            {
                return new OdbcConnection(connectionString);
            }
            public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se desconecto");
            }
        }
    }
}
