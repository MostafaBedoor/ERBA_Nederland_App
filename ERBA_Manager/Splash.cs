using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace ERBA_Manager
{
    public partial class Splash : DevExpress.XtraEditors.XtraForm
    {
        private System.Windows.Forms.Timer _closeTimer;

        public Splash()
        {
            InitializeComponent();
            lblVersie.Text = "Versienummer: " + ERBA_Manager.Properties.Settings.Default.VersieNummer;
            lblVersieDatum.Text = ERBA_Manager.Properties.Settings.Default.VersieDatum;

            this._closeTimer = new System.Windows.Forms.Timer();
            this._closeTimer.Interval = 5000;
            this._closeTimer.Tick += new EventHandler(this._closeTimer_Tick);
            this._closeTimer.Start();
        }

        #region Overrides

        //public override void ProcessCommand(Enum cmd, object arg)
        //{
        //    base.ProcessCommand(cmd, arg);
        //}

        #endregion

        private void _closeTimer_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;
            timer.Stop();
            this.Close();
        }
    }
}