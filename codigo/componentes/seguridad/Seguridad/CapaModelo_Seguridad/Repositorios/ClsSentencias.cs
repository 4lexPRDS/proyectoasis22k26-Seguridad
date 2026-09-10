using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad
{
    public abstract class ClsSentencias : ClsConexion
    {
        private DataTable _TablaDatos; // Establece la tabla de datos para las consultas

        //cuando hagamos un update insert o delete este es el metodo a llamar
        public int SeguridadMetEjecucionNonQuery(string ComandoTexto, List<OdbcParameter> Parametros, CommandType ComandoTipo)
        {
            using (var ConexionActiva = SeguridadMetObtenerConexion())
            {
                ConexionActiva.Open();
                using (var Comando = new OdbcCommand())
                {
                    Comando.Connection = ConexionActiva;
                    Comando.CommandText = ComandoTexto;
                    Comando.CommandType = ComandoTipo;
                    Comando.Parameters.AddRange(Parametros.ToArray()); // Agregar la colecciòn de paràmetros
                    return Comando.ExecuteNonQuery();
                }
            }
        }

        //este metodo llena el dataGriwView
        public DataTable SeguridadMetEjecucionConsulta(string ComandoTexto, CommandType ComandoTipo)
        {
            _TablaDatos = new DataTable();
            using (var ConexionActiva = SeguridadMetObtenerConexion()) //Obtener conexion a la BD
            {
                ConexionActiva.Open();
                using (var Comando = new OdbcCommand())
                {
                    Comando.Connection = ConexionActiva;
                    Comando.CommandText = ComandoTexto;
                    Comando.CommandType = ComandoTipo;
                    using (var LectorDatos = Comando.ExecuteReader())
                        _TablaDatos.Load(LectorDatos);  //Llenar la tabla de datos
                }
                return _TablaDatos; // retorno de la tabla de datos
            }
        }
    }
}