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
using CapaControlador_Seguridad.Modelos_de_controladores;
using CapaControlador_Seguridad;

namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReporteMantenimientoModulo : Form
    {
        private ClsModeloModulo modulo = new ClsModeloModulo();
        public FrmReporteMantenimientoModulo()
        {
            InitializeComponent();
        }

        private void FrmReporteMantenimientoModulo_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("RpReporteMantenimientoModulo", modulo.SeguridadMetObtenerModulosReporte());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteMantenimientoModulo.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
