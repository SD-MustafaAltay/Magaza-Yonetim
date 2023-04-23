namespace Ticari_Otomasyon
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSatis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.NudAdet = new System.Windows.Forms.NumericUpDown();
            this.TxtAlis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskYil = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAracMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtIskonto1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtIskonto2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtIskonto3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtOem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new System.Windows.Forms.RichTextBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAracMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(2196, 1031);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 673;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBarkod);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.txtOem);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtIskonto3);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.txtIskonto2);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtIskonto1);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtAracMarka);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RchDetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.TxtSatis);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.NudAdet);
            this.groupControl1.Controls.Add(this.TxtAlis);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtModel);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtMarka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.MskYil);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2208, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(520, 1071);
            this.groupControl1.TabIndex = 2;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(58, 1002);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(191, 62);
            this.BtnTemizle.TabIndex = 22;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(300, 926);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(181, 62);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click_1);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(300, 1002);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(181, 62);
            this.BtnSil.TabIndex = 20;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click_1);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(58, 926);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(191, 62);
            this.BtnKaydet.TabIndex = 19;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchDetay
            // 
            this.RchDetay.Location = new System.Drawing.Point(168, 868);
            this.RchDetay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RchDetay.Name = "RchDetay";
            this.RchDetay.Size = new System.Drawing.Size(322, 46);
            this.RchDetay.TabIndex = 8;
            this.RchDetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(120, 344);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 36);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Yıl:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(88, 461);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 36);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Adet:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(68, 868);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 36);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Detay:";
            // 
            // TxtSatis
            // 
            this.TxtSatis.Location = new System.Drawing.Point(168, 761);
            this.TxtSatis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSatis.Name = "TxtSatis";
            this.TxtSatis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatis.Properties.Appearance.Options.UseFont = true;
            this.TxtSatis.Size = new System.Drawing.Size(326, 50);
            this.TxtSatis.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(14, 767);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(147, 36);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Satış Fiyat:";
            // 
            // NudAdet
            // 
            this.NudAdet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NudAdet.Location = new System.Drawing.Point(168, 457);
            this.NudAdet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NudAdet.Name = "NudAdet";
            this.NudAdet.Size = new System.Drawing.Size(326, 44);
            this.NudAdet.TabIndex = 5;
            // 
            // TxtAlis
            // 
            this.TxtAlis.Location = new System.Drawing.Point(168, 510);
            this.TxtAlis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtAlis.Name = "TxtAlis";
            this.TxtAlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlis.Properties.Appearance.Options.UseFont = true;
            this.TxtAlis.Size = new System.Drawing.Size(326, 50);
            this.TxtAlis.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(36, 516);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(129, 36);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Alış Fiyat:";
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(168, 281);
            this.TxtModel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtModel.Properties.Appearance.Options.UseFont = true;
            this.TxtModel.Size = new System.Drawing.Size(326, 50);
            this.TxtModel.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(72, 287);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 36);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Model:";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(168, 167);
            this.TxtMarka.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMarka.Properties.Appearance.Options.UseFont = true;
            this.TxtMarka.Size = new System.Drawing.Size(326, 50);
            this.TxtMarka.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(68, 173);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 36);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Marka:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(168, 110);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Size = new System.Drawing.Size(326, 50);
            this.TxtAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(114, 115);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 36);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ad:";
            // 
            // MskYil
            // 
            this.MskYil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskYil.Location = new System.Drawing.Point(168, 339);
            this.MskYil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MskYil.Mask = "0000";
            this.MskYil.Name = "MskYil";
            this.MskYil.Size = new System.Drawing.Size(322, 44);
            this.MskYil.TabIndex = 4;
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(168, 52);
            this.Txtid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txtid.Name = "Txtid";
            this.Txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Properties.Appearance.Options.UseFont = true;
            this.Txtid.Size = new System.Drawing.Size(326, 50);
            this.Txtid.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(114, 58);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 36);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // txtAracMarka
            // 
            this.txtAracMarka.Location = new System.Drawing.Point(164, 223);
            this.txtAracMarka.Margin = new System.Windows.Forms.Padding(6);
            this.txtAracMarka.Name = "txtAracMarka";
            this.txtAracMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracMarka.Properties.Appearance.Options.UseFont = true;
            this.txtAracMarka.Size = new System.Drawing.Size(326, 50);
            this.txtAracMarka.TabIndex = 23;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(6, 230);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(160, 36);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Arac Marka:";
            // 
            // txtIskonto1
            // 
            this.txtIskonto1.Location = new System.Drawing.Point(168, 572);
            this.txtIskonto1.Margin = new System.Windows.Forms.Padding(6);
            this.txtIskonto1.Name = "txtIskonto1";
            this.txtIskonto1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIskonto1.Properties.Appearance.Options.UseFont = true;
            this.txtIskonto1.Size = new System.Drawing.Size(326, 50);
            this.txtIskonto1.TabIndex = 25;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(32, 578);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(134, 36);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Iskonto 1:";
            // 
            // txtIskonto2
            // 
            this.txtIskonto2.Location = new System.Drawing.Point(168, 634);
            this.txtIskonto2.Margin = new System.Windows.Forms.Padding(6);
            this.txtIskonto2.Name = "txtIskonto2";
            this.txtIskonto2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIskonto2.Properties.Appearance.Options.UseFont = true;
            this.txtIskonto2.Size = new System.Drawing.Size(326, 50);
            this.txtIskonto2.TabIndex = 27;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(32, 640);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(134, 36);
            this.labelControl12.TabIndex = 28;
            this.labelControl12.Text = "Iskonto 2:";
            // 
            // txtIskonto3
            // 
            this.txtIskonto3.Location = new System.Drawing.Point(168, 696);
            this.txtIskonto3.Margin = new System.Windows.Forms.Padding(6);
            this.txtIskonto3.Name = "txtIskonto3";
            this.txtIskonto3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIskonto3.Properties.Appearance.Options.UseFont = true;
            this.txtIskonto3.Size = new System.Drawing.Size(326, 50);
            this.txtIskonto3.TabIndex = 29;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(32, 702);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(134, 36);
            this.labelControl13.TabIndex = 30;
            this.labelControl13.Text = "Iskonto 3:";
            // 
            // txtOem
            // 
            this.txtOem.Location = new System.Drawing.Point(168, 395);
            this.txtOem.Margin = new System.Windows.Forms.Padding(6);
            this.txtOem.Name = "txtOem";
            this.txtOem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOem.Properties.Appearance.Options.UseFont = true;
            this.txtOem.Size = new System.Drawing.Size(326, 50);
            this.txtOem.TabIndex = 31;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(72, 401);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(72, 36);
            this.labelControl14.TabIndex = 32;
            this.labelControl14.Text = "OEM:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(168, 814);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(6);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(322, 46);
            this.txtBarkod.TabIndex = 33;
            this.txtBarkod.Text = "";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(68, 814);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(104, 36);
            this.labelControl15.TabIndex = 34;
            this.labelControl15.Text = "Barkod:";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1079);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmUrunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAracMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonto3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtSatis;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown NudAdet;
        private DevExpress.XtraEditors.TextEdit TxtAlis;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtModel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskYil;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.TextEdit txtOem;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtIskonto3;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtIskonto2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtIskonto1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtAracMarka;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.RichTextBox txtBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl15;
    }
}