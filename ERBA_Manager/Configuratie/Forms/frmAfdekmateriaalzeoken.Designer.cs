
namespace ERBA_Manager.Configuratie.Forms
{
    partial class frmAfdekmateriaalzeoken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAfdekmateriaalzeoken));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame3 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame4 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navAdd = new DevExpress.XtraBars.Navigation.NavButton();
            this.navEdit = new DevExpress.XtraBars.Navigation.NavButton();
            this.navDelete = new DevExpress.XtraBars.Navigation.NavButton();
            this.itmEinde = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.itmVerslAktielijsIntern = new DevExpress.XtraEditors.TileItem();
            this.itmVerslAktielijsExtern = new DevExpress.XtraEditors.TileItem();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.gcSuppliers = new DevExpress.XtraGrid.GridControl();
            this.gcCP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAfdekID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOmschrijving = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocatie = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCP)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            resources.ApplyResources(this.tileNavPane1, "tileNavPane1");
            this.tileNavPane1.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tileNavPane1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("tileNavPane1.Appearance.Font")));
            this.tileNavPane1.Appearance.Options.UseBackColor = true;
            this.tileNavPane1.Appearance.Options.UseFont = true;
            this.tileNavPane1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileNavPane1.AppearanceHovered.Font = ((System.Drawing.Font)(resources.GetObject("tileNavPane1.AppearanceHovered.Font")));
            this.tileNavPane1.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavPane1.AppearanceHovered.Options.UseFont = true;
            this.tileNavPane1.AppearanceSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileNavPane1.AppearanceSelected.Font = ((System.Drawing.Font)(resources.GetObject("tileNavPane1.AppearanceSelected.Font")));
            this.tileNavPane1.AppearanceSelected.Options.UseBackColor = true;
            this.tileNavPane1.AppearanceSelected.Options.UseFont = true;
            this.tileNavPane1.Buttons.Add(this.navAdd);
            this.tileNavPane1.Buttons.Add(this.navEdit);
            this.tileNavPane1.Buttons.Add(this.navDelete);
            this.tileNavPane1.Buttons.Add(this.itmEinde);
            // 
            // tileNavCategory1
            // 
            resources.ApplyResources(this.tileNavPane1.DefaultCategory, "tileNavCategory1");
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Name = "tileNavPane1";
            // 
            // navAdd
            // 
            this.navAdd.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            resources.ApplyResources(this.navAdd, "navAdd");
            this.navAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navAdd.ImageOptions.Image")));
            this.navAdd.Name = "navAdd";
            this.navAdd.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navAdd_ElementClick);
            // 
            // navEdit
            // 
            this.navEdit.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            resources.ApplyResources(this.navEdit, "navEdit");
            this.navEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navEdit.ImageOptions.Image")));
            this.navEdit.Name = "navEdit";
            this.navEdit.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navEdit_ElementClick);
            // 
            // navDelete
            // 
            this.navDelete.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            resources.ApplyResources(this.navDelete, "navDelete");
            this.navDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navDelete.ImageOptions.Image")));
            this.navDelete.Name = "navDelete";
            this.navDelete.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navDelete_ElementClick);
            // 
            // itmEinde
            // 
            this.itmEinde.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            resources.ApplyResources(this.itmEinde, "itmEinde");
            this.itmEinde.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itmEinde.ImageOptions.Image")));
            this.itmEinde.Name = "itmEinde";
            this.itmEinde.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.itmEinde_ElementClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.tileItem4);
            this.tileGroup4.Items.Add(this.itmVerslAktielijsIntern);
            this.tileGroup4.Items.Add(this.itmVerslAktielijsExtern);
            this.tileGroup4.Name = "tileGroup4";
            resources.ApplyResources(this.tileGroup4, "tileGroup4");
            // 
            // tileItem4
            // 
            this.tileItem4.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Magenta;
            this.tileItem4.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tileItem4.AppearanceItem.Normal.Font = ((System.Drawing.Font)(resources.GetObject("tileItem4.AppearanceItem.Normal.Font")));
            this.tileItem4.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem4.AppearanceItem.Normal.Options.UseFont = true;
            resources.ApplyResources(tileItemElement1, "tileItemElement1");
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.tileItem4.Elements.Add(tileItemElement1);
            this.tileItem4.Id = 5;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.Padding = new System.Windows.Forms.Padding(0, -1, 20, -1);
            this.tileItem4.Visible = false;
            // 
            // itmVerslAktielijsIntern
            // 
            this.itmVerslAktielijsIntern.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itmVerslAktielijsIntern.AppearanceItem.Normal.Font = ((System.Drawing.Font)(resources.GetObject("itmVerslAktielijsIntern.AppearanceItem.Normal.Font")));
            this.itmVerslAktielijsIntern.AppearanceItem.Normal.Options.UseBackColor = true;
            this.itmVerslAktielijsIntern.AppearanceItem.Normal.Options.UseFont = true;
            resources.ApplyResources(tileItemElement2, "tileItemElement2");
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.itmVerslAktielijsIntern.Elements.Add(tileItemElement2);
            this.itmVerslAktielijsIntern.Enabled = false;
            tileItemFrame1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            tileItemFrame1.Appearance.Options.UseFont = true;
            resources.ApplyResources(tileItemElement3, "tileItemElement3");
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemFrame1.Elements.Add(tileItemElement3);
            this.itmVerslAktielijsIntern.Frames.Add(tileItemFrame1);
            this.itmVerslAktielijsIntern.Id = 9;
            this.itmVerslAktielijsIntern.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.itmVerslAktielijsIntern.Name = "itmVerslAktielijsIntern";
            // 
            // itmVerslAktielijsExtern
            // 
            this.itmVerslAktielijsExtern.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itmVerslAktielijsExtern.AppearanceItem.Normal.Font = ((System.Drawing.Font)(resources.GetObject("itmVerslAktielijsExtern.AppearanceItem.Normal.Font")));
            this.itmVerslAktielijsExtern.AppearanceItem.Normal.Options.UseBackColor = true;
            this.itmVerslAktielijsExtern.AppearanceItem.Normal.Options.UseFont = true;
            resources.ApplyResources(tileItemElement4, "tileItemElement4");
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.itmVerslAktielijsExtern.Elements.Add(tileItemElement4);
            this.itmVerslAktielijsExtern.Enabled = false;
            tileItemFrame2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            tileItemFrame2.Appearance.Options.UseFont = true;
            resources.ApplyResources(tileItemElement5, "tileItemElement5");
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemFrame2.Elements.Add(tileItemElement5);
            this.itmVerslAktielijsExtern.Frames.Add(tileItemFrame2);
            this.itmVerslAktielijsExtern.Id = 10;
            this.itmVerslAktielijsExtern.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.itmVerslAktielijsExtern.Name = "itmVerslAktielijsExtern";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem1);
            this.tileGroup1.Items.Add(this.tileItem2);
            this.tileGroup1.Items.Add(this.tileItem3);
            this.tileGroup1.Name = "tileGroup1";
            resources.ApplyResources(this.tileGroup1, "tileGroup1");
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Magenta;
            this.tileItem1.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tileItem1.AppearanceItem.Normal.Font = ((System.Drawing.Font)(resources.GetObject("tileItem1.AppearanceItem.Normal.Font")));
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            resources.ApplyResources(tileItemElement6, "tileItemElement6");
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.tileItem1.Elements.Add(tileItemElement6);
            this.tileItem1.Id = 5;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.Padding = new System.Windows.Forms.Padding(0, -1, 20, -1);
            this.tileItem1.Visible = false;
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tileItem2.AppearanceItem.Normal.Font = ((System.Drawing.Font)(resources.GetObject("tileItem2.AppearanceItem.Normal.Font")));
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseFont = true;
            resources.ApplyResources(tileItemElement7, "tileItemElement7");
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem2.Elements.Add(tileItemElement7);
            this.tileItem2.Enabled = false;
            tileItemFrame3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            tileItemFrame3.Appearance.Options.UseFont = true;
            resources.ApplyResources(tileItemElement8, "tileItemElement8");
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemFrame3.Elements.Add(tileItemElement8);
            this.tileItem2.Frames.Add(tileItemFrame3);
            this.tileItem2.Id = 9;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tileItem3.AppearanceItem.Normal.Font = ((System.Drawing.Font)(resources.GetObject("tileItem3.AppearanceItem.Normal.Font")));
            this.tileItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseFont = true;
            resources.ApplyResources(tileItemElement9, "tileItemElement9");
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem3.Elements.Add(tileItemElement9);
            this.tileItem3.Enabled = false;
            tileItemFrame4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font3")));
            tileItemFrame4.Appearance.Options.UseFont = true;
            resources.ApplyResources(tileItemElement10, "tileItemElement10");
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemFrame4.Elements.Add(tileItemElement10);
            this.tileItem3.Frames.Add(tileItemFrame4);
            this.tileItem3.Id = 10;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            // 
            // gcSuppliers
            // 
            resources.ApplyResources(this.gcSuppliers, "gcSuppliers");
            this.gcSuppliers.EmbeddedNavigator.AccessibleDescription = resources.GetString("gcSuppliers.EmbeddedNavigator.AccessibleDescription");
            this.gcSuppliers.EmbeddedNavigator.AccessibleName = resources.GetString("gcSuppliers.EmbeddedNavigator.AccessibleName");
            this.gcSuppliers.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gcSuppliers.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gcSuppliers.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gcSuppliers.EmbeddedNavigator.Anchor")));
            this.gcSuppliers.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gcSuppliers.EmbeddedNavigator.BackgroundImage")));
            this.gcSuppliers.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gcSuppliers.EmbeddedNavigator.BackgroundImageLayout")));
            this.gcSuppliers.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gcSuppliers.EmbeddedNavigator.ImeMode")));
            this.gcSuppliers.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gcSuppliers.EmbeddedNavigator.MaximumSize")));
            this.gcSuppliers.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gcSuppliers.EmbeddedNavigator.TextLocation")));
            this.gcSuppliers.EmbeddedNavigator.ToolTip = resources.GetString("gcSuppliers.EmbeddedNavigator.ToolTip");
            this.gcSuppliers.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gcSuppliers.EmbeddedNavigator.ToolTipIconType")));
            this.gcSuppliers.EmbeddedNavigator.ToolTipTitle = resources.GetString("gcSuppliers.EmbeddedNavigator.ToolTipTitle");
            this.gcSuppliers.MainView = this.gcCP;
            this.gcSuppliers.Name = "gcSuppliers";
            this.gcSuppliers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcCP});
            // 
            // gcCP
            // 
            this.gcCP.ActiveFilterEnabled = false;
            this.gcCP.Appearance.ColumnFilterButton.Font = ((System.Drawing.Font)(resources.GetObject("gcCP.Appearance.ColumnFilterButton.Font")));
            this.gcCP.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gcCP.Appearance.CustomizationFormHint.Font = ((System.Drawing.Font)(resources.GetObject("gcCP.Appearance.CustomizationFormHint.Font")));
            this.gcCP.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gcCP.Appearance.RowSeparator.BorderColor = System.Drawing.Color.Maroon;
            this.gcCP.Appearance.RowSeparator.Options.UseBorderColor = true;
            this.gcCP.Appearance.SelectedRow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gcCP.Appearance.SelectedRow.Font = ((System.Drawing.Font)(resources.GetObject("gcCP.Appearance.SelectedRow.Font")));
            this.gcCP.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gcCP.Appearance.SelectedRow.Options.UseFont = true;
            resources.ApplyResources(this.gcCP, "gcCP");
            this.gcCP.ColumnPanelRowHeight = 50;
            this.gcCP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAfdekID,
            this.colNaam,
            this.colOmschrijving,
            this.colLocatie});
            this.gcCP.GridControl = this.gcSuppliers;
            this.gcCP.Name = "gcCP";
            this.gcCP.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gcCP.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gcCP.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gcCP.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gcCP.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gcCP.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gcCP.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gcCP.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gcCP.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gcCP.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gcCP.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gcCP.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.gcCP.OptionsBehavior.ReadOnly = true;
            this.gcCP.OptionsCustomization.AllowFilter = false;
            this.gcCP.OptionsCustomization.AllowGroup = false;
            this.gcCP.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gcCP.OptionsDetail.AllowZoomDetail = false;
            this.gcCP.OptionsDetail.EnableMasterViewMode = false;
            this.gcCP.OptionsDetail.ShowDetailTabs = false;
            this.gcCP.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gcCP.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct;
            this.gcCP.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gcCP.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.gcCP.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gcCP.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gcCP.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gcCP.OptionsFilter.AllowFilterEditor = false;
            this.gcCP.OptionsFind.AlwaysVisible = true;
            this.gcCP.OptionsFind.SearchInPreview = true;
            this.gcCP.OptionsMenu.EnableColumnMenu = false;
            this.gcCP.OptionsMenu.EnableFooterMenu = false;
            this.gcCP.OptionsMenu.EnableGroupPanelMenu = false;
            this.gcCP.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.gcCP.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gcCP.OptionsPrint.ExpandAllGroups = false;
            this.gcCP.OptionsPrint.PrintFilterInfo = true;
            this.gcCP.OptionsPrint.PrintGroupFooter = false;
            this.gcCP.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gcCP.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gcCP.OptionsView.AllowHtmlDrawGroups = false;
            this.gcCP.OptionsView.AllowHtmlDrawHeaders = true;
            this.gcCP.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gcCP.OptionsView.ShowDetailButtons = false;
            this.gcCP.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gcCP.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gcCP.OptionsView.ShowGroupPanel = false;
            this.gcCP.RowHeight = 35;
            this.gcCP.SynchronizeClones = false;
            // 
            // colAfdekID
            // 
            resources.ApplyResources(this.colAfdekID, "colAfdekID");
            this.colAfdekID.FieldName = "AfdekID";
            this.colAfdekID.Name = "colAfdekID";
            this.colAfdekID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colNaam
            // 
            resources.ApplyResources(this.colNaam, "colNaam");
            this.colNaam.FieldName = "Naam_afdekmateriaal";
            this.colNaam.Name = "colNaam";
            this.colNaam.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // colOmschrijving
            // 
            resources.ApplyResources(this.colOmschrijving, "colOmschrijving");
            this.colOmschrijving.FieldName = "Omschrijving";
            this.colOmschrijving.Name = "colOmschrijving";
            // 
            // colLocatie
            // 
            resources.ApplyResources(this.colLocatie, "colLocatie");
            this.colLocatie.FieldName = "Locatie";
            this.colLocatie.Name = "colLocatie";
            // 
            // frmAfdekmateriaalzeoken
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSuppliers);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "frmAfdekmateriaalzeoken";
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem itmVerslAktielijsIntern;
        private DevExpress.XtraEditors.TileItem itmVerslAktielijsExtern;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navAdd;
        private DevExpress.XtraBars.Navigation.NavButton itmEinde;
        private DevExpress.XtraBars.Navigation.NavButton navEdit;
        private DevExpress.XtraBars.Navigation.NavButton navDelete;
        private DevExpress.XtraGrid.GridControl gcSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView gcCP;
        private DevExpress.XtraGrid.Columns.GridColumn colAfdekID;
        private DevExpress.XtraGrid.Columns.GridColumn colNaam;
        private DevExpress.XtraGrid.Columns.GridColumn colOmschrijving;
        private DevExpress.XtraGrid.Columns.GridColumn colLocatie;
    }
}