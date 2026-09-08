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
    public class ModeloAsigAppPerf
    {
        private int _idRol;
        private int _idModulo;
        private int _idAplicacion;
        private bool _derInsertar;
        private bool _derEditar;
        private bool _derEliminar;
        private bool _derImprimir;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private RepositorioAsigAppPerf RepositorioAsigAppPerf;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloAsigAppPerf> ListaAsigAppPerf;

        [Required(ErrorMessage = "El campo Rol es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Rol válido")]
        public int IdRol { get => _idRol; set => _idRol = value; }

        [Required(ErrorMessage = "El campo Módulo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Módulo válido")]
        public int IdModulo { get => _idModulo; set => _idModulo = value; }

        [Required(ErrorMessage = "El campo Aplicación es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una Aplicación válida")]
        public int IdAplicacion { get => _idAplicacion; set => _idAplicacion = value; }

        public bool DerInsertarRolModuloAplicacion { get => _derInsertar; set => _derInsertar = value; }
        public bool DerEditarRolModuloAplicacion { get => _derEditar; set => _derEditar = value; }
        public bool DerEliminarRolModuloAplicacion { get => _derEliminar; set => _derEliminar = value; }
        public bool DerImprimirRolModuloAplicacion { get => _derImprimir; set => _derImprimir = value; }

        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }
        public DateTime UpdatedAt { get => _updatedAt; private set => _updatedAt = value; }

        public ModeloAsigAppPerf()
        {
            RepositorioAsigAppPerf = new RepositorioAsigAppPerf();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modeloDatosAsigAppPerf = new AsigAppPerf();
                modeloDatosAsigAppPerf.idRol = _idRol;
                modeloDatosAsigAppPerf.idModulo = _idModulo;
                modeloDatosAsigAppPerf.idAplicacion = _idAplicacion;
                modeloDatosAsigAppPerf.derInsertarRolModuloAplicacion = _derInsertar;
                modeloDatosAsigAppPerf.derEditarRolModuloAplicacion = _derEditar;
                modeloDatosAsigAppPerf.derEliminarRolModuloAplicacion = _derEliminar;
                modeloDatosAsigAppPerf.derImprimirRolModuloAplicacion = _derImprimir;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioAsigAppPerf.Agregar(modeloDatosAsigAppPerf);
                        mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioAsigAppPerf.Editar(modeloDatosAsigAppPerf);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioAsigAppPerf.Remover(modeloDatosAsigAppPerf);
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

        public List<ModeloAsigAppPerf> GetAll()
        {
            var modeloDatosAsigAppPerf = RepositorioAsigAppPerf.GetAll();
            ListaAsigAppPerf = new List<ModeloAsigAppPerf>();
            foreach (AsigAppPerf item in modeloDatosAsigAppPerf)
            {
                ListaAsigAppPerf.Add(new ModeloAsigAppPerf
                {
                    _idRol = item.idRol,
                    _idModulo = item.idModulo,
                    _idAplicacion = item.idAplicacion,
                    _derInsertar = item.derInsertarRolModuloAplicacion,
                    _derEditar = item.derEditarRolModuloAplicacion,
                    _derEliminar = item.derEliminarRolModuloAplicacion,
                    _derImprimir = item.derImprimirRolModuloAplicacion,
                    _createdAt = item.createdAt,
                    _updatedAt = item.updatedAt
                });
            }
            return ListaAsigAppPerf;
        }

        public IEnumerable<ModeloAsigAppPerf> FindbyId(int idRol, int idModulo, int idAplicacion)
        {
            return ListaAsigAppPerf.FindAll(e =>
                e._idRol == idRol &&
                e._idModulo == idModulo &&
                e._idAplicacion == idAplicacion);
        }

        public DataTable GetRoles()
        {
            return RepositorioAsigAppPerf.GetRoles();
        }

        public DataTable GetModulos()
        {
            return RepositorioAsigAppPerf.GetModulos();
        }

        public DataTable GetAplicaciones()
        {
            return RepositorioAsigAppPerf.GetAplicaciones();
        }

        public IEnumerable<ModeloAsigAppPerf> FindByRol(int idRol)
        {
            return ListaAsigAppPerf.FindAll(e => e._idRol == idRol);
        }
    }
}