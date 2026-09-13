using System.Data;
using System.Windows.Forms;
using CapaModelo_Consultas;

namespace CapaControlador_Consultas
{
    /// <summary>
    /// Mishel loeiza 9959-23-3457
    /// Recibe las acciones de la Vista, valida datos y llama a la CapaModelo.
    /// </summary>

    public class ClsControladorConsultas
    {
        private ClsAgruparOrdenarFiltros _Filtros = new ClsAgruparOrdenarFiltros();
        private ClsConsultasDatos _Datos = new ClsConsultasDatos();

        public void ConsultasMetPoblarComboCampos(string tabla, ComboBox cboDestino)
        {
            _Filtros.Tabla = tabla;
            _Filtros.ConsultasMetPopularComboBox(cboDestino);
        }
        public string ConsultasMetValidarFiltro(string campo)
        {
            if (string.IsNullOrEmpty(campo))
                return "Selecciona un campo antes de filtrar.";

            return null; // sin errores
        }

        public DataTable ConsultasMetFiltrar(string tabla, string campo, string operador, string valor, string ordenamiento)
        {
            _Filtros.Tabla = tabla;
            _Filtros.CampoTabla = campo;
            _Filtros.Operador = operador;
            _Filtros.Valor = valor;
            _Filtros.Ordenamiento = ordenamiento;

            return _Datos.ConsultasMetObtenerDatosFiltrados(_Filtros);
        }

        public DataTable ConsultasMetAgrupar(string tabla, string campo, string ordenamiento)
        {
            _Filtros.Tabla = tabla;
            _Filtros.CampoTabla = campo;
            _Filtros.Ordenamiento = ordenamiento;

            return _Datos.ConsultasMetObtenerDatosAgrupados(_Filtros);
        }
    }
}