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
    public partial class KGiris : Form
    {
        public KGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void lbl_KayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KKayıtOl ko = new KKayıtOl();
            ko.Show();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kullanici where (KullaniciIsim+' '+KullaniciSoyisim)=@k1 and KullaniciSifre=@k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_IsimSoyisim.Text);
            komut.Parameters.AddWithValue("@k2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                KAnaSayfa ana = new KAnaSayfa();
                ana.kullaniciadi = txt_IsimSoyisim.Text;
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Veri Girdiniz..");
            }
            bgl.baglanti().Close();
        }
    }
}
