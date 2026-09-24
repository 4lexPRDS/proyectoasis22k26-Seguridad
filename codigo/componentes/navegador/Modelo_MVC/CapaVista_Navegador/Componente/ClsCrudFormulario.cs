using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaControlador_Navegador;
using CapaEntidades_Navegador;

namespace CapaVista_Navegador
{
    // Arma el panel dinamico de un registro: labels, textbox, combo, fecha, checkbox
    public class ClsCrudFormulario
    {
        private Form _Formulario;
        private Panel NavegadorPnlRegistro;
        private Dictionary<string, Control> _Controles;
        private List<ClsColumnaInfo> _Esquema;
        private string _Tabla;
        private bool _ModoModificar;

        private ClsCtrlTabla _CtrlTabla = new ClsCtrlTabla();
        private ClsCtrlEsquema _CtrlEsquema = new ClsCtrlEsquema();

        public bool Visible
        {
            get { return NavegadorPnlRegistro != null && NavegadorPnlRegistro.Visible; }
        }

        public bool ModoModificar
        {
            get { return _ModoModificar; }
        }

        public int Bottom
        {
            get { return NavegadorPnlRegistro != null ? NavegadorPnlRegistro.Bottom : 0; }
        }

        public ClsCrudFormulario(Form Formulario)
        {
            this._Formulario = Formulario;
        }

        public void NavegadorMetAbrir(string Tabla, List<ClsColumnaInfo> Esquema, bool Modificar, DataGridViewRow Fila, ClsCrudGrid GridControl, int PosicionY)
        {
            NavegadorMetCerrar();

            this._Tabla = Tabla;
            this._Esquema = Esquema;
            this._ModoModificar = Modificar;

            NavegadorPnlRegistro = new Panel();
            NavegadorPnlRegistro.Name = "NavegadorPnlRegistro";
            NavegadorPnlRegistro.Location = new Point(10, PosicionY);
            NavegadorPnlRegistro.Width = _Formulario.ClientSize.Width - 20;

            int Altura = 50 + _Esquema.Count * 42;
            if (Altura < 150) Altura = 150;
            if (Altura > 400) Altura = 400;
            NavegadorPnlRegistro.Height = Altura;

            NavegadorPnlRegistro.BackColor = Color.FromArgb(242, 233, 217);
            NavegadorPnlRegistro.BorderStyle = BorderStyle.FixedSingle;
            NavegadorPnlRegistro.AutoScroll = true;

            _Formulario.Controls.Add(NavegadorPnlRegistro);

            _Controles = new Dictionary<string, Control>();

            Label NavegadorLblTitulo = new Label();
            NavegadorLblTitulo.Text = (Modificar ? "Modificar registro - " : "Nuevo registro - ") + _Tabla;
            NavegadorLblTitulo.Font = new Font(_Formulario.Font.FontFamily, 10, FontStyle.Bold);
            NavegadorLblTitulo.AutoSize = true;
            NavegadorLblTitulo.Location = new Point(10, 8);
            NavegadorPnlRegistro.Controls.Add(NavegadorLblTitulo);

            int PosicionYCampo = 34;

            foreach (ClsColumnaInfo Col in _Esquema)
            {
                Control ControlCampo = NavegadorMetCrearControlColumna(Col, Modificar, Fila, GridControl, PosicionYCampo);

                Label NavegadorLblCampo = new Label();
                NavegadorLblCampo.Text = Col.Nombre + (Col.EsPK ? " [PK]" : "") + (Col.EsFK ? " [FK]" : "");
                NavegadorLblCampo.Location = new Point(15, PosicionYCampo + 4);
                NavegadorLblCampo.AutoSize = true;

                if (Col.EsPK)
                {
                    NavegadorLblCampo.Font = new Font(NavegadorLblCampo.Font, FontStyle.Bold);
                    NavegadorLblCampo.ForeColor = Color.DarkRed;
                }
                else if (Col.EsFK)
                {
                    NavegadorLblCampo.Font = new Font(NavegadorLblCampo.Font, FontStyle.Bold);
                    NavegadorLblCampo.ForeColor = Color.DarkBlue;
                }

                NavegadorPnlRegistro.Controls.Add(NavegadorLblCampo);
                NavegadorPnlRegistro.Controls.Add(ControlCampo);

                _Controles[Col.Nombre] = ControlCampo;
                PosicionYCampo += 42;
            }

            NavegadorPnlRegistro.Visible = true;
            NavegadorPnlRegistro.BringToFront();
        }

        // Decide que ControlCampo dibujar segun el tipo de Columna
        private Control NavegadorMetCrearControlColumna(ClsColumnaInfo Col, bool Modificar, DataGridViewRow Fila, ClsCrudGrid GridControl, int PosicionY)
        {
            if (Col.EsFK && !string.IsNullOrWhiteSpace(Col.TablaFK) && !string.IsNullOrWhiteSpace(Col.ColumnaFK))
            {
                ComboBox NavegadorCboCampo = NavegadorMetCrearComboFk(Col, Fila, GridControl);
                NavegadorCboCampo.Location = new Point(190, PosicionY);
                NavegadorCboCampo.Width = 250;
                NavegadorCboCampo.Enabled = !(Col.EsPK && Modificar);
                return NavegadorCboCampo;
            }

            if (ClsTipoColumna.NavegadorFuncEsFecha(Col))
            {
                DateTimePicker NavegadorDtpFecha = new DateTimePicker();
                NavegadorDtpFecha.Location = new Point(190, PosicionY);
                NavegadorDtpFecha.Width = 250;
                NavegadorDtpFecha.Format = DateTimePickerFormat.Short;
                NavegadorDtpFecha.Value = NavegadorFuncObtenerFechaInicial(Fila, Col.Nombre, GridControl);
                NavegadorDtpFecha.Enabled = !(Col.EsPK && Modificar);
                return NavegadorDtpFecha;
            }

            if (ClsTipoColumna.NavegadorFuncEsBooleano(Col))
            {
                CheckBox NavegadorChkCampo = new CheckBox();
                NavegadorChkCampo.Text = "Sí (marcado) / No (desmarcado)";
                NavegadorChkCampo.AutoSize = true;
                NavegadorChkCampo.Location = new Point(190, PosicionY + 3);
                NavegadorChkCampo.Checked = NavegadorFuncObtenerBooleanoInicial(Fila, Col.Nombre, GridControl);
                NavegadorChkCampo.Enabled = !(Col.EsPK && Modificar);
                return NavegadorChkCampo;
            }

            TextBox NavegadorTxtCampo = new TextBox();
            NavegadorTxtCampo.Location = new Point(190, PosicionY);
            NavegadorTxtCampo.Width = 250;
            NavegadorTxtCampo.Text = Fila != null ? GridControl.NavegadorFuncObtenerValor(Fila, Col.Nombre) : "";

            // Autogeneracion de la llave primaria: MAX + 1, para no depender del motor de BD
            if (!Modificar && Col.EsAutoincremento)
            {
                NavegadorTxtCampo.Text = "(automático)";
                NavegadorTxtCampo.ReadOnly = true;
                NavegadorTxtCampo.BackColor = Color.LightGray;
            }
            else if (!Modificar && Col.EsPK && ClsTipoColumna.NavegadorFuncEsNumerico(Col))
            {
                object Siguiente = null;

                try { Siguiente = _CtrlEsquema.NavegadorFuncObtenerSiguienteValorLlave(_Tabla, Col.Nombre); }
                catch { }

                NavegadorTxtCampo.Text = Siguiente != null ? Convert.ToString(Siguiente) : "";

                if (Siguiente != null)
                {
                    NavegadorTxtCampo.ReadOnly = true;
                    NavegadorTxtCampo.BackColor = Color.LightGray;
                }
            }

            if (Col.EsPK && Modificar)
            {
                NavegadorTxtCampo.ReadOnly = true;
                NavegadorTxtCampo.BackColor = Color.LightGray;
            }

            return NavegadorTxtCampo;
        }

        private ComboBox NavegadorMetCrearComboFk(ClsColumnaInfo Col, DataGridViewRow Fila, ClsCrudGrid GridControl)
        {
            ComboBox NavegadorCboCampo = new ComboBox();
            NavegadorCboCampo.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                DataTable Opciones = _CtrlTabla.NavegadorMetLlenarDgv(Col.TablaFK);
                List<ClsColumnaInfo> EsquemaFk = _CtrlEsquema.NavegadorFuncObtenerEsquemaTabla(Col.TablaFK);

                string ColumnaMostrar = Col.ColumnaFK;

                foreach (ClsColumnaInfo ControlActual in EsquemaFk)
                {
                    if (string.Equals(ControlActual.Nombre, Col.ColumnaFK, StringComparison.OrdinalIgnoreCase))
                        continue;

                    string Tipo = (ControlActual.TipoDato ?? "").ToLowerInvariant();

                    if (Tipo.Contains("char") || Tipo.Contains("text"))
                    {
                        ColumnaMostrar = ControlActual.Nombre;
                        break;
                    }
                }

                if (!Opciones.Columns.Contains(Col.ColumnaFK))
                    return NavegadorCboCampo;

                if (!Opciones.Columns.Contains(ColumnaMostrar))
                    ColumnaMostrar = Col.ColumnaFK;

                NavegadorCboCampo.DataSource = Opciones;
                NavegadorCboCampo.ValueMember = Col.ColumnaFK;
                NavegadorCboCampo.DisplayMember = ColumnaMostrar;
                NavegadorCboCampo.SelectedIndex = -1;

                if (Fila != null)
                {
                    string Valor = GridControl.NavegadorFuncObtenerValor(Fila, Col.Nombre);

                    for (int Indice = 0; Indice < NavegadorCboCampo.Items.Count; Indice++)
                    {
                        DataRowView Item = NavegadorCboCampo.Items[Indice] as DataRowView;
                        if (Item == null) continue;

                        if (string.Equals(Convert.ToString(Item.Row[Col.ColumnaFK]), Valor, StringComparison.OrdinalIgnoreCase))
                        {
                            NavegadorCboCampo.SelectedIndex = Indice;
                            break;
                        }
                    }
                }
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    "No se pudieron cargar las opciones de '" + Col.Nombre + "'.\n\n" + Excepcion.Message,
                    "Error al cargar opciones",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            return NavegadorCboCampo;
        }

        private DateTime NavegadorFuncObtenerFechaInicial(DataGridViewRow Fila, string Campo, ClsCrudGrid GridControl)
        {
            if (Fila == null) return DateTime.Today;

            DateTime NavegadorDtpFecha;
            return DateTime.TryParse(GridControl.NavegadorFuncObtenerValor(Fila, Campo), out NavegadorDtpFecha) ? NavegadorDtpFecha : DateTime.Today;
        }

        private bool NavegadorFuncObtenerBooleanoInicial(DataGridViewRow Fila, string Campo, ClsCrudGrid GridControl)
        {
            if (Fila == null) return false;

            string Valor = GridControl.NavegadorFuncObtenerValor(Fila, Campo).ToLowerInvariant();
            return Valor == "1" || Valor == "true" || Valor == "yes" || Valor == "si";
        }

        public Dictionary<string, string> NavegadorFuncObtenerDatos()
        {
            Dictionary<string, string> Datos = new Dictionary<string, string>();

            if (_Controles == null)
                return Datos;

            foreach (KeyValuePair<string, Control> Par in _Controles)
                Datos[Par.Key] = NavegadorFuncObtenerValorControl(Par.Value);

            return Datos;
        }

        private string NavegadorFuncObtenerValorControl(Control ControlCampo)
        {
            DateTimePicker NavegadorDtpFecha = ControlCampo as DateTimePicker;
            if (NavegadorDtpFecha != null) return NavegadorDtpFecha.Value.ToString("yyyy-MM-dd");

            ComboBox NavegadorCboCampo = ControlCampo as ComboBox;
            if (NavegadorCboCampo != null) return NavegadorCboCampo.SelectedValue == null ? "" : Convert.ToString(NavegadorCboCampo.SelectedValue);

            CheckBox NavegadorChkCampo = ControlCampo as CheckBox;
            if (NavegadorChkCampo != null) return NavegadorChkCampo.Checked ? "1" : "0";

            return ControlCampo.Text.Trim();
        }

        public void NavegadorMetCerrar()
        {
            if (NavegadorPnlRegistro != null)
            {
                _Formulario.Controls.Remove(NavegadorPnlRegistro);
                NavegadorPnlRegistro.Dispose();
                NavegadorPnlRegistro = null;
            }

            _Controles = null;
        }
    }
}