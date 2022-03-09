using PanoramaToNetsis.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PanoramaToNetsis
{
    public class DAL
    {
        public SqlConnection baglanti;

        public DAL()
        {
            try
            {
                var parametreAyarlari = new ParametreAyarlari();
                var parametreler = parametreAyarlari.Getir();
                baglanti = new SqlConnection($"Data Source={parametreler.LogServer};Initial Catalog={parametreler.LogDB};User Id={parametreler.LogKullaniciAdi};Password={parametreler.LogSifre};");

                baglanti.Open();
            }
            catch (Exception e)
            {
                string mesaj = e.ToString();
                new LogKaydet(true, 1, "SQLBaglanti", mesaj, null);
                baglanti.Close();
            }
        }

        public void Kaydet(TblAktarimSonucModel save)
        {
            try
            {
                var insert = new SqlCommand
                {
                    CommandText =
                    "INSERT INTO TblPanServiceAktarimSonucIzleme(Kaynak,Hedef,BelgeMatbu,IslemTuru,Tutar,BelgeTipi,BelgeTarihi,KaynakBelgeID,IslemDurumu,IslemAciklamasi) VALUES(@Kaynak,@Hedef,@BelgeMatbu,@IslemTuru,@Tutar,@BelgeTipi,@BelgeTarihi,@KaynakBelgeID,@IslemDurumu,@IslemAciklamasi)",
                    Connection = baglanti
                };
                insert.Parameters.AddWithValue("@Kaynak", save.Kaynak);
                insert.Parameters.AddWithValue("@Hedef", save.Hedef);
                insert.Parameters.AddWithValue("@BelgeMatbu", save.BelgeMatbu);
                insert.Parameters.AddWithValue("@IslemTuru", save.IslemTuru);
                insert.Parameters.AddWithValue("@Tutar", save.Tutar);
                insert.Parameters.AddWithValue("@BelgeTipi", save.BelgeTipi);
                insert.Parameters.AddWithValue("@BelgeTarihi", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                insert.Parameters.AddWithValue("@KaynakBelgeID", save.KaynakBelgeID);
                insert.Parameters.AddWithValue("@IslemDurumu", save.IslemDurumu);
                insert.Parameters.AddWithValue("@IslemAciklamasi", save.IslemAciklamasi);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string mesaj = e.ToString();
                new LogKaydet(true, 1, "NetsisAktarim", mesaj, null);
            }
        }

        public List<AktarimListModel> Aktarilanlar()
        {
            try
            {
                var aktarilanlar = new SqlCommand
                {
                    CommandText =
                    "SELECT * FROM TblPanServiceAktarimSonucIzleme WHERE IslemDurumu='Aktarildi'",
                    Connection = baglanti
                };

                var drAktarilanlar = aktarilanlar.ExecuteReader();
                var aktarimLists = new List<AktarimListModel>();

                while (drAktarilanlar.Read())
                {
                    var aktarimList = new AktarimListModel
                    {
                        TahsilatID = drAktarilanlar["KaynakBelgeID"].ToString(),
                        Aktarildi = drAktarilanlar["IslemDurumu"].ToString(),
                        Tarih = drAktarilanlar["BelgeTarihi"].ToString()
                    };
                    aktarimLists.Add(aktarimList);
                }

                return aktarimLists;
            }
            catch (Exception e)
            {
                string mesaj = e.ToString();
                new LogKaydet(true, 1, "NetsisAktarim", mesaj, null);
                return null;
            }
        }

        public void SonucDegistir(int ID)
        {
            try
            {
                var update = new SqlCommand
                {
                    CommandText =
                    "UPDATE TblPanServiceAktarimSonucIzleme SET SimdikiIslem=@SimdikiIslem WHERE ID=@ID",
                    Connection = baglanti
                };
                update.Parameters.AddWithValue("@ID", ID);
                update.Parameters.AddWithValue("@SimdikiIslem", 0);
                update.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string mesaj = e.ToString();
                new LogKaydet(true, 1, "NetsisAktarimHataLog", mesaj, null);
            }
        }

        public List<AktarimSonucListModel> AktarimSonuc(string baslangicTarihi, string bitisTarihi)
        {
            try
            {
                var aktarimSonucu = new SqlCommand
                {
                    CommandText = $"SELECT * FROM TblPanServiceAktarimSonucIzleme WHERE BelgeTarihi BETWEEN '{baslangicTarihi}' AND '{bitisTarihi}' ORDER BY BelgeTarihi DESC",
                    Connection = baglanti
                };

                var drAktarimSonuc = aktarimSonucu.ExecuteReader();

                var aktarimSonucLists = new List<AktarimSonucListModel>();
                int i = 1;
                while (drAktarimSonuc.Read())
                {
                    var aktarimSonucList = new AktarimSonucListModel
                    {
                        Sira = i,
                        TahsilatID = drAktarimSonuc["KaynakBelgeID"].ToString(),
                        BelgeTipi = drAktarimSonuc["BelgeTipi"].ToString(),
                        Tutar = Convert.ToDecimal(drAktarimSonuc["Tutar"]),
                        Aktarildi = drAktarimSonuc["IslemDurumu"].ToString(),
                        Aciklama = drAktarimSonuc["IslemAciklamasi"].ToString(),
                        Tarih = ((DateTime)drAktarimSonuc["BelgeTarihi"]).ToString()
                    };
                    aktarimSonucLists.Add(aktarimSonucList);
                    i++;
                }
                return aktarimSonucLists;
            }
            catch (Exception e)
            {
                string mesaj = e.ToString();
                new LogKaydet(true, 1, "NetsisAktarimSonuc", mesaj, null);
                return null;
            }
        }
    }
}