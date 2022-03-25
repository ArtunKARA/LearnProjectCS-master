namespace BüfeSatışEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btAksesuar = new System.Windows.Forms.Button();
            this.btİçecek = new System.Windows.Forms.Button();
            this.btYiyecek = new System.Windows.Forms.Button();
            this.txAksesuar = new System.Windows.Forms.TextBox();
            this.txİçecek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txYiyecek = new System.Windows.Forms.TextBox();
            this.cbAksesuar = new System.Windows.Forms.ComboBox();
            this.cbİçecek = new System.Windows.Forms.ComboBox();
            this.cbYiyecek = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Yiyecekler = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btAksesuar);
            this.panel1.Controls.Add(this.btİçecek);
            this.panel1.Controls.Add(this.btYiyecek);
            this.panel1.Controls.Add(this.txAksesuar);
            this.panel1.Controls.Add(this.txİçecek);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txYiyecek);
            this.panel1.Controls.Add(this.cbAksesuar);
            this.panel1.Controls.Add(this.cbİçecek);
            this.panel1.Controls.Add(this.cbYiyecek);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Yiyecekler);
            this.panel1.Location = new System.Drawing.Point(12, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 280);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 84);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btAksesuar
            // 
            this.btAksesuar.BackColor = System.Drawing.Color.Chartreuse;
            this.btAksesuar.Location = new System.Drawing.Point(354, 152);
            this.btAksesuar.Name = "btAksesuar";
            this.btAksesuar.Size = new System.Drawing.Size(75, 23);
            this.btAksesuar.TabIndex = 11;
            this.btAksesuar.Text = "Ekle";
            this.btAksesuar.UseVisualStyleBackColor = false;
            this.btAksesuar.Click += new System.EventHandler(this.btAksesuar_Click);
            // 
            // btİçecek
            // 
            this.btİçecek.BackColor = System.Drawing.Color.Chartreuse;
            this.btİçecek.Location = new System.Drawing.Point(354, 103);
            this.btİçecek.Name = "btİçecek";
            this.btİçecek.Size = new System.Drawing.Size(75, 23);
            this.btİçecek.TabIndex = 10;
            this.btİçecek.Text = "Ekle";
            this.btİçecek.UseVisualStyleBackColor = false;
            this.btİçecek.Click += new System.EventHandler(this.btİçecek_Click);
            // 
            // btYiyecek
            // 
            this.btYiyecek.BackColor = System.Drawing.Color.Chartreuse;
            this.btYiyecek.Location = new System.Drawing.Point(354, 58);
            this.btYiyecek.Name = "btYiyecek";
            this.btYiyecek.Size = new System.Drawing.Size(75, 23);
            this.btYiyecek.TabIndex = 1;
            this.btYiyecek.Text = "Ekle";
            this.btYiyecek.UseVisualStyleBackColor = false;
            this.btYiyecek.Click += new System.EventHandler(this.btYiyecek_Click);
            // 
            // txAksesuar
            // 
            this.txAksesuar.Location = new System.Drawing.Point(229, 151);
            this.txAksesuar.Name = "txAksesuar";
            this.txAksesuar.Size = new System.Drawing.Size(100, 22);
            this.txAksesuar.TabIndex = 9;
            this.txAksesuar.TextChanged += new System.EventHandler(this.txAksesuar_TextChanged);
            // 
            // txİçecek
            // 
            this.txİçecek.Location = new System.Drawing.Point(229, 105);
            this.txİçecek.Name = "txİçecek";
            this.txİçecek.Size = new System.Drawing.Size(100, 22);
            this.txİçecek.TabIndex = 8;
            this.txİçecek.TextChanged += new System.EventHandler(this.txİçecek_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adet";
            // 
            // txYiyecek
            // 
            this.txYiyecek.Location = new System.Drawing.Point(229, 58);
            this.txYiyecek.Name = "txYiyecek";
            this.txYiyecek.Size = new System.Drawing.Size(100, 22);
            this.txYiyecek.TabIndex = 6;
            this.txYiyecek.TextChanged += new System.EventHandler(this.txYiyecek_TextChanged);
            // 
            // cbAksesuar
            // 
            this.cbAksesuar.FormattingEnabled = true;
            this.cbAksesuar.Items.AddRange(new object[] {
            "Gözlük",
            "Yastık"});
            this.cbAksesuar.Location = new System.Drawing.Point(88, 151);
            this.cbAksesuar.Name = "cbAksesuar";
            this.cbAksesuar.Size = new System.Drawing.Size(121, 24);
            this.cbAksesuar.TabIndex = 5;
            this.cbAksesuar.SelectedIndexChanged += new System.EventHandler(this.cbAksesuar_SelectedIndexChanged);
            // 
            // cbİçecek
            // 
            this.cbİçecek.FormattingEnabled = true;
            this.cbİçecek.Items.AddRange(new object[] {
            "Ayran",
            "Soda",
            "Çay"});
            this.cbİçecek.Location = new System.Drawing.Point(88, 103);
            this.cbİçecek.Name = "cbİçecek";
            this.cbİçecek.Size = new System.Drawing.Size(121, 24);
            this.cbİçecek.TabIndex = 4;
            this.cbİçecek.SelectedIndexChanged += new System.EventHandler(this.cbİçecek_SelectedIndexChanged);
            // 
            // cbYiyecek
            // 
            this.cbYiyecek.FormattingEnabled = true;
            this.cbYiyecek.Items.AddRange(new object[] {
            "Mısır",
            "Çikolata",
            "Cips"});
            this.cbYiyecek.Location = new System.Drawing.Point(88, 55);
            this.cbYiyecek.Name = "cbYiyecek";
            this.cbYiyecek.Size = new System.Drawing.Size(121, 24);
            this.cbYiyecek.TabIndex = 3;
            this.cbYiyecek.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aksesuarlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecekler";
            // 
            // Yiyecekler
            // 
            this.Yiyecekler.AutoSize = true;
            this.Yiyecekler.Location = new System.Drawing.Point(3, 58);
            this.Yiyecekler.Name = "Yiyecekler";
            this.Yiyecekler.Size = new System.Drawing.Size(71, 16);
            this.Yiyecekler.TabIndex = 0;
            this.Yiyecekler.Text = "Yiyecekler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 140);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(81, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kara Cinematorium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(545, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(557, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(229, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(345, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Yiyecekler;
        private System.Windows.Forms.ComboBox cbAksesuar;
        private System.Windows.Forms.ComboBox cbİçecek;
        private System.Windows.Forms.ComboBox cbYiyecek;
        private System.Windows.Forms.Button btAksesuar;
        private System.Windows.Forms.Button btİçecek;
        private System.Windows.Forms.Button btYiyecek;
        private System.Windows.Forms.TextBox txAksesuar;
        private System.Windows.Forms.TextBox txİçecek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txYiyecek;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

