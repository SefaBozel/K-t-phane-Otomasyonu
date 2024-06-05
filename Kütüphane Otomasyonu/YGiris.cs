using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class YGiris : Form
    {
        public YGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Yonetici where (YoneticiIsim + ' ' + YoneticiSoyisim)=@k1 and YoneticiSifre=@k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_IsimSoyisim.Text);
            komut.Parameters.AddWithValue("@k2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                YAnaSayfa ana = new YAnaSayfa();
                ana.YoneticiAdSoyad = txt_IsimSoyisim.Text;
                ana.Show();
                this.Hide();
            }
        }
    }
}
