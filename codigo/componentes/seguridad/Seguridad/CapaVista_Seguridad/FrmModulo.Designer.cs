namespace CapaVista_Seguridad
{
    partial class FrmModulo
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label SeguridadLblIdModulo, SeguridadLblNombreModulo, SeguridadLblDescripcion, SeguridadLblEstado;
        // ¡Cambiamos TextBox a ComboBox!
        private System.Windows.Forms.ComboBox SeguridadCmbIdModulo, SeguridadCmbNombreModulo, SeguridadCmbDescripcion;
        private System.Windows.Forms.CheckBox SeguridadChkEstado;
        private System.Windows.Forms.DataGridView SeguridadDgvModulos;
        private System.Windows.Forms.FlowLayoutPanel pnlBarraHerramientas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModulo));
            this.pnlBarraHerramientas = new System.Windows.Forms.FlowLayoutPanel();
            this.SeguridadLblIdModulo = new System.Windows.Forms.Label();
            this.SeguridadCmbIdModulo = new System.Windows.Forms.ComboBox();
            this.SeguridadLblNombreModulo = new System.Windows.Forms.Label();
            this.SeguridadCmbNombreModulo = new System.Windows.Forms.ComboBox();
            this.SeguridadLblDescripcion = new System.Windows.Forms.Label();
            this.SeguridadCmbDescripcion = new System.Windows.Forms.ComboBox();
            this.SeguridadLblEstado = new System.Windows.Forms.Label();
            this.SeguridadChkEstado = new System.Windows.Forms.CheckBox();
            this.SeguridadDgvModulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraHerramientas
            // 
            this.pnlBarraHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraHerramientas.Name = "pnlBarraHerramientas";
            this.pnlBarraHerramientas.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBarraHerramientas.Size = new System.Drawing.Size(1004, 85);
            this.pnlBarraHerramientas.TabIndex = 0;
            this.pnlBarraHerramientas.WrapContents = false;
            // 
            // SeguridadLblIdModulo
            // 
            this.SeguridadLblIdModulo.AutoSize = true;
            this.SeguridadLblIdModulo.Location = new System.Drawing.Point(20, 103);
            this.SeguridadLblIdModulo.Name = "SeguridadLblIdModulo";
            this.SeguridadLblIdModulo.Size = new System.Drawing.Size(72, 16);
            this.SeguridadLblIdModulo.TabIndex = 1;
            this.SeguridadLblIdModulo.Text = "Id Modulo :";
            // 
            // SeguridadCmbIdModulo
            // 
            this.SeguridadCmbIdModulo.Location = new System.Drawing.Point(115, 100);
            this.SeguridadCmbIdModulo.Name = "SeguridadCmbIdModulo";
            this.SeguridadCmbIdModulo.Size = new System.Drawing.Size(100, 24);
            this.SeguridadCmbIdModulo.TabIndex = 2;
            // 
            // SeguridadLblNombreModulo
            // 
            this.SeguridadLblNombreModulo.AutoSize = true;
            this.SeguridadLblNombreModulo.Location = new System.Drawing.Point(240, 103);
            this.SeguridadLblNombreModulo.Name = "SeguridadLblNombreModulo";
            this.SeguridadLblNombreModulo.Size = new System.Drawing.Size(110, 16);
            this.SeguridadLblNombreModulo.TabIndex = 3;
            this.SeguridadLblNombreModulo.Text = "Nombre Modulo :";
            // 
            // SeguridadCmbNombreModulo
            // 
            this.SeguridadCmbNombreModulo.Location = new System.Drawing.Point(355, 100);
            this.SeguridadCmbNombreModulo.Name = "SeguridadCmbNombreModulo";
            this.SeguridadCmbNombreModulo.Size = new System.Drawing.Size(180, 24);
            this.SeguridadCmbNombreModulo.TabIndex = 4;
            // 
            // SeguridadLblDescripcion
            // 
            this.SeguridadLblDescripcion.AutoSize = true;
            this.SeguridadLblDescripcion.Location = new System.Drawing.Point(560, 103);
            this.SeguridadLblDescripcion.Name = "SeguridadLblDescripcion";
            this.SeguridadLblDescripcion.Size = new System.Drawing.Size(85, 16);
            this.SeguridadLblDescripcion.TabIndex = 5;
            this.SeguridadLblDescripcion.Text = "Descripción :";
            // 
            // SeguridadCmbDescripcion
            // 
            this.SeguridadCmbDescripcion.Location = new System.Drawing.Point(655, 100);
            this.SeguridadCmbDescripcion.Name = "SeguridadCmbDescripcion";
            this.SeguridadCmbDescripcion.Size = new System.Drawing.Size(190, 24);
            this.SeguridadCmbDescripcion.TabIndex = 6;
            // 
            // SeguridadLblEstado
            // 
            this.SeguridadLblEstado.AutoSize = true;
            this.SeguridadLblEstado.Location = new System.Drawing.Point(865, 103);
            this.SeguridadLblEstado.Name = "SeguridadLblEstado";
            this.SeguridadLblEstado.Size = new System.Drawing.Size(56, 16);
            this.SeguridadLblEstado.TabIndex = 7;
            this.SeguridadLblEstado.Text = "Estado :";
            // 
            // SeguridadChkEstado
            // 
            this.SeguridadChkEstado.AutoSize = true;
            this.SeguridadChkEstado.Location = new System.Drawing.Point(925, 102);
            this.SeguridadChkEstado.Name = "SeguridadChkEstado";
            this.SeguridadChkEstado.Size = new System.Drawing.Size(15, 14);
            this.SeguridadChkEstado.TabIndex = 8;
            // 
            // SeguridadDgvModulos
            // 
            this.SeguridadDgvModulos.AllowUserToAddRows = false;
            this.SeguridadDgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeguridadDgvModulos.Location = new System.Drawing.Point(20, 160);
            this.SeguridadDgvModulos.Name = "SeguridadDgvModulos";
            this.SeguridadDgvModulos.ReadOnly = true;
            this.SeguridadDgvModulos.RowHeadersWidth = 30;
            this.SeguridadDgvModulos.Size = new System.Drawing.Size(960, 320);
            this.SeguridadDgvModulos.TabIndex = 9;
            // 
            // FrmModulo
            // 
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.pnlBarraHerramientas);
            this.Controls.Add(this.SeguridadLblIdModulo);
            this.Controls.Add(this.SeguridadCmbIdModulo);
            this.Controls.Add(this.SeguridadLblNombreModulo);
            this.Controls.Add(this.SeguridadCmbNombreModulo);
            this.Controls.Add(this.SeguridadLblDescripcion);
            this.Controls.Add(this.SeguridadCmbDescripcion);
            this.Controls.Add(this.SeguridadLblEstado);
            this.Controls.Add(this.SeguridadChkEstado);
            this.Controls.Add(this.SeguridadDgvModulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2006 - Mantenimiento Modulo";
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvModulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}