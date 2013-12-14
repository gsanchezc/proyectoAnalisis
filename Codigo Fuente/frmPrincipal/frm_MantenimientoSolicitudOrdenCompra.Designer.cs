namespace frmPrincipal
{
    partial class frm_MantenimientoSolicitudOrdenCompra
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_fecha_solicitud = new System.Windows.Forms.TextBox();
            this.cmb_tickets = new System.Windows.Forms.ComboBox();
            this.txt_detalle_orden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dtg_SolicitudesOrdenCompra = new System.Windows.Forms.DataGridView();
            this.idSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SolicitudesOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg_SolicitudesOrdenCompra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 516);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Solicitudes Orden de compra";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_fecha_solicitud);
            this.groupBox3.Controls.Add(this.cmb_tickets);
            this.groupBox3.Controls.Add(this.txt_detalle_orden);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(679, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 490);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Solicitud Orden de Compra";
            // 
            // txt_fecha_solicitud
            // 
            this.txt_fecha_solicitud.Location = new System.Drawing.Point(19, 216);
            this.txt_fecha_solicitud.Name = "txt_fecha_solicitud";
            this.txt_fecha_solicitud.Size = new System.Drawing.Size(277, 22);
            this.txt_fecha_solicitud.TabIndex = 17;
            this.txt_fecha_solicitud.Text = "mm/dd/yyyy";
            // 
            // cmb_tickets
            // 
            this.cmb_tickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tickets.FormattingEnabled = true;
            this.cmb_tickets.Location = new System.Drawing.Point(19, 64);
            this.cmb_tickets.Name = "cmb_tickets";
            this.cmb_tickets.Size = new System.Drawing.Size(277, 24);
            this.cmb_tickets.TabIndex = 12;
            // 
            // txt_detalle_orden
            // 
            this.txt_detalle_orden.Location = new System.Drawing.Point(19, 132);
            this.txt_detalle_orden.Name = "txt_detalle_orden";
            this.txt_detalle_orden.Size = new System.Drawing.Size(277, 22);
            this.txt_detalle_orden.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Detalle Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Solicitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "# Tickets";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1031, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 318);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_limpiar.Location = new System.Drawing.Point(22, 152);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(180, 35);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "&Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(22, 218);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(180, 35);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Guardar.Location = new System.Drawing.Point(22, 84);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(180, 35);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dtg_SolicitudesOrdenCompra
            // 
            this.dtg_SolicitudesOrdenCompra.AllowUserToAddRows = false;
            this.dtg_SolicitudesOrdenCompra.AllowUserToDeleteRows = false;
            this.dtg_SolicitudesOrdenCompra.AllowUserToOrderColumns = true;
            this.dtg_SolicitudesOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SolicitudesOrdenCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSolicitud,
            this.idTicket,
            this.detalleOrden,
            this.fechaSolicitud,
            this.Editar,
            this.Eliminar});
            this.dtg_SolicitudesOrdenCompra.Location = new System.Drawing.Point(6, 20);
            this.dtg_SolicitudesOrdenCompra.Name = "dtg_SolicitudesOrdenCompra";
            this.dtg_SolicitudesOrdenCompra.ReadOnly = true;
            this.dtg_SolicitudesOrdenCompra.Size = new System.Drawing.Size(647, 496);
            this.dtg_SolicitudesOrdenCompra.TabIndex = 0;
            this.dtg_SolicitudesOrdenCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SolicitudesOrdenCompra_CellContentClick);
            // 
            // idSolicitud
            // 
            this.idSolicitud.HeaderText = "ID Solicitud";
            this.idSolicitud.Name = "idSolicitud";
            this.idSolicitud.ReadOnly = true;
            // 
            // idTicket
            // 
            this.idTicket.HeaderText = "# Ticket";
            this.idTicket.Name = "idTicket";
            this.idTicket.ReadOnly = true;
            // 
            // detalleOrden
            // 
            this.detalleOrden.HeaderText = "Detalle Orden";
            this.detalleOrden.Name = "detalleOrden";
            this.detalleOrden.ReadOnly = true;
            // 
            // fechaSolicitud
            // 
            this.fechaSolicitud.HeaderText = "Fecha Solicitud";
            this.fechaSolicitud.Name = "fechaSolicitud";
            this.fechaSolicitud.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frm_MantenimientoSolicitudOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_MantenimientoSolicitudOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Solicitud Orden Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MantenimientoSolicitudOrdenCompra_FormClosing);
            this.Load += new System.EventHandler(this.frm_MantenimientoSolicitudOrdenCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SolicitudesOrdenCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_SolicitudesOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolicitud;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_detalle_orden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tickets;
        private System.Windows.Forms.TextBox txt_fecha_solicitud;
    }
}