using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Components
{
    public class ClsTablaDatosConsultas : DataGridView
    {
        private static readonly Color Primario =
            ColorTranslator.FromHtml("#2E4A63");

        private static readonly Color Secundario =
            ColorTranslator.FromHtml("#4E8078");

        private static readonly Color Fondo =
            ColorTranslator.FromHtml("#EDE7DA");

        private static readonly Color FondoAlterno =
            Color.FromArgb(245, 242, 235);

        public ClsTablaDatosConsultas()
        {
            DoubleBuffered = true;

            AplicarEstandarizacion();
        }

        protected override void OnHandleCreated(System.EventArgs e)
        {
            base.OnHandleCreated(e);

            AplicarEstandarizacion();
        }

        private void AplicarEstandarizacion()
        {
            AutoGenerateColumns = true;

            Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            BackgroundColor = Color.White;

            BorderStyle = BorderStyle.None;

            CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            GridColor = Fondo;

            EnableHeadersVisualStyles = false;

            ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Primario,
                    ForeColor = Color.White,
                    SelectionBackColor = Primario,
                    SelectionForeColor = Color.White,
                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft,
                    Font = new Font(
                        "Tahoma",
                        9.5F,
                        FontStyle.Bold,
                        GraphicsUnit.Point)
                };

            DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Color.White,
                    ForeColor = Primario,
                    SelectionBackColor = Secundario,
                    SelectionForeColor = Color.White,
                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft,
                    Padding = new Padding(3, 0, 3, 0),
                    Font = new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Regular,
                        GraphicsUnit.Point)
                };

            RowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Color.White,
                    ForeColor = Primario,
                    SelectionBackColor = Secundario,
                    SelectionForeColor = Color.White
                };

            AlternatingRowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = FondoAlterno,
                    ForeColor = Primario,
                    SelectionBackColor = Secundario,
                    SelectionForeColor = Color.White
                };

            RowHeadersVisible = false;

            ReadOnly = true;

            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;

            SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            MultiSelect = false;

            EditMode =
                DataGridViewEditMode.EditProgrammatically;

            AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            ColumnHeadersHeight = 32;

            ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            RowTemplate.Height = 28;

            Margin = new Padding(3);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (ClientSize.Width <= 0 ||
                ClientSize.Height <= 0)
            {
                return;
            }

            using (Pen borde = new Pen(Primario, 1F))
            {
                e.Graphics.DrawRectangle(
                    borde,
                    0,
                    0,
                    ClientSize.Width - 1,
                    ClientSize.Height - 1);
            }
        }
    }
}