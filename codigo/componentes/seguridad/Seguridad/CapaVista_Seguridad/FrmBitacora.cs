using CapaControlador_Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmBitacora : Form
    {
        ClsModeloBitacora controladorBitacora = new ClsModeloBitacora();
        public FrmBitacora()
        {
            InitializeComponent();
            CargarBitacora(); // Cargar los datos al abrir el formulario

            // Asignar eventos a los botones existentes
            this.btnVerBitacora.Click += new System.EventHandler(this.btnVerBitacora_Click);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
        }

        private void CargarBitacora()
        {
            try
            {
                var lista = controladorBitacora.SeguridadMetObtenerTodas();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;

                // Ajustar visualización de las columnas si existen
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarAccion_Click(object sender, EventArgs e)
        {
            FrmAsignacionPerfiles Formulario = new FrmAsignacionPerfiles();
            Formulario.Show();
        }

        private void btnVerBitacora_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}