using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmUsuarios : Form
    {
        //LLAMADO DE LACLASE MODELO USUARIO PARA PODER ACCEDER A SUS METODOS Y PROPIEDADES
        private ClsModeloUsuario _Usuario = new ClsModeloUsuario();
        //LLAMADO DE LA CLASE DE PERMISOS PARA PODER ACCEDER A SUS METODOS Y PROPIEDADES
        private ClsPermisoAplicacion _MisPermisos;

        private const int ID_MODULO = 4;       
        private const int ID_APLICACION = 5;  

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                var MapaBotones = new Dictionary<Control, TipoPermiso>
                {
                    { SeguridadBtnGuardar,   TipoPermiso.Insertar },
                    { SeguridadBtnModificar, TipoPermiso.Editar },
                    { SeguridadBtnReporte,   TipoPermiso.Imprimir }

                };

                _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                    this, ID_MODULO, ID_APLICACION, MapaBotones);

                if (!_MisPermisos.TieneAcceso)
                    return;
                //nombramos primero las columnas y luego llenamos todo
                SeguridadMetConfigurarColumnasUsuarios();
                SeguridadMetListarUsuarios();
                SeguridadMetCargarCombos();
                


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + Ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void SeguridadMetCargarCombos()
        {
            try
            {
                SeguridadCboEmpleado.DataSource = _Usuario.SeguridadMetObtenerEmpleados();
                SeguridadCboEmpleado.DisplayMember = "NombresEmpleado";
                SeguridadCboEmpleado.ValueMember = "IdEmpleado";
                SeguridadCboEmpleado.SelectedIndex = -1;
                SeguridadCboEmpleado.SelectedIndexChanged += CboEmpleado_SelectedIndexChanged;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeguridadCboEmpleado.SelectedValue != null)
            {
                SeguridadTxtIdEmpleado.Text = SeguridadCboEmpleado.SelectedValue.ToString();
            }
        }

        private void SeguridadMetListarUsuarios()
        {
            try
            {
                SeguridadDgvUsuarios.DataSource = _Usuario.SeguridadMetObtenerTodos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        //Metodo para configurar nombre de las columnas del DataGridView sean mas legibles
        private void SeguridadMetConfigurarColumnasUsuarios()
        {
            SeguridadDgvUsuarios.AutoGenerateColumns = false;
            SeguridadDgvUsuarios.Columns.Clear();

            SeguridadDgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdUsuario",
                DataPropertyName = "IdUsuario",
                HeaderText = "ID",
                Width = 50
            });

            SeguridadDgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdEmpleado",
                DataPropertyName = "IdEmpleado",
                HeaderText = "ID Empleado",
                Width = 90
            });

            SeguridadDgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombreUsuario",
                DataPropertyName = "NombreUsuario",
                HeaderText = "Usuario",
                Width = 160
            });

            SeguridadDgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUltimoAcceso",
                DataPropertyName = "UltimoAccesoUsuario",
                HeaderText = "Último acceso",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            SeguridadDgvUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive",
                DataPropertyName = "IsActive",
                HeaderText = "Estado",
                Width = 60
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeInsertar)
            {
                MessageBox.Show("No tienes permiso para agregar usuarios.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _Usuario.IdEmpleado = Convert.ToInt32(SeguridadTxtIdEmpleado.Text);
                _Usuario.NombreUsuario = SeguridadTxtUsuario.Text;
                _Usuario.ContrasenaUsuario = SeguridadTxtContrasena.Text;
                _Usuario.ConfirmarContrasenaUsuario = SeguridadTxtConfirmarContrasena.Text;
                _Usuario.UltimoAccesoUsuario = DateTime.Now;
                _Usuario.IsActive = SeguridadChkActivo.Checked ? 1 : 0;
                _Usuario.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_Usuario).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _Usuario.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarUsuarios();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeEditar)
            {
                MessageBox.Show("No tienes permiso para modificar usuarios.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeImprimir)
            {
                MessageBox.Show("No tienes permiso para generar reportes.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            SeguridadTxtIdEmpleado.Clear();
            SeguridadTxtUsuario.Clear();
            SeguridadTxtContrasena.Clear();
            SeguridadCboEmpleado.SelectedIndex = -1;
            SeguridadChkActivo.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadChkMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            SeguridadTxtContrasena.PasswordChar = SeguridadChkMostrarContra.Checked ? '\0' : '*';
        }
    }
}