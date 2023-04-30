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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;
using Daylight_Ajanda;

namespace Daylight_Ajanda
{
    public partial class frmSingUpPanel : Form
    {
        public frmSingUpPanel()
        {
            InitializeComponent();
        }
        UserProvider up = new UserProvider();

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
 
            #region Ad Kontrolü

            if (txtAd.Text == "")
                errorAd.SetError(txtAd, "Ad alanı boş bırakılamaz.");

            else if (txtAd.TextLength == 30)
                errorAd.SetError(txtAd, "Ad alanına 30 karakterden fazlasını yazılamaz.");

            else
                errorAd.Clear();

            #endregion

            #region Soyad Kontrolü

            if (txtSoyad.Text == "")
                errorSoyad.SetError(txtSoyad, "Soyad alanı boş bırakılamaz.");

            else if (txtSoyad.TextLength == 30)
                errorSoyad.SetError(txtSoyad, "Soyad alanına 30 karakterden fazlasını yazılamaz.");

            else
                errorSoyad.Clear();

            #endregion

            #region Kullanıcı Adı Kontrolü

            if (txtKullaniciAdi.Text == "")
                errorKullaniciAdi.SetError(txtKullaniciAdi, "Kullanıcı Adı alanı boş bırakılamaz.");

            else if (txtKullaniciAdi.TextLength == 20)
                errorKullaniciAdi.SetError(txtKullaniciAdi, "Kullanıcı Adı alanına 20 karakterden fazlasını yazılamaz.");

            else
                errorKullaniciAdi.Clear();

            #endregion

            #region Telefon No Kontrolü

            if (msgTelefon.Text.Length != 15)
                errorTelefon.SetError(msgTelefon, "Telefon No alanı 10 karakterli olmalıdır.");

            if (msgTelefon.Text.Length == 15)
                errorTelefon.Clear();

            #endregion Telefon No Kontrolü

            #region Eposta Kontrolü

            if (txtEposta.Text == "")
                errorEposta.SetError(txtEposta, "Eposta alanı boş bırakılamaz.");

            else if (txtEposta.TextLength == 30)
                errorEposta.SetError(txtEposta, "Soyad alanına 30 karakterden fazlasını yazılamaz.");

            else
                errorEposta.Clear();

            #endregion

            #region Kullanıcı Türü Kontrolü

            if (comboKullaniciTur.Text == "")
                errorKullaniciTur.SetError(comboKullaniciTur, "Kullanıcı Türü alanı boş bırakılamaz.");

            else
                errorKullaniciTur.Clear();

            #endregion

            #region Şifre Kontrolü

            if (txtSifre.Text == "")
                errorSifre.SetError(txtSifre, "Şifre alanı boş bırakılamaz.");

            else if (txtSifre.TextLength == 20)
                errorSifre.SetError(txtSifre, "Şifre alanına 20 karakterden fazlasını yazılamaz.");

            else 
            {
                errorSifre.Clear();
                User yenikisi = new User();
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.KullaniciAdi = txtKullaniciAdi.Text;
                yenikisi.Telefon = msgTelefon.Text;
                yenikisi.Eposta = txtEposta.Text;
                yenikisi.KullaniciTuru = comboKullaniciTur.Text;
                yenikisi.Sifre = txtSifre.Text;
                up.Ekle(yenikisi);
                MessageBox.Show("Kayıt başarılı bir şekilde kaydedildi.", "Kayıt Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmUserPanelLognIn fr = new frmUserPanelLognIn();
                fr.Show();
                this.Hide();
            }
            #endregion

            if ((txtAd.Text.Length >0)&&(txtSoyad.Text.Length > 0)&&(txtKullaniciAdi.TextLength > 0)&&(msgTelefon.Text.Length > 0)&&(txtEposta.TextLength > 0)&&(comboKullaniciTur.Text.Length > 0)&&(txtSifre.TextLength > 0))
            {
                User yenikisi = new User();
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.KullaniciAdi = txtKullaniciAdi.Text;
                yenikisi.Telefon = msgTelefon.Text;
                yenikisi.Eposta = txtEposta.Text;
                yenikisi.KullaniciTuru = comboKullaniciTur.Text;
                yenikisi.Sifre = txtSifre.Text;
                up.Ekle(yenikisi);
                MessageBox.Show("Kayıt başarılı bir şekilde kaydedildi.", "Kayıt Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmUserPanelLognIn fr = new frmUserPanelLognIn();
                fr.Show();
                this.Hide();
            }
        }

    }
}
