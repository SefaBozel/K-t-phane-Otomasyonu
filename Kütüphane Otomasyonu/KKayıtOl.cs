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
    public partial class KKayıtOl : Form
    {
        public KKayıtOl()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_KayıtOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kullanici (KullaniciIsim,KullaniciSoyisim,KullaniciTel,KullaniciTC,KullaniciSifre) values(@k1,@k2,@k3,@k4,@k5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_Isim.Text);
            komut.Parameters.AddWithValue("@k2", txt_Soyisim.Text);
            komut.Parameters.AddWithValue("@k3", txt_Tel.Text);
            komut.Parameters.AddWithValue("@k4",txt_TC.Text);
            komut.Parameters.AddWithValue("@k5", txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Alınmıştır. \n Kullanıcı Adınız= " + (txt_Isim.Text + txt_Soyisim.Text) + "\n Şifreniz= " + txt_Sifre.Text);
        }
    }
}
