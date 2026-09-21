using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReporteMantenimientoAplicacioncs : Form
    {
        private ClsModeloMantenimientoApp aplicacion = new ClsModeloMantenimientoApp();
        public FrmReporteMantenimientoAplicacioncs()
        {
            InitializeComponent();
        }

        private void FrmReporteMantenimientoAplicacioncs_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("RpReporteMantenimientoAplicacion", aplicacion.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteMantenimientoAplicacion.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
