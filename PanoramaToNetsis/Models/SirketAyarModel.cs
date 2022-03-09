using NetOpenX50;
namespace PanoramaToNetsis.Models
{
    public class SirketAyarModel
    {
        public TVTTipi TVTTipi { get; set; }
        public string NetsisDBDatabase { get; set; }
        public string NetsisDBUser { get; set; }
        public string NetsisDBPassword { get; set; }
        public string NetsisKullaniciAdi { get; set; }
        public string NetsisSifre { get; set; }
        public int NetsisSube { get; set; }
    }
}