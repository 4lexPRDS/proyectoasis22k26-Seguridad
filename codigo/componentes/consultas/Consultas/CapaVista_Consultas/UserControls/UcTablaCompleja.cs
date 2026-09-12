using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;
using CapaVista_Consultas.Components;

namespace CapaVista_Consultas
{
    public partial class UcTablaCompleja : ClsControlUsuarioConsultas
    {
        private readonly clsTablas _Tablas = new clsTablas();

        private int _PaginaActual = 1;
        private int _RegistrosPorPagina = 10;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _InicioRangoPagina = 1;
        private int _CantidadBotonesPagina = 5;

        public UcTablaCompleja()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasCboTablas.SelectionChangeCommitted +=
                    ConsultasCboTablas_SelectionChangeCommitted;

                ConsultasProcPopularCboTablas();
                ConsultasProcActualizarNavegacion();
            }
        }

        public void ConsultasProcPopularCboTablas()
        {
            ConsultasCboTablas.Items.Clear();

            DataTable dtTablas =
                _Tablas.ConsultasFuncObtenerTablas();

            foreach (DataRow fila in dtTablas.Rows)
            {
                ConsultasCboTablas.Items.Add(
                    fila[0].ToString());
            }

            ConsultasCboTablas.SelectedIndex = -1;
        }

        private void ConsultasProcActualizarTabla()
        {
            if (string.IsNullOrWhiteSpace(_TablaSeleccionada))
            {
                return;
            }

            ConsultasProcCalcularTotalPaginas();
            ConsultasProcActualizarDgvTablas();
            ConsultasProcCrearBotonesPaginas();
            ConsultasProcActualizarNavegacion();
        }

        private void ConsultasProcActualizarDgvTablas()
        {
            DataTable dtTablas =
                _Tablas.ConsutlasFuncLlenarTabla(
                    _TablaSeleccionada,
                    _PaginaActual,
                    _RegistrosPorPagina);

            ConsultasDgvComplejas.DataSource = dtTablas;
        }

        private void ConsultasProcCalcularTotalPaginas()
        {
            _TotalRegistros =
                _Tablas.ConsultasFuncContarRegistros(
                    _TablaSeleccionada);

            _TotalPaginas = (int)Math.Ceiling(
                (double)_TotalRegistros /
                _RegistrosPorPagina);

            if (_TotalPaginas == 0)
            {
                _PaginaActual = 1;
                _InicioRangoPagina = 1;
                return;
            }

            if (_PaginaActual > _TotalPaginas)
            {
                _PaginaActual = _TotalPaginas;
            }
        }

        private void ConsultasProcCrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            if (_TotalPaginas <= 0)
            {
                return;
            }

            int finRango =
                _InicioRangoPagina +
                _CantidadBotonesPagina - 1;

            if (finRango > _TotalPaginas)
            {
                finRango = _TotalPaginas;
            }

            for (
                int numeroPagina = _InicioRangoPagina;
                numeroPagina <= finRango;
                numeroPagina++)
            {
                ClsBotonPaginacionConsultas botonPagina =
                    new ClsBotonPaginacionConsultas();

                botonPagina.Name =
                    $"ConsultasBtnPagina{numeroPagina}";

                botonPagina.Text =
                    numeroPagina.ToString();

                botonPagina.Tag =
                    numeroPagina;

                botonPagina.EsActivo =
                    numeroPagina == _PaginaActual;

                botonPagina.Click +=
                    ConsultasBtnPagina_Click;

                ConsultasFlpPaginas.Controls.Add(
                    botonPagina);
            }
        }

        private void ConsultasProcActualizarNavegacion()
        {
            ConsultasBtnAnterior.Enabled =
                _PaginaActual > 1;

            ConsultasBtnSiguiente.Enabled =
                _TotalPaginas > 0 &&
                _PaginaActual < _TotalPaginas;
        }

        private void ConsultasCboTablas_SelectionChangeCommitted(
            object sender,
            EventArgs e)
        {
            if (ConsultasCboTablas.SelectedItem == null)
            {
                return;
            }

            _TablaSeleccionada =
                ConsultasCboTablas.SelectedItem.ToString();

            _PaginaActual = 1;
            _InicioRangoPagina = 1;

            ConsultasProcActualizarTabla();
        }

        private void ConsultasBtnPagina_Click(
            object sender,
            EventArgs e)
        {
            if (!(sender is ClsBotonPaginacionConsultas botonPagina))
            {
                return;
            }

            _PaginaActual =
                Convert.ToInt32(botonPagina.Tag);

            ConsultasProcActualizarTabla();
        }

        private void ConsultasBtnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (_PaginaActual >= _TotalPaginas)
            {
                return;
            }

            _PaginaActual++;

            if (_PaginaActual >=
                _InicioRangoPagina +
                _CantidadBotonesPagina)
            {
                _InicioRangoPagina++;
            }

            ConsultasProcActualizarTabla();
        }

        private void ConsultasBtnAnterior_Click_1(object sender, EventArgs e)
        {
            if (_PaginaActual <= 1)
            {
                return;
            }

            _PaginaActual--;

            if (_PaginaActual < _InicioRangoPagina)
            {
                _InicioRangoPagina--;
            }

            ConsultasProcActualizarTabla();
        }
    }
}