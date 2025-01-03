namespace Proje1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ad = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.soyadı = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.Label();
            this.cins = new System.Windows.Forms.ComboBox();
            this.odano = new System.Windows.Forms.Label();
            this.oda = new System.Windows.Forms.ComboBox();
            this.kimlik = new System.Windows.Forms.Label();
            this.kimlikno = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.dogumtarih = new System.Windows.Forms.Label();
            this.dogumTarihh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.gelis = new System.Windows.Forms.DateTimePicker();
            this.cikma = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.DateTimePicker();
            this.sil = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rimberio Hotel Reservation Program";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1189, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(8, 203);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(39, 25);
            this.Ad.TabIndex = 2;
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyad.Location = new System.Drawing.Point(8, 259);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(74, 25);
            this.Soyad.TabIndex = 3;
            this.Soyad.Text = "Soyad";
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(141, 207);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(200, 22);
            this.isim.TabIndex = 4;
            this.isim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // soyadı
            // 
            this.soyadı.Location = new System.Drawing.Point(141, 262);
            this.soyadı.Name = "soyadı";
            this.soyadı.Size = new System.Drawing.Size(200, 22);
            this.soyadı.TabIndex = 5;
            this.soyadı.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cinsiyet
            // 
            this.cinsiyet.AutoSize = true;
            this.cinsiyet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyet.Location = new System.Drawing.Point(8, 317);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(90, 25);
            this.cinsiyet.TabIndex = 6;
            this.cinsiyet.Text = "Cinsiyet";
            // 
            // cins
            // 
            this.cins.FormattingEnabled = true;
            this.cins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cins.Location = new System.Drawing.Point(141, 318);
            this.cins.Name = "cins";
            this.cins.Size = new System.Drawing.Size(200, 24);
            this.cins.TabIndex = 7;
            this.cins.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // odano
            // 
            this.odano.AutoSize = true;
            this.odano.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odano.Location = new System.Drawing.Point(8, 369);
            this.odano.Name = "odano";
            this.odano.Size = new System.Drawing.Size(86, 25);
            this.odano.TabIndex = 8;
            this.odano.Text = "Oda No";
            // 
            // oda
            // 
            this.oda.FormattingEnabled = true;
            this.oda.Items.AddRange(new object[] {
            "Tek kişilik 100 numaralı oda",
            "Tek kişilik 101 numaralı oda",
            "Tek kişilik 102 numaralı oda",
            "Tek kişilik 103 numaralı oda",
            "Tek kişilik 104 numaralı oda",
            "Tek kişilik 105 numaralı oda",
            "Tek kişilik 106 numaralı oda",
            "Tek kişilik 107 numaralı oda",
            "Çift kişilik 108 numaralı oda",
            "Çift kişilik 109 numaralı oda",
            "Çift kişilik 110 numaralı oda",
            "Çift kişilik 111 numaralı oda",
            "Çift kişilik 112 numaralı oda",
            "Çift kişilik 113 numaralı oda",
            "Çift kişilik 114 numaralı oda",
            "Çift kişilik 115 numaralı oda",
            "Çift kişilik 116 numaralı oda",
            "Çift kişilik 117 numaralı oda",
            "Çift kişilik 118 numaralı oda",
            "Çift kişilik 119 numaralı oda",
            "Çift kişilik 120 numaralı oda",
            "Çift kişilik 121 numaralı oda",
            "Çift kişilik 122 numaralı oda",
            "Çift kişilik 123 numaralı oda",
            "Çift kişilik 124 numaralı oda",
            "VIP 125 numaralı oda",
            "VIP 126 numaralı oda",
            "VIP 127 numaralı oda",
            "VIP 128 numaralı oda",
            "VIP 129 numaralı oda",
            "VIP 130 numaralı oda",
            "VIP 131 numaralı oda",
            "",
            ""});
            this.oda.Location = new System.Drawing.Point(141, 371);
            this.oda.Name = "oda";
            this.oda.Size = new System.Drawing.Size(200, 24);
            this.oda.TabIndex = 9;
            this.oda.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // kimlik
            // 
            this.kimlik.AutoSize = true;
            this.kimlik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kimlik.Location = new System.Drawing.Point(576, 207);
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(264, 25);
            this.kimlik.TabIndex = 10;
            this.kimlik.Text = "TC Kimlik No/Passport No";
            // 
            // kimlikno
            // 
            this.kimlikno.Location = new System.Drawing.Point(941, 207);
            this.kimlikno.Name = "kimlikno";
            this.kimlikno.Size = new System.Drawing.Size(192, 22);
            this.kimlikno.TabIndex = 12;
            this.kimlikno.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tel.Location = new System.Drawing.Point(576, 260);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(131, 25);
            this.tel.TabIndex = 14;
            this.tel.Text = "Cep Telefon";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(941, 262);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(192, 22);
            this.telefon.TabIndex = 15;
            this.telefon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dogumtarih
            // 
            this.dogumtarih.AutoSize = true;
            this.dogumtarih.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dogumtarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumtarih.Location = new System.Drawing.Point(576, 316);
            this.dogumtarih.Name = "dogumtarih";
            this.dogumtarih.Size = new System.Drawing.Size(136, 25);
            this.dogumtarih.TabIndex = 16;
            this.dogumtarih.Text = "Doğum Tarih";
            // 
            // dogumTarihh
            // 
            this.dogumTarihh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumTarihh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumTarihh.Location = new System.Drawing.Point(941, 315);
            this.dogumTarihh.Name = "dogumTarihh";
            this.dogumTarihh.Size = new System.Drawing.Size(169, 27);
            this.dogumTarihh.TabIndex = 17;
            this.dogumTarihh.Value = new System.DateTime(2023, 7, 28, 13, 30, 0, 0);
            this.dogumTarihh.ValueChanged += new System.EventHandler(this.dogumTarihh_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(576, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Geliş";
            // 
            // gelis
            // 
            this.gelis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelis.Location = new System.Drawing.Point(672, 367);
            this.gelis.Name = "gelis";
            this.gelis.Size = new System.Drawing.Size(168, 27);
            this.gelis.TabIndex = 21;
            this.gelis.ValueChanged += new System.EventHandler(this.gelis_ValueChanged);
            // 
            // cikma
            // 
            this.cikma.AutoSize = true;
            this.cikma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikma.Location = new System.Drawing.Point(936, 371);
            this.cikma.Name = "cikma";
            this.cikma.Size = new System.Drawing.Size(60, 25);
            this.cikma.TabIndex = 23;
            this.cikma.Text = "Çıkış";
            // 
            // cikis
            // 
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.Location = new System.Drawing.Point(1088, 369);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(173, 27);
            this.cikis.TabIndex = 25;
            this.cikis.ValueChanged += new System.EventHandler(this.cikis_ValueChanged);
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(965, 881);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(178, 52);
            this.sil.TabIndex = 38;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(1168, 881);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(193, 52);
            this.kaydet.TabIndex = 39;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 416);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 459);
            this.dataGridView1.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 953);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.cikma);
            this.Controls.Add(this.gelis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dogumTarihh);
            this.Controls.Add(this.dogumtarih);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.kimlikno);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.oda);
            this.Controls.Add(this.odano);
            this.Controls.Add(this.cins);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.soyadı);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Müşteri Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label Soyad;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox soyadı;
        private System.Windows.Forms.Label cinsiyet;
        private System.Windows.Forms.ComboBox cins;
        private System.Windows.Forms.Label odano;
        private System.Windows.Forms.ComboBox oda;
        private System.Windows.Forms.Label kimlik;
        private System.Windows.Forms.TextBox kimlikno;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label dogumtarih;
        private System.Windows.Forms.DateTimePicker dogumTarihh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker gelis;
        private System.Windows.Forms.Label cikma;
        private System.Windows.Forms.DateTimePicker cikis;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

