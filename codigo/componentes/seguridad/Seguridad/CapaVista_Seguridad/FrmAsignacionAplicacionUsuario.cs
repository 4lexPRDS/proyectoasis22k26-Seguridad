using CapaControlador_Seguridad;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmAsignacionAplicacionUsuario : Form
    {
        private ClsModeloAsigAppUsuario _AsigAppUsuario = new ClsModeloAsigAppUsuario();

        public FrmAsignacionAplicacionUsuario()
        {
            InitializeComponent();

            this.Load += FrmAsignacionAplicacionUsuario_Load;
            BtnSeguridadInsertar.Click += BtnSeguridadInsertar_Click;
            BtnSeguridadQuitar.Click += BtnSeguridadQuitar_Click;
            BtnSeguridadBuscar.Click += BtnSeguridadBuscar_Click;
            BtnSeguridadSalir.Click += BtnSeguridadSalir_Click;
            SeguridadBtnAyuda.Click += SeguridadBtnAyuda_Click;
        }

        private void FrmAsignacionAplicacionUsuario_Load(object sender, EventArgs e)
        {
            SeguridadMetCargarCombos();
            SeguridadMetListarAsigAppUsuario();
        }

        private void SeguridadMetCargarCombos()
        {
            try
            {
                CboSeguridadUsuario.DataSource = _AsigAppUsuario.SeguridadMetObtenerUsuarios();
                CboSeguridadUsuario.DisplayMember = "nombreUsuario";
                CboSeguridadUsuario.ValueMember = "idUsuario";

                CboSeguridadModulo.DataSource = _AsigAppUsuario.SeguridadMetObtenerModulos();
                CboSeguridadModulo.DisplayMember = "nombreModulo";
                CboSeguridadModulo.ValueMember = "idModulo";

                SeguridadCboAplicacion.DataSource = _AsigAppUsuario.SeguridadMetObtenerAplicaciones();
                SeguridadCboAplicacion.DisplayMember = "nombreAplicacion";
                SeguridadCboAplicacion.ValueMember = "idAplicacion";

                CboSeguridadUsuario.SelectedIndex = -1;
                CboSeguridadModulo.SelectedIndex = -1;
                SeguridadCboAplicacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadMetListarAsigAppUsuario()
        {
            try
            {
                var Lista = _AsigAppUsuario.SeguridadMetObtenerTodos();
                SeguridadMetCargarGrid(Lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadMetCargarGrid(IEnumerable<ClsModeloAsigAppUsuario> Lista)
        {
            SeguridadDgvAsignaciones.Rows.Clear();

            DataTable Usuarios = CboSeguridadUsuario.DataSource as DataTable;
            DataTable Aplicaciones = SeguridadCboAplicacion.DataSource as DataTable;

            foreach (ClsModeloAsigAppUsuario Item in Lista)
            {
                string NombreUsuario = Item.IdUsuario.ToString();
                string NombreAplicacion = Item.IdAplicacion.ToString();

                if (Usuarios != null)
                {
                    DataRow[] FilaUsuario = Usuarios.Select("idUsuario = " + Item.IdUsuario);

                    if (FilaUsuario.Length > 0)
                    {
                        NombreUsuario = FilaUsuario[0]["nombreUsuario"].ToString();
                    }
                }

                if (Aplicaciones != null)
                {
                    DataRow[] FilaAplicacion = Aplicaciones.Select("idAplicacion = " + Item.IdAplicacion);

                    if (FilaAplicacion.Length > 0)
                    {
                        NombreAplicacion = FilaAplicacion[0]["nombreAplicacion"].ToString();
                    }
                }

                int Fila = SeguridadDgvAsignaciones.Rows.Add(
                    NombreUsuario,
                    NombreAplicacion,
                    "Sí"
                );

                SeguridadDgvAsignaciones.Rows[Fila].Tag = Item;
            }
        }

        private void BtnSeguridadInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CboSeguridadUsuario.SelectedIndex == -1 ||
                    CboSeguridadModulo.SelectedIndex == -1 ||
                    SeguridadCboAplicacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione Usuario, Módulo y Aplicación");
                    return;
                }

                _AsigAppUsuario.IdUsuario =
                    Convert.ToInt32(CboSeguridadUsuario.SelectedValue);

                _AsigAppUsuario.IdModulo =
                    Convert.ToInt32(CboSeguridadModulo.SelectedValue);

                _AsigAppUsuario.IdAplicacion =
                    Convert.ToInt32(SeguridadCboAplicacion.SelectedValue);

                _AsigAppUsuario.DerInsertarUsuarioModuloAplicacion = false;
                _AsigAppUsuario.DerEditarUsuarioModuloAplicacion = false;
                _AsigAppUsuario.DerEliminarUsuarioModuloAplicacion = false;
                _AsigAppUsuario.DerImprimirUsuarioModuloAplicacion = false;

                _AsigAppUsuario.Estado = EstadoEntidad.Added;

                bool Valido =
                    new ClsValidacionDatos(_AsigAppUsuario).SeguridadMetValidar();

                if (Valido)
                {
                    string Resultado =
                        _AsigAppUsuario.SeguridadMetGrabarCambios();

                    MessageBox.Show(Resultado);

                    SeguridadMetListarAsigAppUsuario();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeguridadDgvAsignaciones.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila");
                    return;
                }

                ClsModeloAsigAppUsuario Asignacion =
                    SeguridadDgvAsignaciones.CurrentRow.Tag
                    as ClsModeloAsigAppUsuario;

                if (Asignacion == null)
                {
                    return;
                }

                _AsigAppUsuario.IdUsuario = Asignacion.IdUsuario;
                _AsigAppUsuario.IdModulo = Asignacion.IdModulo;
                _AsigAppUsuario.IdAplicacion = Asignacion.IdAplicacion;

                _AsigAppUsuario.Estado = EstadoEntidad.Deleted;

                string Resultado =
                    _AsigAppUsuario.SeguridadMetGrabarCambios();

                MessageBox.Show(Resultado);

                SeguridadMetListarAsigAppUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CboSeguridadUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Usuario para buscar");
                    return;
                }

                int IdUsuario =
                    Convert.ToInt32(CboSeguridadUsuario.SelectedValue);

                var Resultado =
                    _AsigAppUsuario.SeguridadMetBuscarPorUsuario(IdUsuario);

                SeguridadMetCargarGrid(Resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Seleccione un Usuario, Módulo y Aplicación y presione Insertar."
            );
        }

        private void SeguridadMetReinicio()
        {
            CboSeguridadUsuario.SelectedIndex = -1;
            CboSeguridadModulo.SelectedIndex = -1;
            SeguridadCboAplicacion.SelectedIndex = -1;
        }
    }
}