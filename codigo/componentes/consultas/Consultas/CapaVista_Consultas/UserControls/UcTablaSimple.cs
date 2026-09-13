using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Consultas;
using CapaVista_Consultas.Components;

namespace CapaVista_Consultas.UserControls
{
    public partial class UcTablaSimple : ClsControlUsuarioConsultas
    {
        private readonly ClsTablas Tablas = new ClsTablas();
        private int _PaginaActual = 1;
        private int _RegistrosPorPagina = 10;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _InicioRangoPagina = 1;
        private int _CantidadBotonesPagina = 5;

        public UcTablaSimple()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasDgvSimples.AutoGenerateColumns = true;
                ConsultasProcActualizarTabla("consulta");
            }
        }

        public UcTablaSimple(string tabla)
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasDgvSimples.AutoGenerateColumns = true;
                ConsultasProcActualizarTabla(tabla);
            }
        }
        /*private string _nombreTabla;
        [Category("Consultas")]
        [Description("Nombre de la tabla que se mostrará.")]
        [TypeConverter(typeof(TablaConverter))]
        public string NombreTabla
        {
            get { return _nombreTabla; }
            set { _nombreTabla = value; }
        }


        [Category("Consultas")]
        [Description("Indica si la tabla se carga automáticamente al iniciar.")]
        public bool CargarAutomaticamente { get; set; } = true;

        private void TablaSimple_Load(object sender, EventArgs e)
        {
            if (CargarAutomaticamente && !string.IsNullOrWhiteSpace(_nombreTabla))
            {
                ActualizarTabla();
            }
        }*/

        public void ConsultasProcActualizarTabla(string tablaSeleccionada)
        {
            if (_TablaSeleccionada != tablaSeleccionada)
            {
                _PaginaActual = 1;
                _InicioRangoPagina = 1;
            }

            _TablaSeleccionada = tablaSeleccionada;

            ConsultasProcCalcularTotalPaginas();

            DataTable DtTablas = Tablas.ConsultasFuncLlenarTabla(
                _TablaSeleccionada,
                _PaginaActual,
                _RegistrosPorPagina);

            ConsultasDgvSimples.DataSource = DtTablas;

            ConsultasProcCrearBotonesPaginas();

        }
        private void ConsultasProcCalcularTotalPaginas()
        {
            _TotalRegistros = Tablas.ConsultasFuncContarRegistros(_TablaSeleccionada);

            _TotalPaginas = (int)Math.Ceiling(
                (double)_TotalRegistros / _RegistrosPorPagina
            );
        }
        private void ConsultasProcCrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            int FinRango = _InicioRangoPagina + _CantidadBotonesPagina - 1;

            if (FinRango > _TotalPaginas)
                FinRango = _TotalPaginas;

            for (int NumeroPagina = _InicioRangoPagina; NumeroPagina <= FinRango; NumeroPagina++)
            {
                ClsBotonPaginacionConsultas BotonPagina =
                    new ClsBotonPaginacionConsultas();

                BotonPagina.Name = $"ConsultasBtnPagina{NumeroPagina}";
                BotonPagina.Text = NumeroPagina.ToString();
                BotonPagina.Tag = NumeroPagina;
                BotonPagina.EsActivo = NumeroPagina == _PaginaActual;

                BotonPagina.Click += BtnPagina_Click;

                ConsultasFlpPaginas.Controls.Add(BotonPagina);
            }
        }
        private void BtnPagina_Click(object sender, EventArgs e)
        {
            ClsBotonPaginacionConsultas BotonPagina =
            (ClsBotonPaginacionConsultas)sender;

            _PaginaActual = Convert.ToInt32(BotonPagina.Tag);

            ConsultasProcActualizarTabla(_TablaSeleccionada);
        }

        private void ConsultasBtnAnterior1_Click(object sender, EventArgs e)
        {
            if (_PaginaActual > 1)
            {
                _PaginaActual--;

                if (_PaginaActual < _InicioRangoPagina)
                {
                    _InicioRangoPagina--;
                }

                ConsultasProcActualizarTabla(_TablaSeleccionada);
            }
        }

        private void ConsultasBtnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (_PaginaActual < _TotalPaginas)
            {
                _PaginaActual++;

                if (_PaginaActual >=
                    _InicioRangoPagina + _CantidadBotonesPagina)
                {
                    _InicioRangoPagina++;
                }

                ConsultasProcActualizarTabla(_TablaSeleccionada);
            }
        }
    }
}
