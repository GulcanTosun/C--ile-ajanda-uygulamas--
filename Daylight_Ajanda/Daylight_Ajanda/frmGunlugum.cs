using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//ekle
using System.Data;//ekle
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Daylight_Ajanda
{
    public partial class frmGunlugum : Form
    {
        public frmGunlugum()
        {
            InitializeComponent();
        }
       SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-2BUCSTS1;Initial Catalog=GunlukDB;Integrated Security=True");
        private void frmGunlugum_Load(object sender, EventArgs e)
        {
            veriler();
            tmrSaatTarih.Start();

        }
        private void veriler()
        {
            listGunluk.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Note", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Tarih"].ToString();
                ekle.SubItems.Add(oku["Gunluk"].ToString());
                listGunluk.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void tmrSaatTarih_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmGunluk fr = new frmGunluk();
            fr.Show();
            this.Hide();
        }
    }
}
