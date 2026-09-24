using CapaControlador_Seguridad;
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
    public partial class FrmReporteAsignacionAplicacionUsuario : Form
    {
        private ClsModeloAsigAppUsuario AsigAppUsu = new ClsModeloAsigAppUsuario();
        public FrmReporteAsignacionAplicacionUsuario()
        {
            InitializeComponent();
        }

        private void FrmReporteAsignacionAplicacionUsuario_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("ReporteAsignacionAppUsu", AsigAppUsu.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteAsignacionAplicacionUsuario.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
