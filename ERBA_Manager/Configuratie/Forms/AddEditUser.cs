using System;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using DataLayer;
using BusinessLayer.EntitiesClasses;

namespace ERBA_Manager.Configuratie.Forms
{
    public partial class AddEditUser : DevExpress.XtraEditors.XtraForm
    {
        public Gebruiker NewGebruiker;
        private Taak _taak = Taak.Onbekend;
        public enum Taak
        {
            Bewerken,
            Toevoegen,
            Bekijken,
            Onbekend
        }
        public AddEditUser(int GebID)
        {
            this.Width = 519;
            InitializeComponent();
            _taak = Taak.Bekijken;
            DevExpress.Skins.SkinManager.EnableFormSkins();
            this.Text = "Gebruiker info";
            //groupControl1.Enabled = false;
            //grpMain.Enabled = false;
            txtNaam.ReadOnly = true;
            txtAdres.ReadOnly = true;
            txtPC.ReadOnly = true;
            txtPlaats.ReadOnly = true;
            txtMailadres.ReadOnly = true;
            txtSkype.ReadOnly = true;
            txtTel1.ReadOnly = true;
            txtTel2.ReadOnly = true;
            txtOpmerkingen.ReadOnly = true;
            navOK.Enabled = false;
            clsUsers cls = new clsUsers();
            NewGebruiker = cls.GetGebruikerByID(GebID);
            initAlles();
            navOK.Enabled = true;
            txtGebruikersnaam.Focus();
        }
        public AddEditUser(Taak taak)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            this.Text = "Gebruiker toevoegen";
            NewGebruiker = new Gebruiker();
            initAlles();
        }
        public AddEditUser(Gebruiker geruiker, Taak taak)
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            this.Text = "Gebruiker bewerken";
            NewGebruiker = geruiker;
            initAlles();
        }

        private void initAlles()
        {
            vulCombos();
            if (NewGebruiker == null) return;
            cmbSoortGebruiker.SelectedValue = NewGebruiker.RolID;
            //Rolls hier!!!!!!!!!!!!!!

            txtNaam.Text = NewGebruiker.Volledigenaam;
            txtWW.Text = NewGebruiker.Wachtwoord;
            chkAktief.Checked = NewGebruiker.Aktief;
            chkRapportAccess.Checked = NewGebruiker.Afdrukkenvlgsinleggen;
            txtGebruikersnaam.Text = NewGebruiker.Inlognaam;

            cmbGeslacht.SelectedIndex = cmbGeslacht.FindString(NewGebruiker.Geslacht);
            if (NewGebruiker.GeboorteDatum != null && Convert.ToDateTime(NewGebruiker.GeboorteDatum).Year > 1920) txtGebDat.DateTime = Convert.ToDateTime(NewGebruiker.GeboorteDatum);
            txtAdres.Text = NewGebruiker.Adres;
            txtPC.Text = NewGebruiker.Postcode;
            txtPlaats.Text = NewGebruiker.Plaats;
            txtMailadres.Text = NewGebruiker.Email;
            txtTel1.Text = NewGebruiker.TelNr;
            txtTel2.Text = NewGebruiker.TelNrMobiel;
            txtOpmerkingen.Text = NewGebruiker.ExtraInfo;
            txtGebruikersnaam.Select();
        }
        private void vulCombos()
        {
            cmbSoortGebruiker.DataSource = Algemeen.GetLookupAlleUserTypes();
            cmbSoortGebruiker.DisplayMember = "UserType";
            cmbSoortGebruiker.ValueMember = "ID";
            cmbSoortGebruiker.SelectedIndex = 0;

            cmbGeslacht.Items.Add("Man");
            cmbGeslacht.Items.Add("Vrouw");
            cmbGeslacht.Items.Add("Onbekend");
            cmbGeslacht.SelectedIndex = -1;

        }
        private bool haalData()
        {
            try
            {
                if (NewGebruiker == null) return false;
                NewGebruiker.RolID = Convert.ToInt32(cmbSoortGebruiker.SelectedValue);
                NewGebruiker.Volledigenaam = txtNaam.Text;
                NewGebruiker.Inlognaam = txtGebruikersnaam.Text;
                NewGebruiker.Wachtwoord = txtWW.Text;
                NewGebruiker.Geslacht = cmbGeslacht.Text;
                if (txtGebDat.Text != "" && txtGebDat.DateTime.Year > 1920) NewGebruiker.GeboorteDatum = txtGebDat.DateTime;
                NewGebruiker.Adres = txtAdres.Text;
                NewGebruiker.Postcode = txtPC.Text;
                NewGebruiker.Plaats = txtPlaats.Text;
                NewGebruiker.Email = txtMailadres.Text;
                //NewGebruiker.Skype = txtSkype.Text;
                NewGebruiker.TelNr = txtTel1.Text;
                NewGebruiker.TelNrMobiel = txtTel2.Text;
                NewGebruiker.Aktief = chkAktief.Checked;
                //NewGebruiker.ToegangTotRapportage = chkRapportAccess.Checked;
                if (txtEndContractDate.Text != "" && txtEndContractDate.DateTime.Year > 1920) NewGebruiker.Einddatum = txtEndContractDate.DateTime;
                NewGebruiker.ExtraInfo = txtOpmerkingen.Text;
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "Er is een fout opgetreden tijdens het ophalen van de gegevens." + ex.Message, "Fout", MessageBoxButtons.OK, DevExpress.Utils.DefaultBoolean.True);
                return false;
            }
        }
        private bool kontrole()
        {
            bool toReturn = true;
            if (txtNaam.Text == "")
            {
                toReturn = false;
                errorProvider1.SetError(txtNaam, "Naam mag niet leeg zijn!");
            }
            if (cmbSoortGebruiker.SelectedValue == null || Convert.ToInt32(cmbSoortGebruiker.SelectedValue) == 0)
            {
                toReturn = false;
                errorProvider1.SetError(cmbSoortGebruiker, "U moet soort gebruiker selecteren!");
            }
            if (txtMailadres.Text == "")
            {
                toReturn = false;
                errorProvider1.SetError(txtMailadres, "Mailadres mag niet leeg zijn!");
            }
            return toReturn;
        }
        private void txtWW_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void chkWW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWW.Checked)
            {
                lblWW.Visible = true;
                txtWW.Visible = true;
                //chkWW.Text = "Wachtwoord verbergen";
            }
            else
            {
                lblWW.Visible = false;
                txtWW.Visible = false;
                //chkWW.Text = "Wachtwoord zichtbaar maken";
            }
        }

        private void navOK_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (!kontrole()) return;
            if (!haalData()) return;
            this.DialogResult = DialogResult.OK;
        }

        private void navBack_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
