namespace KisiselVerilerUI
{
    partial class FormMesajGonder
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
            this.trvHobiler = new System.Windows.Forms.TreeView();
            this.dgvKisiBilgileri = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.kisiAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kisiSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kisiTc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kisiTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kisiEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnMesaj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiBilgileri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori";
            // 
            // trvHobiler
            // 
            this.trvHobiler.CheckBoxes = true;
            this.trvHobiler.Location = new System.Drawing.Point(16, 60);
            this.trvHobiler.Name = "trvHobiler";
            this.trvHobiler.Size = new System.Drawing.Size(180, 413);
            this.trvHobiler.TabIndex = 35;
            this.trvHobiler.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvHobiler_AfterCheck);
            this.trvHobiler.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvHobiler_AfterExpand);
            // 
            // dgvKisiBilgileri
            // 
            this.dgvKisiBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiBilgileri.Location = new System.Drawing.Point(244, 60);
            this.dgvKisiBilgileri.Name = "dgvKisiBilgileri";
            this.dgvKisiBilgileri.Size = new System.Drawing.Size(686, 192);
            this.dgvKisiBilgileri.TabIndex = 36;
            this.dgvKisiBilgileri.DoubleClick += new System.EventHandler(this.dgvKisiBilgileri_DoubleClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kisiAdi,
            this.kisiSoyadi,
            this.kisiTc,
            this.kisiTel,
            this.kisiEmail});
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(488, 165);
            this.listView1.TabIndex = 37;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // kisiAdi
            // 
            this.kisiAdi.Text = "Kisi Adı";
            this.kisiAdi.Width = 81;
            // 
            // kisiSoyadi
            // 
            this.kisiSoyadi.Text = "Kisi Soyadı";
            this.kisiSoyadi.Width = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnMesaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(244, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 368);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Kişiler";
            // 
            // kisiTc
            // 
            this.kisiTc.Text = "Tc No";
            this.kisiTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kisiTc.Width = 88;
            // 
            // kisiTel
            // 
            this.kisiTel.Text = "Telefon";
            this.kisiTel.Width = 92;
            // 
            // kisiEmail
            // 
            this.kisiEmail.Text = "E-mail";
            this.kisiEmail.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Secilen mail adreslerine direk kopyalayarak mail atabilirsiniz.";
            this.label2.Visible = false;
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(418, 190);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(75, 23);
            this.btnMesaj.TabIndex = 40;
            this.btnMesaj.Text = "Mesaj Gönder";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 20);
            this.textBox1.TabIndex = 42;
            // 
            // FormMesajGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKisiBilgileri);
            this.Controls.Add(this.trvHobiler);
            this.Controls.Add(this.label1);
            this.Name = "FormMesajGonder";
            this.Text = "FormMesajGonder";
            this.Load += new System.EventHandler(this.FormMesajGonder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiBilgileri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trvHobiler;
        private System.Windows.Forms.DataGridView dgvKisiBilgileri;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader kisiAdi;
        private System.Windows.Forms.ColumnHeader kisiSoyadi;
        private System.Windows.Forms.ColumnHeader kisiTc;
        private System.Windows.Forms.ColumnHeader kisiTel;
        private System.Windows.Forms.ColumnHeader kisiEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}