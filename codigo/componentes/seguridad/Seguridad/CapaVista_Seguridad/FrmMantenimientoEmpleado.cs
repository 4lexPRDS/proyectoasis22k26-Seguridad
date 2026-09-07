using System;
using System.Windows.Forms;

namespace proyecto2k26
{
    // Vista estandarizada (EST-10) — Componente Seguridad.
    // Solo diseño/UI: no se conecta a Controlador/Modelo ni contiene logica de negocio o SQL.
    public partial class FrmMantenimientoEmpleado : Form
    {
        public FrmMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void SeguridadBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
