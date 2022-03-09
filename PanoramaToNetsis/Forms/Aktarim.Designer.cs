
namespace PanoramaToNetsis
{
    partial class Aktarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aktarim));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.txtBaslangicTarihi = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtBitisTarihi = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnTahsilatGetir = new DevExpress.XtraBars.BarButtonItem();
            this.btnNetsiseAktar = new DevExpress.XtraBars.BarButtonItem();
            this.lblAktarimDurumu = new DevExpress.XtraBars.BarStaticItem();
            this.prgBar = new DevExpress.XtraBars.BarEditItem();
            this.prgMarquee = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnKriter = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnAksiyon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemRadioGroup2 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemRadioGroup3 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgMarquee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
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
            this.btnTahsilatGetir,
            this.btnNetsiseAktar,
            this.lblAktarimDurumu,
            this.prgBar,
            this.lblStatus});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 18;
            this.ribbon.MinimumSize = new System.Drawing.Size(0, 162);
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemRadioGroup2,
            this.repositoryItemCheckEdit2,
            this.repositoryItemRadioGroup3,
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.prgMarquee});
            this.ribbon.Size = new System.Drawing.Size(1137, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // txtBaslangicTarihi
            // 
            this.txtBaslangicTarihi.Caption = "Başlangıç Tarihi";
            this.txtBaslangicTarihi.Edit = this.repositoryItemDateEdit1;
            this.txtBaslangicTarihi.EditWidth = 100;
            this.txtBaslangicTarihi.Id = 9;
            this.txtBaslangicTarihi.Name = "txtBaslangicTarihi";
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
            // txtBitisTarihi
            // 
            this.txtBitisTarihi.Caption = "Bitiş Tarihi";
            this.txtBitisTarihi.Edit = this.repositoryItemDateEdit2;
            this.txtBitisTarihi.EditWidth = 100;
            this.txtBitisTarihi.Id = 10;
            this.txtBitisTarihi.Name = "txtBitisTarihi";
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
            // btnTahsilatGetir
            // 
            this.btnTahsilatGetir.Caption = "Tahsilatları Getir";
            this.btnTahsilatGetir.Id = 12;
            this.btnTahsilatGetir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTahsilatGetir.ImageOptions.SvgImage")));
            this.btnTahsilatGetir.Name = "btnTahsilatGetir";
            this.btnTahsilatGetir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTahsilatGetirClick);
            // 
            // btnNetsiseAktar
            // 
            this.btnNetsiseAktar.Caption = "Netsis\'e Aktar";
            this.btnNetsiseAktar.Id = 13;
            this.btnNetsiseAktar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNetsiseAktar.ImageOptions.SvgImage")));
            this.btnNetsiseAktar.Name = "btnNetsiseAktar";
            this.btnNetsiseAktar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNetsiseAktarClick);
            // 
            // lblAktarimDurumu
            // 
            this.lblAktarimDurumu.Id = 15;
            this.lblAktarimDurumu.Name = "lblAktarimDurumu";
            // 
            // prgBar
            // 
            this.prgBar.Edit = this.prgMarquee;
            this.prgBar.EditWidth = 100;
            this.prgBar.Id = 16;
            this.prgBar.Name = "prgBar";
            // 
            // prgMarquee
            // 
            this.prgMarquee.Name = "prgMarquee";
            // 
            // lblStatus
            // 
            this.lblStatus.Id = 17;
            this.lblStatus.Name = "lblStatus";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnKriter,
            this.rbnAksiyon});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Form";
            // 
            // rbnKriter
            // 
            this.rbnKriter.ItemLinks.Add(this.txtBaslangicTarihi);
            this.rbnKriter.ItemLinks.Add(this.txtBitisTarihi);
            this.rbnKriter.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.rbnKriter.Name = "rbnKriter";
            this.rbnKriter.Text = "Kriter";
            // 
            // rbnAksiyon
            // 
            this.rbnAksiyon.ItemLinks.Add(this.btnTahsilatGetir);
            this.rbnAksiyon.ItemLinks.Add(this.btnNetsiseAktar);
            this.rbnAksiyon.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.rbnAksiyon.Name = "rbnAksiyon";
            this.rbnAksiyon.Text = "Aksiyon";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tüm Belgeler", true, null, "tumBelgeler"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Sadece Yeni Belgeler", true, null, "yeniBelgeler"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Sadece Aktarılmayan Belgeler", true, null, "aktarilmayanBelgeler")});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemRadioGroup2
            // 
            this.repositoryItemRadioGroup2.Columns = 3;
            this.repositoryItemRadioGroup2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRadioGroup2.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tüm Belgeler"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Sadece Yeni Belgeler"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Sadece Aktarılmayanlar")});
            this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemRadioGroup3
            // 
            this.repositoryItemRadioGroup3.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemRadioGroup3.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column;
            this.repositoryItemRadioGroup3.ItemVertAlignment = DevExpress.XtraEditors.RadioItemVertAlignment.Top;
            this.repositoryItemRadioGroup3.Name = "repositoryItemRadioGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.prgBar);
            this.ribbonStatusBar.ItemLinks.Add(this.lblStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.lblAktarimDurumu);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 396);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1137, 24);
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Edit = null;
            this.barEditItem3.Name = "barEditItem3";
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
            this.gridControl1.Size = new System.Drawing.Size(1137, 238);
            this.gridControl1.TabIndex = 7;
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
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // Aktarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 420);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Aktarim";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Aktarım";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgMarquee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnKriter;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraBars.BarEditItem txtBaslangicTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem txtBitisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem btnTahsilatGetir;
        private DevExpress.XtraBars.BarButtonItem btnNetsiseAktar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnAksiyon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarStaticItem lblAktarimDurumu;
        private DevExpress.XtraBars.BarEditItem prgBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar prgMarquee;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
    }
}