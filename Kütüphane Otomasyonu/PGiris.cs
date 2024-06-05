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
    public partial class PGiris : Form
    {
        public PGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Personel where (PersonelIsim + ' ' + PersonelSoyisim)=@k1 and PersonelSifre=@k2",bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txt_İsimSoyisim.Text);
            komut.Parameters.AddWithValue("@k2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                PAnaSayfa ana = new PAnaSayfa();
                ana.isimsoyisim = txt_İsimSoyisim.Text;
                ana.Show();
                this.Hide();
            }
        }
    }
}
