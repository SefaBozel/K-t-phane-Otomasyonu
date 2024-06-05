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
    public partial class KAldigiKitaplar : Form
    {
        public KAldigiKitaplar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string kadi;
        private void KAldigiKitaplar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from AlinanKitap where Teslim=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            lbl_KullaniciAdi.Text = kadi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Kitap.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_yazar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (DateTime.TryParse(dataGridView1.Rows[secilen].Cells[4].Value.ToString(), out DateTime alimTarihi))
            {
                dtp_alim.Value = alimTarihi;
            }
            if (DateTime.TryParse(dataGridView1.Rows[secilen].Cells[5].Value.ToString(), out DateTime teslimTarihi))
            {
                dtp_teslim.Value = teslimTarihi;
            }
            txt_KitapID.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt_KullaniciID.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txt_KullaniciAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_TeslimEt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into EmanetOnay (KullaniciAdi,KitapAdi,AlınanTarih,TeslimTarihi,YazarAdi,Onay,KullaniciID,KitapID) values (@k1,@k2,@k3,@k4,@k5,@Onay,@k6,@k7)",bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_KullaniciAdi.Text);
            komut.Parameters.AddWithValue("@k2", txt_Kitap.Text);
            komut.Parameters.AddWithValue("@k3", dtp_alim.Value);
            komut.Parameters.AddWithValue("@k4", dtp_teslim.Value);
            komut.Parameters.AddWithValue("@k5", txt_yazar.Text);
            komut.Parameters.AddWithValue("@Onay", true);
            komut.Parameters.AddWithValue("@k6", txt_KullaniciID.Text);
            komut.Parameters.AddWithValue("@k7", txt_KitapID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Teslim Etme Başarılı.Kitabı Görevliye Teslim Ediniz.");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from AlinanKitap where Teslim=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            KOncedenAldiklari koc = new KOncedenAldiklari();
            koc.Kisimsoyisim = lbl_KullaniciAdi.Text;
            koc.Show();
        }
    }
}