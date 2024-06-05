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
    public partial class KAnaSayfa : Form
    {
        public KAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string kullaniciadi;
        public string kullaniciid;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            lbl_İsim.Text = kullaniciadi;
            SqlCommand komut = new SqlCommand("select KullaniciTC from Kullanici where (KullaniciIsim+' '+KullaniciSoyisim)=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_İsim.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_TC.Text = dr[0].ToString();
            }
            dr.Close();
            //
            SqlCommand komut1 = new SqlCommand("select KullaniciID from Kullanici where (KullaniciIsim+' '+KullaniciSoyisim)=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbl_İsim.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                txt_kid.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();
            //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kitap",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string yazaradi = dataGridView1.Rows[secilen].Cells["yazaradi"].Value.ToString();
            string yazarsoyadi = dataGridView1.Rows[secilen].Cells["yazarsoyadi"].Value.ToString();
            txt_Yazar.Text = yazaradi + " " + yazarsoyadi;
            txt_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into EmanetOnay (KullaniciID,KullaniciAdi,KitapID,KitapAdi,YazarAdi,AlınanTarih,TeslimTarihi,Onay) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@Onay)", bgl.baglanti());
            komut.Parameters.AddWithValue("@a1", txt_kid.Text);
            komut.Parameters.AddWithValue("@a2", lbl_İsim.Text);
            komut.Parameters.AddWithValue("@a3", txt_ID.Text);
            komut.Parameters.AddWithValue("@a4", txt_Ad.Text);
            komut.Parameters.AddWithValue("@a5", txt_Yazar.Text);
            komut.Parameters.AddWithValue("@a6", dateTimePicker2.Value);
            komut.Parameters.AddWithValue("@a7", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@onay", false);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitabı ödünç alma talebiniz görevlilere bildirilmiştir.\n Son Teslim Tarihi: " + dateTimePicker1.Value.ToShortDateString());
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kitap", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KAldigiKitaplar kak = new KAldigiKitaplar();
            kak.kadi = lbl_İsim.Text;
            kak.Show();
        }
    }
}