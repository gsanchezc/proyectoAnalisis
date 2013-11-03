namespace frmPrincipal
{
    partial class frm_MantenimientoDescripcionRoles1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_editar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dtg_ListaDescripcionRol = new System.Windows.Forms.DataGridView();
            this.Id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaDescripcionRol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_cerrar);
            this.groupBox1.Controls.Add(this.dtg_ListaDescripcionRol);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 473);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripcion Roles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_editar);
            this.groupBox2.Controls.Add(this.btn_actualizar);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(15, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de Lista";
            // 
            // b_editar
            // 
            this.b_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_editar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.b_editar.Location = new System.Drawing.Point(24, 22);
            this.b_editar.Name = "b_editar";
            this.b_editar.Size = new System.Drawing.Size(187, 23);
            this.b_editar.TabIndex = 5;
            this.b_editar.Text = "E&ditar";
            this.b_editar.UseVisualStyleBackColor = true;
            this.b_editar.Click += new System.EventHandler(this.b_editar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_actualizar.Location = new System.Drawing.Point(479, 22);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(187, 23);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "&Actualizar Lista";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_eliminar.Location = new System.Drawing.Point(250, 22);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(187, 23);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cerrar.Location = new System.Drawing.Point(265, 441);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(187, 23);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dtg_ListaDescripcionRol
            // 
            this.dtg_ListaDescripcionRol.AllowUserToAddRows = false;
            this.dtg_ListaDescripcionRol.AllowUserToDeleteRows = false;
            this.dtg_ListaDescripcionRol.AllowUserToOrderColumns = true;
            this.dtg_ListaDescripcionRol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_ListaDescripcionRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ListaDescripcionRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_estado,
            this.Descripcion});
            this.dtg_ListaDescripcionRol.Location = new System.Drawing.Point(15, 33);
            this.dtg_ListaDescripcionRol.Name = "dtg_ListaDescripcionRol";
            this.dtg_ListaDescripcionRol.ReadOnly = true;
            this.dtg_ListaDescripcionRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ListaDescripcionRol.Size = new System.Drawing.Size(954, 327);
            this.dtg_ListaDescripcionRol.TabIndex = 0;
            // 
            // Id_estado
            // 
            this.Id_estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_estado.DataPropertyName = "idRol";
            this.Id_estado.HeaderText = "ID Rol";
            this.Id_estado.Name = "Id_estado";
            this.Id_estado.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_agregar.Location = new System.Drawing.Point(39, 441);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(211, 23);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "&Nueva Descripcion de Rol";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // frm_MantenimientoDescripcionRoles1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_MantenimientoDescripcionRoles1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Descripcion Roles";
            this.Load += new System.EventHandler(this.frm_MantenimientoDescripcionRoles1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaDescripcionRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dtg_ListaDescripcionRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_agregar;
    }
}