using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
using System;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    /// <summary>
    /// Vista: Mantenimiento de Perfiles (componente Seguridad).
    /// Prototipo NO funcional — únicamente diseño visual, estandarizado según
    /// EST-10 "Estandarización de Software" (Proyecto Terminus). Sin conexiones
    /// a base de datos ni a CapaControlador_Seguridad / CapaModelo_Seguridad.
    ///
    /// Mapeo de campos con dbSistemaEmbutidos (tabla tblRol, único origen real
    /// de "Perfil" en la base de datos):
    ///   Código Perfil          -> idRol
    ///   Nombre del Perfil      -> nombreRol
    ///   Descripción del Perfil -> descripcionRol
    ///   Estado del Perfil      -> is_active
    /// No se incluyen "Puesto" ni "Tipo de Perfil": no existen columnas
    /// equivalentes en tblRol.
    ///
    /// Capa: CapaVista_Seguridad. La lógica real (validaciones, CRUD) vive en
    /// CapaControlador_Seguridad; el acceso a datos, en CapaModelo_Seguridad.
    /// La Vista no debe ejecutar SQL ni acceder al Modelo directamente.
    /// </summary>
    public partial class FrmMantenimientoPerfiles : Form
    {
        private ClsModeloRoles _SeguridadRoles = new ClsModeloRoles();

        public FrmMantenimientoPerfiles()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoPerfiles_Load(object sender, System.EventArgs e)
        {
            SeguridadMetListarRoles();
        }

        private void SeguridadMetListarRoles()
        {
            try
            {
                SeguridadDgvListaRoles.DataSource = _SeguridadRoles.SeguridadMetObtenerTodos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadMetReinicio()
        {
            SeguridadTxtNombreRol.Clear();
            SeguridadTxtDescripcionRol.Clear();
            SeguridadChkActivo.Checked = false;
        }

        private void SeguridadLblTitulo_Click(object sender, System.EventArgs e)
        {

        }

        private void SeguridadLblSubtitulo_Click(object sender, System.EventArgs e)
        {

        }

        private void SeguridadPbMascota_Click(object sender, System.EventArgs e)
        {

        }

        private void x_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {

        }

        private void SeguridadDgvPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _SeguridadRoles.NombreRol = SeguridadTxtNombreRol.Text;
                _SeguridadRoles.DescripcionRol = SeguridadTxtDescripcionRol.Text;
                _SeguridadRoles.IsActive = SeguridadChkActivo.Checked;
                _SeguridadRoles.Estado = EstadoEntidad.Added;

                bool Valido = new Ayudas.ClsValidacionDatos(_SeguridadRoles).SeguridadMetValidar();
                if (Valido == true)
                {
                    string Resultado = _SeguridadRoles.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarRoles();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.SelectedRows.Count > 0)
            {
                _SeguridadRoles.Estado = EstadoEntidad.Modified;
                _SeguridadRoles.IdRol = Convert.ToInt32(SeguridadDgvListaRoles.CurrentRow.Cells[0].Value);
                _SeguridadRoles.NombreRol = SeguridadTxtNombreRol.Text;
                _SeguridadRoles.DescripcionRol = SeguridadTxtDescripcionRol.Text;
                _SeguridadRoles.IsActive = SeguridadChkActivo.Checked;

                bool Valido = new Ayudas.ClsValidacionDatos(_SeguridadRoles).SeguridadMetValidar();
                if (Valido == true)
                {
                    string Resultado = _SeguridadRoles.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarRoles();
                    SeguridadMetReinicio();
                }
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void SeguridadBtnEliminar_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.SelectedRows.Count > 0)
            {
                _SeguridadRoles.Estado = EstadoEntidad.Deleted;
                _SeguridadRoles.IdRol = Convert.ToInt32(SeguridadDgvListaRoles.CurrentRow.Cells[0].Value);

                string Resultado = _SeguridadRoles.SeguridadMetGrabarCambios();
                MessageBox.Show(Resultado);
                SeguridadMetListarRoles();
                SeguridadMetReinicio();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void SeguridadBtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                _SeguridadRoles.NombreRol = SeguridadTxtNombreRol.Text;
                _SeguridadRoles.DescripcionRol = SeguridadTxtDescripcionRol.Text;
                _SeguridadRoles.IsActive = SeguridadChkActivo.Checked;
                _SeguridadRoles.Estado = EstadoEntidad.Added;

                bool Valido = new Ayudas.ClsValidacionDatos(_SeguridadRoles).SeguridadMetValidar();
                if (Valido == true)
                {
                    string Resultado = _SeguridadRoles.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarRoles();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}