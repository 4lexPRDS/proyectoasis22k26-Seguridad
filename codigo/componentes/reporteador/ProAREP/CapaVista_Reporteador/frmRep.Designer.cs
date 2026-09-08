namespace CapaVista_Reporteador
{
    partial class frmRep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReportes = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblNomRep = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtNomRep = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnVerRep = new System.Windows.Forms.Button();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAplFil = new System.Windows.Forms.Button();
            this.dtgRep = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRep)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(413, 54);
            this.lblReportes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(163, 39);
            this.lblReportes.TabIndex = 0;
            this.lblReportes.Text = "Reportes";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(71, 114);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(161, 25);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Ruta de reportes:";
            // 
            // lblNomRep
            // 
            this.lblNomRep.AutoSize = true;
            this.lblNomRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRep.Location = new System.Drawing.Point(71, 170);
            this.lblNomRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomRep.Name = "lblNomRep";
            this.lblNomRep.Size = new System.Drawing.Size(184, 25);
            this.lblNomRep.TabIndex = 2;
            this.lblNomRep.Text = "Nombre del reporte:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(284, 113);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(495, 22);
            this.txtRuta.TabIndex = 3;
            this.txtRuta.Text = "Ubicacion del archivo";
            // 
            // txtNomRep
            // 
            this.txtNomRep.Location = new System.Drawing.Point(284, 172);
            this.txtNomRep.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomRep.Name = "txtNomRep";
            this.txtNomRep.Size = new System.Drawing.Size(495, 22);
            this.txtNomRep.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(107, 262);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 42);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(283, 262);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 42);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(468, 262);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 42);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(653, 262);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 42);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Teal;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(840, 262);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(125, 42);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.Teal;
            this.btnRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuta.ForeColor = System.Drawing.Color.White;
            this.btnRuta.Location = new System.Drawing.Point(869, 97);
            this.btnRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(125, 42);
            this.btnRuta.TabIndex = 10;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.UseVisualStyleBackColor = false;
            // 
            // btnVerRep
            // 
            this.btnVerRep.BackColor = System.Drawing.Color.Teal;
            this.btnVerRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRep.ForeColor = System.Drawing.Color.White;
            this.btnVerRep.Location = new System.Drawing.Point(827, 156);
            this.btnVerRep.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerRep.Name = "btnVerRep";
            this.btnVerRep.Size = new System.Drawing.Size(168, 41);
            this.btnVerRep.TabIndex = 11;
            this.btnVerRep.Text = "Ver Reporte";
            this.btnVerRep.UseVisualStyleBackColor = false;
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(336, 315);
            this.txtBus.Margin = new System.Windows.Forms.Padding(4);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(379, 22);
            this.txtBus.TabIndex = 14;
            this.txtBus.Text = "Colocar el nombre del reporte";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(336, 343);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(379, 22);
            this.dtpFecha.TabIndex = 15;
            this.dtpFecha.Value = new System.DateTime(2026, 9, 3, 8, 9, 53, 0);
            // 
            // btnAplFil
            // 
            this.btnAplFil.BackColor = System.Drawing.Color.Teal;
            this.btnAplFil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplFil.ForeColor = System.Drawing.Color.White;
            this.btnAplFil.Location = new System.Drawing.Point(747, 322);
            this.btnAplFil.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplFil.Name = "btnAplFil";
            this.btnAplFil.Size = new System.Drawing.Size(157, 43);
            this.btnAplFil.TabIndex = 16;
            this.btnAplFil.Text = "Aplicar filtro";
            this.btnAplFil.UseVisualStyleBackColor = false;
            this.btnAplFil.Click += new System.EventHandler(this.btnAplFil_Click);
            // 
            // dtgRep
            // 
            this.dtgRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRep.Location = new System.Drawing.Point(76, 430);
            this.dtgRep.Margin = new System.Windows.Forms.Padding(4);
            this.dtgRep.Name = "dtgRep";
            this.dtgRep.RowHeadersWidth = 51;
            this.dtgRep.Size = new System.Drawing.Size(919, 124);
            this.dtgRep.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 33);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buscar.ColumnWidth = 436;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.FormattingEnabled = true;
            this.buscar.HorizontalScrollbar = true;
            this.buscar.Items.AddRange(new object[] {
            "Buscar por nombre",
            "Buscar por fecha"});
            this.buscar.Location = new System.Drawing.Point(132, 319);
            this.buscar.MultiColumn = true;
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(197, 46);
            this.buscar.TabIndex = 20;
            // 
            // frmRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 629);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgRep);
            this.Controls.Add(this.btnAplFil);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnVerRep);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNomRep);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblNomRep);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblReportes);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRep)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblNomRep;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox txtNomRep;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnVerRep;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAplFil;
        private System.Windows.Forms.DataGridView dtgRep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox buscar;
    }
}