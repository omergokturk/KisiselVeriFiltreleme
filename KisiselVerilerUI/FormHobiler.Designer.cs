namespace KisiselVerilerUI
{
    partial class FormHobiler
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
            this.lstUstKategoriler = new System.Windows.Forms.ListBox();
            this.lstAltKategoriler = new System.Windows.Forms.ListBox();
            this.btnAltKatEkle = new System.Windows.Forms.Button();
            this.btnUstKatEkle = new System.Windows.Forms.Button();
            this.txtUstKatAdi = new System.Windows.Forms.TextBox();
            this.txtAltKatAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstUstKategoriler
            // 
            this.lstUstKategoriler.FormattingEnabled = true;
            this.lstUstKategoriler.Location = new System.Drawing.Point(29, 23);
            this.lstUstKategoriler.Name = "lstUstKategoriler";
            this.lstUstKategoriler.Size = new System.Drawing.Size(177, 225);
            this.lstUstKategoriler.TabIndex = 0;
            this.lstUstKategoriler.SelectedIndexChanged += new System.EventHandler(this.lstUstKategoriler_SelectedIndexChanged);
            // 
            // lstAltKategoriler
            // 
            this.lstAltKategoriler.FormattingEnabled = true;
            this.lstAltKategoriler.Location = new System.Drawing.Point(225, 23);
            this.lstAltKategoriler.Name = "lstAltKategoriler";
            this.lstAltKategoriler.Size = new System.Drawing.Size(177, 225);
            this.lstAltKategoriler.TabIndex = 0;
            // 
            // btnAltKatEkle
            // 
            this.btnAltKatEkle.Location = new System.Drawing.Point(225, 290);
            this.btnAltKatEkle.Name = "btnAltKatEkle";
            this.btnAltKatEkle.Size = new System.Drawing.Size(177, 23);
            this.btnAltKatEkle.TabIndex = 2;
            this.btnAltKatEkle.Text = "Alt Kategori Ekle";
            this.btnAltKatEkle.UseVisualStyleBackColor = true;
            this.btnAltKatEkle.Click += new System.EventHandler(this.btnAltKatEkle_Click);
            // 
            // btnUstKatEkle
            // 
            this.btnUstKatEkle.Location = new System.Drawing.Point(29, 290);
            this.btnUstKatEkle.Name = "btnUstKatEkle";
            this.btnUstKatEkle.Size = new System.Drawing.Size(177, 23);
            this.btnUstKatEkle.TabIndex = 2;
            this.btnUstKatEkle.Text = "Ust Kategori Ekle";
            this.btnUstKatEkle.UseVisualStyleBackColor = true;
            this.btnUstKatEkle.Click += new System.EventHandler(this.btnUstKatEkle_Click);
            // 
            // txtUstKatAdi
            // 
            this.txtUstKatAdi.Location = new System.Drawing.Point(29, 264);
            this.txtUstKatAdi.Name = "txtUstKatAdi";
            this.txtUstKatAdi.Size = new System.Drawing.Size(177, 20);
            this.txtUstKatAdi.TabIndex = 3;
            // 
            // txtAltKatAdi
            // 
            this.txtAltKatAdi.Location = new System.Drawing.Point(225, 264);
            this.txtAltKatAdi.Name = "txtAltKatAdi";
            this.txtAltKatAdi.Size = new System.Drawing.Size(177, 20);
            this.txtAltKatAdi.TabIndex = 3;
            // 
            // FormIlgiAlanlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 359);
            this.Controls.Add(this.txtAltKatAdi);
            this.Controls.Add(this.txtUstKatAdi);
            this.Controls.Add(this.btnUstKatEkle);
            this.Controls.Add(this.btnAltKatEkle);
            this.Controls.Add(this.lstAltKategoriler);
            this.Controls.Add(this.lstUstKategoriler);
            this.Name = "FormIlgiAlanlari";
            this.Text = "Hobiler Ekranı";
            this.Load += new System.EventHandler(this.FormIlgiAlanlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUstKategoriler;
        private System.Windows.Forms.ListBox lstAltKategoriler;
        private System.Windows.Forms.Button btnAltKatEkle;
        private System.Windows.Forms.Button btnUstKatEkle;
        private System.Windows.Forms.TextBox txtUstKatAdi;
        private System.Windows.Forms.TextBox txtAltKatAdi;
    }
}