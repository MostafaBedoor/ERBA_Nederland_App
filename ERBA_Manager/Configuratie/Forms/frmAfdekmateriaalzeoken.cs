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
using DevExpress.XtraGrid.Views.Grid;

namespace ERBA_Manager.Configuratie.Forms
{
    public partial class frmAfdekmateriaalzeoken : DevExpress.XtraEditors.XtraForm
    {
        string DelMessage = "Weet je zeker dat?";
        string DelCap = "Waarschuwing";
        clsAfdekmateriaal cls = new clsAfdekmateriaal();
        public frmAfdekmateriaalzeoken()
        {
            InitializeComponent();
            gcSuppliers.DataSource = cls.GetAllAfdekmateriaal();
        }

        private void itmEinde_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void navAdd_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAfdekmateriaal f = new frmAfdekmateriaal(0);
            f.ShowDialog();
            gcSuppliers.DataSource = cls.GetAllAfdekmateriaal();
        }

        private void navEdit_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAfdekmateriaal f = new frmAfdekmateriaal(int.Parse(gcCP.GetFocusedRowCellValue("AfdekID").ToString()));
            f.ShowDialog();
            gcSuppliers.DataSource = cls.GetAllAfdekmateriaal();
        }

        private void navDelete_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (MessageBox.Show(DelMessage, DelCap, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.DeleteAfdekmateriaal(int.Parse(gcCP.GetFocusedRowCellValue("AfdekID").ToString()));
                gcSuppliers.DataSource = cls.GetAllAfdekmateriaal();
            }
        }
    }
}