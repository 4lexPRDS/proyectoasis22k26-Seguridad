using CapaControlador_Consultas;
using CapaVista_Consultas.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public partial class ConsultasReutilizables : ClsControlUsuarioConsultas
    {
        public ConsultasReutilizables()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                //ClsEstandarizacionDataGridView.Estandarizar(ConsultasDgvConsultasReutilizables);
            }
        }

        private void ConsultasBtnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultasBtnIngresar_Click(object sender, EventArgs e)
        {
            FrmMantenimientoConsultas FrmMantenimientoConsultas1 = new FrmMantenimientoConsultas();
            FrmMantenimientoConsultas1.Show();
        }
    }
}
