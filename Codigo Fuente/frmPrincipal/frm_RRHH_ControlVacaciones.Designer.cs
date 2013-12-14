namespace frmPrincipal
{
    partial class frm_RRHH_ControlVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RRHH_ControlVacaciones));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dtg_Planilla = new System.Windows.Forms.DataGridView();
            this.idSolicitudVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasSolicitados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacacionesDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAprobacionVacacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Planilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.dtg_Planilla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control de Vacaciones";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(1035, 465);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(182, 23);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "&Salir";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dtg_Planilla
            // 
            this.dtg_Planilla.AllowUserToDeleteRows = false;
            this.dtg_Planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Planilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSolicitudVacacion,
            this.idEmpleado,
            this.fechaInicio,
            this.fechaFin,
            this.diasSolicitados,
            this.vacacionesDisponibles,
            this.idAprobacionVacacion});
            this.dtg_Planilla.Location = new System.Drawing.Point(15, 32);
            this.dtg_Planilla.Name = "dtg_Planilla";
            this.dtg_Planilla.Size = new System.Drawing.Size(1027, 417);
            this.dtg_Planilla.TabIndex = 1;
            // 
            // idSolicitudVacacion
            // 
            this.idSolicitudVacacion.DataPropertyName = "idSolicitudVacacion";
            this.idSolicitudVacacion.HeaderText = "Id Solicitud";
            this.idSolicitudVacacion.Name = "idSolicitudVacacion";
            this.idSolicitudVacacion.Width = 120;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.Width = 120;
            // 
            // fechaInicio
            // 
            this.fechaInicio.DataPropertyName = "fechaInicio";
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Width = 120;
            // 
            // fechaFin
            // 
            this.fechaFin.DataPropertyName = "fechaFin";
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Width = 120;
            // 
            // diasSolicitados
            // 
            this.diasSolicitados.DataPropertyName = "diasSolicitados";
            this.diasSolicitados.HeaderText = "Dias Solicitados";
            this.diasSolicitados.Name = "diasSolicitados";
            this.diasSolicitados.Width = 120;
            // 
            // vacacionesDisponibles
            // 
            this.vacacionesDisponibles.DataPropertyName = "vacacionesDisponibles";
            this.vacacionesDisponibles.HeaderText = "Vacaciones Disponibles";
            this.vacacionesDisponibles.Name = "vacacionesDisponibles";
            this.vacacionesDisponibles.Width = 120;
            // 
            // idAprobacionVacacion
            // 
            this.idAprobacionVacacion.DataPropertyName = "idAprobacionVacacion";
            this.idAprobacionVacacion.HeaderText = "Estatus Solicitud";
            this.idAprobacionVacacion.Name = "idAprobacionVacacion";
            this.idAprobacionVacacion.Width = 120;
            // 
            // frm_RRHH_ControlVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RRHH_ControlVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control Vacaciones";
            this.Load += new System.EventHandler(this.frm_RRHH_ControlVacaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Planilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_Planilla;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSolicitudVacacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasSolicitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacacionesDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAprobacionVacacion;
    }
}