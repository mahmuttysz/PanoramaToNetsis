namespace PanoramaToNetsis
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.rbnCnt = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barDeveloper = new DevExpress.XtraBars.BarStaticItem();
            this.barVersiyon = new DevExpress.XtraBars.BarStaticItem();
            this.barFirma = new DevExpress.XtraBars.BarStaticItem();
            this.barZaman = new DevExpress.XtraBars.BarStaticItem();
            this.barKullanici = new DevExpress.XtraBars.BarStaticItem();
            this.rbnForm = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.TrvMenu = new DevExpress.XtraTreeList.TreeList();
            this.SSLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.SSTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.labelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rbnCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnCnt
            // 
            this.rbnCnt.ApplicationButtonImageOptions.Image = global::PanoramaToNetsis.Properties.Resources.logo1;
            this.rbnCnt.AutoSizeItems = true;
            this.rbnCnt.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.rbnCnt.ExpandCollapseItem.Id = 0;
            this.rbnCnt.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbnCnt.ExpandCollapseItem,
            this.rbnCnt.SearchEditItem,
            this.barDeveloper,
            this.barVersiyon,
            this.barFirma,
            this.barZaman,
            this.barKullanici});
            this.rbnCnt.Location = new System.Drawing.Point(0, 0);
            this.rbnCnt.MaxItemId = 13;
            this.rbnCnt.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.rbnCnt.Name = "rbnCnt";
            this.rbnCnt.OptionsMenuMinWidth = 283;
            this.rbnCnt.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnForm});
            this.rbnCnt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.rbnCnt.Size = new System.Drawing.Size(1632, 144);
            this.rbnCnt.StatusBar = this.ribbonStatusBar1;
            // 
            // barDeveloper
            // 
            this.barDeveloper.Caption = "@2016 SS Shadow |";
            this.barDeveloper.Id = 6;
            this.barDeveloper.Name = "barDeveloper";
            // 
            // barVersiyon
            // 
            this.barVersiyon.Caption = "Versiyon 1.0.0 |";
            this.barVersiyon.Id = 7;
            this.barVersiyon.Name = "barVersiyon";
            // 
            // barFirma
            // 
            this.barFirma.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barFirma.Caption = "Mahmut Tüysüz | mahmuttuysuz45@hotmail.com";
            this.barFirma.Id = 8;
            this.barFirma.Name = "barFirma";
            this.barFirma.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barFirma.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // barZaman
            // 
            this.barZaman.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barZaman.Caption = "Zaman";
            this.barZaman.Id = 9;
            this.barZaman.Name = "barZaman";
            // 
            // barKullanici
            // 
            this.barKullanici.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barKullanici.Caption = "Kullanıcı : Admin |";
            this.barKullanici.Id = 12;
            this.barKullanici.Name = "barKullanici";
            // 
            // rbnForm
            // 
            this.rbnForm.Name = "rbnForm";
            this.rbnForm.Text = "Form";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 646);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.rbnCnt;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1632, 32);
            // 
            // TrvMenu
            // 
            this.TrvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.TrvMenu.Location = new System.Drawing.Point(0, 144);
            this.TrvMenu.Name = "TrvMenu";
            this.TrvMenu.Size = new System.Drawing.Size(260, 502);
            this.TrvMenu.TabIndex = 1;
            this.TrvMenu.DoubleClick += new System.EventHandler(this.TrvMenu_DoubleClick);
            this.TrvMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrvMenu_KeyPress);
            // 
            // SSLookAndFeel
            // 
            this.SSLookAndFeel.EnableBonusSkins = true;
            this.SSLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // SSTabbedMdiManager
            // 
            this.SSTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.SSTabbedMdiManager.MdiParent = this;
            this.SSTabbedMdiManager.SelectedPageChanged += new System.EventHandler(this.SSTabbedMdiManager_SelectedPageChanged);
            this.SSTabbedMdiManager.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.SSTabbedMdiManager_PageRemoved);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(345, 37);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(65, 13);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "version text";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 678);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.TrvMenu);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.rbnCnt);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("fMain.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "fMain";
            this.Ribbon = this.rbnCnt;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Panorama To Netsis Solution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.Shown += new System.EventHandler(this.fMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rbnCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbnCnt;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnForm;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraTreeList.TreeList TrvMenu;
        private DevExpress.LookAndFeel.DefaultLookAndFeel SSLookAndFeel;
        private System.Windows.Forms.Timer tmrMain;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager SSTabbedMdiManager;
        private DevExpress.XtraBars.BarStaticItem barDeveloper;
        private DevExpress.XtraBars.BarStaticItem barVersiyon;
        private DevExpress.XtraBars.BarStaticItem barFirma;
        private DevExpress.XtraBars.BarStaticItem barZaman;
        private DevExpress.XtraBars.BarStaticItem barKullanici;
    private System.Windows.Forms.Label labelVersion;
  }
}