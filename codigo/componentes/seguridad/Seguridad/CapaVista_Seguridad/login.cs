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
    public partial class login : Form
    {
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public login()
        {
            InitializeComponent();
        }
        private GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SeguridadPnlInterfazLogin.Region = new Region(GetRoundedRect(SeguridadPnlInterfazLogin.ClientRectangle, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIseguridad frmPerfil = new MDIseguridad();
            this.Hide();
            frmPerfil.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         FrmRecuperacion formRecuperacion = new FrmRecuperacion();

            this.Hide();

            formRecuperacion.ShowDialog();

            this.Show();
        }

        private void dgbConsultaTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
