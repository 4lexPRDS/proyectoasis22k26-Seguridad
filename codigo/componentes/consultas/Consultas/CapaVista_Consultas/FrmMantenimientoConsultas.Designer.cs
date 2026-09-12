namespace CapaVista_Consultas
{
    partial class FrmMantenimientoConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoConsultas));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasGbxCondicionesLogicas = new CapaVista_Consultas.Components.ClsGrupoConsultas();
            this.condicionesOrdenamientoAgrupacion1 = new CapaVista_Consultas.UserControls.UcCondicionesOrdenamientoAgrupacion();
            this.filtrosAplicados1 = new CapaVista_Consultas.UcFiltrosAplicados();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxCondicionesLogicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxCondicionesLogicas, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.filtrosAplicados1, 1, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 1;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(981, 292);
            this.ConsultasTlpPrincipal.TabIndex = 16;
            // 
            // ConsultasGbxCondicionesLogicas
            // 
            this.ConsultasGbxCondicionesLogicas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxCondicionesLogicas.Controls.Add(this.condicionesOrdenamientoAgrupacion1);
            this.ConsultasGbxCondicionesLogicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxCondicionesLogicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxCondicionesLogicas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxCondicionesLogicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxCondicionesLogicas.Location = new System.Drawing.Point(3, 3);
            this.ConsultasGbxCondicionesLogicas.Name = "ConsultasGbxCondicionesLogicas";
            this.ConsultasGbxCondicionesLogicas.Size = new System.Drawing.Size(386, 286);
            this.ConsultasGbxCondicionesLogicas.TabIndex = 16;
            this.ConsultasGbxCondicionesLogicas.TabStop = false;
            this.ConsultasGbxCondicionesLogicas.Text = "Agregar Condición";
            // 
            // condicionesOrdenamientoAgrupacion1
            // 
            this.condicionesOrdenamientoAgrupacion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.condicionesOrdenamientoAgrupacion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.condicionesOrdenamientoAgrupacion1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.condicionesOrdenamientoAgrupacion1.Location = new System.Drawing.Point(3, 24);
            this.condicionesOrdenamientoAgrupacion1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.condicionesOrdenamientoAgrupacion1.Name = "condicionesOrdenamientoAgrupacion1";
            this.condicionesOrdenamientoAgrupacion1.Size = new System.Drawing.Size(380, 259);
            this.condicionesOrdenamientoAgrupacion1.TabIndex = 1;
            // 
            // filtrosAplicados1
            // 
            this.filtrosAplicados1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.filtrosAplicados1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtrosAplicados1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filtrosAplicados1.Location = new System.Drawing.Point(392, 0);
            this.filtrosAplicados1.Margin = new System.Windows.Forms.Padding(0);
            this.filtrosAplicados1.Name = "filtrosAplicados1";
            this.filtrosAplicados1.Size = new System.Drawing.Size(589, 292);
            this.filtrosAplicados1.TabIndex = 17;
            // 
            // FrmMantenimientoConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(981, 292);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMantenimientoConsultas";
            this.Text = "FrmMantenimientoConsultas";
            this.TopMost = true;
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasGbxCondicionesLogicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Components.ClsGrupoConsultas ConsultasGbxCondicionesLogicas;
        private UserControls.UcCondicionesOrdenamientoAgrupacion condicionesOrdenamientoAgrupacion1;
        private UcFiltrosAplicados filtrosAplicados1;
    }
}