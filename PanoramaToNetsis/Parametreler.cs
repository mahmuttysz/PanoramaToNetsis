using System;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace PanoramaToNetsis
{
    public partial class Parametreler : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Parametreler(string _ConstrRapor, string _ConnStrWebPlus, string _ConnStrDiger)
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Ayarlar.Getir();
            txt_Netsis_Cek_Kasa_Kodu.Text = Ayarlar.NetsisCekKasaKodu;
            txt_Netsis_Database.Text = Ayarlar.NetsisDBDatabase;
            txt_Netsis_DB_Password.Text = Ayarlar.NetsisDBPassword;
            txt_Netsis_DB_User.Text = Ayarlar.NetsisDBUser;
            txt_Netsis_Kullanici_Adi.Text = Ayarlar.NetsisKullaniciAdi;
            txt_Netsis_Nakit_Kasa_Kodu.Text = Ayarlar.NetsisNakitKasaKodu;
            txt_Netsis_Senet_Kasa_Kodu.Text = Ayarlar.NetsisSenetKasaKodu;
            txt_Netsis_Sifre.Text = Ayarlar.NetsisSifre;
            txt_Netsis_Sube.Text = Ayarlar.NetsisSube.ToString();
            txtWebServiceUrl.Text = Ayarlar.WebServiceUrl;
            txtDistKod.Text = Ayarlar.WebServiceDistKod;
            txtWebServiceUser.Text = Ayarlar.WebServiceUser;
            txtWebServicePassword.Text = Ayarlar.WebServicePassword;
            txtCalismaYili.Text = Ayarlar.WebServiceCalismaYili;
            txtFirmaKod.Text = Ayarlar.WebServiceFirmaKod;

            txtLogServer.Text = Ayarlar.LogServer;
            txtLogKAdi.Text = Ayarlar.LogKullaniciAdi;
            txtLogSifre.Text = Ayarlar.LogSifre;
            txtLogDB.Text = Ayarlar.LogDB;
        }

        private void BtnKaydetClick(object sender, ItemClickEventArgs e)
        {
            Ayarlar.WebServiceUrl = txtWebServiceUrl.Text;
            Ayarlar.WebServiceDistKod = txtDistKod.Text;
            Ayarlar.WebServiceUser = txtWebServiceUser.Text;
            Ayarlar.WebServicePassword = txtWebServicePassword.Text;
            Ayarlar.WebServiceCalismaYili = txtCalismaYili.Text;
            Ayarlar.WebServiceFirmaKod = txtFirmaKod.Text;

            Ayarlar.LogServer = txtLogServer.Text;
            Ayarlar.LogKullaniciAdi = txtLogKAdi.Text;
            Ayarlar.LogSifre = txtLogSifre.Text;
            Ayarlar.LogDB = txtLogDB.Text;

            Ayarlar.NetsisCekKasaKodu = txt_Netsis_Cek_Kasa_Kodu.Text;
            Ayarlar.NetsisDBDatabase = txt_Netsis_Database.Text;
            Ayarlar.NetsisDBPassword = txt_Netsis_DB_Password.Text;
            Ayarlar.NetsisDBUser = txt_Netsis_DB_User.Text;
            Ayarlar.NetsisKullaniciAdi = txt_Netsis_Kullanici_Adi.Text;
            Ayarlar.NetsisNakitKasaKodu = txt_Netsis_Nakit_Kasa_Kodu.Text;
            Ayarlar.NetsisSenetKasaKodu = txt_Netsis_Senet_Kasa_Kodu.Text;
            Ayarlar.NetsisSifre = txt_Netsis_Sifre.Text;
            Ayarlar.NetsisSube = int.Parse(txt_Netsis_Sube.Text.DefaultString_("0"));

            Ayarlar.Kaydet();
            MessageBox.Show("Tüm Ayarlar kaydedildi");
        }
    }
}