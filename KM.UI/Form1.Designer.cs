namespace KMUI
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
            this.dgwUrun = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.grbEkle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.cbKategoriSec = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.cbUpdatekategori = new System.Windows.Forms.ComboBox();
            this.txtUpdateBirim = new System.Windows.Forms.TextBox();
            this.txtUpdateStok = new System.Windows.Forms.TextBox();
            this.txtUpdateFiyat = new System.Windows.Forms.TextBox();
            this.txtUpdateAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbEkle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUrun
            // 
            this.dgwUrun.AllowUserToAddRows = false;
            this.dgwUrun.AllowUserToDeleteRows = false;
            this.dgwUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrun.Location = new System.Drawing.Point(12, 133);
            this.dgwUrun.MultiSelect = false;
            this.dgwUrun.Name = "dgwUrun";
            this.dgwUrun.ReadOnly = true;
            this.dgwUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUrun.Size = new System.Drawing.Size(591, 305);
            this.dgwUrun.TabIndex = 0;
            this.dgwUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrun_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkategori);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriye Göre";
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(6, 18);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(579, 21);
            this.cbkategori.TabIndex = 1;
            this.cbkategori.SelectedIndexChanged += new System.EventHandler(this.cbkategori_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUrun);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İsme Göre";
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(6, 18);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(579, 20);
            this.txtUrun.TabIndex = 2;
            this.txtUrun.TextChanged += new System.EventHandler(this.txtUrun_TextChanged);
            // 
            // grbEkle
            // 
            this.grbEkle.Controls.Add(this.btnEkle);
            this.grbEkle.Controls.Add(this.cbKategoriSec);
            this.grbEkle.Controls.Add(this.txtBirim);
            this.grbEkle.Controls.Add(this.txtStok);
            this.grbEkle.Controls.Add(this.txtfiyat);
            this.grbEkle.Controls.Add(this.txtUrunAd);
            this.grbEkle.Controls.Add(this.label5);
            this.grbEkle.Controls.Add(this.label4);
            this.grbEkle.Controls.Add(this.label3);
            this.grbEkle.Controls.Add(this.label2);
            this.grbEkle.Controls.Add(this.label1);
            this.grbEkle.Location = new System.Drawing.Point(12, 444);
            this.grbEkle.Name = "grbEkle";
            this.grbEkle.Size = new System.Drawing.Size(257, 185);
            this.grbEkle.TabIndex = 3;
            this.grbEkle.TabStop = false;
            this.grbEkle.Text = "Yeni Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok Adeti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birim Adeti:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(66, 15);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(185, 20);
            this.txtUrunAd.TabIndex = 4;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(66, 68);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(185, 20);
            this.txtfiyat.TabIndex = 6;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(66, 94);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(185, 20);
            this.txtStok.TabIndex = 7;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(66, 120);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(185, 20);
            this.txtBirim.TabIndex = 8;
            // 
            // cbKategoriSec
            // 
            this.cbKategoriSec.FormattingEnabled = true;
            this.cbKategoriSec.Location = new System.Drawing.Point(66, 41);
            this.cbKategoriSec.Name = "cbKategoriSec";
            this.cbKategoriSec.Size = new System.Drawing.Size(185, 21);
            this.cbKategoriSec.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 146);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(245, 33);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGüncelle);
            this.groupBox3.Controls.Add(this.cbUpdatekategori);
            this.groupBox3.Controls.Add(this.txtUpdateBirim);
            this.groupBox3.Controls.Add(this.txtUpdateStok);
            this.groupBox3.Controls.Add(this.txtUpdateFiyat);
            this.groupBox3.Controls.Add(this.txtUpdateAd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(275, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 185);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Güncelle";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(6, 146);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(245, 33);
            this.btnGüncelle.TabIndex = 9;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // cbUpdatekategori
            // 
            this.cbUpdatekategori.FormattingEnabled = true;
            this.cbUpdatekategori.Location = new System.Drawing.Point(66, 41);
            this.cbUpdatekategori.Name = "cbUpdatekategori";
            this.cbUpdatekategori.Size = new System.Drawing.Size(185, 21);
            this.cbUpdatekategori.TabIndex = 5;
            // 
            // txtUpdateBirim
            // 
            this.txtUpdateBirim.Location = new System.Drawing.Point(66, 120);
            this.txtUpdateBirim.Name = "txtUpdateBirim";
            this.txtUpdateBirim.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateBirim.TabIndex = 8;
            // 
            // txtUpdateStok
            // 
            this.txtUpdateStok.Location = new System.Drawing.Point(66, 94);
            this.txtUpdateStok.Name = "txtUpdateStok";
            this.txtUpdateStok.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateStok.TabIndex = 7;
            // 
            // txtUpdateFiyat
            // 
            this.txtUpdateFiyat.Location = new System.Drawing.Point(66, 68);
            this.txtUpdateFiyat.Name = "txtUpdateFiyat";
            this.txtUpdateFiyat.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateFiyat.TabIndex = 6;
            // 
            // txtUpdateAd
            // 
            this.txtUpdateAd.Location = new System.Drawing.Point(66, 15);
            this.txtUpdateAd.Name = "txtUpdateAd";
            this.txtUpdateAd.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateAd.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Birim Adeti:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stok Adeti:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fiyat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Kategori ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Adı:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(538, 444);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 185);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 632);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwUrun);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbEkle.ResumeLayout(false);
            this.grbEkle.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.GroupBox grbEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbKategoriSec;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.ComboBox cbUpdatekategori;
        private System.Windows.Forms.TextBox txtUpdateBirim;
        private System.Windows.Forms.TextBox txtUpdateStok;
        private System.Windows.Forms.TextBox txtUpdateFiyat;
        private System.Windows.Forms.TextBox txtUpdateAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSil;
    }
}

