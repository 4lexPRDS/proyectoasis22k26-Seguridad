namespace CapaVista_Seguridad
{
    partial class FrmMantenimientoUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoUsuarios));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.SeguridadCboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.SeguridadTxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.SeguridadTxtContrasena = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.SeguridadTxtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.pnlIngresoDatos = new System.Windows.Forms.Panel();
            this.SeguridadChkMostrarContra = new System.Windows.Forms.CheckBox();
            this.SeguridadChkActivo = new System.Windows.Forms.CheckBox();
            this.SeguridadTxtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SeguridadDgvUsuarios = new System.Windows.Forms.DataGridView();
            this.SeguridadBtnModificar = new System.Windows.Forms.Button();
            this.SeguridadBtnSalir = new System.Windows.Forms.Button();
            this.SeguridadBtnReporte = new System.Windows.Forms.Button();
            this.SeguridadBtnLimpiar = new System.Windows.Forms.Button();
            this.SeguridadBtnGuardar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeguridadBtnConsultar = new System.Windows.Forms.Button();
            this.SeguridadTxtConsultar = new System.Windows.Forms.TextBox();
            this.SeguridadBtnRefrescar = new System.Windows.Forms.Button();
            this.SeguridadBtnInicio = new System.Windows.Forms.Button();
            this.SeguridadBtnAnterior = new System.Windows.Forms.Button();
            this.SeguridadBtnSiguiente = new System.Windows.Forms.Button();
            this.SeguridadBtnFin = new System.Windows.Forms.Button();
            this.pnlIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(200, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Usuario";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblEmpleado.Location = new System.Drawing.Point(58, 24);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(73, 17);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // SeguridadCboEmpleado
            // 
            this.SeguridadCboEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.SeguridadCboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeguridadCboEmpleado.FormattingEnabled = true;
            this.SeguridadCboEmpleado.Location = new System.Drawing.Point(217, 24);
            this.SeguridadCboEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadCboEmpleado.Name = "SeguridadCboEmpleado";
            this.SeguridadCboEmpleado.Size = new System.Drawing.Size(288, 21);
            this.SeguridadCboEmpleado.TabIndex = 3;
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblIdEmpleado.Location = new System.Drawing.Point(58, 54);
            this.lblIdEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(85, 17);
            this.lblIdEmpleado.TabIndex = 4;
            this.lblIdEmpleado.Text = "Id Empleado";
            // 
            // SeguridadTxtIdEmpleado
            // 
            this.SeguridadTxtIdEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.SeguridadTxtIdEmpleado.Enabled = false;
            this.SeguridadTxtIdEmpleado.Location = new System.Drawing.Point(216, 54);
            this.SeguridadTxtIdEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadTxtIdEmpleado.Name = "SeguridadTxtIdEmpleado";
            this.SeguridadTxtIdEmpleado.ReadOnly = true;
            this.SeguridadTxtIdEmpleado.Size = new System.Drawing.Size(61, 20);
            this.SeguridadTxtIdEmpleado.TabIndex = 5;
            this.SeguridadTxtIdEmpleado.TabStop = false;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblContrasena.Location = new System.Drawing.Point(58, 124);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(81, 17);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // SeguridadTxtContrasena
            // 
            this.SeguridadTxtContrasena.BackColor = System.Drawing.Color.White;
            this.SeguridadTxtContrasena.Location = new System.Drawing.Point(217, 124);
            this.SeguridadTxtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadTxtContrasena.Name = "SeguridadTxtContrasena";
            this.SeguridadTxtContrasena.PasswordChar = '*';
            this.SeguridadTxtContrasena.Size = new System.Drawing.Size(217, 20);
            this.SeguridadTxtContrasena.TabIndex = 7;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(54, 151);
            this.lblConfirmarContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(152, 34);
            this.lblConfirmarContrasena.TabIndex = 8;
            this.lblConfirmarContrasena.Text = "Confirmar Contraseña:";
            this.lblConfirmarContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirmarContrasena.UseCompatibleTextRendering = true;
            // 
            // SeguridadTxtConfirmarContrasena
            // 
            this.SeguridadTxtConfirmarContrasena.BackColor = System.Drawing.Color.White;
            this.SeguridadTxtConfirmarContrasena.Location = new System.Drawing.Point(217, 160);
            this.SeguridadTxtConfirmarContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadTxtConfirmarContrasena.Name = "SeguridadTxtConfirmarContrasena";
            this.SeguridadTxtConfirmarContrasena.PasswordChar = '*';
            this.SeguridadTxtConfirmarContrasena.Size = new System.Drawing.Size(217, 20);
            this.SeguridadTxtConfirmarContrasena.TabIndex = 9;
            // 
            // pnlIngresoDatos
            // 
            this.pnlIngresoDatos.BackColor = System.Drawing.Color.OldLace;
            this.pnlIngresoDatos.Controls.Add(this.SeguridadChkMostrarContra);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadChkActivo);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtUsuario);
            this.pnlIngresoDatos.Controls.Add(this.lblUsuario);
            this.pnlIngresoDatos.Controls.Add(this.lblEstado);
            this.pnlIngresoDatos.Controls.Add(this.lblEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.pictureBox2);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadCboEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.lblIdEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtIdEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtContrasena);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtConfirmarContrasena);
            this.pnlIngresoDatos.Controls.Add(this.lblContrasena);
            this.pnlIngresoDatos.Controls.Add(this.lblConfirmarContrasena);
            this.pnlIngresoDatos.Location = new System.Drawing.Point(226, 107);
            this.pnlIngresoDatos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIngresoDatos.Name = "pnlIngresoDatos";
            this.pnlIngresoDatos.Size = new System.Drawing.Size(716, 247);
            this.pnlIngresoDatos.TabIndex = 16;
            // 
            // SeguridadChkMostrarContra
            // 
            this.SeguridadChkMostrarContra.AutoSize = true;
            this.SeguridadChkMostrarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadChkMostrarContra.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadChkMostrarContra.Location = new System.Drawing.Point(439, 124);
            this.SeguridadChkMostrarContra.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadChkMostrarContra.Name = "SeguridadChkMostrarContra";
            this.SeguridadChkMostrarContra.Size = new System.Drawing.Size(47, 21);
            this.SeguridadChkMostrarContra.TabIndex = 15;
            this.SeguridadChkMostrarContra.Text = "👁 ";
            this.SeguridadChkMostrarContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeguridadChkMostrarContra.UseVisualStyleBackColor = true;
            this.SeguridadChkMostrarContra.CheckedChanged += new System.EventHandler(this.SeguridadChkMostrarContra_CheckedChanged);
            // 
            // SeguridadChkActivo
            // 
            this.SeguridadChkActivo.AutoSize = true;
            this.SeguridadChkActivo.Checked = true;
            this.SeguridadChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SeguridadChkActivo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SeguridadChkActivo.ForeColor = System.Drawing.Color.DimGray;
            this.SeguridadChkActivo.Location = new System.Drawing.Point(217, 209);
            this.SeguridadChkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadChkActivo.Name = "SeguridadChkActivo";
            this.SeguridadChkActivo.Size = new System.Drawing.Size(65, 21);
            this.SeguridadChkActivo.TabIndex = 14;
            this.SeguridadChkActivo.Text = "Activo";
            // 
            // SeguridadTxtUsuario
            // 
            this.SeguridadTxtUsuario.Location = new System.Drawing.Point(216, 84);
            this.SeguridadTxtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadTxtUsuario.Name = "SeguridadTxtUsuario";
            this.SeguridadTxtUsuario.Size = new System.Drawing.Size(283, 20);
            this.SeguridadTxtUsuario.TabIndex = 13;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUsuario.Location = new System.Drawing.Point(58, 84);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 17);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblEstado.Location = new System.Drawing.Point(64, 209);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(49, 17);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaVista_Seguridad.Properties.Resources._5;
            this.pictureBox2.Location = new System.Drawing.Point(538, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // SeguridadDgvUsuarios
            // 
            this.SeguridadDgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeguridadDgvUsuarios.Location = new System.Drawing.Point(308, 374);
            this.SeguridadDgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadDgvUsuarios.Name = "SeguridadDgvUsuarios";
            this.SeguridadDgvUsuarios.RowHeadersWidth = 51;
            this.SeguridadDgvUsuarios.RowTemplate.Height = 24;
            this.SeguridadDgvUsuarios.Size = new System.Drawing.Size(561, 176);
            this.SeguridadDgvUsuarios.TabIndex = 21;
            this.SeguridadDgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeguridadDgvUsuarios_CellContentClick);
            // 
            // SeguridadBtnModificar
            // 
            this.SeguridadBtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnModificar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_modificarN;
            this.SeguridadBtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnModificar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnModificar.Location = new System.Drawing.Point(293, 42);
            this.SeguridadBtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnModificar.Name = "SeguridadBtnModificar";
            this.SeguridadBtnModificar.Size = new System.Drawing.Size(60, 60);
            this.SeguridadBtnModificar.TabIndex = 20;
            this.SeguridadBtnModificar.UseVisualStyleBackColor = false;
            this.SeguridadBtnModificar.Click += new System.EventHandler(this.SeguridadBtnModificar_Click);
            // 
            // SeguridadBtnSalir
            // 
            this.SeguridadBtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnSalir.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_salirN;
            this.SeguridadBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnSalir.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnSalir.Location = new System.Drawing.Point(421, 42);
            this.SeguridadBtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnSalir.Name = "SeguridadBtnSalir";
            this.SeguridadBtnSalir.Size = new System.Drawing.Size(60, 60);
            this.SeguridadBtnSalir.TabIndex = 14;
            this.SeguridadBtnSalir.UseVisualStyleBackColor = false;
            this.SeguridadBtnSalir.Click += new System.EventHandler(this.SeguridadBtnSalir_Click);
            // 
            // SeguridadBtnReporte
            // 
            this.SeguridadBtnReporte.BackColor = System.Drawing.Color.White;
            this.SeguridadBtnReporte.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_reporte;
            this.SeguridadBtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnReporte.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnReporte.Location = new System.Drawing.Point(11, 78);
            this.SeguridadBtnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnReporte.Name = "SeguridadBtnReporte";
            this.SeguridadBtnReporte.Size = new System.Drawing.Size(68, 70);
            this.SeguridadBtnReporte.TabIndex = 11;
            this.SeguridadBtnReporte.UseVisualStyleBackColor = false;
            this.SeguridadBtnReporte.Click += new System.EventHandler(this.SeguridadBtnReporte_Click);
            // 
            // SeguridadBtnLimpiar
            // 
            this.SeguridadBtnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnLimpiar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_eliminarN;
            this.SeguridadBtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnLimpiar.Location = new System.Drawing.Point(357, 42);
            this.SeguridadBtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnLimpiar.Name = "SeguridadBtnLimpiar";
            this.SeguridadBtnLimpiar.Size = new System.Drawing.Size(60, 60);
            this.SeguridadBtnLimpiar.TabIndex = 13;
            this.SeguridadBtnLimpiar.UseVisualStyleBackColor = false;
            this.SeguridadBtnLimpiar.Click += new System.EventHandler(this.SeguridadBtnLimpiar_Click);
            // 
            // SeguridadBtnGuardar
            // 
            this.SeguridadBtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnGuardar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_guardarN;
            this.SeguridadBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnGuardar.Location = new System.Drawing.Point(229, 42);
            this.SeguridadBtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnGuardar.Name = "SeguridadBtnGuardar";
            this.SeguridadBtnGuardar.Size = new System.Drawing.Size(60, 60);
            this.SeguridadBtnGuardar.TabIndex = 12;
            this.SeguridadBtnGuardar.UseVisualStyleBackColor = false;
            this.SeguridadBtnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_ayudaN;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(11, 11);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(68, 63);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CapaVista_Seguridad.Properties.Resources.fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 652);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // SeguridadBtnConsultar
            // 
            this.SeguridadBtnConsultar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_consultarN;
            this.SeguridadBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SeguridadBtnConsultar.Location = new System.Drawing.Point(886, 37);
            this.SeguridadBtnConsultar.Name = "SeguridadBtnConsultar";
            this.SeguridadBtnConsultar.Size = new System.Drawing.Size(42, 40);
            this.SeguridadBtnConsultar.TabIndex = 22;
            this.SeguridadBtnConsultar.UseVisualStyleBackColor = true;
            // 
            // SeguridadTxtConsultar
            // 
            this.SeguridadTxtConsultar.Location = new System.Drawing.Point(934, 53);
            this.SeguridadTxtConsultar.Name = "SeguridadTxtConsultar";
            this.SeguridadTxtConsultar.Size = new System.Drawing.Size(134, 20);
            this.SeguridadTxtConsultar.TabIndex = 23;
            // 
            // SeguridadBtnRefrescar
            // 
            this.SeguridadBtnRefrescar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_refrescarN;
            this.SeguridadBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnRefrescar.Location = new System.Drawing.Point(486, 42);
            this.SeguridadBtnRefrescar.Name = "SeguridadBtnRefrescar";
            this.SeguridadBtnRefrescar.Size = new System.Drawing.Size(59, 60);
            this.SeguridadBtnRefrescar.TabIndex = 24;
            this.SeguridadBtnRefrescar.UseVisualStyleBackColor = true;
            // 
            // SeguridadBtnInicio
            // 
            this.SeguridadBtnInicio.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_inicioN;
            this.SeguridadBtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnInicio.Location = new System.Drawing.Point(551, 42);
            this.SeguridadBtnInicio.Name = "SeguridadBtnInicio";
            this.SeguridadBtnInicio.Size = new System.Drawing.Size(58, 60);
            this.SeguridadBtnInicio.TabIndex = 25;
            this.SeguridadBtnInicio.UseVisualStyleBackColor = true;
            // 
            // SeguridadBtnAnterior
            // 
            this.SeguridadBtnAnterior.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_anteriorN;
            this.SeguridadBtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnAnterior.Location = new System.Drawing.Point(615, 42);
            this.SeguridadBtnAnterior.Name = "SeguridadBtnAnterior";
            this.SeguridadBtnAnterior.Size = new System.Drawing.Size(58, 60);
            this.SeguridadBtnAnterior.TabIndex = 26;
            this.SeguridadBtnAnterior.UseVisualStyleBackColor = true;
            // 
            // SeguridadBtnSiguiente
            // 
            this.SeguridadBtnSiguiente.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_siguienteN;
            this.SeguridadBtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnSiguiente.Location = new System.Drawing.Point(679, 42);
            this.SeguridadBtnSiguiente.Name = "SeguridadBtnSiguiente";
            this.SeguridadBtnSiguiente.Size = new System.Drawing.Size(58, 60);
            this.SeguridadBtnSiguiente.TabIndex = 27;
            this.SeguridadBtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // SeguridadBtnFin
            // 
            this.SeguridadBtnFin.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_finN;
            this.SeguridadBtnFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnFin.Location = new System.Drawing.Point(743, 42);
            this.SeguridadBtnFin.Name = "SeguridadBtnFin";
            this.SeguridadBtnFin.Size = new System.Drawing.Size(58, 60);
            this.SeguridadBtnFin.TabIndex = 28;
            this.SeguridadBtnFin.UseVisualStyleBackColor = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 652);
            this.Controls.Add(this.SeguridadBtnFin);
            this.Controls.Add(this.SeguridadBtnSiguiente);
            this.Controls.Add(this.SeguridadBtnAnterior);
            this.Controls.Add(this.SeguridadBtnInicio);
            this.Controls.Add(this.SeguridadBtnRefrescar);
            this.Controls.Add(this.SeguridadTxtConsultar);
            this.Controls.Add(this.SeguridadBtnConsultar);
            this.Controls.Add(this.SeguridadDgvUsuarios);
            this.Controls.Add(this.SeguridadBtnModificar);
            this.Controls.Add(this.SeguridadBtnSalir);
            this.Controls.Add(this.SeguridadBtnReporte);
            this.Controls.Add(this.SeguridadBtnLimpiar);
            this.Controls.Add(this.SeguridadBtnGuardar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlIngresoDatos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2005 - Crear Usuario";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.pnlIngresoDatos.ResumeLayout(false);
            this.pnlIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox SeguridadCboEmpleado;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.TextBox SeguridadTxtIdEmpleado;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox SeguridadTxtContrasena;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private System.Windows.Forms.TextBox SeguridadTxtConfirmarContrasena;
        private System.Windows.Forms.Button SeguridadBtnReporte;
        private System.Windows.Forms.Button SeguridadBtnGuardar;
        private System.Windows.Forms.Button SeguridadBtnLimpiar;
        private System.Windows.Forms.Button SeguridadBtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlIngresoDatos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button SeguridadBtnModificar;
        private System.Windows.Forms.DataGridView SeguridadDgvUsuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox SeguridadTxtUsuario;
        private System.Windows.Forms.CheckBox SeguridadChkActivo;
        private System.Windows.Forms.CheckBox SeguridadChkMostrarContra;
        private System.Windows.Forms.Button SeguridadBtnConsultar;
        private System.Windows.Forms.TextBox SeguridadTxtConsultar;
        private System.Windows.Forms.Button SeguridadBtnRefrescar;
        private System.Windows.Forms.Button SeguridadBtnInicio;
        private System.Windows.Forms.Button SeguridadBtnAnterior;
        private System.Windows.Forms.Button SeguridadBtnSiguiente;
        private System.Windows.Forms.Button SeguridadBtnFin;
    }
}
