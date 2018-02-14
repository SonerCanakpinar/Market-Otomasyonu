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

namespace Market.WFA.UI
{
    public partial class FormKategori : DevExpress.XtraEditors.XtraForm
    {
        public FormKategori()
        {
            InitializeComponent();
        }
        private void FormKategori_Load(object sender, EventArgs e)
            {
                VerileriGetir();
            }

        Kategori seciliKategori = null;
      

        void VerileriGetir()
        {
            try
            {
                gridControlKategori.DataSource = new KategoriRepo().GetAll();

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
                new KategoriRepo().Insert(new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    Aciklama = txtAciklama.Text,
                    KDV = Convert.ToDecimal(txtKDV.Text) / 100

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            VerileriGetir();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        { 
            try
            {
                var kategori = new KategoriRepo().GetById(seciliKategori.KategoriID);
                kategori.KategoriAdi = txtKategoriAdi.Text;
                kategori.Aciklama = txtAciklama.Text;
                kategori.KDV = Convert.ToDecimal(txtKDV.Text) / 100;
                new KategoriRepo().Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            VerileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliKategori == null)
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Kategoriyi Seçiniz!");
                    VerileriGetir();
                    return;
                }
                new KategoriRepo().Delete(seciliKategori);
                    VerileriGetir();
                MessageBox.Show($"{seciliKategori.KategoriAdi} adlı kategori silinmiştir");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            VerileriGetir();

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.GetSelectedRows().Length == 0) return;
            seciliKategori = gridView1.GetFocusedRow() as Kategori;
            txtKategoriAdi.Text = seciliKategori.KategoriAdi;
            txtAciklama.Text = seciliKategori.Aciklama;
            txtKDV.Text =( Convert.ToInt32(seciliKategori.KDV*100)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKategoriAdi.Text = "";
            txtAciklama.Text = "";
            txtKDV.Text = "";
        }
    }
}