using System;
using System.Data;
using System.Data.Odbc;
using System.Text.RegularExpressions;

namespace CapaModelo_Consultas
{
    public class ClsSentenciasTablas
    {
        private readonly ClsConexion _Conexion = new ClsConexion();

        public DataTable ConsultasFuncObtenerTabla(
            string NombreTabla,
            int Pagina,
            int RegistrosPorPagina)
        {
            ConsultasMetValidarNombreTabla(NombreTabla);

            DataTable DtTabla = new DataTable();

            try
            {
                int Inicio = (Pagina - 1) * RegistrosPorPagina;

                string Consulta =
                    "SELECT * FROM " + NombreTabla +
                    " LIMIT ? OFFSET ?;";

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    using (OdbcCommand Cmd =
                        new OdbcCommand(Consulta, Conexion))
                    {
                        Cmd.Parameters.AddWithValue(
                            "?",
                            RegistrosPorPagina);

                        Cmd.Parameters.AddWithValue(
                            "?",
                            Inicio);

                        using (OdbcDataAdapter DaTabla =
                            new OdbcDataAdapter(Cmd))
                        {
                            DaTabla.Fill(DtTabla);
                        }
                    }
                }

                return DtTabla;
            }
            catch (Exception Ex)
            {
                throw new Exception(
                    "Error al cargar la tabla " +
                    NombreTabla + ".",
                    Ex);
            }
        }

        public DataTable ConsultasFuncObtenerTablas()
        {
            DataTable DtTablas = new DataTable();

            try
            {
                string Consulta = "SHOW TABLES;";

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    using (OdbcCommand Cmd =
                        new OdbcCommand(Consulta, Conexion))
                    {
                        using (OdbcDataAdapter DaTablas =
                            new OdbcDataAdapter(Cmd))
                        {
                            DaTablas.Fill(DtTablas);
                        }
                    }
                }

                return DtTablas;
            }
            catch (Exception Ex)
            {
                throw new Exception(
                    "Error al obtener las tablas de la base de datos.",
                    Ex);
            }
        }

        public int ConsultasFuncContarRegistros(
            string NombreTabla)
        {
            ConsultasMetValidarNombreTabla(NombreTabla);

            try
            {
                string Consulta =
                    "SELECT COUNT(*) FROM " + NombreTabla + ";";

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    if (Conexion.State != ConnectionState.Open)
                    {
                        Conexion.Open();
                    }

                    using (OdbcCommand Cmd =
                        new OdbcCommand(Consulta, Conexion))
                    {
                        return Convert.ToInt32(
                            Cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(
                    "Error al contar los registros de la tabla " +
                    NombreTabla + ".",
                    Ex);
            }
        }

        private void ConsultasMetValidarNombreTabla(
            string NombreTabla)
        {
            if (string.IsNullOrWhiteSpace(NombreTabla))
            {
                throw new ArgumentException(
                    "El nombre de la tabla no puede estar vacío.");
            }

            if (!Regex.IsMatch(
                NombreTabla,
                @"^[A-Za-z_][A-Za-z0-9_]*$"))
            {
                throw new ArgumentException(
                    "El nombre de la tabla contiene caracteres no válidos.");
            }
        }
    }
}