using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Navegador
{
    public class ClsConexionBD
    {
        public OdbcConnection NavegadorFuncConexion()
        {
            OdbcConnection Conexion = new OdbcConnection("Dsn=BD_ProyectoNominas");

            try
            {
                Conexion.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error al conectar a la base de datos");
            }

            return Conexion;
        }

        public void NavegadorMetDesconexion(OdbcConnection Conexion)
        {
            try
            {
                if (Conexion != null && Conexion.State != System.Data.ConnectionState.Closed)
                {
                    Conexion.Close();
                }
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error al desconectar de la base de datos");
            }
        }
    }

}