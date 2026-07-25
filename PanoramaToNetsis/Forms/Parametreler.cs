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
            var parametreAyarlari = new ParametreAyarlari();
            var parametreler = parametreAyarlari.Getir();
            
            txtNetsisCekKasaKodu.Text = parametreler.NetsisCekKasaKodu;
            txtNetsisDatabase.Text = parametreler.NetsisDBDatabase;
            txtNetsisDBPassword.Text = parametreler.NetsisDBPassword;
            txtNetsisDBUser.Text = parametreler.NetsisDBUser;
            txtNetsisKullaniciAdi.Text = parametreler.NetsisKullaniciAdi;
            txtNetsisNakitKasaKodu.Text = parametreler.NetsisNakitKasaKodu;
            txtNetsisSenetKasaKodu.Text = parametreler.NetsisSenetKasaKodu;
            txtNetsisSifre.Text = parametreler.NetsisSifre;
            txtNetsisSube.Text = parametreler.NetsisSube.ToString();
            txtWebServiceUrl.Text = parametreler.WebServiceUrl;
            txtDistKod.Text = parametreler.WebServiceDistKod;
            txtWebServiceUser.Text = parametreler.WebServiceUser;
            txtWebServicePassword.Text = parametreler.WebServicePassword;
            txtCalismaYili.Text = parametreler.WebServiceCalismaYili;
            txtFirmaKod.Text = parametreler.WebServiceFirmaKod;

            txtLogServer.Text = parametreler.LogServer;
            txtLogKAdi.Text = parametreler.LogKullaniciAdi;
            txtLogSifre.Text = parametreler.LogSifre;
            txtLogDB.Text = parametreler.LogDB;
        }

        private void BtnKaydetClick(object sender, ItemClickEventArgs e)
        {
            var parametreAyarlari = new ParametreAyarlari();
            var parametreler = parametreAyarlari.Getir();

            parametreler.WebServiceUrl = txtWebServiceUrl.Text;
            parametreler.WebServiceDistKod = txtDistKod.Text;
            parametreler.WebServiceUser = txtWebServiceUser.Text;
            parametreler.WebServicePassword = txtWebServicePassword.Text;
            parametreler.WebServiceCalismaYili = txtCalismaYili.Text;
            parametreler.WebServiceFirmaKod = txtFirmaKod.Text;

            parametreler.LogServer = txtLogServer.Text;
            parametreler.LogKullaniciAdi = txtLogKAdi.Text;
            parametreler.LogSifre = txtLogSifre.Text;
            parametreler.LogDB = txtLogDB.Text;

            parametreler.NetsisCekKasaKodu = txtNetsisCekKasaKodu.Text;
            parametreler.NetsisDBDatabase = txtNetsisDatabase.Text;
            parametreler.NetsisDBPassword = txtNetsisDBPassword.Text;
            parametreler.NetsisDBUser = txtNetsisDBUser.Text;
            parametreler.NetsisKullaniciAdi = txtNetsisKullaniciAdi.Text;
            parametreler.NetsisNakitKasaKodu = txtNetsisNakitKasaKodu.Text;
            parametreler.NetsisSenetKasaKodu = txtNetsisSenetKasaKodu.Text;
            parametreler.NetsisSifre = txtNetsisSifre.Text;
            parametreler.NetsisSube = int.Parse(txtNetsisSube.Text.DefaultString_("0"));

            parametreAyarlari.Kaydet();
            MessageBox.Show("Tüm Ayarlar kaydedildi");
        }
    }
}