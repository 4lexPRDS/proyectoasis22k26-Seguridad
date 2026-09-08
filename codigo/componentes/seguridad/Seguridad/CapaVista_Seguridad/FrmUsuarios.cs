using CapaControlador_Seguridad;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CapaVista_Seguridad
{
    public partial class FrmUsuarios : Form
    {
        private ModeloUsuario usuario = new ModeloUsuario();
        public FrmUsuarios()
        {
            InitializeComponent();
            
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListaUsuarios();
            CargarCombos();
            CargarComboEstado();
        }

        private void CargarComboEstado()
        {
            cboEstado.DataSource = usuario.GetEstados();
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = -1;
        }
        private void CargarCombos()
        {
            try
            {
                cboEmpleado.DataSource = usuario.GetEmpleados();
                cboEmpleado.DisplayMember = "nombresEmpleado";
                cboEmpleado.ValueMember = "idEmpleado";
                cboEmpleado.SelectedIndex = -1;
                cboEmpleado.SelectedIndexChanged += CboEmpleado_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedValue != null)
            {
                txtIdEmpleado.Text = cboEmpleado.SelectedValue.ToString();
            }
        }

        private void ListaUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = usuario.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                usuario.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                usuario.usuarioUsuario = txtUsuario.Text;
                usuario.contrasenaUsuario = txtContrasena.Text;
                usuario.ultimoAccesoUsuario = DateTime.Now;
                usuario.is_active = Convert.ToInt32(cboEstado.SelectedValue);
                usuario.Estado = EstadoEntidad.Added;

                bool valido = new ValidacionDatos(usuario).Validar();
                if (valido)
                {
                    string resultado = usuario.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaUsuarios();
                    //Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
    }
}
