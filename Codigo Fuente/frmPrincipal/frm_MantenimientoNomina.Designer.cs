namespace frmPrincipal
{
    partial class frm_MantenimientoNomina
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_ListaNomina = new System.Windows.Forms.DataGridView();
            this.idNomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesNomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioNomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasLaboradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rebajos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_salario_bruto = new System.Windows.Forms.TextBox();
            this.txt_horas_lab = new System.Windows.Forms.TextBox();
            this.cmb_empleados = new System.Windows.Forms.ComboBox();
            this.txt_horas_laboradas = new System.Windows.Forms.TextBox();
            this.cmb_mes_nomina = new System.Windows.Forms.ComboBox();
            this.cmb_año_nomina = new System.Windows.Forms.ComboBox();
            this.txt_salario_neto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_rebajos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaNomina)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(1041, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 221);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_limpiar.Location = new System.Drawing.Point(22, 113);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(160, 35);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "&Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(22, 168);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(160, 35);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Guardar.Location = new System.Drawing.Point(22, 56);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(160, 35);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg_ListaNomina);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 344);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Nomina";
            // 
            // dtg_ListaNomina
            // 
            this.dtg_ListaNomina.AllowUserToAddRows = false;
            this.dtg_ListaNomina.AllowUserToDeleteRows = false;
            this.dtg_ListaNomina.AllowUserToOrderColumns = true;
            this.dtg_ListaNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ListaNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNomina,
            this.mesNomina,
            this.anioNomina,
            this.idEmpleado,
            this.horasLaboradas,
            this.horasExtra,
            this.salario,
            this.salarioBruto,
            this.rebajos,
            this.salarioNeto,
            this.Editar,
            this.Eliminar});
            this.dtg_ListaNomina.Location = new System.Drawing.Point(6, 20);
            this.dtg_ListaNomina.Name = "dtg_ListaNomina";
            this.dtg_ListaNomina.ReadOnly = true;
            this.dtg_ListaNomina.Size = new System.Drawing.Size(1018, 319);
            this.dtg_ListaNomina.TabIndex = 0;
            this.dtg_ListaNomina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ListaNomina_CellContentClick);
            // 
            // idNomina
            // 
            this.idNomina.DataPropertyName = "idNomina";
            this.idNomina.HeaderText = "ID Nomina";
            this.idNomina.Name = "idNomina";
            this.idNomina.ReadOnly = true;
            this.idNomina.Width = 80;
            // 
            // mesNomina
            // 
            this.mesNomina.DataPropertyName = "mesNomina";
            this.mesNomina.HeaderText = "Mes Nomina";
            this.mesNomina.Name = "mesNomina";
            this.mesNomina.ReadOnly = true;
            this.mesNomina.Width = 80;
            // 
            // anioNomina
            // 
            this.anioNomina.DataPropertyName = "anioNomina";
            this.anioNomina.HeaderText = "Año Nomina";
            this.anioNomina.Name = "anioNomina";
            this.anioNomina.ReadOnly = true;
            this.anioNomina.Width = 80;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Width = 90;
            // 
            // horasLaboradas
            // 
            this.horasLaboradas.DataPropertyName = "horasLaboradas";
            this.horasLaboradas.HeaderText = "Horas Laboradas";
            this.horasLaboradas.Name = "horasLaboradas";
            this.horasLaboradas.ReadOnly = true;
            // 
            // horasExtra
            // 
            this.horasExtra.DataPropertyName = "horasExtra";
            this.horasExtra.HeaderText = "Horas Extra";
            this.horasExtra.Name = "horasExtra";
            this.horasExtra.ReadOnly = true;
            this.horasExtra.Width = 70;
            // 
            // salario
            // 
            this.salario.DataPropertyName = "salario";
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            this.salario.Width = 80;
            // 
            // salarioBruto
            // 
            this.salarioBruto.DataPropertyName = "salarioBruto";
            this.salarioBruto.HeaderText = "Salario Bruto";
            this.salarioBruto.Name = "salarioBruto";
            this.salarioBruto.ReadOnly = true;
            this.salarioBruto.Width = 85;
            // 
            // rebajos
            // 
            this.rebajos.DataPropertyName = "rebajos";
            this.rebajos.HeaderText = "Rebajos";
            this.rebajos.Name = "rebajos";
            this.rebajos.ReadOnly = true;
            this.rebajos.Width = 85;
            // 
            // salarioNeto
            // 
            this.salarioNeto.DataPropertyName = "salarioNeto";
            this.salarioNeto.HeaderText = "Salario Neto";
            this.salarioNeto.Name = "salarioNeto";
            this.salarioNeto.ReadOnly = true;
            this.salarioNeto.Width = 80;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 70;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 75;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_salario_bruto);
            this.groupBox3.Controls.Add(this.txt_horas_lab);
            this.groupBox3.Controls.Add(this.cmb_empleados);
            this.groupBox3.Controls.Add(this.txt_horas_laboradas);
            this.groupBox3.Controls.Add(this.cmb_mes_nomina);
            this.groupBox3.Controls.Add(this.cmb_año_nomina);
            this.groupBox3.Controls.Add(this.txt_salario_neto);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_rebajos);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_salario);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(5, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1260, 169);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Nomina";
            // 
            // txt_salario_bruto
            // 
            this.txt_salario_bruto.Location = new System.Drawing.Point(541, 111);
            this.txt_salario_bruto.Name = "txt_salario_bruto";
            this.txt_salario_bruto.Size = new System.Drawing.Size(203, 22);
            this.txt_salario_bruto.TabIndex = 39;
            // 
            // txt_horas_lab
            // 
            this.txt_horas_lab.Location = new System.Drawing.Point(541, 24);
            this.txt_horas_lab.Name = "txt_horas_lab";
            this.txt_horas_lab.Size = new System.Drawing.Size(203, 22);
            this.txt_horas_lab.TabIndex = 38;
            // 
            // cmb_empleados
            // 
            this.cmb_empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empleados.FormattingEnabled = true;
            this.cmb_empleados.Location = new System.Drawing.Point(162, 111);
            this.cmb_empleados.Name = "cmb_empleados";
            this.cmb_empleados.Size = new System.Drawing.Size(203, 24);
            this.cmb_empleados.TabIndex = 37;
            // 
            // txt_horas_laboradas
            // 
            this.txt_horas_laboradas.Location = new System.Drawing.Point(929, 69);
            this.txt_horas_laboradas.Name = "txt_horas_laboradas";
            this.txt_horas_laboradas.Size = new System.Drawing.Size(203, 22);
            this.txt_horas_laboradas.TabIndex = 34;
            // 
            // cmb_mes_nomina
            // 
            this.cmb_mes_nomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes_nomina.FormattingEnabled = true;
            this.cmb_mes_nomina.Location = new System.Drawing.Point(163, 24);
            this.cmb_mes_nomina.Name = "cmb_mes_nomina";
            this.cmb_mes_nomina.Size = new System.Drawing.Size(203, 24);
            this.cmb_mes_nomina.TabIndex = 31;
            // 
            // cmb_año_nomina
            // 
            this.cmb_año_nomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_año_nomina.FormattingEnabled = true;
            this.cmb_año_nomina.Location = new System.Drawing.Point(162, 69);
            this.cmb_año_nomina.Name = "cmb_año_nomina";
            this.cmb_año_nomina.Size = new System.Drawing.Size(203, 24);
            this.cmb_año_nomina.TabIndex = 30;
            // 
            // txt_salario_neto
            // 
            this.txt_salario_neto.Location = new System.Drawing.Point(929, 24);
            this.txt_salario_neto.Name = "txt_salario_neto";
            this.txt_salario_neto.Size = new System.Drawing.Size(203, 22);
            this.txt_salario_neto.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(828, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Salario Neto";
            // 
            // txt_rebajos
            // 
            this.txt_rebajos.Location = new System.Drawing.Point(930, 113);
            this.txt_rebajos.Name = "txt_rebajos";
            this.txt_rebajos.Size = new System.Drawing.Size(202, 22);
            this.txt_rebajos.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(856, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rebajos";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(541, 69);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(203, 22);
            this.txt_salario.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salario Bruto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Horas Laboradas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Horas Laboradas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año Nomina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes Nomina";
            // 
            // frm_MantenimientoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frm_MantenimientoNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Nomina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MantenimientoNomina_FormClosing);
            this.Load += new System.EventHandler(this.frm_MantenimientoNomina_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaNomina)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_ListaNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasLaboradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn rebajos;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioNeto;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_salario_bruto;
        private System.Windows.Forms.TextBox txt_horas_lab;
        private System.Windows.Forms.ComboBox cmb_empleados;
        private System.Windows.Forms.TextBox txt_horas_laboradas;
        private System.Windows.Forms.ComboBox cmb_mes_nomina;
        private System.Windows.Forms.ComboBox cmb_año_nomina;
        private System.Windows.Forms.TextBox txt_salario_neto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_rebajos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}