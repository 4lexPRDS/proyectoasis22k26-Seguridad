using System;
using System.ComponentModel;
using System.Windows.Forms;
using CapaVista_Navegador.formularios;

// Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
namespace CapaVista_Navegador
{
    // Formulario base del CRUD. Ya trae insertado el control Navegador (la barra de botones, arrastrado
    // desde la caja de herramientas como cualquier botón) y arma la tabla (grid), el panel de
    // ingreso/modificación, los permisos por rol y la bitácora. El formulario que lo usa hereda de este
    // y solo cambia sus propiedades (NombreTabla, IdModulo, IdAplicacion...) sin escribir código.
    public partial class NavegadorCrud : Form
    {
        private ClsCrudEventos _Eventos;

        private string _NombreTabla = "tblempleado";
        private string _Usuario = "USUARIO_PRUEBA";
        private string _Modulo = "EMPLEADOS";
        private int _IdModulo = 4;
        private int _IdAplicacion = 4;

        public NavegadorCrud()
        {
            InitializeComponent();

            navegador1.NavegadorAccionSolicitada += NavegadorMetEjecutarAccion;
        }

        [Category("Navegador")]
        [Description("Nombre de la tabla sobre la que se hace el CRUD.")]
        public string NombreTabla
        {
            get { return _NombreTabla; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                _NombreTabla = value.Trim();
                navegador1.NavegadorMetCambiarTabla(_NombreTabla);

                if (_Eventos != null)
                {
                    _Eventos.NombreTabla = _NombreTabla;
                    _Eventos.NavegadorMetConsultar();
                }
            }
        }

        [Category("Navegador")]
        [Description("Usuario que usa el navegador.")]
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        [Category("Navegador")]
        [Description("Código del módulo que usa el navegador.")]
        public string Modulo
        {
            get { return _Modulo; }
            set { _Modulo = value; }
        }

        [Category("Navegador")]
        [Description("IdModulo de Seguridad con el que se buscan los permisos. 0 = sin seguridad.")]
        public int IdModulo
        {
            get { return _IdModulo; }
            set { _IdModulo = value; }
        }

        [Category("Navegador")]
        [Description("IdAplicacion de Seguridad con la que se buscan los permisos. 0 = sin seguridad.")]
        public int IdAplicacion
        {
            get { return _IdAplicacion; }
            set { _IdAplicacion = value; }
        }

        // Cuando el formulario se abre en ejecución se arma el CRUD.
        // En el diseñador de Visual Studio no se hace nada (no debe tocar la base de datos).
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (NavegadorFuncEsDiseno())
            {
                return;
            }

            _Eventos = new ClsCrudEventos(this, _NombreTabla, _Usuario, _Modulo);

            navegador1.NavegadorMetConfigurar(_NombreTabla, _Usuario, _Modulo, _IdModulo, _IdAplicacion);

            _Eventos.NavegadorMetCargar();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (_Eventos != null)
            {
                _Eventos.NavegadorMetPosicionar();
            }
        }

        private bool NavegadorFuncEsDiseno()
        {
            return DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        // Lo que hace cada botón del navegador.
        private void NavegadorMetEjecutarAccion(string Accion)
        {
            if (_Eventos == null)
            {
                return;
            }

            switch (Accion)
            {
                case "INGRESAR":
                    _Eventos.NavegadorMetIngresar();
                    break;
                case "CONSULTAR":
                    _Eventos.NavegadorMetConsultar();
                    break;
                case "MODIFICAR":
                    _Eventos.NavegadorMetModificar();
                    break;
                case "ELIMINAR":
                    _Eventos.NavegadorMetEliminar();
                    break;
                case "REFRESCAR":
                    _Eventos.NavegadorMetRefrescar();
                    break;
                case "GUARDAR":
                    _Eventos.NavegadorMetGuardar();
                    break;
                case "CANCELAR":
                    _Eventos.NavegadorMetCancelar();
                    break;
                case "INICIO":
                    _Eventos.NavegadorMetInicio();
                    break;
                case "ANTERIOR":
                    _Eventos.NavegadorMetAnterior();
                    break;
                case "SIGUIENTE":
                    _Eventos.NavegadorMetSiguiente();
                    break;
                case "FIN":
                    _Eventos.NavegadorMetFin();
                    break;
                case "SALIR":
                    Form Padre = FindForm();

                    if (Padre != null)
                    {
                        Padre.Close();
                    }
                    break;
            }
        }
    }
}
// Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998
