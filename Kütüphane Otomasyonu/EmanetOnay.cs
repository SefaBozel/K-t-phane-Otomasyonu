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
    public partial class EmanetOnay : Form
    {
        public EmanetOnay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void EmanetOnay_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from EmanetOnay where Onay=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_KullaniciID.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_KullaniciAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_KitapID.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_KitapAdi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_YazarAdi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if (DateTime.TryParse(dataGridView1.Rows[secilen].Cells[6].Value.ToString(), out DateTime alimTarihi))
            {
                dtp_Alim.Value = alimTarihi;
            }
            if (DateTime.TryParse(dataGridView1.Rows[secilen].Cells[7].Value.ToString(), out DateTime teslimTarihi))
            {
                dtm_Teslim.Value = teslimTarihi;
            }
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            SqlCommand onay = new SqlCommand("insert into AlinanKitap (KullaniciAdi,KitapAdi,YazarAdi,AlinanTarih,TeslimTarih,KitapID,KullaniciID,Teslim) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7,0)",bgl.baglanti());
            onay.Parameters.AddWithValue("@k1", txt_KullaniciAdi.Text);
            onay.Parameters.AddWithValue("@k2", txt_KitapAdi.Text);
            onay.Parameters.AddWithValue("@k3", txt_YazarAdi.Text);
            onay.Parameters.AddWithValue("@k4", dtp_Alim.Value);
            onay.Parameters.AddWithValue("@k5", dtm_Teslim.Value);
            onay.Parameters.AddWithValue("@k6", txt_KitapID.Text);
            onay.Parameters.AddWithValue("@k7", txt_KullaniciID.Text);
            onay.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand temizle = new SqlCommand("Delete EmanetOnay where KullaniciID=@e1 and KitapID=@e2", bgl.baglanti());
            temizle.Parameters.AddWithValue("@e1", txt_KullaniciID.Text);
            temizle.Parameters.AddWithValue("@e2", txt_KitapID.Text);
            temizle.ExecuteNonQuery();
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from EmanetOnay where Onay = 0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
