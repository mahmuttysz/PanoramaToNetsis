using System;
using System.ComponentModel.DataAnnotations;

namespace PanoramaToNetsis.Model
{
    public class NetsisAktarimModel
    {
        public int? Tahsilat_ID { get; set; }
        public string Tip { get; set; }

        [Display(AutoGenerateField = false)]
        public string Musteri_ID { get; set; }

        public string Musteri { get; set; }
        public decimal Tutar { get; set; }
        public string Fatura_No { get; set; }
        public string Kasa { get; set; }
        public string Aciklama { get; set; }
        public string Banka { get; set; }
        public string Havale_Hesap_No { get; set; }

        [Display(AutoGenerateField = false)]
        public string Temsilci_ID { get; set; }

        public string Temsilci { get; set; }
        public DateTime? Tarih { get; set; }

        [Display(AutoGenerateField = false)]
        public byte? Tip_ID { get; set; }
    }
}