using AplicacionPerfiles;
using proyecto2k26;
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
using Ventana_Bitacora_Seguridad;

namespace CapaVista_Seguridad
{
    public partial class MDIseguridad : Form
    {
        public MDIseguridad()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int radio = 20; // ajusta el radio como quieras
            SeguridadPnlDashboard.Region = new Region(RedondearEsquinas(SeguridadPnlDashboard.ClientRectangle, radio));
        }

        private GraphicsPath RedondearEsquinas(Rectangle rect, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            int diametro = radio * 2;

            path.AddArc(rect.X, rect.Y, diametro, diametro, 180, 90); // esquina superior izquierda
            path.AddArc(rect.Right - diametro, rect.Y, diametro, diametro, 270, 90); // superior derecha
            path.AddArc(rect.Right - diametro, rect.Bottom - diametro, diametro, diametro, 0, 90); // inferior derecha
            path.AddArc(rect.X, rect.Bottom - diametro, diametro, diametro, 90, 90); // inferior izquierda
            path.CloseFigure();

            return path;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmAsignacionAppPerf frmPerfil = new FrmAsignacionAppPerf();
            frmPerfil.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBitacora frmbita = new FrmBitacora();
            frmbita.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmAsignacionAplicacionUsuario frmasigusu = new FrmAsignacionAplicacionUsuario();
            frmasigusu.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AsignacionPerfiles frmasigusu = new AsignacionPerfiles();
            frmasigusu.ShowDialog();
        }

        private void SeguridadBtnPerfiles_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPerfiles frmasigusu = new FrmMantenimientoPerfiles();
            frmasigusu.ShowDialog();
        }
    }
}
