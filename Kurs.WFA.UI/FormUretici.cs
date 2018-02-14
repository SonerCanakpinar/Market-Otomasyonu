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
    public partial class FormUretici : DevExpress.XtraEditors.XtraForm
    {
        public FormUretici()
        {
            InitializeComponent();
        }
        Tedarikci seciliTedarikci = null;

        private void FormUretici_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
        void VerileriGetir()
        {
            try
            {
                gridControl1.DataSource = new TedarikciRepo().GetAll();

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
                new TedarikciRepo().Insert(new Tedarikci()
                {

                CompanyName = tedarikciAdi.Text,
                ContactName = telefon.Text,
                Adres= txtAdres.Text
                });

            }
           
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
                var tedarikci = new TedarikciRepo().GetById(seciliTedarikci.TedarikciID);
                tedarikci.CompanyName = tedarikciAdi.Text;
                tedarikci.ContactName = telefon.Text;
                tedarikci.Adres = txtAdres.Text;
                new TedarikciRepo().Update();
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
                if (seciliTedarikci == null)
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Tedarikçiyi Seçiniz!");
                    VerileriGetir();
                    return;
                }
                new TedarikciRepo().Delete(seciliTedarikci);
                VerileriGetir();
                MessageBox.Show($"{seciliTedarikci.CompanyName} adlı tedarikçi silinmiştir");

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
            tedarikciAdi.Text= "";
            telefon.Text = "";
            txtAdres.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.GetSelectedRows().Length == 0) return;
            seciliTedarikci = gridView1.GetFocusedRow() as Tedarikci;
            tedarikciAdi.Text = seciliTedarikci.CompanyName;
            telefon.Text = seciliTedarikci.ContactName;
            txtAdres.Text = seciliTedarikci.Adres;
        }
    }
}