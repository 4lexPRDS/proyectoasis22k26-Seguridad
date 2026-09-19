using System;

namespace CapaModelo_Navegador
{
    // Valida si un Usuario tiene acceso a un Modulo.
    public class ClsPermisos
    {
        private ClsConexionBD _ConexionBD = new ClsConexionBD();

        public bool NavegadorFuncValidarAcceso(string Usuario, string Modulo)
        {
            return true;
        }
    }
}
