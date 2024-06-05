using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class PKitapListesi : Form
    {
        public PKitapListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void PKitapListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kitap",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kitap (KitapAdi,YazarAdi,YazarSoyadi,SayfaSayisi,KitapYayinevi,KitapTuru) values (@k1,@k2,@k3,@k4,@k5,@k6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_KitapAdi.Text);
            komut.Parameters.AddWithValue("@k2", txt_YazarAdi.Text);
            komut.Parameters.AddWithValue("@k3", txt_YazarSoyadi.Text);
            komut.Parameters.AddWithValue("@k4", txt_SayfaSayisi.Text);
            komut.Parameters.AddWithValue("@k5", txt_Yayinevi.Text);
            komut.Parameters.AddWithValue("@k6", cmb_Tur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Başarıyla Kaydedildi.");
            txt_KitapAdi.Clear();
            txt_YazarAdi.Clear();
            txt_YazarSoyadi.Clear();
            txt_SayfaSayisi.Clear();
            txt_Yayinevi.Clear();
            cmb_Tur.Text = "";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kitap", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update kitap set KitapAdi=@k1,YazarAdi=@k2,YazarSoyadi=@k3,SayfaSayisi=@k4,KitapYayinEvi=@k5,KitapTuru=@k6 where kitap_ID = @Kitap_ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_KitapAdi.Text);
            komut.Parameters.AddWithValue("@k2", txt_YazarAdi.Text);
            komut.Parameters.AddWithValue("@k3", txt_YazarSoyadi.Text);
            komut.Parameters.AddWithValue("@k4", txt_SayfaSayisi.Text);
            komut.Parameters.AddWithValue("@k5", txt_Yayinevi.Text);
            komut.Parameters.AddWithValue("@k6", cmb_Tur.Text);
            komut.Parameters.AddWithValue("@kitap_ID", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Bilgileri Başarıyla Güncellendi.");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kitap", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_KitapAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_YazarAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_YazarSoyadi.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_SayfaSayisi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Yayinevi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmb_Tur.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete kitap where Kitap_ID=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Başarıyla Silinmiştir.");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kitap", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
