using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ClsModeloMantenimientoApp
    {
        private int _IdAplicacion;
        private int _IdModulo;
        private string _NombreAplicacion;
        private string _DescripcionAplicacion;
        private bool _IsActive;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioMantenimientoApp _RepositorioMantenimientoApp;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloMantenimientoApp> ListaMantenimientoApp;

        public int IdAplicacion { get => _IdAplicacion; set => _IdAplicacion = value; }

        [Required(ErrorMessage = "El campo Id Modulo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un modulo válido")]
        public int IdModulo { get => _IdModulo; set => _IdModulo = value; }

        [Required(ErrorMessage = "El campo Nombre Aplicación es requerido")]
        public string NombreAplicacion { get => _NombreAplicacion; set => _NombreAplicacion = value; }

        public string DescripcionAplicacion { get => _DescripcionAplicacion; set => _DescripcionAplicacion = value; }

        [Required(ErrorMessage = "El campo Estado es requerido")]

        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }

        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloMantenimientoApp()
        {
            _RepositorioMantenimientoApp = new ClsRepositorioMantenimientoApp();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var DatosAplicacion = new ClsMantenimientoAplicacion();
                DatosAplicacion.idAplicacion = _IdAplicacion;
                DatosAplicacion.idModulo = _IdModulo;
                DatosAplicacion.nombreAplicacion = _NombreAplicacion;
                DatosAplicacion.descripcionAplicacion = _DescripcionAplicacion;
                DatosAplicacion.is_active = _IsActive;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioMantenimientoApp.Agregar(DatosAplicacion);
                        Mensaje = "Grabacion exitosa";
                        break;


                    case EstadoEntidad.Modified:
                        _RepositorioMantenimientoApp.Editar(DatosAplicacion);
                        Mensaje = "Actualizacion exitosa";
                        break;


                    case EstadoEntidad.Deleted:
                        _RepositorioMantenimientoApp.Remover(DatosAplicacion);
                        Mensaje = "Eliminacion exitosa";
                        break;
                    }
                }
                catch  (Exception Ex)
                {
                Mensaje = Ex.ToString();
                }
                return Mensaje;         
            }
        public List<ClsModeloMantenimientoApp> SeguridadMetGetAll()
        {
            var DatosAplicacion = _RepositorioMantenimientoApp.GetAll();
            ListaMantenimientoApp = new List<ClsModeloMantenimientoApp>();
            foreach (ClsMantenimientoAplicacion Item in DatosAplicacion)
            {
                ListaMantenimientoApp.Add(new ClsModeloMantenimientoApp 
                { 
                    _IdAplicacion = Item.idAplicacion,
                    _IdModulo = Item.idModulo,
                    _NombreAplicacion = Item.nombreAplicacion,
                    _DescripcionAplicacion = Item.descripcionAplicacion,
                    _IsActive = Item.is_active,
                    _CreatedAt = Item.created_at,
                    _UpdatedAt = Item.updated_at

                 });
            }
            return ListaMantenimientoApp;
        }
            public ClsModeloMantenimientoApp SeguridadMetFindById(int IdAplicacion)
            {
            return ListaMantenimientoApp.Find(e => e._IdAplicacion == IdAplicacion);
            }

            public DataTable SeguridadMetGetModulos()
            {
                return _RepositorioMantenimientoApp.SeguridadMetGetModulos();
            }

            public DataTable SeguridadMetGetAplicaciones()
            {
                return _RepositorioMantenimientoApp.SeguridadMetGetAplicaciones();
            }
    }

}