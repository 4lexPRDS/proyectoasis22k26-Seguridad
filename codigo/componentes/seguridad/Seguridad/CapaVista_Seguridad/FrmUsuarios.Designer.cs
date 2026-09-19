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
            this.SeguridadCboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.SeguridadTxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.SeguridadTxtContrasena = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.SeguridadTxtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.pnlIngresoDatos = new System.Windows.Forms.Panel();
            this.SeguridadChkActivo = new System.Windows.Forms.CheckBox();
            this.SeguridadTxtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SeguridadDgvUsuarios = new System.Windows.Forms.DataGridView();
            this.SeguridadBtnModificar = new System.Windows.Forms.Button();
            this.SeguridadBtnSalir = new System.Windows.Forms.Button();
            this.SeguridadBtnReporte = new System.Windows.Forms.Button();
            this.SeguridadBtnLimpiar = new System.Windows.Forms.Button();
            this.SeguridadBtnGuardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeguridadChkMostrarContra = new System.Windows.Forms.CheckBox();
            this.pnlIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvUsuarios)).BeginInit();
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
            // SeguridadCboEmpleado
            // 
            this.SeguridadCboEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.SeguridadCboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeguridadCboEmpleado.FormattingEnabled = true;
            this.SeguridadCboEmpleado.Location = new System.Drawing.Point(136, 30);
            this.SeguridadCboEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadCboEmpleado.Name = "SeguridadCboEmpleado";
            this.SeguridadCboEmpleado.Size = new System.Drawing.Size(383, 24);
            this.SeguridadCboEmpleado.TabIndex = 3;
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblIdEmpleado.Location = new System.Drawing.Point(16, 66);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(111, 23);
            this.lblIdEmpleado.TabIndex = 4;
            this.lblIdEmpleado.Text = "Id Empleado";
            // 
            // SeguridadTxtIdEmpleado
            // 
            this.SeguridadTxtIdEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.SeguridadTxtIdEmpleado.Enabled = false;
            this.SeguridadTxtIdEmpleado.Location = new System.Drawing.Point(136, 66);
            this.SeguridadTxtIdEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadTxtIdEmpleado.Name = "SeguridadTxtIdEmpleado";
            this.SeguridadTxtIdEmpleado.ReadOnly = true;
            this.SeguridadTxtIdEmpleado.Size = new System.Drawing.Size(80, 22);
            this.SeguridadTxtIdEmpleado.TabIndex = 5;
            this.SeguridadTxtIdEmpleado.TabStop = false;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblContrasena.Location = new System.Drawing.Point(16, 153);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(104, 23);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // SeguridadTxtContrasena
            // 
            this.SeguridadTxtContrasena.BackColor = System.Drawing.Color.White;
            this.SeguridadTxtContrasena.Location = new System.Drawing.Point(136, 153);
            this.SeguridadTxtContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadTxtContrasena.Name = "SeguridadTxtContrasena";
            this.SeguridadTxtContrasena.PasswordChar = '*';
            this.SeguridadTxtContrasena.Size = new System.Drawing.Size(288, 22);
            this.SeguridadTxtContrasena.TabIndex = 7;
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
            // SeguridadTxtConfirmarContrasena
            // 
            this.SeguridadTxtConfirmarContrasena.BackColor = System.Drawing.Color.White;
            this.SeguridadTxtConfirmarContrasena.Location = new System.Drawing.Point(136, 208);
            this.SeguridadTxtConfirmarContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadTxtConfirmarContrasena.Name = "SeguridadTxtConfirmarContrasena";
            this.SeguridadTxtConfirmarContrasena.PasswordChar = '*';
            this.SeguridadTxtConfirmarContrasena.Size = new System.Drawing.Size(288, 22);
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
            this.pnlIngresoDatos.Controls.Add(this.SeguridadCboEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.lblIdEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtIdEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtContrasena);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtConfirmarContrasena);
            this.pnlIngresoDatos.Controls.Add(this.lblContrasena);
            this.pnlIngresoDatos.Controls.Add(this.lblConfirmarContrasena);
            this.pnlIngresoDatos.Location = new System.Drawing.Point(224, 80);
            this.pnlIngresoDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIngresoDatos.Name = "pnlIngresoDatos";
            this.pnlIngresoDatos.Size = new System.Drawing.Size(584, 304);
            this.pnlIngresoDatos.TabIndex = 16;
            // 
            // SeguridadChkActivo
            // 
            this.SeguridadChkActivo.AutoSize = true;
            this.SeguridadChkActivo.Checked = true;
            this.SeguridadChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SeguridadChkActivo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SeguridadChkActivo.ForeColor = System.Drawing.Color.DimGray;
            this.SeguridadChkActivo.Location = new System.Drawing.Point(104, 264);
            this.SeguridadChkActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadChkActivo.Name = "SeguridadChkActivo";
            this.SeguridadChkActivo.Size = new System.Drawing.Size(78, 25);
            this.SeguridadChkActivo.TabIndex = 14;
            this.SeguridadChkActivo.Text = "Activo";
            // 
            // SeguridadTxtUsuario
            // 
            this.SeguridadTxtUsuario.Location = new System.Drawing.Point(136, 103);
            this.SeguridadTxtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadTxtUsuario.Name = "SeguridadTxtUsuario";
            this.SeguridadTxtUsuario.Size = new System.Drawing.Size(376, 22);
            this.SeguridadTxtUsuario.TabIndex = 13;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUsuario.Location = new System.Drawing.Point(16, 103);
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
            // SeguridadDgvUsuarios
            // 
            this.SeguridadDgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeguridadDgvUsuarios.Location = new System.Drawing.Point(72, 423);
            this.SeguridadDgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadDgvUsuarios.Name = "SeguridadDgvUsuarios";
            this.SeguridadDgvUsuarios.RowHeadersWidth = 51;
            this.SeguridadDgvUsuarios.RowTemplate.Height = 24;
            this.SeguridadDgvUsuarios.Size = new System.Drawing.Size(752, 217);
            this.SeguridadDgvUsuarios.TabIndex = 21;
            // 
            // SeguridadBtnModificar
            // 
            this.SeguridadBtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnModificar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_modificarN;
            this.SeguridadBtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnModificar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnModificar.Location = new System.Drawing.Point(825, 240);
            this.SeguridadBtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnModificar.Name = "SeguridadBtnModificar";
            this.SeguridadBtnModificar.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnModificar.TabIndex = 20;
            this.SeguridadBtnModificar.UseVisualStyleBackColor = false;
            // 
            // SeguridadBtnSalir
            // 
            this.SeguridadBtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnSalir.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_salirN;
            this.SeguridadBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnSalir.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnSalir.Location = new System.Drawing.Point(840, 487);
            this.SeguridadBtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnSalir.Name = "SeguridadBtnSalir";
            this.SeguridadBtnSalir.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnSalir.TabIndex = 14;
            this.SeguridadBtnSalir.UseVisualStyleBackColor = false;
            // 
            // SeguridadBtnReporte
            // 
            this.SeguridadBtnReporte.BackColor = System.Drawing.Color.White;
            this.SeguridadBtnReporte.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_reporte;
            this.SeguridadBtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnReporte.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnReporte.Location = new System.Drawing.Point(825, 62);
            this.SeguridadBtnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnReporte.Name = "SeguridadBtnReporte";
            this.SeguridadBtnReporte.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnReporte.TabIndex = 11;
            this.SeguridadBtnReporte.UseVisualStyleBackColor = false;
            // 
            // SeguridadBtnLimpiar
            // 
            this.SeguridadBtnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnLimpiar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_eliminarN;
            this.SeguridadBtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnLimpiar.Location = new System.Drawing.Point(825, 325);
            this.SeguridadBtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnLimpiar.Name = "SeguridadBtnLimpiar";
            this.SeguridadBtnLimpiar.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnLimpiar.TabIndex = 13;
            this.SeguridadBtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // SeguridadBtnGuardar
            // 
            this.SeguridadBtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnGuardar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_guardarN;
            this.SeguridadBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnGuardar.Location = new System.Drawing.Point(825, 158);
            this.SeguridadBtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnGuardar.Name = "SeguridadBtnGuardar";
            this.SeguridadBtnGuardar.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnGuardar.TabIndex = 12;
            this.SeguridadBtnGuardar.UseVisualStyleBackColor = false;
            this.SeguridadBtnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaVista_Seguridad.Properties.Resources._5;
            this.pictureBox2.Location = new System.Drawing.Point(72, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(5, 2);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(41, 42);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CapaVista_Seguridad.Properties.Resources.fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // SeguridadChkMostrarContra
            // 
            this.SeguridadChkMostrarContra.AutoSize = true;
            this.SeguridadChkMostrarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadChkMostrarContra.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadChkMostrarContra.Location = new System.Drawing.Point(432, 152);
            this.SeguridadChkMostrarContra.Name = "SeguridadChkMostrarContra";
            this.SeguridadChkMostrarContra.Size = new System.Drawing.Size(52, 24);
            this.SeguridadChkMostrarContra.TabIndex = 15;
            this.SeguridadChkMostrarContra.Text = "👁 ";
            this.SeguridadChkMostrarContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeguridadChkMostrarContra.UseVisualStyleBackColor = true;
            this.SeguridadChkMostrarContra.CheckedChanged += new System.EventHandler(this.SeguridadChkMostrarContra_CheckedChanged);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 665);
            this.Controls.Add(this.SeguridadDgvUsuarios);
            this.Controls.Add(this.SeguridadBtnModificar);
            this.Controls.Add(this.SeguridadBtnSalir);
            this.Controls.Add(this.SeguridadBtnReporte);
            this.Controls.Add(this.SeguridadBtnLimpiar);
            this.Controls.Add(this.SeguridadBtnGuardar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlIngresoDatos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2005 - Crear Usuario";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.pnlIngresoDatos.ResumeLayout(false);
            this.pnlIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}
