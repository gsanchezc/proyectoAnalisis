namespace frmPrincipal
{
    partial class frm_RRHH_ControlNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RRHH_ControlNomina));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_verResumen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cmb_anioNomina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_mesNomina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_Planilla = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasLaboradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rebajos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Planilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmb_anioNomina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_mesNomina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtg_Planilla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 494);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo y consulta de planilla";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_verResumen);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(535, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 59);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar Nomina";
            // 
            // btn_verResumen
            // 
            this.btn_verResumen.Location = new System.Drawing.Point(37, 21);
            this.btn_verResumen.Name = "btn_verResumen";
            this.btn_verResumen.Size = new System.Drawing.Size(130, 23);
            this.btn_verResumen.TabIndex = 13;
            this.btn_verResumen.Text = "&Ver Resumen";
            this.btn_verResumen.UseVisualStyleBackColor = true;
            this.btn_verResumen.Click += new System.EventHandler(this.btn_verResumen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Aceptar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(844, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 59);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar Nomina Nueva";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(28, 21);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(122, 23);
            this.btn_Aceptar.TabIndex = 12;
            this.btn_Aceptar.Text = "&Generar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(156, 21);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(122, 23);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cmb_anioNomina
            // 
            this.cmb_anioNomina.FormattingEnabled = true;
            this.cmb_anioNomina.Items.AddRange(new object[] {
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmb_anioNomina.Location = new System.Drawing.Point(308, 46);
            this.cmb_anioNomina.Name = "cmb_anioNomina";
            this.cmb_anioNomina.Size = new System.Drawing.Size(121, 24);
            this.cmb_anioNomina.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Anio:";
            // 
            // cmb_mesNomina
            // 
            this.cmb_mesNomina.FormattingEnabled = true;
            this.cmb_mesNomina.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_mesNomina.Location = new System.Drawing.Point(123, 46);
            this.cmb_mesNomina.Name = "cmb_mesNomina";
            this.cmb_mesNomina.Size = new System.Drawing.Size(121, 24);
            this.cmb_mesNomina.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mes a Generar";
            // 
            // dtg_Planilla
            // 
            this.dtg_Planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Planilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.identificacion,
            this.nombre,
            this.apellido,
            this.horasLaboradas,
            this.horasExtra,
            this.salario,
            this.salarioBruto,
            this.rebajos,
            this.salarioNeto});
            this.dtg_Planilla.Location = new System.Drawing.Point(9, 97);
            this.dtg_Planilla.Name = "dtg_Planilla";
            this.dtg_Planilla.Size = new System.Drawing.Size(1225, 391);
            this.dtg_Planilla.TabIndex = 0;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "IdEmpleado";
            this.idEmpleado.Name = "idEmpleado";
            // 
            // identificacion
            // 
            this.identificacion.DataPropertyName = "identificacion";
            this.identificacion.HeaderText = "Identificacion";
            this.identificacion.Name = "identificacion";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellidos";
            this.apellido.Name = "apellido";
            // 
            // horasLaboradas
            // 
            this.horasLaboradas.DataPropertyName = "horasLaboradas";
            this.horasLaboradas.HeaderText = "Horas Laboradas";
            this.horasLaboradas.Name = "horasLaboradas";
            // 
            // horasExtra
            // 
            this.horasExtra.DataPropertyName = "horasExtra";
            this.horasExtra.HeaderText = "Extras";
            this.horasExtra.Name = "horasExtra";
            // 
            // salario
            // 
            this.salario.DataPropertyName = "salario";
            this.salario.HeaderText = "Salario Base";
            this.salario.Name = "salario";
            // 
            // salarioBruto
            // 
            this.salarioBruto.DataPropertyName = "salarioBruto";
            this.salarioBruto.HeaderText = "Salario Bruto";
            this.salarioBruto.Name = "salarioBruto";
            // 
            // rebajos
            // 
            this.rebajos.DataPropertyName = "rebajos";
            this.rebajos.HeaderText = "Rebajos";
            this.rebajos.Name = "rebajos";
            // 
            // salarioNeto
            // 
            this.salarioNeto.DataPropertyName = "salarioNeto";
            this.salarioNeto.HeaderText = "Salario Neto";
            this.salarioNeto.Name = "salarioNeto";
            // 
            // frm_RRHH_ControlNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RRHH_ControlNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control Nomina";
            this.Load += new System.EventHandler(this.frm_RRHH_ControlNomina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Planilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_verResumen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cmb_anioNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_mesNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_Planilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasLaboradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn rebajos;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioNeto;

    }
}