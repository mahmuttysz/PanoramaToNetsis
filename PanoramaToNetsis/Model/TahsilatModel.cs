using System;

namespace PanoramaToNetsis.Model
{
    public class TahsilatModel
    {
        public string TahsilatID { get; set; }
        public string KrediKartiKasaKodu { get; set; }
        public string CariKodu { get; set; }
        public string FaturaNo { get; set; }
        public string HesapHavaleKod { get; set; }
        public string BankaAdi { get; set; }
        public double Tutar { get; set; }
        public string SatisTemsilciKodu { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string CHAciklama { get; set; }
    }
}