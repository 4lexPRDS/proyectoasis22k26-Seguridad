using CapaControlador_Seguridad;
using Microsoft.Reporting.WinForms;
using CapaControlador_Seguridad.Modelos_de_controladores;
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
    public partial class FrmReporteAsigAppPerf : Form
    {

        private ClsModeloAsigAppPerf AsigAppPerf = new ClsModeloAsigAppPerf();
        public FrmReporteAsigAppPerf()
        {
            InitializeComponent();
        }

        private void FrmReporteAsigAppPerf_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DsAsigAppPerf", AsigAppPerf.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteAsigAppPerf.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}

