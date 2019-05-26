namespace KisiselVerilerUI
{
    partial class FormAnaEkran
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kişiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hobiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hobilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiEkleToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.mesajGönderToolStripMenuItem,
            this.hobilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kişiEkleToolStripMenuItem
            // 
            this.kişiEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.görüntüleToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.kişiEkleToolStripMenuItem.Name = "kişiEkleToolStripMenuItem";
            this.kişiEkleToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.kişiEkleToolStripMenuItem.Text = "Kişiler";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            this.görüntüleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.görüntüleToolStripMenuItem.Text = "Güncelle";
            this.görüntüleToolStripMenuItem.Click += new System.EventHandler(this.görüntüleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem.Text = "Görüntüle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hobiEkleToolStripMenuItem});
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.çıkışToolStripMenuItem.Text = "Hobiler";
            // 
            // hobiEkleToolStripMenuItem
            // 
            this.hobiEkleToolStripMenuItem.Name = "hobiEkleToolStripMenuItem";
            this.hobiEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hobiEkleToolStripMenuItem.Text = "Ekle";
            this.hobiEkleToolStripMenuItem.Click += new System.EventHandler(this.hobiEkleToolStripMenuItem_Click);
            // 
            // mesajGönderToolStripMenuItem
            // 
            this.mesajGönderToolStripMenuItem.Name = "mesajGönderToolStripMenuItem";
            this.mesajGönderToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.mesajGönderToolStripMenuItem.Text = "Mesaj Gönder";
            this.mesajGönderToolStripMenuItem.Click += new System.EventHandler(this.mesajGönderToolStripMenuItem_Click);
            // 
            // hobilerToolStripMenuItem
            // 
            this.hobilerToolStripMenuItem.Name = "hobilerToolStripMenuItem";
            this.hobilerToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hobilerToolStripMenuItem.Text = "Çıkış";
            this.hobilerToolStripMenuItem.Click += new System.EventHandler(this.hobilerToolStripMenuItem_Click);
            // 
            // FormAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 350);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnaEkran";
            this.Text = "FormAnaEkran";
            this.Load += new System.EventHandler(this.FormAnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kişiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hobilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hobiEkleToolStripMenuItem;
    }
}