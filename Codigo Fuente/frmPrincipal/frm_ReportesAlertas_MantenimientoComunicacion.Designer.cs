namespace frmPrincipal
{
    partial class frm_ReportesAlertas_MantenimientoComunicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportesAlertas_MantenimientoComunicacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NuevaAlerta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_regresarMenu = new System.Windows.Forms.Button();
            this.dtg_Alertas = new System.Windows.Forms.DataGridView();
            this.idAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSuceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstatusAlertas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Alertas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_NuevaAlerta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_regresarMenu);
            this.groupBox1.Controls.Add(this.dtg_Alertas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1261, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de Alertas";
            // 
            // btn_NuevaAlerta
            // 
            this.btn_NuevaAlerta.Location = new System.Drawing.Point(934, 16);
            this.btn_NuevaAlerta.Name = "btn_NuevaAlerta";
            this.btn_NuevaAlerta.Size = new System.Drawing.Size(148, 31);
            this.btn_NuevaAlerta.TabIndex = 49;
            this.btn_NuevaAlerta.Text = "Nueva Alerta";
            this.btn_NuevaAlerta.UseVisualStyleBackColor = true;
            this.btn_NuevaAlerta.Click += new System.EventHandler(this.btn_NuevaAlerta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "HISTORIAL DE ALERTAS";
            // 
            // btn_regresarMenu
            // 
            this.btn_regresarMenu.Location = new System.Drawing.Point(1107, 16);
            this.btn_regresarMenu.Name = "btn_regresarMenu";
            this.btn_regresarMenu.Size = new System.Drawing.Size(148, 31);
            this.btn_regresarMenu.TabIndex = 1;
            this.btn_regresarMenu.Text = "Regresar al Menu";
            this.btn_regresarMenu.UseVisualStyleBackColor = true;
            this.btn_regresarMenu.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // dtg_Alertas
            // 
            this.dtg_Alertas.AllowUserToAddRows = false;
            this.dtg_Alertas.AllowUserToDeleteRows = false;
            this.dtg_Alertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Alertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlerta,
            this.idTipoAlerta,
            this.detalle,
            this.idEmpleado,
            this.fechaSuceso,
            this.fechaFinalizacion,
            this.idPrioridad,
            this.idEstatusAlertas});
            this.dtg_Alertas.Location = new System.Drawing.Point(6, 55);
            this.dtg_Alertas.Name = "dtg_Alertas";
            this.dtg_Alertas.Size = new System.Drawing.Size(1249, 460);
            this.dtg_Alertas.TabIndex = 0;
            // 
            // idAlerta
            // 
            this.idAlerta.DataPropertyName = "idAlerta";
            this.idAlerta.HeaderText = "Id Alerta";
            this.idAlerta.Name = "idAlerta";
            this.idAlerta.ReadOnly = true;
            this.idAlerta.Width = 150;
            // 
            // idTipoAlerta
            // 
            this.idTipoAlerta.DataPropertyName = "idTipoAlerta";
            this.idTipoAlerta.HeaderText = "Tipo Alerta";
            this.idTipoAlerta.Name = "idTipoAlerta";
            this.idTipoAlerta.ReadOnly = true;
            this.idTipoAlerta.Width = 150;
            // 
            // detalle
            // 
            this.detalle.DataPropertyName = "detalle";
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 200;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Width = 150;
            // 
            // fechaSuceso
            // 
            this.fechaSuceso.DataPropertyName = "fechaSuceso";
            this.fechaSuceso.HeaderText = "Fecha Suceso";
            this.fechaSuceso.Name = "fechaSuceso";
            this.fechaSuceso.ReadOnly = true;
            this.fechaSuceso.Width = 125;
            // 
            // fechaFinalizacion
            // 
            this.fechaFinalizacion.DataPropertyName = "fechaFinalizacion";
            this.fechaFinalizacion.HeaderText = "Fecha Finalizacion";
            this.fechaFinalizacion.Name = "fechaFinalizacion";
            this.fechaFinalizacion.ReadOnly = true;
            this.fechaFinalizacion.Width = 125;
            // 
            // idPrioridad
            // 
            this.idPrioridad.DataPropertyName = "idPrioridad";
            this.idPrioridad.HeaderText = "Prioridad";
            this.idPrioridad.Name = "idPrioridad";
            this.idPrioridad.ReadOnly = true;
            this.idPrioridad.Width = 150;
            // 
            // idEstatusAlertas
            // 
            this.idEstatusAlertas.DataPropertyName = "idEstatusAlertas";
            this.idEstatusAlertas.HeaderText = "Estatus";
            this.idEstatusAlertas.Name = "idEstatusAlertas";
            this.idEstatusAlertas.ReadOnly = true;
            this.idEstatusAlertas.Width = 150;
            // 
            // frm_ReportesAlertas_MantenimientoComunicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ReportesAlertas_MantenimientoComunicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Comunicacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ReportesAlertas_MantenimientoComunicacion_FormClosing);
            this.Load += new System.EventHandler(this.frm_ReporteAlertas_MantenimientoComunicacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Alertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_Alertas;
        private System.Windows.Forms.Button btn_regresarMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevaAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSuceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstatusAlertas;
    }
}