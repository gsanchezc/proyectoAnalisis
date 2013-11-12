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
    public partial class frm_ReporteAlertas_MantenimientoComunicacion : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private int rolUsuario;

        public frm_ReporteAlertas_MantenimientoComunicacion()
        {
            InitializeComponent();
        }

        public frm_ReporteAlertas_MantenimientoComunicacion(string usuario) : this()
        {
            this.usuarioSistema = usuario;
        }

        private void frm_ReporteAlertas_MantenimientoComunicacion_Load(object sender, EventArgs e)
        {
            this.cargaRolUsuario();
            this.rolesUsuario();
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

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            frm_0MenuPrincipal ventana = new frm_0MenuPrincipal(usuarioSistema);
            this.Close();
            ventana.Show();
        }
    }
}
