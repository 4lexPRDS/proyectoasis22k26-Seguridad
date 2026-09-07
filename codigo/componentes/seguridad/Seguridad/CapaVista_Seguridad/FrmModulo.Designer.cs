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
            this.SuspendLayout();

            // ... (Configuración del Formulario y Panel se mantiene igual) ...
            this.Name = "FrmModulo";
            this.Text = "2004 - MantenimientoModulo";
            this.MaximizeBox = false;
            this.Size = new System.Drawing.Size(1020, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlBarraHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraHerramientas.Height = 85;
            this.pnlBarraHerramientas.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBarraHerramientas.WrapContents = false;

            // Configuración de los ComboBox (con DropDown para permitir escribir)
            this.SeguridadLblIdModulo.Location = new System.Drawing.Point(20, 103);
            this.SeguridadLblIdModulo.AutoSize = true;
            this.SeguridadLblIdModulo.Text = "Id Modulo :";

            this.SeguridadCmbIdModulo.Location = new System.Drawing.Point(115, 100);
            this.SeguridadCmbIdModulo.Width = 100;
            this.SeguridadCmbIdModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown; // Permite escribir

            this.SeguridadLblNombreModulo.Location = new System.Drawing.Point(240, 103);
            this.SeguridadLblNombreModulo.AutoSize = true;
            this.SeguridadLblNombreModulo.Text = "Nombre Modulo :";

            this.SeguridadCmbNombreModulo.Location = new System.Drawing.Point(355, 100);
            this.SeguridadCmbNombreModulo.Width = 180;
            this.SeguridadCmbNombreModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            this.SeguridadLblDescripcion.Location = new System.Drawing.Point(560, 103);
            this.SeguridadLblDescripcion.AutoSize = true;
            this.SeguridadLblDescripcion.Text = "Descripción :";

            this.SeguridadCmbDescripcion.Location = new System.Drawing.Point(655, 100);
            this.SeguridadCmbDescripcion.Width = 190;
            this.SeguridadCmbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            this.SeguridadLblEstado.Location = new System.Drawing.Point(865, 103);
            this.SeguridadLblEstado.AutoSize = true;
            this.SeguridadLblEstado.Text = "Estado :";

            this.SeguridadChkEstado.Location = new System.Drawing.Point(925, 102);
            this.SeguridadChkEstado.AutoSize = true;

            // ... (Configuración del DataGridView se mantiene igual) ...
            this.SeguridadDgvModulos.Name = "SeguridadDgvModulos";
            this.SeguridadDgvModulos.Location = new System.Drawing.Point(20, 160);
            this.SeguridadDgvModulos.Size = new System.Drawing.Size(960, 320);
            this.SeguridadDgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeguridadDgvModulos.AllowUserToAddRows = false;
            this.SeguridadDgvModulos.ReadOnly = true;
            this.SeguridadDgvModulos.RowHeadersWidth = 30;

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

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}