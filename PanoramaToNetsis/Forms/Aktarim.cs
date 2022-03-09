using PanoramaToNetsis.Models;
using PanoramaToNetsis.Panorama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PanoramaToNetsis
{
    public partial class Aktarim : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Aktarim(string _ConstrRapor, string _ConnStrWebPlus, string _ConnStrDiger)
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            txtBaslangicTarihi.EditValue = DateTime.Now;
            txtBitisTarihi.EditValue = DateTime.Now;
            base.OnLoad(e);
            PStop();
        }

        private void PStop()
        {
            prgMarquee.Stopped = true;
        }

        private void PStart()
        {
            prgMarquee.Stopped = false;
        }

        private async void BtnTahsilatGetirClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LogKaydet Result = new LogKaydet();
            PStart();

            var parametreAyarlari = new ParametreAyarlari();
            var parametreler = parametreAyarlari.Getir();

            try
            {
                
                var asyncTahsilatlar = await Task.Run(() =>
                {
                    lblStatus.Caption = "Kayıtlar listeleniyor.";
                    btnNetsiseAktar.Enabled = false;
                    btnTahsilatGetir.Enabled = false;

                    var service = new IntegrationWebService();
                    if (parametreler.WebServiceUrl != null && parametreler.WebServiceUrl != "")
                    {
                        service.Url = parametreler.WebServiceUrl;
                    }

                    var clsPaketTanim = new List<clsPaketTanim>();

                    DAL dal = new DAL();
                    var aktarilanlar1 = dal.Aktarilanlar();

                    var aktarilanlar = aktarilanlar1?.Select(ee => ee.TahsilatID).ToList();

                    string baslangicTarihi = ((DateTime)txtBaslangicTarihi.EditValue).ToString("yyyy-MM-dd");
                    string bitisTarihi = ((DateTime)txtBitisTarihi.EditValue).ToString("yyyy-MM-dd");
                    clsPaketTanim.Add(new clsPaketTanim()
                    {
                        Kriter = "\"BYTDURUM=0 AND LNGDISTKOD IN (" + parametreler.WebServiceDistKod +
                                 ") AND BYTTIP IN (0, 6, 13, 14) AND TRHISLEMTARIHI BETWEEN '" + baslangicTarihi +
                                 "' AND '" + bitisTarihi + "' \"",
                        Tabloadi = "VIEWTAHSILATGENERIC",
                        Viewadi = "VIEWTAHSILATGENERIC"
                    });

                    clsPaketTanim.Add(new clsPaketTanim()
                    {
                        Kriter = "",
                        Tabloadi = "VIEWSATISTEMSILCISIGENERIC",
                        Viewadi = "VIEWSATISTEMSILCISIGENERIC"
                    });

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 |
                                                           SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

                    var entitySet = service.IntegrationGetEntitySetWithPacketLogin(clsPaketTanim.ToArray(),

                        parametreler.WebServiceUser, parametreler.WebServicePassword, Convert.ToByte(parametreler.WebServiceFirmaKod),
                        Convert.ToInt32(parametreler.WebServiceCalismaYili), 216);

                    var rslt = entitySet.ResultEntitySet.TahsilatGeneric.ToList();

                    var satis = entitySet.ResultEntitySet.SatisTemsilcileri.ToList();

                    var tahsilatlar = rslt.Where(w => !aktarilanlar.Contains(w.Kod.ToString()))
                        .Select(f => new NetsisAktarimModel()
                        {
                            TahsilatID = f.Kod,
                            Tip = f.Tip.Run_(tip =>
                            {
                                switch (tip)
                                {
                                    case 0:
                                        return "Nakit";

                                    case 6:
                                        return "Kredi Kartı";

                                    case 13:
                                        return "Havale Tahsilat";

                                    case 14:
                                        return "Havale Ödeme";

                                    default:
                                        return f.Tip.ToString();
                                }
                            }),
                            MusteriID = f.Musterikod,
                            Musteri = f.MusteriAdi,
                            Tutar = Math.Round(Convert.ToDecimal(f.Tutar), 2),
                            //Tutar=f.Tutar,
                            FaturaNo = f.Makbuzno,
                            Kasa = f.BankaLngKod.Run_(ks =>
                            {
                                switch (f.Tip)
                                {
                                    case 0:
                                        return "";

                                    case 6:
                                        switch (f.Islemtip)
                                        {
                                            case 78:
                                                return "07";

                                            case 79:
                                                return "02";

                                            case 81:
                                                return "06";

                                            case 82:
                                                return "04";

                                            case 80:
                                                return "08";

                                            default:
                                                return f.BankaLngKod.ToString();
                                        }

                                    default:
                                        return f.BankaLngKod.ToString();
                                }
                            }),
                            Aciklama = f.Aciklama,
                            Banka = f.Banka.Run_(bnk =>
                            {
                                switch (f.Tip)
                                {
                                    case 0:
                                        return "";

                                    case 6:
                                        return f.Aciklama;

                                    default:
                                        return f.Banka;
                                }
                            }),

                            HavaleHesapNo = f.Kesideyeri.Run_(hvl => { return hvl ?? ""; }),
                            TemsilciID = f.Stkod,
                            Temsilci = satis.FirstOrDefault(st => st.Stkod2 == f.Stkod).Run_(obj =>
                            {
                                if (obj == null)
                                {
                                    return "";
                                }
                                else
                                {
                                    return obj.Stad;
                                }
                            }),
                            Tarih = f.Islemtarihi,
                            TipID = f.Tip
                        }).OrderBy(o => o.TahsilatID).ToList();

                    if (tahsilatlar.Count > 0)
                    {
                        lblStatus.Caption = $"{tahsilatlar.Count} Adet Kayıt Listelendi.";

                        return tahsilatlar;
                    }
                    else
                    {
                        lblStatus.Caption = "Aktarılmayı Bekleyen Kayıt Yok.";
                        return null;
                    }
                });
                gridControl1.DataSource = asyncTahsilatlar;
                gridView1.BestFitColumns();
                btnNetsiseAktar.Enabled = true;
                btnTahsilatGetir.Enabled = true;
            }
            catch (Exception ex)
            {
                var mesaj = ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += ex.InnerException.InnerException.Message;
                }

                Result = new LogKaydet(true, 1, "btnTahsilatGetir", mesaj, null);
                lblStatus.Caption = "Hata: " + mesaj;
            }
            finally
            {
                PStop();
            }
        }

        private async void BtnNetsiseAktarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var Result = new LogKaydet();
            var dal = new DAL();
            PStart();

            try
            {
                await Task.Factory.StartNew(() =>
                {
                    btnNetsiseAktar.Enabled = false;
                    btnTahsilatGetir.Enabled = false;

                    string tahsilatTipi = "";
                    int aktarilan = 1;
                    var selectedRows = new List<NetsisAktarimModel>();
                    int[] selectedRowHandles = gridView1.GetSelectedRows();
                    for (var i = 0; i < selectedRowHandles.Length; i++)
                    {
                        int selectedRowHandle = selectedRowHandles[i];
                        if (selectedRowHandle >= 0)
                            selectedRows.Add((NetsisAktarimModel)gridView1.GetRow(selectedRowHandle));
                    }
                    foreach (var sRow in selectedRows)
                    {
                        lblAktarimDurumu.Caption = $"({aktarilan} / {selectedRowHandles.Length}) Aktarıldı.";
                        string MusteriUnvan = sRow.Musteri.ToString();
                        var tahsilat = new TahsilatModel()
                        {
                            TahsilatID = sRow.TahsilatID?.ToString(),
                            CariKodu = sRow.MusteriID,
                            FaturaNo = sRow.FaturaNo,
                            Tutar = double.Parse(sRow.Tutar.ToString()),
                            SatisTemsilciKodu = sRow.TemsilciID,
                            Tarih = DateTime.Parse(sRow.Tarih.ToString()),
                        };
                        tahsilat.Aciklama = $"{MusteriUnvan} ({tahsilat.CariKodu})";

                        lblStatus.Caption = $"{tahsilat.TahsilatID} Nolu tahsilat aktarılıyor";
                        string TipID = sRow.TipID?.ToString();
                        var TahsilatKaydet = new Tahsilat();
                        switch (TipID)
                        {
                            case "0":
                                Result = TahsilatKaydet.Nakit(tahsilat);
                                tahsilatTipi = "Nakit";
                                break;

                            case "6":
                                tahsilat.KrediKartiKasaKodu = sRow.Kasa;
                                tahsilat.CHAciklama = sRow.Aciklama;
                                Result = TahsilatKaydet.KrediKarti(tahsilat);
                                tahsilatTipi = "Kredi Kartı";
                                break;

                            case "13":
                                tahsilat.HesapHavaleKod = sRow.HavaleHesapNo;
                                tahsilat.BankaAdi = sRow.Banka;
                                Result = TahsilatKaydet.Havale(tahsilat);
                                tahsilatTipi = "Havale Tahsilat";
                                break;

                            case "14":
                                tahsilat.HesapHavaleKod = sRow.HavaleHesapNo;
                                tahsilat.BankaAdi = sRow.Banka;
                                Result = TahsilatKaydet.HavaleOdeme(tahsilat);
                                tahsilatTipi = "Havale Ödeme";
                                break;
                        }
                        var kaydet = new TblAktarimSonucModel()
                        {
                            Kaynak = "Panorama",
                            Hedef = "Netsis",
                            BelgeMatbu = tahsilat.FaturaNo,
                            Tutar = Convert.ToDecimal(tahsilat.Tutar),
                            BelgeTipi = $"Tahsilat - {tahsilatTipi}",
                            KaynakBelgeID = tahsilat.TahsilatID,
                        };
                        if (!Result.Hatali)
                        {
                            kaydet.IslemTuru = "Sonuc";
                            kaydet.IslemDurumu = "Aktarildi";
                            kaydet.IslemAciklamasi = tahsilat.Aciklama;

                            dal.Kaydet(kaydet);

                            lblStatus.Caption = $"{tahsilat.TahsilatID}  Nolu tahsilat aktarıldı";
                        }
                        else
                        {
                            kaydet.IslemTuru = "Hata";
                            kaydet.IslemDurumu = "Aktarilamadi";
                            kaydet.IslemAciklamasi = Result.Mesaj;

                            dal.Kaydet(kaydet);

                            lblStatus.Caption = Result.Mesaj;
                        }

                        aktarilan++;
                    }
                });
                btnNetsiseAktar.Enabled = true;
                btnTahsilatGetir.Enabled = true;

                btnTahsilatGetir.PerformClick();
            }
            catch (Exception ex)
            {
                string mesaj = ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += ex.InnerException.InnerException.Message;
                }

                Result = new LogKaydet(true, 1, "btnTahsilatListele", mesaj, null);

                lblStatus.Caption = "Hata: " + mesaj;
            }
            finally
            {
                PStop();
            }
        }
    }
}