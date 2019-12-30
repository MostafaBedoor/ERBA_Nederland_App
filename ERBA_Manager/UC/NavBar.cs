using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace ERBA_Manager.UC
{
    public partial class NavBar : XtraUserControl
    {
        GridControl gc = new GridControl();
        public NavBar()
        {
            InitializeComponent();
        }

        private void itmEinde_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ParentForm.Close();
        }
    }
}
