namespace frmPrincipal
{
    partial class frm_CxC_CxP_ControlFacturas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_facturas = new System.Windows.Forms.DataGridView();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteUsuarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoOrdenesCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultarPagarImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_facturasCanceladas = new System.Windows.Forms.RadioButton();
            this.rb_facturasPendientes = new System.Windows.Forms.RadioButton();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_facturas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtg_facturas);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Facturas De Tickets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "CONTROL DE FACTURACION";
            // 
            // dtg_facturas
            // 
            this.dtg_facturas.AllowUserToAddRows = false;
            this.dtg_facturas.AllowUserToDeleteRows = false;
            this.dtg_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactura,
            this.idClienteUsuarioFinal,
            this.fechaFactura,
            this.fechaDesde,
            this.fechahasta,
            this.montoTickets,
            this.montoOrdenesCompra,
            this.subTotal,
            this.impuesto,
            this.total,
            this.ConsultarPagarImprimir});
            this.dtg_facturas.Location = new System.Drawing.Point(6, 45);
            this.dtg_facturas.Name = "dtg_facturas";
            this.dtg_facturas.Size = new System.Drawing.Size(1252, 410);
            this.dtg_facturas.TabIndex = 34;
            this.dtg_facturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_facturas_CellContentClick);
            // 
            // idFactura
            // 
            this.idFactura.DataPropertyName = "idFactura";
            this.idFactura.HeaderText = "# Factura";
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            // 
            // idClienteUsuarioFinal
            // 
            this.idClienteUsuarioFinal.DataPropertyName = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.HeaderText = "Cliente";
            this.idClienteUsuarioFinal.Name = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.ReadOnly = true;
            // 
            // fechaFactura
            // 
            this.fechaFactura.DataPropertyName = "fechaFactura";
            this.fechaFactura.HeaderText = "Fecha";
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.ReadOnly = true;
            // 
            // fechaDesde
            // 
            this.fechaDesde.DataPropertyName = "fechaDesde";
            this.fechaDesde.HeaderText = "Desde";
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.ReadOnly = true;
            // 
            // fechahasta
            // 
            this.fechahasta.DataPropertyName = "fechahasta";
            this.fechahasta.HeaderText = "Hasta";
            this.fechahasta.Name = "fechahasta";
            this.fechahasta.ReadOnly = true;
            // 
            // montoTickets
            // 
            this.montoTickets.DataPropertyName = "montoTickets";
            this.montoTickets.HeaderText = "Monto Tickets";
            this.montoTickets.Name = "montoTickets";
            this.montoTickets.ReadOnly = true;
            // 
            // montoOrdenesCompra
            // 
            this.montoOrdenesCompra.DataPropertyName = "montoOrdenesCompra";
            this.montoOrdenesCompra.HeaderText = "Monto Ordenes";
            this.montoOrdenesCompra.Name = "montoOrdenesCompra";
            this.montoOrdenesCompra.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "subTotal";
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // impuesto
            // 
            this.impuesto.DataPropertyName = "impuesto";
            this.impuesto.HeaderText = "Impuesto";
            this.impuesto.Name = "impuesto";
            this.impuesto.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // ConsultarPagarImprimir
            // 
            this.ConsultarPagarImprimir.HeaderText = "Consultar / Pagar / Imprimir";
            this.ConsultarPagarImprimir.Name = "ConsultarPagarImprimir";
            this.ConsultarPagarImprimir.Width = 210;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_facturasCanceladas);
            this.groupBox2.Controls.Add(this.rb_facturasPendientes);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.btn_cerrar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(6, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1252, 58);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // rb_facturasCanceladas
            // 
            this.rb_facturasCanceladas.AutoSize = true;
            this.rb_facturasCanceladas.Location = new System.Drawing.Point(17, 22);
            this.rb_facturasCanceladas.Name = "rb_facturasCanceladas";
            this.rb_facturasCanceladas.Size = new System.Drawing.Size(238, 21);
            this.rb_facturasCanceladas.TabIndex = 4;
            this.rb_facturasCanceladas.TabStop = true;
            this.rb_facturasCanceladas.Text = "Mostrar Facturas Canceladas";
            this.rb_facturasCanceladas.UseVisualStyleBackColor = true;
            this.rb_facturasCanceladas.CheckedChanged += new System.EventHandler(this.rb_facturasCanceladas_CheckedChanged);
            // 
            // rb_facturasPendientes
            // 
            this.rb_facturasPendientes.AutoSize = true;
            this.rb_facturasPendientes.Location = new System.Drawing.Point(276, 22);
            this.rb_facturasPendientes.Name = "rb_facturasPendientes";
            this.rb_facturasPendientes.Size = new System.Drawing.Size(300, 21);
            this.rb_facturasPendientes.TabIndex = 3;
            this.rb_facturasPendientes.TabStop = true;
            this.rb_facturasPendientes.Text = "Mostrar Facturas Pendientes de Pago";
            this.rb_facturasPendientes.UseVisualStyleBackColor = true;
            this.rb_facturasPendientes.CheckedChanged += new System.EventHandler(this.rb_facturasPendientes_CheckedChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_agregar.Location = new System.Drawing.Point(810, 16);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(215, 27);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Generar Factura Nueva";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cerrar.Location = new System.Drawing.Point(1031, 16);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(215, 27);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "Volver al Menu Principal";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // frm_CxC_CxP_ControlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_CxC_CxP_ControlFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control Facturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_CxC_CxP_ControlFacturas_FormClosing);
            this.Load += new System.EventHandler(this.frm_CxC_CxP_ControlFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_facturas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_facturas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_facturasCanceladas;
        private System.Windows.Forms.RadioButton rb_facturasPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteUsuarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoOrdenesCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn ConsultarPagarImprimir;
    }
}