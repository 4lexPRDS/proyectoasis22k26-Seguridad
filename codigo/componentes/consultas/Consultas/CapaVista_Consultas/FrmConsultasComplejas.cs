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

namespace CapaVista_Consultas
{
    public partial class FrmConsultasComplejas : ClsBaseTerminus
    {
        public FrmConsultasComplejas()
        {
            InitializeComponent();
            // Estandarización EST-10 del Componente Consultas
        /*    ClsEstandarizacionConsultas.ConsultasMetAplicarFormatoVentana(
                this, "4002", "ConsultasComplejas");
        */}

        /// <summary>
        /// TEMPORAL - Carga filas de ejemplo para el prototipo.
        /// Eliminar cuando el constructor de consultas alimente la cuadrícula.
        /// </summary>


        private void ConsultasBtnSalir_Click_1(object sender, EventArgs e)
        {
            FrmConsultasSimples ConsultaSimple_400_0011 = new FrmConsultasSimples();
            this.Hide();
            ConsultaSimple_400_0011.Show();
        }
    }
}
