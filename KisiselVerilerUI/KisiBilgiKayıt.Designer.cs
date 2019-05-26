namespace KisiselVerilerUI
{
    partial class KisiBilgiKayıt
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUyruk = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAylikGelir = new System.Windows.Forms.TextBox();
            this.grpKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTcAra = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDara = new System.Windows.Forms.TextBox();
            this.btnKisiKaydet = new System.Windows.Forms.Button();
            this.grbAileBilgileri = new System.Windows.Forms.GroupBox();
            this.nudKardesSayisi = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAileKaydet = new System.Windows.Forms.Button();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.lblKardesSayisi = new System.Windows.Forms.Label();
            this.grbIletisim = new System.Windows.Forms.GroupBox();
            this.btnIletisimKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.trvHobiler = new System.Windows.Forms.TreeView();
            this.grbHobiEkle = new System.Windows.Forms.GroupBox();
            this.btnHobiKaydet = new System.Windows.Forms.Button();
            this.grpKisiselBilgiler.SuspendLayout();
            this.grbAileBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKardesSayisi)).BeginInit();
            this.grbIletisim.SuspendLayout();
            this.grbHobiEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(108, 79);
            this.txtAd.MaxLength = 30;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(102, 20);
            this.txtAd.TabIndex = 2;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(108, 105);
            this.txtSoyad.MaxLength = 30;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(102, 20);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            this.txtSoyad.Leave += new System.EventHandler(this.txtSoyad_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tc No";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(108, 131);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(102, 20);
            this.txtTc.TabIndex = 4;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDara_KeyPress);
            this.txtTc.Leave += new System.EventHandler(this.txtTc_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Yeri";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(108, 186);
            this.txtDogumYeri.MaxLength = 30;
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(102, 20);
            this.txtDogumYeri.TabIndex = 6;
            this.txtDogumYeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Uyruk";
            // 
            // txtUyruk
            // 
            this.txtUyruk.Location = new System.Drawing.Point(108, 212);
            this.txtUyruk.MaxLength = 20;
            this.txtUyruk.Name = "txtUyruk";
            this.txtUyruk.Size = new System.Drawing.Size(102, 20);
            this.txtUyruk.TabIndex = 7;
            this.txtUyruk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(108, 157);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(102, 20);
            this.dtpDogumTarihi.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Aylık Gelir";
            // 
            // txtAylikGelir
            // 
            this.txtAylikGelir.Location = new System.Drawing.Point(108, 238);
            this.txtAylikGelir.Name = "txtAylikGelir";
            this.txtAylikGelir.Size = new System.Drawing.Size(102, 20);
            this.txtAylikGelir.TabIndex = 8;
            this.txtAylikGelir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDara_KeyPress);
            this.txtAylikGelir.Leave += new System.EventHandler(this.txtAylikGelir_Leave);
            // 
            // grpKisiselBilgiler
            // 
            this.grpKisiselBilgiler.Controls.Add(this.label12);
            this.grpKisiselBilgiler.Controls.Add(this.btnTcAra);
            this.grpKisiselBilgiler.Controls.Add(this.label10);
            this.grpKisiselBilgiler.Controls.Add(this.txtIDara);
            this.grpKisiselBilgiler.Controls.Add(this.label1);
            this.grpKisiselBilgiler.Controls.Add(this.btnKisiKaydet);
            this.grpKisiselBilgiler.Controls.Add(this.txtAd);
            this.grpKisiselBilgiler.Controls.Add(this.txtAylikGelir);
            this.grpKisiselBilgiler.Controls.Add(this.label2);
            this.grpKisiselBilgiler.Controls.Add(this.label7);
            this.grpKisiselBilgiler.Controls.Add(this.txtSoyad);
            this.grpKisiselBilgiler.Controls.Add(this.dtpDogumTarihi);
            this.grpKisiselBilgiler.Controls.Add(this.label3);
            this.grpKisiselBilgiler.Controls.Add(this.txtUyruk);
            this.grpKisiselBilgiler.Controls.Add(this.txtTc);
            this.grpKisiselBilgiler.Controls.Add(this.label6);
            this.grpKisiselBilgiler.Controls.Add(this.label4);
            this.grpKisiselBilgiler.Controls.Add(this.txtDogumYeri);
            this.grpKisiselBilgiler.Controls.Add(this.label5);
            this.grpKisiselBilgiler.Location = new System.Drawing.Point(12, 12);
            this.grpKisiselBilgiler.Name = "grpKisiselBilgiler";
            this.grpKisiselBilgiler.Size = new System.Drawing.Size(366, 305);
            this.grpKisiselBilgiler.TabIndex = 16;
            this.grpKisiselBilgiler.TabStop = false;
            this.grpKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(358, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------";
            // 
            // btnTcAra
            // 
            this.btnTcAra.Location = new System.Drawing.Point(228, 22);
            this.btnTcAra.Name = "btnTcAra";
            this.btnTcAra.Size = new System.Drawing.Size(75, 23);
            this.btnTcAra.TabIndex = 1;
            this.btnTcAra.Text = "Tc Ara";
            this.btnTcAra.UseVisualStyleBackColor = true;
            this.btnTcAra.Click += new System.EventHandler(this.btnTcAra_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tc No";
            // 
            // txtIDara
            // 
            this.txtIDara.Location = new System.Drawing.Point(108, 25);
            this.txtIDara.MaxLength = 11;
            this.txtIDara.Name = "txtIDara";
            this.txtIDara.Size = new System.Drawing.Size(100, 20);
            this.txtIDara.TabIndex = 0;
            this.txtIDara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDara_KeyPress);
            // 
            // btnKisiKaydet
            // 
            this.btnKisiKaydet.Location = new System.Drawing.Point(135, 264);
            this.btnKisiKaydet.Name = "btnKisiKaydet";
            this.btnKisiKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKisiKaydet.TabIndex = 9;
            this.btnKisiKaydet.Text = "Devam Et";
            this.btnKisiKaydet.UseVisualStyleBackColor = true;
            this.btnKisiKaydet.Click += new System.EventHandler(this.btnKisiKaydet_Click);
            // 
            // grbAileBilgileri
            // 
            this.grbAileBilgileri.Controls.Add(this.nudKardesSayisi);
            this.grbAileBilgileri.Controls.Add(this.label8);
            this.grbAileBilgileri.Controls.Add(this.btnAileKaydet);
            this.grbAileBilgileri.Controls.Add(this.txtAnneAdi);
            this.grbAileBilgileri.Controls.Add(this.label9);
            this.grbAileBilgileri.Controls.Add(this.txtBabaAdi);
            this.grbAileBilgileri.Controls.Add(this.lblKardesSayisi);
            this.grbAileBilgileri.Location = new System.Drawing.Point(384, 12);
            this.grbAileBilgileri.Name = "grbAileBilgileri";
            this.grbAileBilgileri.Size = new System.Drawing.Size(215, 131);
            this.grbAileBilgileri.TabIndex = 17;
            this.grbAileBilgileri.TabStop = false;
            this.grbAileBilgileri.Text = "Aile Bilgileri";
            this.grbAileBilgileri.Visible = false;
            // 
            // nudKardesSayisi
            // 
            this.nudKardesSayisi.Location = new System.Drawing.Point(95, 65);
            this.nudKardesSayisi.Name = "nudKardesSayisi";
            this.nudKardesSayisi.Size = new System.Drawing.Size(100, 20);
            this.nudKardesSayisi.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Anne Adı";
            // 
            // btnAileKaydet
            // 
            this.btnAileKaydet.Location = new System.Drawing.Point(120, 91);
            this.btnAileKaydet.Name = "btnAileKaydet";
            this.btnAileKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnAileKaydet.TabIndex = 3;
            this.btnAileKaydet.Text = "Devam Et";
            this.btnAileKaydet.UseVisualStyleBackColor = true;
            this.btnAileKaydet.Click += new System.EventHandler(this.btnAileKaydet_Click);
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Location = new System.Drawing.Point(95, 13);
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAnneAdi.TabIndex = 0;
            this.txtAnneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            this.txtAnneAdi.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Baba Adı";
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Location = new System.Drawing.Point(95, 39);
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtBabaAdi.TabIndex = 1;
            this.txtBabaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            this.txtBabaAdi.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // lblKardesSayisi
            // 
            this.lblKardesSayisi.AutoSize = true;
            this.lblKardesSayisi.Location = new System.Drawing.Point(6, 68);
            this.lblKardesSayisi.Name = "lblKardesSayisi";
            this.lblKardesSayisi.Size = new System.Drawing.Size(70, 13);
            this.lblKardesSayisi.TabIndex = 20;
            this.lblKardesSayisi.Text = "Kardeş Sayısı";
            // 
            // grbIletisim
            // 
            this.grbIletisim.Controls.Add(this.btnIletisimKaydet);
            this.grbIletisim.Controls.Add(this.txtAdres);
            this.grbIletisim.Controls.Add(this.label16);
            this.grbIletisim.Controls.Add(this.label14);
            this.grbIletisim.Controls.Add(this.txtMail);
            this.grbIletisim.Controls.Add(this.txtTelNo);
            this.grbIletisim.Controls.Add(this.label13);
            this.grbIletisim.Location = new System.Drawing.Point(384, 149);
            this.grbIletisim.Name = "grbIletisim";
            this.grbIletisim.Size = new System.Drawing.Size(215, 168);
            this.grbIletisim.TabIndex = 32;
            this.grbIletisim.TabStop = false;
            this.grbIletisim.Text = "İletisim Bilgileri";
            this.grbIletisim.Visible = false;
            // 
            // btnIletisimKaydet
            // 
            this.btnIletisimKaydet.Location = new System.Drawing.Point(120, 127);
            this.btnIletisimKaydet.Name = "btnIletisimKaydet";
            this.btnIletisimKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnIletisimKaydet.TabIndex = 3;
            this.btnIletisimKaydet.Text = "Devam Et";
            this.btnIletisimKaydet.UseVisualStyleBackColor = true;
            this.btnIletisimKaydet.Click += new System.EventHandler(this.btnIletisimKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(95, 82);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 2;
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Adres";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(95, 52);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 1;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(95, 23);
            this.txtTelNo.MaxLength = 11;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelNo.TabIndex = 0;
            this.txtTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDara_KeyPress);
            this.txtTelNo.Leave += new System.EventHandler(this.txtTelNo_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Telefon";
            // 
            // trvHobiler
            // 
            this.trvHobiler.CheckBoxes = true;
            this.trvHobiler.Location = new System.Drawing.Point(6, 25);
            this.trvHobiler.Name = "trvHobiler";
            this.trvHobiler.Size = new System.Drawing.Size(183, 142);
            this.trvHobiler.TabIndex = 34;
            this.trvHobiler.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvHobiler_AfterCheck);
            this.trvHobiler.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvHobiler_AfterExpand);
            // 
            // grbHobiEkle
            // 
            this.grbHobiEkle.Controls.Add(this.btnHobiKaydet);
            this.grbHobiEkle.Controls.Add(this.trvHobiler);
            this.grbHobiEkle.Location = new System.Drawing.Point(12, 332);
            this.grbHobiEkle.Name = "grbHobiEkle";
            this.grbHobiEkle.Size = new System.Drawing.Size(212, 204);
            this.grbHobiEkle.TabIndex = 35;
            this.grbHobiEkle.TabStop = false;
            this.grbHobiEkle.Text = "Hobi Ekleme";
            this.grbHobiEkle.Visible = false;
            // 
            // btnHobiKaydet
            // 
            this.btnHobiKaydet.Location = new System.Drawing.Point(114, 173);
            this.btnHobiKaydet.Name = "btnHobiKaydet";
            this.btnHobiKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnHobiKaydet.TabIndex = 35;
            this.btnHobiKaydet.Text = "Kaydet";
            this.btnHobiKaydet.UseVisualStyleBackColor = true;
            this.btnHobiKaydet.Click += new System.EventHandler(this.btnHobiKaydet_Click);
            // 
            // KisiBilgiKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(680, 548);
            this.Controls.Add(this.grbHobiEkle);
            this.Controls.Add(this.grbIletisim);
            this.Controls.Add(this.grbAileBilgileri);
            this.Controls.Add(this.grpKisiselBilgiler);
            this.Name = "KisiBilgiKayıt";
            this.Text = "KisiBilgiKayıt";
            this.Load += new System.EventHandler(this.KisiBilgiKayıt_Load);
            this.grpKisiselBilgiler.ResumeLayout(false);
            this.grpKisiselBilgiler.PerformLayout();
            this.grbAileBilgileri.ResumeLayout(false);
            this.grbAileBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKardesSayisi)).EndInit();
            this.grbIletisim.ResumeLayout(false);
            this.grbIletisim.PerformLayout();
            this.grbHobiEkle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUyruk;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAylikGelir;
        private System.Windows.Forms.GroupBox grpKisiselBilgiler;
        private System.Windows.Forms.GroupBox grbAileBilgileri;
        private System.Windows.Forms.NumericUpDown nudKardesSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAileKaydet;
        private System.Windows.Forms.TextBox txtAnneAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.Label lblKardesSayisi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTcAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDara;
        private System.Windows.Forms.GroupBox grbIletisim;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnIletisimKaydet;
        private System.Windows.Forms.Button btnKisiKaydet;
        private System.Windows.Forms.TreeView trvHobiler;
        private System.Windows.Forms.GroupBox grbHobiEkle;
        private System.Windows.Forms.Button btnHobiKaydet;
    }
}