namespace Daylight_Ajanda
{
    partial class frmNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNote));
            this.btnNotOlustur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.listNot = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrSaatTarih = new System.Windows.Forms.Timer(this.components);
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotOlustur
            // 
            this.btnNotOlustur.BackColor = System.Drawing.Color.Red;
            this.btnNotOlustur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotOlustur.BackgroundImage")));
            this.btnNotOlustur.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotOlustur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotOlustur.Location = new System.Drawing.Point(8, 248);
            this.btnNotOlustur.Name = "btnNotOlustur";
            this.btnNotOlustur.Size = new System.Drawing.Size(335, 59);
            this.btnNotOlustur.TabIndex = 34;
            this.btnNotOlustur.Text = "Kaydet";
            this.btnNotOlustur.UseVisualStyleBackColor = false;
            this.btnNotOlustur.Click += new System.EventHandler(this.btnNotOlustur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGeri);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 46);
            this.panel2.TabIndex = 35;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.Location = new System.Drawing.Point(3, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(83, 38);
            this.btnGeri.TabIndex = 24;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.lblSaat);
            this.panel3.Controls.Add(this.lblTarih);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(694, -1);
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
            // listNot
            // 
            this.listNot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listNot.HideSelection = false;
            this.listNot.Location = new System.Drawing.Point(377, 73);
            this.listNot.Name = "listNot";
            this.listNot.Size = new System.Drawing.Size(601, 437);
            this.listNot.TabIndex = 36;
            this.listNot.UseCompatibleStateImageBehavior = false;
            this.listNot.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Notlarım";
            this.columnHeader1.Width = 585;
            // 
            // tmrSaatTarih
            // 
            this.tmrSaatTarih.Tick += new System.EventHandler(this.tmrSaatTarih_Tick);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(12, 101);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(331, 141);
            this.txtNot.TabIndex = 37;
            this.txtNot.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Yeni bir not oluştur";
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(990, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.listNot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNotOlustur);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmNote";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.frmNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNotOlustur;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ListView listNot;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer tmrSaatTarih;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Label label1;
    }
}