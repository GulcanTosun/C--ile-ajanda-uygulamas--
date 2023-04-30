namespace Daylight_Ajanda
{
    partial class frmHedefArsiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHedefArsiv));
            this.listHedef = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // listHedef
            // 
            this.listHedef.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12});
            this.listHedef.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listHedef.HideSelection = false;
            this.listHedef.Location = new System.Drawing.Point(2, 64);
            this.listHedef.Name = "listHedef";
            this.listHedef.Size = new System.Drawing.Size(1456, 396);
            this.listHedef.TabIndex = 1;
            this.listHedef.UseCompatibleStateImageBehavior = false;
            this.listHedef.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kariyer";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aile";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Arkadaşlık";
            this.columnHeader3.Width = 151;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sağlık";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ev";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Öğrenme";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Aşk";
            this.columnHeader7.Width = 101;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Para";
            this.columnHeader8.Width = 101;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Kişisel Gelişim";
            this.columnHeader9.Width = 155;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fiziksel";
            this.columnHeader10.Width = 101;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Sosyal";
            this.columnHeader12.Width = 123;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel17.BackgroundImage")));
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.btnGeri);
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Location = new System.Drawing.Point(12, 12);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1446, 46);
            this.panel17.TabIndex = 38;
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
            this.panel18.Location = new System.Drawing.Point(1169, -1);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(276, 46);
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
            // frmHedefArsiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 465);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.listHedef);
            this.Name = "frmHedefArsiv";
            this.Text = "frmHedefArsiv";
            this.Load += new System.EventHandler(this.frmHedefArsiv_Load);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listHedef;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer tmrSaatTarih;
    }
}