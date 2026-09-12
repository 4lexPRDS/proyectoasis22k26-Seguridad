using CapaControlador_Seguridad;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CapaVista_Seguridad
{
    public partial class FrmUsuarios : Form
    {
        private ClsModeloUsuario _Usuario = new ClsModeloUsuario();
        public FrmUsuarios()
        {
            InitializeComponent();

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            SeguridadMetListarUsuarios();
            SeguridadMetCargarCombos();
            SeguridadMetCargarComboEstado();
        }

        private void SeguridadMetCargarComboEstado()
        {
            cboEstado.DataSource = _Usuario.SeguridadMetObtenerEstados();
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = -1;
        }
        private void SeguridadMetCargarCombos()
        {
            try
            {
                cboEmpleado.DataSource = _Usuario.SeguridadMetObtenerEmpleados();
                cboEmpleado.DisplayMember = "NombresEmpleado";
                cboEmpleado.ValueMember = "IdEmpleado";
                cboEmpleado.SelectedIndex = -1;
                cboEmpleado.SelectedIndexChanged += CboEmpleado_SelectedIndexChanged;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        private void CboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedValue != null)
            {
                txtIdEmpleado.Text = cboEmpleado.SelectedValue.ToString();
            }
        }

        private void SeguridadMetListarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = _Usuario.SeguridadMetObtenerTodos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }

        }

        private void cboIdEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkVerContrasena_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _Usuario.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                _Usuario.NombreUsuario = txtUsuario.Text;
                _Usuario.ContrasenaUsuario = txtContrasena.Text;
                _Usuario.UltimoAccesoUsuario = DateTime.Now;
                _Usuario.IsActive = Convert.ToInt32(cboEstado.SelectedValue);
                _Usuario.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_Usuario).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _Usuario.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarUsuarios();
                    //Reinicio();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}