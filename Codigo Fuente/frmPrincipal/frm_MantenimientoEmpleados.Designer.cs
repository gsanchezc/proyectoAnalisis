namespace frmPrincipal
{
    partial class frm_MantenimientoEmpleados
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
            this.dtg_Empleados = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacacionesDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_vac_disp = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_salario = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cmb_depart = new System.Windows.Forms.ComboBox();
            this.cmb_tipo_id = new System.Windows.Forms.ComboBox();
            this.cmb_usuario_sist = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_fecha_ingreso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_puesto = new System.Windows.Forms.ComboBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fecha_nac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Empleados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1063, 61);
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
            this.btn_limpiar.Location = new System.Drawing.Point(24, 92);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(160, 35);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "&Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(24, 147);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(160, 35);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Guardar.Location = new System.Drawing.Point(24, 35);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(160, 35);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg_Empleados);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 344);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Empleados";
            // 
            // dtg_Empleados
            // 
            this.dtg_Empleados.AllowUserToAddRows = false;
            this.dtg_Empleados.AllowUserToDeleteRows = false;
            this.dtg_Empleados.AllowUserToOrderColumns = true;
            this.dtg_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.idUsuarioSistema,
            this.nombre,
            this.apellido,
            this.idTipoIdentificacion,
            this.identificacion,
            this.fechaNacimiento,
            this.correo,
            this.idDepartamento,
            this.idPuesto,
            this.telefono,
            this.celular,
            this.fechaIngreso,
            this.vacacionesDisponibles,
            this.idSalario,
            this.direccion,
            this.Editar,
            this.Eliminar});
            this.dtg_Empleados.Location = new System.Drawing.Point(6, 20);
            this.dtg_Empleados.Name = "dtg_Empleados";
            this.dtg_Empleados.ReadOnly = true;
            this.dtg_Empleados.Size = new System.Drawing.Size(1040, 319);
            this.dtg_Empleados.TabIndex = 0;
            this.dtg_Empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Empleados_CellContentClick);
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "ID Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // idUsuarioSistema
            // 
            this.idUsuarioSistema.DataPropertyName = "idUsuarioSistema";
            this.idUsuarioSistema.HeaderText = "Usuario Sistema";
            this.idUsuarioSistema.Name = "idUsuarioSistema";
            this.idUsuarioSistema.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // idTipoIdentificacion
            // 
            this.idTipoIdentificacion.DataPropertyName = "idTipoIdentificacion";
            this.idTipoIdentificacion.HeaderText = "Tipo Identificacion";
            this.idTipoIdentificacion.Name = "idTipoIdentificacion";
            this.idTipoIdentificacion.ReadOnly = true;
            // 
            // identificacion
            // 
            this.identificacion.DataPropertyName = "identificacion";
            this.identificacion.HeaderText = "Identificacion";
            this.identificacion.Name = "identificacion";
            this.identificacion.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // idDepartamento
            // 
            this.idDepartamento.DataPropertyName = "idDepartamento";
            this.idDepartamento.HeaderText = "Departamento";
            this.idDepartamento.Name = "idDepartamento";
            this.idDepartamento.ReadOnly = true;
            this.idDepartamento.Width = 120;
            // 
            // idPuesto
            // 
            this.idPuesto.DataPropertyName = "idPuesto";
            this.idPuesto.HeaderText = "Puesto";
            this.idPuesto.Name = "idPuesto";
            this.idPuesto.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.DataPropertyName = "fechaIngreso";
            this.fechaIngreso.HeaderText = "Fecha Ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            // 
            // vacacionesDisponibles
            // 
            this.vacacionesDisponibles.DataPropertyName = "vacacionesDisponibles";
            this.vacacionesDisponibles.HeaderText = "Vacaciones Disponibles";
            this.vacacionesDisponibles.Name = "vacacionesDisponibles";
            this.vacacionesDisponibles.ReadOnly = true;
            // 
            // idSalario
            // 
            this.idSalario.DataPropertyName = "idSalario";
            this.idSalario.HeaderText = "Salario";
            this.idSalario.Name = "idSalario";
            this.idSalario.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
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
            this.groupBox3.Controls.Add(this.txt_direccion);
            this.groupBox3.Controls.Add(this.txt_vac_disp);
            this.groupBox3.Controls.Add(this.txt_nombre);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cmb_salario);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.cmb_depart);
            this.groupBox3.Controls.Add(this.cmb_tipo_id);
            this.groupBox3.Controls.Add(this.cmb_usuario_sist);
            this.groupBox3.Controls.Add(this.txt_telefono);
            this.groupBox3.Controls.Add(this.txt_fecha_ingreso);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmb_puesto);
            this.groupBox3.Controls.Add(this.txt_celular);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_correo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_fecha_nac);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_apellido);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(5, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1260, 169);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Empleados";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(981, 43);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(266, 113);
            this.txt_direccion.TabIndex = 14;
            // 
            // txt_vac_disp
            // 
            this.txt_vac_disp.Location = new System.Drawing.Point(769, 40);
            this.txt_vac_disp.Name = "txt_vac_disp";
            this.txt_vac_disp.Size = new System.Drawing.Size(151, 22);
            this.txt_vac_disp.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(6, 84);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(151, 22);
            this.txt_nombre.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(978, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "Direccion";
            // 
            // cmb_salario
            // 
            this.cmb_salario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_salario.FormattingEnabled = true;
            this.cmb_salario.Location = new System.Drawing.Point(768, 82);
            this.cmb_salario.Name = "cmb_salario";
            this.cmb_salario.Size = new System.Drawing.Size(152, 24);
            this.cmb_salario.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(766, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Salario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(766, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Vacaciones Disponibles ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(198, 91);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(151, 22);
            this.txt_id.TabIndex = 4;
            // 
            // cmb_depart
            // 
            this.cmb_depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_depart.FormattingEnabled = true;
            this.cmb_depart.Location = new System.Drawing.Point(394, 84);
            this.cmb_depart.Name = "cmb_depart";
            this.cmb_depart.Size = new System.Drawing.Size(151, 24);
            this.cmb_depart.TabIndex = 7;
            // 
            // cmb_tipo_id
            // 
            this.cmb_tipo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_id.FormattingEnabled = true;
            this.cmb_tipo_id.Location = new System.Drawing.Point(198, 40);
            this.cmb_tipo_id.Name = "cmb_tipo_id";
            this.cmb_tipo_id.Size = new System.Drawing.Size(151, 24);
            this.cmb_tipo_id.TabIndex = 3;
            // 
            // cmb_usuario_sist
            // 
            this.cmb_usuario_sist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usuario_sist.FormattingEnabled = true;
            this.cmb_usuario_sist.Location = new System.Drawing.Point(6, 37);
            this.cmb_usuario_sist.Name = "cmb_usuario_sist";
            this.cmb_usuario_sist.Size = new System.Drawing.Size(151, 24);
            this.cmb_usuario_sist.TabIndex = 0;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(582, 37);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(151, 22);
            this.txt_telefono.TabIndex = 9;
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(582, 136);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(151, 22);
            this.txt_fecha_ingreso.TabIndex = 11;
            this.txt_fecha_ingreso.Text = "mm/dd/yyyy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(579, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Fecha Ingreso";
            // 
            // cmb_puesto
            // 
            this.cmb_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_puesto.FormattingEnabled = true;
            this.cmb_puesto.Location = new System.Drawing.Point(392, 136);
            this.cmb_puesto.Name = "cmb_puesto";
            this.cmb_puesto.Size = new System.Drawing.Size(152, 24);
            this.cmb_puesto.TabIndex = 8;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(582, 84);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(152, 22);
            this.txt_celular.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(579, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Puesto";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(394, 37);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(150, 22);
            this.txt_correo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Departamento";
            // 
            // txt_fecha_nac
            // 
            this.txt_fecha_nac.Location = new System.Drawing.Point(198, 135);
            this.txt_fecha_nac.Name = "txt_fecha_nac";
            this.txt_fecha_nac.Size = new System.Drawing.Size(151, 22);
            this.txt_fecha_nac.TabIndex = 5;
            this.txt_fecha_nac.Text = "mm/dd/yyyy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Identificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Identificacion";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(6, 123);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(151, 22);
            this.txt_apellido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario Sistema";
            // 
            // frm_MantenimientoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frm_MantenimientoEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_MantenimientoEmpleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MantenimientoEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.frm_MantenimientoEmpleados_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Empleados)).EndInit();
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
        private System.Windows.Forms.DataGridView dtg_Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacacionesDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cmb_depart;
        private System.Windows.Forms.ComboBox cmb_tipo_id;
        private System.Windows.Forms.ComboBox cmb_usuario_sist;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_fecha_ingreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_puesto;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fecha_nac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vac_disp;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_salario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_direccion;
    }
}