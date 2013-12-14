namespace frmPrincipal
{
    partial class frm_MantenimientoVacaciones
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
            this.dtg_Vacaciones = new System.Windows.Forms.DataGridView();
            this.idSolicitudVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasSolicitados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAprobacionVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_fechaFinal = new System.Windows.Forms.TextBox();
            this.txt_fechaInicio = new System.Windows.Forms.TextBox();
            this.txt_aprobacion_vacaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dias_solicitados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vacaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Vacaciones
            // 
            this.dtg_Vacaciones.AllowUserToAddRows = false;
            this.dtg_Vacaciones.AllowUserToDeleteRows = false;
            this.dtg_Vacaciones.AllowUserToOrderColumns = true;
            this.dtg_Vacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Vacaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSolicitudVacacion,
            this.idEmpleado,
            this.fechaInicio,
            this.fechaFin,
            this.diasSolicitados,
            this.idAprobacionVacacion,
            this.Editar,
            this.Eliminar});
            this.dtg_Vacaciones.Location = new System.Drawing.Point(6, 20);
            this.dtg_Vacaciones.Name = "dtg_Vacaciones";
            this.dtg_Vacaciones.ReadOnly = true;
            this.dtg_Vacaciones.Size = new System.Drawing.Size(654, 494);
            this.dtg_Vacaciones.TabIndex = 0;
            this.dtg_Vacaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Vacaciones_CellContentClick);
            // 
            // idSolicitudVacacion
            // 
            this.idSolicitudVacacion.DataPropertyName = "idSolicitudVacacion";
            this.idSolicitudVacacion.HeaderText = "ID Solicitud Vacacion";
            this.idSolicitudVacacion.Name = "idSolicitudVacacion";
            this.idSolicitudVacacion.ReadOnly = true;
            this.idSolicitudVacacion.Width = 85;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Width = 85;
            // 
            // fechaInicio
            // 
            this.fechaInicio.DataPropertyName = "fechaInicio";
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Width = 65;
            // 
            // fechaFin
            // 
            this.fechaFin.DataPropertyName = "fechaFin";
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            this.fechaFin.Width = 55;
            // 
            // diasSolicitados
            // 
            this.diasSolicitados.DataPropertyName = "diasSolicitados";
            this.diasSolicitados.HeaderText = "Dias Solicitados";
            this.diasSolicitados.Name = "diasSolicitados";
            this.diasSolicitados.ReadOnly = true;
            this.diasSolicitados.Width = 90;
            // 
            // idAprobacionVacacion
            // 
            this.idAprobacionVacacion.DataPropertyName = "idAprobacionVacacion";
            this.idAprobacionVacacion.HeaderText = "Aprobacion Vacacion";
            this.idAprobacionVacacion.Name = "idAprobacionVacacion";
            this.idAprobacionVacacion.ReadOnly = true;
            this.idAprobacionVacacion.Width = 90;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 65;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 73;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtg_Vacaciones);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 514);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Vacasiones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_fechaFinal);
            this.groupBox3.Controls.Add(this.txt_fechaInicio);
            this.groupBox3.Controls.Add(this.txt_aprobacion_vacaciones);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_empleado);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_dias_solicitados);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(666, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 490);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Vacaciones ";
            // 
            // txt_fechaFinal
            // 
            this.txt_fechaFinal.Location = new System.Drawing.Point(19, 231);
            this.txt_fechaFinal.Name = "txt_fechaFinal";
            this.txt_fechaFinal.Size = new System.Drawing.Size(276, 22);
            this.txt_fechaFinal.TabIndex = 17;
            this.txt_fechaFinal.Text = "mm/dd/yyyy";
            // 
            // txt_fechaInicio
            // 
            this.txt_fechaInicio.Location = new System.Drawing.Point(19, 143);
            this.txt_fechaInicio.Name = "txt_fechaInicio";
            this.txt_fechaInicio.Size = new System.Drawing.Size(276, 22);
            this.txt_fechaInicio.TabIndex = 16;
            this.txt_fechaInicio.Text = "mm/dd/yyyy";
            // 
            // txt_aprobacion_vacaciones
            // 
            this.txt_aprobacion_vacaciones.Location = new System.Drawing.Point(19, 388);
            this.txt_aprobacion_vacaciones.Name = "txt_aprobacion_vacaciones";
            this.txt_aprobacion_vacaciones.Size = new System.Drawing.Size(277, 22);
            this.txt_aprobacion_vacaciones.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Aprobacion Vacasiones";
            // 
            // txt_empleado
            // 
            this.txt_empleado.Location = new System.Drawing.Point(19, 62);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(277, 22);
            this.txt_empleado.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dias Solicitados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Inicio";
            // 
            // txt_dias_solicitados
            // 
            this.txt_dias_solicitados.Location = new System.Drawing.Point(19, 316);
            this.txt_dias_solicitados.Name = "txt_dias_solicitados";
            this.txt_dias_solicitados.Size = new System.Drawing.Size(277, 22);
            this.txt_dias_solicitados.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empleado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1008, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 318);
            this.groupBox2.TabIndex = 8;
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
            // frm_MantenimientoVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_MantenimientoVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Vacaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MantenimientoVacaciones_FormClosing);
            this.Load += new System.EventHandler(this.frm_MantenimientoVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vacaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Vacaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_dias_solicitados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSolicitudVacacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasSolicitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAprobacionVacacion;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TextBox txt_aprobacion_vacaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fechaFinal;
        private System.Windows.Forms.TextBox txt_fechaInicio;
    }
}