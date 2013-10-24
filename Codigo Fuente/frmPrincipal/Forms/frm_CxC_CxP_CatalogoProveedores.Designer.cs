namespace frmPrincipal
{
    partial class frm_CxC_CxP_CatalogoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CxC_CxP_CatalogoProveedores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catalogo Proveedores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Proveedor,
            this.Nombre_Proveedor,
            this.Editar});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_Proveedor
            // 
            this.Id_Proveedor.HeaderText = "Id Proveedor";
            this.Id_Proveedor.Name = "Id_Proveedor";
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.HeaderText = "Nombre Proveedor";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            this.Nombre_Proveedor.Width = 300;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(642, 32);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(116, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "&Nuevo Proveedor";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(642, 81);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(116, 23);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // frm_CxC_CxP_CatalogoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 326);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CxC_CxP_CatalogoProveedores";
            this.Text = "Catalogo Proveedores";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}