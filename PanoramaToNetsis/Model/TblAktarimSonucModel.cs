namespace PanoramaToNetsis.Model
{
    public class TblAktarimSonucModel
    {
        public string Kaynak { get; set; }
        public string Hedef { get; set; }
        public string BelgeMatbu { get; set; }
        public string IslemTuru { get; set; }
        public decimal Tutar { get; set; }
        public string BelgeTipi { get; set; }
        public string KaynakBelgeID { get; set; }
        public string IslemDurumu { get; set; }
        public string IslemAciklamasi { get; set; }
    }
}