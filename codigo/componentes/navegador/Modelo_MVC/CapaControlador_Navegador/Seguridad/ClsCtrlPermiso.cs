using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Navegador;

namespace CapaControlador_Navegador
{
    // Todo lo relacionado a validar el acceso de un Usuario a un Modulo
    public class ClsCtrlPermiso
    {
        private ClsPermisos _Permisos = new ClsPermisos();

        public bool NavegadorFuncValidarAcceso(string Usuario, string Modulo)
        {
            try
            {
                return _Permisos.NavegadorFuncValidarAcceso(Usuario, Modulo);
            }
            catch (Exception Excepcion)
            {
                throw new Exception(
                    "Error al validar los permisos del Usuario '" +
                    Usuario +
                    "' sobre el módulo '" +
                    Modulo +
                    "': " +
                    Excepcion.Message,
                    Excepcion);
            }
        }
    }
}