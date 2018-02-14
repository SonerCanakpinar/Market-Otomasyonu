namespace Market.WFA.UI
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.navMusteri = new DevExpress.XtraNavBar.NavBarItem();
            this.navKullanici = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navUrun = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navkategori = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navUretici = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnSatisYap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSiparisYonetimi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokYonetimi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRapor = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navMusteri
            // 
            this.navMusteri.Caption = "Müşteri İşlemleri";
            this.navMusteri.Name = "navMusteri";
            this.navMusteri.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMusteri_LinkPressed);
            // 
            // navKullanici
            // 
            this.navKullanici.Caption = "Kullanıcı İşlemleri";
            this.navKullanici.Name = "navKullanici";
            this.navKullanici.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navKullanici_LinkPressed);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "navBarItem4";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup4,
            this.navBarGroup1,
            this.navBarGroup5,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem5,
            this.navUrun,
            this.navUretici,
            this.navkategori});
            this.navBarControl1.Location = new System.Drawing.Point(0, 67);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 159;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(159, 391);
            this.navBarControl1.TabIndex = 3;
            this.navBarControl1.Text = "Müşteri İşlemleri";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.ExplorerBarViewInfoRegistrator();
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Ürünler";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.SmallImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUrun)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navUrun
            // 
            this.navUrun.Caption = "Ürün İşlemleri";
            this.navUrun.Name = "navUrun";
            this.navUrun.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navUrun_LinkPressed);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Kategoriler";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.ImageOptions.SmallImage")));
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navkategori)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navkategori
            // 
            this.navkategori.Caption = "Kategori İşlemleri";
            this.navkategori.Name = "navkategori";
            this.navkategori.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navkategori_LinkPressed);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "Tedarikçiler";
            this.navBarGroup5.Expanded = true;
            this.navBarGroup5.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup5.ImageOptions.SmallImage")));
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUretici)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // navUretici
            // 
            this.navUretici.Caption = "Tedarikçi İşlemleri";
            this.navUretici.Name = "navUretici";
            this.navUretici.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navUretici_LinkPressed);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Kullanıcılar";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.ImageOptions.SmallImage")));
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navKullanici)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "navBarItem5";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barBtnSatisYap,
            this.barBtnSiparisYonetimi,
            this.barBtnRapor,
            this.barBtnCikis,
            this.barButtonItem6,
            this.barBtnStokYonetimi,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bar1.BarAppearance.Disabled.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSatisYap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSiparisYonetimi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnStokYonetimi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRapor, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnCikis, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnSatisYap
            // 
            this.barBtnSatisYap.Caption = "Satış Yap";
            this.barBtnSatisYap.Id = 1;
            this.barBtnSatisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSatisYap.ImageOptions.Image")));
            this.barBtnSatisYap.Name = "barBtnSatisYap";
            this.barBtnSatisYap.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSatisYap_ItemPress);
            // 
            // barBtnSiparisYonetimi
            // 
            this.barBtnSiparisYonetimi.Caption = "Sipariş Yönetimi";
            this.barBtnSiparisYonetimi.Id = 2;
            this.barBtnSiparisYonetimi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSiparisYonetimi.ImageOptions.Image")));
            this.barBtnSiparisYonetimi.Name = "barBtnSiparisYonetimi";
            this.barBtnSiparisYonetimi.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSiparisYonetimi_ItemPress);
            // 
            // barBtnStokYonetimi
            // 
            this.barBtnStokYonetimi.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.barBtnStokYonetimi.Caption = "Stok Yönetimi";
            this.barBtnStokYonetimi.Id = 6;
            this.barBtnStokYonetimi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStokYonetimi.ImageOptions.Image")));
            this.barBtnStokYonetimi.Name = "barBtnStokYonetimi";
            this.barBtnStokYonetimi.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokYonetimi_ItemPress);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Cari Hesap";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barBtnRapor
            // 
            this.barBtnRapor.Caption = "Rapor";
            this.barBtnRapor.Id = 3;
            this.barBtnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRapor.ImageOptions.Image")));
            this.barBtnRapor.Name = "barBtnRapor";
            this.barBtnRapor.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRapor_ItemPress);
            // 
            // barBtnCikis
            // 
            this.barBtnCikis.Caption = "Çıkış";
            this.barBtnCikis.Id = 4;
            this.barBtnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCikis.ImageOptions.Image")));
            this.barBtnCikis.Name = "barBtnCikis";
            this.barBtnCikis.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCikis_ItemPress);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(730, 67);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 458);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(730, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 67);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 391);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(730, 67);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 391);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Anasayfa";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::Kurs.WFA.UI.Properties.Resources.shopping1;
            this.pictureEdit1.Location = new System.Drawing.Point(165, 67);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(565, 391);
            this.pictureEdit1.TabIndex = 9;
            // 
            // Anasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(730, 481);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarItem navMusteri;
        private DevExpress.XtraNavBar.NavBarItem navKullanici;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnSatisYap;
        private DevExpress.XtraBars.BarButtonItem barBtnSiparisYonetimi;
        private DevExpress.XtraBars.BarButtonItem barBtnRapor;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnCikis;
        private DevExpress.XtraBars.BarButtonItem barBtnStokYonetimi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraNavBar.NavBarItem navUrun;
        private DevExpress.XtraNavBar.NavBarItem navUretici;
        private DevExpress.XtraNavBar.NavBarItem navkategori;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraBars.Bar bar1;
    }
}