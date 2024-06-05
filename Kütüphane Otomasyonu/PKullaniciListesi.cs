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

namespace Kütüphane_Otomasyonu
{
    public partial class PKullaniciListesi : Form
    {
        public PKullaniciListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void PKullaniciListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kullanici", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kullanici (KullaniciIsim,KullaniciSoyisim,KullaniciTel,KullaniciTC,KullaniciSifre) values (@k1,@k2,@k3,@k4,@k5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Kisim.Text);
            komut.Parameters.AddWithValue("@k2", txt_Ksoyisim.Text);
            komut.Parameters.AddWithValue("@k3", txt_Ktel.Text);
            komut.Parameters.AddWithValue("@k4", txt_Ktc.Text);
            komut.Parameters.AddWithValue("@k5", txt_Ksifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı başarıyla kaydedilmiştir.");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kullanici", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Kullanici set KullaniciIsim=@k1,KullaniciSoyisim=@k2,KullaniciTel=@k3,KullaniciTC=@k4,KullaniciSifre=@k5 where KullaniciID=@k6", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Kisim.Text);
            komut.Parameters.AddWithValue("@k2", txt_Ksoyisim.Text);
            komut.Parameters.AddWithValue("@k3", txt_Ktel.Text);
            komut.Parameters.AddWithValue("@k4", txt_Ktc.Text);
            komut.Parameters.AddWithValue("@k5", txt_Ksifre.Text);
            komut.Parameters.AddWithValue("@k6", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı başarıyla güncellenmiştir.");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kullanici", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Kisim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Ksoyisim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Ktel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_Ktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Ksifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete Kullanici where KullaniciID=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı başarıyla silinmiştir.");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kullanici", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
