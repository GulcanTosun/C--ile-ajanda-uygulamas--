namespace Daylight_Ajanda
{
    partial class frmGunluk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGunluk));
            this.txtGunluk = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGunluk = new System.Windows.Forms.Button();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGunluk
            // 
            this.txtGunluk.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGunluk.Location = new System.Drawing.Point(12, 104);
            this.txtGunluk.Name = "txtGunluk";
            this.txtGunluk.Size = new System.Drawing.Size(681, 264);
            this.txtGunluk.TabIndex = 0;
            this.txtGunluk.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sevgili Günlük ";
            // 
            // tmrTarihSaat
            // 
            this.tmrTarihSaat.Tick += new System.EventHandler(this.tmrTarihSaat_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 46);
            this.panel2.TabIndex = 36;
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.Location = new System.Drawing.Point(3, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 38);
            this.btnCikis.TabIndex = 24;
            this.btnCikis.Text = "Geri";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.lblSaat);
            this.panel3.Controls.Add(this.lblTarih);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(716, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 50);
            this.panel3.TabIndex = 23;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaat.Location = new System.Drawing.Point(183, 16);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 16);
            this.lblSaat.TabIndex = 18;
            this.lblSaat.Text = "saat";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTarih.Location = new System.Drawing.Point(6, 16);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(32, 16);
            this.lblTarih.TabIndex = 17;
            this.lblTarih.Text = "tarih";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(699, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(707, 313);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 57);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGunluk
            // 
            this.btnGunluk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGunluk.BackgroundImage")));
            this.btnGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunluk.Location = new System.Drawing.Point(859, 313);
            this.btnGunluk.Name = "btnGunluk";
            this.btnGunluk.Size = new System.Drawing.Size(146, 57);
            this.btnGunluk.TabIndex = 37;
            this.btnGunluk.Text = "Günlüğüm";
            this.btnGunluk.UseVisualStyleBackColor = true;
            this.btnGunluk.Click += new System.EventHandler(this.btnGunluk_Click);
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(169, 76);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(524, 22);
            this.datetime.TabIndex = 38;
            // 
            // frmGunluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1019, 382);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.btnGunluk);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGunluk);
            this.Name = "frmGunluk";
            this.Text = "Günlük ";
            this.Load += new System.EventHandler(this.frmGunluk_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtGunluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer tmrTarihSaat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGunluk;
        private System.Windows.Forms.DateTimePicker datetime;
    }
}