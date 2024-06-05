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

namespace Kütüphane_Otomasyonu
{
    public partial class YPersonelListesi : Form
    {
        public YPersonelListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void YPersonelListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from personel",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Isim.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyisim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Tel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelIsim,PersonelSoyisim,PersonelTel,PersonelTC,PersonelSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Isim.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyisim.Text);
            komut.Parameters.AddWithValue("@p3", txt_Tel.Text);
            komut.Parameters.AddWithValue("@p4", txt_TC.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla kayıt edilmiştir.");
            txt_Isim.Text = "";
            txt_Soyisim.Text = "";
            txt_Tel.Text = "";
            txt_TC.Text = "";
            txt_Sifre.Text = "";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from personel", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set PersonelIsim=@p1,PersonelSoyisim=@p2,PersonelTel=@p3,PersonelTC=@p4,PersonelSifre=@p5 where PersonelID=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Isim.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyisim.Text);
            komut.Parameters.AddWithValue("@p3", txt_Tel.Text);
            komut.Parameters.AddWithValue("@p4", txt_TC.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p6", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from personel", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from personel", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
