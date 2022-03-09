using PanoramaToNetsis.Models;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PanoramaToNetsis
{
    public class ParametreAyarlari
    {
        private static readonly string DosyaYolu = Application.StartupPath + "\\ParametreAyarlari.ini";
        public static ParametreAyarlariModel Parametre { get; set; }

        public ParametreAyarlari()
        {
            Parametre = new ParametreAyarlariModel();
        }
        

        public void Kaydet()
        {
            if (!File.Exists(DosyaYolu))
            {
                var Dosya = File.Create(DosyaYolu);
                Dosya.Close();
            }

            Parametre.NetsisDBUser = Parametre.NetsisDBUser ?? "";
            Parametre.NetsisDBPassword = Parametre.NetsisDBPassword ?? "";
            Parametre.NetsisDBDatabase = Parametre.NetsisDBDatabase ?? "";
            Parametre.NetsisKullaniciAdi = Parametre.NetsisKullaniciAdi ?? "";
            Parametre.NetsisSifre = Parametre.NetsisSifre ?? "";
            Parametre.NetsisNakitKasaKodu = Parametre.NetsisNakitKasaKodu ?? "";
            Parametre.NetsisCekKasaKodu = Parametre.NetsisCekKasaKodu ?? "";
            Parametre.NetsisSenetKasaKodu = Parametre.NetsisSenetKasaKodu ?? "";

            Parametre.WebServiceUrl = Parametre.WebServiceUrl ?? "";
            Parametre.WebServiceUser = Parametre.WebServiceUser ?? "";
            Parametre.WebServicePassword = Parametre.WebServicePassword ?? "";
            if (Parametre.WebServiceDistKod == null || Parametre.WebServiceDistKod == "")
                Parametre.WebServiceDistKod = "1";
            if (Parametre.WebServiceCalismaYili == null || Parametre.WebServiceCalismaYili == "")
                Parametre.WebServiceCalismaYili = DateTime.Now.Year.ToString();
            if (Parametre.WebServiceFirmaKod == null || Parametre.WebServiceFirmaKod == "")
                Parametre.WebServiceFirmaKod = "1";

            Parametre.LogServer = Parametre.LogServer ?? "";
            Parametre.LogKullaniciAdi = Parametre.LogKullaniciAdi ?? "";
            Parametre.LogSifre = Parametre.LogSifre ?? "";
            Parametre.LogDB = Parametre.LogDB ?? "";

            var sb = new StringBuilder();

            sb.AppendLine("NetsisDBUser=" + Parametre.NetsisDBUser);
            sb.AppendLine("NetsisDBPassword=" + Parametre.NetsisDBPassword);
            sb.AppendLine("NetsisDBDatabase=" + Parametre.NetsisDBDatabase);
            sb.AppendLine("NetsisKullaniciAdi=" + Parametre.NetsisKullaniciAdi);
            sb.AppendLine("NetsisSifre=" + Parametre.NetsisSifre.ToString());
            sb.AppendLine("NetsisSube=" + Parametre.NetsisSube.ToString());
            sb.AppendLine("NetsisNakitKasaKodu=" + Parametre.NetsisNakitKasaKodu);
            sb.AppendLine("NetsisCekKasaKodu=" + Parametre.NetsisCekKasaKodu);
            sb.AppendLine("NetsisSenetKasaKodu=" + Parametre.NetsisSenetKasaKodu);

            sb.AppendLine("WebServiceUrl=" + Parametre.WebServiceUrl);
            sb.AppendLine("WebServiceUser=" + Parametre.WebServiceUser);
            sb.AppendLine("WebServicePassword=" + Parametre.WebServicePassword);
            sb.AppendLine("WebServiceDistKod=" + Parametre.WebServiceDistKod);
            sb.AppendLine("WebServiceCalismaYili=" + Parametre.WebServiceCalismaYili);
            sb.AppendLine("WebServiceFirmaKod=" + Parametre.WebServiceFirmaKod);

            sb.AppendLine("LogServer=" + Parametre.LogServer);
            sb.AppendLine("LogKullaniciAdi=" + Parametre.LogKullaniciAdi);
            sb.AppendLine("LogSifre=" + Parametre.LogSifre);
            sb.AppendLine("LogDB=" + Parametre.LogDB);

            File.WriteAllText(DosyaYolu, sb.ToString());
        }

        public ParametreAyarlariModel Getir()
        {
            if (!File.Exists(DosyaYolu))
            {
                Kaydet();
            }
            var Satirlar = File.ReadAllLines(DosyaYolu);
            foreach (string Satir in Satirlar)
            {
                switch (Satir.Split('=')[0])
                {
                    case "NetsisDBUser":
                        Parametre.NetsisDBUser = Satir.Split('=')[1];
                        break;

                    case "NetsisDBPassword":
                        Parametre.NetsisDBPassword = Satir.Split('=')[1];
                        break;

                    case "NetsisDBDatabase":
                        Parametre.NetsisDBDatabase = Satir.Split('=')[1];
                        break;

                    case "NetsisKullaniciAdi":
                        Parametre.NetsisKullaniciAdi = Satir.Split('=')[1];
                        break;

                    case "NetsisSifre":
                        Parametre.NetsisSifre = Satir.Split('=')[1];
                        break;

                    case "NetsisSube":
                        Parametre.NetsisSube = int.Parse(Satir.Split('=')[1]);
                        break;

                    case "NetsisNakitKasaKodu":
                        Parametre.NetsisNakitKasaKodu = Satir.Split('=')[1];
                        break;

                    case "NetsisCekKasaKodu":
                        Parametre.NetsisCekKasaKodu = Satir.Split('=')[1];
                        break;

                    case "NetsisSenetKasaKodu":
                        Parametre.NetsisSenetKasaKodu = Satir.Split('=')[1];
                        break;

                    case "WebServiceUrl":
                        Parametre.WebServiceUrl = Satir.Split('=')[1];
                        break;

                    case "WebServiceUser":
                        Parametre.WebServiceUser = Satir.Split('=')[1];
                        break;

                    case "WebServicePassword":
                        Parametre.WebServicePassword = Satir.Split('=')[1];
                        break;

                    case "WebServiceDistKod":
                        Parametre.WebServiceDistKod = Satir.Split('=')[1];
                        break;

                    case "WebServiceCalismaYili":
                        Parametre.WebServiceCalismaYili = Satir.Split('=')[1];
                        break;

                    case "WebServiceFirmaKod":
                        Parametre.WebServiceFirmaKod = Satir.Split('=')[1];
                        break;

                    case "LogServer":
                        Parametre.LogServer = Satir.Split('=')[1];
                        break;

                    case "LogKullaniciAdi":
                        Parametre.LogKullaniciAdi = Satir.Split('=')[1];
                        break;

                    case "LogSifre":
                        Parametre.LogSifre = Satir.Split('=')[1];
                        break;

                    case "LogDB":
                        Parametre.LogDB = Satir.Split('=')[1];
                        break;
                }
            }
            return Parametre;
        }
    }
}