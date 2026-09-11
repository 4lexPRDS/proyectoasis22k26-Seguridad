using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Reporteador
{
    public class Conexion
    {

        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=dbReporteador;Uid=usuprueba;Pwd=TuContraseñaAqui;");
            try
            {
                conn.Open();

            }
            catch (OdbcException)
            {
                Console.WriteLine("No se conecto");
            }
            return conn;
        }


        public void cerrarConexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se Desconeto");
            }
        }


    }
}

