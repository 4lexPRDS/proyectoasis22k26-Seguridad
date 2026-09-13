using System.Data;
using System.Windows.Forms;
using CapaModelo_Consultas;

namespace CapaControlador_Consultas
{
    /// Mishel loeiza 9959-23-3457
    /// Recibe las acciones de la Vista, valida datos y llama a la CapaModelo.
    /// </summary>

    public class ClsControladorConsultas
    {
        private ClsAgruparOrdenarFiltros _filtros = new ClsAgruparOrdenarFiltros();
        private ClsConsultasDatos _datos = new ClsConsultasDatos();

        public void PoblarComboCampos(string tabla, ComboBox cboDestino)
        {
            _filtros.Pub_sTabla = tabla;
            _filtros.Pub_PopularComboBox(cboDestino);
        }

        public string ValidarFiltro(string campo)
        {
            if (string.IsNullOrEmpty(campo))
                return "Selecciona un campo antes de filtrar.";

            return null; // sin errores
        }

        public DataTable Filtrar(string tabla, string campo, string operador, string valor, string ordenamiento)
        {
            _filtros.Pub_sTabla = tabla;
            _filtros.Pub_sCampoTabla = campo;
            _filtros.Pub_sOperador = operador;
            _filtros.Pub_sValor = valor;
            _filtros.Pub_sOrdenamiento = ordenamiento;

            return _datos.ObtenerDatosFiltrados(_filtros);
        }

        public DataTable Agrupar(string tabla, string campo, string ordenamiento)
        {
            _filtros.Pub_sTabla = tabla;
            _filtros.Pub_sCampoTabla = campo;
            _filtros.Pub_sOrdenamiento = ordenamiento;

            return _datos.ObtenerDatosAgrupados(_filtros);
        }
    }
}