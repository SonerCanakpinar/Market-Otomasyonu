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
using Market.BLL.Repository;
using Market.Entity.Models;
using DevExpress.XtraEditors.Camera;
using System.IO;

namespace Market.WFA.UI
{
    public partial class FormUrun : DevExpress.XtraEditors.XtraForm
    {
        public FormUrun()
        {
            InitializeComponent();
        }

       

       
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            txtSeriNo.Focus();
            
        }
        Urun seciliUrun=null;

        void VerileriGetir()
        {
            try
            {
               gridUrun.DataSource = new UrunRepo().GetAll();
                cmbKategori.Properties.DataSource = new KategoriRepo().GetAll();
                cmbKategori.Properties.ValueMember = "KategoriID";
                tedarikci.Properties.DataSource = new TedarikciRepo().GetAll();
                tedarikci.Properties.ValueMember = "TedarikciID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                //var urun = new UrunRepo().GetById(Convert.ToInt32(txtUrunAdi.Text));
                
                //if () 
                //{
                //    urun.StokMiktari += Convert.ToInt32(txtStokMiktar.Text);
                //}
                //else
                //{
                    new UrunRepo().Insert(new Urun()
                    {

                        UrunBarkod = txtSeriNo.Text,
                        UrunAdi = txtUrunAdi.Text,
                        SonKullanmaTarihi = Convert.ToDateTime(btnSonKullanmaTarihi.Text),
                        AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text),
                        SatisFiyat = Convert.ToDecimal(txtSatisFiyat.Text),
                        KategoriID = Convert.ToInt32(cmbKategori.GetColumnValue("KategoriID")),
                        TedarikciID = Convert.ToInt32(tedarikci.GetColumnValue("TedarikciID")),

                        StokMiktari = Convert.ToInt32(txtStokMiktar.Text),


                        SatistaMi = checkSatistaMi.Checked,
                        UrunResim = pictureUrun.EditValue as byte[]

                    });

                }
            // }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnTemizle.PerformClick();
            VerileriGetir();
        }
        
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            var dialog = new TakePictureDialog();
            var cevap = dialog.ShowDialog();
            if (cevap == DialogResult.OK)
                pictureUrun.Image = dialog.Image;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = new UrunRepo().GetById(seciliUrun.UrunID);
                urun.UrunAdi = txtUrunAdi.Text;
               urun.SatisFiyat =Convert.ToDecimal( txtSatisFiyat.Text);
               urun.AlisFiyat =Convert.ToDecimal( txtAlisFiyat.Text);
                urun.SonKullanmaTarihi = Convert.ToDateTime(btnSonKullanmaTarihi.Text);
                urun.StokMiktari += Convert.ToInt32(txtStokMiktar.Text);
                urun.SatistaMi = checkSatistaMi.Checked;
                urun.KategoriID = Convert.ToInt32(cmbKategori.GetColumnValue("KategoriID"));
                urun.TedarikciID = Convert.ToInt32(tedarikci.GetColumnValue("TedarikciID"));
                urun.UrunBarkod = txtSeriNo.Text;
                urun.UrunResim = pictureUrun.EditValue as byte[];
                new UrunRepo().Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            btnTemizle.PerformClick();

            VerileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliUrun == null)
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Ürünü Seçiniz!");
                    VerileriGetir();
                    return;
                }
                new UrunRepo().Delete(seciliUrun);
                VerileriGetir();
                MessageBox.Show($"{seciliUrun.UrunAdi} adlı ürün silinmiştir");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            btnTemizle.PerformClick();

            VerileriGetir();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtUrunAdi.Text = "";
            btnSonKullanmaTarihi.Text = "";
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            cmbKategori.Text = "";
            tedarikci.Text = "";
            txtStokMiktar.Text = "";
            checkSatistaMi.Checked = false;
            pictureUrun.Image = null;
            
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {


            dosya_ac.Title = "Bir resim dosyası seçiniz";
            dosya_ac.Multiselect = false;
          
          //  dosya_ac.Filter = "JPG Formatı (*.jpg) | *.jpg; *.jpeg; | PNG Formatı | *.png";
            dosya_ac.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = dosya_ac.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureUrun.Image =Image.FromFile( dosya_ac.FileName);
                FileInfo fi1 = new FileInfo(dosya_ac.FileName);
            }
            else
                MessageBox.Show("işlem iptal edildi");
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.GetSelectedRows().Length == 0) return;
            seciliUrun = gridView1.GetFocusedRow() as Urun;
            txtSeriNo.Text = seciliUrun.UrunBarkod;
            txtUrunAdi.Text =seciliUrun.UrunAdi;
            btnSonKullanmaTarihi.Text =(seciliUrun.SonKullanmaTarihi).ToString();
            txtAlisFiyat.Text = (seciliUrun.AlisFiyat).ToString();
            txtSatisFiyat.Text =(seciliUrun.SatisFiyat).ToString();

            var kategori=new KategoriRepo().GetById(seciliUrun.KategoriID);

            cmbKategori.Text = kategori.KategoriAdi;

            var tedarikciler = new TedarikciRepo().GetById(seciliUrun.TedarikciID);

            tedarikci.Text = tedarikciler.CompanyName;

            txtStokMiktar.Text =(seciliUrun.StokMiktari).ToString();
            checkSatistaMi.Checked = seciliUrun.SatistaMi;
            pictureUrun.EditValue = seciliUrun.UrunResim;
        }
    }
}