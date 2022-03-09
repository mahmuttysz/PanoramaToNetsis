//using SSDBCONTROL;
//using SSTOOLS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PanoramaToNetsis
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //ShadowTools.IniFile Config = new ShadowTools.IniFile(string.Format(@"{0}\{1}.ini", Directory.GetCurrentDirectory(), Application.ProductName));
        private string FormIsmi = string.Empty;

        public string ConnStrRapor, ConnStrWebPlus, ConnStrDiger, Versiyon, KullaniciGrupAdi = string.Empty;

        public fMain()
        {
            InitializeComponent();
            ConnStrRapor = "Connstr";
            ConnStrWebPlus = "ConnStr";
            ConnStrDiger = "Conn";
            //ParametreleriOku();
            MenuHazirla();

            labelVersion.Text = "v" + Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        private void TrvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (TrvMenu.FocusedNode.HasChildren == true) return;
            MenuAc(TrvMenu.FocusedNode);
        }

        private void TrvMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (TrvMenu.FocusedNode.HasChildren == true) return;
                MenuAc(TrvMenu.FocusedNode);
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        private void MenuHazirla()
        {
            TrvMenu.Columns.Clear();
            TrvMenu.Nodes.Clear();
            try
            {
                //KullaniciGrupAdi = SsDbServis.KullaniciGrupAdiGetir(ConnStrRapor, KullaniciAdi);
                //TrvMenu.DataSource = SsDbServis.MenuGetir(ConnStrRapor, KullaniciGrupAdi);

                var menuList = new[]
                {
                    new
                    {
                        Id = 2,
                        MenuAdi = "Aktarım",
                        MenuFormDosyaYolu = "Aktarim",
                    },

                    new
                    {
                        Id = 3,
                        MenuAdi = "Parametreler",
                        MenuFormDosyaYolu = "Parametreler",
                    },
                    new
                    {
                        Id = 4,
                        MenuAdi = "Aktarım Sonuçları",
                        MenuFormDosyaYolu = "AktarimSonuc",
                    }
                }.ToList();

                TrvMenu.DataSource = menuList.ConvertToDataTable_();
                TrvMenu.Columns.ColumnByName("colId").VisibleIndex = -1;
                TrvMenu.Columns.ColumnByName("colMenuFormDosyaYolu").VisibleIndex = -1;
                //TrvMenu.Columns.ColumnByName("colDurumG").VisibleIndex = -1;
                //TrvMenu.Columns.ColumnByName("colDurumE").VisibleIndex = -1;
                //TrvMenu.Columns.ColumnByName("colDurumD").VisibleIndex = -1;
                //TrvMenu.Columns.ColumnByName("colDurumS").VisibleIndex = -1;

                TrvMenu.OptionsBehavior.Editable = false;
                TrvMenu.OptionsView.ShowColumns = false;
                TrvMenu.OptionsView.ShowIndicator = false;
                TrvMenu.OptionsView.ShowHorzLines = false;
                TrvMenu.OptionsView.ShowVertLines = false;
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Menü Hazırlanırken Bir Hata Oluştu.\n" + Hata.ToString(), "Panorama To Netsis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void MenuAc(DevExpress.XtraTreeList.Nodes.TreeListNode Nod)
        {
            try
            {
                //new fKarmaKoli( KullaniciAdi, ConnStrRapor, ConnStrWebPlus, ConnStrDiger, true, true, true ).ShowDialog();
                //return;

                //bool Ekleme = false;
                //bool Degistirme = false;
                //bool Silme = false;
                if (Nod.HasChildren == true) return;
                string FormIsmi = Nod.GetValue(TrvMenu.Columns["MenuFormDosyaYolu"]).ToString();
                //if (Nod.GetValue(TrvMenu.Columns["Ekleme"]).ToString() == "True") Ekleme = true;
                //if (Nod.GetValue(TrvMenu.Columns["Silme"]).ToString() == "True") Silme = true;
                //if (Nod.GetValue(TrvMenu.Columns["Degistirme"]).ToString() == "True") Degistirme = true;

                object obj = null;
                string f = string.Empty;
                f = string.Format("{0}.{1}", Application.ProductName.Replace(" ", "_"), FormIsmi);
                Type type = Type.GetType(f);

                obj = Activator.CreateInstance(type, ConnStrRapor, ConnStrWebPlus, ConnStrDiger);

                Form frm = (obj as Form);
                frm.MdiParent = this;
                frm.Show();
                Cursor = Cursors.Default;
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Form açılırken bir hata oluşu.\n" + Hata.ToString(), "Panorama To Netsis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SSTabbedMdiManager_SelectedPageChanged(object sender, EventArgs e)
        {
            if (SSTabbedMdiManager.SelectedPage != null)
            {
                FormIsmi = SSTabbedMdiManager.SelectedPage.MdiChild.Name;
                if (FormIsmi.Substring(FormIsmi.Length - 5) == "Liste")
                    rbnCnt.SelectedPage = rbnCnt.Pages["Liste"];
                else if (FormIsmi.Substring(FormIsmi.Length - 6) == "Filtre")
                    rbnCnt.SelectedPage = rbnCnt.Pages["Rapor"];
                else
                    rbnCnt.SelectedPage = rbnCnt.Pages["Form"];
            }
        }

        private void SSTabbedMdiManager_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (SSTabbedMdiManager.Pages.Count == 0)
            {
                TrvMenu.Focus();
            }
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                if (e != null) e.Cancel = true;
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            barZaman.Caption = DateTime.Now.ToString();
        }

        private void fMain_Shown(object sender, EventArgs e)
        {
            barDeveloper.Caption = string.Format("© 2013 - {0} SS Shadow |", DateTime.Now.Year);
            barVersiyon.Caption = "Versiyon : v1.1.0.0 |";
            barZaman.Caption = DateTime.Now.ToString();
        }
    }
}