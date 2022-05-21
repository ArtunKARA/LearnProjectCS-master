namespace KelimeBulucu
{
    partial class Form1
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
            this.richTBmetin = new System.Windows.Forms.RichTextBox();
            this.Bul = new System.Windows.Forms.Button();
            this.TBAranan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBKonum = new System.Windows.Forms.TextBox();
            this.Git = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTBmetin
            // 
            this.richTBmetin.Location = new System.Drawing.Point(12, 12);
            this.richTBmetin.Name = "richTBmetin";
            this.richTBmetin.Size = new System.Drawing.Size(776, 272);
            this.richTBmetin.TabIndex = 0;
            this.richTBmetin.Text = "";
            // 
            // Bul
            // 
            this.Bul.Location = new System.Drawing.Point(12, 312);
            this.Bul.Name = "Bul";
            this.Bul.Size = new System.Drawing.Size(92, 33);
            this.Bul.TabIndex = 1;
            this.Bul.Text = "BUL";
            this.Bul.UseVisualStyleBackColor = true;
            // 
            // TBAranan
            // 
            this.TBAranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBAranan.Location = new System.Drawing.Point(124, 312);
            this.TBAranan.Name = "TBAranan";
            this.TBAranan.Size = new System.Drawing.Size(111, 28);
            this.TBAranan.TabIndex = 2;
            this.TBAranan.Text = " Kelime Girin";
            this.TBAranan.TextChanged += new System.EventHandler(this.TBAranan_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Git);
            this.groupBox1.Controls.Add(this.TBKonum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbAdet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(471, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuçlar";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bulunan konumlar:";
            // 
            // TBKonum
            // 
            this.TBKonum.Location = new System.Drawing.Point(164, 66);
            this.TBKonum.Multiline = true;
            this.TBKonum.Name = "TBKonum";
            this.TBKonum.Size = new System.Drawing.Size(100, 22);
            this.TBKonum.TabIndex = 3;
            // 
            // Git
            // 
            this.Git.Location = new System.Drawing.Point(100, 106);
            this.Git.Name = "Git";
            this.Git.Size = new System.Drawing.Size(75, 23);
            this.Git.TabIndex = 4;
            this.Git.Text = "GİT";
            this.Git.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBAranan);
            this.Controls.Add(this.Bul);
            this.Controls.Add(this.richTBmetin);
            this.Name = "Form1";
            this.Text = "Kelime Bulucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTBmetin;
        private System.Windows.Forms.Button Bul;
        private System.Windows.Forms.TextBox TBAranan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Git;
        private System.Windows.Forms.TextBox TBKonum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAdet;
        private System.Windows.Forms.Label label1;
    }
}