using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.parser;

namespace Daylight_Ajanda
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            webEkitap.Navigate("https://e-kitaphavuzu.com/");
            tmrTarihSaat.Start();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmUserPanel fr = new frmUserPanel();
            fr.Show();
            this.Hide();
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

