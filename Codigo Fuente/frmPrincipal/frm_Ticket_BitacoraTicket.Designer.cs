namespace frmPrincipal
{
    partial class frm_Ticket_BitacoraTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ticket_BitacoraTicket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dgv_Bitacora = new System.Windows.Forms.DataGridView();
            this.idBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoLaborado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArchivoAdjunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_cerrar);
            this.groupBox1.Controls.Add(this.dgv_Bitacora);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "HISTORIAL DE BITACORAS DE TICKETS";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1091, 21);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(161, 23);
            this.btn_cerrar.TabIndex = 45;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dgv_Bitacora
            // 
            this.dgv_Bitacora.AllowUserToAddRows = false;
            this.dgv_Bitacora.AllowUserToDeleteRows = false;
            this.dgv_Bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBitacora,
            this.idTicket,
            this.tiempoLaborado,
            this.descripcion,
            this.idArchivoAdjunto,
            this.fecha,
            this.idEmpleado,
            this.Consultar});
            this.dgv_Bitacora.Location = new System.Drawing.Point(6, 56);
            this.dgv_Bitacora.Name = "dgv_Bitacora";
            this.dgv_Bitacora.Size = new System.Drawing.Size(1252, 460);
            this.dgv_Bitacora.TabIndex = 0;
            this.dgv_Bitacora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Bitacora_CellClick);
            // 
            // idBitacora
            // 
            this.idBitacora.DataPropertyName = "idBitacora";
            this.idBitacora.HeaderText = "Id Bitacora";
            this.idBitacora.Name = "idBitacora";
            this.idBitacora.ReadOnly = true;
            this.idBitacora.Width = 150;
            // 
            // idTicket
            // 
            this.idTicket.DataPropertyName = "idTicket";
            this.idTicket.HeaderText = "Id Ticket";
            this.idTicket.Name = "idTicket";
            this.idTicket.ReadOnly = true;
            this.idTicket.Width = 125;
            // 
            // tiempoLaborado
            // 
            this.tiempoLaborado.DataPropertyName = "tiempoLaborado";
            this.tiempoLaborado.HeaderText = "Tiempo Laborado";
            this.tiempoLaborado.Name = "tiempoLaborado";
            this.tiempoLaborado.ReadOnly = true;
            this.tiempoLaborado.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // idArchivoAdjunto
            // 
            this.idArchivoAdjunto.DataPropertyName = "idArchivoAdjunto";
            this.idArchivoAdjunto.HeaderText = "Id Archivo Adjunto";
            this.idArchivoAdjunto.Name = "idArchivoAdjunto";
            this.idArchivoAdjunto.ReadOnly = true;
            this.idArchivoAdjunto.Width = 125;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha Bitacora";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Width = 160;
            // 
            // Consultar
            // 
            this.Consultar.HeaderText = "Consultar";
            this.Consultar.Name = "Consultar";
            this.Consultar.Text = "Consultar";
            this.Consultar.Width = 125;
            // 
            // frm_Ticket_BitacoraTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Ticket_BitacoraTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bitacora de Ticket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Ticket_BitacoraTicket_FormClosing);
            this.Load += new System.EventHandler(this.frm_Ticket_BitacoraTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Bitacora;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoLaborado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArchivoAdjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn Consultar;
        private System.Windows.Forms.Label label1;
    }
}