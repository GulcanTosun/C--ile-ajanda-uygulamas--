using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
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
    public partial class frmUserPanel : Form
    {
        public frmUserPanel()
        {
            InitializeComponent();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmUserPanel_Load(object sender, EventArgs e)
        {
            tmrSaatTarih.Start();
        }

        private void sosyalMedyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sosyalMedyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrSaatTarih_Tick(object sender, EventArgs e)
        {

            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfilGuncelle_Click(object sender, EventArgs e)
        {
            frmUserProfileUpdate fr = new frmUserProfileUpdate();
            fr.Show();
            this.Hide();
        }

        private void btnEkitap_Click(object sender, EventArgs e)
        {
            frmBook frkitap = new frmBook();
            frkitap.Show();
            this.Hide();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            frmPlans pl = new frmPlans();   
            pl.Show();
            this.Hide();
        }

        private void btnKendimeNot_Click(object sender, EventArgs e)
        {
            frmGunluk fr = new frmGunluk();
            fr.Show();
            this.Hide();
        }

        private void btnHedef_Click(object sender, EventArgs e)
        {
            frmHedefler fr = new frmHedefler(); 
            fr.Show();
            this.Hide();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            frmNote fr = new frmNote();
            fr.Show();
            this.Hide();
        }
    }
}
