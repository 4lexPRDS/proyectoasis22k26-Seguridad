using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Components
{
    public class ClsBotonPaginacionConsultas : Button
    {
        private static readonly Color Primario =
            ColorTranslator.FromHtml("#2E4A63");

        private static readonly Color Secundario =
            ColorTranslator.FromHtml("#4E8078");

        private bool _EsActivo;

        public bool EsActivo
        {
            get => _EsActivo;
            set
            {
                _EsActivo = value;
                ConsultasProcActualizarEstado();
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

            BackColor = Primario;
            ForeColor = Color.White;

            Cursor = Cursors.Hand;

            UseVisualStyleBackColor = false;

            TextAlign = ContentAlignment.MiddleCenter;

            Margin = new Padding(2);
        }

        protected override Size DefaultSize =>
            new Size(35, 30);

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (!EsActivo)
            {
                BackColor = Secundario;
                ForeColor = Color.White;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            ConsultasProcActualizarEstado();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            Cursor = Enabled
                ? Cursors.Hand
                : Cursors.Default;

            ForeColor = Color.White;
        }

        private void ConsultasProcActualizarEstado()
        {
            BackColor = EsActivo
                ? Secundario
                : Primario;

            ForeColor = Color.White;

            Font = new Font(
                "Segoe UI",
                9F,
                EsActivo
                    ? FontStyle.Bold
                    : FontStyle.Regular,
                GraphicsUnit.Point);
        }
    }
}