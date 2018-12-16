namespace MY_LIBRARY
{
    partial class PersonelEkranı
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
            this.isim = new System.Windows.Forms.Label();
            this.soyisim = new System.Windows.Forms.Label();
            this.islem = new System.Windows.Forms.Button();
            this.Çıkış = new System.Windows.Forms.Button();
            this.kayit = new System.Windows.Forms.Button();
            this.sifreDegis = new System.Windows.Forms.Button();
            this.islemPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.islemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(13, 13);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(46, 17);
            this.isim.TabIndex = 0;
            this.isim.Text = "label1";
            // 
            // soyisim
            // 
            this.soyisim.AutoSize = true;
            this.soyisim.Location = new System.Drawing.Point(81, 12);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(46, 17);
            this.soyisim.TabIndex = 1;
            this.soyisim.Text = "label1";
            // 
            // islem
            // 
            this.islem.Location = new System.Drawing.Point(12, 59);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(114, 172);
            this.islem.TabIndex = 2;
            this.islem.Text = "Yeni İşlem";
            this.islem.UseVisualStyleBackColor = true;
            this.islem.Click += new System.EventHandler(this.islem_Click);
            // 
            // Çıkış
            // 
            this.Çıkış.Location = new System.Drawing.Point(12, 458);
            this.Çıkış.Name = "Çıkış";
            this.Çıkış.Size = new System.Drawing.Size(75, 43);
            this.Çıkış.TabIndex = 3;
            this.Çıkış.Text = "Çıkış";
            this.Çıkış.UseVisualStyleBackColor = true;
            this.Çıkış.Click += new System.EventHandler(this.Çıkış_Click);
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(12, 237);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(115, 215);
            this.kayit.TabIndex = 4;
            this.kayit.Text = "Yeni Kayıt";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // sifreDegis
            // 
            this.sifreDegis.Location = new System.Drawing.Point(176, 12);
            this.sifreDegis.Name = "sifreDegis";
            this.sifreDegis.Size = new System.Drawing.Size(106, 42);
            this.sifreDegis.TabIndex = 5;
            this.sifreDegis.Text = "Kullanıcı Adı / Şifre Değiş";
            this.sifreDegis.UseVisualStyleBackColor = true;
            this.sifreDegis.Click += new System.EventHandler(this.sifreDegis_Click);
            // 
            // islemPanel
            // 
            this.islemPanel.AutoScroll = true;
            this.islemPanel.Controls.Add(this.label2);
            this.islemPanel.Controls.Add(this.label1);
            this.islemPanel.Location = new System.Drawing.Point(176, 73);
            this.islemPanel.Name = "islemPanel";
            this.islemPanel.Size = new System.Drawing.Size(508, 441);
            this.islemPanel.TabIndex = 7;
            this.islemPanel.Visible = false;
            this.islemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.islemPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlemler";
            // 
            // PersonelEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 524);
            this.Controls.Add(this.islemPanel);
            this.Controls.Add(this.sifreDegis);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.Çıkış);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Name = "PersonelEkranı";
            this.Text = "PersonelEkranı";
            this.Load += new System.EventHandler(this.PersonelEkranı_Load);
            this.islemPanel.ResumeLayout(false);
            this.islemPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label soyisim;
        private System.Windows.Forms.Button islem;
        private System.Windows.Forms.Button Çıkış;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button sifreDegis;
        private System.Windows.Forms.Panel islemPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}