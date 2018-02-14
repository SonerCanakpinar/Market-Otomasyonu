using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Market.WFA.UI;
using System.IO;

namespace Market.WFA.UI
{
    public partial class Anasayfa : DevExpress.XtraEditors.XtraForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void barBtnSatisYap_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSatis SatisForm = new FormSatis();
            SatisForm.Show();
        }

        private void barBtnSiparisYonetimi_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSiparis SiparisForm = new FormSiparis();
            SiparisForm.Show();
        }

        private void barBtnStokYonetimi_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormStokYonetimi StokYonetimiForm = new FormStokYonetimi();
            StokYonetimiForm.Show();
        }

        private void barBtnRapor_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Rapor.
        }

        private void barBtnCikis_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            
        }

        private void navkategori_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormKategori KategoriForm = new FormKategori();
            KategoriForm.Show();
        }

        private void navUrun_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormUrun UrunForm = new FormUrun();
            UrunForm.Show();
        }

        private void navUretici_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormUretici UreticiForm = new FormUretici();
            UreticiForm.Show();
        }

        private void navMusteri_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormMusteri MusteriForm = new FormMusteri();
            MusteriForm.Show();
        }

        private void navKullanici_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormKullanici KullaniciForm = new FormKullanici();
            KullaniciForm.Show();
        }
    }
}