using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PanoramaToNetsis
{
    public static class Ayarlar
    {
        private static readonly string DosyaYolu = Application.StartupPath + "\\Ayarlar.ini";

        public static string NetsisDBUser { get; set; }
        public static string NetsisDBPassword { get; set; }
        public static string NetsisDBDatabase { get; set; }
        public static string NetsisKullaniciAdi { get; set; }
        public static string NetsisSifre { get; set; }
        public static int NetsisSube { get; set; }
        public static string NetsisNakitKasaKodu { get; set; }
        public static string NetsisCekKasaKodu { get; set; }
        public static string NetsisSenetKasaKodu { get; set; }

        public static string WebServiceUrl { get; set; }
        public static string WebServiceUser { get; set; }
        public static string WebServicePassword { get; set; }
        public static string WebServiceCalismaYili { get; set; }
        public static string WebServiceDistKod { get; set; }
        public static string WebServiceFirmaKod { get; set; }

        public static string LogServer { get; set; }
        public static string LogKullaniciAdi { get; set; }
        public static string LogSifre { get; set; }
        public static string LogDB { get; set; }

        public static void Kaydet()
        {
            if (!File.Exists(DosyaYolu))
            {
                var Dosya = File.Create(DosyaYolu);
                Dosya.Close();
            }

            if (NetsisDBUser == null)
                NetsisDBUser = "";
            if (NetsisDBPassword == null)
                NetsisDBPassword = "";
            if (NetsisDBDatabase == null)
                NetsisDBDatabase = "";
            if (NetsisKullaniciAdi == null)
                NetsisKullaniciAdi = "";
            if (NetsisSifre == null)
                NetsisSifre = "";
            if (NetsisNakitKasaKodu == null)
                NetsisNakitKasaKodu = "";
            if (NetsisCekKasaKodu == null)
                NetsisCekKasaKodu = "";
            if (NetsisSenetKasaKodu == null)
                NetsisSenetKasaKodu = "";

            if (WebServiceUrl == null)
                WebServiceUrl = "";
            if (WebServiceUser == null)
                WebServiceUser = "";
            if (WebServicePassword == null)
                WebServicePassword = "";
            if (WebServiceDistKod == null || WebServiceDistKod == "")
                WebServiceDistKod = "216";
            if (WebServiceCalismaYili == null || WebServiceCalismaYili == "")
                WebServiceCalismaYili = "2022";
            if (WebServiceFirmaKod == null || WebServiceFirmaKod == "")
                WebServiceFirmaKod = "1";

            if (LogServer == null)
                LogServer = "";
            if (LogKullaniciAdi == null)
                LogKullaniciAdi = "";
            if (LogSifre == null)
                LogSifre = "";
            if (LogDB == null)
                LogDB = "";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NetsisDBUser=" + NetsisDBUser);
            sb.AppendLine("NetsisDBPassword=" + NetsisDBPassword);
            sb.AppendLine("NetsisDBDatabase=" + NetsisDBDatabase);
            sb.AppendLine("NetsisKullaniciAdi=" + NetsisKullaniciAdi);
            sb.AppendLine("NetsisSifre=" + NetsisSifre.ToString());
            sb.AppendLine("NetsisSube=" + NetsisSube.ToString());
            sb.AppendLine("NetsisNakitKasaKodu=" + NetsisNakitKasaKodu);
            sb.AppendLine("NetsisCekKasaKodu=" + NetsisCekKasaKodu);
            sb.AppendLine("NetsisSenetKasaKodu=" + NetsisSenetKasaKodu);

            sb.AppendLine("WebServiceUrl=" + WebServiceUrl);
            sb.AppendLine("WebServiceUser=" + WebServiceUser);
            sb.AppendLine("WebServicePassword=" + WebServicePassword);
            sb.AppendLine("WebServiceDistKod=" + WebServiceDistKod);
            sb.AppendLine("WebServiceCalismaYili=" + WebServiceCalismaYili);
            sb.AppendLine("WebServiceFirmaKod=" + WebServiceFirmaKod);

            sb.AppendLine("LogServer=" + LogServer);
            sb.AppendLine("LogKullaniciAdi=" + LogKullaniciAdi);
            sb.AppendLine("LogSifre=" + LogSifre);
            sb.AppendLine("LogDB=" + LogDB);

            File.WriteAllText(DosyaYolu, sb.ToString());
        }

        public static void Getir()
        {
            if (!File.Exists(DosyaYolu))
            {
                Kaydet();
            }
            string[] Satirlar = File.ReadAllLines(DosyaYolu);
            foreach (string Satir in Satirlar)
            {
                switch (Satir.Split('=')[0])
                {
                    case "NetsisDBUser":
                        NetsisDBUser = Satir.Split('=')[1];
                        break;

                    case "NetsisDBPassword":
                        NetsisDBPassword = Satir.Split('=')[1];
                        break;

                    case "NetsisDBDatabase":
                        NetsisDBDatabase = Satir.Split('=')[1];
                        break;

                    case "NetsisKullaniciAdi":
                        NetsisKullaniciAdi = Satir.Split('=')[1];
                        break;

                    case "NetsisSifre":
                        NetsisSifre = Satir.Split('=')[1];
                        break;

                    case "NetsisSube":
                        NetsisSube = int.Parse(Satir.Split('=')[1]);
                        break;

                    case "NetsisNakitKasaKodu":
                        NetsisNakitKasaKodu = Satir.Split('=')[1];
                        break;

                    case "NetsisCekKasaKodu":
                        NetsisCekKasaKodu = Satir.Split('=')[1];
                        break;

                    case "NetsisSenetKasaKodu":
                        NetsisSenetKasaKodu = Satir.Split('=')[1];
                        break;

                    case "WebServiceUrl":
                        WebServiceUrl = Satir.Split('=')[1];
                        break;

                    case "WebServiceUser":
                        WebServiceUser = Satir.Split('=')[1];
                        break;

                    case "WebServicePassword":
                        WebServicePassword = Satir.Split('=')[1];
                        break;

                    case "WebServiceDistKod":
                        WebServiceDistKod = Satir.Split('=')[1];
                        break;

                    case "WebServiceCalismaYili":
                        WebServiceCalismaYili = Satir.Split('=')[1];
                        break;

                    case "WebServiceFirmaKod":
                        WebServiceFirmaKod = Satir.Split('=')[1];
                        break;

                    case "LogServer":
                        LogServer = Satir.Split('=')[1];
                        break;

                    case "LogKullaniciAdi":
                        LogKullaniciAdi = Satir.Split('=')[1];
                        break;

                    case "LogSifre":
                        LogSifre = Satir.Split('=')[1];
                        break;

                    case "LogDB":
                        LogDB = Satir.Split('=')[1];
                        break;
                }
            }
        }
    }
}
