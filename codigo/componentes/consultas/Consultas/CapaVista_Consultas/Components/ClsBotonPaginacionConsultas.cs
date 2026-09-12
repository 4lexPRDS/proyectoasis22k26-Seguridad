using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaVista_Consultas.Components
{
    public class ClsBotonPaginacionConsultas : Button
    {
        private static readonly Color Primario =
            ColorTranslator.FromHtml("#2E4A63");

        private static readonly Color Secundario =
            ColorTranslator.FromHtml("#4E8078");

        private bool _esActivo;

        public bool EsActivo
        {
            get => _esActivo;
            set
            {
                _esActivo = value;
                ActualizarEstado();
            }
        }

        public ClsBotonPaginacionConsultas()
        {
            Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            Size = new Size(35, 30);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;

            BackColor = Color.White;
            ForeColor = Primario;

            Margin = new Padding(2);
            TextAlign = ContentAlignment.MiddleCenter;
        }

        protected override Size DefaultSize =>
            new Size(35, 30);

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);

            if (!EsActivo)
            {
                BackColor = Secundario;
                ForeColor = Color.White;
            }
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);

            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            if (EsActivo)
            {
                BackColor = Primario;
                ForeColor = Color.White;
                Font = new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold,
                    GraphicsUnit.Point);
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Primario;
                Font = new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Regular,
                    GraphicsUnit.Point);
            }
        }
    }
}