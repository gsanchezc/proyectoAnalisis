namespace frmPrincipal
{
    partial class frm_AtencionTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Bitacora = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.msk_FechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.msk_FechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.msk_FechaEntrega = new System.Windows.Forms.MaskedTextBox();
            this.msk_FechaAsignacion = new System.Windows.Forms.MaskedTextBox();
            this.rbt_Alto = new System.Windows.Forms.RadioButton();
            this.rbt_Medio = new System.Windows.Forms.RadioButton();
            this.rbt_Bajo = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ArchivoTecnico = new System.Windows.Forms.TextBox();
            this.txt_TiempoLaborado = new System.Windows.Forms.TextBox();
            this.txt_TecnicoAsignado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_AdjuntoUsuario = new System.Windows.Forms.TextBox();
            this.txt_TipoIssue = new System.Windows.Forms.TextBox();
            this.txt_TemaIssue = new System.Windows.Forms.TextBox();
            this.txt_DescripcionIssue = new System.Windows.Forms.TextBox();
            this.txt_StatusIssue = new System.Windows.Forms.TextBox();
            this.txt_idIssue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_ListadoTicket = new System.Windows.Forms.DataGridView();
            this.Id_Tciket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListadoTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id de Issue:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tema de Issue:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tipo de Issue:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_Aceptar);
            this.groupBox1.Controls.Add(this.txt_Bitacora);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.msk_FechaIngreso);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.msk_FechaInicio);
            this.groupBox1.Controls.Add(this.msk_FechaEntrega);
            this.groupBox1.Controls.Add(this.msk_FechaAsignacion);
            this.groupBox1.Controls.Add(this.rbt_Alto);
            this.groupBox1.Controls.Add(this.rbt_Medio);
            this.groupBox1.Controls.Add(this.rbt_Bajo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_ArchivoTecnico);
            this.groupBox1.Controls.Add(this.txt_TiempoLaborado);
            this.groupBox1.Controls.Add(this.txt_TecnicoAsignado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_AdjuntoUsuario);
            this.groupBox1.Controls.Add(this.txt_TipoIssue);
            this.groupBox1.Controls.Add(this.txt_TemaIssue);
            this.groupBox1.Controls.Add(this.txt_DescripcionIssue);
            this.groupBox1.Controls.Add(this.txt_StatusIssue);
            this.groupBox1.Controls.Add(this.txt_idIssue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(302, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 519);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atención de Ticket";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(494, 458);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 44;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(352, 458);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 43;
            this.btn_Aceptar.Text = "&Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // txt_Bitacora
            // 
            this.txt_Bitacora.Location = new System.Drawing.Point(158, 306);
            this.txt_Bitacora.Multiline = true;
            this.txt_Bitacora.Name = "txt_Bitacora";
            this.txt_Bitacora.Size = new System.Drawing.Size(491, 117);
            this.txt_Bitacora.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(103, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Bitacora:";
            // 
            // msk_FechaIngreso
            // 
            this.msk_FechaIngreso.Location = new System.Drawing.Point(158, 258);
            this.msk_FechaIngreso.Mask = "00/00/0000";
            this.msk_FechaIngreso.Name = "msk_FechaIngreso";
            this.msk_FechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.msk_FechaIngreso.TabIndex = 40;
            this.msk_FechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(74, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Fecha Ingreso:";
            // 
            // msk_FechaInicio
            // 
            this.msk_FechaInicio.Location = new System.Drawing.Point(494, 171);
            this.msk_FechaInicio.Mask = "00/00/0000";
            this.msk_FechaInicio.Name = "msk_FechaInicio";
            this.msk_FechaInicio.Size = new System.Drawing.Size(100, 20);
            this.msk_FechaInicio.TabIndex = 39;
            this.msk_FechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // msk_FechaEntrega
            // 
            this.msk_FechaEntrega.Location = new System.Drawing.Point(494, 209);
            this.msk_FechaEntrega.Mask = "00/00/0000";
            this.msk_FechaEntrega.Name = "msk_FechaEntrega";
            this.msk_FechaEntrega.Size = new System.Drawing.Size(100, 20);
            this.msk_FechaEntrega.TabIndex = 38;
            this.msk_FechaEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // msk_FechaAsignacion
            // 
            this.msk_FechaAsignacion.Location = new System.Drawing.Point(494, 135);
            this.msk_FechaAsignacion.Mask = "00/00/0000";
            this.msk_FechaAsignacion.Name = "msk_FechaAsignacion";
            this.msk_FechaAsignacion.Size = new System.Drawing.Size(100, 20);
            this.msk_FechaAsignacion.TabIndex = 37;
            this.msk_FechaAsignacion.ValidatingType = typeof(System.DateTime);
            // 
            // rbt_Alto
            // 
            this.rbt_Alto.AutoSize = true;
            this.rbt_Alto.Location = new System.Drawing.Point(606, 102);
            this.rbt_Alto.Name = "rbt_Alto";
            this.rbt_Alto.Size = new System.Drawing.Size(43, 17);
            this.rbt_Alto.TabIndex = 36;
            this.rbt_Alto.TabStop = true;
            this.rbt_Alto.Text = "Alta";
            this.rbt_Alto.UseVisualStyleBackColor = true;
            // 
            // rbt_Medio
            // 
            this.rbt_Medio.AutoSize = true;
            this.rbt_Medio.Location = new System.Drawing.Point(546, 102);
            this.rbt_Medio.Name = "rbt_Medio";
            this.rbt_Medio.Size = new System.Drawing.Size(54, 17);
            this.rbt_Medio.TabIndex = 35;
            this.rbt_Medio.TabStop = true;
            this.rbt_Medio.Text = "Medio";
            this.rbt_Medio.UseVisualStyleBackColor = true;
            // 
            // rbt_Bajo
            // 
            this.rbt_Bajo.AutoSize = true;
            this.rbt_Bajo.Location = new System.Drawing.Point(494, 102);
            this.rbt_Bajo.Name = "rbt_Bajo";
            this.rbt_Bajo.Size = new System.Drawing.Size(46, 17);
            this.rbt_Bajo.TabIndex = 34;
            this.rbt_Bajo.TabStop = true;
            this.rbt_Bajo.Text = "Bajo";
            this.rbt_Bajo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Fecha asignacion:";
            // 
            // txt_ArchivoTecnico
            // 
            this.txt_ArchivoTecnico.Location = new System.Drawing.Point(494, 67);
            this.txt_ArchivoTecnico.Name = "txt_ArchivoTecnico";
            this.txt_ArchivoTecnico.Size = new System.Drawing.Size(134, 20);
            this.txt_ArchivoTecnico.TabIndex = 31;
            // 
            // txt_TiempoLaborado
            // 
            this.txt_TiempoLaborado.Location = new System.Drawing.Point(494, 244);
            this.txt_TiempoLaborado.Name = "txt_TiempoLaborado";
            this.txt_TiempoLaborado.Size = new System.Drawing.Size(100, 20);
            this.txt_TiempoLaborado.TabIndex = 29;
            // 
            // txt_TecnicoAsignado
            // 
            this.txt_TecnicoAsignado.Location = new System.Drawing.Point(494, 33);
            this.txt_TecnicoAsignado.Name = "txt_TecnicoAsignado";
            this.txt_TecnicoAsignado.Size = new System.Drawing.Size(134, 20);
            this.txt_TecnicoAsignado.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha Entrega:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tiempo laborado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tecnico Asignado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Archivo adjunto tecnico:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Prioridad:";
            // 
            // txt_AdjuntoUsuario
            // 
            this.txt_AdjuntoUsuario.Location = new System.Drawing.Point(158, 217);
            this.txt_AdjuntoUsuario.Name = "txt_AdjuntoUsuario";
            this.txt_AdjuntoUsuario.Size = new System.Drawing.Size(134, 20);
            this.txt_AdjuntoUsuario.TabIndex = 20;
            // 
            // txt_TipoIssue
            // 
            this.txt_TipoIssue.Location = new System.Drawing.Point(158, 71);
            this.txt_TipoIssue.Name = "txt_TipoIssue";
            this.txt_TipoIssue.Size = new System.Drawing.Size(134, 20);
            this.txt_TipoIssue.TabIndex = 19;
            // 
            // txt_TemaIssue
            // 
            this.txt_TemaIssue.Location = new System.Drawing.Point(158, 107);
            this.txt_TemaIssue.Name = "txt_TemaIssue";
            this.txt_TemaIssue.Size = new System.Drawing.Size(134, 20);
            this.txt_TemaIssue.TabIndex = 18;
            // 
            // txt_DescripcionIssue
            // 
            this.txt_DescripcionIssue.Location = new System.Drawing.Point(158, 142);
            this.txt_DescripcionIssue.Name = "txt_DescripcionIssue";
            this.txt_DescripcionIssue.Size = new System.Drawing.Size(134, 20);
            this.txt_DescripcionIssue.TabIndex = 17;
            // 
            // txt_StatusIssue
            // 
            this.txt_StatusIssue.Location = new System.Drawing.Point(158, 179);
            this.txt_StatusIssue.Name = "txt_StatusIssue";
            this.txt_StatusIssue.Size = new System.Drawing.Size(134, 20);
            this.txt_StatusIssue.TabIndex = 16;
            // 
            // txt_idIssue
            // 
            this.txt_idIssue.Location = new System.Drawing.Point(158, 36);
            this.txt_idIssue.Name = "txt_idIssue";
            this.txt_idIssue.ReadOnly = true;
            this.txt_idIssue.Size = new System.Drawing.Size(134, 20);
            this.txt_idIssue.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Archivo adjunto al Issue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status de Issue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripcion de Issue:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_ListadoTicket);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 510);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Ticket";
            // 
            // dtg_ListadoTicket
            // 
            this.dtg_ListadoTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ListadoTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Tciket,
            this.Nombre_Ticket});
            this.dtg_ListadoTicket.Location = new System.Drawing.Point(6, 40);
            this.dtg_ListadoTicket.Name = "dtg_ListadoTicket";
            this.dtg_ListadoTicket.Size = new System.Drawing.Size(253, 446);
            this.dtg_ListadoTicket.TabIndex = 0;
            // 
            // Id_Tciket
            // 
            this.Id_Tciket.HeaderText = "Id Ticket";
            this.Id_Tciket.Name = "Id_Tciket";
            // 
            // Nombre_Ticket
            // 
            this.Nombre_Ticket.HeaderText = "Nombre Ticket";
            this.Nombre_Ticket.Name = "Nombre_Ticket";
            // 
            // frm_AtencionTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_AtencionTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtencionTicket";
            this.Load += new System.EventHandler(this.frm_AtencioTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListadoTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_AdjuntoUsuario;
        private System.Windows.Forms.TextBox txt_TipoIssue;
        private System.Windows.Forms.TextBox txt_TemaIssue;
        private System.Windows.Forms.TextBox txt_DescripcionIssue;
        private System.Windows.Forms.TextBox txt_StatusIssue;
        private System.Windows.Forms.TextBox txt_idIssue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Bitacora;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox msk_FechaIngreso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox msk_FechaInicio;
        private System.Windows.Forms.MaskedTextBox msk_FechaEntrega;
        private System.Windows.Forms.MaskedTextBox msk_FechaAsignacion;
        private System.Windows.Forms.RadioButton rbt_Alto;
        private System.Windows.Forms.RadioButton rbt_Medio;
        private System.Windows.Forms.RadioButton rbt_Bajo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ArchivoTecnico;
        private System.Windows.Forms.TextBox txt_TiempoLaborado;
        private System.Windows.Forms.TextBox txt_TecnicoAsignado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_ListadoTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tciket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Ticket;
    }
}