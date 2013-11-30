namespace frmPrincipal
{
    partial class frm_ReportesAlertas_GenerarGrafico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportesAlertas_GenerarGrafico));
            this.btn_regresarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_regresarMenu
            // 
            this.btn_regresarMenu.Location = new System.Drawing.Point(565, 221);
            this.btn_regresarMenu.Name = "btn_regresarMenu";
            this.btn_regresarMenu.Size = new System.Drawing.Size(113, 32);
            this.btn_regresarMenu.TabIndex = 0;
            this.btn_regresarMenu.Text = "Regresar Al Menu";
            this.btn_regresarMenu.UseVisualStyleBackColor = true;
            this.btn_regresarMenu.Click += new System.EventHandler(this.btn_regresarMenu_Click);
            // 
            // frm_ReportesAlertas_GenerarGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.Controls.Add(this.btn_regresarMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ReportesAlertas_GenerarGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generar Grafico o Reporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ReportesAlertas_GenerarGrafico_FormClosing);
            this.Load += new System.EventHandler(this.frm_ReportesAlertas_GenerarGrafico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regresarMenu;


    }
}