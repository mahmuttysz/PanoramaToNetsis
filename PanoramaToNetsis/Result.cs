using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PanoramaToNetsis
{
    public class Result
    {
        public bool Hatali { get; set; }
        public int Kod { get; set; }
        public string Kaynak { get; set; }
        public string Mesaj { get; set; }
        public object Model { get; set; }

        public Result(bool Hatali = true, int Kod = -1, string Kaynak = "Result", string Mesaj = "Not set result", object Model = null)
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

        private void Log_Kayit(Result Result)
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

            string Log_Klasor = Application.StartupPath + "\\Log";
            if (!Directory.Exists(Log_Klasor))
                Directory.CreateDirectory(Log_Klasor);
            string Log_Dosya = Log_Klasor + "\\" + yil + ay + gun + ".txt";
            if (!File.Exists(Log_Dosya))
            {
                var Dosya = File.Create(Log_Dosya);
                Dosya.Close();
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString() + "\t" + Result.Kaynak + "\t" + Result.Kod + "\t" + Result.Mesaj);
            File.AppendAllText(Log_Dosya, sb.ToString());
        }
    }
}