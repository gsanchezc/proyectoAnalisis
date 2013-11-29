namespace frmPrincipal
{
    partial class frm_Ticket_CatalogoAsignacionTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ticket_CatalogoAsignacionTicket));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_asignacionTicket = new System.Windows.Forms.DataGridView();
            this.idTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteUsuarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstatusTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atender = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_asignacionTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtg_asignacionTicket);
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1263, 517);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignacion de Ticket Pendientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "LISTADO TICKETS PARA ATENCION SUPERVISOR";
            // 
            // dtg_asignacionTicket
            // 
            this.dtg_asignacionTicket.AllowUserToAddRows = false;
            this.dtg_asignacionTicket.AllowUserToDeleteRows = false;
            this.dtg_asignacionTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_asignacionTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTicket,
            this.idClienteUsuarioFinal,
            this.idDepartamento,
            this.idTipoServicio,
            this.fechaRegistro,
            this.idEstatusTickets,
            this.idPrioridad,
            this.idEmpleado,
            this.fechaAsignacion,
            this.fechaInicio,
            this.fechaEntrega,
            this.Atender});
            this.dtg_asignacionTicket.Location = new System.Drawing.Point(5, 63);
            this.dtg_asignacionTicket.Name = "dtg_asignacionTicket";
            this.dtg_asignacionTicket.Size = new System.Drawing.Size(1252, 454);
            this.dtg_asignacionTicket.TabIndex = 3;
            this.dtg_asignacionTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_asignacionTicket_CellClick);
            // 
            // idTicket
            // 
            this.idTicket.DataPropertyName = "idTicket";
            this.idTicket.HeaderText = "Id Ticket";
            this.idTicket.Name = "idTicket";
            this.idTicket.ReadOnly = true;
            // 
            // idClienteUsuarioFinal
            // 
            this.idClienteUsuarioFinal.DataPropertyName = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.HeaderText = "Cliente";
            this.idClienteUsuarioFinal.Name = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.ReadOnly = true;
            // 
            // idDepartamento
            // 
            this.idDepartamento.DataPropertyName = "idDepartamento";
            this.idDepartamento.HeaderText = "Departamento";
            this.idDepartamento.Name = "idDepartamento";
            this.idDepartamento.ReadOnly = true;
            // 
            // idTipoServicio
            // 
            this.idTipoServicio.DataPropertyName = "idTipoServicio";
            this.idTipoServicio.HeaderText = "Tipo Servicio";
            this.idTipoServicio.Name = "idTipoServicio";
            this.idTipoServicio.ReadOnly = true;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.DataPropertyName = "fechaRegistro";
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            // 
            // idEstatusTickets
            // 
            this.idEstatusTickets.DataPropertyName = "idEstatusTickets";
            this.idEstatusTickets.HeaderText = "Estatus Ticket";
            this.idEstatusTickets.Name = "idEstatusTickets";
            this.idEstatusTickets.ReadOnly = true;
            // 
            // idPrioridad
            // 
            this.idPrioridad.DataPropertyName = "idPrioridad";
            this.idPrioridad.HeaderText = "Prioridad";
            this.idPrioridad.Name = "idPrioridad";
            this.idPrioridad.ReadOnly = true;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "Asignado a";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // fechaAsignacion
            // 
            this.fechaAsignacion.DataPropertyName = "fechaAsignacion";
            this.fechaAsignacion.HeaderText = "Fecha Asignacion";
            this.fechaAsignacion.Name = "fechaAsignacion";
            this.fechaAsignacion.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.DataPropertyName = "fechaInicio";
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.DataPropertyName = "fechaEntrega";
            this.fechaEntrega.HeaderText = "Fecha Entrega";
            this.fechaEntrega.Name = "fechaEntrega";
            this.fechaEntrega.ReadOnly = true;
            // 
            // Atender
            // 
            this.Atender.HeaderText = "Atender";
            this.Atender.Name = "Atender";
            this.Atender.Text = "Atender";
            this.Atender.Width = 110;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(1077, 16);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(180, 39);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Regresar al Menu";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_Ticket_CatalogoAsignacionTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Ticket_CatalogoAsignacionTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Asignacion_Ticket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Ticket_CatalogoAsignacionTicket_FormClosing);
            this.Load += new System.EventHandler(this.frm_Ticket_CatalogoAsignacionTicket_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_asignacionTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dtg_asignacionTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteUsuarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstatusTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
        private System.Windows.Forms.DataGridViewButtonColumn Atender;
        private System.Windows.Forms.Label label1;
    }
}