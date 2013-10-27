namespace frmPrincipal
{
    partial class frm_Ticket_CatalogoAsignacionTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ticket_CatalogoAsignacionTicket));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtg_asignacionTicket = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Tciket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cerrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_asignacionTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Controls.Add(this.dtg_asignacionTicket);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 473);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignacion de Ticket Pendientes";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(823, 444);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(137, 23);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dtg_asignacionTicket
            // 
            this.dtg_asignacionTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_asignacionTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Id_Tciket,
            this.Nombre_Ticket,
            this.Column1,
            this.Status,
            this.Column4,
            this.Seleccionar,
            this.Cerrar});
            this.dtg_asignacionTicket.Location = new System.Drawing.Point(18, 29);
            this.dtg_asignacionTicket.Name = "dtg_asignacionTicket";
            this.dtg_asignacionTicket.Size = new System.Drawing.Size(942, 409);
            this.dtg_asignacionTicket.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente";
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
            this.Column1.HeaderText = "Tema Issue";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status del Ticket";
            this.Status.Name = "Status";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha Ingreso";
            this.Column4.Name = "Column4";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Asignar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Asignar";
            this.Seleccionar.ToolTipText = "Asignar";
            // 
            // Cerrar
            // 
            this.Cerrar.HeaderText = "Cerrar";
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.ToolTipText = "Cerrar";
            // 
            // frm_Ticket_CatalogoAsignacionTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Ticket_CatalogoAsignacionTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Asignacion_Ticket";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_asignacionTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dtg_asignacionTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tciket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Cerrar;
    }
}