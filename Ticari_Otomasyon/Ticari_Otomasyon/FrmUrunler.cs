using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            TxtAd.Text = "";
            TxtAlis.Text = "";
            Txtid.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            TxtSatis.Text = "";
            MskYil.Text = "";
            NudAdet.Value = 0;
            RchDetay.Text = "";
            txtOem.Text = "";
            txtIskonto1.Text = "";
            txtIskonto2.Text = "";
            txtIskonto3.Text = "";
            txtAracMarka.Text = "";
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();

            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            Txtid.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            txtAracMarka.Text = dr["ARACMARKA"].ToString();
            TxtModel.Text = dr["MODEL"].ToString();
            MskYil.Text = dr["YIL"].ToString();
            NudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            TxtAlis.Text = dr["ALISFIYAT"].ToString();
            txtIskonto1.Text = dr["ISKONTO"].ToString();
            txtIskonto2.Text = dr["ISKONTO2"].ToString();
            txtIskonto3.Text = dr["ISKONTO3"].ToString();
            TxtSatis.Text = dr["SATISFIYAT"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();
            txtOem.Text= dr["OEM"].ToString();
            txtBarkod.Text = dr["BARKOD"].ToString();
        }


        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_URUNLER set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,ISKONTO=@P7,SATISFIYAT=@P8,DETAY=@P9,ISKONTO2=@P10,ISKONTO3=@P11,OEM=@P12,BARKOD=@P13,,ARACMARKA=@P14 where ID=@P15", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtIskonto1.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p9", RchDetay.Text);
            komut.Parameters.AddWithValue("@p10", decimal.Parse(txtIskonto2.Text));
            komut.Parameters.AddWithValue("@p11", decimal.Parse(txtIskonto3.Text));
            komut.Parameters.AddWithValue("@p12", txtOem.Text);
            komut.Parameters.AddWithValue("@p13", txtBarkod.Text);
            komut.Parameters.AddWithValue("@p14", txtAracMarka.Text);
            komut.Parameters.Add("@p15", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_URUNLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Verileri Kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,ISKONTO,SATISFIYAT,DETAY,ISKONTO2,ISKONTO3,OEM,BARKOD,ARACMARKA) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtIskonto1.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p9", RchDetay.Text);
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtIskonto2.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtIskonto3.Text));
            komut.Parameters.AddWithValue("@p6", txtOem.Text);
            komut.Parameters.AddWithValue("@p6", txtBarkod.Text);
            komut.Parameters.AddWithValue("@p6", txtAracMarka.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
