﻿namespace frmPrincipal
{
    partial class frm_ReportesAlertas_MantenimientoAlertasNotificaciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportesAlertas_MantenimientoAlertasNotificaciones));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_AlertasEmpleados = new System.Windows.Forms.DataGridView();
            this.idAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoAlerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSuceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lb_MinutosTranscurridos = new System.Windows.Forms.Label();
            this.lb_Numero = new System.Windows.Forms.Label();
            this.lb_numeroEmpleado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_AlertasTicket = new System.Windows.Forms.GroupBox();
            this.lb_CantidadAlertas = new System.Windows.Forms.Label();
            this.lb_AlertasActivas = new System.Windows.Forms.Label();
            this.lb_TicketVencidos = new System.Windows.Forms.Label();
            this.lb_TicketPendientes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_SalirSistema = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlertasEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.gb_AlertasTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_AlertasEmpleados);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.gb_AlertasTicket);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(-3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1267, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel de Alertas";
            // 
            // dgv_AlertasEmpleados
            // 
            this.dgv_AlertasEmpleados.AllowUserToAddRows = false;
            this.dgv_AlertasEmpleados.AllowUserToDeleteRows = false;
            this.dgv_AlertasEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_AlertasEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AlertasEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlerta,
            this.idTipoAlerta,
            this.detalle,
            this.fechaSuceso,
            this.idPrioridad,
            this.Referencia});
            this.dgv_AlertasEmpleados.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_AlertasEmpleados.Location = new System.Drawing.Point(633, 14);
            this.dgv_AlertasEmpleados.Name = "dgv_AlertasEmpleados";
            this.dgv_AlertasEmpleados.ReadOnly = true;
            this.dgv_AlertasEmpleados.Size = new System.Drawing.Size(628, 127);
            this.dgv_AlertasEmpleados.TabIndex = 5;
            // 
            // idAlerta
            // 
            this.idAlerta.DataPropertyName = "idAlerta";
            this.idAlerta.HeaderText = "Id Alerta";
            this.idAlerta.Name = "idAlerta";
            this.idAlerta.ReadOnly = true;
            // 
            // idTipoAlerta
            // 
            this.idTipoAlerta.DataPropertyName = "idTipoAlerta";
            this.idTipoAlerta.HeaderText = "Tipo Alerta";
            this.idTipoAlerta.Name = "idTipoAlerta";
            this.idTipoAlerta.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.DataPropertyName = "detalle";
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 185;
            // 
            // fechaSuceso
            // 
            this.fechaSuceso.DataPropertyName = "fechaSuceso";
            this.fechaSuceso.HeaderText = "Fecha Suceso";
            this.fechaSuceso.Name = "fechaSuceso";
            this.fechaSuceso.ReadOnly = true;
            // 
            // idPrioridad
            // 
            this.idPrioridad.DataPropertyName = "idPrioridad";
            this.idPrioridad.HeaderText = "Prioridad";
            this.idPrioridad.Name = "idPrioridad";
            this.idPrioridad.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmPrincipal.Properties.Resources.icono_de_alerta_roja_17_1215160546;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 117);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lb_MinutosTranscurridos);
            this.groupBox5.Controls.Add(this.lb_Numero);
            this.groupBox5.Controls.Add(this.lb_numeroEmpleado);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.labelDepartamento);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.labelUsuario);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Location = new System.Drawing.Point(126, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 133);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Usuario en Sistema";
            // 
            // lb_MinutosTranscurridos
            // 
            this.lb_MinutosTranscurridos.AutoSize = true;
            this.lb_MinutosTranscurridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MinutosTranscurridos.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_MinutosTranscurridos.Location = new System.Drawing.Point(188, 107);
            this.lb_MinutosTranscurridos.Name = "lb_MinutosTranscurridos";
            this.lb_MinutosTranscurridos.Size = new System.Drawing.Size(16, 16);
            this.lb_MinutosTranscurridos.TabIndex = 7;
            this.lb_MinutosTranscurridos.Text = "0";
            // 
            // lb_Numero
            // 
            this.lb_Numero.AutoSize = true;
            this.lb_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Numero.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_Numero.Location = new System.Drawing.Point(188, 77);
            this.lb_Numero.Name = "lb_Numero";
            this.lb_Numero.Size = new System.Drawing.Size(62, 16);
            this.lb_Numero.TabIndex = 7;
            this.lb_Numero.Text = "Numero";
            // 
            // lb_numeroEmpleado
            // 
            this.lb_numeroEmpleado.AutoSize = true;
            this.lb_numeroEmpleado.Location = new System.Drawing.Point(15, 77);
            this.lb_numeroEmpleado.Name = "lb_numeroEmpleado";
            this.lb_numeroEmpleado.Size = new System.Drawing.Size(127, 15);
            this.lb_numeroEmpleado.TabIndex = 6;
            this.lb_numeroEmpleado.Text = "Numero Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minutos Transcurridos";
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartamento.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelDepartamento.Location = new System.Drawing.Point(188, 48);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(56, 16);
            this.labelDepartamento.TabIndex = 5;
            this.labelDepartamento.Text = "Puesto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Puesto";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelUsuario.Location = new System.Drawing.Point(188, 20);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(62, 16);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario en el Sistema";
            // 
            // gb_AlertasTicket
            // 
            this.gb_AlertasTicket.Controls.Add(this.btn_SalirSistema);
            this.gb_AlertasTicket.Controls.Add(this.lb_CantidadAlertas);
            this.gb_AlertasTicket.Controls.Add(this.lb_AlertasActivas);
            this.gb_AlertasTicket.Controls.Add(this.lb_TicketVencidos);
            this.gb_AlertasTicket.Controls.Add(this.lb_TicketPendientes);
            this.gb_AlertasTicket.Controls.Add(this.label6);
            this.gb_AlertasTicket.Controls.Add(this.label5);
            this.gb_AlertasTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_AlertasTicket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_AlertasTicket.Location = new System.Drawing.Point(419, 14);
            this.gb_AlertasTicket.Name = "gb_AlertasTicket";
            this.gb_AlertasTicket.Size = new System.Drawing.Size(208, 133);
            this.gb_AlertasTicket.TabIndex = 2;
            this.gb_AlertasTicket.TabStop = false;
            this.gb_AlertasTicket.Text = "Alertas Atencion De Ticket";
            // 
            // lb_CantidadAlertas
            // 
            this.lb_CantidadAlertas.AutoSize = true;
            this.lb_CantidadAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CantidadAlertas.ForeColor = System.Drawing.Color.Red;
            this.lb_CantidadAlertas.Location = new System.Drawing.Point(133, 20);
            this.lb_CantidadAlertas.Name = "lb_CantidadAlertas";
            this.lb_CantidadAlertas.Size = new System.Drawing.Size(57, 16);
            this.lb_CantidadAlertas.TabIndex = 6;
            this.lb_CantidadAlertas.Text = "Alertas";
            // 
            // lb_AlertasActivas
            // 
            this.lb_AlertasActivas.AutoSize = true;
            this.lb_AlertasActivas.Location = new System.Drawing.Point(6, 20);
            this.lb_AlertasActivas.Name = "lb_AlertasActivas";
            this.lb_AlertasActivas.Size = new System.Drawing.Size(99, 15);
            this.lb_AlertasActivas.TabIndex = 5;
            this.lb_AlertasActivas.Text = "Alertas Activas";
            // 
            // lb_TicketVencidos
            // 
            this.lb_TicketVencidos.AutoSize = true;
            this.lb_TicketVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TicketVencidos.ForeColor = System.Drawing.Color.Red;
            this.lb_TicketVencidos.Location = new System.Drawing.Point(133, 77);
            this.lb_TicketVencidos.Name = "lb_TicketVencidos";
            this.lb_TicketVencidos.Size = new System.Drawing.Size(70, 16);
            this.lb_TicketVencidos.TabIndex = 4;
            this.lb_TicketVencidos.Text = "Cantidad";
            // 
            // lb_TicketPendientes
            // 
            this.lb_TicketPendientes.AutoSize = true;
            this.lb_TicketPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TicketPendientes.ForeColor = System.Drawing.Color.Red;
            this.lb_TicketPendientes.Location = new System.Drawing.Point(133, 48);
            this.lb_TicketPendientes.Name = "lb_TicketPendientes";
            this.lb_TicketPendientes.Size = new System.Drawing.Size(59, 16);
            this.lb_TicketPendientes.TabIndex = 3;
            this.lb_TicketPendientes.Text = "Tickets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ticket Vencidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ticket Pendientes";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_SalirSistema
            // 
            this.btn_SalirSistema.Location = new System.Drawing.Point(9, 104);
            this.btn_SalirSistema.Name = "btn_SalirSistema";
            this.btn_SalirSistema.Size = new System.Drawing.Size(183, 23);
            this.btn_SalirSistema.TabIndex = 7;
            this.btn_SalirSistema.Text = "Atajo Salir del Sistema";
            this.btn_SalirSistema.UseVisualStyleBackColor = true;
            this.btn_SalirSistema.Click += new System.EventHandler(this.btn_SalirSistema_Click);
            // 
            // frm_ReportesAlertas_MantenimientoAlertasNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 143);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 546);
            this.MaximizeBox = false;
            this.Name = "frm_ReportesAlertas_MantenimientoAlertasNotificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Alertas Notificaciones";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ReportesAlertas_MantenimientoAlertasNotificaciones_FormClosing);
            this.Load += new System.EventHandler(this.frm_ReportesAlertas_MantenimientoAlertasNotificaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlertasEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gb_AlertasTicket.ResumeLayout(false);
            this.gb_AlertasTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_AlertasTicket;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_TicketVencidos;
        private System.Windows.Forms.Label lb_TicketPendientes;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_MinutosTranscurridos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Numero;
        private System.Windows.Forms.Label lb_numeroEmpleado;
        private System.Windows.Forms.Label lb_CantidadAlertas;
        private System.Windows.Forms.Label lb_AlertasActivas;
        private System.Windows.Forms.DataGridView dgv_AlertasEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSuceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.Button btn_SalirSistema;
    }
}