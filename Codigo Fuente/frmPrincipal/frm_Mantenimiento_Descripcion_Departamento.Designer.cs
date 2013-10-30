namespace frmPrincipal
{
    partial class frm_Mantenimiento_Descripcion_Departamento
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
            this.dtg_DescripcionDepartamento = new System.Windows.Forms.DataGridView();
            this.Id_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DescripcionDepartamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_DescripcionDepartamento
            // 
            this.dtg_DescripcionDepartamento.AllowUserToOrderColumns = true;
            this.dtg_DescripcionDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DescripcionDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_departamento,
            this.Descripcion_Departamento});
            this.dtg_DescripcionDepartamento.Location = new System.Drawing.Point(18, 28);
            this.dtg_DescripcionDepartamento.Name = "dtg_DescripcionDepartamento";
            this.dtg_DescripcionDepartamento.Size = new System.Drawing.Size(578, 423);
            this.dtg_DescripcionDepartamento.TabIndex = 0;
            // 
            // Id_departamento
            // 
            this.Id_departamento.HeaderText = "Id_Departamento";
            this.Id_departamento.Name = "Id_departamento";
            // 
            // Descripcion_Departamento
            // 
            this.Descripcion_Departamento.HeaderText = "Descripcion_Departamento";
            this.Descripcion_Departamento.Name = "Descripcion_Departamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_DescripcionDepartamento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 473);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de departamentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Departamento";
            // 
            // txt_idDepartamento
            // 
            this.txt_idDepartamento.Location = new System.Drawing.Point(154, 27);
            this.txt_idDepartamento.Name = "txt_idDepartamento";
            this.txt_idDepartamento.ReadOnly = true;
            this.txt_idDepartamento.Size = new System.Drawing.Size(164, 20);
            this.txt_idDepartamento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion del \r\nDepartamento:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(154, 107);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(164, 20);
            this.txt_descripcion.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Aceptar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_descripcion);
            this.groupBox2.Controls.Add(this.txt_idDepartamento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(631, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 473);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_eliminar.Location = new System.Drawing.Point(243, 229);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Cancelar.Location = new System.Drawing.Point(154, 330);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Aceptar.Location = new System.Drawing.Point(67, 229);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "&Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // frm_Mantenimiento_Descripcion_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Mantenimiento_Descripcion_Departamento";
            this.Text = "Mantenimiento Descripcion Departamento";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DescripcionDepartamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_DescripcionDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Departamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}