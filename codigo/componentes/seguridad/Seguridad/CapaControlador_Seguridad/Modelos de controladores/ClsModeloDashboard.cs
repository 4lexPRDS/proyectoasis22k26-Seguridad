using CapaModelo_Seguridad.Repositorios;
/*
 * ==================================================================
 * Área : Seguridad
 * Autor : André De Jesús Gonzalez Camey
 * Fecha : 23/09/2026
 * ==================================================================
 * Propósito :
 * Repositorio de datos encargado de ejecutar las consultas SQL
 * necesarias para obtener el conteo de registros de las tablas
 * principales del módulo de Seguridad: tblUsuario (usuarios
 * activos), tblRol (perfiles activos), tblModulo, tblAplicacion,
 * tblBitacora y tblUsuarioRol (asignaciones). Cada método retorna
 * un entero con el total obtenido directamente desde la base de
 * datos, siguiendo el patrón de herencia de ClsSentencias.
 * ===================================================================
*/
namespace CapaControlador_Seguridad
{
    public class ClsModeloDashboard
    {
        private readonly ClsRepositorioDashboard _Repositorio;

        public ClsModeloDashboard()
        {
            _Repositorio = new ClsRepositorioDashboard();
        }

        public int SeguridadMetUsuarios() => _Repositorio.SeguridadMetContarUsuarios();
        public int SeguridadMetAplicaciones() => _Repositorio.SeguridadMetContarAplicaciones();
        public int SeguridadMetPerfiles() => _Repositorio.SeguridadMetContarPerfiles();
        public int SeguridadMetModulos() => _Repositorio.SeguridadMetContarModulos();
        public int SeguridadMetBitacora() => _Repositorio.SeguridadMetContarBitacora();
        public int SeguridadMetAsignaciones() => _Repositorio.SeguridadMetContarAsignaciones();
    }
}
