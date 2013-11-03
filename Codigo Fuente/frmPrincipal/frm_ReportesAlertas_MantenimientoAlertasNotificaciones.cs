using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frm_ReportesAlertas_MantenimientoAlertasNotificaciones : Form
    {
        public frm_ReportesAlertas_MantenimientoAlertasNotificaciones(int id)
        {
            int usuario = id;
            InitializeComponent();

            labelUsuario.Text = id.ToString();
        }
    }
}
