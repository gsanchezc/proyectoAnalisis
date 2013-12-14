namespace frmPrincipal
{
    partial class frm_RRHH_NuevaNomina
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_anio = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_totaldeducciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ccss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fondoPensiones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_salarioNeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SalarioBruto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_hrsExtra = new System.Windows.Forms.TextBox();
            this.txt_salarioBase = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_horasLaborada = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.g.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_anio);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cmb_mes);
            this.groupBox4.Controls.Add(this.btn_Salir);
            this.groupBox4.Controls.Add(this.btn_generar);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cmb_empleado);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1240, 62);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione Cliente y Fecha";
            // 
            // cmb_anio
            // 
            this.cmb_anio.FormattingEnabled = true;
            this.cmb_anio.Items.AddRange(new object[] {
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
            this.cmb_anio.Location = new System.Drawing.Point(647, 23);
            this.cmb_anio.Name = "cmb_anio";
            this.cmb_anio.Size = new System.Drawing.Size(116, 23);
            this.cmb_anio.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(610, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Año";
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_mes.Location = new System.Drawing.Point(464, 23);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(116, 23);
            this.cmb_mes.TabIndex = 10;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(1077, 17);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(112, 33);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "&Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(911, 17);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(116, 34);
            this.btn_generar.TabIndex = 7;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Empleado";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(142, 23);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(254, 23);
            this.cmb_empleado.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(424, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mes";
            // 
            // g
            // 
            this.g.Controls.Add(this.groupBox3);
            this.g.Controls.Add(this.txt_salarioNeto);
            this.g.Controls.Add(this.label4);
            this.g.Controls.Add(this.txt_SalarioBruto);
            this.g.Controls.Add(this.label9);
            this.g.Controls.Add(this.txt_hrsExtra);
            this.g.Controls.Add(this.txt_salarioBase);
            this.g.Controls.Add(this.label10);
            this.g.Controls.Add(this.label11);
            this.g.Controls.Add(this.txt_horasLaborada);
            this.g.Controls.Add(this.label12);
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.g.Location = new System.Drawing.Point(13, 79);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(1240, 422);
            this.g.TabIndex = 21;
            this.g.TabStop = false;
            this.g.Text = "Calculo de Nomina";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_totaldeducciones);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_ccss);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_fondoPensiones);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(527, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 173);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deducciones";
            // 
            // txt_totaldeducciones
            // 
            this.txt_totaldeducciones.Location = new System.Drawing.Point(173, 115);
            this.txt_totaldeducciones.Name = "txt_totaldeducciones";
            this.txt_totaldeducciones.ReadOnly = true;
            this.txt_totaldeducciones.Size = new System.Drawing.Size(260, 21);
            this.txt_totaldeducciones.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total deducciones:";
            // 
            // txt_ccss
            // 
            this.txt_ccss.Location = new System.Drawing.Point(173, 78);
            this.txt_ccss.Name = "txt_ccss";
            this.txt_ccss.ReadOnly = true;
            this.txt_ccss.Size = new System.Drawing.Size(260, 21);
            this.txt_ccss.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "C.C.S.S:";
            // 
            // txt_fondoPensiones
            // 
            this.txt_fondoPensiones.Location = new System.Drawing.Point(173, 34);
            this.txt_fondoPensiones.Name = "txt_fondoPensiones";
            this.txt_fondoPensiones.ReadOnly = true;
            this.txt_fondoPensiones.Size = new System.Drawing.Size(260, 21);
            this.txt_fondoPensiones.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fondo de pensiones:";
            // 
            // txt_salarioNeto
            // 
            this.txt_salarioNeto.Location = new System.Drawing.Point(672, 238);
            this.txt_salarioNeto.Name = "txt_salarioNeto";
            this.txt_salarioNeto.ReadOnly = true;
            this.txt_salarioNeto.Size = new System.Drawing.Size(260, 21);
            this.txt_salarioNeto.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Salario Neto:";
            // 
            // txt_SalarioBruto
            // 
            this.txt_SalarioBruto.Location = new System.Drawing.Point(177, 210);
            this.txt_SalarioBruto.Name = "txt_SalarioBruto";
            this.txt_SalarioBruto.ReadOnly = true;
            this.txt_SalarioBruto.Size = new System.Drawing.Size(260, 21);
            this.txt_SalarioBruto.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Salario bruto:";
            // 
            // txt_hrsExtra
            // 
            this.txt_hrsExtra.Location = new System.Drawing.Point(177, 88);
            this.txt_hrsExtra.Name = "txt_hrsExtra";
            this.txt_hrsExtra.Size = new System.Drawing.Size(260, 21);
            this.txt_hrsExtra.TabIndex = 33;
            this.txt_hrsExtra.Text = "0";
            // 
            // txt_salarioBase
            // 
            this.txt_salarioBase.Location = new System.Drawing.Point(177, 148);
            this.txt_salarioBase.Name = "txt_salarioBase";
            this.txt_salarioBase.ReadOnly = true;
            this.txt_salarioBase.Size = new System.Drawing.Size(260, 21);
            this.txt_salarioBase.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Horas extra:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Horas laboradas:";
            // 
            // txt_horasLaborada
            // 
            this.txt_horasLaborada.Location = new System.Drawing.Point(177, 36);
            this.txt_horasLaborada.Name = "txt_horasLaborada";
            this.txt_horasLaborada.ReadOnly = true;
            this.txt_horasLaborada.Size = new System.Drawing.Size(260, 21);
            this.txt_horasLaborada.TabIndex = 31;
            this.txt_horasLaborada.Text = "48";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Salario Base:";
            // 
            // frm_RRHH_NuevaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.g);
            this.Controls.Add(this.groupBox4);
            this.Name = "frm_RRHH_NuevaNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generar Nueva Nomina";
            this.Load += new System.EventHandler(this.frm_RRHH_NuevaNomina_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_anio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_totaldeducciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ccss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fondoPensiones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_salarioNeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SalarioBruto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_hrsExtra;
        private System.Windows.Forms.TextBox txt_salarioBase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_horasLaborada;
        private System.Windows.Forms.Label label12;
    }
}