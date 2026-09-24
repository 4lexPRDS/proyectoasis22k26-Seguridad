using System.Linq;
using CapaEntidades_Navegador;

namespace CapaVista_Navegador
{
    // Decide si una Columna se dibuja como fecha, checkbox o campo numerico
    public static class ClsTipoColumna
    {
        public static bool NavegadorFuncEsFecha(ClsColumnaInfo Col)
        {
            string TipoNet = (Col.TipoNet ?? "").ToLowerInvariant();

            if (TipoNet == "datetime" || TipoNet == "date" || TipoNet == "timespan")
                return true;

            string TipoDato = (Col.TipoDato ?? "").ToLowerInvariant();
            return TipoDato.Contains("date") || TipoDato.Contains("time") || TipoDato.Contains("timestamp");
        }

        // MySQL guarda BOOLEAN como tinyint(1), por eso se revisa el texto real de la Columna
        public static bool NavegadorFuncEsBooleano(ClsColumnaInfo Col)
        {
            string TipoNet = (Col.TipoNet ?? "").ToLowerInvariant();

            if (TipoNet == "boolean")
                return true;

            string ColumnaTexto = (Col.TipoColumnaTexto ?? "").ToLowerInvariant().Replace(" ", "");

            if (ColumnaTexto.Contains("tinyint(1)") || ColumnaTexto == "bool" || ColumnaTexto == "boolean")
                return true;

            string TipoDato = (Col.TipoDato ?? "").ToLowerInvariant();

            if (TipoDato == "bit" || TipoDato == "boolean" || TipoDato == "bool")
                return true;

            if ((TipoDato == "tinyint" || TipoDato.Contains("tinyint")) && Col.TamanoColumna == 1)
                return true;

            return false;
        }

        public static bool NavegadorFuncEsNumerico(ClsColumnaInfo Col)
        {
            string TipoNet = (Col.TipoNet ?? "").ToLowerInvariant();
            string[] netNumericos = { "int16", "int32", "int64", "byte", "sbyte", "decimal", "double", "single" };

            if (netNumericos.Contains(TipoNet))
                return true;

            string TipoDato = (Col.TipoDato ?? "").ToLowerInvariant();

            switch (TipoDato)
            {
                case "int":
                case "integer":
                case "smallint":
                case "bigint":
                case "tinyint":
                case "decimal":
                case "numeric":
                case "float":
                case "double":
                case "real":
                case "counter":
                case "number":
                    return true;

                default:
                    return false;
            }
        }
    }
}