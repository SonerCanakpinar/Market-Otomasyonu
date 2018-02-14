namespace Market.WFA.UI
{
    partial class FormUrun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrun));
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSonKullanmaTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureUrun = new DevExpress.XtraEditors.PictureEdit();
            this.checkSatistaMi = new DevExpress.XtraEditors.CheckEdit();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridUrun = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnResimEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cmbKategori = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tedarikci = new DevExpress.XtraEditors.LookUpEdit();
            this.btnResimYukle = new DevExpress.XtraEditors.SimpleButton();
            this.dosya_ac = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtStokMiktar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSonKullanmaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSonKullanmaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSatistaMi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokMiktar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(208, 80);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Properties.Mask.EditMask = "d";
            this.txtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSeriNo.Size = new System.Drawing.Size(100, 20);
            this.txtSeriNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seri Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(208, 115);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(285, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Ürün İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(53, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Son KullanmaTarihi :";
            // 
            // btnSonKullanmaTarihi
            // 
            this.btnSonKullanmaTarihi.EditValue = null;
            this.btnSonKullanmaTarihi.Location = new System.Drawing.Point(208, 205);
            this.btnSonKullanmaTarihi.Name = "btnSonKullanmaTarihi";
            this.btnSonKullanmaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btnSonKullanmaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btnSonKullanmaTarihi.Properties.DisplayFormat.FormatString = "";
            this.btnSonKullanmaTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.btnSonKullanmaTarihi.Properties.EditFormat.FormatString = "";
            this.btnSonKullanmaTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.btnSonKullanmaTarihi.Size = new System.Drawing.Size(100, 20);
            this.btnSonKullanmaTarihi.TabIndex = 10;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(208, 272);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Properties.Mask.EditMask = "c";
            this.txtAlisFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAlisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtAlisFiyat.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(53, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Birim Alış Fiyatı :";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(208, 308);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Properties.Mask.EditMask = "c";
            this.txtSatisFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSatisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyat.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(53, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Birim Satış Fiyatı :";
            // 
            // pictureUrun
            // 
            this.pictureUrun.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureUrun.Location = new System.Drawing.Point(339, 80);
            this.pictureUrun.Name = "pictureUrun";
            this.pictureUrun.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pictureUrun.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.pictureUrun.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureUrun.Size = new System.Drawing.Size(119, 121);
            this.pictureUrun.TabIndex = 21;
            // 
            // checkSatistaMi
            // 
            this.checkSatistaMi.Location = new System.Drawing.Point(56, 353);
            this.checkSatistaMi.Name = "checkSatistaMi";
            this.checkSatistaMi.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkSatistaMi.Properties.Appearance.Options.UseForeColor = true;
            this.checkSatistaMi.Properties.Caption = "Satışta";
            this.checkSatistaMi.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.checkSatistaMi.Size = new System.Drawing.Size(75, 19);
            this.checkSatistaMi.TabIndex = 26;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(131, 424);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 40);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(220, 424);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 40);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(308, 424);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 40);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(409, 424);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(68, 40);
            this.btnCikis.TabIndex = 18;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(33, 424);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 40);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gridUrun
            // 
            this.gridUrun.Location = new System.Drawing.Point(483, 80);
            this.gridUrun.MainView = this.gridView1;
            this.gridUrun.Name = "gridUrun";
            this.gridUrun.Size = new System.Drawing.Size(669, 384);
            this.gridUrun.TabIndex = 27;
            this.gridUrun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridUrun;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Aranacak Kelimeyi Giriniz....";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResimEkle.ImageOptions.Image")));
            this.btnResimEkle.Location = new System.Drawing.Point(339, 208);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(119, 23);
            this.btnResimEkle.TabIndex = 28;
            this.btnResimEkle.Text = "Resim Çek";
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.Location = new System.Drawing.Point(208, 149);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKategori.Properties.NullText = "";
            this.cmbKategori.Properties.PopupSizeable = false;
            this.cmbKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbKategori.Size = new System.Drawing.Size(100, 20);
            this.cmbKategori.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tedarikçi :";
            // 
            // tedarikci
            // 
            this.tedarikci.Location = new System.Drawing.Point(208, 175);
            this.tedarikci.Name = "tedarikci";
            this.tedarikci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tedarikci.Properties.NullText = "";
            this.tedarikci.Properties.PopupSizeable = false;
            this.tedarikci.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.tedarikci.Size = new System.Drawing.Size(100, 20);
            this.tedarikci.TabIndex = 30;
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResimYukle.ImageOptions.Image")));
            this.btnResimYukle.Location = new System.Drawing.Point(339, 237);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(119, 23);
            this.btnResimYukle.TabIndex = 31;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // dosya_ac
            // 
            this.dosya_ac.FileName = "dosya_ac";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(53, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Eklenecek Stok Miktarı  :";
            // 
            // txtStokMiktar
            // 
            this.txtStokMiktar.Location = new System.Drawing.Point(208, 233);
            this.txtStokMiktar.Name = "txtStokMiktar";
            this.txtStokMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtStokMiktar.TabIndex = 12;
            // 
            // FormUrun
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 493);
            this.Controls.Add(this.btnResimYukle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tedarikci);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.gridUrun);
            this.Controls.Add(this.checkSatistaMi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureUrun);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStokMiktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.btnSonKullanmaTarihi);
            this.Controls.Add(this.cmbKategori);
            this.Name = "FormUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün";
            this.Load += new System.EventHandler(this.FormUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSonKullanmaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSonKullanmaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSatistaMi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokMiktar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit btnSonKullanmaTarihi;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.PictureEdit pictureUrun;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.CheckEdit checkSatistaMi;
        private DevExpress.XtraGrid.GridControl gridUrun;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnResimEkle;
        private DevExpress.XtraEditors.LookUpEdit cmbKategori;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit tedarikci;
        private DevExpress.XtraEditors.SimpleButton btnResimYukle;
        private DevExpress.XtraEditors.XtraOpenFileDialog dosya_ac;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtStokMiktar;
    }
}