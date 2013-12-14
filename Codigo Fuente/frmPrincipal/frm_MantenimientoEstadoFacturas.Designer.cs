namespace frmPrincipal
{
    partial class frm_Mantenimiento_estatusFacturas
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
            this.dtg_ClienteProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClienteProveedor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg_ClienteProveedor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 494);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Estatus de Factura";
            // 
            // dtg_ClienteProveedor
            // 
            this.dtg_ClienteProveedor.AllowUserToAddRows = false;
            this.dtg_ClienteProveedor.AllowUserToDeleteRows = false;
            this.dtg_ClienteProveedor.AllowUserToOrderColumns = true;
            this.dtg_ClienteProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ClienteProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.total});
            this.dtg_ClienteProveedor.Location = new System.Drawing.Point(0, 21);
            this.dtg_ClienteProveedor.Name = "dtg_ClienteProveedor";
            this.dtg_ClienteProveedor.ReadOnly = true;
            this.dtg_ClienteProveedor.Size = new System.Drawing.Size(1260, 349);
            this.dtg_ClienteProveedor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(0, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 112);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(175, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_limpiar.Location = new System.Drawing.Point(523, 52);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(134, 35);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "&Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_eliminar.Location = new System.Drawing.Point(347, 52);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(144, 35);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Cancelar.Location = new System.Drawing.Point(686, 52);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 35);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Guardar.Location = new System.Drawing.Point(6, 52);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(136, 35);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // idFactura
            // 
            this.idFactura.HeaderText = "Id Factura";
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            this.idFactura.Width = 75;
            // 
            // idClienteUsuarioFinal
            // 
            this.idClienteUsuarioFinal.HeaderText = "Nombre Cliente";
            this.idClienteUsuarioFinal.Name = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.ReadOnly = true;
            this.idClienteUsuarioFinal.Width = 80;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 75;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 90;
            // 
            // fechaFactura
            // 
            this.fechaFactura.HeaderText = "Fecha Factura";
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.ReadOnly = true;
            this.fechaFactura.Width = 75;
            // 
            // fechaDesde
            // 
            this.fechaDesde.HeaderText = "Fecha Desde";
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.ReadOnly = true;
            this.fechaDesde.Width = 75;
            // 
            // fechahasta
            // 
            this.fechahasta.HeaderText = "Fecha Hasta";
            this.fechahasta.Name = "fechahasta";
            this.fechahasta.ReadOnly = true;
            this.fechahasta.Width = 75;
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
            this.cantidadOrdenes.Width = 80;
            // 
            // cargoPorTipoServicio
            // 
            this.cargoPorTipoServicio.HeaderText = "C.Tip Serv";
            this.cargoPorTipoServicio.Name = "cargoPorTipoServicio";
            this.cargoPorTipoServicio.ReadOnly = true;
            this.cargoPorTipoServicio.Width = 75;
            // 
            // cargoPorPrioridad
            // 
            this.cargoPorPrioridad.HeaderText = "Carg. Priori";
            this.cargoPorPrioridad.Name = "cargoPorPrioridad";
            this.cargoPorPrioridad.ReadOnly = true;
            this.cargoPorPrioridad.Width = 75;
            // 
            // cargoPorPuntualidad
            // 
            this.cargoPorPuntualidad.HeaderText = "Carg. Puntualidad";
            this.cargoPorPuntualidad.Name = "cargoPorPuntualidad";
            this.cargoPorPuntualidad.ReadOnly = true;
            this.cargoPorPuntualidad.Width = 80;
            // 
            // montoTickets
            // 
            this.montoTickets.HeaderText = "MonT. Tickets";
            this.montoTickets.Name = "montoTickets";
            this.montoTickets.ReadOnly = true;
            this.montoTickets.Width = 75;
            // 
            // montoOrdenesCompra
            // 
            this.montoOrdenesCompra.HeaderText = "Monto OC";
            this.montoOrdenesCompra.Name = "montoOrdenesCompra";
            this.montoOrdenesCompra.ReadOnly = true;
            this.montoOrdenesCompra.Width = 75;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 75;
            // 
            // impuesto
            // 
            this.impuesto.HeaderText = "IVA";
            this.impuesto.Name = "impuesto";
            this.impuesto.ReadOnly = true;
            this.impuesto.Width = 50;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 50;
            // 
            // frm_Mantenimiento_estatusFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Mantenimiento_estatusFacturas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Estatus Facturas";
            this.Load += new System.EventHandler(this.frm_Mantenimiento_estatusFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClienteProveedor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_ClienteProveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
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


    }
}