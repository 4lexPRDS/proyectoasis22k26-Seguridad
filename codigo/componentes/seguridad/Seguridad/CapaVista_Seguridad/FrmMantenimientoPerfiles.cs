using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
using System;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{

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