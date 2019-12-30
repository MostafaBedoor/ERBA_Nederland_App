using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERBA_Manager
{
    public partial class AppMain : DevExpress.XtraEditors.XtraForm
    {
        CultureInfo c;
        public AppMain()
        {
            InitializeComponent();
            lblTijd.Text = DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss");

            CultureInfo.CurrentCulture = new CultureInfo("nl-NL");
            CultureInfo.CurrentUICulture = new CultureInfo("nl-NL");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTijd.Text = DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss");
        }

        private void navSettings_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Configuratie.ConfigMain frm = new Configuratie.ConfigMain();
            frm.ShowDialog();
        }

        private void itmEinde_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (MessageBox.Show("Weet u zeker dat u alle programma's wilt afsluiten?", "Programma afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tileItem14_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Configuratie.Forms.frmAfdekmateriaalzeoken f = new Configuratie.Forms.frmAfdekmateriaalzeoken();
            f.Show();
        }

        private void tileItem15_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //Configuratie.Forms.frmSuppliers  f = new Configuratie.Forms.frmSuppliers();
            //f.Show();
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            CultureInfo.CurrentUICulture = new CultureInfo("en-GB");
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Forms.frmNetStatus f = new Forms.frmNetStatus();
            f.Show();
        }
    }
}
