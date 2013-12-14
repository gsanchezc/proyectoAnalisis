namespace frmPrincipal
{
    partial class frm_MantenimientoTickets
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
            this.dtg_Ticket = new System.Windows.Forms.DataGridView();
            this.idTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteUsuarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArchivoAdjunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstatusTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_fecha_ingreso = new System.Windows.Forms.TextBox();
            this.cmb_factura = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cmb_estatus_tickets = new System.Windows.Forms.ComboBox();
            this.cmb_tipo_serv = new System.Windows.Forms.ComboBox();
            this.cmb_nombre_usuario = new System.Windows.Forms.ComboBox();
            this.cmb_depart = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_prioridad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fecha_registro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ticket)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1063, 20);
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
            this.groupBox1.Controls.Add(this.dtg_Ticket);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 321);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Tickets";
            // 
            // dtg_Ticket
            // 
            this.dtg_Ticket.AllowUserToAddRows = false;
            this.dtg_Ticket.AllowUserToDeleteRows = false;
            this.dtg_Ticket.AllowUserToOrderColumns = true;
            this.dtg_Ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Ticket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTicket,
            this.idClienteUsuarioFinal,
            this.idDepartamento,
            this.titulo,
            this.idTipoServicio,
            this.descripcion,
            this.idArchivoAdjunto,
            this.fechaRegistro,
            this.idEstatusTickets,
            this.idPrioridad,
            this.idEmpleado,
            this.fechaAsignacion,
            this.fechaInicio,
            this.fechaEntrega,
            this.idFactura,
            this.Editar,
            this.Eliminar});
            this.dtg_Ticket.Location = new System.Drawing.Point(6, 20);
            this.dtg_Ticket.Name = "dtg_Ticket";
            this.dtg_Ticket.ReadOnly = true;
            this.dtg_Ticket.Size = new System.Drawing.Size(1040, 301);
            this.dtg_Ticket.TabIndex = 0;
            this.dtg_Ticket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Ticket_CellContentClick);
            // 
            // idTicket
            // 
            this.idTicket.HeaderText = "ID Ticket";
            this.idTicket.Name = "idTicket";
            this.idTicket.ReadOnly = true;
            this.idTicket.Width = 90;
            // 
            // idClienteUsuarioFinal
            // 
            this.idClienteUsuarioFinal.HeaderText = "Nombre Usuario Final";
            this.idClienteUsuarioFinal.Name = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.ReadOnly = true;
            this.idClienteUsuarioFinal.Width = 80;
            // 
            // idDepartamento
            // 
            this.idDepartamento.HeaderText = "Departamento";
            this.idDepartamento.Name = "idDepartamento";
            this.idDepartamento.ReadOnly = true;
            this.idDepartamento.Width = 120;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 80;
            // 
            // idTipoServicio
            // 
            this.idTipoServicio.HeaderText = "Tipo Servicio";
            this.idTipoServicio.Name = "idTipoServicio";
            this.idTipoServicio.ReadOnly = true;
            this.idTipoServicio.Width = 80;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // idArchivoAdjunto
            // 
            this.idArchivoAdjunto.HeaderText = "Archivo Adjunto";
            this.idArchivoAdjunto.Name = "idArchivoAdjunto";
            this.idArchivoAdjunto.ReadOnly = true;
            this.idArchivoAdjunto.Width = 80;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            this.fechaRegistro.Width = 80;
            // 
            // idEstatusTickets
            // 
            this.idEstatusTickets.HeaderText = "Estatus Tickets";
            this.idEstatusTickets.Name = "idEstatusTickets";
            this.idEstatusTickets.ReadOnly = true;
            this.idEstatusTickets.Width = 80;
            // 
            // idPrioridad
            // 
            this.idPrioridad.HeaderText = "Prioridad";
            this.idPrioridad.Name = "idPrioridad";
            this.idPrioridad.ReadOnly = true;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // fechaAsignacion
            // 
            this.fechaAsignacion.HeaderText = "Fecha Asignacion";
            this.fechaAsignacion.Name = "fechaAsignacion";
            this.fechaAsignacion.ReadOnly = true;
            this.fechaAsignacion.Width = 90;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Width = 75;
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.HeaderText = "Fecha Entrega";
            this.fechaEntrega.Name = "fechaEntrega";
            this.fechaEntrega.ReadOnly = true;
            this.fechaEntrega.Width = 75;
            // 
            // idFactura
            // 
            this.idFactura.HeaderText = "Factura";
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            this.idFactura.Width = 80;
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
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.txt_fecha_ingreso);
            this.groupBox3.Controls.Add(this.cmb_factura);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_descripcion);
            this.groupBox3.Controls.Add(this.cmb_estatus_tickets);
            this.groupBox3.Controls.Add(this.cmb_tipo_serv);
            this.groupBox3.Controls.Add(this.cmb_nombre_usuario);
            this.groupBox3.Controls.Add(this.cmb_depart);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmb_empleado);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_prioridad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_fecha_registro);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_titulo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(5, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1260, 192);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Tickets";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1047, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "mm/dd/yyyy";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1047, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "mm/dd/yyyy";
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(1047, 52);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(200, 22);
            this.txt_fecha_ingreso.TabIndex = 37;
            this.txt_fecha_ingreso.Text = "mm/dd/yyyy";
            // 
            // cmb_factura
            // 
            this.cmb_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factura.FormattingEnabled = true;
            this.cmb_factura.Location = new System.Drawing.Point(1045, 124);
            this.cmb_factura.Name = "cmb_factura";
            this.cmb_factura.Size = new System.Drawing.Size(200, 24);
            this.cmb_factura.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(979, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Factura";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(151, 158);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(1096, 22);
            this.txt_descripcion.TabIndex = 34;
            // 
            // cmb_estatus_tickets
            // 
            this.cmb_estatus_tickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estatus_tickets.FormattingEnabled = true;
            this.cmb_estatus_tickets.Location = new System.Drawing.Point(637, 52);
            this.cmb_estatus_tickets.Name = "cmb_estatus_tickets";
            this.cmb_estatus_tickets.Size = new System.Drawing.Size(253, 24);
            this.cmb_estatus_tickets.TabIndex = 33;
            // 
            // cmb_tipo_serv
            // 
            this.cmb_tipo_serv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_serv.FormattingEnabled = true;
            this.cmb_tipo_serv.Location = new System.Drawing.Point(151, 90);
            this.cmb_tipo_serv.Name = "cmb_tipo_serv";
            this.cmb_tipo_serv.Size = new System.Drawing.Size(345, 24);
            this.cmb_tipo_serv.TabIndex = 32;
            // 
            // cmb_nombre_usuario
            // 
            this.cmb_nombre_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nombre_usuario.FormattingEnabled = true;
            this.cmb_nombre_usuario.Location = new System.Drawing.Point(151, 15);
            this.cmb_nombre_usuario.Name = "cmb_nombre_usuario";
            this.cmb_nombre_usuario.Size = new System.Drawing.Size(345, 24);
            this.cmb_nombre_usuario.TabIndex = 31;
            // 
            // cmb_depart
            // 
            this.cmb_depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_depart.FormattingEnabled = true;
            this.cmb_depart.Location = new System.Drawing.Point(151, 52);
            this.cmb_depart.Name = "cmb_depart";
            this.cmb_depart.Size = new System.Drawing.Size(345, 24);
            this.cmb_depart.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(931, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Fecha Entrega";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(636, 124);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(254, 24);
            this.cmb_empleado.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(948, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha Inicio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(904, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha Asignacion ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(552, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Empleado";
            // 
            // txt_prioridad
            // 
            this.txt_prioridad.Location = new System.Drawing.Point(638, 90);
            this.txt_prioridad.Name = "txt_prioridad";
            this.txt_prioridad.Size = new System.Drawing.Size(252, 22);
            this.txt_prioridad.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Prioridad";
            // 
            // txt_fecha_registro
            // 
            this.txt_fecha_registro.Location = new System.Drawing.Point(637, 15);
            this.txt_fecha_registro.Name = "txt_fecha_registro";
            this.txt_fecha_registro.Size = new System.Drawing.Size(253, 22);
            this.txt_fecha_registro.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estatus Tickets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Registro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Servicio";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(151, 124);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(345, 22);
            this.txt_titulo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Usuario";
            // 
            // frm_MantenimientoTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frm_MantenimientoTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Tickets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MantenimientoTickets_FormClosing);
            this.Load += new System.EventHandler(this.frm_MantenimientoTickets_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ticket)).EndInit();
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
        private System.Windows.Forms.DataGridView dtg_Ticket;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteUsuarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArchivoAdjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstatusTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_prioridad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fecha_registro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_estatus_tickets;
        private System.Windows.Forms.ComboBox cmb_tipo_serv;
        private System.Windows.Forms.ComboBox cmb_nombre_usuario;
        private System.Windows.Forms.ComboBox cmb_depart;
        private System.Windows.Forms.ComboBox cmb_factura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_fecha_ingreso;
    }
}