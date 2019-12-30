using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.EntitiesClasses;
using DataLayer;

namespace ERBA_Manager.Configuratie
{
    public partial class ConfigMain : DevExpress.XtraEditors.XtraForm
    {
        public ConfigMain()
        {
            InitializeComponent();
            
        }

        private void ConfigMain_Load(object sender, EventArgs e)
        {

        }

        private void itmSuppliers_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //Forms.frmSuppliers frm = new Forms.frmSuppliers();
            //frm.ShowDialog();
        }

        private void itmEinde_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void tileItem12_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }
    }
}
