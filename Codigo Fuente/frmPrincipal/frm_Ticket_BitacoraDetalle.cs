using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using System.IO;
using System.Diagnostics;

namespace frmPrincipal
{
    public partial class frm_Ticket_BitacoraDetalle : Form
    {
        //DECLARACION DE INSTANCIAS DE LAS CLASES
        UsuariosSistema objUsuariosSistema = new UsuariosSistema();
        ClienteProveedor objClienteProveedor = new ClienteProveedor();
        Bitacora objBitacora = new Bitacora();

        //CONECCION
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(local);Initial Catalog=db_soportic;Integrated Security=True");
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //VARIABLES GLOBALES
        private string usuarioSistema = string.Empty;
        private string pantalla = string.Empty;
        private int IdBitacora = 0;
        private int Ticket = 0;
        private string filefullpath = string.Empty;
        private string filetype = string.Empty;
        private string filename = string.Empty;
        private byte[] FileBytes = null;

        public frm_Ticket_BitacoraDetalle()
        {
            InitializeComponent();
        }

        public frm_Ticket_BitacoraDetalle(string usuario, int idBitacora, string pantalla, int Ticket) : this()
        {
            this.usuarioSistema = usuario;
            this.IdBitacora = idBitacora;
            this.pantalla = pantalla;
            this.Ticket = Ticket;
        }

        private void frm_TicketBitacoraDetalle_Load(object sender, EventArgs e)
        {
            this.cargarDatosBitacoraEspecifico();
        }

        private void btn_VerArchivoAdjuntoBitacora_Click(object sender, EventArgs e)
        {
            this.abrirArchivoAdjunto();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarDatosBitacoraEspecifico()
        {
            txt_IdBitacora.Text = IdBitacora.ToString();

            objBitacora.cargarDatosBitacoraEspecifico(IdBitacora);

            txt_IdTicket.Text = objBitacora.idTicket.ToString();
            txt_TiempoLaborado.Text = objBitacora.tiempoLaborado.ToString();
            txt_DescripcionBitacora.Text = objBitacora.descripcion;
            txt_IDArchivoBitacora.Text = objBitacora.idArchivoAdjunto.ToString();
            txt_fechaBitacora.Text = objBitacora.fecha.Substring(0, 10);
            txt_Tecnico.Text = objBitacora.Empleado;
        }

        //METODO ABRE ARCHIVO ADJUNTO
        //RAFAEL ANGEL SEQUEIRA VARGAS
        public void abrirArchivoAdjunto()
        {
            string id;
            FileStream FS = null;
            byte[] dbbyte;

            id = txt_IDArchivoBitacora.Text;

            sqlcon.Open();
            sqlcmd = new SqlCommand("select * from tbl_datosAdjuntos where idArchivoAdjunto='" + id + "'", sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            dt = new DataTable();
            da.Fill(dt);
            sqlcon.Close();

            if (dt.Rows.Count > 0)
            {
                dbbyte = (byte[])dt.Rows[0]["archivo"];
                string filepath = "D:\\temp.pdf";

                FS = new FileStream(filepath, System.IO.FileMode.Create);
                FS.Write(dbbyte, 0, dbbyte.Length);
                FS.Close();

                Process Proc = new Process();
                Proc.StartInfo.FileName = filepath;
                Proc.Start();
            }
            sqlcon.Close();
        }

        private void frm_Ticket_BitacoraDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
