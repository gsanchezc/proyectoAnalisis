namespace frmPrincipal
{
    partial class frm_MantenimientoClienteUsuarioFinal
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_nombreEmpresa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_idUsuarioSistema = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.cmb_TipoId = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Cliente = new System.Windows.Forms.TextBox();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idEmpresaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteUsuarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_ClienteUsuarioFinal = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClienteUsuarioFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1010, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 264);
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
            this.btn_limpiar.Size = new System.Drawing.Size(193, 35);
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
            this.btn_Cancelar.Size = new System.Drawing.Size(193, 35);
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
            this.btn_Guardar.Size = new System.Drawing.Size(193, 35);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg_ClienteUsuarioFinal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 364);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes Usuario Final";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_nombreEmpresa);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmb_idUsuarioSistema);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_apellido);
            this.groupBox3.Controls.Add(this.cmb_TipoId);
            this.groupBox3.Controls.Add(this.txt_telefono);
            this.groupBox3.Controls.Add(this.txt_Nombre_Cliente);
            this.groupBox3.Controls.Add(this.txt_identificacion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(5, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1246, 149);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Cliente Usuario Final";
            // 
            // cmb_nombreEmpresa
            // 
            this.cmb_nombreEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nombreEmpresa.FormattingEnabled = true;
            this.cmb_nombreEmpresa.Location = new System.Drawing.Point(649, 79);
            this.cmb_nombreEmpresa.Name = "cmb_nombreEmpresa";
            this.cmb_nombreEmpresa.Size = new System.Drawing.Size(329, 24);
            this.cmb_nombreEmpresa.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre Empresa";
            // 
            // cmb_idUsuarioSistema
            // 
            this.cmb_idUsuarioSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idUsuarioSistema.FormattingEnabled = true;
            this.cmb_idUsuarioSistema.Location = new System.Drawing.Point(168, 111);
            this.cmb_idUsuarioSistema.Name = "cmb_idUsuarioSistema";
            this.cmb_idUsuarioSistema.Size = new System.Drawing.Size(311, 24);
            this.cmb_idUsuarioSistema.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Usuario Sistema";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(167, 49);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(312, 22);
            this.txt_apellido.TabIndex = 10;
            // 
            // cmb_TipoId
            // 
            this.cmb_TipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoId.FormattingEnabled = true;
            this.cmb_TipoId.Location = new System.Drawing.Point(649, 15);
            this.cmb_TipoId.Name = "cmb_TipoId";
            this.cmb_TipoId.Size = new System.Drawing.Size(329, 24);
            this.cmb_TipoId.TabIndex = 9;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(167, 79);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(312, 22);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_Nombre_Cliente
            // 
            this.txt_Nombre_Cliente.Location = new System.Drawing.Point(167, 15);
            this.txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            this.txt_Nombre_Cliente.Size = new System.Drawing.Size(312, 22);
            this.txt_Nombre_Cliente.TabIndex = 6;
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Location = new System.Drawing.Point(649, 49);
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(329, 22);
            this.txt_identificacion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Identificacion";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 90;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 80;
            // 
            // idEmpresaCliente
            // 
            this.idEmpresaCliente.DataPropertyName = "idEmpresaCliente";
            this.idEmpresaCliente.HeaderText = "Nombre Empresa ";
            this.idEmpresaCliente.Name = "idEmpresaCliente";
            this.idEmpresaCliente.ReadOnly = true;
            // 
            // telefonoEmpresa
            // 
            this.telefonoEmpresa.DataPropertyName = "telefonoEmpresa";
            this.telefonoEmpresa.HeaderText = "Telefono Empresa";
            this.telefonoEmpresa.Name = "telefonoEmpresa";
            this.telefonoEmpresa.ReadOnly = true;
            this.telefonoEmpresa.Width = 95;
            // 
            // identificacion
            // 
            this.identificacion.DataPropertyName = "identificacion";
            this.identificacion.HeaderText = "Identificacion";
            this.identificacion.Name = "identificacion";
            this.identificacion.ReadOnly = true;
            this.identificacion.Width = 110;
            // 
            // idTipoIdentificacion
            // 
            this.idTipoIdentificacion.DataPropertyName = "idTipoIdentificacion";
            this.idTipoIdentificacion.HeaderText = "Tipo Identificacion ";
            this.idTipoIdentificacion.Name = "idTipoIdentificacion";
            this.idTipoIdentificacion.ReadOnly = true;
            this.idTipoIdentificacion.Width = 110;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 75;
            // 
            // idUsuarioSistema
            // 
            this.idUsuarioSistema.DataPropertyName = "idUsuarioSistema";
            this.idUsuarioSistema.HeaderText = "Id Usuario Sistema";
            this.idUsuarioSistema.Name = "idUsuarioSistema";
            this.idUsuarioSistema.ReadOnly = true;
            this.idUsuarioSistema.Width = 90;
            // 
            // idClienteUsuarioFinal
            // 
            this.idClienteUsuarioFinal.DataPropertyName = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.HeaderText = "ID UsuarioFinal";
            this.idClienteUsuarioFinal.Name = "idClienteUsuarioFinal";
            this.idClienteUsuarioFinal.ReadOnly = true;
            // 
            // dtg_ClienteUsuarioFinal
            // 
            this.dtg_ClienteUsuarioFinal.AllowUserToAddRows = false;
            this.dtg_ClienteUsuarioFinal.AllowUserToDeleteRows = false;
            this.dtg_ClienteUsuarioFinal.AllowUserToOrderColumns = true;
            this.dtg_ClienteUsuarioFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ClienteUsuarioFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteUsuarioFinal,
            this.idUsuarioSistema,
            this.nombre,
            this.apellidos,
            this.idTipoIdentificacion,
            this.identificacion,
            this.telefonoEmpresa,
            this.idEmpresaCliente,
            this.Editar,
            this.Eliminar});
            this.dtg_ClienteUsuarioFinal.Location = new System.Drawing.Point(6, 20);
            this.dtg_ClienteUsuarioFinal.Name = "dtg_ClienteUsuarioFinal";
            this.dtg_ClienteUsuarioFinal.ReadOnly = true;
            this.dtg_ClienteUsuarioFinal.Size = new System.Drawing.Size(975, 338);
            this.dtg_ClienteUsuarioFinal.TabIndex = 0;
            this.dtg_ClienteUsuarioFinal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ClienteUsuarioFinal_CellContentClick);
            // 
            // frm_MantenimientoClienteUsuarioFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frm_MantenimientoClienteUsuarioFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_MantenimientoClienteUsuarioFinal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MantenimientoClienteUsuarioFinal_FormClosing);
            this.Load += new System.EventHandler(this.frm_MantenimientoClienteUsuarioFinal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClienteUsuarioFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_TipoId;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_Nombre_Cliente;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.ComboBox cmb_nombreEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_idUsuarioSistema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtg_ClienteUsuarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteUsuarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaCliente;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}