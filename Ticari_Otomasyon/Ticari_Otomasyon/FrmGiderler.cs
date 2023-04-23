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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER Order By ID Asc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            TxtDogalgaz.Text = "";
            TxtEkstra.Text = "";
            TxtElektrik.Text = "";
            Txtid.Text = "";
            Txtinternet.Text = "";
            TxtMaaslar.Text = "";
            TxtSu.Text = "";
            CmbAy.Text = "";
            CmbYil.Text = "";
            RchNotlar.Text = "";
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderlistesi();

            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER  (ODENECEKFATURA1,ODENECEKFATURA2,ODENECEKFATURA3,ODENECEKFATURA4,MAASLAR,ODENECEKFATURA5,ODENECEKFATURA6,NOTLAR,AY,YIL) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p10", CmbAy.Text);
            komut.Parameters.AddWithValue("@p9", CmbYil.Text);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@p2", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(Txtinternet.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtMaaslar.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtDigerGider.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@p8", RchNotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider tabloya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
            //temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                CmbAy.Text = dr["AY"].ToString();
                CmbYil.Text = dr["YIL"].ToString();
                TxtElektrik.Text = dr["ODENECEKFATURA1"].ToString();
                TxtSu.Text = dr["ODENECEKFATURA2"].ToString();
                TxtDogalgaz.Text = dr["ODENECEKFATURA3"].ToString();
                Txtinternet.Text = dr["ODENECEKFATURA4"].ToString();
                TxtMaaslar.Text = dr["MAASLAR"].ToString();
                TxtEkstra.Text = dr["ODENECEKFATURA6"].ToString();
                RchNotlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_GIDERLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderlistesi();
            MessageBox.Show("Gider Listeden Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_GIDERLER set ODENECEKFATURA1=@P1,ODENECEKFATURA2=@P2,ODENECEKFATURA3=@P3,ODENECEKFATURA4=@P4,MAASLAR=@P5,ODENECEKFATURA5=@P6,ODENECEKFATURA6=@P7,NOTLAR=@P8,AY=@P9,YIL=@P10 where ID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p10", CmbAy.Text);
            komut.Parameters.AddWithValue("@p9", CmbYil.Text);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@p2", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(Txtinternet.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtMaaslar.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtDigerGider.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@p8", RchNotlar.Text);
            komut.Parameters.AddWithValue("@p11", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            giderlistesi();
            temizle();
        }
    }
}
