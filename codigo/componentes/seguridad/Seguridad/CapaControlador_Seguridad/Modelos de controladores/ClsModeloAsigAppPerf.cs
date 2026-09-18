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
    public class ClsModeloAsigAppPerf
    {
        private int _IdRol;
        private int _IdModulo;
        private int _IdAplicacion;
        private bool _DerInsertar;
        private bool _DerEditar;
        private bool _DerEliminar;
        private bool _DerImprimir;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioAsigAppPerf _RepositorioAsigAppPerf;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloAsigAppPerf> _ListaAsigAppPerf;

        [Required(ErrorMessage = "El campo Rol es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Rol válido")]
        public int IdRol { get => _IdRol; set => _IdRol = value; }

        [Required(ErrorMessage = "El campo Módulo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Módulo válido")]
        public int IdModulo { get => _IdModulo; set => _IdModulo = value; }

        [Required(ErrorMessage = "El campo Aplicación es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una Aplicación válida")]
        public int IdAplicacion { get => _IdAplicacion; set => _IdAplicacion = value; }

        public bool DerInsertarRolModuloAplicacion { get => _DerInsertar; set => _DerInsertar = value; }
        public bool DerEditarRolModuloAplicacion { get => _DerEditar; set => _DerEditar = value; }
        public bool DerEliminarRolModuloAplicacion { get => _DerEliminar; set => _DerEliminar = value; }
        public bool DerImprimirRolModuloAplicacion { get => _DerImprimir; set => _DerImprimir = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloAsigAppPerf()
        {
            _RepositorioAsigAppPerf = new ClsRepositorioAsigAppPerf();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsAsigAppPerf();
                ModeloDatos.IdRol = _IdRol;
                ModeloDatos.IdModulo = _IdModulo;
                ModeloDatos.IdAplicacion = _IdAplicacion;
                ModeloDatos.DerInsertarRolModuloAplicacion = _DerInsertar;
                ModeloDatos.DerEditarRolModuloAplicacion = _DerEditar;
                ModeloDatos.DerEliminarRolModuloAplicacion = _DerEliminar;
                ModeloDatos.DerImprimirRolModuloAplicacion = _DerImprimir;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioAsigAppPerf.SeguridadMetAgregar(ModeloDatos);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioAsigAppPerf.SeguridadMetEditar(ModeloDatos);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioAsigAppPerf.SeguridadMetRemover(ModeloDatos);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception Ex)
            {
                Mensaje = Ex.ToString();
            }
            return Mensaje;
        }

        public List<ClsModeloAsigAppPerf> SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioAsigAppPerf.SeguridadMetObtenerTodos();
            _ListaAsigAppPerf = new List<ClsModeloAsigAppPerf>();
            foreach (ClsAsigAppPerf Item in ResultadoConsulta)
            {
                _ListaAsigAppPerf.Add(new ClsModeloAsigAppPerf
                {
                    _IdRol = Item.IdRol,
                    _IdModulo = Item.IdModulo,
                    _IdAplicacion = Item.IdAplicacion,
                    _DerInsertar = Item.DerInsertarRolModuloAplicacion,
                    _DerEditar = Item.DerEditarRolModuloAplicacion,
                    _DerEliminar = Item.DerEliminarRolModuloAplicacion,
                    _DerImprimir = Item.DerImprimirRolModuloAplicacion,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }
            return _ListaAsigAppPerf;
        }

        public IEnumerable<ClsModeloAsigAppPerf> SeguridadMetBuscarPorId(int IdRol, int IdModulo, int IdAplicacion)
        {
            return _ListaAsigAppPerf.FindAll(e =>
                e._IdRol == IdRol &&
                e._IdModulo == IdModulo &&
                e._IdAplicacion == IdAplicacion);
        }

        public DataTable SeguridadMetObtenerRoles()
        {
            return _RepositorioAsigAppPerf.SeguridadMetObtenerRoles();
        }

        public DataTable SeguridadMetObtenerModulos()
        {
            return _RepositorioAsigAppPerf.SeguridadMetObtenerModulos();
        }

        public DataTable SeguridadMetObtenerAplicaciones()
        {
            return _RepositorioAsigAppPerf.SeguridadMetObtenerAplicaciones();
        }

        public IEnumerable<ClsModeloAsigAppPerf> SeguridadMetBuscarPorRol(int IdRol)
        {
            return _ListaAsigAppPerf.FindAll(e => e._IdRol == IdRol);
        }
    }
}