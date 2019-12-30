namespace ERBA_Manager.Configuratie.Forms
{
    partial class AddEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkWW = new DevExpress.XtraEditors.CheckEdit();
            this.chkRapportAccess = new DevExpress.XtraEditors.CheckEdit();
            this.chkAktief = new DevExpress.XtraEditors.CheckEdit();
            this.txtGebDat = new DevExpress.XtraEditors.DateEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGeslacht = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaam = new DevExpress.XtraEditors.TextEdit();
            this.txtSkype = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMailadres = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel2 = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel1 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOpmerkingen = new System.Windows.Forms.TextBox();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPlaats = new DevExpress.XtraEditors.TextEdit();
            this.txtPC = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWW = new DevExpress.XtraEditors.TextEdit();
            this.txtGebruikersnaam = new DevExpress.XtraEditors.TextEdit();
            this.lblWW = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtEndContractDate = new DevExpress.XtraEditors.DateEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbSoortGebruiker = new System.Windows.Forms.ComboBox();
            this.txtBeschikbaarheid = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tlSettings = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navOK = new DevExpress.XtraBars.Navigation.NavButton();
            this.navBack = new DevExpress.XtraBars.Navigation.NavButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkWW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRapportAccess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAktief.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGebDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGebDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSkype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailadres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaats.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGebruikersnaam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndContractDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndContractDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeschikbaarheid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // chkWW
            // 
            this.chkWW.Location = new System.Drawing.Point(94, 41);
            this.chkWW.Name = "chkWW";
            this.chkWW.Properties.Caption = "Wachtwoord zichtbaar maken";
            this.chkWW.Size = new System.Drawing.Size(344, 19);
            this.chkWW.TabIndex = 310;
            this.chkWW.CheckedChanged += new System.EventHandler(this.chkWW_CheckedChanged);
            // 
            // chkRapportAccess
            // 
            this.chkRapportAccess.Location = new System.Drawing.Point(97, 165);
            this.chkRapportAccess.Name = "chkRapportAccess";
            this.chkRapportAccess.Properties.Caption = "Toegang tot rapportage";
            this.chkRapportAccess.Size = new System.Drawing.Size(167, 19);
            this.chkRapportAccess.TabIndex = 310;
            // 
            // chkAktief
            // 
            this.chkAktief.EditValue = true;
            this.chkAktief.Location = new System.Drawing.Point(97, 146);
            this.chkAktief.Name = "chkAktief";
            this.chkAktief.Properties.Caption = "Actieve gebruiker";
            this.chkAktief.Size = new System.Drawing.Size(128, 19);
            this.chkAktief.TabIndex = 310;
            // 
            // txtGebDat
            // 
            this.txtGebDat.EditValue = null;
            this.txtGebDat.Location = new System.Drawing.Point(97, 48);
            this.txtGebDat.Name = "txtGebDat";
            this.txtGebDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGebDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGebDat.Size = new System.Drawing.Size(120, 20);
            this.txtGebDat.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label10.Location = new System.Drawing.Point(20, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 308;
            this.label10.Text = "Geb.dat.:";
            // 
            // cmbGeslacht
            // 
            this.cmbGeslacht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeslacht.FormattingEnabled = true;
            this.cmbGeslacht.Location = new System.Drawing.Point(299, 48);
            this.cmbGeslacht.Name = "cmbGeslacht";
            this.cmbGeslacht.Size = new System.Drawing.Size(138, 21);
            this.cmbGeslacht.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 309;
            this.label1.Text = "Naam:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(97, 23);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(339, 20);
            this.txtNaam.TabIndex = 4;
            // 
            // txtSkype
            // 
            this.txtSkype.Location = new System.Drawing.Point(97, 97);
            this.txtSkype.Name = "txtSkype";
            this.txtSkype.Size = new System.Drawing.Size(339, 20);
            this.txtSkype.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label15.Location = new System.Drawing.Point(20, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 309;
            this.label15.Text = "Skype:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label9.Location = new System.Drawing.Point(233, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 308;
            this.label9.Text = "Geslacht:";
            // 
            // txtMailadres
            // 
            this.txtMailadres.Location = new System.Drawing.Point(97, 73);
            this.txtMailadres.Name = "txtMailadres";
            this.txtMailadres.Size = new System.Drawing.Size(339, 20);
            this.txtMailadres.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(20, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 309;
            this.label5.Text = "Tel. 1:";
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(271, 121);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(165, 20);
            this.txtTel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 309;
            this.label4.Text = "Mailadres:";
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(97, 121);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(108, 20);
            this.txtTel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(226, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 309;
            this.label6.Text = "Tel. 2:";
            // 
            // txtOpmerkingen
            // 
            this.txtOpmerkingen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpmerkingen.Location = new System.Drawing.Point(97, 78);
            this.txtOpmerkingen.Multiline = true;
            this.txtOpmerkingen.Name = "txtOpmerkingen";
            this.txtOpmerkingen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpmerkingen.Size = new System.Drawing.Size(790, 62);
            this.txtOpmerkingen.TabIndex = 332;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(98, 30);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(284, 20);
            this.txtAdres.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label11.Location = new System.Drawing.Point(19, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 309;
            this.label11.Text = "Adres:";
            // 
            // txtPlaats
            // 
            this.txtPlaats.Location = new System.Drawing.Point(253, 54);
            this.txtPlaats.Name = "txtPlaats";
            this.txtPlaats.Size = new System.Drawing.Size(129, 20);
            this.txtPlaats.TabIndex = 16;
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(98, 54);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(86, 20);
            this.txtPC.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label13.Location = new System.Drawing.Point(19, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 309;
            this.label13.Text = "Postcode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label7.Location = new System.Drawing.Point(17, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 304;
            this.label7.Text = "Opmerkingen:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label14.Location = new System.Drawing.Point(198, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 309;
            this.label14.Text = "Plaats:";
            // 
            // txtWW
            // 
            this.txtWW.Location = new System.Drawing.Point(299, 15);
            this.txtWW.Name = "txtWW";
            this.txtWW.Size = new System.Drawing.Size(139, 20);
            this.txtWW.TabIndex = 2;
            this.txtWW.Visible = false;
            this.txtWW.EditValueChanged += new System.EventHandler(this.txtWW_EditValueChanged);
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(94, 15);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(121, 20);
            this.txtGebruikersnaam.TabIndex = 1;
            // 
            // lblWW
            // 
            this.lblWW.AutoSize = true;
            this.lblWW.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblWW.Location = new System.Drawing.Point(225, 17);
            this.lblWW.Name = "lblWW";
            this.lblWW.Size = new System.Drawing.Size(72, 13);
            this.lblWW.TabIndex = 309;
            this.lblWW.Text = "Wachtwoord:";
            this.lblWW.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label.Location = new System.Drawing.Point(6, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 13);
            this.label.TabIndex = 309;
            this.label.Text = "Gebruikersnaam:";
            // 
            // txtEndContractDate
            // 
            this.txtEndContractDate.EditValue = null;
            this.txtEndContractDate.Location = new System.Drawing.Point(128, 74);
            this.txtEndContractDate.Name = "txtEndContractDate";
            this.txtEndContractDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndContractDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndContractDate.Size = new System.Drawing.Size(120, 20);
            this.txtEndContractDate.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label20.Location = new System.Drawing.Point(12, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 13);
            this.label20.TabIndex = 308;
            this.label20.Text = "Einde contracttermijn:";
            // 
            // cmbSoortGebruiker
            // 
            this.cmbSoortGebruiker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoortGebruiker.FormattingEnabled = true;
            this.cmbSoortGebruiker.Location = new System.Drawing.Point(128, 23);
            this.cmbSoortGebruiker.Name = "cmbSoortGebruiker";
            this.cmbSoortGebruiker.Size = new System.Drawing.Size(248, 21);
            this.cmbSoortGebruiker.TabIndex = 19;
            // 
            // txtBeschikbaarheid
            // 
            this.txtBeschikbaarheid.Location = new System.Drawing.Point(128, 51);
            this.txtBeschikbaarheid.Name = "txtBeschikbaarheid";
            this.txtBeschikbaarheid.Size = new System.Drawing.Size(139, 20);
            this.txtBeschikbaarheid.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label8.Location = new System.Drawing.Point(11, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 308;
            this.label8.Text = "Soort gebruiker:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label19.Location = new System.Drawing.Point(12, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 13);
            this.label19.TabIndex = 309;
            this.label19.Text = "Beschikbaarheid:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWW);
            this.groupBox1.Controls.Add(this.lblWW);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txtGebruikersnaam);
            this.groupBox1.Controls.Add(this.txtWW);
            this.groupBox1.Location = new System.Drawing.Point(470, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 67);
            this.groupBox1.TabIndex = 307;
            this.groupBox1.TabStop = false;
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.txtEndContractDate);
            this.grpMain.Controls.Add(this.cmbSoortGebruiker);
            this.grpMain.Controls.Add(this.label20);
            this.grpMain.Controls.Add(this.label19);
            this.grpMain.Controls.Add(this.label8);
            this.grpMain.Controls.Add(this.txtBeschikbaarheid);
            this.grpMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpMain.Location = new System.Drawing.Point(470, 127);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(458, 112);
            this.grpMain.TabIndex = 307;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Taken:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOpmerkingen);
            this.groupBox4.Controls.Add(this.txtAdres);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtPlaats);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtPC);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(916, 154);
            this.groupBox4.TabIndex = 307;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adresgegevens:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkRapportAccess);
            this.groupBox5.Controls.Add(this.chkAktief);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtGebDat);
            this.groupBox5.Controls.Add(this.txtTel1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtTel2);
            this.groupBox5.Controls.Add(this.cmbGeslacht);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtMailadres);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtNaam);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtSkype);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(12, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(452, 189);
            this.groupBox5.TabIndex = 307;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Persoonlijke gegevens:";
            // 
            // tlSettings
            // 
            this.tlSettings.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlSettings.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlSettings.Appearance.Options.UseBackColor = true;
            this.tlSettings.Appearance.Options.UseFont = true;
            this.tlSettings.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tlSettings.AppearanceHovered.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlSettings.AppearanceHovered.Options.UseBackColor = true;
            this.tlSettings.AppearanceHovered.Options.UseFont = true;
            this.tlSettings.AppearanceSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tlSettings.AppearanceSelected.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlSettings.AppearanceSelected.Options.UseBackColor = true;
            this.tlSettings.AppearanceSelected.Options.UseFont = true;
            this.tlSettings.Buttons.Add(this.navOK);
            this.tlSettings.Buttons.Add(this.navBack);
            // 
            // tileNavCategory1
            // 
            this.tlSettings.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tlSettings.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlSettings.Location = new System.Drawing.Point(0, 0);
            this.tlSettings.Name = "tlSettings";
            this.tlSettings.Size = new System.Drawing.Size(937, 44);
            this.tlSettings.TabIndex = 308;
            // 
            // navOK
            // 
            this.navOK.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navOK.Caption = "Opslaan";
            this.navOK.Name = "navOK";
            this.navOK.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navOK_ElementClick);
            // 
            // navBack
            // 
            this.navBack.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navBack.Caption = "Terug";
            this.navBack.Name = "navBack";
            this.navBack.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navBack_ElementClick);
            // 
            // AddEditGebruiker
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 409);
            this.Controls.Add(this.tlSettings);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditGebruiker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditGebruiker";
            ((System.ComponentModel.ISupportInitialize)(this.chkWW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRapportAccess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAktief.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGebDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGebDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSkype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailadres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaats.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGebruikersnaam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndContractDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndContractDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeschikbaarheid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit txtGebDat;
        private System.Windows.Forms.ComboBox cmbSoortGebruiker;
        private System.Windows.Forms.ComboBox cmbGeslacht;
        private DevExpress.XtraEditors.TextEdit txtWW;
        private DevExpress.XtraEditors.TextEdit txtGebruikersnaam;
        private DevExpress.XtraEditors.TextEdit txtMailadres;
        private DevExpress.XtraEditors.TextEdit txtTel1;
        private System.Windows.Forms.Label lblWW;
        private DevExpress.XtraEditors.TextEdit txtNaam;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtPlaats;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit txtPC;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txtSkype;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit txtTel2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit txtEndContractDate;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraEditors.TextEdit txtBeschikbaarheid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtOpmerkingen;
        private DevExpress.XtraEditors.CheckEdit chkAktief;
        private DevExpress.XtraEditors.CheckEdit chkRapportAccess;
        private DevExpress.XtraEditors.CheckEdit chkWW;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.Navigation.TileNavPane tlSettings;
        private DevExpress.XtraBars.Navigation.NavButton navOK;
        private DevExpress.XtraBars.Navigation.NavButton navBack;
    }
}