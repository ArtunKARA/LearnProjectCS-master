namespace WorldFinderForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBkonum = new System.Windows.Forms.ComboBox();
            this.Git = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAdet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBAranan = new System.Windows.Forms.TextBox();
            this.Bul = new System.Windows.Forms.Button();
            this.richTBmetin = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBkonum);
            this.groupBox1.Controls.Add(this.Git);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbAdet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(471, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuçlar";
            // 
            // CBkonum
            // 
            this.CBkonum.FormattingEnabled = true;
            this.CBkonum.Location = new System.Drawing.Point(160, 62);
            this.CBkonum.Name = "CBkonum";
            this.CBkonum.Size = new System.Drawing.Size(121, 24);
            this.CBkonum.TabIndex = 5;
            // 
            // Git
            // 
            this.Git.Location = new System.Drawing.Point(100, 106);
            this.Git.Name = "Git";
            this.Git.Size = new System.Drawing.Size(75, 23);
            this.Git.TabIndex = 4;
            this.Git.Text = "GİT";
            this.Git.UseVisualStyleBackColor = true;
            this.Git.Click += new System.EventHandler(this.Git_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bulunan konumlar:";
            // 
            // lbAdet
            // 
            this.lbAdet.AutoSize = true;
            this.lbAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAdet.Location = new System.Drawing.Point(126, 30);
            this.lbAdet.Name = "lbAdet";
            this.lbAdet.Size = new System.Drawing.Size(18, 20);
            this.lbAdet.TabIndex = 1;
            this.lbAdet.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulunan Adet:";
            // 
            // TBAranan
            // 
            this.TBAranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBAranan.Location = new System.Drawing.Point(124, 303);
            this.TBAranan.Name = "TBAranan";
            this.TBAranan.Size = new System.Drawing.Size(119, 28);
            this.TBAranan.TabIndex = 6;
            this.TBAranan.Text = " Kelime Girin";
            this.TBAranan.Click += new System.EventHandler(this.TBAranan_Click);
            this.TBAranan.TextChanged += new System.EventHandler(this.TBAranan_TextChanged);
            this.TBAranan.DoubleClick += new System.EventHandler(this.TBAranan_DoubleClick);
            // 
            // Bul
            // 
            this.Bul.Location = new System.Drawing.Point(12, 303);
            this.Bul.Name = "Bul";
            this.Bul.Size = new System.Drawing.Size(92, 33);
            this.Bul.TabIndex = 5;
            this.Bul.Text = "BUL";
            this.Bul.UseVisualStyleBackColor = true;
            this.Bul.Click += new System.EventHandler(this.Bul_Click);
            // 
            // richTBmetin
            // 
            this.richTBmetin.Location = new System.Drawing.Point(12, 3);
            this.richTBmetin.Name = "richTBmetin";
            this.richTBmetin.Size = new System.Drawing.Size(776, 272);
            this.richTBmetin.TabIndex = 4;
            this.richTBmetin.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBAranan);
            this.Controls.Add(this.Bul);
            this.Controls.Add(this.richTBmetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Git;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBAranan;
        private System.Windows.Forms.Button Bul;
        private System.Windows.Forms.RichTextBox richTBmetin;
        private System.Windows.Forms.ComboBox CBkonum;
    }
}

