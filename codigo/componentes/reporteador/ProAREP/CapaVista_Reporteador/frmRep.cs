using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Reporteador;

namespace CapaVista_Reporteador
{
    public partial class frmRep : Form
    {
        Controlador controlador = new Controlador();

        public frmRep()
        {
            InitializeComponent();
        }

        private void frmRep_Load(object sender, EventArgs e)
        {
            dtgRep.DataSource = controlador.llenarDgv("reportes");
        }

        private void btnAplFil_Click(object sender, EventArgs e)
        {
            bool porNombre = buscar.GetItemChecked(0);
            bool porFecha = buscar.GetItemChecked(1);

            // Ningún filtro
            if (!porNombre && !porFecha)
            {
                dtgRep.DataSource =
                    controlador.llenarDgv("reportes");
            }

            // Solo nombre
            else if (porNombre && !porFecha)
            {
                dtgRep.DataSource =
                    controlador.filtrarNombre(txtBus.Text);
            }

            // Solo fecha
            else if (!porNombre && porFecha)
            {
                dtgRep.DataSource =
                    controlador.filtrarFecha(dtpFecha.Value);
            }

            // Nombre y fecha
            else
            {
                dtgRep.DataSource =
                    controlador.filtrarNombreYFecha(
                        txtBus.Text,
                        dtpFecha.Value
                    );
            }
    }
    }
}