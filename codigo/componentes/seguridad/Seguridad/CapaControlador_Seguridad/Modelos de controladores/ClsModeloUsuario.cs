using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Seguridad
{
    public class ClsModeloUsuario
    {
        private int _IdUsuario;
        private int _IdEmpleado;
        private string _UsuarioUsuario;
        private string _ContrasenaUsuario;
        private DateTime _UltimoAccesoUsuario;
        private int _IsActive;
        private ClsRepositorioUsuarios _RepositorioUsuarios;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloUsuario> _ListaUsuario;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }

        [Required(ErrorMessage = "Debe seleccionar un empleado")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un empleado válido")]
        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }

        [Required]
        [RegularExpression("^[a-zA-Zá-ú ]+$", ErrorMessage = "El campo Nombre debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string UsuarioUsuario { get => _UsuarioUsuario; set => _UsuarioUsuario = value; }

        [Required]
        [RegularExpression(@"^\S+$", ErrorMessage = "La contraseña no debe contener espacios")]
        [StringLength(100, MinimumLength = 6)]
        public string ContrasenaUsuario { get => _ContrasenaUsuario; set => _ContrasenaUsuario = value; }

        public DateTime UltimoAccesoUsuario { get => _UltimoAccesoUsuario; set => _UltimoAccesoUsuario = value; }
        public int IsActive { get => _IsActive; set => _IsActive = value; }

        public ClsModeloUsuario()
        {
            _RepositorioUsuarios = new ClsRepositorioUsuarios();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatosUsuarios = new ClsUsuarios();
                ModeloDatosUsuarios.IdUsuario = _IdUsuario;
                ModeloDatosUsuarios.IdEmpleado = _IdEmpleado;
                ModeloDatosUsuarios.UsuarioUsuario = _UsuarioUsuario;
                ModeloDatosUsuarios.ContrasenaUsuario = _ContrasenaUsuario;
                ModeloDatosUsuarios.UltimoAccesoUsuario = _UltimoAccesoUsuario;
                ModeloDatosUsuarios.IsActive = _IsActive;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioUsuarios.SeguridadMetAgregar(ModeloDatosUsuarios);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioUsuarios.SeguridadMetEditar(ModeloDatosUsuarios);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioUsuarios.SeguridadMetRemover(ModeloDatosUsuarios);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.ToString();
            }
            return Mensaje;
        }

        public List<ClsModeloUsuario> SeguridadMetObtenerTodos()
        {
            var ModeloDatosUsuarios = _RepositorioUsuarios.SeguridadMetObtenerTodos();
            _ListaUsuario = new List<ClsModeloUsuario>();
            foreach (ClsUsuarios Item in ModeloDatosUsuarios)
            {
                _ListaUsuario.Add(new ClsModeloUsuario
                {
                    _IdUsuario = Item.IdUsuario,
                    _IdEmpleado = Item.IdEmpleado,
                    _UsuarioUsuario = Item.UsuarioUsuario,
                    _ContrasenaUsuario = Item.ContrasenaUsuario,
                    _UltimoAccesoUsuario = Item.UltimoAccesoUsuario,
                    _IsActive = Item.IsActive
                });
            }
            return _ListaUsuario;
        }

        public IEnumerable<ClsModeloUsuario> SeguridadMetBuscarPorId(string Filtro)
        {
            return _ListaUsuario.FindAll(u => u.IdUsuario.Equals(Filtro) || u._UsuarioUsuario.Contains(Filtro));
        }

        public DataTable SeguridadMetObtenerEmpleados()
        {
            return _RepositorioUsuarios.SeguridadMetObtenerEmpleados();
        }

        public List<ClsEstadoEntidadValor> SeguridadMetObtenerEstados()
        {
            return new List<ClsEstadoEntidadValor>
            {
                new ClsEstadoEntidadValor { Texto = "Activo", Valor = 1 },
                new ClsEstadoEntidadValor { Texto = "Inactivo", Valor = 0 }
            };
        }
    }
}