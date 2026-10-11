/*
 * ==================================================================
 * Área : Recursos Humanos
 * Autor : Byron Alexander
 * Carné :
 * Fecha : 09/10/2026
 * ==================================================================
 * Propósito :
 *  Prototipo no funcional del formulario MDI (menú de inicio) del
 *  módulo de Recursos Humanos. Muestra la barra lateral con las
 *  opciones del módulo, la barra superior con usuario y rol, y el
 *  panel de bienvenida con el resumen de indicadores (KPIs).
 * Reglas especificas:
 *  - Paleta del módulo 06 - Recursos Humanos.
 *  - Logo y mascota tomados de los recursos de Seguridad.
 *  - Este formulario NO referencia las DLLs de Seguridad (sus bin no
 *    se suben a Git). Quien abra el MDI despues del login le pasa los
 *    datos con los metodos publicos:
 *      RrhhMetActualizarInfoUsuario(nombre, rol)  -> usuario y rol
 *      RrhhMetAplicarPermisos(validador)          -> botones en gris
 *    Ej.: Mdi.RrhhMetAplicarPermisos(IdApp =>
 *           ClsSeguridadFormHelper.SeguridadMetTieneAcceso(IdModulo, IdApp));
 *  - Los valores de los KPIs son de ejemplo; se conectarán al
 *    Controlador cuando el módulo sea funcional.
 *  - El código de aplicación queda como "0000" y los Id de módulo y
 *    aplicación en 0 hasta que Seguridad asigne la numeración oficial.
 * ===================================================================
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CapaVista_Rrhh.Formularios
{
    public partial class FrmMDIRrhh : Form
    {
        private bool _NavegadorColapsado;
        private int _AnchoNavegador;

        public FrmMDIRrhh()
        {
            InitializeComponent();
            this.Load += FrmMDIRrhh_Load;
        }

        private void FrmMDIRrhh_Load(object sender, EventArgs e)
        {
            RrhhMetCargarIconos();
            RrhhMetDarFormaTarjetas();
        }

        // Los íconos se guardan en alta resolución (128 px) y aquí se reducen al
        // tamaño exacto según el DPI de la pantalla, para que no se vean borrosos
        // con escalado de Windows (125 %, 150 %). Las copias "_diseno" (36 px)
        // solo sirven para verlos en el diseñador de Visual Studio.
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
                Par.Key.Image = RrhhMetEscalarImagen(Par.Value, Lado);
            }
        }

        private static Bitmap RrhhMetEscalarImagen(Image Original, int Lado)
        {
            var Resultado = new Bitmap(Lado, Lado);
            using (Graphics G = Graphics.FromImage(Resultado))
            {
                G.InterpolationMode = InterpolationMode.HighQualityBicubic;
                G.PixelOffsetMode = PixelOffsetMode.HighQuality;
                G.SmoothingMode = SmoothingMode.AntiAlias;
                G.DrawImage(Original, 0, 0, Lado, Lado);
            }
            return Resultado;
        }

        // Lo llama quien abre el MDI despues del login, con los datos de la sesion
        // (ClsSesionSeguridad.NombreEmpleado y SeguridadMetRolesComoTexto()).
        public void RrhhMetActualizarInfoUsuario(string Nombre, string Rol)
        {
            RrhhLblUsuario.Text = $"Usuario: {Nombre}";
            RrhhLblUsuarioRol.Text = $"Rol: {Rol}";
            RrhhLblUsuarioRol.Left = RrhhLblUsuario.Right + 30;
        }

        // Recibe la validacion de Seguridad como funcion (IdAplicacion -> tiene acceso)
        // para no depender de sus DLLs. Botón del menú -> Id de aplicación (pendientes).
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

        // Estado deshabilitado del estándar: mismo botón en gris claro y sin efecto.
        // WinForms dibuja el ícono en gris y el botón deja de responder al mouse.
        public void RrhhMetDeshabilitarBoton(Button Boton)
        {
            Boton.Enabled = false;
            Boton.BackColor = Color.FromArgb(200, 200, 200);
        }

        // Efecto al pasar el mouse: el fondo cambia a verde agua (FlatAppearance)
        // y el texto a petróleo para que se lea bien sobre el fondo claro.
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
            // Íconos de los KPIs en círculo y tarjetas con esquinas redondeadas
            foreach (Control Tarjeta in RrhhPnlDashboard.Controls)
            {
                if (!(Tarjeta is Panel) || !Tarjeta.Name.StartsWith("RrhhPnlKPI")) continue;
                Tarjeta.Region = new Region(RrhhMetRedondearEsquinas(Tarjeta.ClientRectangle, 18));
                foreach (Control Icono in Tarjeta.Controls)
                {
                    if (!(Icono is Panel)) continue;
                    GraphicsPath Circulo = new GraphicsPath();
                    Circulo.AddEllipse(Icono.ClientRectangle);
                    Icono.Region = new Region(Circulo);
                }
            }

            // Botones con esquinas redondeadas, como en el diseño de referencia
            foreach (Control Boton in RrhhPnlNavegador.Controls)
            {
                if (Boton is Button) Boton.Region = new Region(RrhhMetRedondearEsquinas(Boton.ClientRectangle, 10));
            }
            RrhhBtnBurger.Region = new Region(RrhhMetRedondearEsquinas(RrhhBtnBurger.ClientRectangle, 8));
        }

        private void RrhhPnlDashboard_Resize(object sender, EventArgs e)
        {
            RrhhPnlDashboard.Region = new Region(RrhhMetRedondearEsquinas(RrhhPnlDashboard.ClientRectangle, 20));
        }

        // Se vuelve a redondear al colapsar/expandir con el botón hamburguesa
        private void RrhhPnlNavegador_Resize(object sender, EventArgs e)
        {
            RrhhPnlNavegador.Region = new Region(RrhhMetRedondearEsquinas(RrhhPnlNavegador.ClientRectangle, 22));
        }

        // El fondo del menú se dibuja siempre al ancho del menú abierto: al colapsar
        // se recorta (solo se ve la parte izquierda) en lugar de comprimirse.
        private void RrhhPnlNavegador_Paint(object sender, PaintEventArgs e)
        {
            int AnchoFondo = _NavegadorColapsado ? _AnchoNavegador : RrhhPnlNavegador.Width;
            e.Graphics.DrawImage(RrhhPnlNavegador.BackgroundImage, 0, 0, AnchoFondo, RrhhPnlNavegador.Height);
        }

        // Borde fino turquesa de las tarjetas de KPIs
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

        // Colapsa la barra lateral a solo íconos (el texto original se guarda en Tag).
        // Se usa un indicador y no el ancho exacto, porque con escalado de pantalla
        // de Windows (125 %, 150 %) el ancho real ya no es 270.
        private void RrhhBtnBurger_Click(object sender, EventArgs e)
        {
            bool Colapsar = !_NavegadorColapsado;
            _NavegadorColapsado = Colapsar;

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
    }
}
