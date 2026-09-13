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
    public partial class UcConsultasReutilizables : ClsControlUsuarioConsultas
    {
        public UcConsultasReutilizables()
        {
            InitializeComponent();
        }
        private void ConsultasBtnIngresar_Click(object sender, EventArgs e)
        {
            FrmMantenimientoConsultas FormularioMantenimientoConsultas = new FrmMantenimientoConsultas();
            FormularioMantenimientoConsultas.Show();
        }
    }
}
