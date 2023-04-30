using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daylight_Ajanda
{
    public partial class frmGunluk : Form
    {
        public frmGunluk()
        {
            InitializeComponent();
        }

        private void frmGunluk_Load(object sender, EventArgs e)
        {
            tmrTarihSaat.Start();
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmUserPanel fr = new frmUserPanel();
            fr.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UserProvider up = new UserProvider();
            User gunluk = new User();
            gunluk.Gunluk = txtGunluk.Text;
            gunluk.DateTime = datetime.Value.ToString();
            up.Gunluk(gunluk);
            MessageBox.Show("Günlük kaydedildi.", "Günlük kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGunluk.Text = "";
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            frmGunlugum fr = new frmGunlugum();
            fr.Show();
            this.Hide();
        }
    }
}
