namespace MY_LIBRARY
{
    partial class kitapEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.kitapAd = new System.Windows.Forms.TextBox();
            this.yazar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tür = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sayfaSayi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.yayın = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİTAP ADI :";
            // 
            // kitapAd
            // 
            this.kitapAd.Location = new System.Drawing.Point(158, 70);
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.Size = new System.Drawing.Size(159, 22);
            this.kitapAd.TabIndex = 1;
            // 
            // yazar
            // 
            this.yazar.FormattingEnabled = true;
            this.yazar.Location = new System.Drawing.Point(158, 98);
            this.yazar.Name = "yazar";
            this.yazar.Size = new System.Drawing.Size(159, 24);
            this.yazar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "YAZAR  :";
            // 
            // tür
            // 
            this.tür.FormattingEnabled = true;
            this.tür.Location = new System.Drawing.Point(158, 128);
            this.tür.Name = "tür";
            this.tür.Size = new System.Drawing.Size(159, 24);
            this.tür.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TÜR :";
            // 
            // dil
            // 
            this.dil.FormattingEnabled = true;
            this.dil.Location = new System.Drawing.Point(158, 158);
            this.dil.Name = "dil";
            this.dil.Size = new System.Drawing.Size(159, 24);
            this.dil.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "DİL :";
            // 
            // sayfaSayi
            // 
            this.sayfaSayi.Location = new System.Drawing.Point(158, 216);
            this.sayfaSayi.Name = "sayfaSayi";
            this.sayfaSayi.Size = new System.Drawing.Size(159, 22);
            this.sayfaSayi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "SAYFA SAYISI :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yayın
            // 
            this.yayın.FormattingEnabled = true;
            this.yayın.Location = new System.Drawing.Point(158, 186);
            this.yayın.Name = "yayın";
            this.yayın.Size = new System.Drawing.Size(159, 24);
            this.yayın.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "YAYIN EVİ :";
            // 
            // kitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yayın);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sayfaSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tür);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yazar);
            this.Controls.Add(this.kitapAd);
            this.Controls.Add(this.label1);
            this.Name = "kitapEkle";
            this.Text = "kitapEkle";
            this.Load += new System.EventHandler(this.kitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitapAd;
        private System.Windows.Forms.ComboBox yazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tür;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sayfaSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox yayın;
        private System.Windows.Forms.Label label6;
    }
}