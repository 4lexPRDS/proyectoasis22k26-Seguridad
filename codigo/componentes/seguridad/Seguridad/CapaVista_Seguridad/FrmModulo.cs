using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaControlador_Seguridad;

namespace CapaVista_Seguridad
{
    public partial class FrmModulo : Form
    {
        private ClsModeloModulo _ControladorModulo = new ClsModeloModulo();
        private BindingSource _BindingSource = new BindingSource();
        private bool _EsCargando = false; // Bandera para evitar eventos al enlazar datos

        public FrmModulo()
        {
            InitializeComponent();
            SeguridadMetAplicarEstandarVisual();
            SeguridadMetCargarDatos();
            SeguridadMetEstadoInicial();
        }

        #region Estándar Visual y Configuración de Barra de Herramientas

        private void SeguridadMetAplicarEstandarVisual()
        {
            Color ColorFondo = ColorTranslator.FromHtml("#EDC9A1");
            Color ColorBotonFondo = ColorTranslator.FromHtml("#83C5BE");
            Color ColorBotonBorde = ColorTranslator.FromHtml("#006D77");

            this.BackColor = ColorFondo;
            this.pnlBarraHerramientas.BackColor = ColorFondo;

            string[] NombresBotones = { "Ingresar", "Modificar", "Guardar", "Cancelar", "Eliminar",
                                "Consultar", "Imprimir", "Refrescar", "Inicio", "Anterior",
                                "Siguiente", "Fin", "Ayuda", "Salir" };

            this.pnlBarraHerramientas.Controls.Clear();

            foreach (string Nombre in NombresBotones)
            {
                Button Btn = new Button
                {
                    Name = "SeguridadBtn" + Nombre,
                    Text = "",
                    Size = new Size(62, 65),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = ColorBotonFondo,
                    Cursor = Cursors.Hand,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Margin = new Padding(2)
                };

                Btn.FlatAppearance.BorderColor = ColorBotonBorde;
                Btn.FlatAppearance.BorderSize = 1;

                switch (Nombre)
                {
                    case "Ingresar":
                        Btn.BackgroundImage = Properties.Resources.btn_ingresarN;
                        Btn.Click += BtnIngresar_Click;
                        break;
                    case "Modificar":
                        Btn.BackgroundImage = Properties.Resources.btn_modificarN;
                        Btn.Click += BtnModificar_Click;
                        break;
                    case "Guardar":
                        Btn.BackgroundImage = Properties.Resources.btn_guardarN;
                        Btn.Click += BtnGuardar_Click;
                        break;
                    case "Cancelar":
                        Btn.BackgroundImage = Properties.Resources.btn_cancelarN;
                        Btn.Click += BtnCancelar_Click;
                        break;
                    case "Eliminar":
                        Btn.BackgroundImage = Properties.Resources.btn_eliminarN;
                        Btn.Click += BtnEliminar_Click;
                        break;
                    case "Consultar":
                    case "Refrescar":
                        Btn.BackgroundImage = (Nombre == "Consultar") ? Properties.Resources.btn_consultarN : Properties.Resources.btn_refrescarN;
                        Btn.Click += (s, e) => { SeguridadMetCargarDatos(); SeguridadMetEstadoInicial(); };
                        break;
                    case "Imprimir":
                        Btn.BackgroundImage = Properties.Resources.btn_imprimirN;
                        Btn.Click += (s, e) => MessageBox.Show("Generando reporte de módulos...", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Inicio":
                        Btn.BackgroundImage = Properties.Resources.btn_inicioN;
                        Btn.Click += (s, e) => _BindingSource.MoveFirst();
                        break;
                    case "Anterior":
                        Btn.BackgroundImage = Properties.Resources.btn_anteriorN;
                        Btn.Click += (s, e) => _BindingSource.MovePrevious();
                        break;
                    case "Siguiente":
                        Btn.BackgroundImage = Properties.Resources.btn_siguienteN;
                        Btn.Click += (s, e) => _BindingSource.MoveNext();
                        break;
                    case "Fin":
                        Btn.BackgroundImage = Properties.Resources.btn_finN;
                        Btn.Click += (s, e) => _BindingSource.MoveLast();
                        break;
                    case "Ayuda":
                        Btn.BackgroundImage = Properties.Resources.btn_ayudaN;
                        Btn.Click += (s, e) => MessageBox.Show("Formulario para mantenimiento de módulos del sistema.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Salir":
                        Btn.BackgroundImage = Properties.Resources.btn_salirN;
                        Btn.Click += (s, e) => this.Close();
                        break;
                }

                this.pnlBarraHerramientas.Controls.Add(Btn);
            }

            // Estilos del DataGridView
            this.SeguridadDgvModulos.BackgroundColor = Color.White;
            this.SeguridadDgvModulos.EnableHeadersVisualStyles = false;
            this.SeguridadDgvModulos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            this.SeguridadDgvModulos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.SeguridadDgvModulos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.SeguridadDgvModulos.CellClick += SeguridadDgvModulos_CellClick;
            _BindingSource.CurrentChanged += BindingSource_CurrentChanged;
        }

        #endregion

        #region Gestión de Datos y Carga desde Base de Datos

        private void SeguridadMetCargarDatos()
        {
            try
            {
                _EsCargando = true;

                DataTable DtModulos = _ControladorModulo.SeguridadMetObtenerModulosTabla();
                _BindingSource.DataSource = DtModulos;
                SeguridadDgvModulos.DataSource = _BindingSource;

                SeguridadMetFormatearGrid();
                SeguridadMetCargarComboBoxesDesdeBD();

                _EsCargando = false;
            }
            catch (Exception ex)
            {
                _EsCargando = false;
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeguridadMetCargarComboBoxesDesdeBD()
        {
            try
            {
                // Obtenemos los registros reales de la base de datos
                DataTable DtModulosNombre = _ControladorModulo.SeguridadMetObtenerModulosTabla();
                DataTable DtModulosDescrip = _ControladorModulo.SeguridadMetObtenerModulosTabla();

                if (DtModulosNombre != null && DtModulosNombre.Rows.Count > 0)
                {
                    // Llenar ComboBox Nombre Módulo desde BD
                    SeguridadCmbNombreModulo.DataSource = DtModulosNombre;
                    SeguridadCmbNombreModulo.DisplayMember = "nombreModulo";
                    SeguridadCmbNombreModulo.ValueMember = "idModulo";

                    // Llenar ComboBox Descripción Módulo desde BD
                    SeguridadCmbDescripcion.DataSource = DtModulosDescrip;
                    SeguridadCmbDescripcion.DisplayMember = "descripcionModulo";
                    SeguridadCmbDescripcion.ValueMember = "idModulo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los desplegables desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeguridadMetFormatearGrid()
        {
            if (SeguridadDgvModulos.Columns.Contains("is_active"))
            {
                int ColIndex = SeguridadDgvModulos.Columns["is_active"].Index;
                SeguridadDgvModulos.Columns.Remove("is_active");

                DataGridViewCheckBoxColumn ChkCol = new DataGridViewCheckBoxColumn
                {
                    Name = "is_active",
                    DataPropertyName = "is_active",
                    HeaderText = "Estado",
                    TrueValue = 1,
                    FalseValue = 0
                };
                SeguridadDgvModulos.Columns.Insert(ColIndex, ChkCol);
            }

            if (SeguridadDgvModulos.Columns.Count > 0)
            {
                if (SeguridadDgvModulos.Columns.Contains("idModulo"))
                    SeguridadDgvModulos.Columns["idModulo"].HeaderText = "Id Módulo";
                if (SeguridadDgvModulos.Columns.Contains("nombreModulo"))
                    SeguridadDgvModulos.Columns["nombreModulo"].HeaderText = "Nombre Módulo";
                if (SeguridadDgvModulos.Columns.Contains("descripcionModulo"))
                    SeguridadDgvModulos.Columns["descripcionModulo"].HeaderText = "Descripción";
            }
        }

        private void SeguridadMetCargarRegistroActual()
        {
            if (_EsCargando) return;

            if (_BindingSource.Current is DataRowView Fila)
            {
                SeguridadCmbIdModulo.Text = Fila["idModulo"].ToString();
                SeguridadCmbNombreModulo.Text = Fila["nombreModulo"].ToString();
                SeguridadCmbDescripcion.Text = Fila["descripcionModulo"].ToString();

                object Val = Fila["is_active"];
                SeguridadChkEstado.Checked = (Val != DBNull.Value && (Convert.ToInt32(Val) == 1 || Convert.ToBoolean(Val)));
            }
            else
            {
                SeguridadMetLimpiarCampos();
            }
        }

        #endregion

        #region Control de Estados del Formulario y Botones

        private void SeguridadMetCambiarEstadoBoton(string NombreBoton, bool Habilitado)
        {
            Control[] Controles = this.pnlBarraHerramientas.Controls.Find("SeguridadBtn" + NombreBoton, false);
            if (Controles.Length > 0)
            {
                Controles[0].Enabled = Habilitado;
            }
        }

        private void SeguridadMetEstadoInicial()
        {
            SeguridadCmbIdModulo.Enabled = false;
            SeguridadCmbNombreModulo.Enabled = false;
            SeguridadCmbDescripcion.Enabled = false;
            SeguridadChkEstado.Enabled = false;

            SeguridadCmbNombreModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            SeguridadCmbDescripcion.DropDownStyle = ComboBoxStyle.DropDownList;

            SeguridadMetCargarRegistroActual();

            SeguridadMetCambiarEstadoBoton("Ingresar", true);
            SeguridadMetCambiarEstadoBoton("Modificar", true);
            SeguridadMetCambiarEstadoBoton("Eliminar", true);
            SeguridadMetCambiarEstadoBoton("Consultar", true);
            SeguridadMetCambiarEstadoBoton("Guardar", false);
            SeguridadMetCambiarEstadoBoton("Cancelar", false);
        }

        private void SeguridadMetEstadoEdicion()
        {
            SeguridadCmbNombreModulo.Enabled = true;
            SeguridadCmbDescripcion.Enabled = true;
            SeguridadChkEstado.Enabled = true;

            // Permite seleccionar de la lista o ingresar una opción si no existe
            SeguridadCmbNombreModulo.DropDownStyle = ComboBoxStyle.DropDown;
            SeguridadCmbDescripcion.DropDownStyle = ComboBoxStyle.DropDown;

            SeguridadMetCambiarEstadoBoton("Ingresar", false);
            SeguridadMetCambiarEstadoBoton("Modificar", false);
            SeguridadMetCambiarEstadoBoton("Eliminar", false);
            SeguridadMetCambiarEstadoBoton("Consultar", false);
            SeguridadMetCambiarEstadoBoton("Guardar", true);
            SeguridadMetCambiarEstadoBoton("Cancelar", true);
        }

        private void SeguridadMetLimpiarCampos()
        {
            SeguridadCmbIdModulo.Text = "";
            SeguridadCmbNombreModulo.SelectedIndex = -1;
            SeguridadCmbDescripcion.SelectedIndex = -1;
            SeguridadCmbNombreModulo.Text = "";
            SeguridadCmbDescripcion.Text = "";
            SeguridadChkEstado.Checked = true;
        }

        #endregion

        #region Eventos y Acciones del Mantenimiento

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            SeguridadMetEstadoEdicion();

            // Cargar los elementos desplegables de la base de datos
            SeguridadMetCargarComboBoxesDesdeBD();

            // Limpiar los controles para un nuevo registro (Id Módulo queda vacío para AUTO_INCREMENT)
            SeguridadMetLimpiarCampos();

            SeguridadCmbNombreModulo.Focus();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeguridadCmbIdModulo.Text))
            {
                SeguridadMetEstadoEdicion();
                SeguridadCmbNombreModulo.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un registro de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            SeguridadMetCargarDatos();
            SeguridadMetEstadoInicial();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SeguridadCmbNombreModulo.Text) || string.IsNullOrWhiteSpace(SeguridadCmbDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre de Módulo y una Descripción antes de guardar.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _ControladorModulo.NombreModulo = SeguridadCmbNombreModulo.Text.Trim();
            _ControladorModulo.DescripcionModulo = SeguridadCmbDescripcion.Text.Trim();
            _ControladorModulo.IsActive = SeguridadChkEstado.Checked;

            // Si Id Módulo está vacío, es un INSERT nuevo
            if (string.IsNullOrEmpty(SeguridadCmbIdModulo.Text))
            {
                _ControladorModulo.Estado = EstadoEntidad.Added;
            }
            else
            {
                _ControladorModulo.IdModulo = Convert.ToInt32(SeguridadCmbIdModulo.Text);
                _ControladorModulo.Estado = EstadoEntidad.Modified;
            }

            string Resultado = _ControladorModulo.SeguridadMetGrabarCambios();
            MessageBox.Show(Resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SeguridadMetCargarDatos();
            SeguridadMetEstadoInicial();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeguridadCmbIdModulo.Text))
            {
                DialogResult Respuesta = MessageBox.Show("¿Está seguro de eliminar este módulo definitivamente?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    _ControladorModulo.IdModulo = Convert.ToInt32(SeguridadCmbIdModulo.Text);
                    _ControladorModulo.Estado = EstadoEntidad.Deleted;

                    string Resultado = _ControladorModulo.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SeguridadMetCargarDatos();
                    SeguridadMetEstadoInicial();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un módulo de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            SeguridadMetCargarRegistroActual();
        }

        private void SeguridadDgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SeguridadMetCargarRegistroActual();
            }
        }

        #endregion
    }
}