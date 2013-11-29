namespace frmPrincipal
{
    partial class frm_CxC_CxP_ControlSolicitudOrdenDeCompra
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dtg_CatalogoSolicitudesCompra = new System.Windows.Forms.DataGridView();
            this.idSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atender = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CatalogoSolicitudesCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg_CatalogoSolicitudesCompra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 520);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catalogo Solicitudes de Compra";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::frmPrincipal.Properties.Resources.imagen_proveedor_255x250;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1038, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 242);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cerrar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1038, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cerrar.Location = new System.Drawing.Point(16, 33);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(187, 37);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "Regresar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dtg_CatalogoSolicitudesCompra
            // 
            this.dtg_CatalogoSolicitudesCompra.AllowUserToAddRows = false;
            this.dtg_CatalogoSolicitudesCompra.AllowUserToDeleteRows = false;
            this.dtg_CatalogoSolicitudesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CatalogoSolicitudesCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSolicitud,
            this.idTicket,
            this.detalleOrden,
            this.fechaSolicitud,
            this.isAproved,
            this.Atender});
            this.dtg_CatalogoSolicitudesCompra.Location = new System.Drawing.Point(12, 21);
            this.dtg_CatalogoSolicitudesCompra.Name = "dtg_CatalogoSolicitudesCompra";
            this.dtg_CatalogoSolicitudesCompra.Size = new System.Drawing.Size(1020, 493);
            this.dtg_CatalogoSolicitudesCompra.TabIndex = 0;
            this.dtg_CatalogoSolicitudesCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CatalogoSolicitudesCompra_CellContentClick);
            // 
            // idSolicitud
            // 
            this.idSolicitud.DataPropertyName = "idSolicitud";
            this.idSolicitud.HeaderText = "Id Solicitud";
            this.idSolicitud.Name = "idSolicitud";
            this.idSolicitud.ReadOnly = true;
            this.idSolicitud.Width = 125;
            // 
            // idTicket
            // 
            this.idTicket.DataPropertyName = "idTicket";
            this.idTicket.HeaderText = "Id Ticket";
            this.idTicket.Name = "idTicket";
            this.idTicket.ReadOnly = true;
            this.idTicket.Width = 125;
            // 
            // detalleOrden
            // 
            this.detalleOrden.DataPropertyName = "detalleOrden";
            this.detalleOrden.HeaderText = "Detalle Solicitud";
            this.detalleOrden.Name = "detalleOrden";
            this.detalleOrden.ReadOnly = true;
            this.detalleOrden.Width = 375;
            // 
            // fechaSolicitud
            // 
            this.fechaSolicitud.DataPropertyName = "fechaSolicitud";
            this.fechaSolicitud.HeaderText = "Fecha Solicitud";
            this.fechaSolicitud.Name = "fechaSolicitud";
            this.fechaSolicitud.ReadOnly = true;
            this.fechaSolicitud.Width = 125;
            // 
            // isAproved
            // 
            this.isAproved.DataPropertyName = "isAproved";
            this.isAproved.HeaderText = "Aprobado";
            this.isAproved.Name = "isAproved";
            this.isAproved.ReadOnly = true;
            this.isAproved.Width = 125;
            // 
            // Atender
            // 
            this.Atender.HeaderText = "Atender";
            this.Atender.Name = "Atender";
            // 
            // frm_CxC_CxP_ControlSolicitudOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_CxC_CxP_ControlSolicitudOrdenDeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control Solicitudes De Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_CxC_CxP_ControlSolicitudOrdenDeCompra_FormClosing);
            this.Load += new System.EventHandler(this.frm_CxC_CxP_ControlSolicitudOrdenDeCompra_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CatalogoSolicitudesCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dtg_CatalogoSolicitudesCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAproved;
        private System.Windows.Forms.DataGridViewButtonColumn Atender;
    }
}