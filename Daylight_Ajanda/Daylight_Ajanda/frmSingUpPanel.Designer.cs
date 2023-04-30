namespace Daylight_Ajanda
{
    partial class frmSingUpPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSingUpPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboKullaniciTur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msgTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorAd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoyad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorKullaniciAdi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEposta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSifre = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorKullaniciTur = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoyad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKullaniciAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSifre)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorKullaniciTur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboKullaniciTur);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.msgTelefon);
            this.panel1.Controls.Add(this.txtEposta);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.btnKayitOl);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(102, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 455);
            this.panel1.TabIndex = 1;
            // 
            // comboKullaniciTur
            // 
            this.comboKullaniciTur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboKullaniciTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboKullaniciTur.FormattingEnabled = true;
            this.comboKullaniciTur.Items.AddRange(new object[] {
            "Öğrenci",
            "Personel",
            "Araştırmacı"});
            this.comboKullaniciTur.Location = new System.Drawing.Point(229, 325);
            this.comboKullaniciTur.Name = "comboKullaniciTur";
            this.comboKullaniciTur.Size = new System.Drawing.Size(203, 28);
            this.comboKullaniciTur.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(88, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = " Kullanıcı Türü :";
            // 
            // msgTelefon
            // 
            this.msgTelefon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msgTelefon.Location = new System.Drawing.Point(229, 243);
            this.msgTelefon.Mask = "(000) 000 00 00";
            this.msgTelefon.Name = "msgTelefon";
            this.msgTelefon.Size = new System.Drawing.Size(203, 27);
            this.msgTelefon.TabIndex = 3;
            // 
            // txtEposta
            // 
            this.txtEposta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(229, 283);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(203, 27);
            this.txtEposta.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(229, 364);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(203, 27);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(91, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mail / E-posta :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(71, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Password / Şifre :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(229, 201);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(203, 27);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Username / Kullanıcı Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(78, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone / Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("STCaiyun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(133, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 63);
            this.label3.TabIndex = 6;
            this.label3.Text = "DAYLIGHT";
            // 
            // txtAd
            // 
            this.txtAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(229, 120);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(203, 27);
            this.txtAd.TabIndex = 0;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.Location = new System.Drawing.Point(335, 397);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(97, 31);
            this.btnKayitOl.TabIndex = 7;
            this.btnKayitOl.Text = "Sign up";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(229, 159);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(203, 27);
            this.txtSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name / Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name / Soyad :";
            // 
            // errorAd
            // 
            this.errorAd.ContainerControl = this;
            // 
            // errorSoyad
            // 
            this.errorSoyad.ContainerControl = this;
            // 
            // errorKullaniciAdi
            // 
            this.errorKullaniciAdi.ContainerControl = this;
            // 
            // errorTelefon
            // 
            this.errorTelefon.ContainerControl = this;
            // 
            // errorEposta
            // 
            this.errorEposta.ContainerControl = this;
            // 
            // errorSifre
            // 
            this.errorSifre.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-4, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 522);
            this.panel2.TabIndex = 0;
            // 
            // errorKullaniciTur
            // 
            this.errorKullaniciTur.ContainerControl = this;
            // 
            // frmSingUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 510);
            this.Controls.Add(this.panel2);
            this.Name = "frmSingUpPanel";
            this.Text = "Sing Up ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoyad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKullaniciAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSifre)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorKullaniciTur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msgTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorAd;
        private System.Windows.Forms.ErrorProvider errorSoyad;
        private System.Windows.Forms.ErrorProvider errorKullaniciAdi;
        private System.Windows.Forms.ErrorProvider errorTelefon;
        private System.Windows.Forms.ErrorProvider errorEposta;
        private System.Windows.Forms.ErrorProvider errorSifre;
        private System.Windows.Forms.ComboBox comboKullaniciTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorKullaniciTur;
    }
}