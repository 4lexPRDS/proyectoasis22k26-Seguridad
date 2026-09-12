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
    public class ClsListaDesplegableConsultas : ComboBox
    {
        private static readonly Color ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

        public ClsListaDesplegableConsultas()
        {
            Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            ForeColor = ColorTexto;
            BackColor = Color.White;

            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;

            IntegralHeight = true;
            MaxDropDownItems = 8;

            Margin = new Padding(3);
        }

        protected override Size DefaultSize =>
            new Size(200, 27);
    }
}