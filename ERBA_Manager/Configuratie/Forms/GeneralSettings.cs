using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERBA_Manager.Configuratie.Forms
{
    public partial class GeneralSettings : DevExpress.XtraEditors.XtraForm
    {
        public GeneralSettings()
        {
            InitializeComponent();
        }


        private void chkPWVisible_CheckedChanged(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = !chkPWVisible.Checked;
        }
    }
}
