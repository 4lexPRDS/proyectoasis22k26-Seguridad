using System;
using System.Windows.Forms;
using CapaControlador_Navegador; // <- esta es la unica capa que crudSeguridad debe conocer


//-----------------------------------------------------
// - Hecho por: Natali Sofía Montenegro Portillo 
// - Carne: 0901-23-10017
namespace CapaVista_Navegador
{
    public class ClsCrudSeguridad
    {
        private string _Usuario;
        private string _Modulo;

        // IMPORTANTE: aqui va ctrlPermiso (Controlador), NUNCA "permisos" (Modelo).
        // La Vista no debe conocer clases de CapaModelo_Navegador.
        private ClsCtrlPermiso _Permisos = new ClsCtrlPermiso();

        public ClsCrudSeguridad(string Usuario, string Modulo)
        {
            this._Usuario = Usuario;
            this._Modulo = Modulo;
        }

        public bool NavegadorFuncTieneAcceso()
        {
            if (string.IsNullOrEmpty(_Usuario) || string.IsNullOrEmpty(_Modulo))
            {
                return true;
            }

            try
            {
                return _Permisos.NavegadorFuncValidarAcceso(_Usuario, _Modulo);   //validaciones por try y catch
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    "Error al validar los permisos: " + Excepcion.Message,
                    "Error de seguridad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
        }
    }
}

//--------------------------------------------------