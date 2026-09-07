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
        public FrmMantenimientoPerfiles()
        {
            InitializeComponent();
        }



        private void FrmMantenimientoPerfiles_Load(object sender, System.EventArgs e)
        {

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
    }
}
