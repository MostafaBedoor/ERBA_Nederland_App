using BusinessLayer.EntitiesClasses;
using DataLayer;
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
    public partial class AddEditEmployee : DevExpress.XtraEditors.XtraForm
    {
        private Gebruiker _empoloyee;

        public AddEditEmployee(int employeeID)
        {
            InitializeComponent();
            vulCombos();
            if (employeeID > 0)
            {
                clsUsers cls = new clsUsers();
                _empoloyee = cls.GetGebruikerByID(employeeID);
            }


        }

        private void vulCombos()
        {
            //GetUesrRolls
            clsUsers cls = new clsUsers();
            cmbRol.DataSource = cls.GetUesrRolls();
            cmbRol.DisplayMember = "Rol";
            cmbRol.ValueMember = "ID";
            cmbRol.SelectedIndex = -1;

            cmbFunctie.DataSource = cls.GetUesrFunctie();
            BindingSource bs = new BindingSource();
            bs.DataSource = cls.GetUesrFunctie();
            cmbFunctie.DataSource = bs;
            cmbFunctie.SelectedIndex = -1;

            cmbGeslacht.Items.Add("Man");
            cmbGeslacht.Items.Add("Vrouw");
            cmbGeslacht.Items.Add("Onbekend");
            cmbGeslacht.SelectedIndex = -1;
        }

        private void chkWW_CheckedChanged(object sender, EventArgs e)
        {
            txtWW.UseSystemPasswordChar = !chkWW.Checked;
        }
    }
}
