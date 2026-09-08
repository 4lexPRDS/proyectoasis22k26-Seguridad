namespace CapaVista_Seguridad
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.pnlIngresoDatos = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(227, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(192, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Usuario";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblEmpleado.Location = new System.Drawing.Point(16, 30);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(95, 23);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(136, 30);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(382, 24);
            this.cboEmpleado.TabIndex = 3;
            this.cboEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboIdEmpleado_SelectedIndexChanged);
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblIdEmpleado.Location = new System.Drawing.Point(16, 67);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(111, 23);
            this.lblIdEmpleado.TabIndex = 4;
            this.lblIdEmpleado.Text = "Id Empleado";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Location = new System.Drawing.Point(136, 67);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.ReadOnly = true;
            this.txtIdEmpleado.Size = new System.Drawing.Size(80, 22);
            this.txtIdEmpleado.TabIndex = 5;
            this.txtIdEmpleado.TabStop = false;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblContrasena.Location = new System.Drawing.Point(16, 152);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(104, 23);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.Location = new System.Drawing.Point(136, 152);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(384, 22);
            this.txtContrasena.TabIndex = 7;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(16, 192);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(112, 42);
            this.lblConfirmarContrasena.TabIndex = 8;
            this.lblConfirmarContrasena.Text = "Confirmar Contraseña:";
            this.lblConfirmarContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirmarContrasena.UseCompatibleTextRendering = true;
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.BackColor = System.Drawing.Color.White;
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(136, 208);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(376, 22);
            this.txtConfirmarContrasena.TabIndex = 9;
            // 
            // pnlIngresoDatos
            // 
            this.pnlIngresoDatos.BackColor = System.Drawing.Color.OldLace;
            this.pnlIngresoDatos.Controls.Add(this.txtUsuario);
            this.pnlIngresoDatos.Controls.Add(this.lblUsuario);
            this.pnlIngresoDatos.Controls.Add(this.lblEstado);
            this.pnlIngresoDatos.Controls.Add(this.cboEstado);
            this.pnlIngresoDatos.Controls.Add(this.lblEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.cboEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.lblIdEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.txtIdEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.txtContrasena);
            this.pnlIngresoDatos.Controls.Add(this.txtConfirmarContrasena);
            this.pnlIngresoDatos.Controls.Add(this.lblContrasena);
            this.pnlIngresoDatos.Controls.Add(this.lblConfirmarContrasena);
            this.pnlIngresoDatos.Location = new System.Drawing.Point(224, 80);
            this.pnlIngresoDatos.Name = "pnlIngresoDatos";
            this.pnlIngresoDatos.Size = new System.Drawing.Size(541, 304);
            this.pnlIngresoDatos.TabIndex = 16;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(136, 104);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(376, 22);
            this.txtUsuario.TabIndex = 13;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUsuario.Location = new System.Drawing.Point(16, 104);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 23);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblEstado.Location = new System.Drawing.Point(24, 262);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 23);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.SystemColors.Control;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(144, 262);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(88, 24);
            this.cboEstado.TabIndex = 11;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(72, 424);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(752, 216);
            this.dgvUsuarios.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_modificarN;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(840, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 75);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_salirN;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(840, 488);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 68);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_reporte;
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(840, 72);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(65, 70);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_eliminarN;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(840, 368);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(65, 75);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_guardarN;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(840, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 72);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaVista_Seguridad.Properties.Resources._5;
            this.pictureBox2.Location = new System.Drawing.Point(72, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_ayudaN;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(5, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(41, 42);
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
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 665);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlIngresoDatos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2002-CrearUsuario";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.pnlIngresoDatos.ResumeLayout(false);
            this.pnlIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlIngresoDatos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}
