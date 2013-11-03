using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clases
{
    public static class Limpieza
    {
        #region metodos

        public static void limpiar(CheckBox chkb)
        {
            chkb.CheckState = CheckState.Unchecked;
        }

        public static void limpiar(ListBox lst)
        {
            lst.Items.Clear();
        }

        public static void limpiar(TextBox txt)
        {
            txt.Clear();
        }

        public static void limpiar(MaskedTextBox mtb)
        {
            mtb.Clear();
        }

        public static void limpiar(ComboBox cb)
        {
            cb.Items.Clear();
        }

        public static void limpiar(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        #endregion
    }
}
