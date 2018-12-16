namespace MY_LIBRARY
{
    partial class yeniOgrForm
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
            this.ad = new System.Windows.Forms.TextBox();
            this.soyAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(86, 43);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(158, 22);
            this.ad.TabIndex = 0;
            // 
            // soyAd
            // 
            this.soyAd.Location = new System.Drawing.Point(86, 70);
            this.soyAd.Name = "soyAd";
            this.soyAd.Size = new System.Drawing.Size(158, 22);
            this.soyAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CİNSİYET :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cinsiyet
            // 
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Location = new System.Drawing.Point(86, 101);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(158, 24);
            this.cinsiyet.TabIndex = 7;
            this.cinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // yeniOgrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 289);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soyAd);
            this.Controls.Add(this.ad);
            this.Name = "yeniOgrForm";
            this.Text = "yeniOgrForm";
            this.Load += new System.EventHandler(this.yeniOgrForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cinsiyet;
    }
}