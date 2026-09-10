using CapaControlador_Seguridad;
using proyecto2k26;
using proyectosisk26;
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

namespace CapaVista_Seguridad
{
    public partial class FrmLogin : Form
    {

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public FrmLogin()
        {
            InitializeComponent();
        }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SeguridadPnlInterfazLogin.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(SeguridadPnlInterfazLogin.ClientRectangle, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMDISeguridad Perfil = new FrmMDISeguridad();
            this.Hide();
            Perfil.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperacion Recuperacion = new FrmRecuperacion();

            this.Hide();

            Recuperacion.ShowDialog();

            this.Show();
        }

        private void dgbConsultaTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}