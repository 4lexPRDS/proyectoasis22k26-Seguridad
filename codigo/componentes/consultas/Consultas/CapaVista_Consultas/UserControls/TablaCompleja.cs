using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;
using CapaVista_Consultas.Components;

namespace CapaVista_Consultas
{
    public partial class TablaCompleja : ClsControlUsuarioConsultas
    {
        private int _PaginaActual = 1;
        private int _RegistrosPorPagina = 10;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _inicioRangoPagina = 1;
        private int _cantidadBotonesPagina = 5;

        private readonly clsTablas tablas = new clsTablas();

        public TablaCompleja()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasDgvComplejas.AutoGenerateColumns = true;

                ConsultasCboTablas.SelectionChangeCommitted +=
                    ConsultasCboTablas_SelectionChangeCommitted;

                ConsultasProcPopularCboTablas();
            }
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
                _inicioRangoPagina = 1;

                ConsultasProcActualizarTabla();
            }

        public void ConsultasProcPopularCboTablas()
        {
            ConsultasCboTablas.Items.Clear();

            DataTable dtTablas = tablas.ConsultasFuncObtenerTablas();

            foreach (DataRow row in dtTablas.Rows)
            {
                ConsultasCboTablas.Items.Add(row[0].ToString());
            }

            ConsultasCboTablas.SelectedIndex = -1;
        }

        private void ConsultasProcActualizarDgvTablas(
        string tablaSeleccionada)
        {
            DataTable dtTablas =
                tablas.ConsutlasFuncLlenarTabla(
                    tablaSeleccionada,
                    _PaginaActual,
                    _RegistrosPorPagina);

            ConsultasDgvComplejas.DataSource = dtTablas;
        }

        private void ConsultasProcCalcularTotalPaginas()
        {
            _TotalRegistros =
                tablas.ConsultasFuncContarRegistros(_TablaSeleccionada);

            _TotalPaginas = (int)Math.Ceiling(
                (double)_TotalRegistros / _RegistrosPorPagina);
        }

        private void ConsultasProcCrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            int finRango =
                _inicioRangoPagina +
                _cantidadBotonesPagina - 1;

            if (finRango > _TotalPaginas)
            {
                finRango = _TotalPaginas;
            }

            for (int i = _inicioRangoPagina; i <= finRango; i++)
            {
                ClsBotonPaginacionConsultas btn =
                    new ClsBotonPaginacionConsultas();

                btn.Name = $"ConsultasBtnPagina{i}";
                btn.Text = i.ToString();
                btn.Tag = i;
                btn.EsActivo = i == _PaginaActual;

                btn.Click += ConsultasBtnPagina_Click;

                ConsultasFlpPaginas.Controls.Add(btn);
            }
        }

        private void ConsultasProcActualizarTabla()
        {
            if (string.IsNullOrWhiteSpace(_TablaSeleccionada))
            {
                return;
            }

            ConsultasProcCalcularTotalPaginas();
            ConsultasProcCrearBotonesPaginas();
            ConsultasProcActualizarDgvTablas(_TablaSeleccionada);
        }

        private void ConsultasCboTablas_SelectedIndexChanged(
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
            _inicioRangoPagina = 1;

            ConsultasProcActualizarTabla();
        }

        private void ConsultasBtnPagina_Click(
            object sender,
            EventArgs e)
        {
            ClsBotonPaginacionConsultas btn =
                (ClsBotonPaginacionConsultas)sender;

            _PaginaActual = Convert.ToInt32(btn.Tag);

            ConsultasProcActualizarTabla();
        }

        private void ConsultasBtnSiguiente_Click(
            object sender,
            EventArgs e)
        {
            if (_PaginaActual >= _TotalPaginas)
            {
                return;
            }

            _PaginaActual++;

            if (_PaginaActual >=
                _inicioRangoPagina +
                _cantidadBotonesPagina)
            {
                _inicioRangoPagina++;
            }

            ConsultasProcActualizarTabla();
        }

        private void ConsultasBtnAnterior_Click(
            object sender,
            EventArgs e)
        {
            if (_PaginaActual <= 1)
            {
                return;
            }

            _PaginaActual--;

            if (_PaginaActual < _inicioRangoPagina)
            {
                _inicioRangoPagina--;
            }

            ConsultasProcActualizarTabla();
        }
    }
}