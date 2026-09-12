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
        private readonly clsTablas tablas = new clsTablas();
        private int _PaginaActual = 1;
        private int _RegistrosPorPagina = 10;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _inicioRangoPagina = 1;
        private int _cantidadBotonesPagina = 5;

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
                _inicioRangoPagina = 1;
            }

            _TablaSeleccionada = tablaSeleccionada;

            CalcularTotalPaginas();

            DataTable dtTablas = tablas.ConsutlasFuncLlenarTabla(
                _TablaSeleccionada,
                _PaginaActual,
                _RegistrosPorPagina);

            ConsultasDgvSimples.DataSource = dtTablas;

            CrearBotonesPaginas();

        }
        private void CalcularTotalPaginas()
        {
            _TotalRegistros = tablas.ConsultasFuncContarRegistros(_TablaSeleccionada);

            _TotalPaginas = (int)Math.Ceiling(
                (double)_TotalRegistros / _RegistrosPorPagina
            );
        }
        private void CrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            int finRango = _inicioRangoPagina + _cantidadBotonesPagina - 1;

            if (finRango > _TotalPaginas)
                finRango = _TotalPaginas;

            for (int i = _inicioRangoPagina; i <= finRango; i++)
            {
                ClsBotonPaginacionConsultas btn =
                    new ClsBotonPaginacionConsultas();

                btn.Name = $"ConsultasBtnPagina{i}";
                btn.Text = i.ToString();
                btn.Tag = i;
                btn.EsActivo = i == _PaginaActual;

                btn.Click += BtnPagina_Click;

                ConsultasFlpPaginas.Controls.Add(btn);
            }
        }
        private void BtnPagina_Click(object sender, EventArgs e)
        {
            ClsBotonPaginacionConsultas btn =
            (ClsBotonPaginacionConsultas)sender;

            _PaginaActual = Convert.ToInt32(btn.Tag);

            ConsultasProcActualizarTabla(_TablaSeleccionada);
        }

        private void ConsultasBtnAnterior_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultasBtnSiguiente_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultasBtnAnterior1_Click(object sender, EventArgs e)
        {
            if (_PaginaActual > 1)
            {
                _PaginaActual--;

                if (_PaginaActual < _inicioRangoPagina)
                {
                    _inicioRangoPagina--;
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
                    _inicioRangoPagina + _cantidadBotonesPagina)
                {
                    _inicioRangoPagina++;
                }

                ConsultasProcActualizarTabla(_TablaSeleccionada);
            }
        }
    }
}
