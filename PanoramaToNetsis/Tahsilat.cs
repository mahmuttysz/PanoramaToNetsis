using NetOpenX50;
using PanoramaToNetsis.Model;
using System;
using System.Runtime.InteropServices;

namespace PanoramaToNetsis
{
    public static class Tahsilat
    {
        public static Result Kredi_Karti(TahsilatModel tahsilat)
        {
            var Result = new Result();
            var kernel = new Kernel();
            var sirket = default(Sirket);
            var kasa = default(Kasa);
            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.NetsisDBDatabase, Ayarlar.NetsisDBUser, Ayarlar.NetsisDBPassword, Ayarlar.NetsisKullaniciAdi, Ayarlar.NetsisSifre, Ayarlar.NetsisSube);
                kasa = kernel.yeniKasa(sirket);

                kasa.KsMas_Kod = tahsilat.KrediKartiKasaKodu;
                kasa.IO = "G";
                kasa.Tip = "C";
                kasa.Kod = tahsilat.CariKodu;
                kasa.Fisno = tahsilat.FaturaNo;
                kasa.Tutar = tahsilat.Tutar;
                kasa.Plasiyer_Kodu = tahsilat.SatisTemsilciKodu;
                kasa.Tarih = tahsilat.Tarih.Date;
                kasa.Aciklama = tahsilat.Aciklama + " (" + tahsilat.CariKodu + ")";
                kasa.CariHareketAciklama = tahsilat.CHAciklama;
                kasa.Islem(TKasaIslem.tkCariOdeme);

                Result = new Result(false, 0, "Tahsilat.Kredi_Karti", tahsilat.TahsilatID + " Nolu kredi kartı tahsilatı aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + kernel.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                Result = new Result(true, 1, "Tahsilat.Kredi_Karti", tahsilat.TahsilatID + " Nolu kredi kartı tahsilatı aktarılamadı. (" + mesaj + ")", null);
            }
            finally
            {
                if (kasa != null)
                    Marshal.ReleaseComObject(kasa);
                if (sirket != null)
                    Marshal.ReleaseComObject(sirket);
                kernel.FreeNetsisLibrary();
                if (kernel != null)
                    Marshal.ReleaseComObject(kernel);
            }
            return Result;
        }

        public static Result Nakit(TahsilatModel tahsilat)
        {
            var Result = new Result();
            var kernel = new Kernel();
            var sirket = default(Sirket);
            var kasa = default(Kasa);
            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.NetsisDBDatabase, Ayarlar.NetsisDBUser, Ayarlar.NetsisDBPassword, Ayarlar.NetsisKullaniciAdi, Ayarlar.NetsisSifre, Ayarlar.NetsisSube);
                kasa = kernel.yeniKasa(sirket);

                kasa.KsMas_Kod = Ayarlar.NetsisNakitKasaKodu;
                kasa.IO = "G";
                kasa.Tip = "C";
                kasa.Kod = tahsilat.CariKodu;
                kasa.Fisno = tahsilat.FaturaNo;
                kasa.Tutar = tahsilat.Tutar;
                kasa.Plasiyer_Kodu = tahsilat.SatisTemsilciKodu;
                kasa.Tarih = tahsilat.Tarih.Date;
                kasa.Aciklama = tahsilat.Aciklama + " (" + tahsilat.CariKodu + ")";
                kasa.Islem(TKasaIslem.tkCariOdeme);
                Result = new Result(false, 0, "Tahsilat.Nakit", tahsilat.TahsilatID + " Nolu nakit tahsilatı aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + kernel.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                Result = new Result(true, 1, "Tahsilat.Nakit", tahsilat.TahsilatID + " Nolu nakit tahsilatı aktarılamadı. (" + mesaj + ")", null);
            }
            finally
            {
                if (kasa != null)
                    Marshal.ReleaseComObject(kasa);
                if (sirket != null)
                    Marshal.ReleaseComObject(sirket);
                kernel.FreeNetsisLibrary();
                if (kernel != null)
                    Marshal.ReleaseComObject(kernel);
            }
            return Result;
        }

        //public static Result Cek(string Cari_Kodu, string Cek_NO, double Tutar, string Satis_Temsilci_Kodu)
        //{
        //    Result Result = new Result();
        //    Kernel kernel = new Kernel();
        //    Sirket sirket = default(Sirket);
        //    Kasa kasa = default(Kasa);
        //    try
        //    {
        //        sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.Netsis_DB_Database, Ayarlar.Netsis_DB_User, Ayarlar.Netsis_DB_Password, Ayarlar.Netsis_Kullanici_Adi, Ayarlar.Netsis_Sifre, Ayarlar.Netsis_Sube);
        //        kasa = kernel.yeniKasa(sirket);
        //        kasa.KsMas_Kod = Ayarlar.Netsis_Cek_Kasa_Kodu;
        //        kasa.IO = "G";
        //        kasa.Tip = "E";
        //        kasa.Fisno = Cek_NO;
        //        kasa.Cari_Muh = "C";
        //        kasa.Kod = Cari_Kodu;
        //        kasa.Plasiyer_Kodu = Satis_Temsilci_Kodu;
        //        kasa.Tarih = DateTime.Today;
        //        kasa.CSKOdeme(TCekSenType.csMCEK);
        //        Result = new Result(false, 0, "Tahsilat.Cek", "Çek tahsilatı Aktarıldı.", null);
        //    }
        //    catch (Exception ex)
        //    {
        //        string mesaj = "Netsis:" + kernel.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
        //        if (ex.InnerException != null)
        //        {
        //            mesaj += " >> " + ex.InnerException.Message;
        //            if (ex.InnerException.InnerException != null)
        //                mesaj += " >> " + ex.InnerException.InnerException.Message;
        //        }
        //        Result = new Result(true, 1, "Tahsilat.Cek", mesaj, null);
        //    }
        //    finally
        //    {
        //        if (kasa != null)
        //            Marshal.ReleaseComObject(kasa);
        //        if (sirket != null)
        //            Marshal.ReleaseComObject(sirket);
        //        kernel.FreeNetsisLibrary();
        //        if (kernel != null)
        //            Marshal.ReleaseComObject(kernel);
        //    }
        //    return Result;
        //}

        //public static Result Senet(string Cari_Kodu, string Senet_NO, double Tutar, string Satis_Temsilci_Kodu)
        //{
        //    Result Result = new Result();
        //    Kernel kernel = new Kernel();
        //    Sirket sirket = default(Sirket);
        //    Kasa kasa = default(Kasa);
        //    try
        //    {
        //        kasa = kernel.yeniKasa(sirket);
        //        kasa.KsMas_Kod = Ayarlar.Netsis_Senet_Kasa_Kodu;
        //        kasa.IO = "G";
        //        kasa.Tip = "S";
        //        kasa.Tutar = Tutar;
        //        kasa.Fisno = Senet_NO;
        //        kasa.Cari_Muh = "C";
        //        kasa.Kod = Cari_Kodu;
        //        kasa.Plasiyer_Kodu = Satis_Temsilci_Kodu;
        //        kasa.Tarih = DateTime.Today;
        //        kasa.CSKOdeme(TCekSenType.csMSEN);
        //        Result = new Result(false, 0, "Tahsilat.Senet", "Senet tahsilatı Aktarıldı.", null);
        //    }
        //    catch (Exception ex)
        //    {
        //        string mesaj = "Netsis:" + kernel.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
        //        if (ex.InnerException != null)
        //        {
        //            mesaj += " >> " + ex.InnerException.Message;
        //            if (ex.InnerException.InnerException != null)
        //                mesaj += " >> " + ex.InnerException.InnerException.Message;
        //        }
        //        Result = new Result(true, 1, "Tahsilat.Senet", mesaj, null);
        //    }
        //    finally
        //    {
        //        if (kasa != null)
        //            Marshal.ReleaseComObject(kasa);
        //        if (sirket != null)
        //            Marshal.ReleaseComObject(sirket);
        //        kernel.FreeNetsisLibrary();
        //        if (kernel != null)
        //            Marshal.ReleaseComObject(kernel);
        //    }
        //    return Result;
        //}

        public static Result Havale(TahsilatModel tahsilat)
        {
            var Result = new Result();
            var kernel = new Kernel();
            var sirket = default(Sirket);
            // Dekomas DekSabit = default(Dekomas);
            var dekontA = default(Dekont);
            var dekontB = default(Dekont);
            var DekSabit = default(Dekomas);

            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.NetsisDBDatabase, Ayarlar.NetsisDBUser, Ayarlar.NetsisDBPassword, Ayarlar.NetsisKullaniciAdi, Ayarlar.NetsisSifre, Ayarlar.NetsisSube);
                string BA = "B";

                DekSabit = kernel.yeniDekomas(sirket);
                int DekontNo = DekSabit.YeniNumaraAl("BH");
                DekSabit.Dekont_No = DekontNo;
                DekSabit.OtoVadeGunu = false;
                dekontA = DekSabit.KalemEkle(TDekontTip.dekCari);
                dekontA.Kod = tahsilat.CariKodu;
                dekontA.C_M = "C";
                dekontA.Fisno = "BH" + DekontNo.ToString();
                dekontA.Aciklama1 = tahsilat.BankaAdi + " Gelen Havale";
                dekontA.ValorGun = 0;
                dekontA.ValorTrh = tahsilat.Tarih.Date;
                dekontA.OtoVadeGunuGetir = false;
                dekontA.DovTL = "T";
                dekontA.Tutar = tahsilat.Tutar;
                dekontA.Tarih = tahsilat.Tarih.Date;

                dekontA.Belge_Tipi = "Banka";
                dekontA.Odeme_Turu = "Havale";
                dekontA.Plasiyer = tahsilat.SatisTemsilciKodu;
                /////////////////////////////////////////////
                dekontB = DekSabit.KalemEkle(TDekontTip.dekBanka);
                dekontB.Kod = tahsilat.HesapHavaleKod;
                dekontB.C_M = "B";
                dekontA.Fisno = "BH" + DekontNo.ToString();
                dekontB.Aciklama1 = tahsilat.Aciklama;
                dekontB.ValorGun = 0;
                dekontB.ValorTrh = tahsilat.Tarih.Date;
                dekontB.OtoVadeGunuGetir = false;
                dekontB.DovTL = "T";
                dekontB.Tutar = tahsilat.Tutar;
                dekontB.Tarih = tahsilat.Tarih.Date;
                dekontB.Belge_Tipi = "Banka";
                dekontB.Odeme_Turu = "Havale";
                dekontB.Plasiyer = tahsilat.SatisTemsilciKodu;
                if (BA == "B")
                {
                    dekontA.B_A = "A";
                    dekontB.B_A = "B";
                }
                else
                {
                    dekontA.B_A = "B";
                    dekontB.B_A = "A";
                }
                DekSabit.Tamamla();

                Result = new Result(false, 0, "Tahsilat.Havale", tahsilat.TahsilatID + " Nolu havale tahsilatı aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + kernel.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                Result = new Result(true, 1, "Tahsilat.Havale", tahsilat.TahsilatID + " Nolu havale tahsilatı aktarılamadı. (" + mesaj + ")", null);
            }
            finally
            {
                if (DekSabit != null)
                    Marshal.ReleaseComObject(DekSabit);
                if (dekontB != null)
                    Marshal.ReleaseComObject(dekontB);
                if (dekontA != null)
                    Marshal.ReleaseComObject(dekontA);
                if (sirket != null)
                    Marshal.ReleaseComObject(sirket);
                kernel.FreeNetsisLibrary();
                if (kernel != null)
                    Marshal.ReleaseComObject(kernel);
            }
            return Result;
        }

        public static Result Havale_Odeme(TahsilatModel tahsilat)
        {
            var Result = new Result();
            var kernel = new Kernel();
            var sirket = default(Sirket);
            // Dekomas DekSabit = default(Dekomas);
            var dekontA = default(Dekont);
            var dekontB = default(Dekont);
            var DekSabit = default(Dekomas);

            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.NetsisDBDatabase, Ayarlar.NetsisDBUser, Ayarlar.NetsisDBPassword, Ayarlar.NetsisKullaniciAdi, Ayarlar.NetsisSifre, Ayarlar.NetsisSube);
                string BA = "C";

                DekSabit = kernel.yeniDekomas(sirket);
                int DekontNo = DekSabit.YeniNumaraAl("BH");
                DekSabit.Dekont_No = DekontNo;
                DekSabit.OtoVadeGunu = false;
                dekontA = DekSabit.KalemEkle(TDekontTip.dekCari);
                dekontA.Kod = tahsilat.CariKodu;
                dekontA.C_M = "C";
                dekontA.OtoVadeGunuGetir = false;
                dekontA.Fisno = "BH" + DekontNo.ToString();
                dekontA.Aciklama1 = tahsilat.BankaAdi + " Giden Havale";
                dekontA.ValorGun = 0;
                dekontA.ValorTrh = tahsilat.Tarih.Date;
                dekontA.DovTL = "T";
                dekontA.Tutar = tahsilat.Tutar;
                dekontA.Tarih = tahsilat.Tarih.Date;
                dekontA.Belge_Tipi = "Banka";
                dekontA.Odeme_Turu = "Havale";
                dekontA.Plasiyer = tahsilat.SatisTemsilciKodu;
                /////////////////////////////////////////////
                dekontB = DekSabit.KalemEkle(TDekontTip.dekBanka);
                dekontB.Kod = tahsilat.HesapHavaleKod;
                dekontB.C_M = "B";
                dekontB.OtoVadeGunuGetir = false;
                dekontA.Fisno = "BH" + DekontNo.ToString();
                dekontB.Aciklama1 = tahsilat.Aciklama;
                dekontB.ValorGun = 0;
                dekontB.ValorTrh = tahsilat.Tarih.Date;
                dekontB.DovTL = "T";
                dekontB.Tutar = tahsilat.Tutar;
                dekontB.Tarih = tahsilat.Tarih.Date;
                dekontB.Belge_Tipi = "Banka";
                dekontB.Odeme_Turu = "Havale";
                dekontB.Plasiyer = tahsilat.SatisTemsilciKodu;
                if (BA == "B")
                {
                    dekontA.B_A = "A";
                    dekontB.B_A = "B";
                }
                else
                {
                    dekontA.B_A = "B";
                    dekontB.B_A = "A";
                }
                DekSabit.Tamamla();

                Result = new Result(false, 0, "Tahsilat.Havale_Odeme", tahsilat.TahsilatID + " Nolu havale ödemesi aktarıldı.", null);
            }
            catch (Exception ex)
            {
                string mesaj = "Netsis:" + kernel.SonNetsisHata.Detay + "\r\n" + "EX: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += " >> " + ex.InnerException.InnerException.Message;
                }
                Result = new Result(true, 1, "Tahsilat.Havale_Odeme", tahsilat.TahsilatID + " Nolu havale ödemesi aktarılamadı. (" + mesaj + ")", null);
            }
            finally
            {
                if (DekSabit != null)
                    Marshal.ReleaseComObject(DekSabit);
                if (dekontB != null)
                    Marshal.ReleaseComObject(dekontB);
                if (dekontA != null)
                    Marshal.ReleaseComObject(dekontA);
                if (sirket != null)
                    Marshal.ReleaseComObject(sirket);
                kernel.FreeNetsisLibrary();
                if (kernel != null)
                    Marshal.ReleaseComObject(kernel);
            }
            return Result;
        }
    }
}