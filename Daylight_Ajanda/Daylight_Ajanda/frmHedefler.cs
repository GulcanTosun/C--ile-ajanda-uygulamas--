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
    public partial class frmHedefler : Form
    {
        public frmHedefler()
        {
            InitializeComponent();
        }

        private void tmrSaatTarih_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmHedefler_Load(object sender, EventArgs e)
        {
            tmrSaatTarih.Start();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmUserPanel fr = new frmUserPanel();
            fr.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UserProvider up = new UserProvider();
            User hedef = new User();
            hedef.Kariyer = txtKariyer.Text;    
            hedef.Aile = txtAile.Text;  
            hedef.Arkadaslik = txtArkadaslik.Text;  
            hedef.Saglik = txtSaglik.Text;  
            hedef.Ev = txtEv.Text;  
            hedef.Ogrenme = txtOgrenme.Text;    
            hedef.Ask = txtAsk.Text;    
            hedef.Para = txtPara.Text;  
            hedef.KisiselGelisim = txtKisisel.Text;
            hedef.Fiziksel = txtFiziksel.Text;
            hedef.Sosyal = txtSosyal.Text;
            up.Hedef(hedef);
            MessageBox.Show("Hedef kaydedildi.", "Hedef kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtKariyer.Clear(); 
            txtAile.Clear();
            txtArkadaslik.Clear();
            txtSaglik.Clear();  
            txtEv.Clear();  
            txtOgrenme.Clear(); 
            txtAsk.Clear(); 
            txtPara.Clear();
            txtKisisel.Clear();
            txtFiziksel.Clear();
            txtSosyal.Clear();
            
        }

        private void btnHedefArsiv_Click(object sender, EventArgs e)
        {
            frmHedefArsiv fr = new frmHedefArsiv();
            fr.Show();
            this.Hide();
        }
    }
}
