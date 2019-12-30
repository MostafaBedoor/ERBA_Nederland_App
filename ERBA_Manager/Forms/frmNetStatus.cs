using DataLayer;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERBA_Manager.Forms
{
    public partial class frmNetStatus : DevExpress.XtraEditors.XtraForm
    {
        public frmNetStatus()
        {
            InitializeComponent();
            Comboboxes.NetStatus(cmbNetStatus);
            Comboboxes.NetStatus(cmbNetstatusNaar);
            int x = int.Parse(cmbNetStatus.SelectedValue.ToString());
            using (ERBAEntities db = new ERBAEntities())
            {
                Comboboxes.Netten(cmbNet, x);
                gc.DataSource = db.Netnummers.Where(n => n.Netstatus == x).ToList();
            }
            Comboboxes.AutoclaafNaam(cmbClavenNaam);
            //RepositoryItemGridLookUpEdit rl = new RepositoryItemGridLookUpEdit();
            //using (ERBAEntities db = new ERBAEntities())
            //{
            //    rl.DataSource = db.Netstatus.Select(c => new { c.NetstatusID, c.Netstatus1 }).ToList();
            //    rl.ValueMember = "NetstatusID";
            //    rl.DisplayMember = "Netstatus1";
            //}
            //StatusNaar.ColumnEdit = rl; 
        }
        
        private void cmbAutoclavenNaam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Comboboxes.Temperature(cmbTemp, cmbClavenNaam.SelectedValue.ToString());
        }
        
        private void cmbNetStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int x = int.Parse(cmbNetStatus.SelectedValue.ToString());
            using (ERBAEntities db = new ERBAEntities())
            {
                Comboboxes.Netten(cmbNet, x);
                gc.DataSource = db.Netnummers.Where(n => n.Netstatus == x).ToList();
            }
        }
    }
}