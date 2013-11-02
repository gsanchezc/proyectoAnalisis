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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_actualizarRoles = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_usuarioFinal = new System.Windows.Forms.CheckBox();
            this.chk_contabilidad = new System.Windows.Forms.CheckBox();
            this.chk_recursosHumanos = new System.Windows.Forms.CheckBox();
            this.chk_tecnico = new System.Windows.Forms.CheckBox();
            this.chk_supervisor = new System.Windows.Forms.CheckBox();
            this.chk_administrador = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_ListaUsuario = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion de Roles";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_actualizarRoles);
            this.groupBox4.Controls.Add(this.btn_cerrar);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(713, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 224);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones";
            // 
            // btn_actualizarRoles
            // 
            this.btn_actualizarRoles.Location = new System.Drawing.Point(30, 50);
            this.btn_actualizarRoles.Name = "btn_actualizarRoles";
            this.btn_actualizarRoles.Size = new System.Drawing.Size(188, 38);
            this.btn_actualizarRoles.TabIndex = 4;
            this.btn_actualizarRoles.Text = "Actualizar Roles";
            this.btn_actualizarRoles.UseVisualStyleBackColor = true;
            this.btn_actualizarRoles.Click += new System.EventHandler(this.btn_actualizarRoles_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(30, 149);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(188, 36);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_usuarioFinal);
            this.groupBox3.Controls.Add(this.chk_contabilidad);
            this.groupBox3.Controls.Add(this.chk_recursosHumanos);
            this.groupBox3.Controls.Add(this.chk_tecnico);
            this.groupBox3.Controls.Add(this.chk_supervisor);
            this.groupBox3.Controls.Add(this.chk_administrador);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(416, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 423);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Roles";
            // 
            // chk_usuarioFinal
            // 
            this.chk_usuarioFinal.AutoSize = true;
            this.chk_usuarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_usuarioFinal.Location = new System.Drawing.Point(43, 357);
            this.chk_usuarioFinal.Name = "chk_usuarioFinal";
            this.chk_usuarioFinal.Size = new System.Drawing.Size(152, 28);
            this.chk_usuarioFinal.TabIndex = 5;
            this.chk_usuarioFinal.Text = "Usuario Final";
            this.chk_usuarioFinal.UseVisualStyleBackColor = true;
            // 
            // chk_contabilidad
            // 
            this.chk_contabilidad.AutoSize = true;
            this.chk_contabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_contabilidad.Location = new System.Drawing.Point(43, 293);
            this.chk_contabilidad.Name = "chk_contabilidad";
            this.chk_contabilidad.Size = new System.Drawing.Size(145, 28);
            this.chk_contabilidad.TabIndex = 4;
            this.chk_contabilidad.Text = "Contabilidad";
            this.chk_contabilidad.UseVisualStyleBackColor = true;
            // 
            // chk_recursosHumanos
            // 
            this.chk_recursosHumanos.AutoSize = true;
            this.chk_recursosHumanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_recursosHumanos.Location = new System.Drawing.Point(43, 235);
            this.chk_recursosHumanos.Name = "chk_recursosHumanos";
            this.chk_recursosHumanos.Size = new System.Drawing.Size(212, 28);
            this.chk_recursosHumanos.TabIndex = 3;
            this.chk_recursosHumanos.Text = "Recursos Humanos";
            this.chk_recursosHumanos.UseVisualStyleBackColor = true;
            // 
            // chk_tecnico
            // 
            this.chk_tecnico.AutoSize = true;
            this.chk_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_tecnico.Location = new System.Drawing.Point(43, 174);
            this.chk_tecnico.Name = "chk_tecnico";
            this.chk_tecnico.Size = new System.Drawing.Size(105, 28);
            this.chk_tecnico.TabIndex = 2;
            this.chk_tecnico.Text = "Tecnico";
            this.chk_tecnico.UseVisualStyleBackColor = true;
            // 
            // chk_supervisor
            // 
            this.chk_supervisor.AutoSize = true;
            this.chk_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_supervisor.Location = new System.Drawing.Point(43, 115);
            this.chk_supervisor.Name = "chk_supervisor";
            this.chk_supervisor.Size = new System.Drawing.Size(129, 28);
            this.chk_supervisor.TabIndex = 1;
            this.chk_supervisor.Text = "Supervisor";
            this.chk_supervisor.UseVisualStyleBackColor = true;
            // 
            // chk_administrador
            // 
            this.chk_administrador.AutoSize = true;
            this.chk_administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_administrador.Location = new System.Drawing.Point(43, 55);
            this.chk_administrador.Name = "chk_administrador";
            this.chk_administrador.Size = new System.Drawing.Size(158, 28);
            this.chk_administrador.TabIndex = 0;
            this.chk_administrador.Text = "Administrador";
            this.chk_administrador.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_ListaUsuario);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(19, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 423);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Usuarios";
            // 
            // lst_ListaUsuario
            // 
            this.lst_ListaUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lst_ListaUsuario.FormattingEnabled = true;
            this.lst_ListaUsuario.ItemHeight = 20;
            this.lst_ListaUsuario.Location = new System.Drawing.Point(20, 25);
            this.lst_ListaUsuario.Name = "lst_ListaUsuario";
            this.lst_ListaUsuario.Size = new System.Drawing.Size(341, 384);
            this.lst_ListaUsuario.TabIndex = 0;
            // 
            // frm_Seguridad_AdministracionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Seguridad_AdministracionPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administracion Perfiles";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chk_usuarioFinal;
        private System.Windows.Forms.CheckBox chk_contabilidad;
        private System.Windows.Forms.CheckBox chk_recursosHumanos;
        private System.Windows.Forms.CheckBox chk_tecnico;
        private System.Windows.Forms.CheckBox chk_supervisor;
        private System.Windows.Forms.CheckBox chk_administrador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_ListaUsuario;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}