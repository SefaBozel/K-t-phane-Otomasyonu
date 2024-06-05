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
    public partial class KOncedenAldiklari : Form
    {
        public KOncedenAldiklari()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string Kisimsoyisim;
        private void KOncedenAldiklari_Load(object sender, EventArgs e)
        {
            lbl_İsim.Text = Kisimsoyisim;
            SqlCommand komut = new SqlCommand("select * from AlinanKitap where Teslim=1 and KullaniciAdi = @KullaniciAdi", bgl.baglanti());
            komut.Parameters.AddWithValue("@KullaniciAdi", lbl_İsim.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
