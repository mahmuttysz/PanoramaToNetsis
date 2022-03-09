using System;
using System.Linq;
using System.Threading.Tasks;

namespace PanoramaToNetsis
{
    public partial class AktarimSonuc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AktarimSonuc(string _ConstrRapor, string _ConnStrWebPlus, string _ConnStrDiger)
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            txtBaslangicTarihi.EditValue = DateTime.Now;
            txtBitisTarihi.EditValue = DateTime.Now;
            base.OnLoad(e);
            prgMarquee.Stopped = true;
        }

        private async void BtnAktarimListeleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string baslangicTarihi = ((DateTime)txtBaslangicTarihi.EditValue).ToString("yyyy-MM-dd 00:00:00");
                string bitisTarihi = ((DateTime)txtBitisTarihi.EditValue).ToString("yyyy-MM-dd 23:59:59");
                var dal = new DAL();
                var asyncList = await Task.Run(() =>
                {
                    var list = dal.AktarimSonuc(baslangicTarihi, bitisTarihi);

                    lblKayitSayisi.Caption = "Kayıtlar Listeleniyor...";
                    prgMarquee.Stopped = false;
                    btnAktarimListele.Enabled = false;
                    return list;
                });
                gridControl1.DataSource = asyncList.ToList();
                gridView1.BestFitColumns();
                lblKayitSayisi.Caption = asyncList.Count + " Adet Kayıt Listelendi.";
                btnAktarimListele.Enabled = true;
                
            }
            catch (Exception ex)
            {
                LogKaydet result = new LogKaydet();
                string mesaj = ex.Message;
                if (ex.InnerException != null)
                {
                    mesaj += " >> " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        mesaj += ex.InnerException.InnerException.Message;
                }

                result = new LogKaydet(true, 1, "btnAktarimSonuc", mesaj, null);
               
            }
            finally
            {
                prgMarquee.Stopped = true;
            }
        }
    }
}