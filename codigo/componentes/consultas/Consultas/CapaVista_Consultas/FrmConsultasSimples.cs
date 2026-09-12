using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas
{
    public partial class ConsultaSimple_400_001 : FrmBaseTerminus
    {
        ControladorConsultaSimple controlador = new ControladorConsultaSimple();

        //Variable dinámica de la tabla = empleado es eliminable
        public string TablaActual { get; set; } = "empleado";

        public ConsultaSimple_400_001()
        {
            InitializeComponent();

        }

        public ConsultaSimple_400_001( string tabla)
        {
            InitializeComponent();
            tablaSimple1.ConsultasProcActualizarTabla(tabla);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡El botón sí está funcionando!");/*
            string campoOrden = agrupar_Ordenar1.comboBox1.Text;
            string campoBusqueda = agrupar_Ordenar1.comboBox2.Text;
            string operador = agrupar_Ordenar1.comboBox3.Text;
            string valorBusqueda = agrupar_Ordenar1.textBox1.Text;

            bool ordenAscendente = agrupar_Ordenar1.radioButton1.Checked;

            string consultaArmada = controlador.GenerarConsultaDinamica(
                TablaActual,
                campoBusqueda,
                operador,
                valorBusqueda,
                campoOrden,
                ordenAscendente
            );*/
        }

        private void ConsultasBtnComplejas_Click(object sender, EventArgs e)
        {
            ConsultaCompleja_500_001 consultaCompleja_500_001 = new ConsultaCompleja_500_001();
            this.Hide();
            consultaCompleja_500_001.Show();
        }
    }
}