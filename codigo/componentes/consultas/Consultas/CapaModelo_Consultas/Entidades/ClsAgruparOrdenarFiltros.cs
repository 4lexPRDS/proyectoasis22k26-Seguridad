using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModelo_Consultas
{
    /// Mishel loeiza 9959-23-3457
    /// Representa los filtros de agrupamiento/ordenamiento elegidos por el usuario.

    public class ClsAgruparOrdenarFiltros
    {
        private ClsConexion _Conexion = new ClsConexion();

        public string Tabla { get; set; }
        public string Ordenamiento { get; set; }
        public string CampoTabla { get; set; }
        public string Operador { get; set; }
        public string Valor { get; set; }

        public ClsAgruparOrdenarFiltros()
        {
            Ordenamiento = "ASC";
        }

        private void ConsultasMetPopularComboBox(string Pub_sTabla, ComboBox cboDestino)
        {
            cboDestino.Items.Clear();

            string Query = @"SELECT COLUMN_NAME
                             FROM INFORMATION_SCHEMA.COLUMNS
                             WHERE TABLE_SCHEMA = DATABASE()
                             AND TABLE_NAME = ?";

            OdbcConnection Conn = _Conexion.ConsultasFuncConexion();

            try
            {
                using (OdbcCommand Cmd = new OdbcCommand(Query, Conn))
                {
                    Cmd.Parameters.AddWithValue("@tabla", Pub_sTabla);

                    using (OdbcDataReader Reader = Cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            cboDestino.Items.Add(Reader["COLUMN_NAME"].ToString());
                        }
                    }
                }
            }
            finally
            {
                _Conexion.ConsultasProcDesconexion(Conn);
            }
        }

        public void ConsultasMetPopularComboBox(ComboBox cboDestino)
        {
            ConsultasMetPopularComboBox(this.Tabla, cboDestino);
        }
    }
}