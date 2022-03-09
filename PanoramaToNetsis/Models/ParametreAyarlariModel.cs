namespace PanoramaToNetsis.Models
{
    public class ParametreAyarlariModel
    {
        public string NetsisDBUser { get; set; }
        public string NetsisDBPassword { get; set; }
        public string NetsisDBDatabase { get; set; }
        public string NetsisKullaniciAdi { get; set; }
        public string NetsisSifre { get; set; }
        public int NetsisSube { get; set; }
        public string NetsisNakitKasaKodu { get; set; }
        public string NetsisCekKasaKodu { get; set; }
        public string NetsisSenetKasaKodu { get; set; }

        public string WebServiceUrl { get; set; }
        public string WebServiceUser { get; set; }
        public string WebServicePassword { get; set; }
        public string WebServiceCalismaYili { get; set; }
        public string WebServiceDistKod { get; set; }
        public string WebServiceFirmaKod { get; set; }

        public string LogServer { get; set; }
        public string LogKullaniciAdi { get; set; }
        public string LogSifre { get; set; }
        public string LogDB { get; set; }
    }
}