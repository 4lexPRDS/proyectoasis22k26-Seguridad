namespace CapaVista_AutorizacionOrdenes.Formularios
{
    partial class FrmAutorizacionOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BancosColNumeroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosColEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosColMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosColMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancosColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BancosLblMontoAsterisco = new System.Windows.Forms.Label();
            this.BancosLblBancoAsterisco = new System.Windows.Forms.Label();
            this.BancosLblTipoCambioValor = new System.Windows.Forms.Label();
            this.BancosLblMonedaValor = new System.Windows.Forms.Label();
            this.BancosLblSaldoValor = new System.Windows.Forms.Label();
            this.BancosLblBanco = new System.Windows.Forms.Label();
            this.BancosLblSaldoDisponible = new System.Windows.Forms.Label();
            this.BancosLblMoneda = new System.Windows.Forms.Label();
            this.BancosLblTipoCambio = new System.Windows.Forms.Label();
            this.BancosLblMontoAsignado = new System.Windows.Forms.Label();
            this.BancosLblResultadoFondos = new System.Windows.Forms.Label();
            this.BancosTxtMontoAsignado = new System.Windows.Forms.TextBox();
            this.BancosCboBanco = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BancosBtnSalir = new System.Windows.Forms.Button();
            this.BancosBtnRechazar = new System.Windows.Forms.Button();
            this.BancosBtnAutorizar = new System.Windows.Forms.Button();
            this.BancosLblDisponibilidadAsignacion = new System.Windows.Forms.Label();
            this.BancosLblOrdenesPendientes = new System.Windows.Forms.Label();
            this.BancosLblTitulo = new System.Windows.Forms.Label();
            this.BancosLblSubtitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BancosPbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancosPbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(49, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 392);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BancosColNumeroOrden,
            this.BancosColEmpresa,
            this.BancosColMonto,
            this.BancosColMoneda,
            this.BancosColEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.dataGridView1.Location = new System.Drawing.Point(7, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // BancosColNumeroOrden
            // 
            this.BancosColNumeroOrden.HeaderText = "N.º de orden";
            this.BancosColNumeroOrden.MinimumWidth = 6;
            this.BancosColNumeroOrden.Name = "BancosColNumeroOrden";
            // 
            // BancosColEmpresa
            // 
            this.BancosColEmpresa.HeaderText = "Empresa";
            this.BancosColEmpresa.MinimumWidth = 6;
            this.BancosColEmpresa.Name = "BancosColEmpresa";
            // 
            // BancosColMonto
            // 
            this.BancosColMonto.HeaderText = "Monto";
            this.BancosColMonto.MinimumWidth = 6;
            this.BancosColMonto.Name = "BancosColMonto";
            // 
            // BancosColMoneda
            // 
            this.BancosColMoneda.HeaderText = "Moneda";
            this.BancosColMoneda.MinimumWidth = 6;
            this.BancosColMoneda.Name = "BancosColMoneda";
            // 
            // BancosColEstado
            // 
            this.BancosColEstado.HeaderText = "Estado";
            this.BancosColEstado.MinimumWidth = 6;
            this.BancosColEstado.Name = "BancosColEstado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.BancosLblMontoAsterisco);
            this.panel2.Controls.Add(this.BancosLblBancoAsterisco);
            this.panel2.Controls.Add(this.BancosLblTipoCambioValor);
            this.panel2.Controls.Add(this.BancosLblMonedaValor);
            this.panel2.Controls.Add(this.BancosLblSaldoValor);
            this.panel2.Controls.Add(this.BancosLblBanco);
            this.panel2.Controls.Add(this.BancosLblSaldoDisponible);
            this.panel2.Controls.Add(this.BancosLblMoneda);
            this.panel2.Controls.Add(this.BancosLblTipoCambio);
            this.panel2.Controls.Add(this.BancosLblMontoAsignado);
            this.panel2.Controls.Add(this.BancosLblResultadoFondos);
            this.panel2.Controls.Add(this.BancosTxtMontoAsignado);
            this.panel2.Controls.Add(this.BancosCboBanco);
            this.panel2.Location = new System.Drawing.Point(763, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 392);
            this.panel2.TabIndex = 1;
            // 
            // BancosLblMontoAsterisco
            // 
            this.BancosLblMontoAsterisco.AutoSize = true;
            this.BancosLblMontoAsterisco.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMontoAsterisco.ForeColor = System.Drawing.Color.Red;
            this.BancosLblMontoAsterisco.Location = new System.Drawing.Point(182, 249);
            this.BancosLblMontoAsterisco.Name = "BancosLblMontoAsterisco";
            this.BancosLblMontoAsterisco.Size = new System.Drawing.Size(24, 27);
            this.BancosLblMontoAsterisco.TabIndex = 12;
            this.BancosLblMontoAsterisco.Text = "*";
            // 
            // BancosLblBancoAsterisco
            // 
            this.BancosLblBancoAsterisco.AutoSize = true;
            this.BancosLblBancoAsterisco.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblBancoAsterisco.ForeColor = System.Drawing.Color.Red;
            this.BancosLblBancoAsterisco.Location = new System.Drawing.Point(167, 27);
            this.BancosLblBancoAsterisco.Name = "BancosLblBancoAsterisco";
            this.BancosLblBancoAsterisco.Size = new System.Drawing.Size(24, 27);
            this.BancosLblBancoAsterisco.TabIndex = 11;
            this.BancosLblBancoAsterisco.Text = "*";
            // 
            // BancosLblTipoCambioValor
            // 
            this.BancosLblTipoCambioValor.AutoSize = true;
            this.BancosLblTipoCambioValor.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblTipoCambioValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.BancosLblTipoCambioValor.Location = new System.Drawing.Point(269, 200);
            this.BancosLblTipoCambioValor.Name = "BancosLblTipoCambioValor";
            this.BancosLblTipoCambioValor.Size = new System.Drawing.Size(55, 27);
            this.BancosLblTipoCambioValor.TabIndex = 10;
            this.BancosLblTipoCambioValor.Text = "1.00";
            // 
            // BancosLblMonedaValor
            // 
            this.BancosLblMonedaValor.AutoSize = true;
            this.BancosLblMonedaValor.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMonedaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.BancosLblMonedaValor.Location = new System.Drawing.Point(269, 156);
            this.BancosLblMonedaValor.Name = "BancosLblMonedaValor";
            this.BancosLblMonedaValor.Size = new System.Drawing.Size(56, 27);
            this.BancosLblMonedaValor.TabIndex = 9;
            this.BancosLblMonedaValor.Text = "GTQ";
            // 
            // BancosLblSaldoValor
            // 
            this.BancosLblSaldoValor.AutoSize = true;
            this.BancosLblSaldoValor.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblSaldoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.BancosLblSaldoValor.Location = new System.Drawing.Point(269, 110);
            this.BancosLblSaldoValor.Name = "BancosLblSaldoValor";
            this.BancosLblSaldoValor.Size = new System.Drawing.Size(78, 27);
            this.BancosLblSaldoValor.TabIndex = 8;
            this.BancosLblSaldoValor.Text = "Q 0.00";
            // 
            // BancosLblBanco
            // 
            this.BancosLblBanco.AutoSize = true;
            this.BancosLblBanco.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblBanco.Location = new System.Drawing.Point(14, 27);
            this.BancosLblBanco.Name = "BancosLblBanco";
            this.BancosLblBanco.Size = new System.Drawing.Size(157, 27);
            this.BancosLblBanco.TabIndex = 7;
            this.BancosLblBanco.Text = "Banco de pago";
            // 
            // BancosLblSaldoDisponible
            // 
            this.BancosLblSaldoDisponible.AutoSize = true;
            this.BancosLblSaldoDisponible.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblSaldoDisponible.Location = new System.Drawing.Point(14, 110);
            this.BancosLblSaldoDisponible.Name = "BancosLblSaldoDisponible";
            this.BancosLblSaldoDisponible.Size = new System.Drawing.Size(177, 27);
            this.BancosLblSaldoDisponible.TabIndex = 6;
            this.BancosLblSaldoDisponible.Text = "Saldo disponible:";
            // 
            // BancosLblMoneda
            // 
            this.BancosLblMoneda.AutoSize = true;
            this.BancosLblMoneda.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMoneda.Location = new System.Drawing.Point(16, 156);
            this.BancosLblMoneda.Name = "BancosLblMoneda";
            this.BancosLblMoneda.Size = new System.Drawing.Size(97, 27);
            this.BancosLblMoneda.TabIndex = 5;
            this.BancosLblMoneda.Text = "Moneda:";
            // 
            // BancosLblTipoCambio
            // 
            this.BancosLblTipoCambio.AutoSize = true;
            this.BancosLblTipoCambio.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblTipoCambio.Location = new System.Drawing.Point(14, 200);
            this.BancosLblTipoCambio.Name = "BancosLblTipoCambio";
            this.BancosLblTipoCambio.Size = new System.Drawing.Size(169, 27);
            this.BancosLblTipoCambio.TabIndex = 4;
            this.BancosLblTipoCambio.Text = "Tipo de cambio:";
            // 
            // BancosLblMontoAsignado
            // 
            this.BancosLblMontoAsignado.AutoSize = true;
            this.BancosLblMontoAsignado.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblMontoAsignado.Location = new System.Drawing.Point(16, 249);
            this.BancosLblMontoAsignado.Name = "BancosLblMontoAsignado";
            this.BancosLblMontoAsignado.Size = new System.Drawing.Size(173, 27);
            this.BancosLblMontoAsignado.TabIndex = 3;
            this.BancosLblMontoAsignado.Text = "\tMonto asignado ";
            // 
            // BancosLblResultadoFondos
            // 
            this.BancosLblResultadoFondos.AutoSize = true;
            this.BancosLblResultadoFondos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosLblResultadoFondos.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblResultadoFondos.Location = new System.Drawing.Point(14, 342);
            this.BancosLblResultadoFondos.Name = "BancosLblResultadoFondos";
            this.BancosLblResultadoFondos.Size = new System.Drawing.Size(301, 27);
            this.BancosLblResultadoFondos.TabIndex = 2;
            this.BancosLblResultadoFondos.Text = "Resultado: Fondos suficientes";
            // 
            // BancosTxtMontoAsignado
            // 
            this.BancosTxtMontoAsignado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BancosTxtMontoAsignado.Location = new System.Drawing.Point(17, 279);
            this.BancosTxtMontoAsignado.Name = "BancosTxtMontoAsignado";
            this.BancosTxtMontoAsignado.Size = new System.Drawing.Size(360, 39);
            this.BancosTxtMontoAsignado.TabIndex = 1;
            // 
            // BancosCboBanco
            // 
            this.BancosCboBanco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BancosCboBanco.FormattingEnabled = true;
            this.BancosCboBanco.Location = new System.Drawing.Point(17, 57);
            this.BancosCboBanco.Name = "BancosCboBanco";
            this.BancosCboBanco.Size = new System.Drawing.Size(360, 31);
            this.BancosCboBanco.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.BancosBtnSalir);
            this.panel3.Controls.Add(this.BancosBtnRechazar);
            this.panel3.Controls.Add(this.BancosBtnAutorizar);
            this.panel3.Location = new System.Drawing.Point(49, 570);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 49);
            this.panel3.TabIndex = 2;
            // 
            // BancosBtnSalir
            // 
            this.BancosBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnSalir.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnSalir.Location = new System.Drawing.Point(569, 10);
            this.BancosBtnSalir.Name = "BancosBtnSalir";
            this.BancosBtnSalir.Size = new System.Drawing.Size(149, 36);
            this.BancosBtnSalir.TabIndex = 2;
            this.BancosBtnSalir.Text = "Salir";
            this.BancosBtnSalir.UseVisualStyleBackColor = false;
            // 
            // BancosBtnRechazar
            // 
            this.BancosBtnRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnRechazar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnRechazar.Location = new System.Drawing.Point(390, 10);
            this.BancosBtnRechazar.Name = "BancosBtnRechazar";
            this.BancosBtnRechazar.Size = new System.Drawing.Size(149, 36);
            this.BancosBtnRechazar.TabIndex = 1;
            this.BancosBtnRechazar.Text = "Rechazar orden";
            this.BancosBtnRechazar.UseVisualStyleBackColor = false;
            // 
            // BancosBtnAutorizar
            // 
            this.BancosBtnAutorizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.BancosBtnAutorizar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BancosBtnAutorizar.Location = new System.Drawing.Point(206, 10);
            this.BancosBtnAutorizar.Name = "BancosBtnAutorizar";
            this.BancosBtnAutorizar.Size = new System.Drawing.Size(149, 36);
            this.BancosBtnAutorizar.TabIndex = 0;
            this.BancosBtnAutorizar.Text = "Autorizar orden";
            this.BancosBtnAutorizar.UseVisualStyleBackColor = false;
            // 
            // BancosLblDisponibilidadAsignacion
            // 
            this.BancosLblDisponibilidadAsignacion.AutoSize = true;
            this.BancosLblDisponibilidadAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
            this.BancosLblDisponibilidadAsignacion.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BancosLblDisponibilidadAsignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosLblDisponibilidadAsignacion.Location = new System.Drawing.Point(775, 134);
            this.BancosLblDisponibilidadAsignacion.Name = "BancosLblDisponibilidadAsignacion";
            this.BancosLblDisponibilidadAsignacion.Size = new System.Drawing.Size(359, 27);
            this.BancosLblDisponibilidadAsignacion.TabIndex = 8;
            this.BancosLblDisponibilidadAsignacion.Text = "Disponibilidad y asignación de pago";
            // 
            // BancosLblOrdenesPendientes
            // 
            this.BancosLblOrdenesPendientes.AutoSize = true;
            this.BancosLblOrdenesPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(169)))), ((int)(((byte)(59)))));
            this.BancosLblOrdenesPendientes.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancosLblOrdenesPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosLblOrdenesPendientes.Location = new System.Drawing.Point(67, 134);
            this.BancosLblOrdenesPendientes.Name = "BancosLblOrdenesPendientes";
            this.BancosLblOrdenesPendientes.Size = new System.Drawing.Size(207, 27);
            this.BancosLblOrdenesPendientes.TabIndex = 9;
            this.BancosLblOrdenesPendientes.Text = "Órdenes pendientes";
            // 
            // BancosLblTitulo
            // 
            this.BancosLblTitulo.AutoSize = true;
            this.BancosLblTitulo.Font = new System.Drawing.Font("Lucida Fax", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancosLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosLblTitulo.Location = new System.Drawing.Point(140, 13);
            this.BancosLblTitulo.Name = "BancosLblTitulo";
            this.BancosLblTitulo.Size = new System.Drawing.Size(657, 40);
            this.BancosLblTitulo.TabIndex = 10;
            this.BancosLblTitulo.Text = "Autorización de órdenes de compra";
            // 
            // BancosLblSubtitulo
            // 
            this.BancosLblSubtitulo.AutoSize = true;
            this.BancosLblSubtitulo.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancosLblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.BancosLblSubtitulo.Location = new System.Drawing.Point(144, 65);
            this.BancosLblSubtitulo.Name = "BancosLblSubtitulo";
            this.BancosLblSubtitulo.Size = new System.Drawing.Size(281, 27);
            this.BancosLblSubtitulo.TabIndex = 11;
            this.BancosLblSubtitulo.Text = "Área de Tesorería y Bancos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista_AutorizacionOrdenes.Properties.Resources.bancos_butti;
            this.pictureBox1.Location = new System.Drawing.Point(1049, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // BancosPbLogo
            // 
            this.BancosPbLogo.Image = global::CapaVista_AutorizacionOrdenes.Properties.Resources.bancos_logo;
            this.BancosPbLogo.Location = new System.Drawing.Point(19, 13);
            this.BancosPbLogo.Name = "BancosPbLogo";
            this.BancosPbLogo.Size = new System.Drawing.Size(90, 90);
            this.BancosPbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BancosPbLogo.TabIndex = 12;
            this.BancosPbLogo.TabStop = false;
            // 
            // FrmAutorizacionOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BancosPbLogo);
            this.Controls.Add(this.BancosLblOrdenesPendientes);
            this.Controls.Add(this.BancosLblSubtitulo);
            this.Controls.Add(this.BancosLblTitulo);
            this.Controls.Add(this.BancosLblDisponibilidadAsignacion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutorizacionOrdenes";
            this.Text = "FrmAutorizacionOrdenes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancosPbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label BancosLblMontoAsignado;
        private System.Windows.Forms.Label BancosLblResultadoFondos;
        private System.Windows.Forms.TextBox BancosTxtMontoAsignado;
        private System.Windows.Forms.ComboBox BancosCboBanco;
        private System.Windows.Forms.Label BancosLblTipoCambioValor;
        private System.Windows.Forms.Label BancosLblMonedaValor;
        private System.Windows.Forms.Label BancosLblSaldoValor;
        private System.Windows.Forms.Label BancosLblBanco;
        private System.Windows.Forms.Label BancosLblSaldoDisponible;
        private System.Windows.Forms.Label BancosLblMoneda;
        private System.Windows.Forms.Label BancosLblTipoCambio;
        private System.Windows.Forms.Button BancosBtnSalir;
        private System.Windows.Forms.Button BancosBtnRechazar;
        private System.Windows.Forms.Button BancosBtnAutorizar;
        private System.Windows.Forms.Label BancosLblDisponibilidadAsignacion;
        private System.Windows.Forms.Label BancosLblOrdenesPendientes;
        private System.Windows.Forms.Label BancosLblTitulo;
        private System.Windows.Forms.Label BancosLblSubtitulo;
        private System.Windows.Forms.PictureBox BancosPbLogo;
        private System.Windows.Forms.Label BancosLblMontoAsterisco;
        private System.Windows.Forms.Label BancosLblBancoAsterisco;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColNumeroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancosColEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}