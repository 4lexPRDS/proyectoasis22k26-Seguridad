using System.Data;
using System.Data.SqlClient;

namespace CapaModelo_Consultas
{
    /// mishel loeiza 9959-23-3457
    /// Ejecuta las consultas reales contra la base de datos usando
    /// los valores guardados en un ClsAgruparOrdenarFiltros.
    
    public class ClsConsultasDatos
    {
        private string _CadenaConexion = "Data Source=.;Initial Catalog=TU_BD;Integrated Security=True";

        public DataTable ConsultasMetObtenerDatosFiltrados(ClsAgruparOrdenarFiltros filtros)
        {
            string Query = $"SELECT * FROM {filtros.Tabla}";

            bool HayFiltro = !string.IsNullOrEmpty(filtros.Operador)
                              && !string.IsNullOrEmpty(filtros.Valor);

            if (HayFiltro)
                Query += $" WHERE {filtros.CampoTabla} {ConsultasMetTraducirOperador(filtros.Operador)} @valor";

            Query += $" ORDER BY {filtros.CampoTabla} {filtros.Ordenamiento}";

            return ConsultasMetEjecutar(Query, filtros, HayFiltro);
        }

        public DataTable ConsultasMetObtenerDatosAgrupados(ClsAgruparOrdenarFiltros filtros)
        {
            string query = $@"SELECT {filtros.CampoTabla}, COUNT(*) AS Total
                               FROM {filtros.Tabla}
                               GROUP BY {filtros.CampoTabla}
                               ORDER BY {filtros.CampoTabla} {filtros.Ordenamiento}";

            return ConsultasMetEjecutar(query, filtros, aplicarFiltro: false);
        }

        private string ConsultasMetTraducirOperador(string operadorTexto)
        {
            switch (operadorTexto)
            {
                case "Contiene":
                case "Comienza con":
                case "Termina con":
                    return "LIKE";
                default:
                    return operadorTexto;
            }
        }

        private DataTable ConsultasMetEjecutar(string query, ClsAgruparOrdenarFiltros filtros, bool aplicarFiltro)
        {
            DataTable Dt = new DataTable();

            using (SqlConnection Conn = new SqlConnection(_CadenaConexion))
            using (SqlCommand Cmd = new SqlCommand(query, Conn))
            {
                if (aplicarFiltro)
                {
                    string ValorParametro = filtros.Valor;

                    if (filtros.Operador == "Contiene")
                        ValorParametro = $"%{filtros.Valor}%";
                    else if (filtros.Operador == "Comienza con")
                        ValorParametro = $"{filtros.Valor}%";
                    else if (filtros.Operador == "Termina con")
                        ValorParametro = $"%{filtros.Valor}";

                    Cmd.Parameters.AddWithValue("@valor", ValorParametro);
                }

                using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                {
                    Da.Fill(Dt);
                }
            }

            return Dt;
        }
    }
}