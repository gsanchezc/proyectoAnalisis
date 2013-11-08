namespace frmPrincipal
{
    partial class frm_RRHH_ControlIncapacidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RRHH_ControlIncapacidades));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dtg_Incapacidades = new System.Windows.Forms.DataGridView();
            this.idIncapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isApprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Incapacidades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.dtg_Incapacidades);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 473);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Incapacidades";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Cancelar.Location = new System.Drawing.Point(1065, 415);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(152, 23);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "&Salir";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dtg_Incapacidades
            // 
            this.dtg_Incapacidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Incapacidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIncapacidad,
            this.idEmpleado,
            this.diaInicio,
            this.diaFin,
            this.totalDias,
            this.isApprove});
            this.dtg_Incapacidades.Location = new System.Drawing.Point(19, 32);
            this.dtg_Incapacidades.Name = "dtg_Incapacidades";
            this.dtg_Incapacidades.Size = new System.Drawing.Size(1025, 419);
            this.dtg_Incapacidades.TabIndex = 1;
            // 
            // idIncapacidad
            // 
            this.idIncapacidad.DataPropertyName = "idIncapacidad";
            this.idIncapacidad.HeaderText = "IdIcapacidad";
            this.idIncapacidad.Name = "idIncapacidad";
            this.idIncapacidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "IdEmpleado";
            this.idEmpleado.Name = "idEmpleado";
            // 
            // diaInicio
            // 
            this.diaInicio.DataPropertyName = "diaInicio";
            this.diaInicio.HeaderText = "Día Inicio";
            this.diaInicio.Name = "diaInicio";
            this.diaInicio.Width = 190;
            // 
            // diaFin
            // 
            this.diaFin.DataPropertyName = "diaFin";
            this.diaFin.HeaderText = "Día fin";
            this.diaFin.Name = "diaFin";
            this.diaFin.Width = 190;
            // 
            // totalDias
            // 
            this.totalDias.DataPropertyName = "totalDias";
            this.totalDias.HeaderText = "Total Días";
            this.totalDias.Name = "totalDias";
            this.totalDias.Width = 190;
            // 
            // isApprove
            // 
            this.isApprove.DataPropertyName = "isApprove";
            this.isApprove.HeaderText = "Status";
            this.isApprove.Name = "isApprove";
            this.isApprove.Width = 190;
            // 
            // frm_RRHH_ControlIncapacidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RRHH_ControlIncapacidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control Incapacidades";
            this.Load += new System.EventHandler(this.frm_RRHH_ControlIncapacidades_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Incapacidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_Incapacidades;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIncapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn isApprove;
    }
}