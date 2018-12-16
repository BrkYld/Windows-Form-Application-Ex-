namespace MY_LIBRARY
{
    partial class kisiEkle
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
            this.isim = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.yetki = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(271, 26);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(155, 22);
            this.isim.TabIndex = 0;
            // 
            // soyisim
            // 
            this.soyisim.Location = new System.Drawing.Point(271, 66);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(155, 22);
            this.soyisim.TabIndex = 1;
            // 
            // cinsiyet
            // 
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Location = new System.Drawing.Point(271, 107);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(155, 24);
            this.cinsiyet.TabIndex = 2;
            // 
            // yetki
            // 
            this.yetki.FormattingEnabled = true;
            this.yetki.Location = new System.Drawing.Point(271, 150);
            this.yetki.Name = "yetki";
            this.yetki.Size = new System.Drawing.Size(155, 24);
            this.yetki.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "SOY AD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "CİNSİYET :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "YETKİ :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "KAYDET/GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yetki);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Name = "kisiEkle";
            this.Text = "kisiEkle";
            this.Load += new System.EventHandler(this.kisiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox soyisim;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.ComboBox yetki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}