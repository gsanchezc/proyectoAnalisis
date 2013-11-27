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
    public partial class frm_CxC_CxP_CatalogoOrdenesDeCompra : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        OrdenCompras objOrdenCompra = new OrdenCompras();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_CxC_CxP_CatalogoOrdenesDeCompra()
        {
            InitializeComponent();
        }

        public frm_CxC_CxP_CatalogoOrdenesDeCompra(string usuario, string pantalla) :this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_CxC_CxP_CatalogoOrdenesDeCompra_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
            this.cargaDataGridOrdenesDeCompra();
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void cargaRolUsuario()
        {
            objUsuariosSistema.cargaRolUsuario(usuarioSistema);
            rolUsuario = objUsuariosSistema.idRol;
        }

        //METODO PARA MANEJAR EL ACCESO POR ROLES
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void rolesUsuario()
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);

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

        private void btn_NuevoOrdenCompra_Click(object sender, EventArgs e)
        {
            string pantalla = "CatalogoOrdenes";
            int IdSolicitud = 0;
            frm_CxC_CxP_NuevaOrdenCompra ventana = new frm_CxC_CxP_NuevaOrdenCompra(usuarioSistema, IdSolicitud, pantalla);
            this.Close();
            ventana.Show();
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);

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

        //METODO 
        //RAFAEL ANGEL SEQUEIRA VARGAS
        private void cargaDataGridOrdenesDeCompra()
        {
            try
            {
                dtg_OrdenCompra.AutoGenerateColumns = false;
                dtg_OrdenCompra.DataSource = objOrdenCompra.cargarDataGridOrdenesDeCompra().Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexion a la base de datos", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
