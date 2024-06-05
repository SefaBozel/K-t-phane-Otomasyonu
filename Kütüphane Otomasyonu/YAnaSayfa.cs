using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class YAnaSayfa : Form
    {
        public YAnaSayfa()
        {
            InitializeComponent();
        }
        public string YoneticiAdSoyad;
        private void button4_Click(object sender, EventArgs e)
        {
            PAnaSayfa pas = new PAnaSayfa();
            pas.isimsoyisim = label1.Text;
            pas.Show();
        }

        private void YAnaSayfa_Load(object sender, EventArgs e)
        {
            label1.Text = YoneticiAdSoyad;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YDuyuru yd = new YDuyuru();
            yd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PKitapListesi pkl = new PKitapListesi();
            pkl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YPersonelListesi ypl = new YPersonelListesi();
            ypl.Show();
        }
    }
}
