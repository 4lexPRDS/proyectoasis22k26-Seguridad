using CapaModelo_Reporteador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Reporteador
{
    public class Controlador
    {

        Sentencias sentencias = new Sentencias();
        public DataTable llenarDgv(string nombreTabla)
        {
            OdbcDataAdapter daControlador = sentencias.llenarTbl(nombreTabla);
            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);
            return dtControlador;
        }

    }
}
