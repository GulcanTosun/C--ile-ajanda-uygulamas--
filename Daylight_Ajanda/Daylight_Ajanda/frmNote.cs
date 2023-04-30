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
    public partial class frmNote : Form
    {
        public frmNote()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-2BUCSTS1;Initial Catalog=GunlukDB;Integrated Security=True");
        private void tmrSaatTarih_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            tmrSaatTarih.Start();
            veriler();
        }
        private void veriler()
        {
            listNot.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Notlar", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["NotAd"].ToString();
                listNot.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void btnNotOlustur_Click(object sender, EventArgs e)
        {
            UserProvider up = new UserProvider();
            User not = new User();
            not.Not = txtNot.Text;
            up.Not(not);
            MessageBox.Show("Not kaydedildi.", "Not oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNot.Clear();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmUserPanel fr = new frmUserPanel();
            fr.Show();
            this.Hide();
        }
    }
}
