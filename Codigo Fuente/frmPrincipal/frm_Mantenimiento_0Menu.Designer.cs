namespace frmPrincipal
{
    partial class frm_Mantenimiento_0Menu
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
            this.btn_estatusFactura = new System.Windows.Forms.Button();
            this.btn_descripcionRoles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_estatusFactura
            // 
            this.btn_estatusFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_estatusFactura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_estatusFactura.Location = new System.Drawing.Point(333, 12);
            this.btn_estatusFactura.Name = "btn_estatusFactura";
            this.btn_estatusFactura.Size = new System.Drawing.Size(205, 42);
            this.btn_estatusFactura.TabIndex = 0;
            this.btn_estatusFactura.Text = "Mantenimiento Estados de Factura";
            this.btn_estatusFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estatusFactura.UseVisualStyleBackColor = true;
            this.btn_estatusFactura.Click += new System.EventHandler(this.btn_estatusFactura_Click);
            // 
            // btn_descripcionRoles
            // 
            this.btn_descripcionRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_descripcionRoles.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_descripcionRoles.Location = new System.Drawing.Point(333, 71);
            this.btn_descripcionRoles.Name = "btn_descripcionRoles";
            this.btn_descripcionRoles.Size = new System.Drawing.Size(205, 42);
            this.btn_descripcionRoles.TabIndex = 1;
            this.btn_descripcionRoles.Text = "Mantenimiento Descripcion de Roles";
            this.btn_descripcionRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_descripcionRoles.UseVisualStyleBackColor = true;
            this.btn_descripcionRoles.Click += new System.EventHandler(this.btn_descripcionRoles_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(333, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mantenimiento Tipo Puesto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Mantenimiento_0Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_descripcionRoles);
            this.Controls.Add(this.btn_estatusFactura);
            this.Name = "frm_Mantenimiento_0Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu de Mantenimiento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_estatusFactura;
        private System.Windows.Forms.Button btn_descripcionRoles;
        private System.Windows.Forms.Button button1;
    }
}