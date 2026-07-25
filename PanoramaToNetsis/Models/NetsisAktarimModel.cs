using System;
using System.ComponentModel.DataAnnotations;

namespace PanoramaToNetsis.Models
{
    public class NetsisAktarimModel
    {
        public int? TahsilatID { get; set; }
        public string Tip { get; set; }

        [Display(AutoGenerateField = false)]
        public string MusteriID { get; set; }

        public string Musteri { get; set; }
        public decimal Tutar { get; set; }
        public string FaturaNo { get; set; }
        public string Kasa { get; set; }
        public string Aciklama { get; set; }
        public string Banka { get; set; }
        public string HavaleHesapNo { get; set; }

        [Display(AutoGenerateField = false)]
        public string TemsilciID { get; set; }

        public string Temsilci { get; set; }
        public DateTime? Tarih { get; set; }

        [Display(AutoGenerateField = false)]
        public byte? TipID { get; set; }
    }
}