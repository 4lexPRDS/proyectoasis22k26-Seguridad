using CapaControlador_Seguridad;
using CapaVista_Seguridad;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2k26
{
    public partial class FrmMantenimientoEmpleado : Form
    {
        private ModeloEmpleado empleado = new ModeloEmpleado();

        public FrmMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            ListaEmpleados();
        }

        private void ListaEmpleados()
        {
            try
            {
                SeguridadDgvEmpleados.DataSource = empleado.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadCboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SeguridadChkActivo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complete los datos del empleado y presione Guardar.");
        }

        private void SeguridadBtnAgregar_Click(object sender, EventArgs e)
        {
            SeguridadTxtCodigo.Text = "";
            SeguridadTxtDpi.Text = "";
            SeguridadTxtNit.Text = "";
            SeguridadTxtNombres.Text = "";
            SeguridadTxtApellidos.Text = "";
            SeguridadTxtPuesto.Text = "";
            SeguridadCboGenero.SelectedIndex = -1;
            SeguridadTxtTelefono.Text = "";
            SeguridadTxtCorreo.Text = "";

            empleado.Estado = EstadoEntidad.Added;

            SeguridadCboGenero.Enabled = true;
        }

        private void SeguridadBtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SeguridadTxtIdEmpleado.Text))
                {
                    MessageBox.Show("Ingrese un Id de Empleado para filtrar");
                    return;
                }

                int idEmpleado = Convert.ToInt32(SeguridadTxtIdEmpleado.Text);
                SeguridadDgvEmpleados.DataSource = empleado.FindbyId(idEmpleado);
            }
            catch (FormatException)
            {
                MessageBox.Show("El Id de Empleado debe ser un número");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnEliminar_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.SelectedRows.Count > 0)
            {
                empleado.Estado = EstadoEntidad.Deleted;
                empleado.IdEmpleado = Convert.ToInt32(SeguridadDgvEmpleados.CurrentRow.Cells[0].Value);

                string resultado = empleado.GrabarCambios();
                MessageBox.Show(resultado);
                ListaEmpleados();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void SeguridadBtnImprimir_Click(object sender, EventArgs e)
        {
            // TODO: lógica para imprimir el contenido de SeguridadDgvEmpleados
        }

        private void SeguridadBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadDgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SeguridadDgvEmpleados.SelectedRows.Count > 0)
            {
                empleado.Estado = EstadoEntidad.Modified;
                SeguridadTxtIdEmpleado.Text = SeguridadDgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                SeguridadTxtCodigo.Text = SeguridadDgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                SeguridadTxtDpi.Text = SeguridadDgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                SeguridadTxtNit.Text = SeguridadDgvEmpleados.CurrentRow.Cells[3].Value?.ToString();
                SeguridadTxtNombres.Text = SeguridadDgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                SeguridadTxtApellidos.Text = SeguridadDgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                SeguridadTxtPuesto.Text = SeguridadDgvEmpleados.CurrentRow.Cells[6].Value.ToString();
                SeguridadCboGenero.SelectedItem = SeguridadDgvEmpleados.CurrentRow.Cells[7].Value.ToString();
                SeguridadDtpFechaNacimiento.Value = Convert.ToDateTime(SeguridadDgvEmpleados.CurrentRow.Cells[8].Value);
                SeguridadDtpFechaContratacion.Value = Convert.ToDateTime(SeguridadDgvEmpleados.CurrentRow.Cells[9].Value);
                SeguridadTxtTelefono.Text = SeguridadDgvEmpleados.CurrentRow.Cells[10].Value?.ToString();
                SeguridadTxtCorreo.Text = SeguridadDgvEmpleados.CurrentRow.Cells[11].Value?.ToString();
                SeguridadChkActivo.Checked = Convert.ToBoolean(SeguridadDgvEmpleados.CurrentRow.Cells[12].Value);
            }
        }

        private void Reinicio()
        {
            SeguridadTxtCodigo.Text = "";
            SeguridadTxtDpi.Text = "";
            SeguridadTxtNit.Text = "";
            SeguridadTxtNombres.Text = "";
            SeguridadTxtApellidos.Text = "";
            SeguridadTxtPuesto.Text = "";
            SeguridadCboGenero.SelectedIndex = -1;
            SeguridadTxtTelefono.Text = "";
            SeguridadTxtCorreo.Text = "";
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeguridadDgvEmpleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila del listado para modificar");
                    return;
                }

                empleado.IdEmpleado = Convert.ToInt32(SeguridadTxtIdEmpleado.Text);
                empleado.CodigoEmpleado = SeguridadTxtCodigo.Text;
                empleado.DpiEmpleado = SeguridadTxtDpi.Text;
                empleado.NitEmpleado = SeguridadTxtNit.Text;
                empleado.NombresEmpleado = SeguridadTxtNombres.Text;
                empleado.ApellidosEmpleado = SeguridadTxtApellidos.Text;
                empleado.PuestoEmpleado = SeguridadTxtPuesto.Text;
                empleado.GeneroEmpleado = SeguridadCboGenero.SelectedItem?.ToString();
                empleado.FechaNacimientoEmpleado = SeguridadDtpFechaNacimiento.Value;
                empleado.FechaContratacionEmpleado = SeguridadDtpFechaContratacion.Value;
                empleado.TelefonoEmpleado = SeguridadTxtTelefono.Text;
                empleado.CorreoEmpleado = SeguridadTxtCorreo.Text;
                empleado.Estado = EstadoEntidad.Modified;

                bool valido = new ValidacionDatos(empleado).Validar();
                if (valido)
                {
                    string resultado = empleado.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaEmpleados();
                    Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                empleado.CodigoEmpleado = SeguridadTxtCodigo.Text;
                empleado.DpiEmpleado = SeguridadTxtDpi.Text;
                empleado.NitEmpleado = SeguridadTxtNit.Text;
                empleado.NombresEmpleado = SeguridadTxtNombres.Text;
                empleado.ApellidosEmpleado = SeguridadTxtApellidos.Text;
                empleado.PuestoEmpleado = SeguridadTxtPuesto.Text;
                empleado.GeneroEmpleado = SeguridadCboGenero.SelectedItem?.ToString();
                empleado.FechaNacimientoEmpleado = SeguridadDtpFechaNacimiento.Value;
                empleado.FechaContratacionEmpleado = SeguridadDtpFechaContratacion.Value;
                empleado.TelefonoEmpleado = SeguridadTxtTelefono.Text;
                empleado.CorreoEmpleado = SeguridadTxtCorreo.Text;
                empleado.Estado = EstadoEntidad.Added;

                bool valido = new ValidacionDatos(empleado).Validar();
                if (valido)
                {
                    string resultado = empleado.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaEmpleados();
                    Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnLimpiar_Click(object sender, EventArgs e)
        {
            SeguridadTxtIdEmpleado.Clear();
            Reinicio();
            ListaEmpleados();
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            SeguridadTxtIdEmpleado.Clear();
            ListaEmpleados();
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.Rows.Count > 0)
            {
                SeguridadDgvEmpleados.ClearSelection();
                SeguridadDgvEmpleados.Rows[0].Selected = true;
                SeguridadDgvEmpleados.CurrentCell = SeguridadDgvEmpleados.Rows[0].Cells[0];
            }
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.Rows.Count > 0 && SeguridadDgvEmpleados.CurrentCell != null)
            {
                int filaActual = SeguridadDgvEmpleados.CurrentCell.RowIndex;
                if (filaActual > 0)
                {
                    SeguridadDgvEmpleados.ClearSelection();
                    SeguridadDgvEmpleados.Rows[filaActual - 1].Selected = true;
                    SeguridadDgvEmpleados.CurrentCell = SeguridadDgvEmpleados.Rows[filaActual - 1].Cells[0];
                }
            }
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.Rows.Count > 0 && SeguridadDgvEmpleados.CurrentCell != null)
            {
                int filaActual = SeguridadDgvEmpleados.CurrentCell.RowIndex;
                if (filaActual < SeguridadDgvEmpleados.Rows.Count - 1)
                {
                    SeguridadDgvEmpleados.ClearSelection();
                    SeguridadDgvEmpleados.Rows[filaActual + 1].Selected = true;
                    SeguridadDgvEmpleados.CurrentCell = SeguridadDgvEmpleados.Rows[filaActual + 1].Cells[0];
                }
            }
        }

        private void SeguridadBtnFin_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.Rows.Count > 0)
            {
                int ultimaFila = SeguridadDgvEmpleados.Rows.Count - 1;
                SeguridadDgvEmpleados.ClearSelection();
                SeguridadDgvEmpleados.Rows[ultimaFila].Selected = true;
                SeguridadDgvEmpleados.CurrentCell = SeguridadDgvEmpleados.Rows[ultimaFila].Cells[0];
            }
        }
    }
}