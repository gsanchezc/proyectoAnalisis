namespace frmPrincipal
{
    partial class frm_CxC_CxP_EnvioEstadosCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CxC_CxP_EnvioEstadosCuenta));
            this.dtg_EstadoCuenta = new System.Windows.Forms.DataGridView();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoOrdenesCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_mostrarPorFechas = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.gb_info_basica = new System.Windows.Forms.GroupBox();
            this.txt_montoEstadoDeCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fechaDesde = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_hastaFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_fechaEstadoCuenta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Empresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EstadoCuenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_info_basica.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_EstadoCuenta
            // 
            this.dtg_EstadoCuenta.AllowUserToAddRows = false;
            this.dtg_EstadoCuenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.dtg_EstadoCuenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_EstadoCuenta.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_EstadoCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_EstadoCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactura,
            this.fechaFactura,
            this.montoTickets,
            this.montoOrdenesCompra,
            this.subTotal,
            this.impuesto,
            this.total});
            this.dtg_EstadoCuenta.GridColor = System.Drawing.SystemColors.Window;
            this.dtg_EstadoCuenta.Location = new System.Drawing.Point(17, 270);
            this.dtg_EstadoCuenta.Name = "dtg_EstadoCuenta";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            this.dtg_EstadoCuenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_EstadoCuenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_EstadoCuenta.Size = new System.Drawing.Size(777, 421);
            this.dtg_EstadoCuenta.TabIndex = 26;
            // 
            // idFactura
            // 
            this.idFactura.DataPropertyName = "idFactura";
            this.idFactura.HeaderText = "# Factura";
            this.idFactura.Name = "idFactura";
            this.idFactura.Width = 105;
            // 
            // fechaFactura
            // 
            this.fechaFactura.DataPropertyName = "fechaFactura";
            this.fechaFactura.HeaderText = "Fecha Factura";
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Width = 105;
            // 
            // montoTickets
            // 
            this.montoTickets.DataPropertyName = "montoTickets";
            this.montoTickets.HeaderText = "Monto Ticket";
            this.montoTickets.Name = "montoTickets";
            this.montoTickets.Width = 105;
            // 
            // montoOrdenesCompra
            // 
            this.montoOrdenesCompra.DataPropertyName = "montoOrdenesCompra";
            this.montoOrdenesCompra.HeaderText = "Monto Ordenes";
            this.montoOrdenesCompra.Name = "montoOrdenesCompra";
            this.montoOrdenesCompra.Width = 105;
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "subTotal";
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.Width = 105;
            // 
            // impuesto
            // 
            this.impuesto.DataPropertyName = "impuesto";
            this.impuesto.HeaderText = "Impuesto";
            this.impuesto.Name = "impuesto";
            this.impuesto.Width = 105;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Width = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_hasta);
            this.groupBox1.Controls.Add(this.cmb_cliente);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtp_desde);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(845, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 107);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Cliente y Fecha";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(258, 63);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(116, 22);
            this.dtp_hasta.TabIndex = 3;
            this.dtp_hasta.ValueChanged += new System.EventHandler(this.dtp_hasta_ValueChanged);
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(73, 27);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(301, 23);
            this.cmb_cliente.TabIndex = 4;
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(208, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Hasta";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(73, 62);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(116, 23);
            this.dtp_desde.TabIndex = 2;
            this.dtp_desde.ValueChanged += new System.EventHandler(this.dtp_desde_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Desde";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_mostrarPorFechas);
            this.groupBox2.Controls.Add(this.btn_Salir);
            this.groupBox2.Controls.Add(this.btn_imprimir);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(845, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 182);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_mostrarPorFechas
            // 
            this.btn_mostrarPorFechas.Location = new System.Drawing.Point(18, 24);
            this.btn_mostrarPorFechas.Name = "btn_mostrarPorFechas";
            this.btn_mostrarPorFechas.Size = new System.Drawing.Size(352, 34);
            this.btn_mostrarPorFechas.TabIndex = 28;
            this.btn_mostrarPorFechas.Text = "Generar Estado De Cuenta Segun Fecha";
            this.btn_mostrarPorFechas.UseVisualStyleBackColor = true;
            this.btn_mostrarPorFechas.Click += new System.EventHandler(this.btn_mostrarPorFechas_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(102, 128);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(190, 36);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Volver al Menu Principal";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(102, 76);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(190, 35);
            this.btn_imprimir.TabIndex = 7;
            this.btn_imprimir.Text = "Imprimir Estado De Cuenta";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // gb_info_basica
            // 
            this.gb_info_basica.Controls.Add(this.txt_montoEstadoDeCuenta);
            this.gb_info_basica.Controls.Add(this.label2);
            this.gb_info_basica.Controls.Add(this.groupBox3);
            this.gb_info_basica.Controls.Add(this.dtg_EstadoCuenta);
            this.gb_info_basica.Controls.Add(this.label22);
            this.gb_info_basica.Controls.Add(this.label6);
            this.gb_info_basica.Controls.Add(this.txt_fechaDesde);
            this.gb_info_basica.Controls.Add(this.pictureBox1);
            this.gb_info_basica.Controls.Add(this.txt_hastaFecha);
            this.gb_info_basica.Controls.Add(this.label1);
            this.gb_info_basica.Controls.Add(this.txt_Direccion);
            this.gb_info_basica.Controls.Add(this.txt_fechaEstadoCuenta);
            this.gb_info_basica.Controls.Add(this.label16);
            this.gb_info_basica.Controls.Add(this.txt_Empresa);
            this.gb_info_basica.Controls.Add(this.label8);
            this.gb_info_basica.Controls.Add(this.label27);
            this.gb_info_basica.Controls.Add(this.txt_telefono);
            this.gb_info_basica.Controls.Add(this.label28);
            this.gb_info_basica.Controls.Add(this.txt_nombreCliente);
            this.gb_info_basica.Controls.Add(this.label29);
            this.gb_info_basica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_info_basica.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_info_basica.Location = new System.Drawing.Point(2, 0);
            this.gb_info_basica.Name = "gb_info_basica";
            this.gb_info_basica.Size = new System.Drawing.Size(826, 743);
            this.gb_info_basica.TabIndex = 27;
            this.gb_info_basica.TabStop = false;
            this.gb_info_basica.Text = "Informacion Basica";
            // 
            // txt_montoEstadoDeCuenta
            // 
            this.txt_montoEstadoDeCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montoEstadoDeCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_montoEstadoDeCuenta.Location = new System.Drawing.Point(605, 704);
            this.txt_montoEstadoDeCuenta.Name = "txt_montoEstadoDeCuenta";
            this.txt_montoEstadoDeCuenta.ReadOnly = true;
            this.txt_montoEstadoDeCuenta.Size = new System.Drawing.Size(189, 20);
            this.txt_montoEstadoDeCuenta.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(329, 705);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Total De Monto Por Facturas Del Periodo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(422, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 91);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Contacto";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(11, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(192, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "Correo: info@soportic.com\r\n";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label25.Location = new System.Drawing.Point(11, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(157, 16);
            this.label25.TabIndex = 1;
            this.label25.Text = "San Jose, Costa Rica";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label26.Location = new System.Drawing.Point(197, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(137, 16);
            this.label26.TabIndex = 3;
            this.label26.Text = "Telefax: 5555-5555\r\n";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(14, 252);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(244, 15);
            this.label22.TabIndex = 49;
            this.label22.Text = "Detalle De Rubros Estado De Cuenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(266, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha Desde";
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaDesde.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_fechaDesde.Location = new System.Drawing.Point(343, 219);
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.ReadOnly = true;
            this.txt_fechaDesde.Size = new System.Drawing.Size(182, 20);
            this.txt_fechaDesde.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmPrincipal.Properties.Resources.support2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txt_hastaFecha
            // 
            this.txt_hastaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hastaFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_hastaFecha.Location = new System.Drawing.Point(605, 219);
            this.txt_hastaFecha.Name = "txt_hastaFecha";
            this.txt_hastaFecha.ReadOnly = true;
            this.txt_hastaFecha.Size = new System.Drawing.Size(189, 20);
            this.txt_hastaFecha.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(531, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hasta Fecha";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Direccion.Location = new System.Drawing.Point(343, 157);
            this.txt_Direccion.Multiline = true;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.ReadOnly = true;
            this.txt_Direccion.Size = new System.Drawing.Size(451, 52);
            this.txt_Direccion.TabIndex = 19;
            // 
            // txt_fechaEstadoCuenta
            // 
            this.txt_fechaEstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaEstadoCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_fechaEstadoCuenta.Location = new System.Drawing.Point(98, 219);
            this.txt_fechaEstadoCuenta.Name = "txt_fechaEstadoCuenta";
            this.txt_fechaEstadoCuenta.ReadOnly = true;
            this.txt_fechaEstadoCuenta.Size = new System.Drawing.Size(160, 20);
            this.txt_fechaEstadoCuenta.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(16, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Fecha Estado:";
            // 
            // txt_Empresa
            // 
            this.txt_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Empresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Empresa.Location = new System.Drawing.Point(478, 121);
            this.txt_Empresa.Name = "txt_Empresa";
            this.txt_Empresa.ReadOnly = true;
            this.txt_Empresa.Size = new System.Drawing.Size(316, 20);
            this.txt_Empresa.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(40, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Telefono:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(282, 160);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Direccion:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_telefono.Location = new System.Drawing.Point(100, 157);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(158, 20);
            this.txt_telefono.TabIndex = 10;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(50, 124);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "Cliente:";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nombreCliente.Location = new System.Drawing.Point(100, 121);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.ReadOnly = true;
            this.txt_nombreCliente.Size = new System.Drawing.Size(295, 20);
            this.txt_nombreCliente.TabIndex = 8;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(419, 124);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 7;
            this.label29.Text = "Empresa:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frm_CxC_CxP_EnvioEstadosCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 742);
            this.Controls.Add(this.gb_info_basica);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_CxC_CxP_EnvioEstadosCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Envio Estados Cuenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_CxC_CxP_EnvioEstadosCuenta_FormClosing);
            this.Load += new System.EventHandler(this.frm_CxC_CxP_EnvioEstadosCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EstadoCuenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gb_info_basica.ResumeLayout(false);
            this.gb_info_basica.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtg_EstadoCuenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.GroupBox gb_info_basica;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_hastaFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fechaDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_fechaEstadoCuenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Empresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_montoEstadoDeCuenta;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_mostrarPorFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoOrdenesCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}