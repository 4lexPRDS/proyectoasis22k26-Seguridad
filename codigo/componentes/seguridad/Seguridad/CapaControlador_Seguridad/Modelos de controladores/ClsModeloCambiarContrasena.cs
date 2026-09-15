using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.ComponentModel.DataAnnotations;

namespace CapaControlador_Seguridad
{
    // Paso 2 de la recuperación de contraseña: valida el código y, si es
    // válido, actualiza la contraseña (hasheada con BCrypt). El token es
    // UNIQUE en la tabla, así que no hace falta pedir el usuario aquí.
    public class ClsModeloCambiarContrasena
    {
        private IRepositorioRecuperacionContrasena _RepositorioRecuperacion;
        private IRepositorioUsuarios _RepositorioUsuarios;

        [Required(ErrorMessage = "Debe ingresar el código recibido por correo")]
        public string CodigoRecuperacion { get; set; }

        // mismas reglas que ContrasenaUsuario en ClsModeloUsuario, para que
        // quede estandarizado con el resto del sistema
        [Required(ErrorMessage = "Debe ingresar la nueva contraseña")]
        [RegularExpression(@"^\S+$", ErrorMessage = "La contraseña no debe contener espacios")]
        [StringLength(100, MinimumLength = 6)]
        public string NuevaContrasena { get; set; }

        [Required(ErrorMessage = "Debe confirmar la nueva contraseña")]
        [Compare("NuevaContrasena", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmarContrasena { get; set; }

        public ClsModeloCambiarContrasena()
        {
            _RepositorioRecuperacion = new ClsRepositorioRecuperacionContrasena();
            _RepositorioUsuarios = new ClsRepositorioUsuarios();
        }

        public string SeguridadMetCambiarContrasena()
        {
            string Mensaje = null;
            try
            {
                var IdUsuario = _RepositorioRecuperacion.SeguridadMetBuscarIdUsuarioPorToken(CodigoRecuperacion);
                if (IdUsuario == null)
                {
                    return "El código es inválido o ya expiró";
                }

                var ContrasenaHasheada = BCrypt.Net.BCrypt.HashPassword(NuevaContrasena);
                _RepositorioUsuarios.SeguridadMetActualizarContrasena(IdUsuario.Value, ContrasenaHasheada);

                // el código ya se usó, que no quede pendiente en la bd
                _RepositorioRecuperacion.SeguridadMetEliminarPorUsuario(IdUsuario.Value);

                Mensaje = "Contrasena actualizada";
            }
            catch (Exception ex)
            {
                Mensaje = ex.ToString();
            }
            return Mensaje;
        }
    }
}
