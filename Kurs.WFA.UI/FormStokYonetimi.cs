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
using Market.Entity.Models;
using Market.BLL.Repository;

namespace Market.WFA.UI
{
    public partial class FormStokYonetimi : DevExpress.XtraEditors.XtraForm
    {
        public FormStokYonetimi()
        {
            InitializeComponent();
        }

        Stok seciliStok = null;

        void VerileriGetir()
        {
            try
            {
                gridControl1.DataSource = new StokRepo().GetAll();
                cmbUrun.Properties.DataSource = new UrunRepo().GetAll();
                cmbUrun.Properties.ValueMember = "UrunID";
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
                new StokRepo().Insert(new Stok()
                {

                    UrunBarkod = txtSeriNo.Text,
                    //UrunID = Convert.ToInt32(cmbUrun.GetColumnValue("UrunID")),
                    //KategoriID = Convert.ToInt32(cmbKategori.GetColumnValue("KategoriID")),
                    //TedarikciID = Convert.ToInt32(tedarikci.GetColumnValue("TedarikciID")),

                    StokMiktari = Convert.ToInt32(txtStokMiktar.Text),
  
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var stok = new StokRepo().GetById(seciliStok.StokID);
               
                stok.StokMiktari += Convert.ToInt32(txtStokMiktar.Text);

                //stok.UrunID = Convert.ToInt32(cmbUrun.GetColumnValue("UrunID")); 
                //stok.KategoriID = Convert.ToInt32(cmbKategori.GetColumnValue("KategoriID"));
                //stok.TedarikciID = Convert.ToInt32(tedarikci.GetColumnValue("TedarikciID"));
                stok.UrunBarkod = txtSeriNo.Text;
               
                new StokRepo().Update();
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
                if (seciliStok == null)
                {
                    MessageBox.Show("Lütfen Silmek Stok Ürününü Seçiniz!");
                    VerileriGetir();
                    return;
                }
                new StokRepo().Delete(seciliStok);
                VerileriGetir();
                MessageBox.Show("secilen ürün stoğu silinmiştir");

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
            cmbUrun.Text = "";
            cmbKategori.Text = "";
            tedarikci.Text = "";
            txtStokMiktar.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStokYonetimi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            txtSeriNo.Focus();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.GetSelectedRows().Length == 0) return;
            seciliStok = gridView1.GetFocusedRow() as Stok;
            txtSeriNo.Text = seciliStok.UrunBarkod;

            //var urun = new UrunRepo().GetById(seciliStok.UrunID);

            //cmbUrun.Text = urun.UrunAdi;
            //var kategori = new KategoriRepo().GetById(seciliStok.KategoriID);

            //cmbKategori.Text = kategori.KategoriAdi;

            //var tedarikciler = new TedarikciRepo().GetById(seciliStok.TedarikciID);

            //tedarikci.Text = tedarikciler.CompanyName;

            txtStokMiktar.Text = (seciliStok.StokMiktari).ToString();
        }
    }
}