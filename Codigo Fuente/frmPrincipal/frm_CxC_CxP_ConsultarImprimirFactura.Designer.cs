namespace frmPrincipal
{
    partial class frm_CxC_CxP_ConsultarImprimirFactura
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
            this.gb_info_basica = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtg_facturas = new System.Windows.Forms.DataGridView();
            this.idTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstatusTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtg_OrdenesDeCompra = new System.Windows.Forms.DataGridView();
            this.idOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_imprimirFactura = new System.Windows.Forms.Button();
            this.txt_hastaFecha = new System.Windows.Forms.TextBox();
            this.btn_pagoFactura = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalOrdenCompra = new System.Windows.Forms.TextBox();
            this.txt_validarPrioridad = new System.Windows.Forms.TextBox();
            this.txt_totalTickets = new System.Windows.Forms.TextBox();
            this.txt_valorPuntualidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_impuestos = new System.Windows.Forms.TextBox();
            this.txt_valorTipoServicio = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_fechaDesde = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cantidadOrdenes = new System.Windows.Forms.TextBox();
            this.txt_cantidadTickets = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_idFactura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_fechaFactura = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Empresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_info_basica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_facturas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OrdenesDeCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_info_basica
            // 
            this.gb_info_basica.Controls.Add(this.btn_Salir);
            this.gb_info_basica.Controls.Add(this.pictureBox1);
            this.gb_info_basica.Controls.Add(this.tabControl1);
            this.gb_info_basica.Controls.Add(this.label9);
            this.gb_info_basica.Controls.Add(this.btn_imprimirFactura);
            this.gb_info_basica.Controls.Add(this.txt_hastaFecha);
            this.gb_info_basica.Controls.Add(this.btn_pagoFactura);
            this.gb_info_basica.Controls.Add(this.label15);
            this.gb_info_basica.Controls.Add(this.label1);
            this.gb_info_basica.Controls.Add(this.label4);
            this.gb_info_basica.Controls.Add(this.txt_totalOrdenCompra);
            this.gb_info_basica.Controls.Add(this.txt_validarPrioridad);
            this.gb_info_basica.Controls.Add(this.txt_totalTickets);
            this.gb_info_basica.Controls.Add(this.txt_valorPuntualidad);
            this.gb_info_basica.Controls.Add(this.label10);
            this.gb_info_basica.Controls.Add(this.label17);
            this.gb_info_basica.Controls.Add(this.txt_SubTotal);
            this.gb_info_basica.Controls.Add(this.label3);
            this.gb_info_basica.Controls.Add(this.txt_impuestos);
            this.gb_info_basica.Controls.Add(this.txt_valorTipoServicio);
            this.gb_info_basica.Controls.Add(this.txt_total);
            this.gb_info_basica.Controls.Add(this.label2);
            this.gb_info_basica.Controls.Add(this.label11);
            this.gb_info_basica.Controls.Add(this.label19);
            this.gb_info_basica.Controls.Add(this.label12);
            this.gb_info_basica.Controls.Add(this.txt_fechaDesde);
            this.gb_info_basica.Controls.Add(this.label14);
            this.gb_info_basica.Controls.Add(this.txt_cantidadOrdenes);
            this.gb_info_basica.Controls.Add(this.txt_cantidadTickets);
            this.gb_info_basica.Controls.Add(this.label21);
            this.gb_info_basica.Controls.Add(this.label20);
            this.gb_info_basica.Controls.Add(this.txt_idFactura);
            this.gb_info_basica.Controls.Add(this.label13);
            this.gb_info_basica.Controls.Add(this.txt_Direccion);
            this.gb_info_basica.Controls.Add(this.txt_fechaFactura);
            this.gb_info_basica.Controls.Add(this.label16);
            this.gb_info_basica.Controls.Add(this.txt_Empresa);
            this.gb_info_basica.Controls.Add(this.label7);
            this.gb_info_basica.Controls.Add(this.label6);
            this.gb_info_basica.Controls.Add(this.txt_telefono);
            this.gb_info_basica.Controls.Add(this.label5);
            this.gb_info_basica.Controls.Add(this.txt_nombreCliente);
            this.gb_info_basica.Controls.Add(this.label8);
            this.gb_info_basica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_info_basica.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_info_basica.Location = new System.Drawing.Point(0, 0);
            this.gb_info_basica.Name = "gb_info_basica";
            this.gb_info_basica.Size = new System.Drawing.Size(1265, 518);
            this.gb_info_basica.TabIndex = 21;
            this.gb_info_basica.TabStop = false;
            this.gb_info_basica.Text = "Informacion Basica";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(1047, 473);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(129, 33);
            this.btn_Salir.TabIndex = 46;
            this.btn_Salir.Text = "&Regresar a Menu";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmPrincipal.Properties.Resources.support2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 198);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 320);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dtg_facturas);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ticket a Facturar";
            // 
            // dtg_facturas
            // 
            this.dtg_facturas.AllowUserToAddRows = false;
            this.dtg_facturas.AllowUserToDeleteRows = false;
            this.dtg_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTicket,
            this.titulo,
            this.idTipoServicio,
            this.fechaRegistro,
            this.idEstatusTickets,
            this.idPrioridad,
            this.fechaEntrega});
            this.dtg_facturas.Location = new System.Drawing.Point(0, 0);
            this.dtg_facturas.Name = "dtg_facturas";
            this.dtg_facturas.Size = new System.Drawing.Size(943, 292);
            this.dtg_facturas.TabIndex = 0;
            // 
            // idTicket
            // 
            this.idTicket.DataPropertyName = "idTicket";
            this.idTicket.HeaderText = "# Ticket";
            this.idTicket.Name = "idTicket";
            this.idTicket.ReadOnly = true;
            this.idTicket.Width = 120;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 150;
            // 
            // idTipoServicio
            // 
            this.idTipoServicio.DataPropertyName = "idTipoServicio";
            this.idTipoServicio.HeaderText = "Tipo Servicio";
            this.idTipoServicio.Name = "idTipoServicio";
            this.idTipoServicio.ReadOnly = true;
            this.idTipoServicio.Width = 125;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.DataPropertyName = "fechaRegistro";
            this.fechaRegistro.HeaderText = "Fecha Ticket";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            this.fechaRegistro.Width = 125;
            // 
            // idEstatusTickets
            // 
            this.idEstatusTickets.DataPropertyName = "idEstatusTickets";
            this.idEstatusTickets.HeaderText = "Estatus Ticket";
            this.idEstatusTickets.Name = "idEstatusTickets";
            this.idEstatusTickets.ReadOnly = true;
            this.idEstatusTickets.Width = 125;
            // 
            // idPrioridad
            // 
            this.idPrioridad.DataPropertyName = "idPrioridad";
            this.idPrioridad.HeaderText = "Prioridad";
            this.idPrioridad.Name = "idPrioridad";
            this.idPrioridad.ReadOnly = true;
            this.idPrioridad.Width = 125;
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.DataPropertyName = "fechaEntrega";
            this.fechaEntrega.HeaderText = "Fecha Entrega";
            this.fechaEntrega.Name = "fechaEntrega";
            this.fechaEntrega.ReadOnly = true;
            this.fechaEntrega.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.dtg_OrdenesDeCompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ordenes de Compra";
            // 
            // dtg_OrdenesDeCompra
            // 
            this.dtg_OrdenesDeCompra.AllowUserToAddRows = false;
            this.dtg_OrdenesDeCompra.AllowUserToDeleteRows = false;
            this.dtg_OrdenesDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_OrdenesDeCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrdenCompra,
            this.Ticket,
            this.idProveedor,
            this.numeroCotizacion,
            this.detalle,
            this.monto,
            this.Seleccion});
            this.dtg_OrdenesDeCompra.Location = new System.Drawing.Point(0, 0);
            this.dtg_OrdenesDeCompra.Name = "dtg_OrdenesDeCompra";
            this.dtg_OrdenesDeCompra.Size = new System.Drawing.Size(986, 307);
            this.dtg_OrdenesDeCompra.TabIndex = 1;
            // 
            // idOrdenCompra
            // 
            this.idOrdenCompra.DataPropertyName = "idOrdenCompra";
            this.idOrdenCompra.HeaderText = "# Orden";
            this.idOrdenCompra.Name = "idOrdenCompra";
            this.idOrdenCompra.ReadOnly = true;
            this.idOrdenCompra.Width = 110;
            // 
            // Ticket
            // 
            this.Ticket.DataPropertyName = "idTicket";
            this.Ticket.HeaderText = "# Ticket";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            this.Ticket.Width = 110;
            // 
            // idProveedor
            // 
            this.idProveedor.DataPropertyName = "idProveedor";
            this.idProveedor.HeaderText = "Proveedor";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.Width = 150;
            // 
            // numeroCotizacion
            // 
            this.numeroCotizacion.DataPropertyName = "numeroCotizacion";
            this.numeroCotizacion.HeaderText = "# Cotizacion";
            this.numeroCotizacion.Name = "numeroCotizacion";
            this.numeroCotizacion.ReadOnly = true;
            this.numeroCotizacion.Width = 125;
            // 
            // detalle
            // 
            this.detalle.DataPropertyName = "detalle";
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 250;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1044, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Detalle de Rubros";
            // 
            // btn_imprimirFactura
            // 
            this.btn_imprimirFactura.Location = new System.Drawing.Point(1119, 422);
            this.btn_imprimirFactura.Name = "btn_imprimirFactura";
            this.btn_imprimirFactura.Size = new System.Drawing.Size(129, 33);
            this.btn_imprimirFactura.TabIndex = 41;
            this.btn_imprimirFactura.Text = "Imprimir Factura";
            this.btn_imprimirFactura.UseVisualStyleBackColor = true;
            this.btn_imprimirFactura.Click += new System.EventHandler(this.btn_imprimirFactura_Click);
            // 
            // txt_hastaFecha
            // 
            this.txt_hastaFecha.Location = new System.Drawing.Point(377, 162);
            this.txt_hastaFecha.Name = "txt_hastaFecha";
            this.txt_hastaFecha.ReadOnly = true;
            this.txt_hastaFecha.Size = new System.Drawing.Size(131, 21);
            this.txt_hastaFecha.TabIndex = 25;
            // 
            // btn_pagoFactura
            // 
            this.btn_pagoFactura.Location = new System.Drawing.Point(973, 422);
            this.btn_pagoFactura.Name = "btn_pagoFactura";
            this.btn_pagoFactura.Size = new System.Drawing.Size(129, 34);
            this.btn_pagoFactura.TabIndex = 40;
            this.btn_pagoFactura.Text = "Pago Factura";
            this.btn_pagoFactura.UseVisualStyleBackColor = true;
            this.btn_pagoFactura.Click += new System.EventHandler(this.btn_pagoFactura_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Hasta Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(989, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Orden Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1062, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Montos Totales";
            // 
            // txt_totalOrdenCompra
            // 
            this.txt_totalOrdenCompra.Location = new System.Drawing.Point(1098, 293);
            this.txt_totalOrdenCompra.Name = "txt_totalOrdenCompra";
            this.txt_totalOrdenCompra.ReadOnly = true;
            this.txt_totalOrdenCompra.Size = new System.Drawing.Size(146, 21);
            this.txt_totalOrdenCompra.TabIndex = 8;
            // 
            // txt_validarPrioridad
            // 
            this.txt_validarPrioridad.Location = new System.Drawing.Point(1097, 162);
            this.txt_validarPrioridad.Name = "txt_validarPrioridad";
            this.txt_validarPrioridad.ReadOnly = true;
            this.txt_validarPrioridad.Size = new System.Drawing.Size(146, 21);
            this.txt_validarPrioridad.TabIndex = 29;
            // 
            // txt_totalTickets
            // 
            this.txt_totalTickets.Location = new System.Drawing.Point(1098, 259);
            this.txt_totalTickets.Name = "txt_totalTickets";
            this.txt_totalTickets.ReadOnly = true;
            this.txt_totalTickets.Size = new System.Drawing.Size(146, 21);
            this.txt_totalTickets.TabIndex = 10;
            // 
            // txt_valorPuntualidad
            // 
            this.txt_valorPuntualidad.Location = new System.Drawing.Point(1098, 198);
            this.txt_valorPuntualidad.Name = "txt_valorPuntualidad";
            this.txt_valorPuntualidad.ReadOnly = true;
            this.txt_valorPuntualidad.Size = new System.Drawing.Size(146, 21);
            this.txt_valorPuntualidad.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1025, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "SubTotal";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1022, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "Prioridad";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Location = new System.Drawing.Point(1098, 327);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(146, 21);
            this.txt_SubTotal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1005, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Puntualidad";
            // 
            // txt_impuestos
            // 
            this.txt_impuestos.Location = new System.Drawing.Point(1098, 361);
            this.txt_impuestos.Name = "txt_impuestos";
            this.txt_impuestos.ReadOnly = true;
            this.txt_impuestos.Size = new System.Drawing.Size(146, 21);
            this.txt_impuestos.TabIndex = 5;
            // 
            // txt_valorTipoServicio
            // 
            this.txt_valorTipoServicio.Location = new System.Drawing.Point(1098, 123);
            this.txt_valorTipoServicio.Name = "txt_valorTipoServicio";
            this.txt_valorTipoServicio.ReadOnly = true;
            this.txt_valorTipoServicio.Size = new System.Drawing.Size(146, 21);
            this.txt_valorTipoServicio.TabIndex = 31;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(1098, 391);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(146, 21);
            this.txt_total.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(993, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Monto Tickets";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1016, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Impuestos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(999, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 15);
            this.label19.TabIndex = 30;
            this.label19.Text = "Tipo Servicio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1050, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total";
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Location = new System.Drawing.Point(136, 162);
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.ReadOnly = true;
            this.txt_fechaDesde.Size = new System.Drawing.Size(131, 21);
            this.txt_fechaDesde.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Fecha Desde";
            // 
            // txt_cantidadOrdenes
            // 
            this.txt_cantidadOrdenes.Location = new System.Drawing.Point(1097, 84);
            this.txt_cantidadOrdenes.Name = "txt_cantidadOrdenes";
            this.txt_cantidadOrdenes.ReadOnly = true;
            this.txt_cantidadOrdenes.Size = new System.Drawing.Size(150, 21);
            this.txt_cantidadOrdenes.TabIndex = 35;
            // 
            // txt_cantidadTickets
            // 
            this.txt_cantidadTickets.Location = new System.Drawing.Point(1098, 51);
            this.txt_cantidadTickets.Name = "txt_cantidadTickets";
            this.txt_cantidadTickets.ReadOnly = true;
            this.txt_cantidadTickets.Size = new System.Drawing.Size(150, 21);
            this.txt_cantidadTickets.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(967, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 15);
            this.label21.TabIndex = 34;
            this.label21.Text = "Cantidad Ordenes";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(976, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 15);
            this.label20.TabIndex = 36;
            this.label20.Text = "Cantidad Tickets";
            // 
            // txt_idFactura
            // 
            this.txt_idFactura.Location = new System.Drawing.Point(136, 126);
            this.txt_idFactura.Name = "txt_idFactura";
            this.txt_idFactura.ReadOnly = true;
            this.txt_idFactura.Size = new System.Drawing.Size(131, 21);
            this.txt_idFactura.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Id Factura";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(592, 84);
            this.txt_Direccion.Multiline = true;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.ReadOnly = true;
            this.txt_Direccion.Size = new System.Drawing.Size(359, 60);
            this.txt_Direccion.TabIndex = 19;
            // 
            // txt_fechaFactura
            // 
            this.txt_fechaFactura.Location = new System.Drawing.Point(377, 126);
            this.txt_fechaFactura.Name = "txt_fechaFactura";
            this.txt_fechaFactura.ReadOnly = true;
            this.txt_fechaFactura.Size = new System.Drawing.Size(131, 21);
            this.txt_fechaFactura.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(273, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 15);
            this.label16.TabIndex = 17;
            this.label16.Text = "Fecha Factura";
            // 
            // txt_Empresa
            // 
            this.txt_Empresa.Location = new System.Drawing.Point(592, 51);
            this.txt_Empresa.Name = "txt_Empresa";
            this.txt_Empresa.ReadOnly = true;
            this.txt_Empresa.Size = new System.Drawing.Size(359, 21);
            this.txt_Empresa.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(592, 162);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(178, 21);
            this.txt_telefono.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente:";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(592, 20);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.ReadOnly = true;
            this.txt_nombreCliente.Size = new System.Drawing.Size(359, 21);
            this.txt_nombreCliente.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Empresa:";
            // 
            // frm_CxC_CxP_ConsultarImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.gb_info_basica);
            this.MaximizeBox = false;
            this.Name = "frm_CxC_CxP_ConsultarImprimirFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_CxC_CxP_ConsultarImprimirFactura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_CxC_CxP_ConsultarImprimirFactura_FormClosing);
            this.Load += new System.EventHandler(this.frm_CxC_CxP_ConsultarImprimirFactura_Load);
            this.gb_info_basica.ResumeLayout(false);
            this.gb_info_basica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_facturas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OrdenesDeCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_info_basica;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtg_facturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstatusTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtg_OrdenesDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_imprimirFactura;
        private System.Windows.Forms.TextBox txt_hastaFecha;
        private System.Windows.Forms.Button btn_pagoFactura;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalOrdenCompra;
        private System.Windows.Forms.TextBox txt_validarPrioridad;
        private System.Windows.Forms.TextBox txt_totalTickets;
        private System.Windows.Forms.TextBox txt_valorPuntualidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_impuestos;
        private System.Windows.Forms.TextBox txt_valorTipoServicio;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_fechaDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_cantidadOrdenes;
        private System.Windows.Forms.TextBox txt_cantidadTickets;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_idFactura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_fechaFactura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Empresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Label label8;

    }
}