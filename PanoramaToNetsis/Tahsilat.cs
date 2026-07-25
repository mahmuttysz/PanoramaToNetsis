using NetOpenX50;
using PanoramaToNetsis.Models;
using System;
using System.Runtime.InteropServices;

namespace PanoramaToNetsis
{
    public class Tahsilat
    {
        public static ParametreAyarlariModel ParametreAyarlari { get; set; }
        private static LogKaydet LogKaydetParam { get; set; }
        private static SirketAyarModel SirketAyarParam { get; set; }
        private static Kernel KernelParam { get; set; }
        private static Sirket SirketParam { get; set; }
        private static Kasa KasaParam { get; set; }
        private static Dekont DekontAParam { get; set; }
        private static Dekont DekontBParam { get; set; }
        private static Dekomas DekomasParam { get; set; }

        public Tahsilat()
        {
            var ParametreAyarlar = new ParametreAyarlari();
            ParametreAyarlari = ParametreAyarlar.Getir();
            SirketAyarParam = new SirketAyarModel()
            {
                TVTTipi = TVTTipi.vtMSSQL,
                NetsisDBDatabase = ParametreAyarlari.NetsisDBDatabase,
                NetsisDBPassword = ParametreAyarlari.NetsisDBPassword,
                NetsisDBUser = ParametreAyarlari.NetsisDBUser,
                NetsisKullaniciAdi = ParametreAyarlari.NetsisKullaniciAdi,
                NetsisSifre = ParametreAyarlari.NetsisSifre,
                NetsisSube = ParametreAyarlari.NetsisSube,
            };
            LogKaydetParam = new LogKaydet();
            KernelParam = new Kernel();
            SirketParam = default;
            SirketParam = KernelParam.yeniSirket(SirketAyarParam.TVTTipi, SirketAyarParam.NetsisDBDatabase, SirketAyarParam.NetsisDBUser, SirketAyarParam.NetsisDBPassword, SirketAyarParam.NetsisKullaniciAdi, SirketAyarParam.NetsisSifre, SirketAyarParam.NetsisSube);
        }

        public LogKaydet KrediKarti(TahsilatModel tahsilat)
        {
            KasaParam = default;
            KasaParam = KernelParam.yeniKasa(SirketParam);
            try
            {
                KasaParam.KsMas_Kod = tahsilat.KrediKartiKasaKodu;
                KasaParam.IO = "G";
                KasaParam.Tip = "C";
                KasaParam.Kod = tahsilat.CariKodu;
                KasaParam.Fisno = tahsilat.FaturaNo;
                KasaParam.Tutar = tahsilat.Tutar;
                KasaParam.Plasiyer_Kodu = tahsilat.SatisTemsilciKodu;
                KasaParam.Tarih = tahsilat.Tarih.Date;
                KasaParam.Aciklama = tahsilat.Aciklama + " (" + tahsilat.CariKodu + ")";
                KasaParam.CariHareketAciklama = tahsilat.CHAciklama;
                KasaParam.Islem(TKasaIslem.tkCariOdeme);

                LogKaydetParam = new LogKaydet(false, 0, "Tahsilat.Kredi_Karti", tahsilat.TahsilatID + " Nolu kredi kartı tahsilatı aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + KernelParam.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                LogKaydetParam = new LogKaydet(true, 1, "Tahsilat.Kredi_Karti", tahsilat.TahsilatID + " Nolu kredi kartı tahsilatı aktarılamadı. (" + mesaj + ")", null);
            }
            finally
            {
                if (KasaParam != null)
                    Marshal.ReleaseComObject(KasaParam);
                if (SirketParam != null)
                    Marshal.ReleaseComObject(SirketParam);
                KernelParam.FreeNetsisLibrary();
                if (KernelParam != null)
                    Marshal.ReleaseComObject(KernelParam);
            }
            return LogKaydetParam;
        }

        public LogKaydet Nakit(TahsilatModel tahsilat)
        {
            KasaParam = KernelParam.yeniKasa(SirketParam);
            try
            {
                KasaParam.KsMas_Kod = ParametreAyarlari.NetsisNakitKasaKodu;
                KasaParam.IO = "G";
                KasaParam.Tip = "C";
                KasaParam.Kod = tahsilat.CariKodu;
                KasaParam.Fisno = tahsilat.FaturaNo;
                KasaParam.Tutar = tahsilat.Tutar;
                KasaParam.Plasiyer_Kodu = tahsilat.SatisTemsilciKodu;
                KasaParam.Tarih = tahsilat.Tarih.Date;
                KasaParam.Aciklama = tahsilat.Aciklama + " (" + tahsilat.CariKodu + ")";
                KasaParam.Islem(TKasaIslem.tkCariOdeme);
                LogKaydetParam = new LogKaydet(false, 0, "Tahsilat.Nakit", tahsilat.TahsilatID + " Nolu nakit tahsilatı aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + KernelParam.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                LogKaydetParam = new LogKaydet(true, 1, "Tahsilat.Nakit", tahsilat.TahsilatID + " Nolu nakit tahsilatı aktarılamadı. (" + mesaj + ")", null);
            }
            finally
            {
                if (KasaParam != null)
                    Marshal.ReleaseComObject(KasaParam);
                if (SirketParam != null)
                    Marshal.ReleaseComObject(SirketParam);
                KernelParam.FreeNetsisLibrary();
                if (KernelParam != null)
                    Marshal.ReleaseComObject(KernelParam);
            }
            return LogKaydetParam;
        }

        public LogKaydet Cek(TahsilatModel tahsilat)
        {
            KasaParam = default;
          
            try
            {
                KasaParam = KernelParam.yeniKasa(SirketParam);
                KasaParam.KsMas_Kod = ParametreAyarlari.NetsisCekKasaKodu;
                KasaParam.IO = "G";
                KasaParam.Tip = "E";
                KasaParam.Fisno = tahsilat.CekNo;
                KasaParam.Cari_Muh = "C";
                KasaParam.Kod = tahsilat.CariKodu;
                KasaParam.Plasiyer_Kodu = tahsilat.SatisTemsilciKodu;
                KasaParam.Tarih = DateTime.Today;
                KasaParam.CSKOdeme(TCekSenType.csMCEK);
                LogKaydetParam = new LogKaydet(false, 0, "Tahsilat.Cek", "Çek tahsilatı Aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + KernelParam.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                LogKaydetParam = new LogKaydet(true, 1, "Tahsilat.Cek", mesaj, null);
            }
            finally
            {
                if (KasaParam != null)
                    Marshal.ReleaseComObject(KasaParam);
                if (SirketParam != null)
                    Marshal.ReleaseComObject(SirketParam);
                KernelParam.FreeNetsisLibrary();
                if (KernelParam != null)
                    Marshal.ReleaseComObject(KernelParam);
            }
            return LogKaydetParam;
        }

        public LogKaydet Senet(TahsilatModel tahsilat)
        {

            KasaParam = default;
            
            try
            {
                KasaParam = KernelParam.yeniKasa(SirketParam);
                KasaParam.KsMas_Kod = ParametreAyarlari.NetsisSenetKasaKodu;
                KasaParam.IO = "G";
                KasaParam.Tip = "S";
                KasaParam.Tutar = tahsilat.Tutar;
                KasaParam.Fisno = tahsilat.SenetNo;
                KasaParam.Cari_Muh = "C";
                KasaParam.Kod = tahsilat.CariKodu;
                KasaParam.Plasiyer_Kodu = tahsilat.SatisTemsilciKodu;
                KasaParam.Tarih = DateTime.Today;
                KasaParam.CSKOdeme(TCekSenType.csMSEN);
                LogKaydetParam = new LogKaydet(false, 0, "Tahsilat.Senet", "Senet tahsilatı Aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + KernelParam.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                LogKaydetParam = new LogKaydet(true, 1, "Tahsilat.Senet", mesaj, null);
            }
            finally
            {
                if (KasaParam != null)
                    Marshal.ReleaseComObject(KasaParam);
                if (SirketParam != null)
                    Marshal.ReleaseComObject(SirketParam);
                KernelParam.FreeNetsisLibrary();
                if (KernelParam != null)
                    Marshal.ReleaseComObject(KernelParam);
            }
            return LogKaydetParam;
        }

        public LogKaydet Havale(TahsilatModel tahsilat)
        {
           
            DekontAParam = default;
            DekontBParam = default;
            DekomasParam = default;

            try
            {
                string BA = "B";

                DekomasParam = KernelParam.yeniDekomas(SirketParam);
                int DekontNo = DekomasParam.YeniNumaraAl("BH");
                DekomasParam.Dekont_No = DekontNo;
                DekomasParam.OtoVadeGunu = false;
                DekontAParam = DekomasParam.KalemEkle(TDekontTip.dekCari);
                DekontAParam.Kod = tahsilat.CariKodu;
                DekontAParam.C_M = "C";
                DekontAParam.Fisno = "BH" + DekontNo.ToString();
                DekontAParam.Aciklama1 = tahsilat.BankaAdi + " Gelen Havale";
                DekontAParam.ValorGun = 0;
                DekontAParam.ValorTrh = tahsilat.Tarih.Date;
                DekontAParam.OtoVadeGunuGetir = false;
                DekontAParam.DovTL = "T";
                DekontAParam.Tutar = tahsilat.Tutar;
                DekontAParam.Tarih = tahsilat.Tarih.Date;
                DekontAParam.Belge_Tipi = "Banka";
                DekontAParam.Odeme_Turu = "Havale";
                DekontAParam.Plasiyer = tahsilat.SatisTemsilciKodu;
                /////////////////////////////////////////////
                DekontBParam = DekomasParam.KalemEkle(TDekontTip.dekBanka);
                DekontBParam.Kod = tahsilat.HesapHavaleKod;
                DekontBParam.C_M = "B";
                DekontBParam.Fisno = "BH" + DekontNo.ToString();
                DekontBParam.Aciklama1 = tahsilat.Aciklama;
                DekontBParam.ValorGun = 0;
                DekontBParam.ValorTrh = tahsilat.Tarih.Date;
                DekontBParam.OtoVadeGunuGetir = false;
                DekontBParam.DovTL = "T";
                DekontBParam.Tutar = tahsilat.Tutar;
                DekontBParam.Tarih = tahsilat.Tarih.Date;
                DekontBParam.Belge_Tipi = "Banka";
                DekontBParam.Odeme_Turu = "Havale";
                DekontBParam.Plasiyer = tahsilat.SatisTemsilciKodu;
                if (BA == "B")
                {
                    DekontAParam.B_A = "A";
                    DekontBParam.B_A = "B";
                }
                else
                {
                    DekontAParam.B_A = "B";
                    DekontBParam.B_A = "A";
                }
                DekomasParam.Tamamla();

                LogKaydetParam = new LogKaydet(false, 0, "Tahsilat.Havale", tahsilat.TahsilatID + " Nolu havale tahsilatı aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + KernelParam.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                LogKaydetParam = new LogKaydet(true, 1, "Tahsilat.Havale", tahsilat.TahsilatID + " Nolu havale tahsilatı aktarılamadı. (" + mesaj + ")", null);
            }
            finally
            {
                if (DekomasParam != null)
                    Marshal.ReleaseComObject(DekomasParam);
                if (DekontBParam != null)
                    Marshal.ReleaseComObject(DekontBParam);
                if (DekontAParam != null)
                    Marshal.ReleaseComObject(DekontAParam);
                if (SirketParam != null)
                    Marshal.ReleaseComObject(SirketParam);
                KernelParam.FreeNetsisLibrary();
                if (KernelParam != null)
                    Marshal.ReleaseComObject(KernelParam);
            }
            return LogKaydetParam;
        }

        public LogKaydet HavaleOdeme(TahsilatModel tahsilat)
        {
          
            DekontAParam = default;
            DekontBParam = default;
            DekomasParam = default;

            try
            {
                string BA = "C";

                DekomasParam = KernelParam.yeniDekomas(SirketParam);
                int DekontNo = DekomasParam.YeniNumaraAl("BH");
                DekomasParam.Dekont_No = DekontNo;
                DekomasParam.OtoVadeGunu = false;

                DekontAParam = DekomasParam.KalemEkle(TDekontTip.dekCari);
                DekontAParam.Kod = tahsilat.CariKodu;
                DekontAParam.C_M = "C";
                DekontAParam.OtoVadeGunuGetir = false;
                DekontAParam.Fisno = "BH" + DekontNo.ToString();
                DekontAParam.Aciklama1 = tahsilat.BankaAdi + " Giden Havale";
                DekontAParam.ValorGun = 0;
                DekontAParam.ValorTrh = tahsilat.Tarih.Date;
                DekontAParam.DovTL = "T";
                DekontAParam.Tutar = tahsilat.Tutar;
                DekontAParam.Tarih = tahsilat.Tarih.Date;
                DekontAParam.Belge_Tipi = "Banka";
                DekontAParam.Odeme_Turu = "Havale";
                DekontAParam.Plasiyer = tahsilat.SatisTemsilciKodu;
                /////////////////////////////////////////////
                DekontBParam = DekomasParam.KalemEkle(TDekontTip.dekBanka);
                DekontBParam.Kod = tahsilat.HesapHavaleKod;
                DekontBParam.C_M = "B";
                DekontBParam.OtoVadeGunuGetir = false;
                DekontBParam.Fisno = "BH" + DekontNo.ToString();
                DekontBParam.Aciklama1 = tahsilat.Aciklama;
                DekontBParam.ValorGun = 0;
                DekontBParam.ValorTrh = tahsilat.Tarih.Date;
                DekontBParam.DovTL = "T";
                DekontBParam.Tutar = tahsilat.Tutar;
                DekontBParam.Tarih = tahsilat.Tarih.Date;
                DekontBParam.Belge_Tipi = "Banka";
                DekontBParam.Odeme_Turu = "Havale";
                DekontBParam.Plasiyer = tahsilat.SatisTemsilciKodu;
                if (BA == "B")
                {
                    DekontAParam.B_A = "A";
                    DekontBParam.B_A = "B";
                }
                else
                {
                    DekontAParam.B_A = "B";
                    DekontBParam.B_A = "A";
                }
                DekomasParam.Tamamla();

                LogKaydetParam = new LogKaydet(false, 0, "Tahsilat.Havale_Odeme", tahsilat.TahsilatID + " Nolu havale ödemesi aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + KernelParam.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                LogKaydetParam = new LogKaydet(true, 1, "Tahsilat.Havale_Odeme", tahsilat.TahsilatID + " Nolu havale ödemesi aktarılamadı. (" + mesaj + ")", null);
            }
            finally
            {
                if (DekomasParam != null)
                    Marshal.ReleaseComObject(DekomasParam);
                if (DekontBParam != null)
                    Marshal.ReleaseComObject(DekontBParam);
                if (DekontAParam != null)
                    Marshal.ReleaseComObject(DekontAParam);
                if (SirketParam != null)
                    Marshal.ReleaseComObject(SirketParam);
                KernelParam.FreeNetsisLibrary();
                if (KernelParam != null)
                    Marshal.ReleaseComObject(KernelParam);
            }
            return LogKaydetParam;
        }
    }
}