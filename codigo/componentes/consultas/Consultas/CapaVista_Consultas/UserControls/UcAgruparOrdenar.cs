using CapaControlador_Consultas;
using CapaVista_Consultas.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public partial class UcAgruparOrdenar : ClsControlUsuarioConsultas
    {
        private readonly ClsControladorConsultas _controlador =
            new ClsControladorConsultas();

        public UcAgruparOrdenar()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasMetCargarDatosIniciales();
            }
        }

        private void ConsultasMetCargarDatosIniciales()
        {
            string Tabla = "Empleados";

            _controlador.ConsultasMetPoblarComboCampos(
                Tabla,
                ConsultasCboCampo);

            ConsultasCboOperador.Items.Clear();

            ConsultasCboOperador.Items.AddRange(new object[]
            {
                "=",
                ">",
                "<",
                ">=",
                "<=",
                "Contiene",
                "Comienza con",
                "Termina con"
            });

            ConsultasRdoAscendente.Checked = true;
        }
    }
}