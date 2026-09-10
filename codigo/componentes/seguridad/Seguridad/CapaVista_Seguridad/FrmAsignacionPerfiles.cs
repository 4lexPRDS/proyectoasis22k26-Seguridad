using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionPerfiles
{
    public partial class FrmAsignacionPerfiles : Form
    {
        public FrmAsignacionPerfiles()
        {
            InitializeComponent();
        }

        // Helper para dar esquinas redondeadas a los paneles (mismo patrón usado en el módulo de Seguridad)
        private GraphicsPath SeguridadMetObtenerRectanguloRedondeado(Rectangle Limites, int Radio)
        {
            GraphicsPath RutaGrafica = new GraphicsPath();
            int Diametro = Radio * 2;
            RutaGrafica.AddArc(Limites.X, Limites.Y, Diametro, Diametro, 180, 90);
            RutaGrafica.AddArc(Limites.Right - Diametro, Limites.Y, Diametro, Diametro, 270, 90);
            RutaGrafica.AddArc(Limites.Right - Diametro, Limites.Bottom - Diametro, Diametro, Diametro, 0, 90);
            RutaGrafica.AddArc(Limites.X, Limites.Bottom - Diametro, Diametro, Diametro, 90, 90);
            RutaGrafica.CloseFigure();
            return RutaGrafica;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            panelHeader.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(panelHeader.ClientRectangle, 18));
        }

        private void panelConsulta_Paint(object sender, PaintEventArgs e)
        {
            panelConsulta.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(panelConsulta.ClientRectangle, 18));
        }

        private void panelAsignacion_Paint(object sender, PaintEventArgs e)
        {
            panelAsignacion.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(panelAsignacion.ClientRectangle, 18));
        }

        private void panelIconPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelIconConsulta_Paint(object sender, PaintEventArgs e)
        {
            panelIconConsulta.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(panelIconConsulta.ClientRectangle, 10));
        }

        private void panelIconAsignacion_Paint(object sender, PaintEventArgs e)
        {
            panelIconAsignacion.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(panelIconAsignacion.ClientRectangle, 10));
        }

        // ---- Prototipo NO funcional: los siguientes eventos están vacíos a propósito ----

        private void buttonCancelarConsulta_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarAsignacion_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsignar_Click(object sender, EventArgs e)
        {

        }
    }
}