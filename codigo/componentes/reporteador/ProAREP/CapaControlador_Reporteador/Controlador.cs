using CapaModelo_Reporteador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
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

        // FILTRO SOLO POR NOMBRE
        public DataTable filtrarNombre(string nombre)
        {
            OdbcDataAdapter daControlador =
                sentencias.filtrarPorNombre(nombre);

            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);

            return dtControlador;
        }

        // FILTRO SOLO POR FECHA
        public DataTable filtrarFecha(DateTime fecha)
        {
            OdbcDataAdapter daControlador =
                sentencias.filtrarPorFecha(fecha);

            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);

            return dtControlador;
        }

        // FILTRO POR NOMBRE Y FECHA
        public DataTable filtrarNombreYFecha(string nombre, DateTime fecha)
        {
            OdbcDataAdapter daControlador =
                sentencias.filtrarPorNombreYFecha(nombre, fecha);

            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);

            return dtControlador;
        }

        public string obtenerRutaReporte(string nombreReporte)
        {
            return sentencias.consultarRutaReporte(nombreReporte);
        }

        public string construirRutaCompleta(string nombreReporte, string rutaReporte)
        {
            return Path.Combine(rutaReporte, nombreReporte + ".pdf");
        }
    }
}
