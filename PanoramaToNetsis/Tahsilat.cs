using NetOpenX50;
using System;
using System.Runtime.InteropServices;

namespace PanoramaToNetsis
{
    public static class Tahsilat
    {
        public static Result Kredi_Karti(string Tahsilat_ID, string Kredi_Karti_Kasa_Kodu, string Cari_Kodu, string Fatura_NO, double Tutar, string Satis_Temsilci_Kodu, DateTime Tarih, string Aciklama, string CHAciklama)
        {
            Result Result = new Result();
            Kernel kernel = new Kernel();
            Sirket sirket = default(Sirket);
            Kasa kasa = default(Kasa);
            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.NetsisDBDatabase, Ayarlar.NetsisDBUser, Ayarlar.NetsisDBPassword, Ayarlar.NetsisKullaniciAdi, Ayarlar.NetsisSifre, Ayarlar.NetsisSube);
                kasa = kernel.yeniKasa(sirket);

                kasa.KsMas_Kod = Kredi_Karti_Kasa_Kodu;
                kasa.IO = "G";
                kasa.Tip = "C";
                kasa.Kod = Cari_Kodu;
                kasa.Fisno = Fatura_NO;
                kasa.Tutar = Tutar;
                kasa.Plasiyer_Kodu = Satis_Temsilci_Kodu;
                kasa.Tarih = Tarih.Date;
                kasa.Aciklama = Aciklama + " (" + Cari_Kodu + ")";
                kasa.CariHareketAciklama = CHAciklama;
                kasa.Islem(TKasaIslem.tkCariOdeme);

                Result = new Result(false, 0, "Tahsilat.Kredi_Karti", Tahsilat_ID + " Nolu kredi kartı tahsilatı aktarıldı.", null);
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
                Result = new Result(true, 1, "Tahsilat.Kredi_Karti", Tahsilat_ID + " Nolu kredi kartı tahsilatı aktarılamadı. (" + mesaj + ")", null);
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

        public static Result Nakit(string Tahsilat_ID, string Cari_Kodu, string Fatura_NO, double Tutar, string Satis_Temsilci_Kodu, DateTime Tarih, string Aciklama)
        {
            Result Result = new Result();
            Kernel kernel = new Kernel();
            Sirket sirket = default(Sirket);
            Kasa kasa = default(Kasa);
            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.NetsisDBDatabase, Ayarlar.NetsisDBUser, Ayarlar.NetsisDBPassword, Ayarlar.NetsisKullaniciAdi, Ayarlar.NetsisSifre, Ayarlar.NetsisSube);
                kasa = kernel.yeniKasa(sirket);

                kasa.KsMas_Kod = Ayarlar.NetsisNakitKasaKodu;
                kasa.IO = "G";
                kasa.Tip = "C";
                kasa.Kod = Cari_Kodu;
                kasa.Fisno = Fatura_NO;
                kasa.Tutar = Tutar;
                kasa.Plasiyer_Kodu = Satis_Temsilci_Kodu;
                kasa.Tarih = Tarih.Date;
                kasa.Aciklama = Aciklama + " (" + Cari_Kodu + ")";
                kasa.Islem(TKasaIslem.tkCariOdeme);
                Result = new Result(false, 0, "Tahsilat.Nakit", Tahsilat_ID + " Nolu nakit tahsilatı aktarıldı.", null);
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
                Result = new Result(true, 1, "Tahsilat.Nakit", Tahsilat_ID + " Nolu nakit tahsilatı aktarılamadı. (" + mesaj + ")", null);
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

        public static Result Havale(string Tahsilat_ID, string Cari_Kodu, string Banka_Kodu, string Fatura_NO, double Tutar, string Satis_Temsilci_Kodu, DateTime Tarih, string Aciklama, string Banka_Adi)
        {
            Result Result = new Result();
            Kernel kernel = new Kernel();
            Sirket sirket = default(Sirket);
            // Dekomas DekSabit = default(Dekomas);
            Dekont dekontA = default(Dekont);
            Dekont dekontB = default(Dekont);
            Dekomas DekSabit = default(Dekomas);

            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.NetsisDBDatabase, Ayarlar.NetsisDBUser, Ayarlar.NetsisDBPassword, Ayarlar.NetsisKullaniciAdi, Ayarlar.NetsisSifre, Ayarlar.NetsisSube);
                string BA = "B";

                DekSabit = kernel.yeniDekomas(sirket);
                int DekontNo = DekSabit.YeniNumaraAl("BH");
                DekSabit.Dekont_No = DekontNo;
                DekSabit.OtoVadeGunu = false;
                dekontA = DekSabit.KalemEkle(TDekontTip.dekCari);
                dekontA.Kod = Cari_Kodu;
                dekontA.C_M = "C";
                dekontA.Fisno = "BH" + DekontNo.ToString();
                dekontA.Aciklama1 = Banka_Adi + " Gelen Havale";
                dekontA.ValorGun = 0;
                dekontA.ValorTrh = Tarih.Date;
                dekontA.OtoVadeGunuGetir = false;
                dekontA.DovTL = "T";
                dekontA.Tutar = Tutar;
                dekontA.Tarih = Tarih.Date;

                dekontA.Belge_Tipi = "Banka";
                dekontA.Odeme_Turu = "Havale";
                dekontA.Plasiyer = Satis_Temsilci_Kodu;
                /////////////////////////////////////////////
                dekontB = DekSabit.KalemEkle(TDekontTip.dekBanka);
                dekontB.Kod = Banka_Kodu;
                dekontB.C_M = "B";
                dekontA.Fisno = "BH" + DekontNo.ToString();
                dekontB.Aciklama1 = Aciklama;
                dekontB.ValorGun = 0;
                dekontB.ValorTrh = Tarih.Date;
                dekontB.OtoVadeGunuGetir = false;
                dekontB.DovTL = "T";
                dekontB.Tutar = Tutar;
                dekontB.Tarih = Tarih.Date;
                dekontB.Belge_Tipi = "Banka";
                dekontB.Odeme_Turu = "Havale";
                dekontB.Plasiyer = Satis_Temsilci_Kodu;
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

                Result = new Result(false, 0, "Tahsilat.Havale", Tahsilat_ID + " Nolu havale tahsilatı aktarıldı.", null);
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
                Result = new Result(true, 1, "Tahsilat.Havale", Tahsilat_ID + " Nolu havale tahsilatı aktarılamadı. (" + mesaj + ")", null);
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

        public static Result Havale_Odeme(string Tahsilat_ID, string Cari_Kodu, string Banka_Kodu, string Fatura_NO, double Tutar, string Satis_Temsilci_Kodu, DateTime Tarih, string Aciklama, string Banka_Adi)
        {
            Result Result = new Result();
            Kernel kernel = new Kernel();
            Sirket sirket = default(Sirket);
            // Dekomas DekSabit = default(Dekomas);
            Dekont dekontA = default(Dekont);
            Dekont dekontB = default(Dekont);
            Dekomas DekSabit = default(Dekomas);

            try
            {
                sirket = kernel.yeniSirket(TVTTipi.vtMSSQL, Ayarlar.NetsisDBDatabase, Ayarlar.NetsisDBUser, Ayarlar.NetsisDBPassword, Ayarlar.NetsisKullaniciAdi, Ayarlar.NetsisSifre, Ayarlar.NetsisSube);
                string BA = "C";

                DekSabit = kernel.yeniDekomas(sirket);
                int DekontNo = DekSabit.YeniNumaraAl("BH");
                DekSabit.Dekont_No = DekontNo;
                DekSabit.OtoVadeGunu = false;
                dekontA = DekSabit.KalemEkle(TDekontTip.dekCari);
                dekontA.Kod = Cari_Kodu;
                dekontA.C_M = "C";
                dekontA.OtoVadeGunuGetir = false;
                dekontA.Fisno = "BH" + DekontNo.ToString();
                dekontA.Aciklama1 = Banka_Adi + " Giden Havale";
                dekontA.ValorGun = 0;
                dekontA.ValorTrh = Tarih.Date;
                dekontA.DovTL = "T";
                dekontA.Tutar = Tutar;
                dekontA.Tarih = Tarih.Date;
                dekontA.Belge_Tipi = "Banka";
                dekontA.Odeme_Turu = "Havale";
                dekontA.Plasiyer = Satis_Temsilci_Kodu;
                /////////////////////////////////////////////
                dekontB = DekSabit.KalemEkle(TDekontTip.dekBanka);
                dekontB.Kod = Banka_Kodu;
                dekontB.C_M = "B";
                dekontB.OtoVadeGunuGetir = false;
                dekontA.Fisno = "BH" + DekontNo.ToString();
                dekontB.Aciklama1 = Aciklama;
                dekontB.ValorGun = 0;
                dekontB.ValorTrh = Tarih.Date;
                dekontB.DovTL = "T";
                dekontB.Tutar = Tutar;
                dekontB.Tarih = Tarih.Date;
                dekontB.Belge_Tipi = "Banka";
                dekontB.Odeme_Turu = "Havale";
                dekontB.Plasiyer = Satis_Temsilci_Kodu;
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

                Result = new Result(false, 0, "Tahsilat.Havale_Odeme", Tahsilat_ID + " Nolu havale ödemesi aktarıldı.", null);
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
                Result = new Result(true, 1, "Tahsilat.Havale_Odeme", Tahsilat_ID + " Nolu havale ödemesi aktarılamadı. (" + mesaj + ")", null);
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