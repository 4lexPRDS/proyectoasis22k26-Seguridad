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

        private ModeloRoles seguridadRoles = new ModeloRoles();

        public FrmMantenimientoPerfiles()
        {
            InitializeComponent();
        }



        private void FrmMantenimientoPerfiles_Load(object sender, System.EventArgs e)
        {
            ListaRoles();
        }

        private void ListaRoles()
        {
            try
            {
                SeguridadDgvListaRoles.DataSource = seguridadRoles.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Reinicio()
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
                seguridadRoles.NombreRol = SeguridadTxtNombreRol.Text;
                seguridadRoles.DescripcionRol = SeguridadTxtDescripcionRol.Text;
                seguridadRoles.IsActive = SeguridadChkActivo.Checked;
                seguridadRoles.Estado = EstadoEntidad.Added;

                bool valido = new Ayudas.ValidacionDatos(seguridadRoles).Validar();
                if (valido == true)
                {
                    string resultado = seguridadRoles.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaRoles();
                    Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {


            if (SeguridadDgvListaRoles.SelectedRows.Count > 0)
            {
                seguridadRoles.Estado = EstadoEntidad.Modified;
                seguridadRoles.IdRol = Convert.ToInt32(SeguridadDgvListaRoles.CurrentRow.Cells[0].Value);
                seguridadRoles.NombreRol = SeguridadTxtNombreRol.Text;
                seguridadRoles.DescripcionRol = SeguridadTxtDescripcionRol.Text;
                seguridadRoles.IsActive = SeguridadChkActivo.Checked;


                bool valido = new Ayudas.ValidacionDatos(seguridadRoles).Validar();
                if (valido == true)
                {
                    string resultado = seguridadRoles.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaRoles();
                    Reinicio();
                }
            }
            else MessageBox.Show("Seleccione una fila");


        }

        private void SeguridadBtnEliminar_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.SelectedRows.Count > 0)
            {
                seguridadRoles.Estado = EstadoEntidad.Deleted;
                seguridadRoles.IdRol = Convert.ToInt32(SeguridadDgvListaRoles.CurrentRow.Cells[0].Value);

                string resultado = seguridadRoles.GrabarCambios();
                MessageBox.Show(resultado);
                ListaRoles();
                Reinicio();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void SeguridadBtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                seguridadRoles.NombreRol = SeguridadTxtNombreRol.Text;
                seguridadRoles.DescripcionRol = SeguridadTxtDescripcionRol.Text;
                seguridadRoles.IsActive = SeguridadChkActivo.Checked;
                seguridadRoles.Estado = EstadoEntidad.Added;

                bool valido = new Ayudas.ValidacionDatos(seguridadRoles).Validar();
                if (valido == true)
                {
                    string resultado = seguridadRoles.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaRoles();
                    Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
