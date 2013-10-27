namespace frmPrincipal
{
    partial class frm_CxC_CxP_CatalogoOrdenesDeCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CxC_CxP_CatalogoOrdenesDeCompra));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_NuevoOrdenCompra = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dtg_OrdenCompra = new System.Windows.Forms.DataGridView();
            this.Numero_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Cotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver_Cotizacion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg_OrdenCompra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 473);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catalogo Ordenes de Compra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_NuevoOrdenCompra);
            this.groupBox2.Controls.Add(this.btn_cerrar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(16, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 56);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_NuevoOrdenCompra
            // 
            this.btn_NuevoOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoOrdenCompra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_NuevoOrdenCompra.Location = new System.Drawing.Point(38, 22);
            this.btn_NuevoOrdenCompra.Name = "btn_NuevoOrdenCompra";
            this.btn_NuevoOrdenCompra.Size = new System.Drawing.Size(196, 23);
            this.btn_NuevoOrdenCompra.TabIndex = 4;
            this.btn_NuevoOrdenCompra.Text = "&Nuevo Orden de Compra";
            this.btn_NuevoOrdenCompra.UseVisualStyleBackColor = true;
            this.btn_NuevoOrdenCompra.Click += new System.EventHandler(this.btn_NuevoOrdenCompra_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cerrar.Location = new System.Drawing.Point(257, 22);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(196, 23);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click_1);
            // 
            // dtg_OrdenCompra
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_OrdenCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_OrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_OrdenCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Orden,
            this.Proveedor,
            this.Numero_Cotizacion,
            this.Ver_Cotizacion});
            this.dtg_OrdenCompra.Location = new System.Drawing.Point(16, 32);
            this.dtg_OrdenCompra.Name = "dtg_OrdenCompra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_OrdenCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_OrdenCompra.Size = new System.Drawing.Size(944, 373);
            this.dtg_OrdenCompra.TabIndex = 0;
            // 
            // Numero_Orden
            // 
            this.Numero_Orden.HeaderText = "Numero Orden";
            this.Numero_Orden.Name = "Numero_Orden";
            this.Numero_Orden.Width = 200;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 250;
            // 
            // Numero_Cotizacion
            // 
            this.Numero_Cotizacion.HeaderText = "Numero Cotizacion";
            this.Numero_Cotizacion.Name = "Numero_Cotizacion";
            this.Numero_Cotizacion.Width = 200;
            // 
            // Ver_Cotizacion
            // 
            this.Ver_Cotizacion.HeaderText = "Ver Cotizacion";
            this.Ver_Cotizacion.Name = "Ver_Cotizacion";
            this.Ver_Cotizacion.Text = "Ver Cotizacion";
            this.Ver_Cotizacion.Width = 250;
            // 
            // frm_CxC_CxP_CatalogoOrdenesDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CxC_CxP_CatalogoOrdenesDeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ordenes De Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OrdenCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_NuevoOrdenCompra;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dtg_OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Cotizacion;
        private System.Windows.Forms.DataGridViewLinkColumn Ver_Cotizacion;


    }
}