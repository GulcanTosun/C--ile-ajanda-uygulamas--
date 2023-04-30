namespace Daylight_Ajanda
{
    partial class frmGunlugum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGunlugum));
            this.listGunluk = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tmrSaatTarih = new System.Windows.Forms.Timer(this.components);
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // listGunluk
            // 
            this.listGunluk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listGunluk.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listGunluk.HideSelection = false;
            this.listGunluk.Location = new System.Drawing.Point(50, 62);
            this.listGunluk.Name = "listGunluk";
            this.listGunluk.Size = new System.Drawing.Size(1104, 416);
            this.listGunluk.TabIndex = 0;
            this.listGunluk.UseCompatibleStateImageBehavior = false;
            this.listGunluk.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sevgili Günlük";
            this.columnHeader2.Width = 910;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel17.BackgroundImage")));
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.btnGeri);
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Location = new System.Drawing.Point(12, 6);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1204, 46);
            this.panel17.TabIndex = 39;
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
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Goldenrod;
            this.panel18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel18.BackgroundImage")));
            this.panel18.Controls.Add(this.lblSaat);
            this.panel18.Controls.Add(this.lblTarih);
            this.panel18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel18.Location = new System.Drawing.Point(925, -1);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(276, 50);
            this.panel18.TabIndex = 23;
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
            // tmrSaatTarih
            // 
            this.tmrSaatTarih.Tick += new System.EventHandler(this.tmrSaatTarih_Tick);
            // 
            // frmGunlugum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 490);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.listGunluk);
            this.Name = "frmGunlugum";
            this.Text = "frmGunlugum";
            this.Load += new System.EventHandler(this.frmGunlugum_Load);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listGunluk;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer tmrSaatTarih;
    }
}