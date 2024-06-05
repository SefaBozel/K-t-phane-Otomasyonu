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
    public partial class PAnaSayfa : Form
    {
        public PAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string isimsoyisim;
        private void PAnaSayfa_Load(object sender, EventArgs e)
        {
            lbl_İsim.Text = isimsoyisim;
            SqlCommand komut = new SqlCommand("select PersonelTC from Personel where (PersonelIsim+' '+PersonelSoyisim)=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_İsim.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_TC.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Kitap", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from AlinanKitap", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PKitapListesi pkl = new PKitapListesi();
            pkl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PKullaniciListesi kl = new PKullaniciListesi();
            kl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmanetOnay eo = new EmanetOnay();
            eo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TeslimOnay to = new TeslimOnay();
            to.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PDuyuru pd = new PDuyuru();
            pd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PGecikenEmanetler pge = new PGecikenEmanetler();
            pge.Show();
        }
    }
}
