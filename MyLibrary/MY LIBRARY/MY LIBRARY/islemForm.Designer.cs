namespace MY_LIBRARY
{
    partial class islemForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ogrenci = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapPanel = new System.Windows.Forms.Panel();
            this.kitaplar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.kitapPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ogrenci);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 184);
            this.panel1.TabIndex = 0;
            // 
            // ogrenci
            // 
            this.ogrenci.AutoSize = true;
            this.ogrenci.Location = new System.Drawing.Point(5, 32);
            this.ogrenci.Name = "ogrenci";
            this.ogrenci.Size = new System.Drawing.Size(46, 17);
            this.ogrenci.TabIndex = 1;
            this.ogrenci.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenciler";
            // 
            // kitapPanel
            // 
            this.kitapPanel.AutoScroll = true;
            this.kitapPanel.Controls.Add(this.kitaplar);
            this.kitapPanel.Controls.Add(this.label2);
            this.kitapPanel.Location = new System.Drawing.Point(373, 12);
            this.kitapPanel.Name = "kitapPanel";
            this.kitapPanel.Size = new System.Drawing.Size(425, 184);
            this.kitapPanel.TabIndex = 1;
            // 
            // kitaplar
            // 
            this.kitaplar.AutoSize = true;
            this.kitaplar.Location = new System.Drawing.Point(8, 32);
            this.kitaplar.Name = "kitaplar";
            this.kitaplar.Size = new System.Drawing.Size(46, 17);
            this.kitaplar.TabIndex = 1;
            this.kitaplar.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Listesi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(598, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yeni Öğrenci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 154);
            this.button2.TabIndex = 3;
            this.button2.Text = "KAYIT İŞLEMİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 154);
            this.button3.TabIndex = 4;
            this.button3.Text = "İADE İŞLEMİ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // islemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 5);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kitapPanel);
            this.Controls.Add(this.panel1);
            this.Name = "islemForm";
            this.Text = "islemForm";
            this.Load += new System.EventHandler(this.islemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.kitapPanel.ResumeLayout(false);
            this.kitapPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ogrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel kitapPanel;
        private System.Windows.Forms.Label kitaplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}