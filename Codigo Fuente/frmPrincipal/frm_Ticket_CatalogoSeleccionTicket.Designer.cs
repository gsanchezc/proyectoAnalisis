﻿namespace frmPrincipal
{
    partial class frm_Ticket_CatalogoSeleccionTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ticket_CatalogoSeleccionTicket));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtg_TicketPendientes = new System.Windows.Forms.DataGridView();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Tciket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TicketPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Controls.Add(this.dtg_TicketPendientes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 473);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion de Ticket Pendientes";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(798, 444);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(160, 23);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dtg_TicketPendientes
            // 
            this.dtg_TicketPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_TicketPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prioridad,
            this.Column2,
            this.Id_Tciket,
            this.Nombre_Ticket,
            this.Column1,
            this.Column4,
            this.Column5,
            this.Seleccionar});
            this.dtg_TicketPendientes.Location = new System.Drawing.Point(16, 30);
            this.dtg_TicketPendientes.Name = "dtg_TicketPendientes";
            this.dtg_TicketPendientes.Size = new System.Drawing.Size(942, 408);
            this.dtg_TicketPendientes.TabIndex = 0;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            // 
            // Id_Tciket
            // 
            this.Id_Tciket.HeaderText = "Id Ticket";
            this.Id_Tciket.Name = "Id_Tciket";
            // 
            // Nombre_Ticket
            // 
            this.Nombre_Ticket.HeaderText = "Departamento";
            this.Nombre_Ticket.Name = "Nombre_Ticket";
            this.Nombre_Ticket.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tema Ticket";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha Ingreso";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha Asignacion";
            this.Column5.Name = "Column5";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Abrir";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Abrir";
            this.Seleccionar.ToolTipText = "Abrir";
            // 
            // frm_Ticket_CatalogoSeleccionTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Ticket_CatalogoSeleccionTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catalogo Seleccion Ticket";
            this.Load += new System.EventHandler(this.frm_Ticket_CatalogoSeleccionTicket_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TicketPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_TicketPendientes;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tciket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}