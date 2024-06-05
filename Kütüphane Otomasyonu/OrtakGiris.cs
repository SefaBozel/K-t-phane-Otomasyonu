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
    public partial class OrtakGiris : Form
    {
        public OrtakGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_KGiris_Click(object sender, EventArgs e)
        {
            KGiris kg = new KGiris();
            kg.Show();
            this.Hide();
        }

        private void btn_PGiris_Click(object sender, EventArgs e)
        {
            PGiris pg = new PGiris();
            pg.Show();
            this.Hide();
        }

        private void btn_YGiris_Click(object sender, EventArgs e)
        {
            YGiris yg = new YGiris();
            yg.Show();
            this.Hide();
        }
    }
}
