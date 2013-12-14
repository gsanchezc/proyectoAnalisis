namespace frmPrincipal
{
    partial class frm_MantenimientoFactura
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_Facturas = new System.Windows.Forms.DataGridView();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteUsuarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadOrdenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoPorTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoPorPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoPorPuntualidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoOrdenesCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_fechaHasta = new System.Windows.Forms.TextBox();
            this.txt_fechaDesde = new System.Windows.Forms.TextBox();
            this.txt_fechaFactura = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_impuesto = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_monto_oc = new System.Windows.Forms.TextBox();
            this.txt_carg_tipo_serv = new System.Windows.Forms.TextBox();
            this.cmb_cant_ordenes = new System.Windows.Forms.ComboBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_cant_tickets = new System.Windows.Forms.ComboBox();
            this.cmb_usuario_sist = new System.Windows.Forms.ComboBox();
            this.txt_cargo_prioridad = new System.Windows.Forms.TextBox();
            this.txt_monto_tickets = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cargo_punt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Facturas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1063, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 221);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_limpiar.Location = new System.Drawing.Point(22, 113);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(160, 35);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "&Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(22, 168);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(160, 35);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Guardar.Location = new System.Drawing.Point(22, 56);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(160, 35);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg_Facturas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 313);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Facturas";
            // 
            // dtg_Facturas
            // 
            this.dtg_Facturas.AllowUserToAddRows = false;
            this.dtg_Facturas.AllowUserToDeleteRows = false;
            this.dtg_Facturas.AllowUserToOrderColumns = true;
            this.dtg_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactura,
            this.idClienteUsuarioFinal,
            this.telefono,
            this.direccion,
            this.fechaFactura,
            this.fechaDesde,
            this.fechahasta,
            this.cantidadTickets,
            this.cantidadOrdenes,
            this.cargoPorTipoServicio,
            this.cargoPorPrioridad,
            this.cargoPorPuntualidad,
            this.montoTickets,
            this.montoOrdenesCompra,
            this.subTotal,
            this.impuesto,
            this.total,
            this.Editar,
            this.Eliminar});
            this.dtg_Facturas.Location = new System.Drawing.Point(6, 20);
            this.dtg_Facturas.Name = "dtg_Facturas";
            this.dtg_Facturas.ReadOnly = true;
            this.dtg_Facturas.Size = new System.Drawing.Size(1040, 290);
            this.dtg_Facturas.TabIndex = 0;
            this.dtg_Facturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Facturas_CellContentClick);
            // 
            // idFactura
            // 
            this.idFactura.HeaderText = "ID Factura";
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            this.idFactura.Width = 75;
            // 
            // idClienteUsuarioFinal
            // 
            this.idClienteUsuarioFinal.HeaderText = "Usuario Final";
            this.idClienteUsuarioFinal.Name = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.ReadOnly = true;
            this.idClienteUsuarioFinal.Width = 75;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 80;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 80;
            // 
            // fechaFactura
            // 
            this.fechaFactura.HeaderText = "Fecha Factura";
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.ReadOnly = true;
            this.fechaFactura.Width = 70;
            // 
            // fechaDesde
            // 
            this.fechaDesde.HeaderText = "Fecha Desde";
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.ReadOnly = true;
            this.fechaDesde.Width = 70;
            // 
            // fechahasta
            // 
            this.fechahasta.HeaderText = "Fecha Hasta";
            this.fechahasta.Name = "fechahasta";
            this.fechahasta.ReadOnly = true;
            this.fechahasta.Width = 70;
            // 
            // cantidadTickets
            // 
            this.cantidadTickets.HeaderText = "Cantidad Tickets";
            this.cantidadTickets.Name = "cantidadTickets";
            this.cantidadTickets.ReadOnly = true;
            this.cantidadTickets.Width = 80;
            // 
            // cantidadOrdenes
            // 
            this.cantidadOrdenes.HeaderText = "Cantidad Ordenes";
            this.cantidadOrdenes.Name = "cantidadOrdenes";
            this.cantidadOrdenes.ReadOnly = true;
            this.cantidadOrdenes.Width = 85;
            // 
            // cargoPorTipoServicio
            // 
            this.cargoPorTipoServicio.HeaderText = "Cargo Tipo Servicio";
            this.cargoPorTipoServicio.Name = "cargoPorTipoServicio";
            this.cargoPorTipoServicio.ReadOnly = true;
            this.cargoPorTipoServicio.Width = 80;
            // 
            // cargoPorPrioridad
            // 
            this.cargoPorPrioridad.HeaderText = "Cargo Prioridad";
            this.cargoPorPrioridad.Name = "cargoPorPrioridad";
            this.cargoPorPrioridad.ReadOnly = true;
            this.cargoPorPrioridad.Width = 80;
            // 
            // cargoPorPuntualidad
            // 
            this.cargoPorPuntualidad.HeaderText = "Cargo Puntualidad";
            this.cargoPorPuntualidad.Name = "cargoPorPuntualidad";
            this.cargoPorPuntualidad.ReadOnly = true;
            this.cargoPorPuntualidad.Width = 90;
            // 
            // montoTickets
            // 
            this.montoTickets.HeaderText = "Monto Tickets";
            this.montoTickets.Name = "montoTickets";
            this.montoTickets.ReadOnly = true;
            this.montoTickets.Width = 70;
            // 
            // montoOrdenesCompra
            // 
            this.montoOrdenesCompra.HeaderText = "Monto OC";
            this.montoOrdenesCompra.Name = "montoOrdenesCompra";
            this.montoOrdenesCompra.ReadOnly = true;
            this.montoOrdenesCompra.Width = 70;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 80;
            // 
            // impuesto
            // 
            this.impuesto.HeaderText = "Impuesto";
            this.impuesto.Name = "impuesto";
            this.impuesto.ReadOnly = true;
            this.impuesto.Width = 82;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 60;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 70;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 75;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_fechaHasta);
            this.groupBox3.Controls.Add(this.txt_fechaDesde);
            this.groupBox3.Controls.Add(this.txt_fechaFactura);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.txt_impuesto);
            this.groupBox3.Controls.Add(this.txt_subtotal);
            this.groupBox3.Controls.Add(this.txt_monto_oc);
            this.groupBox3.Controls.Add(this.txt_carg_tipo_serv);
            this.groupBox3.Controls.Add(this.cmb_cant_ordenes);
            this.groupBox3.Controls.Add(this.txt_direccion);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmb_cant_tickets);
            this.groupBox3.Controls.Add(this.cmb_usuario_sist);
            this.groupBox3.Controls.Add(this.txt_cargo_prioridad);
            this.groupBox3.Controls.Add(this.txt_monto_tickets);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_cargo_punt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_telefono);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(5, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1260, 200);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Factura";
            // 
            // txt_fechaHasta
            // 
            this.txt_fechaHasta.Location = new System.Drawing.Point(209, 158);
            this.txt_fechaHasta.Name = "txt_fechaHasta";
            this.txt_fechaHasta.Size = new System.Drawing.Size(151, 22);
            this.txt_fechaHasta.TabIndex = 53;
            this.txt_fechaHasta.Text = "mm/dd/yyyy";
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Location = new System.Drawing.Point(209, 96);
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.Size = new System.Drawing.Size(151, 22);
            this.txt_fechaDesde.TabIndex = 52;
            this.txt_fechaDesde.Text = "mm/dd/yyyy";
            // 
            // txt_fechaFactura
            // 
            this.txt_fechaFactura.Location = new System.Drawing.Point(209, 45);
            this.txt_fechaFactura.Name = "txt_fechaFactura";
            this.txt_fechaFactura.Size = new System.Drawing.Size(151, 22);
            this.txt_fechaFactura.TabIndex = 51;
            this.txt_fechaFactura.Text = "mm/dd/yyyy";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(1079, 45);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(151, 22);
            this.txt_total.TabIndex = 50;
            // 
            // txt_impuesto
            // 
            this.txt_impuesto.Location = new System.Drawing.Point(868, 158);
            this.txt_impuesto.Name = "txt_impuesto";
            this.txt_impuesto.Size = new System.Drawing.Size(151, 22);
            this.txt_impuesto.TabIndex = 49;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(868, 100);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(151, 22);
            this.txt_subtotal.TabIndex = 48;
            // 
            // txt_monto_oc
            // 
            this.txt_monto_oc.Location = new System.Drawing.Point(868, 45);
            this.txt_monto_oc.Name = "txt_monto_oc";
            this.txt_monto_oc.Size = new System.Drawing.Size(151, 22);
            this.txt_monto_oc.TabIndex = 47;
            // 
            // txt_carg_tipo_serv
            // 
            this.txt_carg_tipo_serv.Location = new System.Drawing.Point(423, 158);
            this.txt_carg_tipo_serv.Name = "txt_carg_tipo_serv";
            this.txt_carg_tipo_serv.Size = new System.Drawing.Size(151, 22);
            this.txt_carg_tipo_serv.TabIndex = 46;
            // 
            // cmb_cant_ordenes
            // 
            this.cmb_cant_ordenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cant_ordenes.FormattingEnabled = true;
            this.cmb_cant_ordenes.Location = new System.Drawing.Point(423, 98);
            this.cmb_cant_ordenes.Name = "cmb_cant_ordenes";
            this.cmb_cant_ordenes.Size = new System.Drawing.Size(151, 24);
            this.cmb_cant_ordenes.TabIndex = 45;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(6, 158);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(151, 22);
            this.txt_direccion.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1076, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(865, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "Impuesto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(865, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "SubTotal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(865, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Monto OC";
            // 
            // cmb_cant_tickets
            // 
            this.cmb_cant_tickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cant_tickets.FormattingEnabled = true;
            this.cmb_cant_tickets.Location = new System.Drawing.Point(422, 43);
            this.cmb_cant_tickets.Name = "cmb_cant_tickets";
            this.cmb_cant_tickets.Size = new System.Drawing.Size(151, 24);
            this.cmb_cant_tickets.TabIndex = 33;
            // 
            // cmb_usuario_sist
            // 
            this.cmb_usuario_sist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usuario_sist.FormattingEnabled = true;
            this.cmb_usuario_sist.Location = new System.Drawing.Point(6, 43);
            this.cmb_usuario_sist.Name = "cmb_usuario_sist";
            this.cmb_usuario_sist.Size = new System.Drawing.Size(151, 24);
            this.cmb_usuario_sist.TabIndex = 31;
            // 
            // txt_cargo_prioridad
            // 
            this.txt_cargo_prioridad.Location = new System.Drawing.Point(647, 43);
            this.txt_cargo_prioridad.Name = "txt_cargo_prioridad";
            this.txt_cargo_prioridad.Size = new System.Drawing.Size(151, 22);
            this.txt_cargo_prioridad.TabIndex = 29;
            // 
            // txt_monto_tickets
            // 
            this.txt_monto_tickets.Location = new System.Drawing.Point(647, 156);
            this.txt_monto_tickets.Name = "txt_monto_tickets";
            this.txt_monto_tickets.Size = new System.Drawing.Size(151, 22);
            this.txt_monto_tickets.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(644, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Monto Tickets";
            // 
            // txt_cargo_punt
            // 
            this.txt_cargo_punt.Location = new System.Drawing.Point(647, 98);
            this.txt_cargo_punt.Name = "txt_cargo_punt";
            this.txt_cargo_punt.Size = new System.Drawing.Size(152, 22);
            this.txt_cargo_punt.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cargo Puntualidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(644, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Cargo Prioridad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(420, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Carg Tipo Serv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cantidad Ordenes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad Tickets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Hasta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha Desde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha Factura";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(6, 98);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(151, 22);
            this.txt_telefono.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario Final";
            // 
            // frm_MantenimientoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frm_MantenimientoFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Factura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MantenimientoFactura_FormClosing);
            this.Load += new System.EventHandler(this.frm_MantenimientoFactura_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Facturas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_Facturas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_cant_tickets;
        private System.Windows.Forms.ComboBox cmb_usuario_sist;
        private System.Windows.Forms.TextBox txt_cargo_prioridad;
        private System.Windows.Forms.TextBox txt_monto_tickets;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cargo_punt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteUsuarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoPorTipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoPorPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoPorPuntualidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoOrdenesCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_impuesto;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_monto_oc;
        private System.Windows.Forms.TextBox txt_carg_tipo_serv;
        private System.Windows.Forms.ComboBox cmb_cant_ordenes;
        private System.Windows.Forms.TextBox txt_fechaHasta;
        private System.Windows.Forms.TextBox txt_fechaDesde;
        private System.Windows.Forms.TextBox txt_fechaFactura;
    }
}