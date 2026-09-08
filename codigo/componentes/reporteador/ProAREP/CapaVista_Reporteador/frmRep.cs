using CapaControlador_Reporteador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnVerRep_Click(object sender, EventArgs e)
        {
            string nombreReporte = txtNomRep.Text.Trim();

            if (string.IsNullOrEmpty(nombreReporte))
            {
                MessageBox.Show("Debe ingresar el nombre del reporte.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string rutaReporte = controlador.obtenerRutaReporte(nombreReporte);

                if (string.IsNullOrEmpty(rutaReporte))
                {
                    MessageBox.Show("No se encontró el reporte en la base de datos.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string rutaCompleta = controlador.construirRutaCompleta(nombreReporte, rutaReporte);

                if (!File.Exists(rutaCompleta))
                {
                    MessageBox.Show("El archivo PDF no existe en la ruta especificada:\n" + rutaCompleta,
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaCompleta,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}