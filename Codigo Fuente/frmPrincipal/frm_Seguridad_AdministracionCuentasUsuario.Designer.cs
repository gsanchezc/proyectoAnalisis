namespace frmPrincipal
{
    partial class frm_Seguridad_AdministracionCuentasUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Seguridad_AdministracionCuentasUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbt_activo = new System.Windows.Forms.RadioButton();
            this.rbt_inactivo = new System.Windows.Forms.RadioButton();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.txt_confirmaContraseña = new System.Windows.Forms.TextBox();
            this.btn_establecer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_ListaUsuario = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion de Usuario y Contrasena";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txt_confirmaContraseña);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_Contraseña);
            this.groupBox3.Controls.Add(this.txt_Usuario);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(306, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 427);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario y Contrasena";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbt_activo);
            this.groupBox4.Controls.Add(this.rbt_inactivo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(13, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 95);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estatus de Cuenta";
            // 
            // rbt_activo
            // 
            this.rbt_activo.AutoSize = true;
            this.rbt_activo.Location = new System.Drawing.Point(33, 44);
            this.rbt_activo.Name = "rbt_activo";
            this.rbt_activo.Size = new System.Drawing.Size(76, 24);
            this.rbt_activo.TabIndex = 14;
            this.rbt_activo.TabStop = true;
            this.rbt_activo.Text = "Activo";
            this.rbt_activo.UseVisualStyleBackColor = true;
            // 
            // rbt_inactivo
            // 
            this.rbt_inactivo.AutoSize = true;
            this.rbt_inactivo.Location = new System.Drawing.Point(234, 44);
            this.rbt_inactivo.Name = "rbt_inactivo";
            this.rbt_inactivo.Size = new System.Drawing.Size(90, 24);
            this.rbt_inactivo.TabIndex = 13;
            this.rbt_inactivo.TabStop = true;
            this.rbt_inactivo.Text = "Inactivo";
            this.rbt_inactivo.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(60, 119);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(128, 30);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // txt_confirmaContraseña
            // 
            this.txt_confirmaContraseña.Location = new System.Drawing.Point(22, 249);
            this.txt_confirmaContraseña.Name = "txt_confirmaContraseña";
            this.txt_confirmaContraseña.PasswordChar = '*';
            this.txt_confirmaContraseña.Size = new System.Drawing.Size(352, 26);
            this.txt_confirmaContraseña.TabIndex = 9;
            // 
            // btn_establecer
            // 
            this.btn_establecer.Location = new System.Drawing.Point(60, 55);
            this.btn_establecer.Name = "btn_establecer";
            this.btn_establecer.Size = new System.Drawing.Size(128, 27);
            this.btn_establecer.TabIndex = 7;
            this.btn_establecer.Text = "Establecer";
            this.btn_establecer.UseVisualStyleBackColor = true;
            this.btn_establecer.Click += new System.EventHandler(this.btn_establecer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirmar Contrasena";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(22, 167);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(352, 26);
            this.txt_Contraseña.TabIndex = 7;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(22, 86);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(352, 26);
            this.txt_Usuario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_ListaUsuario);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(20, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 427);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Usuarios";
            // 
            // lst_ListaUsuario
            // 
            this.lst_ListaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_ListaUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lst_ListaUsuario.FormattingEnabled = true;
            this.lst_ListaUsuario.ItemHeight = 16;
            this.lst_ListaUsuario.Location = new System.Drawing.Point(19, 31);
            this.lst_ListaUsuario.Name = "lst_ListaUsuario";
            this.lst_ListaUsuario.Size = new System.Drawing.Size(223, 372);
            this.lst_ListaUsuario.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_establecer);
            this.groupBox5.Controls.Add(this.btn_cerrar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Location = new System.Drawing.Point(716, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 427);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opciones";
            // 
            // frm_Seguridad_AdministracionCuentasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Seguridad_AdministracionCuentasUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administracion Cuentas Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_ListaUsuario;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_establecer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_confirmaContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbt_activo;
        private System.Windows.Forms.RadioButton rbt_inactivo;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}