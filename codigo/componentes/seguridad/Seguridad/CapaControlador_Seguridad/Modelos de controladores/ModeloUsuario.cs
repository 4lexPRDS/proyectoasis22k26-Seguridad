using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
namespace CapaControlador_Seguridad
{
    public class ModeloUsuario
    {
        private int _idUsuario;
        private int _idEmpleado;
        private string _usuarioUsuario;
        private string _contrasenaUsuario;
        private DateTime _ultimoAccesoUsuario;
        private IRepositorioUsuarios RepositorioUsuarios;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloUsuario> ListaUsuario;

        public int idUsuario { get => _idUsuario; set => _idUsuario = value; }

        [Required(ErrorMessage = "El campo numero de identificacion es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Numero de identificacion debe ser numerico")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Numero de identificacion debe tener 10 digitos")]
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }

        [Required]
        [RegularExpression("^[a-zA-Zá-ú ]+$", ErrorMessage = "El campo Nombre debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string usuarioUsuario { get => _usuarioUsuario; set => _usuarioUsuario = value; }

        [Required]
        [RegularExpression(@"^\S+$", ErrorMessage = "La contraseña no debe contener espacios")]
        [StringLength(100, MinimumLength = 6)]
        public string contrasenaUsuario { get => _contrasenaUsuario; set => _contrasenaUsuario = value; }



        public DateTime ultimoAccesoUsuario { get => _ultimoAccesoUsuario; set => _ultimoAccesoUsuario = value; }


        public ModeloUsuario()
        {
            RepositorioUsuarios = new RepositorioUsuarios();

        }
        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modeloDatosUsuarios = new Usuarios();
                modeloDatosUsuarios.idUsuario = _idUsuario;
                modeloDatosUsuarios.idEmpleado = _idEmpleado;
                modeloDatosUsuarios.usuarioUsuario = _usuarioUsuario;
                modeloDatosUsuarios.contrasenaUsuario = _contrasenaUsuario;
                modeloDatosUsuarios.ultimoAccesoUsuario = _ultimoAccesoUsuario;
                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioUsuarios.Agregar(modeloDatosUsuarios);
                        mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioUsuarios.Editar(modeloDatosUsuarios);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioUsuarios.Remover(modeloDatosUsuarios);
                        mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }
        public List<ModeloUsuario> GetAll()
        {
            var modeloDatosUsuarios = RepositorioUsuarios.GetAll();
            ListaUsuario = new List<ModeloUsuario>();
            foreach (Usuarios item in modeloDatosUsuarios)
            {
               
                ListaUsuario.Add(new ModeloUsuario
                {
                    _idUsuario = item.idUsuario,
                    _idEmpleado = item.idEmpleado,
                    _usuarioUsuario = item.usuarioUsuario,
                    _ultimoAccesoUsuario = item.ultimoAccesoUsuario
                    
                });
            }
            return ListaUsuario;
        }
        public IEnumerable<ModeloUsuario> FindbyId(string filter)
        {
            return ListaUsuario.FindAll(u => u.idUsuario.Equals(filter) || u._usuarioUsuario.Contains(filter));
        }
        

    }

}

