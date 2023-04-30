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
using System.Data.SqlClient;
using System.Data.Sql;


namespace Daylight_Ajanda
{
    public partial class frmUserPanelLognIn : Form
    {
        public frmUserPanelLognIn()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void linkKayitol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmSingUpPanel singUpPanel = new frmSingUpPanel();
            singUpPanel.Show();
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            string sorgu = "SELECT * FROM [User] where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
            con = new SqlConnection("Data Source=LAPTOP-2BUCSTS1;Initial Catalog=GunlukDB;Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmUserPanel fr = new frmUserPanel();
                fr.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz.");
            }
            con.Close();

        }
    }
}
