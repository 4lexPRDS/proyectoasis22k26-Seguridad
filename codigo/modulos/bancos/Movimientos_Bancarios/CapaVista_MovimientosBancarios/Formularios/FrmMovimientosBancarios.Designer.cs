namespace CapaVista_MovimientosBancarios.Formularios
{
    partial class FrmMovimientosBancarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimientosBancarios));
            this.BancosPnlFondo = new System.Windows.Forms.Panel();
            this.BancosScContenedor = new System.Windows.Forms.SplitContainer();
            this.BancosPbLogo = new System.Windows.Forms.PictureBox();
            this.BancosBtnMovimientos = new System.Windows.Forms.Button();
            this.BancosBtnLista = new System.Windows.Forms.Button();
            this.BancosBtnCheques = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BancosPnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BancosScContenedor)).BeginInit();
            this.BancosScContenedor.Panel1.SuspendLayout();
            this.BancosScContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BancosPbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BancosPnlFondo
            // 
            this.BancosPnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.BancosPnlFondo.Controls.Add(this.BancosScContenedor);
            this.BancosPnlFondo.Location = new System.Drawing.Point(0, 0);
            this.BancosPnlFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BancosPnlFondo.Name = "BancosPnlFondo";
            this.BancosPnlFondo.Size = new System.Drawing.Size(1385, 782);
            this.BancosPnlFondo.TabIndex = 0;
            // 
            // BancosScContenedor
            // 
            this.BancosScContenedor.Location = new System.Drawing.Point(16, 15);
            this.BancosScContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BancosScContenedor.Name = "BancosScContenedor";
            // 
            // BancosScContenedor.Panel1
            // 
            this.BancosScContenedor.Panel1.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.movbac_navegador;
            this.BancosScContenedor.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosScContenedor.Panel1.Controls.Add(this.BancosPbLogo);
            this.BancosScContenedor.Panel1.Controls.Add(this.BancosBtnMovimientos);
            this.BancosScContenedor.Panel1.Controls.Add(this.BancosBtnLista);
            this.BancosScContenedor.Panel1.Controls.Add(this.BancosBtnCheques);
            // 
            // BancosScContenedor.Panel2
            // 
            this.BancosScContenedor.Panel2.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.movbac_contenedor;
            this.BancosScContenedor.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosScContenedor.Size = new System.Drawing.Size(1355, 752);
            this.BancosScContenedor.SplitterDistance = 361;
            this.BancosScContenedor.SplitterWidth = 5;
            this.BancosScContenedor.TabIndex = 3;
            // 
            // BancosPbLogo
            // 
            this.BancosPbLogo.BackColor = System.Drawing.Color.Transparent;
            this.BancosPbLogo.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.bancos_logo;
            this.BancosPbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosPbLogo.Location = new System.Drawing.Point(89, 4);
            this.BancosPbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BancosPbLogo.Name = "BancosPbLogo";
            this.BancosPbLogo.Size = new System.Drawing.Size(177, 156);
            this.BancosPbLogo.TabIndex = 3;
            this.BancosPbLogo.TabStop = false;
            // 
            // BancosBtnMovimientos
            // 
            this.BancosBtnMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.BancosBtnMovimientos.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.movbac_btn2;
            this.BancosBtnMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnMovimientos.FlatAppearance.BorderSize = 0;
            this.BancosBtnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BancosBtnMovimientos.Location = new System.Drawing.Point(13, 226);
            this.BancosBtnMovimientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BancosBtnMovimientos.Name = "BancosBtnMovimientos";
            this.BancosBtnMovimientos.Size = new System.Drawing.Size(352, 60);
            this.BancosBtnMovimientos.TabIndex = 1;
            this.BancosBtnMovimientos.UseVisualStyleBackColor = false;
            this.BancosBtnMovimientos.Click += new System.EventHandler(this.BancosBtnMovimientos_Click);
            // 
            // BancosBtnLista
            // 
            this.BancosBtnLista.BackColor = System.Drawing.Color.Transparent;
            this.BancosBtnLista.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.movbac_btn1;
            this.BancosBtnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnLista.FlatAppearance.BorderSize = 0;
            this.BancosBtnLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BancosBtnLista.Location = new System.Drawing.Point(13, 159);
            this.BancosBtnLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BancosBtnLista.Name = "BancosBtnLista";
            this.BancosBtnLista.Size = new System.Drawing.Size(352, 60);
            this.BancosBtnLista.TabIndex = 0;
            this.BancosBtnLista.UseVisualStyleBackColor = false;
            this.BancosBtnLista.Click += new System.EventHandler(this.BancosBtnLista_Click);
            // 
            // BancosBtnCheques
            // 
            this.BancosBtnCheques.BackColor = System.Drawing.Color.Transparent;
            this.BancosBtnCheques.BackgroundImage = global::CapaVista_MovimientosBancarios.Properties.Resources.movbac_btn3;
            this.BancosBtnCheques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BancosBtnCheques.FlatAppearance.BorderSize = 0;
            this.BancosBtnCheques.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BancosBtnCheques.Location = new System.Drawing.Point(13, 294);
            this.BancosBtnCheques.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BancosBtnCheques.Name = "BancosBtnCheques";
            this.BancosBtnCheques.Size = new System.Drawing.Size(352, 60);
            this.BancosBtnCheques.TabIndex = 2;
            this.BancosBtnCheques.UseVisualStyleBackColor = false;
            this.BancosBtnCheques.Click += new System.EventHandler(this.BancosBtnCheques_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(283, 38);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FrmMovimientosBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 782);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BancosPnlFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMovimientosBancarios";
            this.Text = "8001 - Movimientos Bancarios";
            this.Load += new System.EventHandler(this.FrmMovimientosBancarios_Load);
            this.BancosPnlFondo.ResumeLayout(false);
            this.BancosScContenedor.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BancosScContenedor)).EndInit();
            this.BancosScContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BancosPbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BancosPnlFondo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BancosBtnCheques;
        private System.Windows.Forms.Button BancosBtnMovimientos;
        private System.Windows.Forms.Button BancosBtnLista;
        private System.Windows.Forms.SplitContainer BancosScContenedor;
        private System.Windows.Forms.PictureBox BancosPbLogo;
    }
}