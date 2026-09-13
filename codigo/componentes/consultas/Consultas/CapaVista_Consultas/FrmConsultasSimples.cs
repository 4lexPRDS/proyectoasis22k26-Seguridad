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
    public partial class FrmConsultasSimples : ClsBaseTerminus
    {
        ClsControladorConsultaSimple _Controlador = new ClsControladorConsultaSimple();

        //Variable dinámica de la tabla = empleado es eliminable
        public string TablaActual { get; set; } = "empleado";

        public FrmConsultasSimples()
        {
            InitializeComponent();

        }

        public FrmConsultasSimples( string tabla)
        {
            InitializeComponent();
            ConsultasUcTablaSimple.ConsultasProcActualizarTabla(tabla);
        }

        private void ConsultasBtnComplejas_Click(object sender, EventArgs e)
        {
            FrmConsultasComplejas FormularioConsultasComplejas = new FrmConsultasComplejas();
            this.Hide();
            FormularioConsultasComplejas.Show();
        }
    }
}