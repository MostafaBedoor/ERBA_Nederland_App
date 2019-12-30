namespace ERBA_Manager.Forms
{
    partial class frmNetStatus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNetstatusNaar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.cmbClavenNaam = new System.Windows.Forms.ComboBox();
            this.lblNaamNet = new System.Windows.Forms.Label();
            this.lblClaaf = new System.Windows.Forms.Label();
            this.cmbNet = new System.Windows.Forms.ComboBox();
            this.lblHandel = new System.Windows.Forms.Label();
            this.cmbNetStatus = new System.Windows.Forms.ComboBox();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NetnoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetstatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Naam_net = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netstatusdatum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netstatustijd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbNetstatusNaar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTemp);
            this.panel1.Controls.Add(this.cmbTemp);
            this.panel1.Controls.Add(this.cmbClavenNaam);
            this.panel1.Controls.Add(this.lblNaamNet);
            this.panel1.Controls.Add(this.lblClaaf);
            this.panel1.Controls.Add(this.cmbNet);
            this.panel1.Controls.Add(this.lblHandel);
            this.panel1.Controls.Add(this.cmbNetStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 204);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Status zeoken:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(665, 175);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 37;
            this.simpleButton1.Text = "Ok";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(435, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Status:";
            // 
            // cmbNetstatusNaar
            // 
            this.cmbNetstatusNaar.FormattingEnabled = true;
            this.cmbNetstatusNaar.Location = new System.Drawing.Point(111, 144);
            this.cmbNetstatusNaar.Name = "cmbNetstatusNaar";
            this.cmbNetstatusNaar.Size = new System.Drawing.Size(218, 21);
            this.cmbNetstatusNaar.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Status verandering:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(356, 175);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(73, 13);
            this.lblTemp.TabIndex = 32;
            this.lblTemp.Text = "Temperature:";
            // 
            // cmbTemp
            // 
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(435, 172);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(69, 21);
            this.cmbTemp.TabIndex = 31;
            // 
            // cmbClavenNaam
            // 
            this.cmbClavenNaam.FormattingEnabled = true;
            this.cmbClavenNaam.Location = new System.Drawing.Point(110, 172);
            this.cmbClavenNaam.Name = "cmbClavenNaam";
            this.cmbClavenNaam.Size = new System.Drawing.Size(218, 21);
            this.cmbClavenNaam.TabIndex = 29;
            // 
            // lblNaamNet
            // 
            this.lblNaamNet.AutoSize = true;
            this.lblNaamNet.Location = new System.Drawing.Point(47, 120);
            this.lblNaamNet.Name = "lblNaamNet";
            this.lblNaamNet.Size = new System.Drawing.Size(57, 13);
            this.lblNaamNet.TabIndex = 26;
            this.lblNaamNet.Text = "Naam net:";
            // 
            // lblClaaf
            // 
            this.lblClaaf.AutoSize = true;
            this.lblClaaf.Location = new System.Drawing.Point(38, 175);
            this.lblClaaf.Name = "lblClaaf";
            this.lblClaaf.Size = new System.Drawing.Size(66, 13);
            this.lblClaaf.TabIndex = 25;
            this.lblClaaf.Text = "Sub Locatie:";
            // 
            // cmbNet
            // 
            this.cmbNet.FormattingEnabled = true;
            this.cmbNet.Location = new System.Drawing.Point(110, 117);
            this.cmbNet.Name = "cmbNet";
            this.cmbNet.Size = new System.Drawing.Size(218, 21);
            this.cmbNet.TabIndex = 24;
            // 
            // lblHandel
            // 
            this.lblHandel.AutoSize = true;
            this.lblHandel.Location = new System.Drawing.Point(47, 50);
            this.lblHandel.Name = "lblHandel";
            this.lblHandel.Size = new System.Drawing.Size(58, 13);
            this.lblHandel.TabIndex = 23;
            this.lblHandel.Text = "Handeling:";
            // 
            // cmbNetStatus
            // 
            this.cmbNetStatus.FormattingEnabled = true;
            this.cmbNetStatus.Location = new System.Drawing.Point(111, 47);
            this.cmbNetStatus.Name = "cmbNetStatus";
            this.cmbNetStatus.Size = new System.Drawing.Size(218, 21);
            this.cmbNetStatus.TabIndex = 22;
            this.cmbNetStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbNetStatus_SelectionChangeCommitted);
            // 
            // gc
            // 
            this.gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc.Location = new System.Drawing.Point(0, 204);
            this.gc.MainView = this.gridView1;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(800, 359);
            this.gc.TabIndex = 24;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NetnoID,
            this.NetstatusID,
            this.Netstatus,
            this.NetID,
            this.Naam_net,
            this.Netstatusdatum,
            this.Netstatustijd});
            this.gridView1.GridControl = this.gc;
            this.gridView1.Name = "gridView1";
            // 
            // NetnoID
            // 
            this.NetnoID.Caption = "NetnoID";
            this.NetnoID.FieldName = "NetnoID";
            this.NetnoID.Name = "NetnoID";
            // 
            // NetstatusID
            // 
            this.NetstatusID.Caption = "NetstatusID";
            this.NetstatusID.FieldName = "NetstatusID";
            this.NetstatusID.Name = "NetstatusID";
            // 
            // Netstatus
            // 
            this.Netstatus.Caption = "Netstatus";
            this.Netstatus.FieldName = "Netstatus";
            this.Netstatus.Name = "Netstatus";
            // 
            // NetID
            // 
            this.NetID.Caption = "Net ID";
            this.NetID.FieldName = "NetID";
            this.NetID.Name = "NetID";
            this.NetID.OptionsColumn.AllowEdit = false;
            this.NetID.Visible = true;
            this.NetID.VisibleIndex = 0;
            // 
            // Naam_net
            // 
            this.Naam_net.Caption = "Naam net";
            this.Naam_net.FieldName = "Naam_net";
            this.Naam_net.Name = "Naam_net";
            this.Naam_net.OptionsColumn.AllowEdit = false;
            this.Naam_net.Visible = true;
            this.Naam_net.VisibleIndex = 1;
            // 
            // Netstatusdatum
            // 
            this.Netstatusdatum.Caption = "Netstatus datum";
            this.Netstatusdatum.FieldName = "Netstatusdatum";
            this.Netstatusdatum.Name = "Netstatusdatum";
            this.Netstatusdatum.OptionsColumn.AllowEdit = false;
            this.Netstatusdatum.Visible = true;
            this.Netstatusdatum.VisibleIndex = 2;
            // 
            // Netstatustijd
            // 
            this.Netstatustijd.Caption = "Netstatus tijd";
            this.Netstatustijd.FieldName = "Netstatustijd";
            this.Netstatustijd.Name = "Netstatustijd";
            this.Netstatustijd.OptionsColumn.AllowEdit = false;
            this.Netstatustijd.Visible = true;
            this.Netstatustijd.VisibleIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Datum tijid:";
            // 
            // frmNetStatus
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.gc);
            this.Controls.Add(this.panel1);
            this.Name = "frmNetStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetStatus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.ComboBox cmbTemp;
        private System.Windows.Forms.ComboBox cmbClavenNaam;
        private System.Windows.Forms.Label lblNaamNet;
        private System.Windows.Forms.Label lblClaaf;
        private System.Windows.Forms.ComboBox cmbNet;
        private System.Windows.Forms.Label lblHandel;
        private System.Windows.Forms.ComboBox cmbNetStatus;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NetnoID;
        private DevExpress.XtraGrid.Columns.GridColumn NetstatusID;
        private DevExpress.XtraGrid.Columns.GridColumn Netstatus;
        private DevExpress.XtraGrid.Columns.GridColumn NetID;
        private DevExpress.XtraGrid.Columns.GridColumn Naam_net;
        private DevExpress.XtraGrid.Columns.GridColumn Netstatusdatum;
        private DevExpress.XtraGrid.Columns.GridColumn Netstatustijd;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNetstatusNaar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}