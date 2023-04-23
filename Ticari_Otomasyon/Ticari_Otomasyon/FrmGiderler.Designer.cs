namespace Ticari_Otomasyon
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtElektrik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CmbYil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.RchNotlar = new System.Windows.Forms.RichTextBox();
            this.CmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txtinternet = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtEkstra = new DevExpress.XtraEditors.TextEdit();
            this.TxtMaaslar = new DevExpress.XtraEditors.TextEdit();
            this.TxtDogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDigerGider = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtinternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaaslar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigerGider.Properties)).BeginInit();
            this.SuspendLayout();
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
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Location = new System.Drawing.Point(18, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(2172, 1071);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(174, 1000);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(326, 62);
            this.BtnTemizle.TabIndex = 29;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Location = new System.Drawing.Point(174, 225);
            this.TxtElektrik.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtElektrik.Properties.Appearance.Options.UseFont = true;
            this.TxtElektrik.Size = new System.Drawing.Size(326, 50);
            this.TxtElektrik.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(120, 58);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 36);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // CmbYil
            // 
            this.CmbYil.Location = new System.Drawing.Point(174, 165);
            this.CmbYil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmbYil.Name = "CmbYil";
            this.CmbYil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbYil.Properties.Appearance.Options.UseFont = true;
            this.CmbYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbYil.Properties.Items.AddRange(new object[] {
            "2017",
            "2018"});
            this.CmbYil.Size = new System.Drawing.Size(326, 50);
            this.CmbYil.TabIndex = 2;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(174, 927);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(326, 62);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(174, 52);
            this.Txtid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txtid.Name = "Txtid";
            this.Txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Properties.Appearance.Options.UseFont = true;
            this.Txtid.Size = new System.Drawing.Size(326, 50);
            this.Txtid.TabIndex = 100;
            // 
            // RchNotlar
            // 
            this.RchNotlar.Location = new System.Drawing.Point(174, 634);
            this.RchNotlar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RchNotlar.Name = "RchNotlar";
            this.RchNotlar.Size = new System.Drawing.Size(322, 117);
            this.RchNotlar.TabIndex = 9;
            this.RchNotlar.Text = "";
            // 
            // CmbAy
            // 
            this.CmbAy.Location = new System.Drawing.Point(174, 110);
            this.CmbAy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbAy.Properties.Appearance.Options.UseFont = true;
            this.CmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbAy.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.CmbAy.Size = new System.Drawing.Size(326, 50);
            this.CmbAy.TabIndex = 1;
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(168, 853);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(326, 62);
            this.BtnSil.TabIndex = 20;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(118, 115);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 36);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ay:";
            // 
            // Txtinternet
            // 
            this.Txtinternet.Location = new System.Drawing.Point(174, 396);
            this.Txtinternet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txtinternet.Name = "Txtinternet";
            this.Txtinternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtinternet.Properties.Appearance.Options.UseFont = true;
            this.Txtinternet.Size = new System.Drawing.Size(326, 50);
            this.Txtinternet.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDigerGider);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.TxtEkstra);
            this.groupControl1.Controls.Add(this.TxtMaaslar);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.TxtElektrik);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.CmbYil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.RchNotlar);
            this.groupControl1.Controls.Add(this.CmbAy);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Txtinternet);
            this.groupControl1.Controls.Add(this.TxtDogalgaz);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.TxtSu);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Location = new System.Drawing.Point(2202, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(520, 1071);
            this.groupControl1.TabIndex = 9;
            // 
            // TxtEkstra
            // 
            this.TxtEkstra.Location = new System.Drawing.Point(174, 572);
            this.TxtEkstra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtEkstra.Name = "TxtEkstra";
            this.TxtEkstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEkstra.Properties.Appearance.Options.UseFont = true;
            this.TxtEkstra.Size = new System.Drawing.Size(326, 50);
            this.TxtEkstra.TabIndex = 8;
            // 
            // TxtMaaslar
            // 
            this.TxtMaaslar.Location = new System.Drawing.Point(174, 454);
            this.TxtMaaslar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtMaaslar.Name = "TxtMaaslar";
            this.TxtMaaslar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMaaslar.Properties.Appearance.Options.UseFont = true;
            this.TxtMaaslar.Size = new System.Drawing.Size(326, 50);
            this.TxtMaaslar.TabIndex = 7;
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.Location = new System.Drawing.Point(174, 338);
            this.TxtDogalgaz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDogalgaz.Properties.Appearance.Options.UseFont = true;
            this.TxtDogalgaz.Size = new System.Drawing.Size(326, 50);
            this.TxtDogalgaz.TabIndex = 5;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(168, 780);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(326, 62);
            this.BtnKaydet.TabIndex = 19;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(124, 171);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 36);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Yıl:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(72, 577);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(93, 36);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "Ekstra:";
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(174, 281);
            this.TxtSu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSu.Properties.Appearance.Options.UseFont = true;
            this.TxtSu.Size = new System.Drawing.Size(326, 50);
            this.TxtSu.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(52, 460);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(113, 36);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Maaşlar:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(64, 231);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(109, 36);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Elektrik:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(46, 402);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(119, 36);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "İnternet:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(34, 344);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(133, 36);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Doğalgaz:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(76, 634);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 36);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Notlar:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(120, 287);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 36);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Su:";
            // 
            // txtDigerGider
            // 
            this.txtDigerGider.Location = new System.Drawing.Point(174, 516);
            this.txtDigerGider.Margin = new System.Windows.Forms.Padding(6);
            this.txtDigerGider.Name = "txtDigerGider";
            this.txtDigerGider.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDigerGider.Properties.Appearance.Options.UseFont = true;
            this.txtDigerGider.Size = new System.Drawing.Size(326, 50);
            this.txtDigerGider.TabIndex = 101;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(3, 523);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(162, 36);
            this.labelControl9.TabIndex = 102;
            this.labelControl9.Text = "Diger Gider:";
            // 
            // FrmGiderler
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnTemizle;
            this.ClientSize = new System.Drawing.Size(2740, 1079);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmGiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtinternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaaslar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigerGider.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.TextEdit TxtElektrik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit CmbYil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private System.Windows.Forms.RichTextBox RchNotlar;
        private DevExpress.XtraEditors.ComboBoxEdit CmbAy;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txtinternet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtDogalgaz;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtSu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtEkstra;
        private DevExpress.XtraEditors.TextEdit TxtMaaslar;
        private DevExpress.XtraEditors.TextEdit txtDigerGider;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}