namespace frmPrincipal
{
    partial class frm_Mantenimiento_ClienteProveedor
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
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreClienteProveedor = new System.Windows.Forms.TextBox();
            this.txt_idClienteProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_ClienteProveedor = new System.Windows.Forms.DataGridView();
            this.Id_Cliente_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClienteProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_Cancelar);
            this.groupBox2.Controls.Add(this.btn_Aceptar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_nombreClienteProveedor);
            this.groupBox2.Controls.Add(this.txt_idClienteProveedor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(579, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 473);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_eliminar.Location = new System.Drawing.Point(272, 221);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Cancelar.Location = new System.Drawing.Point(193, 323);
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
            this.btn_Aceptar.Location = new System.Drawing.Point(102, 221);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "&Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id_ClienteProveedor";
            // 
            // txt_nombreClienteProveedor
            // 
            this.txt_nombreClienteProveedor.Location = new System.Drawing.Point(179, 107);
            this.txt_nombreClienteProveedor.Name = "txt_nombreClienteProveedor";
            this.txt_nombreClienteProveedor.Size = new System.Drawing.Size(190, 20);
            this.txt_nombreClienteProveedor.TabIndex = 5;
            // 
            // txt_idClienteProveedor
            // 
            this.txt_idClienteProveedor.Location = new System.Drawing.Point(179, 27);
            this.txt_idClienteProveedor.Name = "txt_idClienteProveedor";
            this.txt_idClienteProveedor.ReadOnly = true;
            this.txt_idClienteProveedor.Size = new System.Drawing.Size(190, 20);
            this.txt_idClienteProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del\r\nCliente o Proveedor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_ClienteProveedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 473);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes y Proveedores";
            // 
            // dtg_ClienteProveedor
            // 
            this.dtg_ClienteProveedor.AllowUserToOrderColumns = true;
            this.dtg_ClienteProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ClienteProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente_Proveedor,
            this.Nombre});
            this.dtg_ClienteProveedor.Location = new System.Drawing.Point(18, 28);
            this.dtg_ClienteProveedor.Name = "dtg_ClienteProveedor";
            this.dtg_ClienteProveedor.Size = new System.Drawing.Size(517, 428);
            this.dtg_ClienteProveedor.TabIndex = 0;
            // 
            // Id_Cliente_Proveedor
            // 
            this.Id_Cliente_Proveedor.HeaderText = "Id_Cliente_Proveedor";
            this.Id_Cliente_Proveedor.Name = "Id_Cliente_Proveedor";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // frm_Mantenimiento_ClienteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Mantenimiento_ClienteProveedor";
            this.Text = "Mantenimiento Cliente & Proveedor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClienteProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreClienteProveedor;
        private System.Windows.Forms.TextBox txt_idClienteProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_ClienteProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btn_eliminar;
    }
}