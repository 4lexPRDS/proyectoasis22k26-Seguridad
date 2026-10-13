/*
 * ==================================================================
 * Área : Recursos Humanos
 * Autor : Byron Alexander
 * Carné : 0901-23-3747
 * Fecha : 11/10/2026
 * ==================================================================
 * Propósito :
 *  Formulario MDI (menú de inicio) del módulo de Recursos Humanos.
 *  Tiene el menú lateral con las opciones del módulo, la barra de
 *  arriba con el usuario y el rol, y el panel de bienvenida con el
 *  resumen de indicadores (KPIs), la información del módulo y la
 *  nota de integración.
 * Reglas especificas:
 *  Por ahora es un prototipo, los botones del menú todavía no abren
 *  ventanas y los números de los KPIs son de ejemplo. El usuario, el
 *  rol y los permisos se reciben desde afuera con los métodos
 *  RrhhMetActualizarInfoUsuario y RrhhMetAplicarPermisos, para no
 *  depender de las DLL de Seguridad.
 * ===================================================================
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using CapaVista_CierreNominas.Fomularios;
using CapaVista_Nomina.Formularios;


namespace CapaVista_Rrhh.Formularios
{
    public partial class FrmMDIRrhh : Form
    {
        private bool _NavegadorColapsado;
        private int _AnchoNavegador;

        // imagenes de fondo originales y la del menu ya escalada
        private Image _FondoDashboard;
        private Image _FondoNavegador;
        private Bitmap _FondoNavegadorEscalado;

        public FrmMDIRrhh()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += FrmMDIRrhh_Load;
        }

        // para que la ventana se pinte completa de una vez y no por partes
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams Parametros = base.CreateParams;
                Parametros.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return Parametros;
            }
        }

        private void FrmMDIRrhh_Load(object sender, EventArgs e)
        {
            RrhhMetPrepararImagenes();
            RrhhMetCargarIconos();
            RrhhMetDarFormaTarjetas();
        }

        // los fondos, el logo y la mascota se escalan una sola vez al cargar,
        // si se dejan en Stretch o Zoom se vuelven a escalar cada vez que se pinta
        private void RrhhMetPrepararImagenes()
        {
            _FondoDashboard = RrhhPnlDashboard.BackgroundImage;
            RrhhMetEscalarFondoDashboard();

            // el fondo del menu se pinta en RrhhPnlNavegador_Paint
            _FondoNavegador = RrhhPnlNavegador.BackgroundImage;
            RrhhPnlNavegador.BackgroundImage = null;

            RrhhMetAjustarImagen(RrhhPbLogo);
            RrhhMetAjustarImagen(RrhhPbMascota);
        }

        private void RrhhMetEscalarFondoDashboard()
        {
            Size Tamano = RrhhPnlDashboard.ClientSize;
            if (_FondoDashboard == null || Tamano.Width <= 0 || Tamano.Height <= 0) return;

            Image Anterior = RrhhPnlDashboard.BackgroundImage;
            RrhhPnlDashboard.BackgroundImageLayout = ImageLayout.None;
            RrhhPnlDashboard.BackgroundImage = RrhhMetEscalarImagen(_FondoDashboard, Tamano.Width, Tamano.Height, false);
            if (Anterior != null && Anterior != _FondoDashboard) Anterior.Dispose();
        }

        private void RrhhMetAjustarImagen(PictureBox Caja)
        {
            Image Original = Caja.Image;
            if (Original == null) return;

            float Escala = Math.Min((float)Caja.Width / Original.Width, (float)Caja.Height / Original.Height);
            int Ancho = Math.Max(1, (int)(Original.Width * Escala));
            int Alto = Math.Max(1, (int)(Original.Height * Escala));

            Caja.Image = RrhhMetEscalarImagen(Original, Ancho, Alto, true);
            Caja.SizeMode = PictureBoxSizeMode.CenterImage;
            Original.Dispose();
        }

        // los iconos vienen a 128 px y se reducen segun la escala de la pantalla
        // para que no se vean borrosos, las copias _diseno solo son para el diseñador
        private void RrhhMetCargarIconos()
        {
            var Iconos = new Dictionary<Button, Image>
            {
                { RrhhBtnEmpleados, Properties.Resources.btn_empleados },
                { RrhhBtnAsistencia, Properties.Resources.btn_asistencia },
                { RrhhBtnPermisosVacaciones, Properties.Resources.btn_permisos },
                { RrhhBtnCapacitaciones, Properties.Resources.btn_capacitaciones },
                { RrhhBtnEvaluacionDesempeno, Properties.Resources.btn_evaluacion },
                { RrhhBtnNomina, Properties.Resources.btn_nomina },
                { RrhhBtnCierresNomina, Properties.Resources.btn_cierres },
                { RrhhBtnLiquidacion, Properties.Resources.btn_liquidacion },
                { RrhhBtnCerrarSesion, Properties.Resources.btn_cerrarsesion }
            };

            int Lado;
            using (Graphics G = CreateGraphics())
            {
                Lado = (int)Math.Round(36 * G.DpiX / 96f);
            }

            foreach (var Par in Iconos)
            {
                Par.Key.Image = RrhhMetEscalarImagen(Par.Value, Lado, Lado, true);
            }
        }

        // con AltaCalidad en false es mas rapido, se usa para los fondos
        private static Bitmap RrhhMetEscalarImagen(Image Original, int Ancho, int Alto, bool AltaCalidad)
        {
            var Resultado = new Bitmap(Ancho, Alto, PixelFormat.Format32bppPArgb);
            using (Graphics G = Graphics.FromImage(Resultado))
            {
                G.InterpolationMode = AltaCalidad ? InterpolationMode.HighQualityBicubic : InterpolationMode.Bilinear;
                G.PixelOffsetMode = AltaCalidad ? PixelOffsetMode.HighQuality : PixelOffsetMode.HighSpeed;
                G.SmoothingMode = SmoothingMode.AntiAlias;
                G.DrawImage(Original, 0, 0, Ancho, Alto);
            }
            return Resultado;
        }

        // se llama despues del login con los datos de la sesion
        public void RrhhMetActualizarInfoUsuario(string Nombre, string Rol)
        {
            RrhhLblUsuario.Text = $"Usuario: {Nombre}";
            RrhhLblUsuarioRol.Text = $"Rol: {Rol}";
            RrhhLblUsuarioRol.Left = RrhhLblUsuario.Right + 30;
        }

        // TieneAcceso recibe el id de la aplicacion y dice si el usuario puede entrar,
        // los id estan en 0 porque Seguridad todavia no nos da la numeracion
        public void RrhhMetAplicarPermisos(Func<int, bool> TieneAcceso)
        {
            var MapaBotonesMDI = new Dictionary<Button, int>
            {
                { RrhhBtnEmpleados, 0 },
                { RrhhBtnAsistencia, 0 },
                { RrhhBtnPermisosVacaciones, 0 },
                { RrhhBtnCapacitaciones, 0 },
                { RrhhBtnEvaluacionDesempeno, 0 },
                { RrhhBtnNomina, 0 },
                { RrhhBtnCierresNomina, 0 },
                { RrhhBtnLiquidacion, 0 }
            };

            foreach (var Par in MapaBotonesMDI)
            {
                if (!TieneAcceso(Par.Value))
                    RrhhMetDeshabilitarBoton(Par.Key);
            }
        }

        // boton gris y sin efecto, como pide el estandar
        public void RrhhMetDeshabilitarBoton(Button Boton)
        {
            Boton.Enabled = false;
            Boton.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void RrhhBtnMenu_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(14, 76, 85);
        }

        private void RrhhBtnMenu_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
        }

        private void RrhhMetDarFormaTarjetas()
        {
            // tarjetas redondeadas y los iconos de los KPIs en circulo
            foreach (Control Tarjeta in RrhhPnlDashboard.Controls)
            {
                if (!(Tarjeta is Panel) || !Tarjeta.Name.StartsWith("RrhhPnlKPI")) continue;
                Tarjeta.Region = new Region(RrhhMetRedondearEsquinas(Tarjeta.ClientRectangle, 18));

                foreach (Control Icono in Tarjeta.Controls)
                {
                    if (!(Icono is Panel)) continue;

                    if (Icono.BackgroundImage != null)
                    {
                        Image Original = Icono.BackgroundImage;
                        Icono.BackgroundImage = RrhhMetEscalarImagen(Original, Icono.Width, Icono.Height, true);
                        Icono.BackgroundImageLayout = ImageLayout.None;
                        Original.Dispose();
                    }

                    GraphicsPath Circulo = new GraphicsPath();
                    Circulo.AddEllipse(Icono.ClientRectangle);
                    Icono.Region = new Region(Circulo);
                }
            }

            RrhhPnlInfo.Region = new Region(RrhhMetRedondearEsquinas(RrhhPnlInfo.ClientRectangle, 18));
            GraphicsPath CirculoNota = new GraphicsPath();
            CirculoNota.AddEllipse(RrhhLblIconoNota.ClientRectangle);
            RrhhLblIconoNota.Region = new Region(CirculoNota);

            foreach (Control Boton in RrhhPnlNavegador.Controls)
            {
                if (Boton is Button) Boton.Region = new Region(RrhhMetRedondearEsquinas(Boton.ClientRectangle, 10));
            }
            RrhhBtnBurger.Region = new Region(RrhhMetRedondearEsquinas(RrhhBtnBurger.ClientRectangle, 8));
        }

        private void RrhhPnlDashboard_Resize(object sender, EventArgs e)
        {
            RrhhPnlDashboard.Region = new Region(RrhhMetRedondearEsquinas(RrhhPnlDashboard.ClientRectangle, 20));
            RrhhMetEscalarFondoDashboard();
        }

        private void RrhhPnlNavegador_Resize(object sender, EventArgs e)
        {
            RrhhPnlNavegador.Region = new Region(RrhhMetRedondearEsquinas(RrhhPnlNavegador.ClientRectangle, 22));
        }

        // el fondo del menu siempre se pinta al ancho del menu abierto,
        // asi cuando se colapsa solo se recorta y no se ve aplastado
        private void RrhhPnlNavegador_Paint(object sender, PaintEventArgs e)
        {
            if (_FondoNavegador == null) return;
            int AnchoFondo = _NavegadorColapsado ? _AnchoNavegador : RrhhPnlNavegador.Width;

            if (_FondoNavegadorEscalado == null || _FondoNavegadorEscalado.Width != AnchoFondo
                || _FondoNavegadorEscalado.Height != RrhhPnlNavegador.Height)
            {
                _FondoNavegadorEscalado?.Dispose();
                _FondoNavegadorEscalado = RrhhMetEscalarImagen(_FondoNavegador, AnchoFondo, RrhhPnlNavegador.Height, false);
            }
            e.Graphics.DrawImageUnscaled(_FondoNavegadorEscalado, 0, 0);
        }

        private void RrhhPnlKPI_Paint(object sender, PaintEventArgs e)
        {
            Control Tarjeta = (Control)sender;
            Rectangle Borde = new Rectangle(0, 0, Tarjeta.Width - 1, Tarjeta.Height - 1);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath Ruta = RrhhMetRedondearEsquinas(Borde, 18))
            using (Pen Lapiz = new Pen(Color.FromArgb(160, 31, 138, 143), 1.5f))
            {
                e.Graphics.DrawPath(Lapiz, Ruta);
            }
        }

        private GraphicsPath RrhhMetRedondearEsquinas(Rectangle Rectangulo, int Radio)
        {
            GraphicsPath RutaGrafica = new GraphicsPath();
            int Diametro = Radio * 2;

            RutaGrafica.AddArc(Rectangulo.X, Rectangulo.Y, Diametro, Diametro, 180, 90);
            RutaGrafica.AddArc(Rectangulo.Right - Diametro, Rectangulo.Y, Diametro, Diametro, 270, 90);
            RutaGrafica.AddArc(Rectangulo.Right - Diametro, Rectangulo.Bottom - Diametro, Diametro, Diametro, 0, 90);
            RutaGrafica.AddArc(Rectangulo.X, Rectangulo.Bottom - Diametro, Diametro, Diametro, 90, 90);
            RutaGrafica.CloseFigure();

            return RutaGrafica;
        }

        // colapsa el menu y deja solo los iconos, el texto de cada boton se guarda en el Tag.
        // uso una bandera en vez de comparar el ancho porque con escala de 125% o 150%
        // el ancho ya no es 270
        private void RrhhBtnBurger_Click(object sender, EventArgs e)
        {
            bool Colapsar = !_NavegadorColapsado;
            _NavegadorColapsado = Colapsar;

            this.SuspendLayout();
            RrhhPnlNavegador.SuspendLayout();

            if (Colapsar)
            {
                _AnchoNavegador = RrhhPnlNavegador.Width;
                RrhhPnlNavegador.Width = RrhhBtnEmpleados.Left + RrhhBtnEmpleados.Padding.Left
                    + RrhhBtnEmpleados.Image.Width + 18;
            }
            else
            {
                RrhhPnlNavegador.Width = _AnchoNavegador;
            }
            RrhhPbLogo.Visible = !Colapsar;

            foreach (Control Boton in RrhhPnlNavegador.Controls)
            {
                if (Boton is Button) Boton.Text = Colapsar ? "" : (string)Boton.Tag;
            }

            RrhhPnlNavegador.ResumeLayout();
            this.ResumeLayout();
        }

        private void RrhhBtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show(
                "¿Seguro que deseas cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RrhhBtnEmpleados_Click(object sender, EventArgs e)
        {
            
        }

        private void RrhhBtnCierresNomina_Click(object sender, EventArgs e)
        {
            FrmCierreNominas CierreNominas = new FrmCierreNominas();
            CierreNominas.ShowDialog();
        }

        private void FrmMDIRrhh_Load_1(object sender, EventArgs e)
        {

        }

        private void RrhhBtnNomina_Click(object sender, EventArgs e)
        {
            FrmPercepcionesDeducciones CierreNominas = new FrmPercepcionesDeducciones();
            CierreNominas.ShowDialog();
        }
    }
}
