using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaControlador_Seguridad;

namespace CapaVista_Seguridad
{
    public partial class FrmModulo : Form
    {
        private ModeloModulo controladorModulo = new ModeloModulo();
        private BindingSource bindingSource = new BindingSource();
        private bool esCargando = false; // Bandera para evitar eventos al enlazar datos

        public FrmModulo()
        {
            InitializeComponent();
            AplicarEstandarVisual();
            CargarDatos();
            EstadoInicial();
        }

        #region Estándar Visual y Configuración de Barra de Herramientas

        private void AplicarEstandarVisual()
        {
            Color colorFondo = ColorTranslator.FromHtml("#EDC9A1");
            Color colorBotonFondo = ColorTranslator.FromHtml("#83C5BE");
            Color colorBotonBorde = ColorTranslator.FromHtml("#006D77");

            this.BackColor = colorFondo;
            this.pnlBarraHerramientas.BackColor = colorFondo;

            string[] nombresBotones = { "Ingresar", "Modificar", "Guardar", "Cancelar", "Eliminar",
                                "Consultar", "Imprimir", "Refrescar", "Inicio", "Anterior",
                                "Siguiente", "Fin", "Ayuda", "Salir" };

            this.pnlBarraHerramientas.Controls.Clear();

            foreach (string nombre in nombresBotones)
            {
                Button btn = new Button
                {
                    Name = "SeguridadBtn" + nombre,
                    Text = "",
                    Size = new Size(62, 65),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = colorBotonFondo,
                    Cursor = Cursors.Hand,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Margin = new Padding(2)
                };

                btn.FlatAppearance.BorderColor = colorBotonBorde;
                btn.FlatAppearance.BorderSize = 1;

                switch (nombre)
                {
                    case "Ingresar":
                        btn.BackgroundImage = Properties.Resources.btn_ingresarN;
                        btn.Click += BtnIngresar_Click;
                        break;
                    case "Modificar":
                        btn.BackgroundImage = Properties.Resources.btn_modificarN;
                        btn.Click += BtnModificar_Click;
                        break;
                    case "Guardar":
                        btn.BackgroundImage = Properties.Resources.btn_guardarN;
                        btn.Click += BtnGuardar_Click;
                        break;
                    case "Cancelar":
                        btn.BackgroundImage = Properties.Resources.btn_cancelarN;
                        btn.Click += BtnCancelar_Click;
                        break;
                    case "Eliminar":
                        btn.BackgroundImage = Properties.Resources.btn_eliminarN;
                        btn.Click += BtnEliminar_Click;
                        break;
                    case "Consultar":
                    case "Refrescar":
                        btn.BackgroundImage = (nombre == "Consultar") ? Properties.Resources.btn_consultarN : Properties.Resources.btn_refrescarN;
                        btn.Click += (s, e) => { CargarDatos(); EstadoInicial(); };
                        break;
                    case "Imprimir":
                        btn.BackgroundImage = Properties.Resources.btn_imprimirN;
                        btn.Click += (s, e) => MessageBox.Show("Generando reporte de módulos...", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Inicio":
                        btn.BackgroundImage = Properties.Resources.btn_inicioN;
                        btn.Click += (s, e) => bindingSource.MoveFirst();
                        break;
                    case "Anterior":
                        btn.BackgroundImage = Properties.Resources.btn_anteriorN;
                        btn.Click += (s, e) => bindingSource.MovePrevious();
                        break;
                    case "Siguiente":
                        btn.BackgroundImage = Properties.Resources.btn_siguienteN;
                        btn.Click += (s, e) => bindingSource.MoveNext();
                        break;
                    case "Fin":
                        btn.BackgroundImage = Properties.Resources.btn_finN;
                        btn.Click += (s, e) => bindingSource.MoveLast();
                        break;
                    case "Ayuda":
                        btn.BackgroundImage = Properties.Resources.btn_ayudaN;
                        btn.Click += (s, e) => MessageBox.Show("Formulario para mantenimiento de módulos del sistema.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Salir":
                        btn.BackgroundImage = Properties.Resources.btn_salirN;
                        btn.Click += (s, e) => this.Close();
                        break;
                }

                this.pnlBarraHerramientas.Controls.Add(btn);
            }

            // Estilos del DataGridView
            this.SeguridadDgvModulos.BackgroundColor = Color.White;
            this.SeguridadDgvModulos.EnableHeadersVisualStyles = false;
            this.SeguridadDgvModulos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            this.SeguridadDgvModulos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.SeguridadDgvModulos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.SeguridadDgvModulos.CellClick += SeguridadDgvModulos_CellClick;
            this.bindingSource.CurrentChanged += BindingSource_CurrentChanged;
        }

        #endregion

        #region Gestión de Datos y Carga desde Base de Datos

        private void CargarDatos()
        {
            try
            {
                esCargando = true;

                DataTable dtModulos = controladorModulo.ObtenerModulosTabla();
                bindingSource.DataSource = dtModulos;
                SeguridadDgvModulos.DataSource = bindingSource;

                FormatearGrid();
                CargarComboBoxesDesdeBD();

                esCargando = false;
            }
            catch (Exception ex)
            {
                esCargando = false;
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxesDesdeBD()
        {
            try
            {
                // Obtenemos los registros reales de la base de datos
                DataTable dtModulosNombre = controladorModulo.ObtenerModulosTabla();
                DataTable dtModulosDescrip = controladorModulo.ObtenerModulosTabla();

                if (dtModulosNombre != null && dtModulosNombre.Rows.Count > 0)
                {
                    // Llenar ComboBox Nombre Módulo desde BD
                    SeguridadCmbNombreModulo.DataSource = dtModulosNombre;
                    SeguridadCmbNombreModulo.DisplayMember = "nombreModulo";
                    SeguridadCmbNombreModulo.ValueMember = "idModulo";

                    // Llenar ComboBox Descripción Módulo desde BD
                    SeguridadCmbDescripcion.DataSource = dtModulosDescrip;
                    SeguridadCmbDescripcion.DisplayMember = "descripcionModulo";
                    SeguridadCmbDescripcion.ValueMember = "idModulo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los desplegables desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrid()
        {
            if (SeguridadDgvModulos.Columns.Contains("is_active"))
            {
                int colIndex = SeguridadDgvModulos.Columns["is_active"].Index;
                SeguridadDgvModulos.Columns.Remove("is_active");

                DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn
                {
                    Name = "is_active",
                    DataPropertyName = "is_active",
                    HeaderText = "Estado",
                    TrueValue = 1,
                    FalseValue = 0
                };
                SeguridadDgvModulos.Columns.Insert(colIndex, chkCol);
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

        private void CargarRegistroActual()
        {
            if (esCargando) return;

            if (bindingSource.Current is DataRowView row)
            {
                SeguridadCmbIdModulo.Text = row["idModulo"].ToString();
                SeguridadCmbNombreModulo.Text = row["nombreModulo"].ToString();
                SeguridadCmbDescripcion.Text = row["descripcionModulo"].ToString();

                object val = row["is_active"];
                SeguridadChkEstado.Checked = (val != DBNull.Value && (Convert.ToInt32(val) == 1 || Convert.ToBoolean(val)));
            }
            else
            {
                LimpiarCampos();
            }
        }

        #endregion

        #region Control de Estados del Formulario y Botones

        private void CambiarEstadoBoton(string nombreBoton, bool habilitado)
        {
            Control[] controles = this.pnlBarraHerramientas.Controls.Find("SeguridadBtn" + nombreBoton, false);
            if (controles.Length > 0)
            {
                controles[0].Enabled = habilitado;
            }
        }

        private void EstadoInicial()
        {
            SeguridadCmbIdModulo.Enabled = false;
            SeguridadCmbNombreModulo.Enabled = false;
            SeguridadCmbDescripcion.Enabled = false;
            SeguridadChkEstado.Enabled = false;

            SeguridadCmbNombreModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            SeguridadCmbDescripcion.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarRegistroActual();

            CambiarEstadoBoton("Ingresar", true);
            CambiarEstadoBoton("Modificar", true);
            CambiarEstadoBoton("Eliminar", true);
            CambiarEstadoBoton("Consultar", true);
            CambiarEstadoBoton("Guardar", false);
            CambiarEstadoBoton("Cancelar", false);
        }

        private void EstadoEdicion()
        {
            SeguridadCmbNombreModulo.Enabled = true;
            SeguridadCmbDescripcion.Enabled = true;
            SeguridadChkEstado.Enabled = true;

            // Permite seleccionar de la lista o ingresar una opción si no existe
            SeguridadCmbNombreModulo.DropDownStyle = ComboBoxStyle.DropDown;
            SeguridadCmbDescripcion.DropDownStyle = ComboBoxStyle.DropDown;

            CambiarEstadoBoton("Ingresar", false);
            CambiarEstadoBoton("Modificar", false);
            CambiarEstadoBoton("Eliminar", false);
            CambiarEstadoBoton("Consultar", false);
            CambiarEstadoBoton("Guardar", true);
            CambiarEstadoBoton("Cancelar", true);
        }

        private void LimpiarCampos()
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
            EstadoEdicion();

            // Cargar los elementos desplegables de la base de datos
            CargarComboBoxesDesdeBD();

            // Limpiar los controles para un nuevo registro (Id Módulo queda vacío para AUTO_INCREMENT)
            LimpiarCampos();

            SeguridadCmbNombreModulo.Focus();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeguridadCmbIdModulo.Text))
            {
                EstadoEdicion();
                SeguridadCmbNombreModulo.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un registro de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            EstadoInicial();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SeguridadCmbNombreModulo.Text) || string.IsNullOrWhiteSpace(SeguridadCmbDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre de Módulo y una Descripción antes de guardar.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controladorModulo.NombreModulo = SeguridadCmbNombreModulo.Text.Trim();
            controladorModulo.DescripcionModulo = SeguridadCmbDescripcion.Text.Trim();
            controladorModulo.Is_active = SeguridadChkEstado.Checked;

            // Si Id Módulo está vacío, es un INSERT nuevo
            if (string.IsNullOrEmpty(SeguridadCmbIdModulo.Text))
            {
                controladorModulo.Estado = EstadoEntidad.Added;
            }
            else
            {
                controladorModulo.IdModulo = Convert.ToInt32(SeguridadCmbIdModulo.Text);
                controladorModulo.Estado = EstadoEntidad.Modified;
            }

            string resultado = controladorModulo.GrabarCambios();
            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDatos();
            EstadoInicial();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeguridadCmbIdModulo.Text))
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este módulo definitivamente?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    controladorModulo.IdModulo = Convert.ToInt32(SeguridadCmbIdModulo.Text);
                    controladorModulo.Estado = EstadoEntidad.Deleted;

                    string resultado = controladorModulo.GrabarCambios();
                    MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatos();
                    EstadoInicial();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un módulo de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CargarRegistroActual();
        }

        private void SeguridadDgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CargarRegistroActual();
            }
        }

        #endregion
    }
}