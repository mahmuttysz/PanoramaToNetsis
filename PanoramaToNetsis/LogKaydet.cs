using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PanoramaToNetsis
{
    public class LogKaydet
    {
        public bool Hatali { get; set; }
        public int Kod { get; set; }
        public string Kaynak { get; set; }
        public string Mesaj { get; set; }
        public object Model { get; set; }

        public LogKaydet(bool Hatali = true, int Kod = -1, string Kaynak = "Result", string Mesaj = "Not set result", object Model = null)
        {
            this.Hatali = Hatali;
            this.Kod = Kod;
            this.Kaynak = Kaynak;
            this.Mesaj = Mesaj;
            this.Model = Model;
            if (this.Kod != -1)
                if (this.Kod != 2)
                    Log_Kayit(this);
        }

        private void Log_Kayit(LogKaydet Result)
        {
            string yil = DateTime.Now.Year.ToString();
            string ay = "";
            if (DateTime.Now.Month < 10)
                ay = "0" + DateTime.Now.Month.ToString();
            else
                ay = DateTime.Now.Month.ToString();
            string gun = "";
            if (DateTime.Now.Month < 10)
                gun = "0" + DateTime.Now.Day.ToString();
            else
                gun = DateTime.Now.Day.ToString();

            string LogKlasor = Application.StartupPath + "\\Log";
            if (!Directory.Exists(LogKlasor))
                Directory.CreateDirectory(LogKlasor);
            string LogDosya = LogKlasor + "\\" + yil + ay + gun + ".txt";
            if (!File.Exists(LogDosya))
            {
                var Dosya = File.Create(LogDosya);
                Dosya.Close();
            }
            var sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString() + "\t" + Result.Kaynak + "\t" + Result.Kod + "\t" + Result.Mesaj);
            File.AppendAllText(LogDosya, sb.ToString());
        }
    }
}