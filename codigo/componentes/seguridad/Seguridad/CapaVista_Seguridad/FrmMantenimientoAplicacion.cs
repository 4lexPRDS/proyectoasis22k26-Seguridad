using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
using CapaVista_Seguridad;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmMantenimientoAplicacion : Form{
        private ClsModeloMantenimientoApp _ModeloMantenimientoApp = new ClsModeloMantenimientoApp();
        public FrmMantenimientoAplicacion(){
            InitializeComponent();
        }

        private void FrmMantenimientoAplicacion_Load(object sender, EventArgs e){
            SeguridadMetCargarCombos();
            SeguridadMetListaAplicaciones();
        }

        private void SeguridadMetCargarCombos(){
            try
            {
                SeguridadCboIdModulo.DataSource = _ModeloMantenimientoApp.SeguridadMetGetModulos();
                SeguridadCboIdModulo.DisplayMember = "nombreModulo";
                SeguridadCboIdModulo.ValueMember = "idModulo";

                SeguridadCboBuscar.DataSource = _ModeloMantenimientoApp.SeguridadMetGetAplicaciones();
                SeguridadCboBuscar.DisplayMember = "nombreAplicacion";
                SeguridadCboBuscar.ValueMember = "idAplicacion";

                SeguridadCboEstado.Items.Clear();
                SeguridadCboEstado.Items.Add("Activo");
                SeguridadCboEstado.Items.Add("Inactivo");
                SeguridadCboEstado.SelectedIndex = 0;


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadMetListaAplicaciones(){
            try
            {
                SeguridadDgvAplicaciones.DataSource = _ModeloMantenimientoApp.SeguridadMetGetAll();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnNuevo_Click(Object sender, EventArgs e){
            SeguridadMetReinicio();
        }

        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _ModeloMantenimientoApp.IdModulo = Convert.ToInt32(SeguridadCboIdModulo.SelectedValue);
                _ModeloMantenimientoApp.NombreAplicacion = SeguridadTxtNombreAplicacion.Text;
                _ModeloMantenimientoApp.DescripcionAplicacion = SeguridadTxtDescripcion.Text;
                _ModeloMantenimientoApp.IsActive = SeguridadCboEstado.SelectedItem.ToString() == "Activo";
                _ModeloMantenimientoApp.Estado = EstadoEntidad.Added;

                bool Valido = new ValidacionDatos(_ModeloMantenimientoApp).Validar();

                if (Valido)
                {
                    string Resultado = _ModeloMantenimientoApp.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListaAplicaciones();
                    SeguridadMetReinicio();
                }
            }

            catch (Exception Ex)
            {
                    MessageBox.Show(Ex.ToString());
            }
        }   

       private void SeguridadBtnModificar_Click(Object sender, EventArgs e)
       {
            try
            {
                _ModeloMantenimientoApp.IdAplicacion = Convert.ToInt32(SeguridadTxtIdAplicacion.Text);
                _ModeloMantenimientoApp.IdModulo = Convert.ToInt32(SeguridadCboIdModulo.SelectedValue);
                _ModeloMantenimientoApp.NombreAplicacion = SeguridadTxtNombreAplicacion.Text;
                _ModeloMantenimientoApp.DescripcionAplicacion = SeguridadTxtDescripcion.Text;
                _ModeloMantenimientoApp.IsActive = SeguridadCboEstado.SelectedItem.ToString() == "Activo";
                _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;

                    bool Valido = new ValidacionDatos(_ModeloMantenimientoApp).Validar();
                    if (Valido)
                    {
                        string Resultado = _ModeloMantenimientoApp.SeguridadMetGrabarCambios();
                        MessageBox.Show(Resultado);
                        SeguridadMetListaAplicaciones();
                        SeguridadMetReinicio();
                    }
            }
            catch (Exception Ex)
            {
                    MessageBox.Show(Ex.ToString());
            }
       }
          

        private void SeguridadBtnBuscar_Click(Object sender, EventArgs e)
        {
            try
            {
                int IdAplicacion = Convert.ToInt32(SeguridadCboBuscar.SelectedValue);
                var Resultado = _ModeloMantenimientoApp.SeguridadMetFindById(IdAplicacion);

                if (Resultado != null)
                {
                    SeguridadTxtIdAplicacion.Text = Resultado.IdAplicacion.ToString();
                    SeguridadCboIdModulo.SelectedValue = Resultado.IdModulo;
                    SeguridadTxtNombreAplicacion.Text = Resultado.NombreAplicacion;
                    SeguridadTxtDescripcion.Text = Resultado.DescripcionAplicacion;
                    SeguridadCboEstado.SelectedItem = Resultado.IsActive ? "Activo" : "Inactivo";
                    _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnEliminar_Click(Object sender, EventArgs e)
        {
            try
            {
                if (SeguridadDgvAplicaciones.SelectedRows.Count > 0)
                {
                    var Confirmacion = MessageBox.Show(
                    "¿Estas seguro que deseas eliminar este registro?", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Confirmacion == DialogResult.Yes)
                    {
                        _ModeloMantenimientoApp.IdAplicacion = Convert.ToInt32(SeguridadDgvAplicaciones.CurrentRow.Cells[0].Value);
                        _ModeloMantenimientoApp.Estado = EstadoEntidad.Deleted;

                        string Resultado = _ModeloMantenimientoApp.SeguridadMetGrabarCambios();
                        MessageBox.Show(Resultado);
                        SeguridadMetListaAplicaciones();
                        SeguridadMetReinicio();
                    }

                }
                else
                {
                    MessageBox.Show("Seleccionar una fila para eliminar");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnSalir_Click(Object sender, EventArgs e)
        {
            this.Close();
        }


        private void SeguridadMetReinicio()
        {
            SeguridadTxtIdAplicacion.Text = string.Empty;
            SeguridadTxtNombreAplicacion.Text = string.Empty;
            SeguridadTxtDescripcion.Text = string.Empty;
            SeguridadCboEstado.SelectedIndex = 0;
            SeguridadCboIdModulo.SelectedIndex = 0;
            _ModeloMantenimientoApp.Estado = EstadoEntidad.Added;
        }

        private void SeguridadBtnReporte_Click(object sender, EventArgs e)
        {

        }

        private void SeguridadDgvAplicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (SeguridadDgvAplicaciones.SelectedRows.Count > 0)
             {
                    SeguridadTxtIdAplicacion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[0].Value.ToString();
                    SeguridadCboIdModulo.SelectedValue = Convert.ToInt32(SeguridadDgvAplicaciones.CurrentRow.Cells[1].Value);
                    SeguridadTxtNombreAplicacion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[2].Value.ToString();
                    SeguridadTxtDescripcion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[3].Value.ToString();
                    SeguridadCboEstado.SelectedItem = Convert.ToBoolean(SeguridadDgvAplicaciones.CurrentRow.Cells[4].Value) ? "Activo" : "Inactivo";
                    _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;
             }
        }
    }
}
