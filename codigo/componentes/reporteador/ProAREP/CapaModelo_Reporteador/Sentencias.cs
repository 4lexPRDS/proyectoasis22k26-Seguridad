using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Reporteador
{
    public class Sentencias
    {
        Conexion conn = new Conexion();

        public OdbcDataAdapter llenarTbl(string nombreTabla)
        {
            string sSql = "SELECT * FROM " + nombreTabla + " ;";
            OdbcDataAdapter daSentencias =
                new OdbcDataAdapter(sSql, conn.conexion());

            return daSentencias;
        }

        public OdbcDataAdapter filtrarPorNombre(string nombre)
        {
            string sSql = "SELECT * FROM reportes WHERE nombre_reporte LIKE ?;";

            OdbcCommand cmd = new OdbcCommand(sSql, conn.conexion());

            cmd.Parameters.AddWithValue(
                "@nombre",
                "%" + nombre + "%"
            );

            return new OdbcDataAdapter(cmd);
        }

        public OdbcDataAdapter filtrarPorFecha(DateTime fecha)
        {
            string sSql = "SELECT * FROM reportes WHERE fecha = ?;";

            OdbcCommand cmd = new OdbcCommand(sSql, conn.conexion());

            cmd.Parameters.AddWithValue(
                "@fecha",
                fecha.ToString("yyyy-MM-dd")
            );

            return new OdbcDataAdapter(cmd);
        }

        public OdbcDataAdapter filtrarPorNombreYFecha(
            string nombre,
            DateTime fecha)
        {
            string sSql = "SELECT * FROM reportes " +
                          "WHERE nombre_reporte LIKE ? AND fecha = ?;";

            OdbcCommand cmd = new OdbcCommand(sSql, conn.conexion());

            cmd.Parameters.AddWithValue(
                "@nombre",
                "%" + nombre + "%"
            );

            cmd.Parameters.AddWithValue(
                "@fecha",
                fecha.ToString("yyyy-MM-dd")
            );

            return new OdbcDataAdapter(cmd);
        }

        public string consultarRutaReporte(string nombreReporte)
        {
            string sSql = "SELECT rutaReporte FROM tblReporte WHERE nombreReporte = ? ;";
            OdbcCommand cmdSentencias = new OdbcCommand(sSql, conn.conexion());
            cmdSentencias.Parameters.Add("nombreReporte", OdbcType.VarChar).Value = nombreReporte;
            object resultado = cmdSentencias.ExecuteScalar();

            if (resultado != null && resultado != DBNull.Value)
            {
                return resultado.ToString();
            }

            return string.Empty;
        }
    }
}