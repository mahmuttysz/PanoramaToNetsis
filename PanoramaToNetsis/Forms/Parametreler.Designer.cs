
namespace PanoramaToNetsis
{
    partial class Parametreler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametreler));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtNetsisSenetKasaKodu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNetsisCekKasaKodu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNetsisNakitKasaKodu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNetsisSube = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNetsisSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNetsisKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNetsisDBPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNetsisDBUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNetsisDatabase = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLogServer = new System.Windows.Forms.TextBox();
            this.txtLogDB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLogSifre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLogKAdi = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFirmaKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalismaYili = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtWebServiceUrl = new System.Windows.Forms.TextBox();
            this.txtDistKod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWebServicePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWebServiceUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnKaydet});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1125, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 1;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKaydetClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Form";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Aksiyon";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 627);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1125, 40);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 178);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisSenetKasaKodu);
            this.splitContainerControl1.Panel1.Controls.Add(this.label14);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisCekKasaKodu);
            this.splitContainerControl1.Panel1.Controls.Add(this.label13);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisNakitKasaKodu);
            this.splitContainerControl1.Panel1.Controls.Add(this.label12);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisSube);
            this.splitContainerControl1.Panel1.Controls.Add(this.label11);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisSifre);
            this.splitContainerControl1.Panel1.Controls.Add(this.label6);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisKullaniciAdi);
            this.splitContainerControl1.Panel1.Controls.Add(this.label7);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisDBPassword);
            this.splitContainerControl1.Panel1.Controls.Add(this.label8);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisDBUser);
            this.splitContainerControl1.Panel1.Controls.Add(this.label9);
            this.splitContainerControl1.Panel1.Controls.Add(this.label10);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNetsisDatabase);
            this.splitContainerControl1.Panel1.Controls.Add(this.label17);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtLogServer);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtLogDB);
            this.splitContainerControl1.Panel1.Controls.Add(this.label18);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtLogSifre);
            this.splitContainerControl1.Panel1.Controls.Add(this.label19);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtLogKAdi);
            this.splitContainerControl1.Panel1.Controls.Add(this.label20);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtFirmaKod);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtCalismaYili);
            this.splitContainerControl1.Panel1.Controls.Add(this.label16);
            this.splitContainerControl1.Panel1.Controls.Add(this.label15);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtWebServiceUrl);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtDistKod);
            this.splitContainerControl1.Panel1.Controls.Add(this.label5);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtWebServicePassword);
            this.splitContainerControl1.Panel1.Controls.Add(this.label4);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtWebServiceUser);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            this.splitContainerControl1.Size = new System.Drawing.Size(1125, 449);
            this.splitContainerControl1.SplitterPosition = 420;
            this.splitContainerControl1.TabIndex = 110;
            // 
            // txt_Netsis_Senet_Kasa_Kodu
            // 
            this.txtNetsisSenetKasaKodu.Location = new System.Drawing.Point(736, 270);
            this.txtNetsisSenetKasaKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisSenetKasaKodu.Name = "txt_Netsis_Senet_Kasa_Kodu";
            this.txtNetsisSenetKasaKodu.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisSenetKasaKodu.TabIndex = 145;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(608, 274);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 144;
            this.label14.Text = "Senet Kasa Kodu";
            // 
            // txt_Netsis_Cek_Kasa_Kodu
            // 
            this.txtNetsisCekKasaKodu.Location = new System.Drawing.Point(736, 238);
            this.txtNetsisCekKasaKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisCekKasaKodu.Name = "txt_Netsis_Cek_Kasa_Kodu";
            this.txtNetsisCekKasaKodu.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisCekKasaKodu.TabIndex = 143;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(608, 242);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 142;
            this.label13.Text = "Çek Kasa Kodu";
            // 
            // txt_Netsis_Nakit_Kasa_Kodu
            // 
            this.txtNetsisNakitKasaKodu.Location = new System.Drawing.Point(736, 206);
            this.txtNetsisNakitKasaKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisNakitKasaKodu.Name = "txt_Netsis_Nakit_Kasa_Kodu";
            this.txtNetsisNakitKasaKodu.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisNakitKasaKodu.TabIndex = 141;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(608, 210);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 140;
            this.label12.Text = "Nakit Kasa Kodu";
            // 
            // txt_Netsis_Sube
            // 
            this.txtNetsisSube.Location = new System.Drawing.Point(736, 174);
            this.txtNetsisSube.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisSube.Name = "txt_Netsis_Sube";
            this.txtNetsisSube.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisSube.TabIndex = 139;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 138;
            this.label11.Text = "Şube";
            // 
            // txt_Netsis_Sifre
            // 
            this.txtNetsisSifre.Location = new System.Drawing.Point(736, 142);
            this.txtNetsisSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisSifre.Name = "txt_Netsis_Sifre";
            this.txtNetsisSifre.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisSifre.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 136;
            this.label6.Text = "Şifre";
            // 
            // txt_Netsis_Kullanici_Adi
            // 
            this.txtNetsisKullaniciAdi.Location = new System.Drawing.Point(736, 110);
            this.txtNetsisKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisKullaniciAdi.Name = "txt_Netsis_Kullanici_Adi";
            this.txtNetsisKullaniciAdi.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisKullaniciAdi.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(608, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 134;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // txt_Netsis_DB_Password
            // 
            this.txtNetsisDBPassword.Location = new System.Drawing.Point(736, 78);
            this.txtNetsisDBPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisDBPassword.Name = "txt_Netsis_DB_Password";
            this.txtNetsisDBPassword.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisDBPassword.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 132;
            this.label8.Text = "DB Password";
            // 
            // txt_Netsis_DB_User
            // 
            this.txtNetsisDBUser.Location = new System.Drawing.Point(736, 46);
            this.txtNetsisDBUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisDBUser.Name = "txt_Netsis_DB_User";
            this.txtNetsisDBUser.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisDBUser.TabIndex = 131;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 130;
            this.label9.Text = "DB User";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 129;
            this.label10.Text = "Database";
            // 
            // txt_Netsis_Database
            // 
            this.txtNetsisDatabase.Location = new System.Drawing.Point(736, 14);
            this.txtNetsisDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetsisDatabase.Name = "txt_Netsis_Database";
            this.txtNetsisDatabase.Size = new System.Drawing.Size(173, 23);
            this.txtNetsisDatabase.TabIndex = 128;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 245);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 17);
            this.label17.TabIndex = 127;
            this.label17.Text = "Log Kayıt Server";
            // 
            // txtLogServer
            // 
            this.txtLogServer.Location = new System.Drawing.Point(149, 242);
            this.txtLogServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogServer.Name = "txtLogServer";
            this.txtLogServer.Size = new System.Drawing.Size(348, 23);
            this.txtLogServer.TabIndex = 126;
            // 
            // txtLogDB
            // 
            this.txtLogDB.Location = new System.Drawing.Point(149, 339);
            this.txtLogDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogDB.Name = "txtLogDB";
            this.txtLogDB.Size = new System.Drawing.Size(348, 23);
            this.txtLogDB.TabIndex = 125;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 343);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 17);
            this.label18.TabIndex = 124;
            this.label18.Text = "DB Adı";
            // 
            // txtLogSifre
            // 
            this.txtLogSifre.Location = new System.Drawing.Point(149, 307);
            this.txtLogSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogSifre.Name = "txtLogSifre";
            this.txtLogSifre.Size = new System.Drawing.Size(348, 23);
            this.txtLogSifre.TabIndex = 123;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 311);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 17);
            this.label19.TabIndex = 122;
            this.label19.Text = "Şifre";
            // 
            // txtLogKAdi
            // 
            this.txtLogKAdi.Location = new System.Drawing.Point(149, 275);
            this.txtLogKAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogKAdi.Name = "txtLogKAdi";
            this.txtLogKAdi.Size = new System.Drawing.Size(348, 23);
            this.txtLogKAdi.TabIndex = 121;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 279);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 120;
            this.label20.Text = "Kullanıcı";
            // 
            // txtFirmaKod
            // 
            this.txtFirmaKod.Location = new System.Drawing.Point(149, 176);
            this.txtFirmaKod.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirmaKod.Name = "txtFirmaKod";
            this.txtFirmaKod.Size = new System.Drawing.Size(348, 23);
            this.txtFirmaKod.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "Firma Kodu";
            // 
            // txtCalismaYili
            // 
            this.txtCalismaYili.Location = new System.Drawing.Point(149, 144);
            this.txtCalismaYili.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalismaYili.Name = "txtCalismaYili";
            this.txtCalismaYili.Size = new System.Drawing.Size(348, 23);
            this.txtCalismaYili.TabIndex = 117;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 148);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 17);
            this.label16.TabIndex = 116;
            this.label16.Text = "Çalışma Yılı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 17);
            this.label15.TabIndex = 115;
            this.label15.Text = "Web Service Url";
            // 
            // txtWebServiceUrl
            // 
            this.txtWebServiceUrl.Location = new System.Drawing.Point(149, 17);
            this.txtWebServiceUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebServiceUrl.Name = "txtWebServiceUrl";
            this.txtWebServiceUrl.Size = new System.Drawing.Size(348, 23);
            this.txtWebServiceUrl.TabIndex = 114;
            // 
            // txtDistKod
            // 
            this.txtDistKod.Location = new System.Drawing.Point(149, 114);
            this.txtDistKod.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistKod.Name = "txtDistKod";
            this.txtDistKod.Size = new System.Drawing.Size(348, 23);
            this.txtDistKod.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 112;
            this.label5.Text = "Dist Kod";
            // 
            // txtWebServicePassword
            // 
            this.txtWebServicePassword.Location = new System.Drawing.Point(149, 82);
            this.txtWebServicePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebServicePassword.Name = "txtWebServicePassword";
            this.txtWebServicePassword.Size = new System.Drawing.Size(348, 23);
            this.txtWebServicePassword.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 110;
            this.label4.Text = "Şifre";
            // 
            // txtWebServiceUser
            // 
            this.txtWebServiceUser.Location = new System.Drawing.Point(149, 50);
            this.txtWebServiceUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebServiceUser.Name = "txtWebServiceUser";
            this.txtWebServiceUser.Size = new System.Drawing.Size(348, 23);
            this.txtWebServiceUser.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 108;
            this.label3.Text = "Kullanıcı";
            // 
            // Parametreler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 667);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Parametreler";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Parametreler";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TextBox txtNetsisSenetKasaKodu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNetsisCekKasaKodu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNetsisNakitKasaKodu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNetsisSube;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNetsisSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNetsisKullaniciAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNetsisDBPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNetsisDBUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNetsisDatabase;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLogServer;
        private System.Windows.Forms.TextBox txtLogDB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLogSifre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLogKAdi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFirmaKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalismaYili;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtWebServiceUrl;
        private System.Windows.Forms.TextBox txtDistKod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWebServicePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWebServiceUser;
        private System.Windows.Forms.Label label3;
    }
}