namespace frmPrincipal
{
    partial class frm_Ticket_BitacoraDetalle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_VerArchivoAdjuntoBitacora = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.pb_ArchivoAdjunto = new System.Windows.Forms.PictureBox();
            this.txt_Tecnico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fechaBitacora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IDArchivoBitacora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DescripcionBitacora = new System.Windows.Forms.TextBox();
            this.txt_TiempoLaborado = new System.Windows.Forms.TextBox();
            this.txt_IdTicket = new System.Windows.Forms.TextBox();
            this.txt_IdBitacora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ArchivoAdjunto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pb_ArchivoAdjunto);
            this.groupBox1.Controls.Add(this.txt_Tecnico);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_fechaBitacora);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_IDArchivoBitacora);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_DescripcionBitacora);
            this.groupBox1.Controls.Add(this.txt_TiempoLaborado);
            this.groupBox1.Controls.Add(this.txt_IdTicket);
            this.groupBox1.Controls.Add(this.txt_IdBitacora);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Bitacora";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_VerArchivoAdjuntoBitacora);
            this.groupBox2.Controls.Add(this.Cerrar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(197, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 144);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_VerArchivoAdjuntoBitacora
            // 
            this.btn_VerArchivoAdjuntoBitacora.Location = new System.Drawing.Point(21, 34);
            this.btn_VerArchivoAdjuntoBitacora.Name = "btn_VerArchivoAdjuntoBitacora";
            this.btn_VerArchivoAdjuntoBitacora.Size = new System.Drawing.Size(281, 37);
            this.btn_VerArchivoAdjuntoBitacora.TabIndex = 14;
            this.btn_VerArchivoAdjuntoBitacora.Text = "Ver Archivo Adjunto Bitacora";
            this.btn_VerArchivoAdjuntoBitacora.UseVisualStyleBackColor = true;
            this.btn_VerArchivoAdjuntoBitacora.Click += new System.EventHandler(this.btn_VerArchivoAdjuntoBitacora_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(21, 90);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(281, 37);
            this.Cerrar.TabIndex = 15;
            this.Cerrar.Text = "Cerrar Bitacora";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pb_ArchivoAdjunto
            // 
            this.pb_ArchivoAdjunto.BackgroundImage = global::frmPrincipal.Properties.Resources.pdfLogo;
            this.pb_ArchivoAdjunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_ArchivoAdjunto.Location = new System.Drawing.Point(60, 342);
            this.pb_ArchivoAdjunto.Name = "pb_ArchivoAdjunto";
            this.pb_ArchivoAdjunto.Size = new System.Drawing.Size(109, 120);
            this.pb_ArchivoAdjunto.TabIndex = 68;
            this.pb_ArchivoAdjunto.TabStop = false;
            // 
            // txt_Tecnico
            // 
            this.txt_Tecnico.Location = new System.Drawing.Point(218, 231);
            this.txt_Tecnico.Name = "txt_Tecnico";
            this.txt_Tecnico.ReadOnly = true;
            this.txt_Tecnico.Size = new System.Drawing.Size(281, 26);
            this.txt_Tecnico.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tecnico Bitacora";
            // 
            // txt_fechaBitacora
            // 
            this.txt_fechaBitacora.Location = new System.Drawing.Point(218, 179);
            this.txt_fechaBitacora.Name = "txt_fechaBitacora";
            this.txt_fechaBitacora.ReadOnly = true;
            this.txt_fechaBitacora.Size = new System.Drawing.Size(281, 26);
            this.txt_fechaBitacora.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha Bitacora";
            // 
            // txt_IDArchivoBitacora
            // 
            this.txt_IDArchivoBitacora.Location = new System.Drawing.Point(218, 286);
            this.txt_IDArchivoBitacora.Name = "txt_IDArchivoBitacora";
            this.txt_IDArchivoBitacora.ReadOnly = true;
            this.txt_IDArchivoBitacora.Size = new System.Drawing.Size(281, 26);
            this.txt_IDArchivoBitacora.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID_ArchivoAdjunto";
            // 
            // txt_DescripcionBitacora
            // 
            this.txt_DescripcionBitacora.Location = new System.Drawing.Point(539, 45);
            this.txt_DescripcionBitacora.Multiline = true;
            this.txt_DescripcionBitacora.Name = "txt_DescripcionBitacora";
            this.txt_DescripcionBitacora.ReadOnly = true;
            this.txt_DescripcionBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DescripcionBitacora.Size = new System.Drawing.Size(676, 434);
            this.txt_DescripcionBitacora.TabIndex = 7;
            // 
            // txt_TiempoLaborado
            // 
            this.txt_TiempoLaborado.Location = new System.Drawing.Point(218, 128);
            this.txt_TiempoLaborado.Name = "txt_TiempoLaborado";
            this.txt_TiempoLaborado.ReadOnly = true;
            this.txt_TiempoLaborado.Size = new System.Drawing.Size(281, 26);
            this.txt_TiempoLaborado.TabIndex = 6;
            // 
            // txt_IdTicket
            // 
            this.txt_IdTicket.Location = new System.Drawing.Point(218, 80);
            this.txt_IdTicket.Name = "txt_IdTicket";
            this.txt_IdTicket.ReadOnly = true;
            this.txt_IdTicket.Size = new System.Drawing.Size(281, 26);
            this.txt_IdTicket.TabIndex = 5;
            // 
            // txt_IdBitacora
            // 
            this.txt_IdBitacora.Location = new System.Drawing.Point(218, 35);
            this.txt_IdBitacora.Name = "txt_IdBitacora";
            this.txt_IdBitacora.ReadOnly = true;
            this.txt_IdBitacora.Size = new System.Drawing.Size(281, 26);
            this.txt_IdBitacora.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion de Bitacora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo Laborado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Bitacora";
            // 
            // frm_Ticket_BitacoraDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Ticket_BitacoraDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_TicketBitacoraDetalle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Ticket_BitacoraDetalle_FormClosing);
            this.Load += new System.EventHandler(this.frm_TicketBitacoraDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ArchivoAdjunto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_VerArchivoAdjuntoBitacora;
        private System.Windows.Forms.TextBox txt_Tecnico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fechaBitacora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IDArchivoBitacora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DescripcionBitacora;
        private System.Windows.Forms.TextBox txt_TiempoLaborado;
        private System.Windows.Forms.TextBox txt_IdTicket;
        private System.Windows.Forms.TextBox txt_IdBitacora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_ArchivoAdjunto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Cerrar;
    }
}