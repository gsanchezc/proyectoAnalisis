namespace frmPrincipal
{
    partial class frm_Ticket_Clientes
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
            this.rb_Cerrados = new System.Windows.Forms.RadioButton();
            this.rb_pendientes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_misTickets = new System.Windows.Forms.DataGridView();
            this.idTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstatusTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_regresarMenu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_misTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Cerrados);
            this.groupBox2.Controls.Add(this.rb_pendientes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtg_misTickets);
            this.groupBox2.Controls.Add(this.btn_regresarMenu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1263, 516);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mis Tickets";
            // 
            // rb_Cerrados
            // 
            this.rb_Cerrados.AutoSize = true;
            this.rb_Cerrados.Location = new System.Drawing.Point(611, 23);
            this.rb_Cerrados.Name = "rb_Cerrados";
            this.rb_Cerrados.Size = new System.Drawing.Size(201, 20);
            this.rb_Cerrados.TabIndex = 50;
            this.rb_Cerrados.TabStop = true;
            this.rb_Cerrados.Text = "Ver mis Tickets Cerrados";
            this.rb_Cerrados.UseVisualStyleBackColor = true;
            this.rb_Cerrados.CheckedChanged += new System.EventHandler(this.rb_Cerrados_CheckedChanged);
            // 
            // rb_pendientes
            // 
            this.rb_pendientes.AutoSize = true;
            this.rb_pendientes.Location = new System.Drawing.Point(336, 23);
            this.rb_pendientes.Name = "rb_pendientes";
            this.rb_pendientes.Size = new System.Drawing.Size(215, 20);
            this.rb_pendientes.TabIndex = 49;
            this.rb_pendientes.TabStop = true;
            this.rb_pendientes.Text = "Ver mis Tickets Pendientes";
            this.rb_pendientes.UseVisualStyleBackColor = true;
            this.rb_pendientes.CheckedChanged += new System.EventHandler(this.rb_pendientes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "MIS TICKETS";
            // 
            // dtg_misTickets
            // 
            this.dtg_misTickets.AllowUserToAddRows = false;
            this.dtg_misTickets.AllowUserToDeleteRows = false;
            this.dtg_misTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_misTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTicket,
            this.idDepartamento,
            this.titulo,
            this.idTipoServicio,
            this.fechaRegistro,
            this.idEstatusTickets,
            this.idPrioridad,
            this.idEmpleado,
            this.fechaAsignacion,
            this.fechaInicio,
            this.fechaEntrega});
            this.dtg_misTickets.Location = new System.Drawing.Point(5, 62);
            this.dtg_misTickets.Name = "dtg_misTickets";
            this.dtg_misTickets.Size = new System.Drawing.Size(1252, 454);
            this.dtg_misTickets.TabIndex = 2;
            // 
            // idTicket
            // 
            this.idTicket.DataPropertyName = "idTicket";
            this.idTicket.HeaderText = "Id Ticket";
            this.idTicket.Name = "idTicket";
            this.idTicket.ReadOnly = true;
            // 
            // idDepartamento
            // 
            this.idDepartamento.DataPropertyName = "idDepartamento";
            this.idDepartamento.HeaderText = "Departamento";
            this.idDepartamento.Name = "idDepartamento";
            this.idDepartamento.ReadOnly = true;
            this.idDepartamento.Width = 125;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 125;
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
            this.idEstatusTickets.Width = 125;
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
            this.idEmpleado.Width = 125;
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
            // btn_regresarMenu
            // 
            this.btn_regresarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresarMenu.Location = new System.Drawing.Point(1070, 15);
            this.btn_regresarMenu.Name = "btn_regresarMenu";
            this.btn_regresarMenu.Size = new System.Drawing.Size(187, 35);
            this.btn_regresarMenu.TabIndex = 1;
            this.btn_regresarMenu.Text = "Regresar al Menu";
            this.btn_regresarMenu.UseVisualStyleBackColor = true;
            this.btn_regresarMenu.Click += new System.EventHandler(this.btn_regresarMenu_Click);
            // 
            // frm_Ticket_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frm_Ticket_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ticket Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Ticket_Clientes_FormClosing);
            this.Load += new System.EventHandler(this.frm_Ticket_Clientes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_misTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Cerrados;
        private System.Windows.Forms.RadioButton rb_pendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_misTickets;
        private System.Windows.Forms.Button btn_regresarMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstatusTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
    }
}