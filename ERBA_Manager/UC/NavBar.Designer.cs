namespace ERBA_Manager.UC
{
    partial class NavBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBar));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navAdd = new DevExpress.XtraBars.Navigation.NavButton();
            this.navEdit = new DevExpress.XtraBars.Navigation.NavButton();
            this.navDelete = new DevExpress.XtraBars.Navigation.NavButton();
            this.itmEinde = new DevExpress.XtraBars.Navigation.NavButton();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
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
            // 
            // navEdit
            // 
            this.navEdit.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            resources.ApplyResources(this.navEdit, "navEdit");
            this.navEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navEdit.ImageOptions.Image")));
            this.navEdit.Name = "navEdit";
            // 
            // navDelete
            // 
            this.navDelete.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            resources.ApplyResources(this.navDelete, "navDelete");
            this.navDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navDelete.ImageOptions.Image")));
            this.navDelete.Name = "navDelete";
            // 
            // itmEinde
            // 
            this.itmEinde.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            resources.ApplyResources(this.itmEinde, "itmEinde");
            this.itmEinde.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itmEinde.ImageOptions.Image")));
            this.itmEinde.Name = "itmEinde";
            this.itmEinde.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.itmEinde_ElementClick);
            // 
            // NavBar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileNavPane1);
            this.Name = "NavBar";
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navAdd;
        private DevExpress.XtraBars.Navigation.NavButton navEdit;
        private DevExpress.XtraBars.Navigation.NavButton navDelete;
        private DevExpress.XtraBars.Navigation.NavButton itmEinde;
    }
}
