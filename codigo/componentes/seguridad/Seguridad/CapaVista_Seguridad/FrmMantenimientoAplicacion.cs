using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
using CapaControlador_Seguridad.Objetos_de_valor;
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
    public partial class FrmMantenimientoAplicacion : Form
    {
        private ClsModeloMantenimientoApp _ModeloMantenimientoApp = new ClsModeloMantenimientoApp();

        private ClsPermisoAplicacion _MisPermisos;
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 7;
        public FrmMantenimientoAplicacion()
        {
            InitializeComponent();
            SeguridadMetReinicio();
        }

        private void FrmMantenimientoAplicacion_Load(object sender, EventArgs e)
        {
            SeguridadMetCargarCombos();
            SeguridadMetListaAplicaciones();

            var MapaBotones = new Dictionary<Control, TipoPermiso>
            {
                { SeguridadBtnGuardar, TipoPermiso.Insertar },
                { SeguridadBtnModificar, TipoPermiso.Editar },
                { SeguridadBtnEliminar, TipoPermiso.Eliminar }
            };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                this, ID_MODULO, ID_APLICACION, MapaBotones);

            if (!_MisPermisos.TieneAcceso) 
                return;
        }

        private void SeguridadMetCargarCombos()
        {
            try
            {
                SeguridadCboIdModulo.DataSource = _ModeloMantenimientoApp.SeguridadMetObtenerModulos();
                SeguridadCboIdModulo.DisplayMember = "NombreModulo";
                SeguridadCboIdModulo.ValueMember = "IdModulo";

                SeguridadCboBuscar.DataSource = _ModeloMantenimientoApp.SeguridadMetObtenerAplicaciones();
                SeguridadCboBuscar.DisplayMember = "NombreAplicacion";
                SeguridadCboBuscar.ValueMember = "IdAplicacion";

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadMetListaAplicaciones()
        {
            try
            {
                SeguridadDgvAplicaciones.DataSource = _ModeloMantenimientoApp.SeguridadMetObtenerTodos();

                SeguridadDgvAplicaciones.Columns[0].HeaderText = "Aplicacion";
                SeguridadDgvAplicaciones.Columns[1].HeaderText = "Modulo ";
                SeguridadDgvAplicaciones.Columns[2].HeaderText = "Nombre";
                SeguridadDgvAplicaciones.Columns[3].HeaderText = "Descripcion";
                SeguridadDgvAplicaciones.Columns[4].HeaderText = "Activo";
                SeguridadDgvAplicaciones.Columns[5].HeaderText = "Fecha Creacion";
                SeguridadDgvAplicaciones.Columns[6].HeaderText = "Ultima Actualizacion";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _ModeloMantenimientoApp.IdModulo = Convert.ToInt32(SeguridadCboIdModulo.SelectedValue);
                _ModeloMantenimientoApp.NombreAplicacion = SeguridadTxtNombreAplicacion.Text;
                _ModeloMantenimientoApp.DescripcionAplicacion = SeguridadTxtDescripcion.Text;
                _ModeloMantenimientoApp.IsActive = SeguridadChkEstado.Checked;
                _ModeloMantenimientoApp.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_ModeloMantenimientoApp).SeguridadMetValidar();

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
                _ModeloMantenimientoApp.IsActive = SeguridadChkEstado.Checked;
                _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;

                bool Valido = new ClsValidacionDatos(_ModeloMantenimientoApp).SeguridadMetValidar();
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
                var Resultado = _ModeloMantenimientoApp.SeguridadMetBuscarPorId(IdAplicacion);

                if (Resultado != null)
                {
                    SeguridadTxtIdAplicacion.Text = Resultado.IdAplicacion.ToString();
                    SeguridadCboIdModulo.SelectedValue = Resultado.IdModulo;
                    SeguridadTxtNombreAplicacion.Text = Resultado.NombreAplicacion;
                    SeguridadTxtDescripcion.Text = Resultado.DescripcionAplicacion;
                    SeguridadChkEstado.Checked = Resultado.IsActive;
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

        private void SeguridadMetCargarFila(int Indice)
        {
            SeguridadDgvAplicaciones.ClearSelection();
            SeguridadDgvAplicaciones.Rows[Indice].Selected = true;
            SeguridadDgvAplicaciones.CurrentCell = SeguridadDgvAplicaciones.Rows[Indice].Cells[0];

            SeguridadTxtIdAplicacion.Text = SeguridadDgvAplicaciones.Rows[Indice].Cells[0].Value.ToString();
            SeguridadCboIdModulo.SelectedValue = Convert.ToInt32(SeguridadDgvAplicaciones.Rows[Indice].Cells[1].Value);
            SeguridadTxtNombreAplicacion.Text = SeguridadDgvAplicaciones.Rows[Indice].Cells[2].Value.ToString();
            SeguridadTxtDescripcion.Text = SeguridadDgvAplicaciones.Rows[Indice].Cells[3].Value.ToString();
            SeguridadChkEstado.Checked= Convert.ToBoolean(SeguridadDgvAplicaciones.Rows[Indice].Cells[4].Value);
            _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;

        }

        private void SeguridadMetReinicio()
        {
            SeguridadTxtIdAplicacion.Text = string.Empty;
            SeguridadTxtNombreAplicacion.Text = string.Empty;
            SeguridadTxtDescripcion.Text = string.Empty;
            SeguridadChkEstado.Checked = false;
            if (SeguridadCboIdModulo.Items.Count > 0)
                SeguridadCboIdModulo.SelectedIndex = 0;
            _ModeloMantenimientoApp.Estado = EstadoEntidad.Added;

            SeguridadPnlFormulario.Enabled = false;
            SeguridadCboBuscar.Enabled = false;
            SeguridadBtnGuardar.Enabled = false;
            SeguridadBtnModificar.Enabled = false;
            SeguridadBtnEliminar.Enabled = false;
            SeguridadBtnCancelar.Enabled = false;
            SeguridadBtnBuscar.Enabled = false;
            SeguridadBtnRefrescar.Enabled = false;
            SeguridadBtnInicio.Enabled = false;
            SeguridadBtnAnterior.Enabled = false;
            SeguridadBtnSiguiente.Enabled = false;
            SeguridadBtnFin.Enabled = false;
            SeguridadBtnImprimir.Enabled = false;
            SeguridadBtnReporte.Enabled = false;
        }

        private void SeguridadDgvAplicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SeguridadDgvAplicaciones.SelectedRows.Count > 0)
            {
                SeguridadTxtIdAplicacion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[0].Value.ToString();
                SeguridadCboIdModulo.SelectedValue = Convert.ToInt32(SeguridadDgvAplicaciones.CurrentRow.Cells[1].Value);
                SeguridadTxtNombreAplicacion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[2].Value.ToString();
                SeguridadTxtDescripcion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[3].Value.ToString();
                SeguridadChkEstado.Checked = Convert.ToBoolean(SeguridadDgvAplicaciones.CurrentRow.Cells[4].Value);
                _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;


            }
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            SeguridadCboBuscar.SelectedIndex = 0;
            SeguridadMetListaAplicaciones();
            SeguridadMetReinicio();
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAplicaciones.Rows.Count > 0)
            {
                SeguridadMetCargarFila(0);
            }
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAplicaciones.Rows.Count > 0 && SeguridadDgvAplicaciones.CurrentCell != null)
            {
                int FilaActual = SeguridadDgvAplicaciones.CurrentCell.RowIndex;
                if (FilaActual > 0)
                {
                    SeguridadMetCargarFila(FilaActual - 1);
                }
            }
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAplicaciones.Rows.Count > 0 && SeguridadDgvAplicaciones.CurrentCell != null)
            {
                int FilaActual = SeguridadDgvAplicaciones.CurrentCell.RowIndex;
                if (FilaActual < SeguridadDgvAplicaciones.Rows.Count - 1)
                {
                    SeguridadMetCargarFila(FilaActual + 1);
                }
            }
        }

        private void SeguridadBtnFin_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAplicaciones.Rows.Count > 0)
            {
                SeguridadMetCargarFila(SeguridadDgvAplicaciones.Rows.Count - 1);
            }
        }

        private void SeguridadBtnIngresar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
            SeguridadPnlFormulario.Enabled = true;
            SeguridadCboBuscar.Enabled = true;
            SeguridadBtnGuardar.Enabled = _MisPermisos.PuedeInsertar;
            SeguridadBtnModificar.Enabled = _MisPermisos.PuedeEditar;
            SeguridadBtnEliminar.Enabled = _MisPermisos.PuedeEliminar;
            SeguridadBtnImprimir.Enabled = _MisPermisos.PuedeImprimir;
            SeguridadBtnReporte.Enabled = _MisPermisos.PuedeImprimir;
            SeguridadBtnCancelar.Enabled = true;
            SeguridadBtnBuscar.Enabled = true;
            SeguridadBtnRefrescar.Enabled = true;
            SeguridadBtnInicio.Enabled = true;
            SeguridadBtnAnterior.Enabled = true;
            SeguridadBtnSiguiente.Enabled = true;
            SeguridadBtnFin.Enabled = true;
        }

        private void SeguridadBtnCancelar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
        }
    }
}