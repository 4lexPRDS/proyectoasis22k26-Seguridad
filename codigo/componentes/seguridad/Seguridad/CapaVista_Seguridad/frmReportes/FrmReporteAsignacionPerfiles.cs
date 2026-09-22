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
    public partial class FrmReporteAsignacionPerfiles : Form
    {

        private ClsModeloAsignacionPerfiles AsignacionPerfiles = new ClsModeloAsignacionPerfiles();
        public FrmReporteAsignacionPerfiles()
        {
            InitializeComponent();
        }

        private void FrmReporteAsignacionPerfiles_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DsAsignacionPerfiles", AsignacionPerfiles.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteAsignacionPerfiles.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
