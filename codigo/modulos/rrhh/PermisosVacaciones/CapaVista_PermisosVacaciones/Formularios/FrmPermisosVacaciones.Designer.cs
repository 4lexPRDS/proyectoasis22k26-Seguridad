/*
 * ==================================================================
 * Área : Recursos Humanos
 * Autor : Daniella Jurado
 * Carné : 0901-23-3679
 * Fecha : 12/10/2026
 * ==================================================================
 * Propósito :
 *  Diseño (Designer) de la ventana 9802 - PermisosVacaciones.
 *  Prototipo NO funcional: solo controles visuales, sin datos de
 *  ejemplo, eventos, validaciones ni acceso a datos.
 * ===================================================================
*/

namespace CapaVista_PermisosVacaciones.Formularios
{
    partial class FrmPermisosVacaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermisosVacaciones));
            this.RrhhBtnPestañaPermisos = new System.Windows.Forms.Button();
            this.RrhhBtnPestañaVacaciones = new System.Windows.Forms.Button();
            this.RrhhPnlLineaPestañas = new System.Windows.Forms.Panel();
            this.RrhhTabPermisosVacaciones = new System.Windows.Forms.TabControl();
            this.RrhhTabPagPermisos = new System.Windows.Forms.TabPage();
            this.RrhhPnlDetallePermiso = new System.Windows.Forms.Panel();
            this.RrhhLblTituloDetallePermiso = new System.Windows.Forms.Label();
            this.RrhhGbxDatosPermiso = new System.Windows.Forms.GroupBox();
            this.RrhhLblPermisoEmpleado = new System.Windows.Forms.Label();
            this.RrhhLblAsteriscoPermisoEmpleado = new System.Windows.Forms.Label();
            this.RrhhCboPermisoEmpleado = new System.Windows.Forms.ComboBox();
            this.RrhhLblPermisoDepartamento = new System.Windows.Forms.Label();
            this.RrhhTxtPermisoDepartamento = new System.Windows.Forms.TextBox();
            this.RrhhLblPermisoPuesto = new System.Windows.Forms.Label();
            this.RrhhTxtPermisoPuesto = new System.Windows.Forms.TextBox();
            this.RrhhLblPermisoTipo = new System.Windows.Forms.Label();
            this.RrhhLblAsteriscoPermisoTipo = new System.Windows.Forms.Label();
            this.RrhhCboPermisoTipo = new System.Windows.Forms.ComboBox();
            this.RrhhLblPermisoEstado = new System.Windows.Forms.Label();
            this.RrhhCboPermisoEstado = new System.Windows.Forms.ComboBox();
            this.RrhhLblNotaDatosPermiso = new System.Windows.Forms.Label();
            this.RrhhGbxPeriodoPermiso = new System.Windows.Forms.GroupBox();
            this.RrhhLblPermisoFechaInicio = new System.Windows.Forms.Label();
            this.RrhhLblAsteriscoPermisoFechaInicio = new System.Windows.Forms.Label();
            this.RrhhDtpPermisoFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.RrhhLblPermisoFechaFin = new System.Windows.Forms.Label();
            this.RrhhLblAsteriscoPermisoFechaFin = new System.Windows.Forms.Label();
            this.RrhhDtpPermisoFechaFin = new System.Windows.Forms.DateTimePicker();
            this.RrhhLblPermisoCalcularEn = new System.Windows.Forms.Label();
            this.RrhhRdbPermisoDias = new System.Windows.Forms.RadioButton();
            this.RrhhRdbPermisoHoras = new System.Windows.Forms.RadioButton();
            this.RrhhLblPermisoHorario = new System.Windows.Forms.Label();
            this.RrhhDtpPermisoHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.RrhhDtpPermisoHoraFin = new System.Windows.Forms.DateTimePicker();
            this.RrhhPnlTotalPermiso = new System.Windows.Forms.Panel();
            this.RrhhLblTotalPermisoTexto = new System.Windows.Forms.Label();
            this.RrhhLblNotaTotalPermiso = new System.Windows.Forms.Label();
            this.RrhhLblTotalPermisoValor = new System.Windows.Forms.Label();
            this.RrhhGbxMotivoPermiso = new System.Windows.Forms.GroupBox();
            this.RrhhLblPermisoMotivo = new System.Windows.Forms.Label();
            this.RrhhLblAsteriscoPermisoMotivo = new System.Windows.Forms.Label();
            this.RrhhTxtPermisoMotivo = new System.Windows.Forms.TextBox();
            this.RrhhLblContadorMotivo = new System.Windows.Forms.Label();
            this.RrhhPnlRegistrosPermiso = new System.Windows.Forms.Panel();
            this.RrhhLblTituloRegistrosPermiso = new System.Windows.Forms.Label();
            this.RrhhLblFiltroPermisoEmpleado = new System.Windows.Forms.Label();
            this.RrhhTxtFiltroPermisoEmpleado = new System.Windows.Forms.TextBox();
            this.RrhhLblFiltroPermisoTipo = new System.Windows.Forms.Label();
            this.RrhhCboFiltroPermisoTipo = new System.Windows.Forms.ComboBox();
            this.RrhhLblFiltroPermisoEstado = new System.Windows.Forms.Label();
            this.RrhhCboFiltroPermisoEstado = new System.Windows.Forms.ComboBox();
            this.RrhhBtnFiltrarPermiso = new System.Windows.Forms.Button();
            this.RrhhDgvPermisos = new System.Windows.Forms.DataGridView();
            this.RrhhColPermisoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColPermisoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhTabPagVacaciones = new System.Windows.Forms.TabPage();
            this.RrhhPnlDetalleVacacion = new System.Windows.Forms.Panel();
            this.RrhhLblTituloDetalleVacacion = new System.Windows.Forms.Label();
            this.RrhhGbxDatosColaborador = new System.Windows.Forms.GroupBox();
            this.RrhhLblVacacionEmpleado = new System.Windows.Forms.Label();
            this.RrhhLblAsteriscoVacacionEmpleado = new System.Windows.Forms.Label();
            this.RrhhCboVacacionEmpleado = new System.Windows.Forms.ComboBox();
            this.RrhhLblVacacionDepartamento = new System.Windows.Forms.Label();
            this.RrhhTxtVacacionDepartamento = new System.Windows.Forms.TextBox();
            this.RrhhLblVacacionPuesto = new System.Windows.Forms.Label();
            this.RrhhTxtVacacionPuesto = new System.Windows.Forms.TextBox();
            this.RrhhLblVacacionFechaContratacion = new System.Windows.Forms.Label();
            this.RrhhTxtVacacionFechaContratacion = new System.Windows.Forms.TextBox();
            this.RrhhLblVacacionTiempoLaborado = new System.Windows.Forms.Label();
            this.RrhhTxtVacacionTiempoLaborado = new System.Windows.Forms.TextBox();
            this.RrhhLblNotaDatosColaborador = new System.Windows.Forms.Label();
            this.RrhhGbxDerechoVacaciones = new System.Windows.Forms.GroupBox();
            this.RrhhLblIndicadorDerecho = new System.Windows.Forms.Label();
            this.RrhhLblLeyendaDerecho = new System.Windows.Forms.Label();
            this.RrhhPnlDiasPeriodo = new System.Windows.Forms.Panel();
            this.RrhhLblDiasPeriodoValor = new System.Windows.Forms.Label();
            this.RrhhLblDiasPeriodoTexto = new System.Windows.Forms.Label();
            this.RrhhPnlDiasTomados = new System.Windows.Forms.Panel();
            this.RrhhLblDiasTomadosValor = new System.Windows.Forms.Label();
            this.RrhhLblDiasTomadosTexto = new System.Windows.Forms.Label();
            this.RrhhPnlDiasDisponibles = new System.Windows.Forms.Panel();
            this.RrhhLblDiasDisponiblesValor = new System.Windows.Forms.Label();
            this.RrhhLblDiasDisponiblesTexto = new System.Windows.Forms.Label();
            this.RrhhLblUsoPeriodo = new System.Windows.Forms.Label();
            this.RrhhLblUsoPeriodoValor = new System.Windows.Forms.Label();
            this.RrhhPnlUsoPista = new System.Windows.Forms.Panel();
            this.RrhhPnlUsoRelleno = new System.Windows.Forms.Panel();
            this.RrhhLblNotaUsoPeriodo = new System.Windows.Forms.Label();
            this.RrhhGbxSolicitudVacaciones = new System.Windows.Forms.GroupBox();
            this.RrhhLblVacacionFechaInicio = new System.Windows.Forms.Label();
            this.RrhhLblAsteriscoVacacionFechaInicio = new System.Windows.Forms.Label();
            this.RrhhDtpVacacionFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.RrhhLblVacacionFechaFin = new System.Windows.Forms.Label();
            this.RrhhLblAsteriscoVacacionFechaFin = new System.Windows.Forms.Label();
            this.RrhhDtpVacacionFechaFin = new System.Windows.Forms.DateTimePicker();
            this.RrhhLblVacacionDiasTomar = new System.Windows.Forms.Label();
            this.RrhhTxtVacacionDiasTomar = new System.Windows.Forms.TextBox();
            this.RrhhLblVacacionEstado = new System.Windows.Forms.Label();
            this.RrhhCboVacacionEstado = new System.Windows.Forms.ComboBox();
            this.RrhhLblVacacionObservacion = new System.Windows.Forms.Label();
            this.RrhhTxtVacacionObservacion = new System.Windows.Forms.TextBox();
            this.RrhhLblRegistroBloqueado = new System.Windows.Forms.Label();
            this.RrhhPnlRegistrosVacacion = new System.Windows.Forms.Panel();
            this.RrhhLblTituloRegistrosVacacion = new System.Windows.Forms.Label();
            this.RrhhLblFiltroVacacionPeriodo = new System.Windows.Forms.Label();
            this.RrhhCboFiltroVacacionPeriodo = new System.Windows.Forms.ComboBox();
            this.RrhhLblFiltroVacacionEstado = new System.Windows.Forms.Label();
            this.RrhhCboFiltroVacacionEstado = new System.Windows.Forms.ComboBox();
            this.RrhhBtnFiltrarVacacion = new System.Windows.Forms.Button();
            this.RrhhDgvVacaciones = new System.Windows.Forms.DataGridView();
            this.RrhhColVacacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionDiasTomados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionDiasRestantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhColVacacionEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RrhhLblMostrandoVacacion = new System.Windows.Forms.Label();
            this.RrhhBtnPaginaPrimeraVacacion = new System.Windows.Forms.Button();
            this.RrhhBtnPaginaAnteriorVacacion = new System.Windows.Forms.Button();
            this.RrhhLblPaginaVacacion = new System.Windows.Forms.Label();
            this.RrhhBtnPaginaSiguienteVacacion = new System.Windows.Forms.Button();
            this.RrhhBtnPaginaUltimaVacacion = new System.Windows.Forms.Button();
            this.RrhhPnlEncabezado = new System.Windows.Forms.Panel();
            this.RrhhLblSubTituloPermisosVacaciones = new System.Windows.Forms.Label();
            this.RrhhLblTituloPermisosVacaciones = new System.Windows.Forms.Label();
            this.RrhhPbIconoPermisosVacaciones = new System.Windows.Forms.PictureBox();
            this.RrhhPbMascota = new System.Windows.Forms.PictureBox();
            this.RrhhBtnNuevo = new System.Windows.Forms.Button();
            this.RrhhBtnGuardar = new System.Windows.Forms.Button();
            this.RrhhBtnModificar = new System.Windows.Forms.Button();
            this.RrhhBtnEliminar = new System.Windows.Forms.Button();
            this.RrhhBtnCancelar = new System.Windows.Forms.Button();
            this.RrhhBtnRefrescar = new System.Windows.Forms.Button();
            this.RrhhBtnImprimir = new System.Windows.Forms.Button();
            this.RrhhBtnInicio = new System.Windows.Forms.Button();
            this.RrhhBtnAnterior = new System.Windows.Forms.Button();
            this.RrhhBtnSiguiente = new System.Windows.Forms.Button();
            this.RrhhBtnFin = new System.Windows.Forms.Button();
            this.RrhhBtnConsultar = new System.Windows.Forms.Button();
            this.RrhhBtnAyuda = new System.Windows.Forms.Button();
            this.RrhhBtnSalir = new System.Windows.Forms.Button();
            this.RrhhTabPermisosVacaciones.SuspendLayout();
            this.RrhhTabPagPermisos.SuspendLayout();
            this.RrhhPnlDetallePermiso.SuspendLayout();
            this.RrhhGbxDatosPermiso.SuspendLayout();
            this.RrhhGbxPeriodoPermiso.SuspendLayout();
            this.RrhhPnlTotalPermiso.SuspendLayout();
            this.RrhhGbxMotivoPermiso.SuspendLayout();
            this.RrhhPnlRegistrosPermiso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RrhhDgvPermisos)).BeginInit();
            this.RrhhTabPagVacaciones.SuspendLayout();
            this.RrhhPnlDetalleVacacion.SuspendLayout();
            this.RrhhGbxDatosColaborador.SuspendLayout();
            this.RrhhGbxDerechoVacaciones.SuspendLayout();
            this.RrhhPnlDiasPeriodo.SuspendLayout();
            this.RrhhPnlDiasTomados.SuspendLayout();
            this.RrhhPnlDiasDisponibles.SuspendLayout();
            this.RrhhPnlUsoPista.SuspendLayout();
            this.RrhhGbxSolicitudVacaciones.SuspendLayout();
            this.RrhhPnlRegistrosVacacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RrhhDgvVacaciones)).BeginInit();
            this.RrhhPnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RrhhPbIconoPermisosVacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RrhhPbMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // RrhhBtnPestañaPermisos
            // 
            this.RrhhBtnPestañaPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhBtnPestañaPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnPestañaPermisos.FlatAppearance.BorderSize = 0;
            this.RrhhBtnPestañaPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnPestañaPermisos.Font = new System.Drawing.Font("Tahoma", 6.62F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnPestañaPermisos.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnPestañaPermisos.Location = new System.Drawing.Point(20, 257);
            this.RrhhBtnPestañaPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnPestañaPermisos.Name = "RrhhBtnPestañaPermisos";
            this.RrhhBtnPestañaPermisos.Size = new System.Drawing.Size(196, 32);
            this.RrhhBtnPestañaPermisos.TabIndex = 15;
            this.RrhhBtnPestañaPermisos.Text = "Permisos";
            this.RrhhBtnPestañaPermisos.UseVisualStyleBackColor = false;
            this.RrhhBtnPestañaPermisos.Click += new System.EventHandler(this.RrhhBtnPestañaPermisos_Click);
            // 
            // RrhhBtnPestañaVacaciones
            // 
            this.RrhhBtnPestañaVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.RrhhBtnPestañaVacaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnPestañaVacaciones.FlatAppearance.BorderSize = 0;
            this.RrhhBtnPestañaVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnPestañaVacaciones.Font = new System.Drawing.Font("Tahoma", 6.62F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnPestañaVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.RrhhBtnPestañaVacaciones.Location = new System.Drawing.Point(220, 259);
            this.RrhhBtnPestañaVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnPestañaVacaciones.Name = "RrhhBtnPestañaVacaciones";
            this.RrhhBtnPestañaVacaciones.Size = new System.Drawing.Size(196, 30);
            this.RrhhBtnPestañaVacaciones.TabIndex = 16;
            this.RrhhBtnPestañaVacaciones.Text = "Vacaciones";
            this.RrhhBtnPestañaVacaciones.UseVisualStyleBackColor = false;
            this.RrhhBtnPestañaVacaciones.Click += new System.EventHandler(this.RrhhBtnPestañaVacaciones_Click);
            // 
            // RrhhPnlLineaPestañas
            // 
            this.RrhhPnlLineaPestañas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhPnlLineaPestañas.Location = new System.Drawing.Point(20, 289);
            this.RrhhPnlLineaPestañas.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlLineaPestañas.Name = "RrhhPnlLineaPestañas";
            this.RrhhPnlLineaPestañas.Size = new System.Drawing.Size(1484, 3);
            this.RrhhPnlLineaPestañas.TabIndex = 17;
            // 
            // RrhhTabPermisosVacaciones
            // 
            this.RrhhTabPermisosVacaciones.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.RrhhTabPermisosVacaciones.Controls.Add(this.RrhhTabPagPermisos);
            this.RrhhTabPermisosVacaciones.Controls.Add(this.RrhhTabPagVacaciones);
            this.RrhhTabPermisosVacaciones.ItemSize = new System.Drawing.Size(0, 1);
            this.RrhhTabPermisosVacaciones.Location = new System.Drawing.Point(16, 290);
            this.RrhhTabPermisosVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTabPermisosVacaciones.Name = "RrhhTabPermisosVacaciones";
            this.RrhhTabPermisosVacaciones.SelectedIndex = 0;
            this.RrhhTabPermisosVacaciones.Size = new System.Drawing.Size(1484, 663);
            this.RrhhTabPermisosVacaciones.TabIndex = 18;
            // 
            // RrhhTabPagPermisos
            // 
            this.RrhhTabPagPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhTabPagPermisos.Controls.Add(this.RrhhPnlDetallePermiso);
            this.RrhhTabPagPermisos.Controls.Add(this.RrhhPnlRegistrosPermiso);
            this.RrhhTabPagPermisos.Location = new System.Drawing.Point(4, 5);
            this.RrhhTabPagPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTabPagPermisos.Name = "RrhhTabPagPermisos";
            this.RrhhTabPagPermisos.Size = new System.Drawing.Size(1476, 654);
            this.RrhhTabPagPermisos.TabIndex = 0;
            this.RrhhTabPagPermisos.Text = "Permisos";
            // 
            // RrhhPnlDetallePermiso
            // 
            this.RrhhPnlDetallePermiso.BackColor = System.Drawing.Color.White;
            this.RrhhPnlDetallePermiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhPnlDetallePermiso.Controls.Add(this.RrhhLblTituloDetallePermiso);
            this.RrhhPnlDetallePermiso.Controls.Add(this.RrhhGbxDatosPermiso);
            this.RrhhPnlDetallePermiso.Controls.Add(this.RrhhGbxPeriodoPermiso);
            this.RrhhPnlDetallePermiso.Controls.Add(this.RrhhGbxMotivoPermiso);
            this.RrhhPnlDetallePermiso.Location = new System.Drawing.Point(4, -4);
            this.RrhhPnlDetallePermiso.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlDetallePermiso.Name = "RrhhPnlDetallePermiso";
            this.RrhhPnlDetallePermiso.Size = new System.Drawing.Size(1460, 358);
            this.RrhhPnlDetallePermiso.TabIndex = 0;
            // 
            // RrhhLblTituloDetallePermiso
            // 
            this.RrhhLblTituloDetallePermiso.AutoSize = true;
            this.RrhhLblTituloDetallePermiso.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblTituloDetallePermiso.Font = new System.Drawing.Font("Lucida Bright", 8.82F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblTituloDetallePermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblTituloDetallePermiso.Location = new System.Drawing.Point(14, 10);
            this.RrhhLblTituloDetallePermiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblTituloDetallePermiso.Name = "RrhhLblTituloDetallePermiso";
            this.RrhhLblTituloDetallePermiso.Size = new System.Drawing.Size(187, 20);
            this.RrhhLblTituloDetallePermiso.TabIndex = 0;
            this.RrhhLblTituloDetallePermiso.Text = "Detalle del permiso";
            // 
            // RrhhGbxDatosPermiso
            // 
            this.RrhhGbxDatosPermiso.BackColor = System.Drawing.Color.White;
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhLblPermisoEmpleado);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhLblAsteriscoPermisoEmpleado);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhCboPermisoEmpleado);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhLblPermisoDepartamento);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhTxtPermisoDepartamento);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhLblPermisoPuesto);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhTxtPermisoPuesto);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhLblPermisoTipo);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhLblAsteriscoPermisoTipo);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhCboPermisoTipo);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhLblPermisoEstado);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhCboPermisoEstado);
            this.RrhhGbxDatosPermiso.Controls.Add(this.RrhhLblNotaDatosPermiso);
            this.RrhhGbxDatosPermiso.Font = new System.Drawing.Font("Tahoma", 6.81F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhGbxDatosPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.RrhhGbxDatosPermiso.Location = new System.Drawing.Point(14, 44);
            this.RrhhGbxDatosPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhGbxDatosPermiso.Name = "RrhhGbxDatosPermiso";
            this.RrhhGbxDatosPermiso.Padding = new System.Windows.Forms.Padding(4);
            this.RrhhGbxDatosPermiso.Size = new System.Drawing.Size(470, 303);
            this.RrhhGbxDatosPermiso.TabIndex = 1;
            this.RrhhGbxDatosPermiso.TabStop = false;
            this.RrhhGbxDatosPermiso.Text = "Datos del permiso";
            // 
            // RrhhLblPermisoEmpleado
            // 
            this.RrhhLblPermisoEmpleado.AutoSize = true;
            this.RrhhLblPermisoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoEmpleado.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoEmpleado.Location = new System.Drawing.Point(15, 38);
            this.RrhhLblPermisoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoEmpleado.Name = "RrhhLblPermisoEmpleado";
            this.RrhhLblPermisoEmpleado.Size = new System.Drawing.Size(68, 16);
            this.RrhhLblPermisoEmpleado.TabIndex = 0;
            this.RrhhLblPermisoEmpleado.Text = "Empleado:";
            // 
            // RrhhLblAsteriscoPermisoEmpleado
            // 
            this.RrhhLblAsteriscoPermisoEmpleado.AutoSize = true;
            this.RrhhLblAsteriscoPermisoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblAsteriscoPermisoEmpleado.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblAsteriscoPermisoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblAsteriscoPermisoEmpleado.Location = new System.Drawing.Point(148, 38);
            this.RrhhLblAsteriscoPermisoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblAsteriscoPermisoEmpleado.Name = "RrhhLblAsteriscoPermisoEmpleado";
            this.RrhhLblAsteriscoPermisoEmpleado.Size = new System.Drawing.Size(17, 17);
            this.RrhhLblAsteriscoPermisoEmpleado.TabIndex = 1;
            this.RrhhLblAsteriscoPermisoEmpleado.Text = "*";
            // 
            // RrhhCboPermisoEmpleado
            // 
            this.RrhhCboPermisoEmpleado.BackColor = System.Drawing.Color.White;
            this.RrhhCboPermisoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboPermisoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboPermisoEmpleado.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboPermisoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboPermisoEmpleado.FormattingEnabled = true;
            this.RrhhCboPermisoEmpleado.Location = new System.Drawing.Point(168, 34);
            this.RrhhCboPermisoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboPermisoEmpleado.Name = "RrhhCboPermisoEmpleado";
            this.RrhhCboPermisoEmpleado.Size = new System.Drawing.Size(284, 25);
            this.RrhhCboPermisoEmpleado.TabIndex = 2;
            // 
            // RrhhLblPermisoDepartamento
            // 
            this.RrhhLblPermisoDepartamento.AutoSize = true;
            this.RrhhLblPermisoDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoDepartamento.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoDepartamento.Location = new System.Drawing.Point(15, 81);
            this.RrhhLblPermisoDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoDepartamento.Name = "RrhhLblPermisoDepartamento";
            this.RrhhLblPermisoDepartamento.Size = new System.Drawing.Size(93, 16);
            this.RrhhLblPermisoDepartamento.TabIndex = 3;
            this.RrhhLblPermisoDepartamento.Text = "Departamento:";
            // 
            // RrhhTxtPermisoDepartamento
            // 
            this.RrhhTxtPermisoDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RrhhTxtPermisoDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtPermisoDepartamento.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtPermisoDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtPermisoDepartamento.Location = new System.Drawing.Point(168, 78);
            this.RrhhTxtPermisoDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtPermisoDepartamento.Name = "RrhhTxtPermisoDepartamento";
            this.RrhhTxtPermisoDepartamento.ReadOnly = true;
            this.RrhhTxtPermisoDepartamento.Size = new System.Drawing.Size(286, 24);
            this.RrhhTxtPermisoDepartamento.TabIndex = 4;
            this.RrhhTxtPermisoDepartamento.TabStop = false;
            // 
            // RrhhLblPermisoPuesto
            // 
            this.RrhhLblPermisoPuesto.AutoSize = true;
            this.RrhhLblPermisoPuesto.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoPuesto.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoPuesto.Location = new System.Drawing.Point(15, 124);
            this.RrhhLblPermisoPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoPuesto.Name = "RrhhLblPermisoPuesto";
            this.RrhhLblPermisoPuesto.Size = new System.Drawing.Size(50, 16);
            this.RrhhLblPermisoPuesto.TabIndex = 5;
            this.RrhhLblPermisoPuesto.Text = "Puesto:";
            // 
            // RrhhTxtPermisoPuesto
            // 
            this.RrhhTxtPermisoPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RrhhTxtPermisoPuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtPermisoPuesto.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtPermisoPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtPermisoPuesto.Location = new System.Drawing.Point(168, 122);
            this.RrhhTxtPermisoPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtPermisoPuesto.Name = "RrhhTxtPermisoPuesto";
            this.RrhhTxtPermisoPuesto.ReadOnly = true;
            this.RrhhTxtPermisoPuesto.Size = new System.Drawing.Size(286, 24);
            this.RrhhTxtPermisoPuesto.TabIndex = 6;
            this.RrhhTxtPermisoPuesto.TabStop = false;
            // 
            // RrhhLblPermisoTipo
            // 
            this.RrhhLblPermisoTipo.AutoSize = true;
            this.RrhhLblPermisoTipo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoTipo.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoTipo.Location = new System.Drawing.Point(15, 168);
            this.RrhhLblPermisoTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoTipo.Name = "RrhhLblPermisoTipo";
            this.RrhhLblPermisoTipo.Size = new System.Drawing.Size(105, 16);
            this.RrhhLblPermisoTipo.TabIndex = 7;
            this.RrhhLblPermisoTipo.Text = "Tipo de permiso:";
            // 
            // RrhhLblAsteriscoPermisoTipo
            // 
            this.RrhhLblAsteriscoPermisoTipo.AutoSize = true;
            this.RrhhLblAsteriscoPermisoTipo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblAsteriscoPermisoTipo.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblAsteriscoPermisoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblAsteriscoPermisoTipo.Location = new System.Drawing.Point(148, 168);
            this.RrhhLblAsteriscoPermisoTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblAsteriscoPermisoTipo.Name = "RrhhLblAsteriscoPermisoTipo";
            this.RrhhLblAsteriscoPermisoTipo.Size = new System.Drawing.Size(17, 17);
            this.RrhhLblAsteriscoPermisoTipo.TabIndex = 8;
            this.RrhhLblAsteriscoPermisoTipo.Text = "*";
            // 
            // RrhhCboPermisoTipo
            // 
            this.RrhhCboPermisoTipo.BackColor = System.Drawing.Color.White;
            this.RrhhCboPermisoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboPermisoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboPermisoTipo.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboPermisoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboPermisoTipo.FormattingEnabled = true;
            this.RrhhCboPermisoTipo.Location = new System.Drawing.Point(168, 165);
            this.RrhhCboPermisoTipo.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboPermisoTipo.Name = "RrhhCboPermisoTipo";
            this.RrhhCboPermisoTipo.Size = new System.Drawing.Size(284, 25);
            this.RrhhCboPermisoTipo.TabIndex = 9;
            // 
            // RrhhLblPermisoEstado
            // 
            this.RrhhLblPermisoEstado.AutoSize = true;
            this.RrhhLblPermisoEstado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoEstado.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoEstado.Location = new System.Drawing.Point(15, 212);
            this.RrhhLblPermisoEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoEstado.Name = "RrhhLblPermisoEstado";
            this.RrhhLblPermisoEstado.Size = new System.Drawing.Size(50, 16);
            this.RrhhLblPermisoEstado.TabIndex = 10;
            this.RrhhLblPermisoEstado.Text = "Estado:";
            // 
            // RrhhCboPermisoEstado
            // 
            this.RrhhCboPermisoEstado.BackColor = System.Drawing.Color.White;
            this.RrhhCboPermisoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboPermisoEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboPermisoEstado.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboPermisoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboPermisoEstado.FormattingEnabled = true;
            this.RrhhCboPermisoEstado.Location = new System.Drawing.Point(168, 208);
            this.RrhhCboPermisoEstado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboPermisoEstado.Name = "RrhhCboPermisoEstado";
            this.RrhhCboPermisoEstado.Size = new System.Drawing.Size(284, 25);
            this.RrhhCboPermisoEstado.TabIndex = 11;
            // 
            // RrhhLblNotaDatosPermiso
            // 
            this.RrhhLblNotaDatosPermiso.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblNotaDatosPermiso.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblNotaDatosPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            this.RrhhLblNotaDatosPermiso.Location = new System.Drawing.Point(15, 256);
            this.RrhhLblNotaDatosPermiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblNotaDatosPermiso.Name = "RrhhLblNotaDatosPermiso";
            this.RrhhLblNotaDatosPermiso.Size = new System.Drawing.Size(440, 16);
            this.RrhhLblNotaDatosPermiso.TabIndex = 12;
            this.RrhhLblNotaDatosPermiso.Text = "Departamento y puesto se cargan al elegir al empleado.";
            this.RrhhLblNotaDatosPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RrhhGbxPeriodoPermiso
            // 
            this.RrhhGbxPeriodoPermiso.BackColor = System.Drawing.Color.White;
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhLblPermisoFechaInicio);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhLblAsteriscoPermisoFechaInicio);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhDtpPermisoFechaInicio);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhLblPermisoFechaFin);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhLblAsteriscoPermisoFechaFin);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhDtpPermisoFechaFin);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhLblPermisoCalcularEn);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhRdbPermisoDias);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhRdbPermisoHoras);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhLblPermisoHorario);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhDtpPermisoHoraInicio);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhDtpPermisoHoraFin);
            this.RrhhGbxPeriodoPermiso.Controls.Add(this.RrhhPnlTotalPermiso);
            this.RrhhGbxPeriodoPermiso.Font = new System.Drawing.Font("Tahoma", 6.81F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhGbxPeriodoPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.RrhhGbxPeriodoPermiso.Location = new System.Drawing.Point(496, 44);
            this.RrhhGbxPeriodoPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhGbxPeriodoPermiso.Name = "RrhhGbxPeriodoPermiso";
            this.RrhhGbxPeriodoPermiso.Padding = new System.Windows.Forms.Padding(4);
            this.RrhhGbxPeriodoPermiso.Size = new System.Drawing.Size(470, 303);
            this.RrhhGbxPeriodoPermiso.TabIndex = 2;
            this.RrhhGbxPeriodoPermiso.TabStop = false;
            this.RrhhGbxPeriodoPermiso.Text = "Período del permiso";
            // 
            // RrhhLblPermisoFechaInicio
            // 
            this.RrhhLblPermisoFechaInicio.AutoSize = true;
            this.RrhhLblPermisoFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoFechaInicio.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoFechaInicio.Location = new System.Drawing.Point(15, 38);
            this.RrhhLblPermisoFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoFechaInicio.Name = "RrhhLblPermisoFechaInicio";
            this.RrhhLblPermisoFechaInicio.Size = new System.Drawing.Size(97, 16);
            this.RrhhLblPermisoFechaInicio.TabIndex = 0;
            this.RrhhLblPermisoFechaInicio.Text = "Fecha de inicio:";
            // 
            // RrhhLblAsteriscoPermisoFechaInicio
            // 
            this.RrhhLblAsteriscoPermisoFechaInicio.AutoSize = true;
            this.RrhhLblAsteriscoPermisoFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblAsteriscoPermisoFechaInicio.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblAsteriscoPermisoFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblAsteriscoPermisoFechaInicio.Location = new System.Drawing.Point(148, 38);
            this.RrhhLblAsteriscoPermisoFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblAsteriscoPermisoFechaInicio.Name = "RrhhLblAsteriscoPermisoFechaInicio";
            this.RrhhLblAsteriscoPermisoFechaInicio.Size = new System.Drawing.Size(17, 17);
            this.RrhhLblAsteriscoPermisoFechaInicio.TabIndex = 1;
            this.RrhhLblAsteriscoPermisoFechaInicio.Text = "*";
            // 
            // RrhhDtpPermisoFechaInicio
            // 
            this.RrhhDtpPermisoFechaInicio.CalendarMonthBackground = System.Drawing.Color.White;
            this.RrhhDtpPermisoFechaInicio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhDtpPermisoFechaInicio.CalendarTitleForeColor = System.Drawing.Color.White;
            this.RrhhDtpPermisoFechaInicio.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhDtpPermisoFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RrhhDtpPermisoFechaInicio.Location = new System.Drawing.Point(168, 34);
            this.RrhhDtpPermisoFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhDtpPermisoFechaInicio.Name = "RrhhDtpPermisoFechaInicio";
            this.RrhhDtpPermisoFechaInicio.Size = new System.Drawing.Size(284, 24);
            this.RrhhDtpPermisoFechaInicio.TabIndex = 2;
            this.RrhhDtpPermisoFechaInicio.ValueChanged += new System.EventHandler(this.RrhhDtpPermisoFechaInicio_ValueChanged);
            // 
            // RrhhLblPermisoFechaFin
            // 
            this.RrhhLblPermisoFechaFin.AutoSize = true;
            this.RrhhLblPermisoFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoFechaFin.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoFechaFin.Location = new System.Drawing.Point(15, 81);
            this.RrhhLblPermisoFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoFechaFin.Name = "RrhhLblPermisoFechaFin";
            this.RrhhLblPermisoFechaFin.Size = new System.Drawing.Size(82, 16);
            this.RrhhLblPermisoFechaFin.TabIndex = 3;
            this.RrhhLblPermisoFechaFin.Text = "Fecha de fin:";
            // 
            // RrhhLblAsteriscoPermisoFechaFin
            // 
            this.RrhhLblAsteriscoPermisoFechaFin.AutoSize = true;
            this.RrhhLblAsteriscoPermisoFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblAsteriscoPermisoFechaFin.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblAsteriscoPermisoFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblAsteriscoPermisoFechaFin.Location = new System.Drawing.Point(148, 81);
            this.RrhhLblAsteriscoPermisoFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblAsteriscoPermisoFechaFin.Name = "RrhhLblAsteriscoPermisoFechaFin";
            this.RrhhLblAsteriscoPermisoFechaFin.Size = new System.Drawing.Size(17, 17);
            this.RrhhLblAsteriscoPermisoFechaFin.TabIndex = 4;
            this.RrhhLblAsteriscoPermisoFechaFin.Text = "*";
            // 
            // RrhhDtpPermisoFechaFin
            // 
            this.RrhhDtpPermisoFechaFin.CalendarMonthBackground = System.Drawing.Color.White;
            this.RrhhDtpPermisoFechaFin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhDtpPermisoFechaFin.CalendarTitleForeColor = System.Drawing.Color.White;
            this.RrhhDtpPermisoFechaFin.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhDtpPermisoFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RrhhDtpPermisoFechaFin.Location = new System.Drawing.Point(168, 78);
            this.RrhhDtpPermisoFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhDtpPermisoFechaFin.Name = "RrhhDtpPermisoFechaFin";
            this.RrhhDtpPermisoFechaFin.Size = new System.Drawing.Size(284, 24);
            this.RrhhDtpPermisoFechaFin.TabIndex = 5;
            // 
            // RrhhLblPermisoCalcularEn
            // 
            this.RrhhLblPermisoCalcularEn.AutoSize = true;
            this.RrhhLblPermisoCalcularEn.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoCalcularEn.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoCalcularEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoCalcularEn.Location = new System.Drawing.Point(15, 124);
            this.RrhhLblPermisoCalcularEn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoCalcularEn.Name = "RrhhLblPermisoCalcularEn";
            this.RrhhLblPermisoCalcularEn.Size = new System.Drawing.Size(76, 16);
            this.RrhhLblPermisoCalcularEn.TabIndex = 6;
            this.RrhhLblPermisoCalcularEn.Text = "Calcular en:";
            // 
            // RrhhRdbPermisoDias
            // 
            this.RrhhRdbPermisoDias.AutoSize = true;
            this.RrhhRdbPermisoDias.BackColor = System.Drawing.Color.Transparent;
            this.RrhhRdbPermisoDias.Checked = true;
            this.RrhhRdbPermisoDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhRdbPermisoDias.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhRdbPermisoDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhRdbPermisoDias.Location = new System.Drawing.Point(168, 123);
            this.RrhhRdbPermisoDias.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhRdbPermisoDias.Name = "RrhhRdbPermisoDias";
            this.RrhhRdbPermisoDias.Size = new System.Drawing.Size(56, 20);
            this.RrhhRdbPermisoDias.TabIndex = 7;
            this.RrhhRdbPermisoDias.TabStop = true;
            this.RrhhRdbPermisoDias.Text = "Días";
            this.RrhhRdbPermisoDias.UseVisualStyleBackColor = false;
            // 
            // RrhhRdbPermisoHoras
            // 
            this.RrhhRdbPermisoHoras.AutoSize = true;
            this.RrhhRdbPermisoHoras.BackColor = System.Drawing.Color.Transparent;
            this.RrhhRdbPermisoHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhRdbPermisoHoras.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhRdbPermisoHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhRdbPermisoHoras.Location = new System.Drawing.Point(258, 123);
            this.RrhhRdbPermisoHoras.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhRdbPermisoHoras.Name = "RrhhRdbPermisoHoras";
            this.RrhhRdbPermisoHoras.Size = new System.Drawing.Size(65, 20);
            this.RrhhRdbPermisoHoras.TabIndex = 8;
            this.RrhhRdbPermisoHoras.Text = "Horas";
            this.RrhhRdbPermisoHoras.UseVisualStyleBackColor = false;
            // 
            // RrhhLblPermisoHorario
            // 
            this.RrhhLblPermisoHorario.AutoSize = true;
            this.RrhhLblPermisoHorario.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoHorario.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoHorario.Location = new System.Drawing.Point(15, 168);
            this.RrhhLblPermisoHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoHorario.Name = "RrhhLblPermisoHorario";
            this.RrhhLblPermisoHorario.Size = new System.Drawing.Size(54, 16);
            this.RrhhLblPermisoHorario.TabIndex = 9;
            this.RrhhLblPermisoHorario.Text = "Horario:";
            // 
            // RrhhDtpPermisoHoraInicio
            // 
            this.RrhhDtpPermisoHoraInicio.CalendarMonthBackground = System.Drawing.Color.White;
            this.RrhhDtpPermisoHoraInicio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhDtpPermisoHoraInicio.CalendarTitleForeColor = System.Drawing.Color.White;
            this.RrhhDtpPermisoHoraInicio.Enabled = false;
            this.RrhhDtpPermisoHoraInicio.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhDtpPermisoHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.RrhhDtpPermisoHoraInicio.Location = new System.Drawing.Point(168, 165);
            this.RrhhDtpPermisoHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhDtpPermisoHoraInicio.Name = "RrhhDtpPermisoHoraInicio";
            this.RrhhDtpPermisoHoraInicio.ShowUpDown = true;
            this.RrhhDtpPermisoHoraInicio.Size = new System.Drawing.Size(132, 24);
            this.RrhhDtpPermisoHoraInicio.TabIndex = 10;
            // 
            // RrhhDtpPermisoHoraFin
            // 
            this.RrhhDtpPermisoHoraFin.CalendarMonthBackground = System.Drawing.Color.White;
            this.RrhhDtpPermisoHoraFin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhDtpPermisoHoraFin.CalendarTitleForeColor = System.Drawing.Color.White;
            this.RrhhDtpPermisoHoraFin.Enabled = false;
            this.RrhhDtpPermisoHoraFin.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhDtpPermisoHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.RrhhDtpPermisoHoraFin.Location = new System.Drawing.Point(321, 165);
            this.RrhhDtpPermisoHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhDtpPermisoHoraFin.Name = "RrhhDtpPermisoHoraFin";
            this.RrhhDtpPermisoHoraFin.ShowUpDown = true;
            this.RrhhDtpPermisoHoraFin.Size = new System.Drawing.Size(132, 24);
            this.RrhhDtpPermisoHoraFin.TabIndex = 11;
            // 
            // RrhhPnlTotalPermiso
            // 
            this.RrhhPnlTotalPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.RrhhPnlTotalPermiso.Controls.Add(this.RrhhLblTotalPermisoTexto);
            this.RrhhPnlTotalPermiso.Controls.Add(this.RrhhLblNotaTotalPermiso);
            this.RrhhPnlTotalPermiso.Controls.Add(this.RrhhLblTotalPermisoValor);
            this.RrhhPnlTotalPermiso.Location = new System.Drawing.Point(15, 208);
            this.RrhhPnlTotalPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlTotalPermiso.Name = "RrhhPnlTotalPermiso";
            this.RrhhPnlTotalPermiso.Size = new System.Drawing.Size(440, 72);
            this.RrhhPnlTotalPermiso.TabIndex = 12;
            // 
            // RrhhLblTotalPermisoTexto
            // 
            this.RrhhLblTotalPermisoTexto.AutoSize = true;
            this.RrhhLblTotalPermisoTexto.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblTotalPermisoTexto.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblTotalPermisoTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblTotalPermisoTexto.Location = new System.Drawing.Point(14, 14);
            this.RrhhLblTotalPermisoTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblTotalPermisoTexto.Name = "RrhhLblTotalPermisoTexto";
            this.RrhhLblTotalPermisoTexto.Size = new System.Drawing.Size(126, 17);
            this.RrhhLblTotalPermisoTexto.TabIndex = 0;
            this.RrhhLblTotalPermisoTexto.Text = "Total del permiso";
            // 
            // RrhhLblNotaTotalPermiso
            // 
            this.RrhhLblNotaTotalPermiso.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblNotaTotalPermiso.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblNotaTotalPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            this.RrhhLblNotaTotalPermiso.Location = new System.Drawing.Point(14, 42);
            this.RrhhLblNotaTotalPermiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblNotaTotalPermiso.Name = "RrhhLblNotaTotalPermiso";
            this.RrhhLblNotaTotalPermiso.Size = new System.Drawing.Size(226, 16);
            this.RrhhLblNotaTotalPermiso.TabIndex = 1;
            this.RrhhLblNotaTotalPermiso.Text = "Se calcula solo a partir de las fechas";
            this.RrhhLblNotaTotalPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RrhhLblTotalPermisoValor
            // 
            this.RrhhLblTotalPermisoValor.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblTotalPermisoValor.Font = new System.Drawing.Font("Segoe UI", 11.34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblTotalPermisoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblTotalPermisoValor.Location = new System.Drawing.Point(246, 16);
            this.RrhhLblTotalPermisoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblTotalPermisoValor.Name = "RrhhLblTotalPermisoValor";
            this.RrhhLblTotalPermisoValor.Size = new System.Drawing.Size(180, 38);
            this.RrhhLblTotalPermisoValor.TabIndex = 2;
            this.RrhhLblTotalPermisoValor.Text = "0 días";
            this.RrhhLblTotalPermisoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RrhhGbxMotivoPermiso
            // 
            this.RrhhGbxMotivoPermiso.BackColor = System.Drawing.Color.White;
            this.RrhhGbxMotivoPermiso.Controls.Add(this.RrhhLblPermisoMotivo);
            this.RrhhGbxMotivoPermiso.Controls.Add(this.RrhhLblAsteriscoPermisoMotivo);
            this.RrhhGbxMotivoPermiso.Controls.Add(this.RrhhTxtPermisoMotivo);
            this.RrhhGbxMotivoPermiso.Controls.Add(this.RrhhLblContadorMotivo);
            this.RrhhGbxMotivoPermiso.Font = new System.Drawing.Font("Tahoma", 6.81F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhGbxMotivoPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.RrhhGbxMotivoPermiso.Location = new System.Drawing.Point(978, 44);
            this.RrhhGbxMotivoPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhGbxMotivoPermiso.Name = "RrhhGbxMotivoPermiso";
            this.RrhhGbxMotivoPermiso.Padding = new System.Windows.Forms.Padding(4);
            this.RrhhGbxMotivoPermiso.Size = new System.Drawing.Size(470, 303);
            this.RrhhGbxMotivoPermiso.TabIndex = 3;
            this.RrhhGbxMotivoPermiso.TabStop = false;
            this.RrhhGbxMotivoPermiso.Text = "Motivo del permiso";
            // 
            // RrhhLblPermisoMotivo
            // 
            this.RrhhLblPermisoMotivo.AutoSize = true;
            this.RrhhLblPermisoMotivo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPermisoMotivo.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPermisoMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblPermisoMotivo.Location = new System.Drawing.Point(15, 38);
            this.RrhhLblPermisoMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPermisoMotivo.Name = "RrhhLblPermisoMotivo";
            this.RrhhLblPermisoMotivo.Size = new System.Drawing.Size(49, 16);
            this.RrhhLblPermisoMotivo.TabIndex = 0;
            this.RrhhLblPermisoMotivo.Text = "Motivo:";
            // 
            // RrhhLblAsteriscoPermisoMotivo
            // 
            this.RrhhLblAsteriscoPermisoMotivo.AutoSize = true;
            this.RrhhLblAsteriscoPermisoMotivo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblAsteriscoPermisoMotivo.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblAsteriscoPermisoMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblAsteriscoPermisoMotivo.Location = new System.Drawing.Point(148, 38);
            this.RrhhLblAsteriscoPermisoMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblAsteriscoPermisoMotivo.Name = "RrhhLblAsteriscoPermisoMotivo";
            this.RrhhLblAsteriscoPermisoMotivo.Size = new System.Drawing.Size(17, 17);
            this.RrhhLblAsteriscoPermisoMotivo.TabIndex = 1;
            this.RrhhLblAsteriscoPermisoMotivo.Text = "*";
            // 
            // RrhhTxtPermisoMotivo
            // 
            this.RrhhTxtPermisoMotivo.BackColor = System.Drawing.Color.White;
            this.RrhhTxtPermisoMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtPermisoMotivo.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtPermisoMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtPermisoMotivo.Location = new System.Drawing.Point(15, 63);
            this.RrhhTxtPermisoMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtPermisoMotivo.MaxLength = 250;
            this.RrhhTxtPermisoMotivo.Multiline = true;
            this.RrhhTxtPermisoMotivo.Name = "RrhhTxtPermisoMotivo";
            this.RrhhTxtPermisoMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RrhhTxtPermisoMotivo.Size = new System.Drawing.Size(438, 185);
            this.RrhhTxtPermisoMotivo.TabIndex = 2;
            // 
            // RrhhLblContadorMotivo
            // 
            this.RrhhLblContadorMotivo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblContadorMotivo.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblContadorMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            this.RrhhLblContadorMotivo.Location = new System.Drawing.Point(258, 256);
            this.RrhhLblContadorMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblContadorMotivo.Name = "RrhhLblContadorMotivo";
            this.RrhhLblContadorMotivo.Size = new System.Drawing.Size(196, 16);
            this.RrhhLblContadorMotivo.TabIndex = 3;
            this.RrhhLblContadorMotivo.Text = "0 / 250 caracteres";
            this.RrhhLblContadorMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RrhhPnlRegistrosPermiso
            // 
            this.RrhhPnlRegistrosPermiso.BackColor = System.Drawing.Color.White;
            this.RrhhPnlRegistrosPermiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhLblTituloRegistrosPermiso);
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhLblFiltroPermisoEmpleado);
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhTxtFiltroPermisoEmpleado);
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhLblFiltroPermisoTipo);
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhCboFiltroPermisoTipo);
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhLblFiltroPermisoEstado);
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhCboFiltroPermisoEstado);
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhBtnFiltrarPermiso);
            this.RrhhPnlRegistrosPermiso.Controls.Add(this.RrhhDgvPermisos);
            this.RrhhPnlRegistrosPermiso.Location = new System.Drawing.Point(6, 362);
            this.RrhhPnlRegistrosPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlRegistrosPermiso.Name = "RrhhPnlRegistrosPermiso";
            this.RrhhPnlRegistrosPermiso.Size = new System.Drawing.Size(1466, 296);
            this.RrhhPnlRegistrosPermiso.TabIndex = 1;
            // 
            // RrhhLblTituloRegistrosPermiso
            // 
            this.RrhhLblTituloRegistrosPermiso.AutoSize = true;
            this.RrhhLblTituloRegistrosPermiso.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblTituloRegistrosPermiso.Font = new System.Drawing.Font("Lucida Bright", 8.82F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblTituloRegistrosPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblTituloRegistrosPermiso.Location = new System.Drawing.Point(14, 10);
            this.RrhhLblTituloRegistrosPermiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblTituloRegistrosPermiso.Name = "RrhhLblTituloRegistrosPermiso";
            this.RrhhLblTituloRegistrosPermiso.Size = new System.Drawing.Size(201, 20);
            this.RrhhLblTituloRegistrosPermiso.TabIndex = 0;
            this.RrhhLblTituloRegistrosPermiso.Text = "Permisos registrados";
            // 
            // RrhhLblFiltroPermisoEmpleado
            // 
            this.RrhhLblFiltroPermisoEmpleado.AutoSize = true;
            this.RrhhLblFiltroPermisoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblFiltroPermisoEmpleado.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblFiltroPermisoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblFiltroPermisoEmpleado.Location = new System.Drawing.Point(15, 51);
            this.RrhhLblFiltroPermisoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblFiltroPermisoEmpleado.Name = "RrhhLblFiltroPermisoEmpleado";
            this.RrhhLblFiltroPermisoEmpleado.Size = new System.Drawing.Size(68, 16);
            this.RrhhLblFiltroPermisoEmpleado.TabIndex = 1;
            this.RrhhLblFiltroPermisoEmpleado.Text = "Empleado:";
            // 
            // RrhhTxtFiltroPermisoEmpleado
            // 
            this.RrhhTxtFiltroPermisoEmpleado.BackColor = System.Drawing.Color.White;
            this.RrhhTxtFiltroPermisoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtFiltroPermisoEmpleado.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtFiltroPermisoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtFiltroPermisoEmpleado.Location = new System.Drawing.Point(93, 48);
            this.RrhhTxtFiltroPermisoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtFiltroPermisoEmpleado.Name = "RrhhTxtFiltroPermisoEmpleado";
            this.RrhhTxtFiltroPermisoEmpleado.Size = new System.Drawing.Size(245, 24);
            this.RrhhTxtFiltroPermisoEmpleado.TabIndex = 2;
            // 
            // RrhhLblFiltroPermisoTipo
            // 
            this.RrhhLblFiltroPermisoTipo.AutoSize = true;
            this.RrhhLblFiltroPermisoTipo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblFiltroPermisoTipo.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblFiltroPermisoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblFiltroPermisoTipo.Location = new System.Drawing.Point(370, 51);
            this.RrhhLblFiltroPermisoTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblFiltroPermisoTipo.Name = "RrhhLblFiltroPermisoTipo";
            this.RrhhLblFiltroPermisoTipo.Size = new System.Drawing.Size(37, 16);
            this.RrhhLblFiltroPermisoTipo.TabIndex = 3;
            this.RrhhLblFiltroPermisoTipo.Text = "Tipo:";
            // 
            // RrhhCboFiltroPermisoTipo
            // 
            this.RrhhCboFiltroPermisoTipo.BackColor = System.Drawing.Color.White;
            this.RrhhCboFiltroPermisoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboFiltroPermisoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboFiltroPermisoTipo.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboFiltroPermisoTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboFiltroPermisoTipo.FormattingEnabled = true;
            this.RrhhCboFiltroPermisoTipo.Location = new System.Drawing.Point(414, 48);
            this.RrhhCboFiltroPermisoTipo.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboFiltroPermisoTipo.Name = "RrhhCboFiltroPermisoTipo";
            this.RrhhCboFiltroPermisoTipo.Size = new System.Drawing.Size(216, 25);
            this.RrhhCboFiltroPermisoTipo.TabIndex = 4;
            // 
            // RrhhLblFiltroPermisoEstado
            // 
            this.RrhhLblFiltroPermisoEstado.AutoSize = true;
            this.RrhhLblFiltroPermisoEstado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblFiltroPermisoEstado.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblFiltroPermisoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblFiltroPermisoEstado.Location = new System.Drawing.Point(660, 51);
            this.RrhhLblFiltroPermisoEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblFiltroPermisoEstado.Name = "RrhhLblFiltroPermisoEstado";
            this.RrhhLblFiltroPermisoEstado.Size = new System.Drawing.Size(50, 16);
            this.RrhhLblFiltroPermisoEstado.TabIndex = 5;
            this.RrhhLblFiltroPermisoEstado.Text = "Estado:";
            // 
            // RrhhCboFiltroPermisoEstado
            // 
            this.RrhhCboFiltroPermisoEstado.BackColor = System.Drawing.Color.White;
            this.RrhhCboFiltroPermisoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboFiltroPermisoEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboFiltroPermisoEstado.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboFiltroPermisoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboFiltroPermisoEstado.FormattingEnabled = true;
            this.RrhhCboFiltroPermisoEstado.Location = new System.Drawing.Point(720, 48);
            this.RrhhCboFiltroPermisoEstado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboFiltroPermisoEstado.Name = "RrhhCboFiltroPermisoEstado";
            this.RrhhCboFiltroPermisoEstado.Size = new System.Drawing.Size(194, 25);
            this.RrhhCboFiltroPermisoEstado.TabIndex = 6;
            // 
            // RrhhBtnFiltrarPermiso
            // 
            this.RrhhBtnFiltrarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhBtnFiltrarPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnFiltrarPermiso.FlatAppearance.BorderSize = 0;
            this.RrhhBtnFiltrarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnFiltrarPermiso.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnFiltrarPermiso.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnFiltrarPermiso.Location = new System.Drawing.Point(1299, 45);
            this.RrhhBtnFiltrarPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnFiltrarPermiso.Name = "RrhhBtnFiltrarPermiso";
            this.RrhhBtnFiltrarPermiso.Size = new System.Drawing.Size(148, 28);
            this.RrhhBtnFiltrarPermiso.TabIndex = 7;
            this.RrhhBtnFiltrarPermiso.Text = "Filtrar";
            this.RrhhBtnFiltrarPermiso.UseVisualStyleBackColor = false;
            // 
            // RrhhDgvPermisos
            // 
            this.RrhhDgvPermisos.AllowUserToAddRows = false;
            this.RrhhDgvPermisos.AllowUserToDeleteRows = false;
            this.RrhhDgvPermisos.AllowUserToResizeColumns = false;
            this.RrhhDgvPermisos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RrhhDgvPermisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RrhhDgvPermisos.BackgroundColor = System.Drawing.Color.White;
            this.RrhhDgvPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RrhhDgvPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RrhhDgvPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 6.05F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RrhhDgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RrhhDgvPermisos.ColumnHeadersHeight = 19;
            this.RrhhDgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RrhhDgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RrhhColPermisoId,
            this.RrhhColPermisoCodigo,
            this.RrhhColPermisoEmpleado,
            this.RrhhColPermisoDepartamento,
            this.RrhhColPermisoTipo,
            this.RrhhColPermisoFechaInicio,
            this.RrhhColPermisoFechaFin,
            this.RrhhColPermisoTotal,
            this.RrhhColPermisoMotivo,
            this.RrhhColPermisoEstado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 6.05F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RrhhDgvPermisos.DefaultCellStyle = dataGridViewCellStyle6;
            this.RrhhDgvPermisos.EnableHeadersVisualStyles = false;
            this.RrhhDgvPermisos.Location = new System.Drawing.Point(15, 82);
            this.RrhhDgvPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhDgvPermisos.MultiSelect = false;
            this.RrhhDgvPermisos.Name = "RrhhDgvPermisos";
            this.RrhhDgvPermisos.ReadOnly = true;
            this.RrhhDgvPermisos.RowHeadersVisible = false;
            this.RrhhDgvPermisos.RowHeadersWidth = 34;
            this.RrhhDgvPermisos.RowTemplate.Height = 16;
            this.RrhhDgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RrhhDgvPermisos.ShowCellToolTips = false;
            this.RrhhDgvPermisos.Size = new System.Drawing.Size(1431, 203);
            this.RrhhDgvPermisos.TabIndex = 8;
            // 
            // RrhhColPermisoId
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RrhhColPermisoId.DefaultCellStyle = dataGridViewCellStyle3;
            this.RrhhColPermisoId.HeaderText = "ID";
            this.RrhhColPermisoId.MinimumWidth = 4;
            this.RrhhColPermisoId.Name = "RrhhColPermisoId";
            this.RrhhColPermisoId.ReadOnly = true;
            this.RrhhColPermisoId.Width = 33;
            // 
            // RrhhColPermisoCodigo
            // 
            this.RrhhColPermisoCodigo.HeaderText = "Código";
            this.RrhhColPermisoCodigo.MinimumWidth = 4;
            this.RrhhColPermisoCodigo.Name = "RrhhColPermisoCodigo";
            this.RrhhColPermisoCodigo.ReadOnly = true;
            this.RrhhColPermisoCodigo.Width = 59;
            // 
            // RrhhColPermisoEmpleado
            // 
            this.RrhhColPermisoEmpleado.HeaderText = "Empleado";
            this.RrhhColPermisoEmpleado.MinimumWidth = 4;
            this.RrhhColPermisoEmpleado.Name = "RrhhColPermisoEmpleado";
            this.RrhhColPermisoEmpleado.ReadOnly = true;
            this.RrhhColPermisoEmpleado.Width = 151;
            // 
            // RrhhColPermisoDepartamento
            // 
            this.RrhhColPermisoDepartamento.HeaderText = "Departamento";
            this.RrhhColPermisoDepartamento.MinimumWidth = 4;
            this.RrhhColPermisoDepartamento.Name = "RrhhColPermisoDepartamento";
            this.RrhhColPermisoDepartamento.ReadOnly = true;
            this.RrhhColPermisoDepartamento.Width = 99;
            // 
            // RrhhColPermisoTipo
            // 
            this.RrhhColPermisoTipo.HeaderText = "Tipo de permiso";
            this.RrhhColPermisoTipo.MinimumWidth = 4;
            this.RrhhColPermisoTipo.Name = "RrhhColPermisoTipo";
            this.RrhhColPermisoTipo.ReadOnly = true;
            this.RrhhColPermisoTipo.Width = 151;
            // 
            // RrhhColPermisoFechaInicio
            // 
            this.RrhhColPermisoFechaInicio.HeaderText = "Fecha inicio";
            this.RrhhColPermisoFechaInicio.MinimumWidth = 4;
            this.RrhhColPermisoFechaInicio.Name = "RrhhColPermisoFechaInicio";
            this.RrhhColPermisoFechaInicio.ReadOnly = true;
            this.RrhhColPermisoFechaInicio.Width = 72;
            // 
            // RrhhColPermisoFechaFin
            // 
            this.RrhhColPermisoFechaFin.HeaderText = "Fecha fin";
            this.RrhhColPermisoFechaFin.MinimumWidth = 4;
            this.RrhhColPermisoFechaFin.Name = "RrhhColPermisoFechaFin";
            this.RrhhColPermisoFechaFin.ReadOnly = true;
            this.RrhhColPermisoFechaFin.Width = 72;
            // 
            // RrhhColPermisoTotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RrhhColPermisoTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.RrhhColPermisoTotal.HeaderText = "Días / horas";
            this.RrhhColPermisoTotal.MinimumWidth = 4;
            this.RrhhColPermisoTotal.Name = "RrhhColPermisoTotal";
            this.RrhhColPermisoTotal.ReadOnly = true;
            this.RrhhColPermisoTotal.Width = 66;
            // 
            // RrhhColPermisoMotivo
            // 
            this.RrhhColPermisoMotivo.HeaderText = "Motivo";
            this.RrhhColPermisoMotivo.MinimumWidth = 4;
            this.RrhhColPermisoMotivo.Name = "RrhhColPermisoMotivo";
            this.RrhhColPermisoMotivo.ReadOnly = true;
            this.RrhhColPermisoMotivo.Width = 171;
            // 
            // RrhhColPermisoEstado
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RrhhColPermisoEstado.DefaultCellStyle = dataGridViewCellStyle5;
            this.RrhhColPermisoEstado.HeaderText = "Estado";
            this.RrhhColPermisoEstado.MinimumWidth = 4;
            this.RrhhColPermisoEstado.Name = "RrhhColPermisoEstado";
            this.RrhhColPermisoEstado.ReadOnly = true;
            this.RrhhColPermisoEstado.Width = 80;
            // 
            // RrhhTabPagVacaciones
            // 
            this.RrhhTabPagVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhTabPagVacaciones.Controls.Add(this.RrhhPnlDetalleVacacion);
            this.RrhhTabPagVacaciones.Controls.Add(this.RrhhPnlRegistrosVacacion);
            this.RrhhTabPagVacaciones.Location = new System.Drawing.Point(4, 5);
            this.RrhhTabPagVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTabPagVacaciones.Name = "RrhhTabPagVacaciones";
            this.RrhhTabPagVacaciones.Size = new System.Drawing.Size(1476, 654);
            this.RrhhTabPagVacaciones.TabIndex = 1;
            this.RrhhTabPagVacaciones.Text = "Vacaciones";
            // 
            // RrhhPnlDetalleVacacion
            // 
            this.RrhhPnlDetalleVacacion.BackColor = System.Drawing.Color.White;
            this.RrhhPnlDetalleVacacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhPnlDetalleVacacion.Controls.Add(this.RrhhLblTituloDetalleVacacion);
            this.RrhhPnlDetalleVacacion.Controls.Add(this.RrhhGbxDatosColaborador);
            this.RrhhPnlDetalleVacacion.Controls.Add(this.RrhhGbxDerechoVacaciones);
            this.RrhhPnlDetalleVacacion.Controls.Add(this.RrhhGbxSolicitudVacaciones);
            this.RrhhPnlDetalleVacacion.Location = new System.Drawing.Point(6, 4);
            this.RrhhPnlDetalleVacacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlDetalleVacacion.Name = "RrhhPnlDetalleVacacion";
            this.RrhhPnlDetalleVacacion.Size = new System.Drawing.Size(1460, 358);
            this.RrhhPnlDetalleVacacion.TabIndex = 0;
            // 
            // RrhhLblTituloDetalleVacacion
            // 
            this.RrhhLblTituloDetalleVacacion.AutoSize = true;
            this.RrhhLblTituloDetalleVacacion.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblTituloDetalleVacacion.Font = new System.Drawing.Font("Lucida Bright", 8.82F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblTituloDetalleVacacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblTituloDetalleVacacion.Location = new System.Drawing.Point(14, 10);
            this.RrhhLblTituloDetalleVacacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblTituloDetalleVacacion.Name = "RrhhLblTituloDetalleVacacion";
            this.RrhhLblTituloDetalleVacacion.Size = new System.Drawing.Size(205, 20);
            this.RrhhLblTituloDetalleVacacion.TabIndex = 0;
            this.RrhhLblTituloDetalleVacacion.Text = "Detalle de vacaciones";
            // 
            // RrhhGbxDatosColaborador
            // 
            this.RrhhGbxDatosColaborador.BackColor = System.Drawing.Color.White;
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhLblVacacionEmpleado);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhLblAsteriscoVacacionEmpleado);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhCboVacacionEmpleado);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhLblVacacionDepartamento);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhTxtVacacionDepartamento);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhLblVacacionPuesto);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhTxtVacacionPuesto);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhLblVacacionFechaContratacion);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhTxtVacacionFechaContratacion);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhLblVacacionTiempoLaborado);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhTxtVacacionTiempoLaborado);
            this.RrhhGbxDatosColaborador.Controls.Add(this.RrhhLblNotaDatosColaborador);
            this.RrhhGbxDatosColaborador.Font = new System.Drawing.Font("Tahoma", 6.81F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhGbxDatosColaborador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.RrhhGbxDatosColaborador.Location = new System.Drawing.Point(14, 44);
            this.RrhhGbxDatosColaborador.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhGbxDatosColaborador.Name = "RrhhGbxDatosColaborador";
            this.RrhhGbxDatosColaborador.Padding = new System.Windows.Forms.Padding(4);
            this.RrhhGbxDatosColaborador.Size = new System.Drawing.Size(470, 303);
            this.RrhhGbxDatosColaborador.TabIndex = 1;
            this.RrhhGbxDatosColaborador.TabStop = false;
            this.RrhhGbxDatosColaborador.Text = "Datos del colaborador";
            // 
            // RrhhLblVacacionEmpleado
            // 
            this.RrhhLblVacacionEmpleado.AutoSize = true;
            this.RrhhLblVacacionEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionEmpleado.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionEmpleado.Location = new System.Drawing.Point(15, 38);
            this.RrhhLblVacacionEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionEmpleado.Name = "RrhhLblVacacionEmpleado";
            this.RrhhLblVacacionEmpleado.Size = new System.Drawing.Size(68, 16);
            this.RrhhLblVacacionEmpleado.TabIndex = 0;
            this.RrhhLblVacacionEmpleado.Text = "Empleado:";
            // 
            // RrhhLblAsteriscoVacacionEmpleado
            // 
            this.RrhhLblAsteriscoVacacionEmpleado.AutoSize = true;
            this.RrhhLblAsteriscoVacacionEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblAsteriscoVacacionEmpleado.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblAsteriscoVacacionEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblAsteriscoVacacionEmpleado.Location = new System.Drawing.Point(148, 38);
            this.RrhhLblAsteriscoVacacionEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblAsteriscoVacacionEmpleado.Name = "RrhhLblAsteriscoVacacionEmpleado";
            this.RrhhLblAsteriscoVacacionEmpleado.Size = new System.Drawing.Size(17, 17);
            this.RrhhLblAsteriscoVacacionEmpleado.TabIndex = 1;
            this.RrhhLblAsteriscoVacacionEmpleado.Text = "*";
            // 
            // RrhhCboVacacionEmpleado
            // 
            this.RrhhCboVacacionEmpleado.BackColor = System.Drawing.Color.White;
            this.RrhhCboVacacionEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboVacacionEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboVacacionEmpleado.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboVacacionEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboVacacionEmpleado.FormattingEnabled = true;
            this.RrhhCboVacacionEmpleado.Location = new System.Drawing.Point(168, 34);
            this.RrhhCboVacacionEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboVacacionEmpleado.Name = "RrhhCboVacacionEmpleado";
            this.RrhhCboVacacionEmpleado.Size = new System.Drawing.Size(284, 25);
            this.RrhhCboVacacionEmpleado.TabIndex = 2;
            // 
            // RrhhLblVacacionDepartamento
            // 
            this.RrhhLblVacacionDepartamento.AutoSize = true;
            this.RrhhLblVacacionDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionDepartamento.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionDepartamento.Location = new System.Drawing.Point(15, 81);
            this.RrhhLblVacacionDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionDepartamento.Name = "RrhhLblVacacionDepartamento";
            this.RrhhLblVacacionDepartamento.Size = new System.Drawing.Size(93, 16);
            this.RrhhLblVacacionDepartamento.TabIndex = 3;
            this.RrhhLblVacacionDepartamento.Text = "Departamento:";
            // 
            // RrhhTxtVacacionDepartamento
            // 
            this.RrhhTxtVacacionDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RrhhTxtVacacionDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtVacacionDepartamento.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtVacacionDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtVacacionDepartamento.Location = new System.Drawing.Point(168, 78);
            this.RrhhTxtVacacionDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtVacacionDepartamento.Name = "RrhhTxtVacacionDepartamento";
            this.RrhhTxtVacacionDepartamento.ReadOnly = true;
            this.RrhhTxtVacacionDepartamento.Size = new System.Drawing.Size(286, 24);
            this.RrhhTxtVacacionDepartamento.TabIndex = 4;
            this.RrhhTxtVacacionDepartamento.TabStop = false;
            // 
            // RrhhLblVacacionPuesto
            // 
            this.RrhhLblVacacionPuesto.AutoSize = true;
            this.RrhhLblVacacionPuesto.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionPuesto.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionPuesto.Location = new System.Drawing.Point(15, 124);
            this.RrhhLblVacacionPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionPuesto.Name = "RrhhLblVacacionPuesto";
            this.RrhhLblVacacionPuesto.Size = new System.Drawing.Size(50, 16);
            this.RrhhLblVacacionPuesto.TabIndex = 5;
            this.RrhhLblVacacionPuesto.Text = "Puesto:";
            // 
            // RrhhTxtVacacionPuesto
            // 
            this.RrhhTxtVacacionPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RrhhTxtVacacionPuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtVacacionPuesto.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtVacacionPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtVacacionPuesto.Location = new System.Drawing.Point(168, 122);
            this.RrhhTxtVacacionPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtVacacionPuesto.Name = "RrhhTxtVacacionPuesto";
            this.RrhhTxtVacacionPuesto.ReadOnly = true;
            this.RrhhTxtVacacionPuesto.Size = new System.Drawing.Size(286, 24);
            this.RrhhTxtVacacionPuesto.TabIndex = 6;
            this.RrhhTxtVacacionPuesto.TabStop = false;
            // 
            // RrhhLblVacacionFechaContratacion
            // 
            this.RrhhLblVacacionFechaContratacion.AutoSize = true;
            this.RrhhLblVacacionFechaContratacion.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionFechaContratacion.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionFechaContratacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionFechaContratacion.Location = new System.Drawing.Point(15, 168);
            this.RrhhLblVacacionFechaContratacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionFechaContratacion.Name = "RrhhLblVacacionFechaContratacion";
            this.RrhhLblVacacionFechaContratacion.Size = new System.Drawing.Size(120, 16);
            this.RrhhLblVacacionFechaContratacion.TabIndex = 7;
            this.RrhhLblVacacionFechaContratacion.Text = "Fecha contratación:";
            // 
            // RrhhTxtVacacionFechaContratacion
            // 
            this.RrhhTxtVacacionFechaContratacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RrhhTxtVacacionFechaContratacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtVacacionFechaContratacion.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtVacacionFechaContratacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtVacacionFechaContratacion.Location = new System.Drawing.Point(168, 165);
            this.RrhhTxtVacacionFechaContratacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtVacacionFechaContratacion.Name = "RrhhTxtVacacionFechaContratacion";
            this.RrhhTxtVacacionFechaContratacion.ReadOnly = true;
            this.RrhhTxtVacacionFechaContratacion.Size = new System.Drawing.Size(286, 24);
            this.RrhhTxtVacacionFechaContratacion.TabIndex = 8;
            this.RrhhTxtVacacionFechaContratacion.TabStop = false;
            // 
            // RrhhLblVacacionTiempoLaborado
            // 
            this.RrhhLblVacacionTiempoLaborado.AutoSize = true;
            this.RrhhLblVacacionTiempoLaborado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionTiempoLaborado.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionTiempoLaborado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionTiempoLaborado.Location = new System.Drawing.Point(15, 212);
            this.RrhhLblVacacionTiempoLaborado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionTiempoLaborado.Name = "RrhhLblVacacionTiempoLaborado";
            this.RrhhLblVacacionTiempoLaborado.Size = new System.Drawing.Size(109, 16);
            this.RrhhLblVacacionTiempoLaborado.TabIndex = 9;
            this.RrhhLblVacacionTiempoLaborado.Text = "Tiempo laborado:";
            // 
            // RrhhTxtVacacionTiempoLaborado
            // 
            this.RrhhTxtVacacionTiempoLaborado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RrhhTxtVacacionTiempoLaborado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtVacacionTiempoLaborado.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtVacacionTiempoLaborado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtVacacionTiempoLaborado.Location = new System.Drawing.Point(168, 208);
            this.RrhhTxtVacacionTiempoLaborado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtVacacionTiempoLaborado.Name = "RrhhTxtVacacionTiempoLaborado";
            this.RrhhTxtVacacionTiempoLaborado.ReadOnly = true;
            this.RrhhTxtVacacionTiempoLaborado.Size = new System.Drawing.Size(286, 24);
            this.RrhhTxtVacacionTiempoLaborado.TabIndex = 10;
            this.RrhhTxtVacacionTiempoLaborado.TabStop = false;
            // 
            // RrhhLblNotaDatosColaborador
            // 
            this.RrhhLblNotaDatosColaborador.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblNotaDatosColaborador.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblNotaDatosColaborador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            this.RrhhLblNotaDatosColaborador.Location = new System.Drawing.Point(15, 256);
            this.RrhhLblNotaDatosColaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblNotaDatosColaborador.Name = "RrhhLblNotaDatosColaborador";
            this.RrhhLblNotaDatosColaborador.Size = new System.Drawing.Size(440, 16);
            this.RrhhLblNotaDatosColaborador.TabIndex = 11;
            this.RrhhLblNotaDatosColaborador.Text = "Estos datos se cargan solos y no se pueden editar.";
            this.RrhhLblNotaDatosColaborador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RrhhGbxDerechoVacaciones
            // 
            this.RrhhGbxDerechoVacaciones.BackColor = System.Drawing.Color.White;
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhLblIndicadorDerecho);
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhLblLeyendaDerecho);
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhPnlDiasPeriodo);
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhPnlDiasTomados);
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhPnlDiasDisponibles);
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhLblUsoPeriodo);
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhLblUsoPeriodoValor);
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhPnlUsoPista);
            this.RrhhGbxDerechoVacaciones.Controls.Add(this.RrhhLblNotaUsoPeriodo);
            this.RrhhGbxDerechoVacaciones.Font = new System.Drawing.Font("Tahoma", 6.81F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhGbxDerechoVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.RrhhGbxDerechoVacaciones.Location = new System.Drawing.Point(496, 44);
            this.RrhhGbxDerechoVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhGbxDerechoVacaciones.Name = "RrhhGbxDerechoVacaciones";
            this.RrhhGbxDerechoVacaciones.Padding = new System.Windows.Forms.Padding(4);
            this.RrhhGbxDerechoVacaciones.Size = new System.Drawing.Size(470, 303);
            this.RrhhGbxDerechoVacaciones.TabIndex = 2;
            this.RrhhGbxDerechoVacaciones.TabStop = false;
            this.RrhhGbxDerechoVacaciones.Text = "Derecho a vacaciones";
            // 
            // RrhhLblIndicadorDerecho
            // 
            this.RrhhLblIndicadorDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.RrhhLblIndicadorDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhLblIndicadorDerecho.Font = new System.Drawing.Font("Tahoma", 7.56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblIndicadorDerecho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.RrhhLblIndicadorDerecho.Location = new System.Drawing.Point(15, 32);
            this.RrhhLblIndicadorDerecho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblIndicadorDerecho.Name = "RrhhLblIndicadorDerecho";
            this.RrhhLblIndicadorDerecho.Size = new System.Drawing.Size(438, 41);
            this.RrhhLblIndicadorDerecho.TabIndex = 0;
            this.RrhhLblIndicadorDerecho.Text = "Seleccione un empleado";
            this.RrhhLblIndicadorDerecho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhLblLeyendaDerecho
            // 
            this.RrhhLblLeyendaDerecho.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblLeyendaDerecho.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblLeyendaDerecho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            this.RrhhLblLeyendaDerecho.Location = new System.Drawing.Point(15, 81);
            this.RrhhLblLeyendaDerecho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblLeyendaDerecho.Name = "RrhhLblLeyendaDerecho";
            this.RrhhLblLeyendaDerecho.Size = new System.Drawing.Size(440, 16);
            this.RrhhLblLeyendaDerecho.TabIndex = 1;
            this.RrhhLblLeyendaDerecho.Text = "Verde: tiene derecho (1 año o más)  ·  Rojo: aún no tiene derecho";
            this.RrhhLblLeyendaDerecho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhPnlDiasPeriodo
            // 
            this.RrhhPnlDiasPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.RrhhPnlDiasPeriodo.Controls.Add(this.RrhhLblDiasPeriodoValor);
            this.RrhhPnlDiasPeriodo.Controls.Add(this.RrhhLblDiasPeriodoTexto);
            this.RrhhPnlDiasPeriodo.Location = new System.Drawing.Point(15, 106);
            this.RrhhPnlDiasPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlDiasPeriodo.Name = "RrhhPnlDiasPeriodo";
            this.RrhhPnlDiasPeriodo.Size = new System.Drawing.Size(140, 80);
            this.RrhhPnlDiasPeriodo.TabIndex = 2;
            // 
            // RrhhLblDiasPeriodoValor
            // 
            this.RrhhLblDiasPeriodoValor.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblDiasPeriodoValor.Font = new System.Drawing.Font("Segoe UI", 12.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblDiasPeriodoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblDiasPeriodoValor.Location = new System.Drawing.Point(0, 9);
            this.RrhhLblDiasPeriodoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblDiasPeriodoValor.Name = "RrhhLblDiasPeriodoValor";
            this.RrhhLblDiasPeriodoValor.Size = new System.Drawing.Size(140, 39);
            this.RrhhLblDiasPeriodoValor.TabIndex = 0;
            this.RrhhLblDiasPeriodoValor.Text = "0";
            this.RrhhLblDiasPeriodoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhLblDiasPeriodoTexto
            // 
            this.RrhhLblDiasPeriodoTexto.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblDiasPeriodoTexto.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblDiasPeriodoTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.RrhhLblDiasPeriodoTexto.Location = new System.Drawing.Point(0, 51);
            this.RrhhLblDiasPeriodoTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblDiasPeriodoTexto.Name = "RrhhLblDiasPeriodoTexto";
            this.RrhhLblDiasPeriodoTexto.Size = new System.Drawing.Size(140, 20);
            this.RrhhLblDiasPeriodoTexto.TabIndex = 1;
            this.RrhhLblDiasPeriodoTexto.Text = "Días por período";
            this.RrhhLblDiasPeriodoTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhPnlDiasTomados
            // 
            this.RrhhPnlDiasTomados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.RrhhPnlDiasTomados.Controls.Add(this.RrhhLblDiasTomadosValor);
            this.RrhhPnlDiasTomados.Controls.Add(this.RrhhLblDiasTomadosTexto);
            this.RrhhPnlDiasTomados.Location = new System.Drawing.Point(165, 106);
            this.RrhhPnlDiasTomados.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlDiasTomados.Name = "RrhhPnlDiasTomados";
            this.RrhhPnlDiasTomados.Size = new System.Drawing.Size(140, 80);
            this.RrhhPnlDiasTomados.TabIndex = 3;
            // 
            // RrhhLblDiasTomadosValor
            // 
            this.RrhhLblDiasTomadosValor.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblDiasTomadosValor.Font = new System.Drawing.Font("Segoe UI", 12.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblDiasTomadosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblDiasTomadosValor.Location = new System.Drawing.Point(0, 9);
            this.RrhhLblDiasTomadosValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblDiasTomadosValor.Name = "RrhhLblDiasTomadosValor";
            this.RrhhLblDiasTomadosValor.Size = new System.Drawing.Size(140, 39);
            this.RrhhLblDiasTomadosValor.TabIndex = 0;
            this.RrhhLblDiasTomadosValor.Text = "0";
            this.RrhhLblDiasTomadosValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhLblDiasTomadosTexto
            // 
            this.RrhhLblDiasTomadosTexto.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblDiasTomadosTexto.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblDiasTomadosTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.RrhhLblDiasTomadosTexto.Location = new System.Drawing.Point(0, 51);
            this.RrhhLblDiasTomadosTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblDiasTomadosTexto.Name = "RrhhLblDiasTomadosTexto";
            this.RrhhLblDiasTomadosTexto.Size = new System.Drawing.Size(140, 20);
            this.RrhhLblDiasTomadosTexto.TabIndex = 1;
            this.RrhhLblDiasTomadosTexto.Text = "Días tomados";
            this.RrhhLblDiasTomadosTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhPnlDiasDisponibles
            // 
            this.RrhhPnlDiasDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhPnlDiasDisponibles.Controls.Add(this.RrhhLblDiasDisponiblesValor);
            this.RrhhPnlDiasDisponibles.Controls.Add(this.RrhhLblDiasDisponiblesTexto);
            this.RrhhPnlDiasDisponibles.Location = new System.Drawing.Point(315, 106);
            this.RrhhPnlDiasDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlDiasDisponibles.Name = "RrhhPnlDiasDisponibles";
            this.RrhhPnlDiasDisponibles.Size = new System.Drawing.Size(140, 80);
            this.RrhhPnlDiasDisponibles.TabIndex = 4;
            // 
            // RrhhLblDiasDisponiblesValor
            // 
            this.RrhhLblDiasDisponiblesValor.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblDiasDisponiblesValor.Font = new System.Drawing.Font("Segoe UI", 12.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblDiasDisponiblesValor.ForeColor = System.Drawing.Color.White;
            this.RrhhLblDiasDisponiblesValor.Location = new System.Drawing.Point(0, 9);
            this.RrhhLblDiasDisponiblesValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblDiasDisponiblesValor.Name = "RrhhLblDiasDisponiblesValor";
            this.RrhhLblDiasDisponiblesValor.Size = new System.Drawing.Size(140, 39);
            this.RrhhLblDiasDisponiblesValor.TabIndex = 0;
            this.RrhhLblDiasDisponiblesValor.Text = "0";
            this.RrhhLblDiasDisponiblesValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhLblDiasDisponiblesTexto
            // 
            this.RrhhLblDiasDisponiblesTexto.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblDiasDisponiblesTexto.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblDiasDisponiblesTexto.ForeColor = System.Drawing.Color.White;
            this.RrhhLblDiasDisponiblesTexto.Location = new System.Drawing.Point(0, 51);
            this.RrhhLblDiasDisponiblesTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblDiasDisponiblesTexto.Name = "RrhhLblDiasDisponiblesTexto";
            this.RrhhLblDiasDisponiblesTexto.Size = new System.Drawing.Size(140, 20);
            this.RrhhLblDiasDisponiblesTexto.TabIndex = 1;
            this.RrhhLblDiasDisponiblesTexto.Text = "Días disponibles";
            this.RrhhLblDiasDisponiblesTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhLblUsoPeriodo
            // 
            this.RrhhLblUsoPeriodo.AutoSize = true;
            this.RrhhLblUsoPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblUsoPeriodo.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblUsoPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblUsoPeriodo.Location = new System.Drawing.Point(15, 206);
            this.RrhhLblUsoPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblUsoPeriodo.Name = "RrhhLblUsoPeriodo";
            this.RrhhLblUsoPeriodo.Size = new System.Drawing.Size(96, 16);
            this.RrhhLblUsoPeriodo.TabIndex = 5;
            this.RrhhLblUsoPeriodo.Text = "Uso del período";
            // 
            // RrhhLblUsoPeriodoValor
            // 
            this.RrhhLblUsoPeriodoValor.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblUsoPeriodoValor.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblUsoPeriodoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblUsoPeriodoValor.Location = new System.Drawing.Point(326, 206);
            this.RrhhLblUsoPeriodoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblUsoPeriodoValor.Name = "RrhhLblUsoPeriodoValor";
            this.RrhhLblUsoPeriodoValor.Size = new System.Drawing.Size(129, 20);
            this.RrhhLblUsoPeriodoValor.TabIndex = 6;
            this.RrhhLblUsoPeriodoValor.Text = "0 %";
            this.RrhhLblUsoPeriodoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RrhhPnlUsoPista
            // 
            this.RrhhPnlUsoPista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.RrhhPnlUsoPista.Controls.Add(this.RrhhPnlUsoRelleno);
            this.RrhhPnlUsoPista.Location = new System.Drawing.Point(15, 231);
            this.RrhhPnlUsoPista.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlUsoPista.Name = "RrhhPnlUsoPista";
            this.RrhhPnlUsoPista.Size = new System.Drawing.Size(440, 12);
            this.RrhhPnlUsoPista.TabIndex = 7;
            // 
            // RrhhPnlUsoRelleno
            // 
            this.RrhhPnlUsoRelleno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(145)))));
            this.RrhhPnlUsoRelleno.Location = new System.Drawing.Point(0, 0);
            this.RrhhPnlUsoRelleno.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlUsoRelleno.Name = "RrhhPnlUsoRelleno";
            this.RrhhPnlUsoRelleno.Size = new System.Drawing.Size(10, 12);
            this.RrhhPnlUsoRelleno.TabIndex = 0;
            // 
            // RrhhLblNotaUsoPeriodo
            // 
            this.RrhhLblNotaUsoPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblNotaUsoPeriodo.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblNotaUsoPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            this.RrhhLblNotaUsoPeriodo.Location = new System.Drawing.Point(15, 252);
            this.RrhhLblNotaUsoPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblNotaUsoPeriodo.Name = "RrhhLblNotaUsoPeriodo";
            this.RrhhLblNotaUsoPeriodo.Size = new System.Drawing.Size(440, 16);
            this.RrhhLblNotaUsoPeriodo.TabIndex = 8;
            this.RrhhLblNotaUsoPeriodo.Text = "0 de 0 días utilizados";
            this.RrhhLblNotaUsoPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RrhhGbxSolicitudVacaciones
            // 
            this.RrhhGbxSolicitudVacaciones.BackColor = System.Drawing.Color.White;
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhLblVacacionFechaInicio);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhLblAsteriscoVacacionFechaInicio);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhDtpVacacionFechaInicio);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhLblVacacionFechaFin);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhLblAsteriscoVacacionFechaFin);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhDtpVacacionFechaFin);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhLblVacacionDiasTomar);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhTxtVacacionDiasTomar);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhLblVacacionEstado);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhCboVacacionEstado);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhLblVacacionObservacion);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhTxtVacacionObservacion);
            this.RrhhGbxSolicitudVacaciones.Controls.Add(this.RrhhLblRegistroBloqueado);
            this.RrhhGbxSolicitudVacaciones.Font = new System.Drawing.Font("Tahoma", 6.81F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhGbxSolicitudVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.RrhhGbxSolicitudVacaciones.Location = new System.Drawing.Point(978, 44);
            this.RrhhGbxSolicitudVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhGbxSolicitudVacaciones.Name = "RrhhGbxSolicitudVacaciones";
            this.RrhhGbxSolicitudVacaciones.Padding = new System.Windows.Forms.Padding(4);
            this.RrhhGbxSolicitudVacaciones.Size = new System.Drawing.Size(470, 303);
            this.RrhhGbxSolicitudVacaciones.TabIndex = 3;
            this.RrhhGbxSolicitudVacaciones.TabStop = false;
            this.RrhhGbxSolicitudVacaciones.Text = "Solicitud de vacaciones";
            // 
            // RrhhLblVacacionFechaInicio
            // 
            this.RrhhLblVacacionFechaInicio.AutoSize = true;
            this.RrhhLblVacacionFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionFechaInicio.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionFechaInicio.Location = new System.Drawing.Point(15, 38);
            this.RrhhLblVacacionFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionFechaInicio.Name = "RrhhLblVacacionFechaInicio";
            this.RrhhLblVacacionFechaInicio.Size = new System.Drawing.Size(97, 16);
            this.RrhhLblVacacionFechaInicio.TabIndex = 0;
            this.RrhhLblVacacionFechaInicio.Text = "Fecha de inicio:";
            // 
            // RrhhLblAsteriscoVacacionFechaInicio
            // 
            this.RrhhLblAsteriscoVacacionFechaInicio.AutoSize = true;
            this.RrhhLblAsteriscoVacacionFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblAsteriscoVacacionFechaInicio.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblAsteriscoVacacionFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblAsteriscoVacacionFechaInicio.Location = new System.Drawing.Point(148, 38);
            this.RrhhLblAsteriscoVacacionFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblAsteriscoVacacionFechaInicio.Name = "RrhhLblAsteriscoVacacionFechaInicio";
            this.RrhhLblAsteriscoVacacionFechaInicio.Size = new System.Drawing.Size(17, 17);
            this.RrhhLblAsteriscoVacacionFechaInicio.TabIndex = 1;
            this.RrhhLblAsteriscoVacacionFechaInicio.Text = "*";
            // 
            // RrhhDtpVacacionFechaInicio
            // 
            this.RrhhDtpVacacionFechaInicio.CalendarMonthBackground = System.Drawing.Color.White;
            this.RrhhDtpVacacionFechaInicio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhDtpVacacionFechaInicio.CalendarTitleForeColor = System.Drawing.Color.White;
            this.RrhhDtpVacacionFechaInicio.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhDtpVacacionFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RrhhDtpVacacionFechaInicio.Location = new System.Drawing.Point(168, 34);
            this.RrhhDtpVacacionFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhDtpVacacionFechaInicio.Name = "RrhhDtpVacacionFechaInicio";
            this.RrhhDtpVacacionFechaInicio.Size = new System.Drawing.Size(284, 24);
            this.RrhhDtpVacacionFechaInicio.TabIndex = 2;
            // 
            // RrhhLblVacacionFechaFin
            // 
            this.RrhhLblVacacionFechaFin.AutoSize = true;
            this.RrhhLblVacacionFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionFechaFin.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionFechaFin.Location = new System.Drawing.Point(15, 81);
            this.RrhhLblVacacionFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionFechaFin.Name = "RrhhLblVacacionFechaFin";
            this.RrhhLblVacacionFechaFin.Size = new System.Drawing.Size(82, 16);
            this.RrhhLblVacacionFechaFin.TabIndex = 3;
            this.RrhhLblVacacionFechaFin.Text = "Fecha de fin:";
            // 
            // RrhhLblAsteriscoVacacionFechaFin
            // 
            this.RrhhLblAsteriscoVacacionFechaFin.AutoSize = true;
            this.RrhhLblAsteriscoVacacionFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblAsteriscoVacacionFechaFin.Font = new System.Drawing.Font("Tahoma", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblAsteriscoVacacionFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblAsteriscoVacacionFechaFin.Location = new System.Drawing.Point(148, 81);
            this.RrhhLblAsteriscoVacacionFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblAsteriscoVacacionFechaFin.Name = "RrhhLblAsteriscoVacacionFechaFin";
            this.RrhhLblAsteriscoVacacionFechaFin.Size = new System.Drawing.Size(17, 17);
            this.RrhhLblAsteriscoVacacionFechaFin.TabIndex = 4;
            this.RrhhLblAsteriscoVacacionFechaFin.Text = "*";
            // 
            // RrhhDtpVacacionFechaFin
            // 
            this.RrhhDtpVacacionFechaFin.CalendarMonthBackground = System.Drawing.Color.White;
            this.RrhhDtpVacacionFechaFin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhDtpVacacionFechaFin.CalendarTitleForeColor = System.Drawing.Color.White;
            this.RrhhDtpVacacionFechaFin.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhDtpVacacionFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RrhhDtpVacacionFechaFin.Location = new System.Drawing.Point(168, 78);
            this.RrhhDtpVacacionFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhDtpVacacionFechaFin.Name = "RrhhDtpVacacionFechaFin";
            this.RrhhDtpVacacionFechaFin.Size = new System.Drawing.Size(284, 24);
            this.RrhhDtpVacacionFechaFin.TabIndex = 5;
            // 
            // RrhhLblVacacionDiasTomar
            // 
            this.RrhhLblVacacionDiasTomar.AutoSize = true;
            this.RrhhLblVacacionDiasTomar.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionDiasTomar.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionDiasTomar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionDiasTomar.Location = new System.Drawing.Point(15, 124);
            this.RrhhLblVacacionDiasTomar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionDiasTomar.Name = "RrhhLblVacacionDiasTomar";
            this.RrhhLblVacacionDiasTomar.Size = new System.Drawing.Size(85, 16);
            this.RrhhLblVacacionDiasTomar.TabIndex = 6;
            this.RrhhLblVacacionDiasTomar.Text = "Días a tomar:";
            // 
            // RrhhTxtVacacionDiasTomar
            // 
            this.RrhhTxtVacacionDiasTomar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RrhhTxtVacacionDiasTomar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtVacacionDiasTomar.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtVacacionDiasTomar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtVacacionDiasTomar.Location = new System.Drawing.Point(168, 122);
            this.RrhhTxtVacacionDiasTomar.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtVacacionDiasTomar.Name = "RrhhTxtVacacionDiasTomar";
            this.RrhhTxtVacacionDiasTomar.ReadOnly = true;
            this.RrhhTxtVacacionDiasTomar.Size = new System.Drawing.Size(286, 24);
            this.RrhhTxtVacacionDiasTomar.TabIndex = 7;
            this.RrhhTxtVacacionDiasTomar.TabStop = false;
            // 
            // RrhhLblVacacionEstado
            // 
            this.RrhhLblVacacionEstado.AutoSize = true;
            this.RrhhLblVacacionEstado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionEstado.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionEstado.Location = new System.Drawing.Point(15, 168);
            this.RrhhLblVacacionEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionEstado.Name = "RrhhLblVacacionEstado";
            this.RrhhLblVacacionEstado.Size = new System.Drawing.Size(50, 16);
            this.RrhhLblVacacionEstado.TabIndex = 8;
            this.RrhhLblVacacionEstado.Text = "Estado:";
            // 
            // RrhhCboVacacionEstado
            // 
            this.RrhhCboVacacionEstado.BackColor = System.Drawing.Color.White;
            this.RrhhCboVacacionEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboVacacionEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboVacacionEstado.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboVacacionEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboVacacionEstado.FormattingEnabled = true;
            this.RrhhCboVacacionEstado.Location = new System.Drawing.Point(168, 165);
            this.RrhhCboVacacionEstado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboVacacionEstado.Name = "RrhhCboVacacionEstado";
            this.RrhhCboVacacionEstado.Size = new System.Drawing.Size(284, 25);
            this.RrhhCboVacacionEstado.TabIndex = 9;
            // 
            // RrhhLblVacacionObservacion
            // 
            this.RrhhLblVacacionObservacion.AutoSize = true;
            this.RrhhLblVacacionObservacion.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblVacacionObservacion.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblVacacionObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblVacacionObservacion.Location = new System.Drawing.Point(15, 212);
            this.RrhhLblVacacionObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblVacacionObservacion.Name = "RrhhLblVacacionObservacion";
            this.RrhhLblVacacionObservacion.Size = new System.Drawing.Size(82, 16);
            this.RrhhLblVacacionObservacion.TabIndex = 10;
            this.RrhhLblVacacionObservacion.Text = "Observación:";
            // 
            // RrhhTxtVacacionObservacion
            // 
            this.RrhhTxtVacacionObservacion.BackColor = System.Drawing.Color.White;
            this.RrhhTxtVacacionObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhTxtVacacionObservacion.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhTxtVacacionObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhTxtVacacionObservacion.Location = new System.Drawing.Point(168, 204);
            this.RrhhTxtVacacionObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhTxtVacacionObservacion.Multiline = true;
            this.RrhhTxtVacacionObservacion.Name = "RrhhTxtVacacionObservacion";
            this.RrhhTxtVacacionObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RrhhTxtVacacionObservacion.Size = new System.Drawing.Size(286, 48);
            this.RrhhTxtVacacionObservacion.TabIndex = 11;
            // 
            // RrhhLblRegistroBloqueado
            // 
            this.RrhhLblRegistroBloqueado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.RrhhLblRegistroBloqueado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhLblRegistroBloqueado.Font = new System.Drawing.Font("Tahoma", 5.67F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblRegistroBloqueado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RrhhLblRegistroBloqueado.Location = new System.Drawing.Point(15, 261);
            this.RrhhLblRegistroBloqueado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblRegistroBloqueado.Name = "RrhhLblRegistroBloqueado";
            this.RrhhLblRegistroBloqueado.Size = new System.Drawing.Size(438, 29);
            this.RrhhLblRegistroBloqueado.TabIndex = 12;
            this.RrhhLblRegistroBloqueado.Text = "Registro bloqueado: aún no cumple un año de servicio.";
            this.RrhhLblRegistroBloqueado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RrhhLblRegistroBloqueado.Visible = false;
            // 
            // RrhhPnlRegistrosVacacion
            // 
            this.RrhhPnlRegistrosVacacion.BackColor = System.Drawing.Color.White;
            this.RrhhPnlRegistrosVacacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhLblTituloRegistrosVacacion);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhLblFiltroVacacionPeriodo);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhCboFiltroVacacionPeriodo);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhLblFiltroVacacionEstado);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhCboFiltroVacacionEstado);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhBtnFiltrarVacacion);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhDgvVacaciones);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhLblMostrandoVacacion);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhBtnPaginaPrimeraVacacion);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhBtnPaginaAnteriorVacacion);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhLblPaginaVacacion);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhBtnPaginaSiguienteVacacion);
            this.RrhhPnlRegistrosVacacion.Controls.Add(this.RrhhBtnPaginaUltimaVacacion);
            this.RrhhPnlRegistrosVacacion.Location = new System.Drawing.Point(6, 370);
            this.RrhhPnlRegistrosVacacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlRegistrosVacacion.Name = "RrhhPnlRegistrosVacacion";
            this.RrhhPnlRegistrosVacacion.Size = new System.Drawing.Size(1460, 364);
            this.RrhhPnlRegistrosVacacion.TabIndex = 1;
            // 
            // RrhhLblTituloRegistrosVacacion
            // 
            this.RrhhLblTituloRegistrosVacacion.AutoSize = true;
            this.RrhhLblTituloRegistrosVacacion.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblTituloRegistrosVacacion.Font = new System.Drawing.Font("Lucida Bright", 8.82F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblTituloRegistrosVacacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblTituloRegistrosVacacion.Location = new System.Drawing.Point(14, 10);
            this.RrhhLblTituloRegistrosVacacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblTituloRegistrosVacacion.Name = "RrhhLblTituloRegistrosVacacion";
            this.RrhhLblTituloRegistrosVacacion.Size = new System.Drawing.Size(220, 20);
            this.RrhhLblTituloRegistrosVacacion.TabIndex = 0;
            this.RrhhLblTituloRegistrosVacacion.Text = "Historial de vacaciones";
            // 
            // RrhhLblFiltroVacacionPeriodo
            // 
            this.RrhhLblFiltroVacacionPeriodo.AutoSize = true;
            this.RrhhLblFiltroVacacionPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblFiltroVacacionPeriodo.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblFiltroVacacionPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblFiltroVacacionPeriodo.Location = new System.Drawing.Point(15, 51);
            this.RrhhLblFiltroVacacionPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblFiltroVacacionPeriodo.Name = "RrhhLblFiltroVacacionPeriodo";
            this.RrhhLblFiltroVacacionPeriodo.Size = new System.Drawing.Size(55, 16);
            this.RrhhLblFiltroVacacionPeriodo.TabIndex = 1;
            this.RrhhLblFiltroVacacionPeriodo.Text = "Período:";
            // 
            // RrhhCboFiltroVacacionPeriodo
            // 
            this.RrhhCboFiltroVacacionPeriodo.BackColor = System.Drawing.Color.White;
            this.RrhhCboFiltroVacacionPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboFiltroVacacionPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboFiltroVacacionPeriodo.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboFiltroVacacionPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboFiltroVacacionPeriodo.FormattingEnabled = true;
            this.RrhhCboFiltroVacacionPeriodo.Location = new System.Drawing.Point(84, 48);
            this.RrhhCboFiltroVacacionPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboFiltroVacacionPeriodo.Name = "RrhhCboFiltroVacacionPeriodo";
            this.RrhhCboFiltroVacacionPeriodo.Size = new System.Drawing.Size(216, 25);
            this.RrhhCboFiltroVacacionPeriodo.TabIndex = 2;
            // 
            // RrhhLblFiltroVacacionEstado
            // 
            this.RrhhLblFiltroVacacionEstado.AutoSize = true;
            this.RrhhLblFiltroVacacionEstado.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblFiltroVacacionEstado.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblFiltroVacacionEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhLblFiltroVacacionEstado.Location = new System.Drawing.Point(330, 51);
            this.RrhhLblFiltroVacacionEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblFiltroVacacionEstado.Name = "RrhhLblFiltroVacacionEstado";
            this.RrhhLblFiltroVacacionEstado.Size = new System.Drawing.Size(50, 16);
            this.RrhhLblFiltroVacacionEstado.TabIndex = 3;
            this.RrhhLblFiltroVacacionEstado.Text = "Estado:";
            // 
            // RrhhCboFiltroVacacionEstado
            // 
            this.RrhhCboFiltroVacacionEstado.BackColor = System.Drawing.Color.White;
            this.RrhhCboFiltroVacacionEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RrhhCboFiltroVacacionEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhCboFiltroVacacionEstado.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhCboFiltroVacacionEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.RrhhCboFiltroVacacionEstado.FormattingEnabled = true;
            this.RrhhCboFiltroVacacionEstado.Location = new System.Drawing.Point(390, 48);
            this.RrhhCboFiltroVacacionEstado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhCboFiltroVacacionEstado.Name = "RrhhCboFiltroVacacionEstado";
            this.RrhhCboFiltroVacacionEstado.Size = new System.Drawing.Size(194, 25);
            this.RrhhCboFiltroVacacionEstado.TabIndex = 4;
            // 
            // RrhhBtnFiltrarVacacion
            // 
            this.RrhhBtnFiltrarVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhBtnFiltrarVacacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnFiltrarVacacion.FlatAppearance.BorderSize = 0;
            this.RrhhBtnFiltrarVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnFiltrarVacacion.Font = new System.Drawing.Font("Segoe UI", 6.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnFiltrarVacacion.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnFiltrarVacacion.Location = new System.Drawing.Point(1299, 45);
            this.RrhhBtnFiltrarVacacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnFiltrarVacacion.Name = "RrhhBtnFiltrarVacacion";
            this.RrhhBtnFiltrarVacacion.Size = new System.Drawing.Size(148, 28);
            this.RrhhBtnFiltrarVacacion.TabIndex = 5;
            this.RrhhBtnFiltrarVacacion.Text = "Filtrar";
            this.RrhhBtnFiltrarVacacion.UseVisualStyleBackColor = false;
            // 
            // RrhhDgvVacaciones
            // 
            this.RrhhDgvVacaciones.AllowUserToAddRows = false;
            this.RrhhDgvVacaciones.AllowUserToDeleteRows = false;
            this.RrhhDgvVacaciones.AllowUserToResizeColumns = false;
            this.RrhhDgvVacaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.RrhhDgvVacaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.RrhhDgvVacaciones.BackgroundColor = System.Drawing.Color.White;
            this.RrhhDgvVacaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RrhhDgvVacaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RrhhDgvVacaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 6.05F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RrhhDgvVacaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.RrhhDgvVacaciones.ColumnHeadersHeight = 19;
            this.RrhhDgvVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RrhhDgvVacaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RrhhColVacacionId,
            this.RrhhColVacacionCodigo,
            this.RrhhColVacacionEmpleado,
            this.RrhhColVacacionPeriodo,
            this.RrhhColVacacionFechaInicio,
            this.RrhhColVacacionFechaFin,
            this.RrhhColVacacionDiasTomados,
            this.RrhhColVacacionDiasRestantes,
            this.RrhhColVacacionObservacion,
            this.RrhhColVacacionEstado});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 6.05F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RrhhDgvVacaciones.DefaultCellStyle = dataGridViewCellStyle13;
            this.RrhhDgvVacaciones.EnableHeadersVisualStyles = false;
            this.RrhhDgvVacaciones.Location = new System.Drawing.Point(15, 82);
            this.RrhhDgvVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhDgvVacaciones.MultiSelect = false;
            this.RrhhDgvVacaciones.Name = "RrhhDgvVacaciones";
            this.RrhhDgvVacaciones.ReadOnly = true;
            this.RrhhDgvVacaciones.RowHeadersVisible = false;
            this.RrhhDgvVacaciones.RowHeadersWidth = 34;
            this.RrhhDgvVacaciones.RowTemplate.Height = 16;
            this.RrhhDgvVacaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RrhhDgvVacaciones.ShowCellToolTips = false;
            this.RrhhDgvVacaciones.Size = new System.Drawing.Size(1431, 240);
            this.RrhhDgvVacaciones.TabIndex = 6;
            // 
            // RrhhColVacacionId
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RrhhColVacacionId.DefaultCellStyle = dataGridViewCellStyle9;
            this.RrhhColVacacionId.HeaderText = "ID";
            this.RrhhColVacacionId.MinimumWidth = 4;
            this.RrhhColVacacionId.Name = "RrhhColVacacionId";
            this.RrhhColVacacionId.ReadOnly = true;
            this.RrhhColVacacionId.Width = 33;
            // 
            // RrhhColVacacionCodigo
            // 
            this.RrhhColVacacionCodigo.HeaderText = "Código";
            this.RrhhColVacacionCodigo.MinimumWidth = 4;
            this.RrhhColVacacionCodigo.Name = "RrhhColVacacionCodigo";
            this.RrhhColVacacionCodigo.ReadOnly = true;
            this.RrhhColVacacionCodigo.Width = 59;
            // 
            // RrhhColVacacionEmpleado
            // 
            this.RrhhColVacacionEmpleado.HeaderText = "Empleado";
            this.RrhhColVacacionEmpleado.MinimumWidth = 4;
            this.RrhhColVacacionEmpleado.Name = "RrhhColVacacionEmpleado";
            this.RrhhColVacacionEmpleado.ReadOnly = true;
            this.RrhhColVacacionEmpleado.Width = 151;
            // 
            // RrhhColVacacionPeriodo
            // 
            this.RrhhColVacacionPeriodo.HeaderText = "Período";
            this.RrhhColVacacionPeriodo.MinimumWidth = 4;
            this.RrhhColVacacionPeriodo.Name = "RrhhColVacacionPeriodo";
            this.RrhhColVacacionPeriodo.ReadOnly = true;
            this.RrhhColVacacionPeriodo.Width = 92;
            // 
            // RrhhColVacacionFechaInicio
            // 
            this.RrhhColVacacionFechaInicio.HeaderText = "Fecha inicio";
            this.RrhhColVacacionFechaInicio.MinimumWidth = 4;
            this.RrhhColVacacionFechaInicio.Name = "RrhhColVacacionFechaInicio";
            this.RrhhColVacacionFechaInicio.ReadOnly = true;
            this.RrhhColVacacionFechaInicio.Width = 79;
            // 
            // RrhhColVacacionFechaFin
            // 
            this.RrhhColVacacionFechaFin.HeaderText = "Fecha fin";
            this.RrhhColVacacionFechaFin.MinimumWidth = 4;
            this.RrhhColVacacionFechaFin.Name = "RrhhColVacacionFechaFin";
            this.RrhhColVacacionFechaFin.ReadOnly = true;
            this.RrhhColVacacionFechaFin.Width = 79;
            // 
            // RrhhColVacacionDiasTomados
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RrhhColVacacionDiasTomados.DefaultCellStyle = dataGridViewCellStyle10;
            this.RrhhColVacacionDiasTomados.HeaderText = "Días tomados";
            this.RrhhColVacacionDiasTomados.MinimumWidth = 4;
            this.RrhhColVacacionDiasTomados.Name = "RrhhColVacacionDiasTomados";
            this.RrhhColVacacionDiasTomados.ReadOnly = true;
            this.RrhhColVacacionDiasTomados.Width = 76;
            // 
            // RrhhColVacacionDiasRestantes
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RrhhColVacacionDiasRestantes.DefaultCellStyle = dataGridViewCellStyle11;
            this.RrhhColVacacionDiasRestantes.HeaderText = "Días restantes";
            this.RrhhColVacacionDiasRestantes.MinimumWidth = 4;
            this.RrhhColVacacionDiasRestantes.Name = "RrhhColVacacionDiasRestantes";
            this.RrhhColVacacionDiasRestantes.ReadOnly = true;
            this.RrhhColVacacionDiasRestantes.Width = 79;
            // 
            // RrhhColVacacionObservacion
            // 
            this.RrhhColVacacionObservacion.HeaderText = "Observación";
            this.RrhhColVacacionObservacion.MinimumWidth = 4;
            this.RrhhColVacacionObservacion.Name = "RrhhColVacacionObservacion";
            this.RrhhColVacacionObservacion.ReadOnly = true;
            this.RrhhColVacacionObservacion.Width = 227;
            // 
            // RrhhColVacacionEstado
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RrhhColVacacionEstado.DefaultCellStyle = dataGridViewCellStyle12;
            this.RrhhColVacacionEstado.HeaderText = "Estado";
            this.RrhhColVacacionEstado.MinimumWidth = 4;
            this.RrhhColVacacionEstado.Name = "RrhhColVacacionEstado";
            this.RrhhColVacacionEstado.ReadOnly = true;
            this.RrhhColVacacionEstado.Width = 80;
            // 
            // RrhhLblMostrandoVacacion
            // 
            this.RrhhLblMostrandoVacacion.AutoSize = true;
            this.RrhhLblMostrandoVacacion.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblMostrandoVacacion.Font = new System.Drawing.Font("Tahoma", 6.05F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblMostrandoVacacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.RrhhLblMostrandoVacacion.Location = new System.Drawing.Point(15, 336);
            this.RrhhLblMostrandoVacacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblMostrandoVacacion.Name = "RrhhLblMostrandoVacacion";
            this.RrhhLblMostrandoVacacion.Size = new System.Drawing.Size(181, 16);
            this.RrhhLblMostrandoVacacion.TabIndex = 7;
            this.RrhhLblMostrandoVacacion.Text = "Mostrando 0 - 0 de 0 registros";
            // 
            // RrhhBtnPaginaPrimeraVacacion
            // 
            this.RrhhBtnPaginaPrimeraVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhBtnPaginaPrimeraVacacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnPaginaPrimeraVacacion.FlatAppearance.BorderSize = 0;
            this.RrhhBtnPaginaPrimeraVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnPaginaPrimeraVacacion.Font = new System.Drawing.Font("Segoe UI", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnPaginaPrimeraVacacion.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnPaginaPrimeraVacacion.Location = new System.Drawing.Point(1233, 332);
            this.RrhhBtnPaginaPrimeraVacacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnPaginaPrimeraVacacion.Name = "RrhhBtnPaginaPrimeraVacacion";
            this.RrhhBtnPaginaPrimeraVacacion.Size = new System.Drawing.Size(32, 27);
            this.RrhhBtnPaginaPrimeraVacacion.TabIndex = 8;
            this.RrhhBtnPaginaPrimeraVacacion.Text = "«";
            this.RrhhBtnPaginaPrimeraVacacion.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnPaginaAnteriorVacacion
            // 
            this.RrhhBtnPaginaAnteriorVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhBtnPaginaAnteriorVacacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnPaginaAnteriorVacacion.FlatAppearance.BorderSize = 0;
            this.RrhhBtnPaginaAnteriorVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnPaginaAnteriorVacacion.Font = new System.Drawing.Font("Segoe UI", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnPaginaAnteriorVacacion.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnPaginaAnteriorVacacion.Location = new System.Drawing.Point(1270, 332);
            this.RrhhBtnPaginaAnteriorVacacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnPaginaAnteriorVacacion.Name = "RrhhBtnPaginaAnteriorVacacion";
            this.RrhhBtnPaginaAnteriorVacacion.Size = new System.Drawing.Size(32, 27);
            this.RrhhBtnPaginaAnteriorVacacion.TabIndex = 9;
            this.RrhhBtnPaginaAnteriorVacacion.Text = "‹";
            this.RrhhBtnPaginaAnteriorVacacion.UseVisualStyleBackColor = false;
            // 
            // RrhhLblPaginaVacacion
            // 
            this.RrhhLblPaginaVacacion.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblPaginaVacacion.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblPaginaVacacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblPaginaVacacion.Location = new System.Drawing.Point(1306, 334);
            this.RrhhLblPaginaVacacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RrhhLblPaginaVacacion.Name = "RrhhLblPaginaVacacion";
            this.RrhhLblPaginaVacacion.Size = new System.Drawing.Size(75, 20);
            this.RrhhLblPaginaVacacion.TabIndex = 10;
            this.RrhhLblPaginaVacacion.Text = "0 de 0";
            this.RrhhLblPaginaVacacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RrhhBtnPaginaSiguienteVacacion
            // 
            this.RrhhBtnPaginaSiguienteVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhBtnPaginaSiguienteVacacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnPaginaSiguienteVacacion.FlatAppearance.BorderSize = 0;
            this.RrhhBtnPaginaSiguienteVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnPaginaSiguienteVacacion.Font = new System.Drawing.Font("Segoe UI", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnPaginaSiguienteVacacion.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnPaginaSiguienteVacacion.Location = new System.Drawing.Point(1386, 332);
            this.RrhhBtnPaginaSiguienteVacacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnPaginaSiguienteVacacion.Name = "RrhhBtnPaginaSiguienteVacacion";
            this.RrhhBtnPaginaSiguienteVacacion.Size = new System.Drawing.Size(32, 27);
            this.RrhhBtnPaginaSiguienteVacacion.TabIndex = 11;
            this.RrhhBtnPaginaSiguienteVacacion.Text = "›";
            this.RrhhBtnPaginaSiguienteVacacion.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnPaginaUltimaVacacion
            // 
            this.RrhhBtnPaginaUltimaVacacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhBtnPaginaUltimaVacacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnPaginaUltimaVacacion.FlatAppearance.BorderSize = 0;
            this.RrhhBtnPaginaUltimaVacacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnPaginaUltimaVacacion.Font = new System.Drawing.Font("Segoe UI", 6.93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnPaginaUltimaVacacion.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnPaginaUltimaVacacion.Location = new System.Drawing.Point(1422, 332);
            this.RrhhBtnPaginaUltimaVacacion.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnPaginaUltimaVacacion.Name = "RrhhBtnPaginaUltimaVacacion";
            this.RrhhBtnPaginaUltimaVacacion.Size = new System.Drawing.Size(32, 27);
            this.RrhhBtnPaginaUltimaVacacion.TabIndex = 12;
            this.RrhhBtnPaginaUltimaVacacion.Text = "»";
            this.RrhhBtnPaginaUltimaVacacion.UseVisualStyleBackColor = false;
            // 
            // RrhhPnlEncabezado
            // 
            this.RrhhPnlEncabezado.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.Pnl_fondo;
            this.RrhhPnlEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhPnlEncabezado.Controls.Add(this.RrhhLblSubTituloPermisosVacaciones);
            this.RrhhPnlEncabezado.Controls.Add(this.RrhhLblTituloPermisosVacaciones);
            this.RrhhPnlEncabezado.Controls.Add(this.RrhhPbIconoPermisosVacaciones);
            this.RrhhPnlEncabezado.Controls.Add(this.RrhhPbMascota);
            this.RrhhPnlEncabezado.Location = new System.Drawing.Point(12, 12);
            this.RrhhPnlEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPnlEncabezado.Name = "RrhhPnlEncabezado";
            this.RrhhPnlEncabezado.Size = new System.Drawing.Size(1492, 145);
            this.RrhhPnlEncabezado.TabIndex = 0;
            // 
            // RrhhLblSubTituloPermisosVacaciones
            // 
            this.RrhhLblSubTituloPermisosVacaciones.AutoSize = true;
            this.RrhhLblSubTituloPermisosVacaciones.BackColor = System.Drawing.Color.Transparent;
            this.RrhhLblSubTituloPermisosVacaciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblSubTituloPermisosVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblSubTituloPermisosVacaciones.Location = new System.Drawing.Point(144, 88);
            this.RrhhLblSubTituloPermisosVacaciones.Name = "RrhhLblSubTituloPermisosVacaciones";
            this.RrhhLblSubTituloPermisosVacaciones.Size = new System.Drawing.Size(716, 29);
            this.RrhhLblSubTituloPermisosVacaciones.TabIndex = 7;
            this.RrhhLblSubTituloPermisosVacaciones.Text = "Registro y Control de Permisos y Vacaciones de los Colaboradores";
            // 
            // RrhhLblTituloPermisosVacaciones
            // 
            this.RrhhLblTituloPermisosVacaciones.AutoSize = true;
            this.RrhhLblTituloPermisosVacaciones.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhLblTituloPermisosVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RrhhLblTituloPermisosVacaciones.Location = new System.Drawing.Point(142, 35);
            this.RrhhLblTituloPermisosVacaciones.Name = "RrhhLblTituloPermisosVacaciones";
            this.RrhhLblTituloPermisosVacaciones.Size = new System.Drawing.Size(398, 37);
            this.RrhhLblTituloPermisosVacaciones.TabIndex = 6;
            this.RrhhLblTituloPermisosVacaciones.Text = "Permisos y Vacaciones";
            // 
            // RrhhPbIconoPermisosVacaciones
            // 
            this.RrhhPbIconoPermisosVacaciones.BackColor = System.Drawing.Color.Transparent;
            this.RrhhPbIconoPermisosVacaciones.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.btn_permisos;
            this.RrhhPbIconoPermisosVacaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhPbIconoPermisosVacaciones.Location = new System.Drawing.Point(16, 12);
            this.RrhhPbIconoPermisosVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPbIconoPermisosVacaciones.Name = "RrhhPbIconoPermisosVacaciones";
            this.RrhhPbIconoPermisosVacaciones.Size = new System.Drawing.Size(119, 118);
            this.RrhhPbIconoPermisosVacaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RrhhPbIconoPermisosVacaciones.TabIndex = 0;
            this.RrhhPbIconoPermisosVacaciones.TabStop = false;
            // 
            // RrhhPbMascota
            // 
            this.RrhhPbMascota.BackColor = System.Drawing.Color.Transparent;
            this.RrhhPbMascota.Image = global::CapaVista_PermisosVacaciones.Properties.Resources._5;
            this.RrhhPbMascota.Location = new System.Drawing.Point(808, 4);
            this.RrhhPbMascota.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhPbMascota.Name = "RrhhPbMascota";
            this.RrhhPbMascota.Size = new System.Drawing.Size(153, 137);
            this.RrhhPbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RrhhPbMascota.TabIndex = 3;
            this.RrhhPbMascota.TabStop = false;
            // 
            // RrhhBtnNuevo
            // 
            this.RrhhBtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(146)))), ((int)(((byte)(161)))));
            this.RrhhBtnNuevo.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.btn_nuevo;
            this.RrhhBtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnNuevo.FlatAppearance.BorderSize = 0;
            this.RrhhBtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnNuevo.Font = new System.Drawing.Font("Segoe UI", 5.67F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnNuevo.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnNuevo.Location = new System.Drawing.Point(12, 165);
            this.RrhhBtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnNuevo.Name = "RrhhBtnNuevo";
            this.RrhhBtnNuevo.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnNuevo.TabIndex = 1;
            this.RrhhBtnNuevo.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnGuardar
            // 
            this.RrhhBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnGuardar.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_guardar_sin_bordes;
            this.RrhhBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnGuardar.FlatAppearance.BorderSize = 0;
            this.RrhhBtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnGuardar.Location = new System.Drawing.Point(118, 165);
            this.RrhhBtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnGuardar.Name = "RrhhBtnGuardar";
            this.RrhhBtnGuardar.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnGuardar.TabIndex = 2;
            this.RrhhBtnGuardar.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnModificar
            // 
            this.RrhhBtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnModificar.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_modificar_sin_bordes;
            this.RrhhBtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnModificar.FlatAppearance.BorderSize = 0;
            this.RrhhBtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnModificar.Location = new System.Drawing.Point(224, 165);
            this.RrhhBtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnModificar.Name = "RrhhBtnModificar";
            this.RrhhBtnModificar.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnModificar.TabIndex = 3;
            this.RrhhBtnModificar.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnEliminar
            // 
            this.RrhhBtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnEliminar.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_eliminar_sin_bordes;
            this.RrhhBtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnEliminar.FlatAppearance.BorderSize = 0;
            this.RrhhBtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnEliminar.Location = new System.Drawing.Point(329, 165);
            this.RrhhBtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnEliminar.Name = "RrhhBtnEliminar";
            this.RrhhBtnEliminar.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnEliminar.TabIndex = 4;
            this.RrhhBtnEliminar.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnCancelar
            // 
            this.RrhhBtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(169)))), ((int)(((byte)(178)))));
            this.RrhhBtnCancelar.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.btn_cancelar;
            this.RrhhBtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnCancelar.FlatAppearance.BorderSize = 0;
            this.RrhhBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnCancelar.Font = new System.Drawing.Font("Segoe UI", 5.67F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnCancelar.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnCancelar.Location = new System.Drawing.Point(434, 165);
            this.RrhhBtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnCancelar.Name = "RrhhBtnCancelar";
            this.RrhhBtnCancelar.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnCancelar.TabIndex = 5;
            this.RrhhBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnRefrescar
            // 
            this.RrhhBtnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnRefrescar.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_refrescar_sin_bordes;
            this.RrhhBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnRefrescar.FlatAppearance.BorderSize = 0;
            this.RrhhBtnRefrescar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnRefrescar.Location = new System.Drawing.Point(539, 165);
            this.RrhhBtnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnRefrescar.Name = "RrhhBtnRefrescar";
            this.RrhhBtnRefrescar.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnRefrescar.TabIndex = 6;
            this.RrhhBtnRefrescar.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnImprimir
            // 
            this.RrhhBtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnImprimir.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_imprimir_sin_bordes;
            this.RrhhBtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnImprimir.FlatAppearance.BorderSize = 0;
            this.RrhhBtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnImprimir.Location = new System.Drawing.Point(645, 165);
            this.RrhhBtnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnImprimir.Name = "RrhhBtnImprimir";
            this.RrhhBtnImprimir.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnImprimir.TabIndex = 7;
            this.RrhhBtnImprimir.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnInicio
            // 
            this.RrhhBtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnInicio.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_inicio_sin_bordes;
            this.RrhhBtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnInicio.FlatAppearance.BorderSize = 0;
            this.RrhhBtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnInicio.Location = new System.Drawing.Point(750, 165);
            this.RrhhBtnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnInicio.Name = "RrhhBtnInicio";
            this.RrhhBtnInicio.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnInicio.TabIndex = 8;
            this.RrhhBtnInicio.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnAnterior
            // 
            this.RrhhBtnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnAnterior.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_anterior_sin_bordes;
            this.RrhhBtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnAnterior.FlatAppearance.BorderSize = 0;
            this.RrhhBtnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnAnterior.Location = new System.Drawing.Point(855, 165);
            this.RrhhBtnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnAnterior.Name = "RrhhBtnAnterior";
            this.RrhhBtnAnterior.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnAnterior.TabIndex = 9;
            this.RrhhBtnAnterior.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnSiguiente
            // 
            this.RrhhBtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnSiguiente.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_siguiente_sin_bordes;
            this.RrhhBtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnSiguiente.FlatAppearance.BorderSize = 0;
            this.RrhhBtnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnSiguiente.Location = new System.Drawing.Point(961, 165);
            this.RrhhBtnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnSiguiente.Name = "RrhhBtnSiguiente";
            this.RrhhBtnSiguiente.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnSiguiente.TabIndex = 10;
            this.RrhhBtnSiguiente.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnFin
            // 
            this.RrhhBtnFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnFin.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_fin_sin_bordes_final;
            this.RrhhBtnFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnFin.FlatAppearance.BorderSize = 0;
            this.RrhhBtnFin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnFin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnFin.Location = new System.Drawing.Point(1067, 165);
            this.RrhhBtnFin.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnFin.Name = "RrhhBtnFin";
            this.RrhhBtnFin.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnFin.TabIndex = 11;
            this.RrhhBtnFin.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnConsultar
            // 
            this.RrhhBtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnConsultar.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_consultar_sin_bordes;
            this.RrhhBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnConsultar.FlatAppearance.BorderSize = 0;
            this.RrhhBtnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnConsultar.Location = new System.Drawing.Point(1176, 165);
            this.RrhhBtnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnConsultar.Name = "RrhhBtnConsultar";
            this.RrhhBtnConsultar.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnConsultar.TabIndex = 12;
            this.RrhhBtnConsultar.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnAyuda
            // 
            this.RrhhBtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(169)))), ((int)(((byte)(178)))));
            this.RrhhBtnAyuda.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.btn_ayuda;
            this.RrhhBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnAyuda.FlatAppearance.BorderSize = 0;
            this.RrhhBtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnAyuda.Font = new System.Drawing.Font("Segoe UI", 5.67F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrhhBtnAyuda.ForeColor = System.Drawing.Color.White;
            this.RrhhBtnAyuda.Location = new System.Drawing.Point(1285, 165);
            this.RrhhBtnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnAyuda.Name = "RrhhBtnAyuda";
            this.RrhhBtnAyuda.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnAyuda.TabIndex = 13;
            this.RrhhBtnAyuda.UseVisualStyleBackColor = false;
            // 
            // RrhhBtnSalir
            // 
            this.RrhhBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnSalir.BackgroundImage = global::CapaVista_PermisosVacaciones.Properties.Resources.boton_salir_sin_bordes;
            this.RrhhBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RrhhBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RrhhBtnSalir.FlatAppearance.BorderSize = 0;
            this.RrhhBtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.RrhhBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RrhhBtnSalir.Location = new System.Drawing.Point(1395, 165);
            this.RrhhBtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.RrhhBtnSalir.Name = "RrhhBtnSalir";
            this.RrhhBtnSalir.Size = new System.Drawing.Size(95, 82);
            this.RrhhBtnSalir.TabIndex = 14;
            this.RrhhBtnSalir.UseVisualStyleBackColor = false;
            // 
            // FrmPermisosVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1516, 966);
            this.Controls.Add(this.RrhhPnlEncabezado);
            this.Controls.Add(this.RrhhBtnNuevo);
            this.Controls.Add(this.RrhhBtnPestañaVacaciones);
            this.Controls.Add(this.RrhhBtnGuardar);
            this.Controls.Add(this.RrhhPnlLineaPestañas);
            this.Controls.Add(this.RrhhBtnPestañaPermisos);
            this.Controls.Add(this.RrhhBtnModificar);
            this.Controls.Add(this.RrhhBtnEliminar);
            this.Controls.Add(this.RrhhBtnCancelar);
            this.Controls.Add(this.RrhhBtnRefrescar);
            this.Controls.Add(this.RrhhBtnImprimir);
            this.Controls.Add(this.RrhhBtnInicio);
            this.Controls.Add(this.RrhhBtnAnterior);
            this.Controls.Add(this.RrhhBtnSiguiente);
            this.Controls.Add(this.RrhhBtnFin);
            this.Controls.Add(this.RrhhBtnConsultar);
            this.Controls.Add(this.RrhhBtnAyuda);
            this.Controls.Add(this.RrhhBtnSalir);
            this.Controls.Add(this.RrhhTabPermisosVacaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPermisosVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9301 - Permisos y Vacaciones";
            this.RrhhTabPermisosVacaciones.ResumeLayout(false);
            this.RrhhTabPagPermisos.ResumeLayout(false);
            this.RrhhPnlDetallePermiso.ResumeLayout(false);
            this.RrhhPnlDetallePermiso.PerformLayout();
            this.RrhhGbxDatosPermiso.ResumeLayout(false);
            this.RrhhGbxDatosPermiso.PerformLayout();
            this.RrhhGbxPeriodoPermiso.ResumeLayout(false);
            this.RrhhGbxPeriodoPermiso.PerformLayout();
            this.RrhhPnlTotalPermiso.ResumeLayout(false);
            this.RrhhPnlTotalPermiso.PerformLayout();
            this.RrhhGbxMotivoPermiso.ResumeLayout(false);
            this.RrhhGbxMotivoPermiso.PerformLayout();
            this.RrhhPnlRegistrosPermiso.ResumeLayout(false);
            this.RrhhPnlRegistrosPermiso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RrhhDgvPermisos)).EndInit();
            this.RrhhTabPagVacaciones.ResumeLayout(false);
            this.RrhhPnlDetalleVacacion.ResumeLayout(false);
            this.RrhhPnlDetalleVacacion.PerformLayout();
            this.RrhhGbxDatosColaborador.ResumeLayout(false);
            this.RrhhGbxDatosColaborador.PerformLayout();
            this.RrhhGbxDerechoVacaciones.ResumeLayout(false);
            this.RrhhGbxDerechoVacaciones.PerformLayout();
            this.RrhhPnlDiasPeriodo.ResumeLayout(false);
            this.RrhhPnlDiasTomados.ResumeLayout(false);
            this.RrhhPnlDiasDisponibles.ResumeLayout(false);
            this.RrhhPnlUsoPista.ResumeLayout(false);
            this.RrhhGbxSolicitudVacaciones.ResumeLayout(false);
            this.RrhhGbxSolicitudVacaciones.PerformLayout();
            this.RrhhPnlRegistrosVacacion.ResumeLayout(false);
            this.RrhhPnlRegistrosVacacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RrhhDgvVacaciones)).EndInit();
            this.RrhhPnlEncabezado.ResumeLayout(false);
            this.RrhhPnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RrhhPbIconoPermisosVacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RrhhPbMascota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RrhhPnlEncabezado;
        private System.Windows.Forms.Button RrhhBtnNuevo;
        private System.Windows.Forms.Button RrhhBtnGuardar;
        private System.Windows.Forms.Button RrhhBtnModificar;
        private System.Windows.Forms.Button RrhhBtnEliminar;
        private System.Windows.Forms.Button RrhhBtnCancelar;
        private System.Windows.Forms.Button RrhhBtnRefrescar;
        private System.Windows.Forms.Button RrhhBtnImprimir;
        private System.Windows.Forms.Button RrhhBtnInicio;
        private System.Windows.Forms.Button RrhhBtnAnterior;
        private System.Windows.Forms.Button RrhhBtnSiguiente;
        private System.Windows.Forms.Button RrhhBtnFin;
        private System.Windows.Forms.Button RrhhBtnConsultar;
        private System.Windows.Forms.Button RrhhBtnAyuda;
        private System.Windows.Forms.Button RrhhBtnSalir;
        private System.Windows.Forms.PictureBox RrhhPbIconoPermisosVacaciones;
        private System.Windows.Forms.PictureBox RrhhPbMascota;
        private System.Windows.Forms.Button RrhhBtnPestañaPermisos;
        private System.Windows.Forms.Button RrhhBtnPestañaVacaciones;
        private System.Windows.Forms.Panel RrhhPnlLineaPestañas;
        private System.Windows.Forms.TabControl RrhhTabPermisosVacaciones;
        private System.Windows.Forms.TabPage RrhhTabPagPermisos;
        private System.Windows.Forms.TabPage RrhhTabPagVacaciones;
        private System.Windows.Forms.Panel RrhhPnlDetallePermiso;
        private System.Windows.Forms.Label RrhhLblTituloDetallePermiso;
        private System.Windows.Forms.GroupBox RrhhGbxDatosPermiso;
        private System.Windows.Forms.Label RrhhLblPermisoEmpleado;
        private System.Windows.Forms.Label RrhhLblAsteriscoPermisoEmpleado;
        private System.Windows.Forms.ComboBox RrhhCboPermisoEmpleado;
        private System.Windows.Forms.Label RrhhLblPermisoDepartamento;
        private System.Windows.Forms.TextBox RrhhTxtPermisoDepartamento;
        private System.Windows.Forms.Label RrhhLblPermisoPuesto;
        private System.Windows.Forms.TextBox RrhhTxtPermisoPuesto;
        private System.Windows.Forms.Label RrhhLblPermisoTipo;
        private System.Windows.Forms.Label RrhhLblAsteriscoPermisoTipo;
        private System.Windows.Forms.ComboBox RrhhCboPermisoTipo;
        private System.Windows.Forms.Label RrhhLblPermisoEstado;
        private System.Windows.Forms.ComboBox RrhhCboPermisoEstado;
        private System.Windows.Forms.Label RrhhLblNotaDatosPermiso;
        private System.Windows.Forms.GroupBox RrhhGbxPeriodoPermiso;
        private System.Windows.Forms.Label RrhhLblPermisoFechaInicio;
        private System.Windows.Forms.Label RrhhLblAsteriscoPermisoFechaInicio;
        private System.Windows.Forms.DateTimePicker RrhhDtpPermisoFechaInicio;
        private System.Windows.Forms.Label RrhhLblPermisoFechaFin;
        private System.Windows.Forms.Label RrhhLblAsteriscoPermisoFechaFin;
        private System.Windows.Forms.DateTimePicker RrhhDtpPermisoFechaFin;
        private System.Windows.Forms.Label RrhhLblPermisoCalcularEn;
        private System.Windows.Forms.RadioButton RrhhRdbPermisoDias;
        private System.Windows.Forms.RadioButton RrhhRdbPermisoHoras;
        private System.Windows.Forms.Label RrhhLblPermisoHorario;
        private System.Windows.Forms.DateTimePicker RrhhDtpPermisoHoraInicio;
        private System.Windows.Forms.DateTimePicker RrhhDtpPermisoHoraFin;
        private System.Windows.Forms.Panel RrhhPnlTotalPermiso;
        private System.Windows.Forms.Label RrhhLblTotalPermisoTexto;
        private System.Windows.Forms.Label RrhhLblNotaTotalPermiso;
        private System.Windows.Forms.Label RrhhLblTotalPermisoValor;
        private System.Windows.Forms.GroupBox RrhhGbxMotivoPermiso;
        private System.Windows.Forms.Label RrhhLblPermisoMotivo;
        private System.Windows.Forms.Label RrhhLblAsteriscoPermisoMotivo;
        private System.Windows.Forms.TextBox RrhhTxtPermisoMotivo;
        private System.Windows.Forms.Label RrhhLblContadorMotivo;
        private System.Windows.Forms.Panel RrhhPnlRegistrosPermiso;
        private System.Windows.Forms.Label RrhhLblTituloRegistrosPermiso;
        private System.Windows.Forms.Label RrhhLblFiltroPermisoEmpleado;
        private System.Windows.Forms.TextBox RrhhTxtFiltroPermisoEmpleado;
        private System.Windows.Forms.Label RrhhLblFiltroPermisoTipo;
        private System.Windows.Forms.ComboBox RrhhCboFiltroPermisoTipo;
        private System.Windows.Forms.Label RrhhLblFiltroPermisoEstado;
        private System.Windows.Forms.ComboBox RrhhCboFiltroPermisoEstado;
        private System.Windows.Forms.Button RrhhBtnFiltrarPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColPermisoEstado;
        private System.Windows.Forms.DataGridView RrhhDgvPermisos;
        private System.Windows.Forms.Panel RrhhPnlDetalleVacacion;
        private System.Windows.Forms.Label RrhhLblTituloDetalleVacacion;
        private System.Windows.Forms.GroupBox RrhhGbxDatosColaborador;
        private System.Windows.Forms.Label RrhhLblVacacionEmpleado;
        private System.Windows.Forms.Label RrhhLblAsteriscoVacacionEmpleado;
        private System.Windows.Forms.ComboBox RrhhCboVacacionEmpleado;
        private System.Windows.Forms.Label RrhhLblVacacionDepartamento;
        private System.Windows.Forms.TextBox RrhhTxtVacacionDepartamento;
        private System.Windows.Forms.Label RrhhLblVacacionPuesto;
        private System.Windows.Forms.TextBox RrhhTxtVacacionPuesto;
        private System.Windows.Forms.Label RrhhLblVacacionFechaContratacion;
        private System.Windows.Forms.TextBox RrhhTxtVacacionFechaContratacion;
        private System.Windows.Forms.Label RrhhLblVacacionTiempoLaborado;
        private System.Windows.Forms.TextBox RrhhTxtVacacionTiempoLaborado;
        private System.Windows.Forms.Label RrhhLblNotaDatosColaborador;
        private System.Windows.Forms.GroupBox RrhhGbxDerechoVacaciones;
        private System.Windows.Forms.Label RrhhLblIndicadorDerecho;
        private System.Windows.Forms.Label RrhhLblLeyendaDerecho;
        private System.Windows.Forms.Panel RrhhPnlDiasPeriodo;
        private System.Windows.Forms.Label RrhhLblDiasPeriodoValor;
        private System.Windows.Forms.Label RrhhLblDiasPeriodoTexto;
        private System.Windows.Forms.Panel RrhhPnlDiasTomados;
        private System.Windows.Forms.Label RrhhLblDiasTomadosValor;
        private System.Windows.Forms.Label RrhhLblDiasTomadosTexto;
        private System.Windows.Forms.Panel RrhhPnlDiasDisponibles;
        private System.Windows.Forms.Label RrhhLblDiasDisponiblesValor;
        private System.Windows.Forms.Label RrhhLblDiasDisponiblesTexto;
        private System.Windows.Forms.Label RrhhLblUsoPeriodo;
        private System.Windows.Forms.Label RrhhLblUsoPeriodoValor;
        private System.Windows.Forms.Panel RrhhPnlUsoPista;
        private System.Windows.Forms.Panel RrhhPnlUsoRelleno;
        private System.Windows.Forms.Label RrhhLblNotaUsoPeriodo;
        private System.Windows.Forms.GroupBox RrhhGbxSolicitudVacaciones;
        private System.Windows.Forms.Label RrhhLblVacacionFechaInicio;
        private System.Windows.Forms.Label RrhhLblAsteriscoVacacionFechaInicio;
        private System.Windows.Forms.DateTimePicker RrhhDtpVacacionFechaInicio;
        private System.Windows.Forms.Label RrhhLblVacacionFechaFin;
        private System.Windows.Forms.Label RrhhLblAsteriscoVacacionFechaFin;
        private System.Windows.Forms.DateTimePicker RrhhDtpVacacionFechaFin;
        private System.Windows.Forms.Label RrhhLblVacacionDiasTomar;
        private System.Windows.Forms.TextBox RrhhTxtVacacionDiasTomar;
        private System.Windows.Forms.Label RrhhLblVacacionEstado;
        private System.Windows.Forms.ComboBox RrhhCboVacacionEstado;
        private System.Windows.Forms.Label RrhhLblVacacionObservacion;
        private System.Windows.Forms.TextBox RrhhTxtVacacionObservacion;
        private System.Windows.Forms.Label RrhhLblRegistroBloqueado;
        private System.Windows.Forms.Panel RrhhPnlRegistrosVacacion;
        private System.Windows.Forms.Label RrhhLblTituloRegistrosVacacion;
        private System.Windows.Forms.Label RrhhLblFiltroVacacionPeriodo;
        private System.Windows.Forms.ComboBox RrhhCboFiltroVacacionPeriodo;
        private System.Windows.Forms.Label RrhhLblFiltroVacacionEstado;
        private System.Windows.Forms.ComboBox RrhhCboFiltroVacacionEstado;
        private System.Windows.Forms.Button RrhhBtnFiltrarVacacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionDiasTomados;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionDiasRestantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RrhhColVacacionEstado;
        private System.Windows.Forms.DataGridView RrhhDgvVacaciones;
        private System.Windows.Forms.Label RrhhLblMostrandoVacacion;
        private System.Windows.Forms.Button RrhhBtnPaginaPrimeraVacacion;
        private System.Windows.Forms.Button RrhhBtnPaginaAnteriorVacacion;
        private System.Windows.Forms.Label RrhhLblPaginaVacacion;
        private System.Windows.Forms.Button RrhhBtnPaginaSiguienteVacacion;
        private System.Windows.Forms.Button RrhhBtnPaginaUltimaVacacion;
        private System.Windows.Forms.Label RrhhLblSubTituloPermisosVacaciones;
        private System.Windows.Forms.Label RrhhLblTituloPermisosVacaciones;
    }
}
