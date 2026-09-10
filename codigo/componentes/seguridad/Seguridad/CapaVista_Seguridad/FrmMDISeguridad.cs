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
    public partial class FrmMDISeguridad : Form
    {
        public FrmMDISeguridad()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int Radio = 20; // ajusta el radio como quieras
            SeguridadPnlDashboard.Region = new Region(SeguridadMetRedondearEsquinas(SeguridadPnlDashboard.ClientRectangle, Radio));
        }

        private GraphicsPath SeguridadMetRedondearEsquinas(Rectangle Rectangulo, int Radio)
        {
            GraphicsPath RutaGrafica = new GraphicsPath();
            int Diametro = Radio * 2;

            RutaGrafica.AddArc(Rectangulo.X, Rectangulo.Y, Diametro, Diametro, 180, 90); // esquina superior izquierda
            RutaGrafica.AddArc(Rectangulo.Right - Diametro, Rectangulo.Y, Diametro, Diametro, 270, 90); // superior derecha
            RutaGrafica.AddArc(Rectangulo.Right - Diametro, Rectangulo.Bottom - Diametro, Diametro, Diametro, 0, 90); // inferior derecha
            RutaGrafica.AddArc(Rectangulo.X, Rectangulo.Bottom - Diametro, Diametro, Diametro, 90, 90); // inferior izquierda
            RutaGrafica.CloseFigure();

            return RutaGrafica;
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
            FrmAsignacionAppPerf Perfil = new FrmAsignacionAppPerf();
            Perfil.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBitacora Bitacora = new FrmBitacora();
            Bitacora.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmAsignacionAplicacionUsuario AsigAplicacionUsuario = new FrmAsignacionAplicacionUsuario();
            AsigAplicacionUsuario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAsignacionPerfiles AsignacionPerfiles = new FrmAsignacionPerfiles();
            AsignacionPerfiles.ShowDialog();
        }

        private void SeguridadBtnPerfiles_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPerfiles MantenimientoPerfiles = new FrmMantenimientoPerfiles();
            MantenimientoPerfiles.ShowDialog();
        }

        private void SeguridadBtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios Usuarios = new FrmUsuarios();
            Usuarios.ShowDialog();
        }

        private void SeguridadBtnBurger_Click(object sender, EventArgs e)
        {
            if (SeguridadPnlNavegador.Width == 270)
            {
                SeguridadPnlNavegador.Width = 64;
                SeguridadPnlDashboard.Location = new Point(200, 52);
                SeguridadBtnBurger.Location = new Point(220, 13);
                SeguridadLblUsuariosRol.Location = new Point(285, 19);
            }
            else
            {
                SeguridadPnlNavegador.Width = 270;
                SeguridadPnlDashboard.Location = new Point(307, 52);
                SeguridadBtnBurger.Location = new Point(323, 13);
                SeguridadLblUsuariosRol.Location = new Point(390, 19);
            }
        }

        private void SeguridadBtnModulos_Click(object sender, EventArgs e)
        {
            FrmModulo Modulo = new FrmModulo();
            Modulo.ShowDialog();
        }

        private void SeguridadBtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEmpleado Empleados = new FrmMantenimientoEmpleado();
            Empleados.ShowDialog();
        }

        private void SeguridadBtnAplicaciones_Click(object sender, EventArgs e)
        {
            FrmMantenimientoAplicacion Aplicaciones = new FrmMantenimientoAplicacion();
            Aplicaciones.ShowDialog();
        }
    }
}