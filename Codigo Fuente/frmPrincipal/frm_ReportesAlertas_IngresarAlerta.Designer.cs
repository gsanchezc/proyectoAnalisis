namespace frmPrincipal
{
    partial class frm_ReportesAlertas_IngresarAlerta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_IngresarAlerta = new System.Windows.Forms.Button();
            this.txt_Referencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Prioridad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Empleados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DetalleAlerta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_TiposAlerta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_Referencia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_Prioridad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_Empleados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_DetalleAlerta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_TiposAlerta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1261, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Alerta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmPrincipal.Properties.Resources.Alerts1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(853, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 319);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_regresar);
            this.groupBox2.Controls.Add(this.btn_IngresarAlerta);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(30, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 109);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(390, 46);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(199, 33);
            this.btn_regresar.TabIndex = 1;
            this.btn_regresar.Text = "Regresar a Alertas";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_IngresarAlerta
            // 
            this.btn_IngresarAlerta.Location = new System.Drawing.Point(40, 46);
            this.btn_IngresarAlerta.Name = "btn_IngresarAlerta";
            this.btn_IngresarAlerta.Size = new System.Drawing.Size(199, 33);
            this.btn_IngresarAlerta.TabIndex = 0;
            this.btn_IngresarAlerta.Text = "Ingresar Alerta";
            this.btn_IngresarAlerta.UseVisualStyleBackColor = true;
            // 
            // txt_Referencia
            // 
            this.txt_Referencia.Location = new System.Drawing.Point(247, 348);
            this.txt_Referencia.Name = "txt_Referencia";
            this.txt_Referencia.Size = new System.Drawing.Size(272, 26);
            this.txt_Referencia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero Referencia";
            // 
            // cmb_Prioridad
            // 
            this.cmb_Prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Prioridad.FormattingEnabled = true;
            this.cmb_Prioridad.Location = new System.Drawing.Point(247, 292);
            this.cmb_Prioridad.Name = "cmb_Prioridad";
            this.cmb_Prioridad.Size = new System.Drawing.Size(272, 28);
            this.cmb_Prioridad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prioridad";
            // 
            // cmb_Empleados
            // 
            this.cmb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Empleados.FormattingEnabled = true;
            this.cmb_Empleados.Location = new System.Drawing.Point(247, 240);
            this.cmb_Empleados.Name = "cmb_Empleados";
            this.cmb_Empleados.Size = new System.Drawing.Size(272, 28);
            this.cmb_Empleados.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empleado";
            // 
            // txt_DetalleAlerta
            // 
            this.txt_DetalleAlerta.Location = new System.Drawing.Point(247, 99);
            this.txt_DetalleAlerta.Multiline = true;
            this.txt_DetalleAlerta.Name = "txt_DetalleAlerta";
            this.txt_DetalleAlerta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DetalleAlerta.Size = new System.Drawing.Size(522, 115);
            this.txt_DetalleAlerta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalle";
            // 
            // cmb_TiposAlerta
            // 
            this.cmb_TiposAlerta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TiposAlerta.FormattingEnabled = true;
            this.cmb_TiposAlerta.Location = new System.Drawing.Point(247, 45);
            this.cmb_TiposAlerta.Name = "cmb_TiposAlerta";
            this.cmb_TiposAlerta.Size = new System.Drawing.Size(272, 28);
            this.cmb_TiposAlerta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo De Alerta";
            // 
            // frm_ReportesAlertas_IngresarAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_ReportesAlertas_IngresarAlerta";
            this.Text = "Nuevo Reporte Alerta";
            this.Load += new System.EventHandler(this.frm_ReportesAlertas_IngresarAlerta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Referencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Prioridad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Empleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DetalleAlerta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_TiposAlerta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_IngresarAlerta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}