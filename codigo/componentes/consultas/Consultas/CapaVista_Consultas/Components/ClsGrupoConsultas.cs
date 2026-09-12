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
    public class ClsGrupoConsultas : GroupBox
    {
        private static readonly Color ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

        public ClsGrupoConsultas()
        {
            Font = new Font(
                "Tahoma",
                10F,
                FontStyle.Bold,
                GraphicsUnit.Point);

            ForeColor = ColorTexto;
            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            Margin = new Padding(3);
        }
    }
}