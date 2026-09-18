using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

namespace CapaControlador_Seguridad
{
    public class ModeloEmpleado
    {
        private int _idEmpleado;
        private string _codigoEmpleado;
        private string _dpiEmpleado;
        private string _nitEmpleado;
        private string _nombresEmpleado;
        private string _apellidosEmpleado;
        private string _puestoEmpleado;
        private string _generoEmpleado;
        private DateTime _fechaNacimientoEmpleado;
        private DateTime _fechaContratacionEmpleado;
        private string _telefonoEmpleado;
        private string _correoEmpleado;
        private bool _isActive;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private RepositorioEmpleado RepositorioEmpleado;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloEmpleado> ListaEmpleado;

        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }

        [Required(ErrorMessage = "El campo Código Empleado es requerido")]
        public string CodigoEmpleado { get => _codigoEmpleado; set => _codigoEmpleado = value; }

        [Required(ErrorMessage = "El campo Dpi es requerido")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "El Dpi debe tener 13 dígitos")]
        public string DpiEmpleado { get => _dpiEmpleado; set => _dpiEmpleado = value; }

        public string NitEmpleado { get => _nitEmpleado; set => _nitEmpleado = value; }

        [Required(ErrorMessage = "El campo Nombres es requerido")]
        public string NombresEmpleado { get => _nombresEmpleado; set => _nombresEmpleado = value; }

        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string ApellidosEmpleado { get => _apellidosEmpleado; set => _apellidosEmpleado = value; }

        [Required(ErrorMessage = "El campo Puesto es requerido")]
        public string PuestoEmpleado { get => _puestoEmpleado; set => _puestoEmpleado = value; }

        [Required(ErrorMessage = "El campo Género es requerido")]
        public string GeneroEmpleado { get => _generoEmpleado; set => _generoEmpleado = value; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es requerido")]
        public DateTime FechaNacimientoEmpleado { get => _fechaNacimientoEmpleado; set => _fechaNacimientoEmpleado = value; }

        [Required(ErrorMessage = "El campo Fecha de Contratación es requerido")]
        public DateTime FechaContratacionEmpleado { get => _fechaContratacionEmpleado; set => _fechaContratacionEmpleado = value; }

        public string TelefonoEmpleado { get => _telefonoEmpleado; set => _telefonoEmpleado = value; }

        public string CorreoEmpleado { get => _correoEmpleado; set => _correoEmpleado = value; }

        public bool IsActive { get => _isActive; set => _isActive = value; }

        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }
        public DateTime UpdatedAt { get => _updatedAt; private set => _updatedAt = value; }

        public ModeloEmpleado()
        {
            RepositorioEmpleado = new RepositorioEmpleado();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modeloDatosEmpleado = new Empleado();
                modeloDatosEmpleado.idEmpleado = _idEmpleado;
                modeloDatosEmpleado.codigoEmpleado = _codigoEmpleado;
                modeloDatosEmpleado.dpiEmpleado = _dpiEmpleado;
                modeloDatosEmpleado.nitEmpleado = _nitEmpleado;
                modeloDatosEmpleado.nombresEmpleado = _nombresEmpleado;
                modeloDatosEmpleado.apellidosEmpleado = _apellidosEmpleado;
                modeloDatosEmpleado.puestoEmpleado = _puestoEmpleado;
                modeloDatosEmpleado.generoEmpleado = _generoEmpleado;
                modeloDatosEmpleado.fechaNacimientoEmpleado = _fechaNacimientoEmpleado;
                modeloDatosEmpleado.fechaContratacionEmpleado = _fechaContratacionEmpleado;
                modeloDatosEmpleado.telefonoEmpleado = _telefonoEmpleado;
                modeloDatosEmpleado.correoEmpleado = _correoEmpleado;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioEmpleado.Agregar(modeloDatosEmpleado);
                        mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioEmpleado.Editar(modeloDatosEmpleado);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioEmpleado.Remover(modeloDatosEmpleado);
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

        public List<ModeloEmpleado> GetAll()
        {
            var modeloDatosEmpleado = RepositorioEmpleado.GetAll();
            ListaEmpleado = new List<ModeloEmpleado>();
            foreach (Empleado item in modeloDatosEmpleado)
            {
                ListaEmpleado.Add(new ModeloEmpleado
                {
                    _idEmpleado = item.idEmpleado,
                    _codigoEmpleado = item.codigoEmpleado,
                    _dpiEmpleado = item.dpiEmpleado,
                    _nitEmpleado = item.nitEmpleado,
                    _nombresEmpleado = item.nombresEmpleado,
                    _apellidosEmpleado = item.apellidosEmpleado,
                    _puestoEmpleado = item.puestoEmpleado,
                    _generoEmpleado = item.generoEmpleado,
                    _fechaNacimientoEmpleado = item.fechaNacimientoEmpleado,
                    _fechaContratacionEmpleado = item.fechaContratacionEmpleado,
                    _telefonoEmpleado = item.telefonoEmpleado,
                    _correoEmpleado = item.correoEmpleado,
                    _isActive = item.isActive,
                    _createdAt = item.createdAt,
                    _updatedAt = item.updatedAt
                });
            }
            return ListaEmpleado;
        }

        public IEnumerable<ModeloEmpleado> FindbyId(int idEmpleado)
        {
            return ListaEmpleado.FindAll(e => e._idEmpleado == idEmpleado);
        }
    }
}