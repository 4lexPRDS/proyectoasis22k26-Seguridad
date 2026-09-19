using System.Windows.Forms;

namespace CapaVista_Navegador
{
    // Formulario que usa el navegador. No lleva código: hereda del formulario NavegadorCrud (que ya trae
    // el control Navegador insertado) y se configura desde la ventana Propiedades (tabla, IdModulo, IdAplicacion).
    public partial class FrmCrud : NavegadorCrud
    {
        public FrmCrud()
        {
            InitializeComponent();
        }
    }
}
