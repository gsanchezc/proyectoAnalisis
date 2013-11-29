namespace frmPrincipal
{
    partial class frm_CxC_CxP_NuevaOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CxC_CxP_NuevaOrdenCompra));
            this.btn_CrearOrden = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pb_ArchivoAdjunto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.btn_cargarArchivoPDF = new System.Windows.Forms.Button();
            this.btn_guardarArchivo = new System.Windows.Forms.Button();
            this.txt_IdArchivoAdjunto = new System.Windows.Forms.TextBox();
            this.txt_numeroTicket = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numeroCotizacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NombreArchivo = new System.Windows.Forms.TextBox();
            this.txt_DetalleOrdenDeCompra = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ArchivoAdjunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CrearOrden
            // 
            this.btn_CrearOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearOrden.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_CrearOrden.Location = new System.Drawing.Point(15, 34);
            this.btn_CrearOrden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CrearOrden.Name = "btn_CrearOrden";
            this.btn_CrearOrden.Size = new System.Drawing.Size(192, 37);
            this.btn_CrearOrden.TabIndex = 0;
            this.btn_CrearOrden.Text = "Crear Orden Compra";
            this.btn_CrearOrden.UseVisualStyleBackColor = true;
            this.btn_CrearOrden.Click += new System.EventHandler(this.btn_CrearOrden_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Cancelar.Location = new System.Drawing.Point(15, 95);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(192, 37);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "&Salir";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_CrearOrden);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1031, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 152);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 494);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Orden de Compra";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(677, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(323, 140);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Correo: info@soportic.com\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "San Jose, Costa Rica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Telefax: 5555-5555\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmPrincipal.Properties.Resources.support2;
            this.pictureBox1.Location = new System.Drawing.Point(18, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_DetalleOrdenDeCompra);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_NombreArchivo);
            this.groupBox4.Controls.Add(this.pb_ArchivoAdjunto);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_Monto);
            this.groupBox4.Controls.Add(this.btn_cargarArchivoPDF);
            this.groupBox4.Controls.Add(this.btn_guardarArchivo);
            this.groupBox4.Controls.Add(this.txt_IdArchivoAdjunto);
            this.groupBox4.Controls.Add(this.txt_numeroTicket);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_numeroCotizacion);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmb_proveedor);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(18, 158);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(982, 319);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Orden De Compra";
            // 
            // pb_ArchivoAdjunto
            // 
            this.pb_ArchivoAdjunto.BackgroundImage = global::frmPrincipal.Properties.Resources.pdfLogo;
            this.pb_ArchivoAdjunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_ArchivoAdjunto.Location = new System.Drawing.Point(793, 190);
            this.pb_ArchivoAdjunto.Name = "pb_ArchivoAdjunto";
            this.pb_ArchivoAdjunto.Size = new System.Drawing.Size(154, 121);
            this.pb_ArchivoAdjunto.TabIndex = 71;
            this.pb_ArchivoAdjunto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(572, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "ID Archivo Adjunto";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Monto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_Monto.Location = new System.Drawing.Point(207, 140);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(242, 26);
            this.txt_Monto.TabIndex = 3;
            // 
            // btn_cargarArchivoPDF
            // 
            this.btn_cargarArchivoPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargarArchivoPDF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cargarArchivoPDF.Location = new System.Drawing.Point(757, 20);
            this.btn_cargarArchivoPDF.Name = "btn_cargarArchivoPDF";
            this.btn_cargarArchivoPDF.Size = new System.Drawing.Size(206, 38);
            this.btn_cargarArchivoPDF.TabIndex = 5;
            this.btn_cargarArchivoPDF.Text = "Cargar PDF Cotizacion";
            this.btn_cargarArchivoPDF.UseVisualStyleBackColor = true;
            this.btn_cargarArchivoPDF.Click += new System.EventHandler(this.btn_cargarArchivoPDF_Click);
            // 
            // btn_guardarArchivo
            // 
            this.btn_guardarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarArchivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_guardarArchivo.Location = new System.Drawing.Point(757, 110);
            this.btn_guardarArchivo.Name = "btn_guardarArchivo";
            this.btn_guardarArchivo.Size = new System.Drawing.Size(206, 38);
            this.btn_guardarArchivo.TabIndex = 7;
            this.btn_guardarArchivo.Text = "Guardar Cotizacion";
            this.btn_guardarArchivo.UseVisualStyleBackColor = true;
            this.btn_guardarArchivo.Click += new System.EventHandler(this.btn_guardarArchivo_Click);
            // 
            // txt_IdArchivoAdjunto
            // 
            this.txt_IdArchivoAdjunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdArchivoAdjunto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_IdArchivoAdjunto.Location = new System.Drawing.Point(757, 154);
            this.txt_IdArchivoAdjunto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_IdArchivoAdjunto.Name = "txt_IdArchivoAdjunto";
            this.txt_IdArchivoAdjunto.ReadOnly = true;
            this.txt_IdArchivoAdjunto.Size = new System.Drawing.Size(206, 26);
            this.txt_IdArchivoAdjunto.TabIndex = 8;
            // 
            // txt_numeroTicket
            // 
            this.txt_numeroTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroTicket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_numeroTicket.Location = new System.Drawing.Point(207, 26);
            this.txt_numeroTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_numeroTicket.Name = "txt_numeroTicket";
            this.txt_numeroTicket.ReadOnly = true;
            this.txt_numeroTicket.Size = new System.Drawing.Size(242, 26);
            this.txt_numeroTicket.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(110, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Monto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(20, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Numero de Ticket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(20, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Detalle de la Orden de Compra";
            // 
            // txt_numeroCotizacion
            // 
            this.txt_numeroCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroCotizacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_numeroCotizacion.Location = new System.Drawing.Point(207, 62);
            this.txt_numeroCotizacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_numeroCotizacion.Name = "txt_numeroCotizacion";
            this.txt_numeroCotizacion.Size = new System.Drawing.Size(242, 26);
            this.txt_numeroCotizacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero Cotizacion";
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_proveedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(207, 103);
            this.cmb_proveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(341, 28);
            this.cmb_proveedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Proveedor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::frmPrincipal.Properties.Resources.Capture;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1046, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 258);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(572, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Nombre Archivo";
            // 
            // txt_NombreArchivo
            // 
            this.txt_NombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreArchivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_NombreArchivo.Location = new System.Drawing.Point(576, 65);
            this.txt_NombreArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_NombreArchivo.Name = "txt_NombreArchivo";
            this.txt_NombreArchivo.ReadOnly = true;
            this.txt_NombreArchivo.Size = new System.Drawing.Size(387, 26);
            this.txt_NombreArchivo.TabIndex = 6;
            // 
            // txt_DetalleOrdenDeCompra
            // 
            this.txt_DetalleOrdenDeCompra.Location = new System.Drawing.Point(24, 190);
            this.txt_DetalleOrdenDeCompra.Multiline = true;
            this.txt_DetalleOrdenDeCompra.Name = "txt_DetalleOrdenDeCompra";
            this.txt_DetalleOrdenDeCompra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DetalleOrdenDeCompra.Size = new System.Drawing.Size(707, 121);
            this.txt_DetalleOrdenDeCompra.TabIndex = 4;
            // 
            // frm_CxC_CxP_NuevaOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_CxC_CxP_NuevaOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nueva Orden Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_CxC_CxP_NuevaOrdenCompra_FormClosing);
            this.Load += new System.EventHandler(this.frm_CxC_CxP_NuevaOrdenCompra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ArchivoAdjunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearOrden;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numeroCotizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_IdArchivoAdjunto;
        private System.Windows.Forms.TextBox txt_numeroTicket;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Button btn_guardarArchivo;
        private System.Windows.Forms.Button btn_cargarArchivoPDF;
        private System.Windows.Forms.PictureBox pb_ArchivoAdjunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NombreArchivo;
        private System.Windows.Forms.TextBox txt_DetalleOrdenDeCompra;
    }
}