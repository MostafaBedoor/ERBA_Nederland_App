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
using DevExpress.XtraEditors;

namespace ERBA_Manager.Configuratie.Forms
{
    public partial class Gebruikersbeheer : DevExpress.XtraEditors.XtraForm
    {
        

        public Gebruikersbeheer()
        {
            InitializeComponent();
        }

        private void editRec()
        {
            clsUsers cls = new clsUsers();
            Gebruiker geb = cls.GetGebruikerByID(Convert.ToInt32(gcGebruiker.GetRowCellValue(gcGebruiker.FocusedRowHandle, "ID")));
            Forms.AddEditUser frm = new Forms.AddEditUser(geb, Forms.AddEditUser.Taak.Bewerken);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frm.Dispose();
                herladen();
            }
        }

        private void herladen()
        {
            clsUsers cls = new clsUsers();
            gcEmployees.DataSource = cls.GetAllUesr();
        }

        private void navEdit_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            editRec();
        }

        private void navDelete_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (XtraMessageBox.Show(this, "Weet u het zeker dat u deze gebruiker wilt verwijderen?", "Verwijder gebruiker", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gcGebruiker.GetRowCellValue(gcGebruiker.FocusedRowHandle, "ID"));
                if (id > 0)
                {
                    MessageBox.Show("Weet u het zekere dat u deze gebruiker wilt verwijderen?", "Gebruiker verwijderen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    herladen();
                }
            }

        }
    }
}
