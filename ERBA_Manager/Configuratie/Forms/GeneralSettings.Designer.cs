namespace ERBA_Manager.Configuratie.Forms
{
    partial class GeneralSettings
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
            this.tabSettings = new DevExpress.XtraTab.XtraTabControl();
            this.tab_1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navOK = new DevExpress.XtraBars.Navigation.NavButton();
            this.itmEinde = new DevExpress.XtraBars.Navigation.NavButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPoort = new System.Windows.Forms.TextBox();
            this.chkPWVisible = new DevExpress.XtraEditors.CheckEdit();
            this.chkEnableSSL = new DevExpress.XtraEditors.CheckEdit();
            this.txtSMTP_Server = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtServerUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNaamLocatieNetten_2 = new System.Windows.Forms.TextBox();
            this.txtNaamLocatieNetten_1 = new System.Windows.Forms.TextBox();
            this.cmbInleggenstatus = new System.Windows.Forms.ComboBox();
            this.txtExpdatmetdustcov = new System.Windows.Forms.NumericUpDown();
            this.txtExpdatnaster = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBarcodelezerAangesloten = new DevExpress.XtraEditors.CheckEdit();
            this.chkNetregzondcsa = new DevExpress.XtraEditors.CheckEdit();
            this.chkGewichtnetinschakelen = new DevExpress.XtraEditors.CheckEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSMTP_Afzender = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReparatieMailadres = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtZichtOrderMailadres = new System.Windows.Forms.TextBox();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabSettings)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tab_1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPWVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableSSL.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpdatmetdustcov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpdatnaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBarcodelezerAangesloten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNetregzondcsa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGewichtnetinschakelen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.AppearancePage.Header.Options.UseFont = true;
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(0, 45);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedTabPage = this.tab_1;
            this.tabSettings.Size = new System.Drawing.Size(800, 368);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab_1,
            this.xtraTabPage2});
            // 
            // tab_1
            // 
            this.tab_1.Controls.Add(this.groupBox1);
            this.tab_1.Name = "tab_1";
            this.tab_1.Size = new System.Drawing.Size(794, 337);
            this.tab_1.Text = "Algemeen";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupBox2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(794, 337);
            this.xtraTabPage2.Text = "Email";
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tileNavPane1.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNavPane1.Appearance.Options.UseBackColor = true;
            this.tileNavPane1.Appearance.Options.UseFont = true;
            this.tileNavPane1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileNavPane1.AppearanceHovered.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNavPane1.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavPane1.AppearanceHovered.Options.UseFont = true;
            this.tileNavPane1.AppearanceSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileNavPane1.AppearanceSelected.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNavPane1.AppearanceSelected.Options.UseBackColor = true;
            this.tileNavPane1.AppearanceSelected.Options.UseFont = true;
            this.tileNavPane1.Buttons.Add(this.navOK);
            this.tileNavPane1.Buttons.Add(this.itmEinde);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(800, 45);
            this.tileNavPane1.TabIndex = 44;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navOK
            // 
            this.navOK.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navOK.Caption = "Opslaan";
            this.navOK.ImageOptions.Image = global::ERBA_Manager.Properties.Resources.saveall_32x32;
            this.navOK.Name = "navOK";
            // 
            // itmEinde
            // 
            this.itmEinde.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.itmEinde.Caption = "Annuleren";
            this.itmEinde.ImageOptions.Image = global::ERBA_Manager.Properties.Resources.backward_32x32;
            this.itmEinde.Name = "itmEinde";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPoort);
            this.groupBox2.Controls.Add(this.checkEdit1);
            this.groupBox2.Controls.Add(this.chkPWVisible);
            this.groupBox2.Controls.Add(this.chkEnableSSL);
            this.groupBox2.Controls.Add(this.txtSMTP_Server);
            this.groupBox2.Controls.Add(this.txtZichtOrderMailadres);
            this.groupBox2.Controls.Add(this.txtReparatieMailadres);
            this.groupBox2.Controls.Add(this.txtSMTP_Afzender);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPW);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtServerUserID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 278);
            this.groupBox2.TabIndex = 354;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail server";
            // 
            // txtPoort
            // 
            this.txtPoort.Location = new System.Drawing.Point(489, 31);
            this.txtPoort.Name = "txtPoort";
            this.txtPoort.Size = new System.Drawing.Size(72, 20);
            this.txtPoort.TabIndex = 8;
            // 
            // chkPWVisible
            // 
            this.chkPWVisible.Location = new System.Drawing.Point(97, 122);
            this.chkPWVisible.Name = "chkPWVisible";
            this.chkPWVisible.Properties.Caption = "Wachtwoord zichtbaar maken";
            this.chkPWVisible.Size = new System.Drawing.Size(306, 19);
            this.chkPWVisible.TabIndex = 7;
            this.chkPWVisible.CheckedChanged += new System.EventHandler(this.chkPWVisible_CheckedChanged);
            // 
            // chkEnableSSL
            // 
            this.chkEnableSSL.Location = new System.Drawing.Point(97, 54);
            this.chkEnableSSL.Name = "chkEnableSSL";
            this.chkEnableSSL.Properties.Caption = "Gebruik SSL";
            this.chkEnableSSL.Size = new System.Drawing.Size(209, 19);
            this.chkEnableSSL.TabIndex = 7;
            // 
            // txtSMTP_Server
            // 
            this.txtSMTP_Server.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTP_Server.Location = new System.Drawing.Point(97, 31);
            this.txtSMTP_Server.Name = "txtSMTP_Server";
            this.txtSMTP_Server.Size = new System.Drawing.Size(337, 21);
            this.txtSMTP_Server.TabIndex = 6;
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(97, 98);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(163, 21);
            this.txtPW.TabIndex = 7;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // txtServerUserID
            // 
            this.txtServerUserID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerUserID.Location = new System.Drawing.Point(97, 74);
            this.txtServerUserID.Name = "txtServerUserID";
            this.txtServerUserID.Size = new System.Drawing.Size(163, 21);
            this.txtServerUserID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mail server:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Wachwoord:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loginnaam:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(448, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Poort:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNaamLocatieNetten_2);
            this.groupBox1.Controls.Add(this.txtNaamLocatieNetten_1);
            this.groupBox1.Controls.Add(this.cmbInleggenstatus);
            this.groupBox1.Controls.Add(this.txtExpdatmetdustcov);
            this.groupBox1.Controls.Add(this.txtExpdatnaster);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkBarcodelezerAangesloten);
            this.groupBox1.Controls.Add(this.chkNetregzondcsa);
            this.groupBox1.Controls.Add(this.chkGewichtnetinschakelen);
            this.groupBox1.Location = new System.Drawing.Point(11, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 325);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtNaamLocatieNetten_2
            // 
            this.txtNaamLocatieNetten_2.Location = new System.Drawing.Point(166, 197);
            this.txtNaamLocatieNetten_2.Name = "txtNaamLocatieNetten_2";
            this.txtNaamLocatieNetten_2.Size = new System.Drawing.Size(308, 21);
            this.txtNaamLocatieNetten_2.TabIndex = 17;
            // 
            // txtNaamLocatieNetten_1
            // 
            this.txtNaamLocatieNetten_1.Location = new System.Drawing.Point(166, 170);
            this.txtNaamLocatieNetten_1.Name = "txtNaamLocatieNetten_1";
            this.txtNaamLocatieNetten_1.Size = new System.Drawing.Size(308, 21);
            this.txtNaamLocatieNetten_1.TabIndex = 18;
            // 
            // cmbInleggenstatus
            // 
            this.cmbInleggenstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInleggenstatus.FormattingEnabled = true;
            this.cmbInleggenstatus.Location = new System.Drawing.Point(231, 138);
            this.cmbInleggenstatus.Name = "cmbInleggenstatus";
            this.cmbInleggenstatus.Size = new System.Drawing.Size(243, 21);
            this.cmbInleggenstatus.TabIndex = 16;
            // 
            // txtExpdatmetdustcov
            // 
            this.txtExpdatmetdustcov.Location = new System.Drawing.Point(240, 224);
            this.txtExpdatmetdustcov.Name = "txtExpdatmetdustcov";
            this.txtExpdatmetdustcov.Size = new System.Drawing.Size(81, 21);
            this.txtExpdatmetdustcov.TabIndex = 14;
            // 
            // txtExpdatnaster
            // 
            this.txtExpdatnaster.Location = new System.Drawing.Point(122, 108);
            this.txtExpdatnaster.Name = "txtExpdatnaster";
            this.txtExpdatnaster.Size = new System.Drawing.Size(54, 21);
            this.txtExpdatnaster.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Naam locatie van netten 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "maanden na inleggen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Naam locatie van netten 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Expiratiedatum met dustcover (maanden):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Netstatus gekoppeld aan inleggen CSA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Netten expireren";
            // 
            // chkBarcodelezerAangesloten
            // 
            this.chkBarcodelezerAangesloten.Location = new System.Drawing.Point(30, 78);
            this.chkBarcodelezerAangesloten.Name = "chkBarcodelezerAangesloten";
            this.chkBarcodelezerAangesloten.Properties.Caption = "Barcodelezer aangesloten";
            this.chkBarcodelezerAangesloten.Size = new System.Drawing.Size(351, 19);
            this.chkBarcodelezerAangesloten.TabIndex = 5;
            // 
            // chkNetregzondcsa
            // 
            this.chkNetregzondcsa.Location = new System.Drawing.Point(30, 52);
            this.chkNetregzondcsa.Name = "chkNetregzondcsa";
            this.chkNetregzondcsa.Properties.Caption = "Verrichtingen registreren zonder inleggen CSA";
            this.chkNetregzondcsa.Size = new System.Drawing.Size(351, 19);
            this.chkNetregzondcsa.TabIndex = 6;
            // 
            // chkGewichtnetinschakelen
            // 
            this.chkGewichtnetinschakelen.Location = new System.Drawing.Point(30, 27);
            this.chkGewichtnetinschakelen.Name = "chkGewichtnetinschakelen";
            this.chkGewichtnetinschakelen.Properties.Caption = "Netten worden gewogen ipv instrumenten tellen ";
            this.chkGewichtnetinschakelen.Size = new System.Drawing.Size(351, 19);
            this.chkGewichtnetinschakelen.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email adres afzender:";
            // 
            // txtSMTP_Afzender
            // 
            this.txtSMTP_Afzender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTP_Afzender.Location = new System.Drawing.Point(170, 147);
            this.txtSMTP_Afzender.Name = "txtSMTP_Afzender";
            this.txtSMTP_Afzender.Size = new System.Drawing.Size(391, 21);
            this.txtSMTP_Afzender.TabIndex = 7;
            this.txtSMTP_Afzender.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mailadres voor reparaties:";
            // 
            // txtReparatieMailadres
            // 
            this.txtReparatieMailadres.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReparatieMailadres.Location = new System.Drawing.Point(170, 174);
            this.txtReparatieMailadres.Name = "txtReparatieMailadres";
            this.txtReparatieMailadres.Size = new System.Drawing.Size(391, 21);
            this.txtReparatieMailadres.TabIndex = 7;
            this.txtReparatieMailadres.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mailadres voor zichtorders:";
            // 
            // txtZichtOrderMailadres
            // 
            this.txtZichtOrderMailadres.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZichtOrderMailadres.Location = new System.Drawing.Point(170, 201);
            this.txtZichtOrderMailadres.Name = "txtZichtOrderMailadres";
            this.txtZichtOrderMailadres.Size = new System.Drawing.Size(391, 21);
            this.txtZichtOrderMailadres.TabIndex = 7;
            this.txtZichtOrderMailadres.UseSystemPasswordChar = true;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(170, 229);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Logging voor mail aanzetten";
            this.checkEdit1.Size = new System.Drawing.Size(306, 19);
            this.checkEdit1.TabIndex = 7;
            // 
            // GeneralSettings
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "GeneralSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralSettings";
            ((System.ComponentModel.ISupportInitialize)(this.tabSettings)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tab_1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPWVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableSSL.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpdatmetdustcov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpdatnaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBarcodelezerAangesloten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNetregzondcsa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGewichtnetinschakelen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabSettings;
        private DevExpress.XtraTab.XtraTabPage tab_1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navOK;
        private DevExpress.XtraBars.Navigation.NavButton itmEinde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNaamLocatieNetten_2;
        private System.Windows.Forms.TextBox txtNaamLocatieNetten_1;
        private System.Windows.Forms.ComboBox cmbInleggenstatus;
        private System.Windows.Forms.NumericUpDown txtExpdatmetdustcov;
        private System.Windows.Forms.NumericUpDown txtExpdatnaster;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit chkBarcodelezerAangesloten;
        private DevExpress.XtraEditors.CheckEdit chkNetregzondcsa;
        private DevExpress.XtraEditors.CheckEdit chkGewichtnetinschakelen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPoort;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit chkPWVisible;
        private DevExpress.XtraEditors.CheckEdit chkEnableSSL;
        private System.Windows.Forms.TextBox txtSMTP_Server;
        private System.Windows.Forms.TextBox txtZichtOrderMailadres;
        private System.Windows.Forms.TextBox txtReparatieMailadres;
        private System.Windows.Forms.TextBox txtSMTP_Afzender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtServerUserID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}