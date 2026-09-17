using System;
using System.Data;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

namespace CapaControlador_Seguridad
{
    public class ModeloModulo
    {
        private int _idModulo;
        private string _nombreModulo;
        private string _descripcionModulo;
        private bool _is_active;
        private RepositorioModulo repositorioModulo;

        // Propiedad clave para saber si Guardamos, Editamos o Eliminamos
        public EstadoEntidad Estado { private get; set; }

        public int IdModulo { get => _idModulo; set => _idModulo = value; }
        public string NombreModulo { get => _nombreModulo; set => _nombreModulo = value; }
        public string DescripcionModulo { get => _descripcionModulo; set => _descripcionModulo = value; }
        public bool Is_active { get => _is_active; set => _is_active = value; }

        public ModeloModulo()
        {
            repositorioModulo = new RepositorioModulo();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modulo = new Modulo
                {
                    idModulo = _idModulo,
                    nombreModulo = _nombreModulo,
                    descripcionModulo = _descripcionModulo,
                    is_active = _is_active
                };

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        repositorioModulo.Agregar(modulo);
                        mensaje = "Registro guardado exitosamente.";
                        break;
                    case EstadoEntidad.Modified:
                        repositorioModulo.Editar(modulo);
                        mensaje = "Registro actualizado exitosamente.";
                        break;
                    case EstadoEntidad.Deleted:
                        repositorioModulo.Remover(modulo);
                        mensaje = "Registro eliminado exitosamente.";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;
            }
            return mensaje;
        }

        public DataTable ObtenerModulosTabla()
        {
            return repositorioModulo.GetModulosTabla();
        }
    }
}