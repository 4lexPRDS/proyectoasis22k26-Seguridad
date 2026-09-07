//using CapaControlador_Seguridad.Objetos_de_valor.EstadoEntidad;

using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ModeloRoles
    {
        private int _idRol;
        private string _nombreRol;
        private string _descripcionRol;
        private bool _isActive;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private RepositorioRoles RepositorioRoles;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloRoles> ListaRoles;

        // Autoincremental
        public int IdRol { get => _idRol; set => _idRol = value; }

        [Required(ErrorMessage = "El campo Nombre de Rol es requerido")]
        [RegularExpression("^[a-zA-Zá-ú\\s]+$", ErrorMessage = "El campo Nombre debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El campo Nombre debe tener entre 10 y 100 caracteres")]
        public string NombreRol { get => _nombreRol; set => _nombreRol = value; }

        [Required(ErrorMessage = "El campo Descripción de Rol es requerido")]
        [RegularExpression("^[a-zA-Zá-ú\\s]+$", ErrorMessage = "El campo Descripción debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El campo Descripción debe tener entre 10 y 100 caracteres")]
        public string DescripcionRol { get => _descripcionRol; set => _descripcionRol = value; }

        // Se enlaza directamente con SeguridadChkActivo.Checked
        public bool IsActive { get => _isActive; set => _isActive = value; }

        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }
        public DateTime UpdatedAt { get => _updatedAt; private set => _updatedAt = value; }

        public ModeloRoles()
        {
            RepositorioRoles = new RepositorioRoles();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                // Validación manual del idRol
                if (Estado == EstadoEntidad.Modified || Estado == EstadoEntidad.Deleted)
                {
                    if (_idRol <= 0)
                        return "Debe indicar un Rol válido para esta operación";
                }

                var modeloDatosRoles = new Roles();
                modeloDatosRoles.idRol = _idRol;
                modeloDatosRoles.nombreRol = _nombreRol;
                modeloDatosRoles.descripcionRol = _descripcionRol;
                modeloDatosRoles.is_active = _isActive;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioRoles.Agregar(modeloDatosRoles);
                        mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioRoles.Editar(modeloDatosRoles);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioRoles.Remover(modeloDatosRoles);
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

        public List<ModeloRoles> GetAll()
        {
            var modeloDatosRoles = RepositorioRoles.GetAll();
            ListaRoles = new List<ModeloRoles>();
            foreach (Roles item in modeloDatosRoles)
            {
                ListaRoles.Add(new ModeloRoles
                {
                    _idRol = item.idRol,
                    _nombreRol = item.nombreRol,
                    _descripcionRol = item.descripcionRol,
                    _isActive = item.is_active,
                    _createdAt = item.created_at,
                    _updatedAt = item.updated_at
                });
            }
            return ListaRoles;
        }

        public IEnumerable<ModeloRoles> FindbyId(int idRol)
        {
            return ListaRoles.FindAll(e => e._idRol == idRol);
        }

    }
}
