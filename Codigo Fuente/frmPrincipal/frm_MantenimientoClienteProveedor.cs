﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;

namespace frmPrincipal
{
    public partial class frm_MantenimientoClienteProveedor : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;

        public frm_MantenimientoClienteProveedor()
        {
            InitializeComponent();
        }

        public frm_MantenimientoClienteProveedor(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_MantenimientoClienteProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_0Menu ventana = new frm_Mantenimiento_0Menu(usuarioSistema);
            if ((MessageBox.Show("Desea regresar al menu principal", "Volver al Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Close();
                ventana.Show();
            }
            else
            {
                return;
            }
        }

        private void dtg_ClienteProveedor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

