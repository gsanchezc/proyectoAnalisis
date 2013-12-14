namespace frmPrincipal
{
    partial class frm_MantenimientoIncapacidades
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
            this.dtg_ListaIncapacidades = new System.Windows.Forms.DataGridView();
            this.idIncapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_fechaFin = new System.Windows.Forms.TextBox();
            this.txt_fecha_ingreso = new System.Windows.Forms.TextBox();
            this.txt_nomb_empleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total_dias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaIncapacidades)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_ListaIncapacidades
            // 
            this.dtg_ListaIncapacidades.AllowUserToAddRows = false;
            this.dtg_ListaIncapacidades.AllowUserToDeleteRows = false;
            this.dtg_ListaIncapacidades.AllowUserToOrderColumns = true;
            this.dtg_ListaIncapacidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ListaIncapacidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIncapacidad,
            this.idEmpleado,
            this.diaInicio,
            this.diaFin,
            this.totalDias,
            this.Editar,
            this.Eliminar});
            this.dtg_ListaIncapacidades.Location = new System.Drawing.Point(6, 20);
            this.dtg_ListaIncapacidades.Name = "dtg_ListaIncapacidades";
            this.dtg_ListaIncapacidades.ReadOnly = true;
            this.dtg_ListaIncapacidades.Size = new System.Drawing.Size(616, 494);
            this.dtg_ListaIncapacidades.TabIndex = 0;
            this.dtg_ListaIncapacidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ListaIncapacidades_CellContentClick);
            // 
            // idIncapacidad
            // 
            this.idIncapacidad.DataPropertyName = "idIncapacidad";
            this.idIncapacidad.HeaderText = "# Incapacidad";
            this.idIncapacidad.Name = "idIncapacidad";
            this.idIncapacidad.ReadOnly = true;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "Nombre Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Width = 90;
            // 
            // diaInicio
            // 
            this.diaInicio.DataPropertyName = "diaInicio";
            this.diaInicio.HeaderText = "Dia Inicio";
            this.diaInicio.Name = "diaInicio";
            this.diaInicio.ReadOnly = true;
            this.diaInicio.Width = 70;
            // 
            // diaFin
            // 
            this.diaFin.DataPropertyName = "diaFin";
            this.diaFin.HeaderText = "Dia Fin";
            this.diaFin.Name = "diaFin";
            this.diaFin.ReadOnly = true;
            this.diaFin.Width = 70;
            // 
            // totalDias
            // 
            this.totalDias.DataPropertyName = "totalDias";
            this.totalDias.HeaderText = "Total Dias";
            this.totalDias.Name = "totalDias";
            this.totalDias.ReadOnly = true;
            this.totalDias.Width = 70;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 85;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtg_ListaIncapacidades);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 514);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Incapacidades";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_fechaFin);
            this.groupBox3.Controls.Add(this.txt_fecha_ingreso);
            this.groupBox3.Controls.Add(this.txt_nomb_empleado);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_total_dias);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_descripcion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(641, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 490);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Incapacidades";
            // 
            // txt_fechaFin
            // 
            this.txt_fechaFin.Location = new System.Drawing.Point(9, 344);
            this.txt_fechaFin.Name = "txt_fechaFin";
            this.txt_fechaFin.Size = new System.Drawing.Size(200, 22);
            this.txt_fechaFin.TabIndex = 17;
            this.txt_fechaFin.Text = "mm/dd/yyyy";
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(9, 255);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(200, 22);
            this.txt_fecha_ingreso.TabIndex = 16;
            this.txt_fecha_ingreso.Text = "mm/dd/yyyy";
            // 
            // txt_nomb_empleado
            // 
            this.txt_nomb_empleado.Location = new System.Drawing.Point(9, 94);
            this.txt_nomb_empleado.Name = "txt_nomb_empleado";
            this.txt_nomb_empleado.Size = new System.Drawing.Size(277, 22);
            this.txt_nomb_empleado.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre Empleado:";
            // 
            // txt_total_dias
            // 
            this.txt_total_dias.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_total_dias.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_total_dias.Location = new System.Drawing.Point(9, 418);
            this.txt_total_dias.Name = "txt_total_dias";
            this.txt_total_dias.Size = new System.Drawing.Size(200, 22);
            this.txt_total_dias.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total dias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dia Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dia Inicio";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(9, 175);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(277, 22);
            this.txt_descripcion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Guardar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(996, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 318);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_limpiar.Location = new System.Drawing.Point(22, 152);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(180, 35);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "&Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(22, 218);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(180, 35);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Guardar.Location = new System.Drawing.Point(22, 84);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(180, 35);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // frm_MantenimientoIncapacidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_MantenimientoIncapacidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Incapacidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MantenimientoIncapacidades_FormClosing);
            this.Load += new System.EventHandler(this.frm_MantenimientoIncapacidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaIncapacidades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_ListaIncapacidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_total_dias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIncapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDias;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TextBox txt_nomb_empleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fechaFin;
        private System.Windows.Forms.TextBox txt_fecha_ingreso;
    }
}