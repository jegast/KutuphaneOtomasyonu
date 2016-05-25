namespace Kutuphane_Otomasyonu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ekle_basimtarihi = new System.Windows.Forms.DateTimePicker();
            this.ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle_kategori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ekle_yazar = new System.Windows.Forms.TextBox();
            this.ekle_barkod = new System.Windows.Forms.TextBox();
            this.ekle_yayinevi = new System.Windows.Forms.TextBox();
            this.ekle_kitap_adi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sil_basimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.sil_kategori = new System.Windows.Forms.TextBox();
            this.sil_isim_getir = new System.Windows.Forms.Button();
            this.Sil_Barkod_getir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.sil_kitap_adi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sil_yayinevi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sil_barkod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sil_yazar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.duzenle_basimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.duzenle_kategori = new System.Windows.Forms.TextBox();
            this.Duzenle_isim_getir = new System.Windows.Forms.Button();
            this.Duzenle_barkod_getir = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.duzenle_yazar = new System.Windows.Forms.TextBox();
            this.duzenle_barkod = new System.Windows.Forms.TextBox();
            this.duzenle_yayinevi = new System.Windows.Forms.TextBox();
            this.duzenle_kitap_adi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ekle_basimtarihi);
            this.tabPage1.Controls.Add(this.ekle);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ekle_kategori);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ekle_yazar);
            this.tabPage1.Controls.Add(this.ekle_barkod);
            this.tabPage1.Controls.Add(this.ekle_yayinevi);
            this.tabPage1.Controls.Add(this.ekle_kitap_adi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ekle_basimtarihi
            // 
            this.ekle_basimtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ekle_basimtarihi.Location = new System.Drawing.Point(113, 116);
            this.ekle_basimtarihi.Name = "ekle_basimtarihi";
            this.ekle_basimtarihi.Size = new System.Drawing.Size(100, 20);
            this.ekle_basimtarihi.TabIndex = 7;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(113, 168);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 6;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Kutuphane_Otomasyonu.Properties.Resources.turk_edebiyati;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(242, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 223);
            this.panel1.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Basım Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yayın Evi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Barkod";
            // 
            // ekle_kategori
            // 
            this.ekle_kategori.Location = new System.Drawing.Point(113, 142);
            this.ekle_kategori.Name = "ekle_kategori";
            this.ekle_kategori.Size = new System.Drawing.Size(100, 20);
            this.ekle_kategori.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı";
            // 
            // ekle_yazar
            // 
            this.ekle_yazar.Location = new System.Drawing.Point(113, 90);
            this.ekle_yazar.Name = "ekle_yazar";
            this.ekle_yazar.Size = new System.Drawing.Size(100, 20);
            this.ekle_yazar.TabIndex = 2;
            // 
            // ekle_barkod
            // 
            this.ekle_barkod.Location = new System.Drawing.Point(113, 12);
            this.ekle_barkod.Name = "ekle_barkod";
            this.ekle_barkod.Size = new System.Drawing.Size(100, 20);
            this.ekle_barkod.TabIndex = 0;
            // 
            // ekle_yayinevi
            // 
            this.ekle_yayinevi.Location = new System.Drawing.Point(113, 64);
            this.ekle_yayinevi.Name = "ekle_yayinevi";
            this.ekle_yayinevi.Size = new System.Drawing.Size(100, 20);
            this.ekle_yayinevi.TabIndex = 1;
            // 
            // ekle_kitap_adi
            // 
            this.ekle_kitap_adi.Location = new System.Drawing.Point(113, 38);
            this.ekle_kitap_adi.Name = "ekle_kitap_adi";
            this.ekle_kitap_adi.Size = new System.Drawing.Size(100, 20);
            this.ekle_kitap_adi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sil_basimtarihi);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.sil_kategori);
            this.tabPage2.Controls.Add(this.sil_isim_getir);
            this.tabPage2.Controls.Add(this.Sil_Barkod_getir);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.sil);
            this.tabPage2.Controls.Add(this.sil_kitap_adi);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.sil_yayinevi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.sil_barkod);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.sil_yazar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitap Çıkar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sil_basimtarihi
            // 
            this.sil_basimtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sil_basimtarihi.Location = new System.Drawing.Point(69, 115);
            this.sil_basimtarihi.Name = "sil_basimtarihi";
            this.sil_basimtarihi.Size = new System.Drawing.Size(100, 20);
            this.sil_basimtarihi.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Kategori";
            // 
            // sil_kategori
            // 
            this.sil_kategori.Location = new System.Drawing.Point(69, 141);
            this.sil_kategori.Name = "sil_kategori";
            this.sil_kategori.Size = new System.Drawing.Size(100, 20);
            this.sil_kategori.TabIndex = 31;
            // 
            // sil_isim_getir
            // 
            this.sil_isim_getir.Location = new System.Drawing.Point(175, 39);
            this.sil_isim_getir.Name = "sil_isim_getir";
            this.sil_isim_getir.Size = new System.Drawing.Size(42, 23);
            this.sil_isim_getir.TabIndex = 28;
            this.sil_isim_getir.Text = "Bul";
            this.sil_isim_getir.UseVisualStyleBackColor = true;
            this.sil_isim_getir.Click += new System.EventHandler(this.sil_isim_getir_Click);
            // 
            // Sil_Barkod_getir
            // 
            this.Sil_Barkod_getir.Location = new System.Drawing.Point(175, 10);
            this.Sil_Barkod_getir.Name = "Sil_Barkod_getir";
            this.Sil_Barkod_getir.Size = new System.Drawing.Size(42, 23);
            this.Sil_Barkod_getir.TabIndex = 29;
            this.Sil_Barkod_getir.Text = "Bul";
            this.Sil_Barkod_getir.UseVisualStyleBackColor = true;
            this.Sil_Barkod_getir.Click += new System.EventHandler(this.Sil_Barkod_getir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Barkod";
            // 
            // sil
            // 
            this.sil.Enabled = false;
            this.sil.Location = new System.Drawing.Point(69, 167);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 30;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // sil_kitap_adi
            // 
            this.sil_kitap_adi.Location = new System.Drawing.Point(69, 38);
            this.sil_kitap_adi.Name = "sil_kitap_adi";
            this.sil_kitap_adi.Size = new System.Drawing.Size(100, 20);
            this.sil_kitap_adi.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Basım Tarihi";
            // 
            // sil_yayinevi
            // 
            this.sil_yayinevi.Location = new System.Drawing.Point(69, 64);
            this.sil_yayinevi.Name = "sil_yayinevi";
            this.sil_yayinevi.Size = new System.Drawing.Size(100, 20);
            this.sil_yayinevi.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Yazarı";
            // 
            // sil_barkod
            // 
            this.sil_barkod.Location = new System.Drawing.Point(69, 12);
            this.sil_barkod.Name = "sil_barkod";
            this.sil_barkod.Size = new System.Drawing.Size(100, 20);
            this.sil_barkod.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Yayın Evi";
            // 
            // sil_yazar
            // 
            this.sil_yazar.Location = new System.Drawing.Point(69, 90);
            this.sil_yazar.Name = "sil_yazar";
            this.sil_yazar.Size = new System.Drawing.Size(100, 20);
            this.sil_yazar.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Kitap Adı";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Kutuphane_Otomasyonu.Properties.Resources.turk_edebiyati;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(242, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 223);
            this.panel2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.duzenle_basimtarihi);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.duzenle_kategori);
            this.tabPage3.Controls.Add(this.Duzenle_isim_getir);
            this.tabPage3.Controls.Add(this.Duzenle_barkod_getir);
            this.tabPage3.Controls.Add(this.duzenle);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.duzenle_yazar);
            this.tabPage3.Controls.Add(this.duzenle_barkod);
            this.tabPage3.Controls.Add(this.duzenle_yayinevi);
            this.tabPage3.Controls.Add(this.duzenle_kitap_adi);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(470, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kitap Düzenle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // duzenle_basimtarihi
            // 
            this.duzenle_basimtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duzenle_basimtarihi.Location = new System.Drawing.Point(69, 115);
            this.duzenle_basimtarihi.Name = "duzenle_basimtarihi";
            this.duzenle_basimtarihi.Size = new System.Drawing.Size(100, 20);
            this.duzenle_basimtarihi.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Kategori";
            // 
            // duzenle_kategori
            // 
            this.duzenle_kategori.Location = new System.Drawing.Point(69, 142);
            this.duzenle_kategori.Name = "duzenle_kategori";
            this.duzenle_kategori.Size = new System.Drawing.Size(100, 20);
            this.duzenle_kategori.TabIndex = 31;
            // 
            // Duzenle_isim_getir
            // 
            this.Duzenle_isim_getir.Location = new System.Drawing.Point(175, 39);
            this.Duzenle_isim_getir.Name = "Duzenle_isim_getir";
            this.Duzenle_isim_getir.Size = new System.Drawing.Size(42, 23);
            this.Duzenle_isim_getir.TabIndex = 28;
            this.Duzenle_isim_getir.Text = "Bul";
            this.Duzenle_isim_getir.UseVisualStyleBackColor = true;
            this.Duzenle_isim_getir.Click += new System.EventHandler(this.Duzenle_isim_getir_Click);
            // 
            // Duzenle_barkod_getir
            // 
            this.Duzenle_barkod_getir.Location = new System.Drawing.Point(175, 10);
            this.Duzenle_barkod_getir.Name = "Duzenle_barkod_getir";
            this.Duzenle_barkod_getir.Size = new System.Drawing.Size(42, 23);
            this.Duzenle_barkod_getir.TabIndex = 29;
            this.Duzenle_barkod_getir.Text = "Bul";
            this.Duzenle_barkod_getir.UseVisualStyleBackColor = true;
            this.Duzenle_barkod_getir.Click += new System.EventHandler(this.Duzenle_barkod_getir_Click);
            // 
            // duzenle
            // 
            this.duzenle.Enabled = false;
            this.duzenle.Location = new System.Drawing.Point(69, 181);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(75, 23);
            this.duzenle.TabIndex = 30;
            this.duzenle.Text = "Düzelt";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Basım Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Yazarı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Yayın Evi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Barkod";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Kitap Adı";
            // 
            // duzenle_yazar
            // 
            this.duzenle_yazar.Location = new System.Drawing.Point(69, 90);
            this.duzenle_yazar.Name = "duzenle_yazar";
            this.duzenle_yazar.Size = new System.Drawing.Size(100, 20);
            this.duzenle_yazar.TabIndex = 21;
            // 
            // duzenle_barkod
            // 
            this.duzenle_barkod.Location = new System.Drawing.Point(69, 12);
            this.duzenle_barkod.Name = "duzenle_barkod";
            this.duzenle_barkod.Size = new System.Drawing.Size(100, 20);
            this.duzenle_barkod.TabIndex = 18;
            // 
            // duzenle_yayinevi
            // 
            this.duzenle_yayinevi.Location = new System.Drawing.Point(69, 64);
            this.duzenle_yayinevi.Name = "duzenle_yayinevi";
            this.duzenle_yayinevi.Size = new System.Drawing.Size(100, 20);
            this.duzenle_yayinevi.TabIndex = 20;
            // 
            // duzenle_kitap_adi
            // 
            this.duzenle_kitap_adi.Location = new System.Drawing.Point(69, 38);
            this.duzenle_kitap_adi.Name = "duzenle_kitap_adi";
            this.duzenle_kitap_adi.Size = new System.Drawing.Size(100, 20);
            this.duzenle_kitap_adi.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Kutuphane_Otomasyonu.Properties.Resources.turk_edebiyati;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(242, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 223);
            this.panel3.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox16);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(470, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hakkında";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Control;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox16.Location = new System.Drawing.Point(41, 62);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(384, 104);
            this.textBox16.TabIndex = 0;
            this.textBox16.Text = "\r\ndeneme amaçlı yazılmıştır";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(470, 235);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Çıkış";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 301);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kutuphane Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ekle_yazar;
        private System.Windows.Forms.TextBox ekle_yayinevi;
        private System.Windows.Forms.TextBox ekle_kitap_adi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ekle_barkod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button sil_isim_getir;
        private System.Windows.Forms.Button Sil_Barkod_getir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox sil_kitap_adi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sil_yayinevi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sil_barkod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sil_yazar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Duzenle_isim_getir;
        private System.Windows.Forms.Button Duzenle_barkod_getir;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox duzenle_yazar;
        private System.Windows.Forms.TextBox duzenle_barkod;
        private System.Windows.Forms.TextBox duzenle_yayinevi;
        private System.Windows.Forms.TextBox duzenle_kitap_adi;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ekle_kategori;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox sil_kategori;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox duzenle_kategori;
        private System.Windows.Forms.DateTimePicker ekle_basimtarihi;
        private System.Windows.Forms.DateTimePicker sil_basimtarihi;
        private System.Windows.Forms.DateTimePicker duzenle_basimtarihi;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

