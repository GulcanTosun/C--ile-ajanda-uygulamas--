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

namespace Daylight_Ajanda
{
    public partial class frmHedefArsiv : Form
    {
        public frmHedefArsiv()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-2BUCSTS1;Initial Catalog=GunlukDB;Integrated Security=True");
        private void frmHedefArsiv_Load(object sender, EventArgs e)
        {
            tmrSaatTarih.Start();
            veriler();
        }
        private void veriler()
        {
            listHedef.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Hedef", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kariyer"].ToString();
                ekle.SubItems.Add(oku["Aile"].ToString());
                ekle.SubItems.Add(oku["Arkadaslik"].ToString());
                ekle.SubItems.Add(oku["Saglık"].ToString());
                ekle.SubItems.Add(oku["Ev"].ToString());
                ekle.SubItems.Add(oku["Ogrenme"].ToString());
                ekle.SubItems.Add(oku["Ask"].ToString());
                ekle.SubItems.Add(oku["Para"].ToString());
                ekle.SubItems.Add(oku["KisiselGelisim"].ToString());
                ekle.SubItems.Add(oku["Fiziksel"].ToString());
                ekle.SubItems.Add(oku["Sosyal"].ToString());
               listHedef.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
           frmHedefler fr = new frmHedefler();
            fr.Show();
            this.Hide();
        }

        private void tmrSaatTarih_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
