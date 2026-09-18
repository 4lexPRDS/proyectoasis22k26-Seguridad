using System.Windows.Forms;
using System.Drawing;


namespace CapaVista_Navegador
{
    partial class FrmCrud
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrud));
            this.NavegadorBtnIngresar = new System.Windows.Forms.Button();
            this.NavegadorIlImagenes = new System.Windows.Forms.ImageList(this.components);
            this.NavegadorBtnCancelar = new System.Windows.Forms.Button();
            this.NavegadorBtnModificar = new System.Windows.Forms.Button();
            this.NavegadorBtnImprimir = new System.Windows.Forms.Button();
            this.NavegadorBtnGuardar = new System.Windows.Forms.Button();
            this.NavegadorBtnSiguiente = new System.Windows.Forms.Button();
            this.NavegadorBtnAnterior = new System.Windows.Forms.Button();
            this.NavegadorBtnInicio = new System.Windows.Forms.Button();
            this.NavegadorBtnEliminar = new System.Windows.Forms.Button();
            this.NavegadorBtnConsultar = new System.Windows.Forms.Button();
            this.NavegadorBtnSalir = new System.Windows.Forms.Button();
            this.NavegadorBtnFin = new System.Windows.Forms.Button();
            this.NavegadorBtnRefrescar = new System.Windows.Forms.Button();
            this.NavegadorBtnAyuda = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // NavegadorBtnIngresar
            // 
            this.NavegadorBtnIngresar.ImageIndex = 0;
            this.NavegadorBtnIngresar.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnIngresar.Location = new System.Drawing.Point(12, 24);
            this.NavegadorBtnIngresar.Name = "NavegadorBtnIngresar";
            this.NavegadorBtnIngresar.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnIngresar.TabIndex = 0;
            this.NavegadorBtnIngresar.UseVisualStyleBackColor = true;
            this.NavegadorBtnIngresar.Click += new System.EventHandler(this.NavegadorMetIngresarClick);
            // 
            // NavegadorIlImagenes
            // 
            this.NavegadorIlImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NavegadorIlImagenes.ImageStream")));
            this.NavegadorIlImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.NavegadorIlImagenes.Images.SetKeyName(0, "ingresar.png");
            this.NavegadorIlImagenes.Images.SetKeyName(1, "cancelar.png");
            this.NavegadorIlImagenes.Images.SetKeyName(2, "consultar.png");
            this.NavegadorIlImagenes.Images.SetKeyName(3, "eliminar.png");
            this.NavegadorIlImagenes.Images.SetKeyName(4, "Fin.png");
            this.NavegadorIlImagenes.Images.SetKeyName(5, "Guardar.png");
            this.NavegadorIlImagenes.Images.SetKeyName(6, "icono aterior.png");
            this.NavegadorIlImagenes.Images.SetKeyName(7, "imprimir.png");
            this.NavegadorIlImagenes.Images.SetKeyName(8, "inicio.png");
            this.NavegadorIlImagenes.Images.SetKeyName(9, "modificar.png");
            this.NavegadorIlImagenes.Images.SetKeyName(10, "refrescar.png");
            this.NavegadorIlImagenes.Images.SetKeyName(11, "salir.png");
            this.NavegadorIlImagenes.Images.SetKeyName(12, "siguiente.png");
            this.NavegadorIlImagenes.Images.SetKeyName(13, "Fin.png");
            this.NavegadorIlImagenes.Images.SetKeyName(14, "ayuda.png");
            // 
            // NavegadorBtnCancelar
            // 
            this.NavegadorBtnCancelar.ImageIndex = 1;
            this.NavegadorBtnCancelar.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnCancelar.Location = new System.Drawing.Point(119, 24);
            this.NavegadorBtnCancelar.Name = "NavegadorBtnCancelar";
            this.NavegadorBtnCancelar.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnCancelar.TabIndex = 1;
            this.NavegadorBtnCancelar.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnModificar
            // 
            this.NavegadorBtnModificar.ImageIndex = 9;
            this.NavegadorBtnModificar.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnModificar.Location = new System.Drawing.Point(547, 24);
            this.NavegadorBtnModificar.Name = "NavegadorBtnModificar";
            this.NavegadorBtnModificar.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnModificar.TabIndex = 2;
            this.NavegadorBtnModificar.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnImprimir
            // 
            this.NavegadorBtnImprimir.ImageIndex = 7;
            this.NavegadorBtnImprimir.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnImprimir.Location = new System.Drawing.Point(333, 111);
            this.NavegadorBtnImprimir.Name = "NavegadorBtnImprimir";
            this.NavegadorBtnImprimir.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnImprimir.TabIndex = 3;
            this.NavegadorBtnImprimir.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnGuardar
            // 
            this.NavegadorBtnGuardar.ImageIndex = 5;
            this.NavegadorBtnGuardar.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnGuardar.Location = new System.Drawing.Point(440, 111);
            this.NavegadorBtnGuardar.Name = "NavegadorBtnGuardar";
            this.NavegadorBtnGuardar.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnGuardar.TabIndex = 4;
            this.NavegadorBtnGuardar.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnSiguiente
            // 
            this.NavegadorBtnSiguiente.ImageIndex = 13;
            this.NavegadorBtnSiguiente.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnSiguiente.Location = new System.Drawing.Point(868, 24);
            this.NavegadorBtnSiguiente.Name = "NavegadorBtnSiguiente";
            this.NavegadorBtnSiguiente.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnSiguiente.TabIndex = 5;
            this.NavegadorBtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnAnterior
            // 
            this.NavegadorBtnAnterior.ImageIndex = 8;
            this.NavegadorBtnAnterior.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnAnterior.Location = new System.Drawing.Point(761, 24);
            this.NavegadorBtnAnterior.Name = "NavegadorBtnAnterior";
            this.NavegadorBtnAnterior.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnAnterior.TabIndex = 6;
            this.NavegadorBtnAnterior.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnInicio
            // 
            this.NavegadorBtnInicio.ImageIndex = 6;
            this.NavegadorBtnInicio.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnInicio.Location = new System.Drawing.Point(654, 24);
            this.NavegadorBtnInicio.Name = "NavegadorBtnInicio";
            this.NavegadorBtnInicio.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnInicio.TabIndex = 7;
            this.NavegadorBtnInicio.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnEliminar
            // 
            this.NavegadorBtnEliminar.ImageIndex = 3;
            this.NavegadorBtnEliminar.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnEliminar.Location = new System.Drawing.Point(333, 24);
            this.NavegadorBtnEliminar.Name = "NavegadorBtnEliminar";
            this.NavegadorBtnEliminar.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnEliminar.TabIndex = 8;
            this.NavegadorBtnEliminar.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnConsultar
            // 
            this.NavegadorBtnConsultar.ImageIndex = 2;
            this.NavegadorBtnConsultar.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnConsultar.Location = new System.Drawing.Point(226, 24);
            this.NavegadorBtnConsultar.Name = "NavegadorBtnConsultar";
            this.NavegadorBtnConsultar.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnConsultar.TabIndex = 9;
            this.NavegadorBtnConsultar.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnSalir
            // 
            this.NavegadorBtnSalir.ImageIndex = 11;
            this.NavegadorBtnSalir.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnSalir.Location = new System.Drawing.Point(761, 111);
            this.NavegadorBtnSalir.Name = "NavegadorBtnSalir";
            this.NavegadorBtnSalir.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnSalir.TabIndex = 10;
            this.NavegadorBtnSalir.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnFin
            // 
            this.NavegadorBtnFin.ImageIndex = 12;
            this.NavegadorBtnFin.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnFin.Location = new System.Drawing.Point(975, 24);
            this.NavegadorBtnFin.Name = "NavegadorBtnFin";
            this.NavegadorBtnFin.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnFin.TabIndex = 11;
            this.NavegadorBtnFin.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnRefrescar
            // 
            this.NavegadorBtnRefrescar.ImageIndex = 10;
            this.NavegadorBtnRefrescar.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnRefrescar.Location = new System.Drawing.Point(440, 24);
            this.NavegadorBtnRefrescar.Name = "NavegadorBtnRefrescar";
            this.NavegadorBtnRefrescar.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnRefrescar.TabIndex = 13;
            this.NavegadorBtnRefrescar.UseVisualStyleBackColor = true;
            // 
            // NavegadorBtnAyuda
            // 
            this.NavegadorBtnAyuda.ImageIndex = 14;
            this.NavegadorBtnAyuda.ImageList = this.NavegadorIlImagenes;
            this.NavegadorBtnAyuda.Location = new System.Drawing.Point(654, 111);
            this.NavegadorBtnAyuda.Name = "NavegadorBtnAyuda";
            this.NavegadorBtnAyuda.Size = new System.Drawing.Size(101, 81);
            this.NavegadorBtnAyuda.TabIndex = 14;
            this.NavegadorBtnAyuda.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1089, 653);
            this.Controls.Add(this.NavegadorBtnAyuda);
            this.Controls.Add(this.NavegadorBtnRefrescar);
            this.Controls.Add(this.NavegadorBtnFin);
            this.Controls.Add(this.NavegadorBtnSalir);
            this.Controls.Add(this.NavegadorBtnConsultar);
            this.Controls.Add(this.NavegadorBtnEliminar);
            this.Controls.Add(this.NavegadorBtnInicio);
            this.Controls.Add(this.NavegadorBtnAnterior);
            this.Controls.Add(this.NavegadorBtnSiguiente);
            this.Controls.Add(this.NavegadorBtnGuardar);
            this.Controls.Add(this.NavegadorBtnImprimir);
            this.Controls.Add(this.NavegadorBtnModificar);
            this.Controls.Add(this.NavegadorBtnCancelar);
            this.Controls.Add(this.NavegadorBtnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCrud";
            this.Text = "1001 – Crud";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NavegadorBtnIngresar;
        private System.Windows.Forms.ImageList NavegadorIlImagenes;
        private System.Windows.Forms.Button NavegadorBtnCancelar;
        private System.Windows.Forms.Button NavegadorBtnModificar;
        private System.Windows.Forms.Button NavegadorBtnImprimir;
        private System.Windows.Forms.Button NavegadorBtnGuardar;
        private System.Windows.Forms.Button NavegadorBtnSiguiente;
        private System.Windows.Forms.Button NavegadorBtnAnterior;
        private System.Windows.Forms.Button NavegadorBtnInicio;
        private System.Windows.Forms.Button NavegadorBtnEliminar;
        private System.Windows.Forms.Button NavegadorBtnConsultar;
        private System.Windows.Forms.Button NavegadorBtnSalir;
        private System.Windows.Forms.Button NavegadorBtnFin;
        private System.Windows.Forms.Button NavegadorBtnRefrescar;
        private System.Windows.Forms.Button NavegadorBtnAyuda;
        private ImageList imageList1;
    }
}