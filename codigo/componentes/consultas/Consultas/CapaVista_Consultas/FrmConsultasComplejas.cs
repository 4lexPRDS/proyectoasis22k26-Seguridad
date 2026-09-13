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
        }

        private void ConsultasBtnSalir_Click_1(object sender, EventArgs e)
        {
            FrmConsultasSimples FormularioConsultasSimples = new FrmConsultasSimples();
            this.Hide();
            FormularioConsultasSimples.Show();
        }
    }
}
