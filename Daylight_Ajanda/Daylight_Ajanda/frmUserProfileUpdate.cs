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
    public partial class frmUserProfileUpdate : Form
    {
        public frmUserProfileUpdate()
        {
            InitializeComponent();
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmUserProfileUpdate_Load(object sender, EventArgs e)
        {
            tmrTarihSaat.Start();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmUserPanel fr = new frmUserPanel();
            fr.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

        }
    }
}
