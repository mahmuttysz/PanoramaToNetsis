
namespace PanoramaToNetsis
{
    partial class AktarimSonuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AktarimSonuc));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.txtBaslangicTarihi = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtBitisTarihi = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAktarimListele = new DevExpress.XtraBars.BarButtonItem();
            this.lblKayitSayisi = new DevExpress.XtraBars.BarStaticItem();
            this.barPrg = new DevExpress.XtraBars.BarEditItem();
            this.prgMarquee = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgMarquee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.txtBaslangicTarihi,
            this.txtBitisTarihi,
            this.barButtonItem1,
            this.btnAktarimListele,
            this.lblKayitSayisi,
            this.barPrg});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemDateEdit3,
            this.prgMarquee});
            this.ribbon.Size = new System.Drawing.Size(1119, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // txtBaslangicTarihi
            // 
            this.txtBaslangicTarihi.Caption = "Başlangıç Tarihi ";
            this.txtBaslangicTarihi.Edit = this.repositoryItemDateEdit2;
            this.txtBaslangicTarihi.EditWidth = 150;
            this.txtBaslangicTarihi.Id = 4;
            this.txtBaslangicTarihi.Name = "txtBaslangicTarihi";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // txtBitisTarihi
            // 
            this.txtBitisTarihi.Caption = "Bitiş Tarihi ";
            this.txtBitisTarihi.Edit = this.repositoryItemDateEdit3;
            this.txtBitisTarihi.EditWidth = 150;
            this.txtBitisTarihi.Id = 5;
            this.txtBitisTarihi.Name = "txtBitisTarihi";
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnAktarimListele
            // 
            this.btnAktarimListele.Caption = "Listele";
            this.btnAktarimListele.Id = 7;
            this.btnAktarimListele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAktarimListele.ImageOptions.SvgImage")));
            this.btnAktarimListele.Name = "btnAktarimListele";
            this.btnAktarimListele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAktarimListeleClick);
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.Id = 8;
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            // 
            // barPrg
            // 
            this.barPrg.Edit = this.prgMarquee;
            this.barPrg.EditWidth = 100;
            this.barPrg.Id = 9;
            this.barPrg.Name = "barPrg";
            // 
            // prgMarquee
            // 
            this.prgMarquee.Name = "prgMarquee";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Form";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.txtBaslangicTarihi);
            this.ribbonPageGroup1.ItemLinks.Add(this.txtBitisTarihi);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Kriter";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAktarimListele);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Aksiyon";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barPrg);
            this.ribbonStatusBar.ItemLinks.Add(this.lblKayitSayisi);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 401);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1119, 24);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1119, 243);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 43;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            // 
            // AktarimSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 425);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AktarimSonuc";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Aktarım Sonuçları";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgMarquee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarEditItem txtBaslangicTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarEditItem txtBitisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnAktarimListele;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarStaticItem lblKayitSayisi;
        private DevExpress.XtraBars.BarEditItem barPrg;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar prgMarquee;
    }
}