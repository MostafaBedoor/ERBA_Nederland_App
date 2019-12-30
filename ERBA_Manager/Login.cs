using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Threading;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer.EntitiesClasses;

namespace ERBA_Manager
{
    public partial class Login : XtraForm
    {
        private AppMain _MainForm;
        public Login()
        {
            //Thread t = new Thread(new ThreadStart(splash));
            //InitializeComponent();
            //DevExpress.Skins.SkinManager.EnableFormSkins();
            //t.Start();
            //Thread.Sleep(1700);
            //t.Abort();

            InitializeComponent();
            Splash _splash = new Splash();
            _splash.ShowDialog();

            if (!CheckNet())
            {
                setWarning("Let op: er is geen netwerk verbinding!");
            }
        }

        public void splash()
        {
            Application.Run(new Splash());
        }

        private void setWarning(string warning)
        {
            lblMelding.Font = new Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold);
            lblMelding.Text = warning;
        }

        private void setNormal(string warning)
        {
            lblMelding.Font = new Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Regular);
            lblMelding.Text = warning;
        }

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
        private void DoOK()
        {
            errorProvider1.Clear();
            if (!kontrole()) return;
            if (chkOnthoud.Checked)
            {
                Properties.Settings.Default.GebNaam = txtName.Text;
                Cryptor crypt = new Cryptor();
                Properties.Settings.Default.GebWW = crypt.EncryptData(txtWW.Text);
                //Properties.Settings.Default.GebWW = txtWW.Text;
                Properties.Settings.Default.OnthoudGegs = chkOnthoud.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.GebNaam = "";
                Properties.Settings.Default.GebWW = "";
                Properties.Settings.Default.GebWW = "";
                Properties.Settings.Default.OnthoudGegs = chkOnthoud.Checked;
                Properties.Settings.Default.Save();
            }
            clsUsers cls = new clsUsers();
            Program.HuidigeGebruiker = cls.GetGebruikerByInlogGegs(txtName.Text, txtWW.Text);
            if (Program.HuidigeGebruiker == null)
            {
                setWarning("Ongeldige logingegevens");
                return;
            }

            pnlInfo.BackColor = Color.FromArgb(18, 186, 132);
            lblMelding.Font = new Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold);
            lblMelding.Text = string.Format("{0} is ingelogd", Program.HuidigeGebruiker.Volledigenaam);
            //this.WindowState = FormWindowState.Minimized;

            if (_MainForm == null || _MainForm.IsDisposed)
            {
                _MainForm = new AppMain();
            }
            _MainForm.WindowState = FormWindowState.Maximized;
            _MainForm.ShowDialog();
            //this.Hide();
        }
        private void isDone(object sender, EventArgs e)
        {

        }

        private void closed(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool kontrole()
        {
            bool toReturn = true;

            if (!CheckNet())
            {
                setWarning("Let op: er is geen netwerk verbinding!");
                toReturn = false;
            }
            if (txtName.Text == "")
            {
                toReturn = false;
                errorProvider1.SetError(txtName, "Loginnaam mag niet leeg zijn!");
            }
            if (txtWW.Text == "")
            {
                toReturn = false;
                errorProvider1.SetError(txtWW, "Wachtwoord mag niet leeg zijn!");
            }
            return toReturn;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DoOK();
        }
        private void nudgeControls()
        {
            int margeLinks = (this.Width - (btnOK.Width + btnEnd.Width + 2)) / 2;
            btnOK.Location = new Point(margeLinks, btnOK.Location.Y);
            btnEnd.Location = new Point(margeLinks + btnOK.Width + 2, btnOK.Location.Y);
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoOK();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoOK();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (_MainForm != null)
            {
                if (XtraMessageBox.Show(this, "Weet u zeker dat u het programma wilt afsluiten?", "Programma afsluiten",
                    MessageBoxButtons.YesNo, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
                    Application.Exit();
            }
            else Application.Exit();
        }

        private void chkShowWW_CheckedChanged(object sender, EventArgs e)
        {
            txtWW.UseSystemPasswordChar = !chkShowWW.Checked;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblMelding.Text = "";
            nudgeControls();
            if (Properties.Settings.Default.GebNaam != "") txtName.Text = Properties.Settings.Default.GebNaam;
            Cryptor crypt = new Cryptor();
            if (Properties.Settings.Default.GebWW != "") txtWW.Text = crypt.DecryptData(Properties.Settings.Default.GebWW);
            if (Properties.Settings.Default.OnthoudGegs)
            {
                chkOnthoud.Checked = true;
            }
            txtName.Focus();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
