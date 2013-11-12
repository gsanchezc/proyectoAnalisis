namespace frmPrincipal
{
    partial class frm_Seguridad_AdministracionPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Seguridad_AdministracionPerfiles));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_empleados = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_clientes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_clientes = new System.Windows.Forms.RadioButton();
            this.rb_empleados = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_RolActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_idUsuarioSistema = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_actualizarRoles = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_UsuarioFinal = new System.Windows.Forms.RadioButton();
            this.rb_Contabilidad = new System.Windows.Forms.RadioButton();
            this.rb_RRHH = new System.Windows.Forms.RadioButton();
            this.rb_tecnico = new System.Windows.Forms.RadioButton();
            this.rb_Supervisor = new System.Windows.Forms.RadioButton();
            this.rb_Administrador = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_ListaUsuario = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion de Roles";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_empleados);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.txt_clientes);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.rb_clientes);
            this.groupBox7.Controls.Add(this.rb_empleados);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox7.Location = new System.Drawing.Point(15, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(192, 448);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Listas";
            // 
            // txt_empleados
            // 
            this.txt_empleados.Location = new System.Drawing.Point(14, 265);
            this.txt_empleados.Name = "txt_empleados";
            this.txt_empleados.ReadOnly = true;
            this.txt_empleados.Size = new System.Drawing.Size(149, 26);
            this.txt_empleados.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cantidad Empleados";
            // 
            // txt_clientes
            // 
            this.txt_clientes.Location = new System.Drawing.Point(14, 185);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.ReadOnly = true;
            this.txt_clientes.Size = new System.Drawing.Size(149, 26);
            this.txt_clientes.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad Clientes";
            // 
            // rb_clientes
            // 
            this.rb_clientes.AutoSize = true;
            this.rb_clientes.Location = new System.Drawing.Point(18, 41);
            this.rb_clientes.Name = "rb_clientes";
            this.rb_clientes.Size = new System.Drawing.Size(136, 24);
            this.rb_clientes.TabIndex = 0;
            this.rb_clientes.TabStop = true;
            this.rb_clientes.Text = "Lista Clientes";
            this.rb_clientes.UseVisualStyleBackColor = true;
            this.rb_clientes.CheckedChanged += new System.EventHandler(this.rb_clientes_CheckedChanged);
            // 
            // rb_empleados
            // 
            this.rb_empleados.AutoSize = true;
            this.rb_empleados.Location = new System.Drawing.Point(16, 95);
            this.rb_empleados.Name = "rb_empleados";
            this.rb_empleados.Size = new System.Drawing.Size(160, 24);
            this.rb_empleados.TabIndex = 1;
            this.rb_empleados.TabStop = true;
            this.rb_empleados.Text = "Lista Empleados";
            this.rb_empleados.UseVisualStyleBackColor = true;
            this.rb_empleados.CheckedChanged += new System.EventHandler(this.rb_empleados_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_RolActual);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txt_identificacion);
            this.groupBox6.Controls.Add(this.txt_apellidos);
            this.groupBox6.Controls.Add(this.txt_nombre);
            this.groupBox6.Controls.Add(this.txt_idUsuarioSistema);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox6.Location = new System.Drawing.Point(443, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(311, 448);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos Usuario";
            // 
            // txt_RolActual
            // 
            this.txt_RolActual.Location = new System.Drawing.Point(21, 313);
            this.txt_RolActual.Name = "txt_RolActual";
            this.txt_RolActual.ReadOnly = true;
            this.txt_RolActual.Size = new System.Drawing.Size(274, 26);
            this.txt_RolActual.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol Actual";
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Location = new System.Drawing.Point(21, 254);
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.ReadOnly = true;
            this.txt_identificacion.Size = new System.Drawing.Size(274, 26);
            this.txt_identificacion.TabIndex = 3;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(21, 189);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.ReadOnly = true;
            this.txt_apellidos.Size = new System.Drawing.Size(274, 26);
            this.txt_apellidos.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(21, 126);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(274, 26);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_idUsuarioSistema
            // 
            this.txt_idUsuarioSistema.Location = new System.Drawing.Point(21, 61);
            this.txt_idUsuarioSistema.Name = "txt_idUsuarioSistema";
            this.txt_idUsuarioSistema.ReadOnly = true;
            this.txt_idUsuarioSistema.Size = new System.Drawing.Size(274, 26);
            this.txt_idUsuarioSistema.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Identificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Usuario Sistema";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_actualizarRoles);
            this.groupBox4.Controls.Add(this.btn_cerrar);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(1022, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 445);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones";
            // 
            // btn_actualizarRoles
            // 
            this.btn_actualizarRoles.Location = new System.Drawing.Point(18, 50);
            this.btn_actualizarRoles.Name = "btn_actualizarRoles";
            this.btn_actualizarRoles.Size = new System.Drawing.Size(156, 38);
            this.btn_actualizarRoles.TabIndex = 4;
            this.btn_actualizarRoles.Text = "Actualizar Rol";
            this.btn_actualizarRoles.UseVisualStyleBackColor = true;
            this.btn_actualizarRoles.Click += new System.EventHandler(this.btn_actualizarRoles_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(18, 149);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(156, 36);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_UsuarioFinal);
            this.groupBox3.Controls.Add(this.rb_Contabilidad);
            this.groupBox3.Controls.Add(this.rb_RRHH);
            this.groupBox3.Controls.Add(this.rb_tecnico);
            this.groupBox3.Controls.Add(this.rb_Supervisor);
            this.groupBox3.Controls.Add(this.rb_Administrador);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(760, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 448);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Roles";
            // 
            // rb_UsuarioFinal
            // 
            this.rb_UsuarioFinal.AutoSize = true;
            this.rb_UsuarioFinal.Location = new System.Drawing.Point(23, 354);
            this.rb_UsuarioFinal.Name = "rb_UsuarioFinal";
            this.rb_UsuarioFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_UsuarioFinal.Size = new System.Drawing.Size(192, 24);
            this.rb_UsuarioFinal.TabIndex = 5;
            this.rb_UsuarioFinal.TabStop = true;
            this.rb_UsuarioFinal.Text = "(6) Rol Usuario Final";
            this.rb_UsuarioFinal.UseVisualStyleBackColor = true;
            // 
            // rb_Contabilidad
            // 
            this.rb_Contabilidad.AutoSize = true;
            this.rb_Contabilidad.Location = new System.Drawing.Point(23, 290);
            this.rb_Contabilidad.Name = "rb_Contabilidad";
            this.rb_Contabilidad.Size = new System.Drawing.Size(186, 24);
            this.rb_Contabilidad.TabIndex = 4;
            this.rb_Contabilidad.TabStop = true;
            this.rb_Contabilidad.Text = "(5) Rol Contabilidad";
            this.rb_Contabilidad.UseVisualStyleBackColor = true;
            // 
            // rb_RRHH
            // 
            this.rb_RRHH.AutoSize = true;
            this.rb_RRHH.Location = new System.Drawing.Point(23, 232);
            this.rb_RRHH.Name = "rb_RRHH";
            this.rb_RRHH.Size = new System.Drawing.Size(138, 24);
            this.rb_RRHH.TabIndex = 3;
            this.rb_RRHH.TabStop = true;
            this.rb_RRHH.Text = "(4) Rol RRHH";
            this.rb_RRHH.UseVisualStyleBackColor = true;
            // 
            // rb_tecnico
            // 
            this.rb_tecnico.AutoSize = true;
            this.rb_tecnico.Location = new System.Drawing.Point(23, 171);
            this.rb_tecnico.Name = "rb_tecnico";
            this.rb_tecnico.Size = new System.Drawing.Size(148, 24);
            this.rb_tecnico.TabIndex = 2;
            this.rb_tecnico.TabStop = true;
            this.rb_tecnico.Text = "(3) Rol Tecnico";
            this.rb_tecnico.UseVisualStyleBackColor = true;
            // 
            // rb_Supervisor
            // 
            this.rb_Supervisor.AutoSize = true;
            this.rb_Supervisor.Location = new System.Drawing.Point(23, 112);
            this.rb_Supervisor.Name = "rb_Supervisor";
            this.rb_Supervisor.Size = new System.Drawing.Size(171, 24);
            this.rb_Supervisor.TabIndex = 1;
            this.rb_Supervisor.TabStop = true;
            this.rb_Supervisor.Text = "(2) Rol Supervisor";
            this.rb_Supervisor.UseVisualStyleBackColor = true;
            // 
            // rb_Administrador
            // 
            this.rb_Administrador.AutoSize = true;
            this.rb_Administrador.Location = new System.Drawing.Point(23, 60);
            this.rb_Administrador.Name = "rb_Administrador";
            this.rb_Administrador.Size = new System.Drawing.Size(197, 24);
            this.rb_Administrador.TabIndex = 0;
            this.rb_Administrador.TabStop = true;
            this.rb_Administrador.Text = "(1) Rol Administrador";
            this.rb_Administrador.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_ListaUsuario);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(213, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 448);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Usuarios";
            // 
            // lst_ListaUsuario
            // 
            this.lst_ListaUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lst_ListaUsuario.FormattingEnabled = true;
            this.lst_ListaUsuario.ItemHeight = 20;
            this.lst_ListaUsuario.Location = new System.Drawing.Point(6, 25);
            this.lst_ListaUsuario.Name = "lst_ListaUsuario";
            this.lst_ListaUsuario.Size = new System.Drawing.Size(209, 404);
            this.lst_ListaUsuario.TabIndex = 0;
            this.lst_ListaUsuario.SelectedIndexChanged += new System.EventHandler(this.lst_ListaUsuario_SelectedIndexChanged);
            // 
            // frm_Seguridad_AdministracionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Seguridad_AdministracionPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administracion Perfiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Seguridad_AdministracionPerfiles_FormClosing);
            this.Load += new System.EventHandler(this.frm_Seguridad_AdministracionPerfiles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_actualizarRoles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_ListaUsuario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_UsuarioFinal;
        private System.Windows.Forms.RadioButton rb_Contabilidad;
        private System.Windows.Forms.RadioButton rb_RRHH;
        private System.Windows.Forms.RadioButton rb_tecnico;
        private System.Windows.Forms.RadioButton rb_Supervisor;
        private System.Windows.Forms.RadioButton rb_Administrador;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_idUsuarioSistema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txt_empleados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_clientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_clientes;
        private System.Windows.Forms.RadioButton rb_empleados;
        private System.Windows.Forms.TextBox txt_RolActual;
        private System.Windows.Forms.Label label1;
    }
}