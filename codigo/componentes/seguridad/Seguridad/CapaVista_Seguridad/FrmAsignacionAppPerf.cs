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
    public partial class FrmAsignacionAppPerf : Form
    {
        private ModeloAsigAppPerf asigAppPerf = new ModeloAsigAppPerf();

        public FrmAsignacionAppPerf()
        {
            InitializeComponent();
        }

        private void FrmAsignacionAppPerf_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ListaAsigAppPerf();
        }

        private void CargarCombos()
        {
            try
            {
                CboSeguridadPerfiles.DataSource = asigAppPerf.GetRoles();
                CboSeguridadPerfiles.DisplayMember = "nombreRol";
                CboSeguridadPerfiles.ValueMember = "idRol";

                CboSeguridadModulos.DataSource = asigAppPerf.GetModulos();
                CboSeguridadModulos.DisplayMember = "nombreModulo";
                CboSeguridadModulos.ValueMember = "idModulo";

                CboSeguridadAplicaciones.DataSource = asigAppPerf.GetAplicaciones();
                CboSeguridadAplicaciones.DisplayMember = "nombreAplicacion";
                CboSeguridadAplicaciones.ValueMember = "idAplicacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ListaAsigAppPerf()
        {
            try
            {
                DgvSeguridadListaUsuarios.DataSource = asigAppPerf.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblPerfiles_Click(object sender, EventArgs e)
        {
        }

        private void CboSeguridadAplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CboSeguridadPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CboSeguridadModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void chkSeguridadInsertar_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkSeguridadEditar_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkSeguridadeliminar_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkSeguridadImprimir_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BtnSeguridadAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un Perfil, Módulo y Aplicación, marque los permisos deseados y presione Agregar.");
        }

        private void BtnSeguridadAgregar_Click(object sender, EventArgs e)
        {
            CboSeguridadPerfiles.SelectedIndex = -1;
            CboSeguridadModulos.SelectedIndex = -1;
            CboSeguridadAplicaciones.SelectedIndex = -1;

            chkSeguridadInsertar.Checked = false;
            chkSeguridadEditar.Checked = false;
            chkSeguridadeliminar.Checked = false;
            chkSeguridadImprimir.Checked = false;

            asigAppPerf.Estado = EstadoEntidad.Added;

            CboSeguridadPerfiles.Enabled = true;
            CboSeguridadModulos.Enabled = true;
            CboSeguridadAplicaciones.Enabled = true;
        }

        private void BtnSeguridadBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtSeguridadFiltro.Text))
                {
                    MessageBox.Show("Ingrese un ID de Rol para filtrar");
                    return;
                }

                int idRol = Convert.ToInt32(TxtSeguridadFiltro.Text);
                DgvSeguridadListaUsuarios.DataSource = asigAppPerf.FindByRol(idRol);
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID de Rol debe ser un número");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadQuitar_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.SelectedRows.Count > 0)
            {
                asigAppPerf.Estado = EstadoEntidad.Deleted;
                asigAppPerf.IdRol = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells[0].Value);
                asigAppPerf.IdModulo = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells[1].Value);
                asigAppPerf.IdAplicacion = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells[2].Value);

                string resultado = asigAppPerf.GrabarCambios();
                MessageBox.Show(resultado);
                ListaAsigAppPerf();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void BtnSeguridadImprimir_Click(object sender, EventArgs e)
        {
            // TODO: lógica para imprimir el contenido de DgvSeguridadListaUsuarios
        }

        private void BtnSeguridadSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvSeguridadListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSeguridadListaUsuarios.SelectedRows.Count > 0)
            {
                asigAppPerf.Estado = EstadoEntidad.Modified;
                CboSeguridadPerfiles.SelectedValue = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells[0].Value);
                CboSeguridadModulos.SelectedValue = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells[1].Value);
                CboSeguridadAplicaciones.SelectedValue = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells[2].Value);
                chkSeguridadInsertar.Checked = Convert.ToBoolean(DgvSeguridadListaUsuarios.CurrentRow.Cells[3].Value);
                chkSeguridadEditar.Checked = Convert.ToBoolean(DgvSeguridadListaUsuarios.CurrentRow.Cells[4].Value);
                chkSeguridadeliminar.Checked = Convert.ToBoolean(DgvSeguridadListaUsuarios.CurrentRow.Cells[5].Value);
                chkSeguridadImprimir.Checked = Convert.ToBoolean(DgvSeguridadListaUsuarios.CurrentRow.Cells[6].Value);
            }
        }

        private void Reinicio()
        {
            chkSeguridadInsertar.Checked = false;
            chkSeguridadEditar.Checked = false;
            chkSeguridadeliminar.Checked = false;
            chkSeguridadImprimir.Checked = false;
        }

        private void PnlSeguridadPnlDecorativo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSeguridadModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvSeguridadListaUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila del listado para modificar");
                    return;
                }

                asigAppPerf.IdRol = Convert.ToInt32(CboSeguridadPerfiles.SelectedValue);
                asigAppPerf.IdModulo = Convert.ToInt32(CboSeguridadModulos.SelectedValue);
                asigAppPerf.IdAplicacion = Convert.ToInt32(CboSeguridadAplicaciones.SelectedValue);
                asigAppPerf.DerInsertarRolModuloAplicacion = chkSeguridadInsertar.Checked;
                asigAppPerf.DerEditarRolModuloAplicacion = chkSeguridadEditar.Checked;
                asigAppPerf.DerEliminarRolModuloAplicacion = chkSeguridadeliminar.Checked;
                asigAppPerf.DerImprimirRolModuloAplicacion = chkSeguridadImprimir.Checked;
                asigAppPerf.Estado = EstadoEntidad.Modified;

                bool valido = new ValidacionDatos(asigAppPerf).Validar();
                if (valido)
                {
                    string resultado = asigAppPerf.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaAsigAppPerf();
                    Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                asigAppPerf.IdRol = Convert.ToInt32(CboSeguridadPerfiles.SelectedValue);
                asigAppPerf.IdModulo = Convert.ToInt32(CboSeguridadModulos.SelectedValue);
                asigAppPerf.IdAplicacion = Convert.ToInt32(CboSeguridadAplicaciones.SelectedValue);
                asigAppPerf.DerInsertarRolModuloAplicacion = chkSeguridadInsertar.Checked;
                asigAppPerf.DerEditarRolModuloAplicacion = chkSeguridadEditar.Checked;
                asigAppPerf.DerEliminarRolModuloAplicacion = chkSeguridadeliminar.Checked;
                asigAppPerf.DerImprimirRolModuloAplicacion = chkSeguridadImprimir.Checked;
                asigAppPerf.Estado = EstadoEntidad.Added;

                bool valido = new ValidacionDatos(asigAppPerf).Validar();
                if (valido)
                {
                    string resultado = asigAppPerf.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaAsigAppPerf();
                    Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadReporte_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeguridadActualizar_Click(object sender, EventArgs e)
        {
            TxtSeguridadFiltro.Clear();
            ListaAsigAppPerf();
        }

        private void BtnSeguridadInicio_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.Rows.Count > 0)
            {
                DgvSeguridadListaUsuarios.ClearSelection();
                DgvSeguridadListaUsuarios.Rows[0].Selected = true;
                DgvSeguridadListaUsuarios.CurrentCell = DgvSeguridadListaUsuarios.Rows[0].Cells[0];
            }
        }

        private void BtnSeguridadAnterior_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.Rows.Count > 0 && DgvSeguridadListaUsuarios.CurrentCell != null)
            {
                int filaActual = DgvSeguridadListaUsuarios.CurrentCell.RowIndex;
                if (filaActual > 0)
                {
                    DgvSeguridadListaUsuarios.ClearSelection();
                    DgvSeguridadListaUsuarios.Rows[filaActual - 1].Selected = true;
                    DgvSeguridadListaUsuarios.CurrentCell = DgvSeguridadListaUsuarios.Rows[filaActual - 1].Cells[0];
                }
            }
        }

        private void BtnSeguridadSiguiente_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.Rows.Count > 0 && DgvSeguridadListaUsuarios.CurrentCell != null)
            {
                int filaActual = DgvSeguridadListaUsuarios.CurrentCell.RowIndex;
                if (filaActual < DgvSeguridadListaUsuarios.Rows.Count - 1)
                {
                    DgvSeguridadListaUsuarios.ClearSelection();
                    DgvSeguridadListaUsuarios.Rows[filaActual + 1].Selected = true;
                    DgvSeguridadListaUsuarios.CurrentCell = DgvSeguridadListaUsuarios.Rows[filaActual + 1].Cells[0];
                }
            }
        }

        private void BtnSeguridadFin_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.Rows.Count > 0)
            {
                int ultimaFila = DgvSeguridadListaUsuarios.Rows.Count - 1;
                DgvSeguridadListaUsuarios.ClearSelection();
                DgvSeguridadListaUsuarios.Rows[ultimaFila].Selected = true;
                DgvSeguridadListaUsuarios.CurrentCell = DgvSeguridadListaUsuarios.Rows[ultimaFila].Cells[0];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}