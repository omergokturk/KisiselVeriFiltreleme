namespace KisiselVerilerUI
{
    partial class FormKisiGörüntüle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAile = new System.Windows.Forms.Button();
            this.btnHobi = new System.Windows.Forms.Button();
            this.btnEgitim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 338);
            this.dataGridView1.TabIndex = 0;
          
            
            // 
            // btnAile
            // 
            this.btnAile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAile.Location = new System.Drawing.Point(12, 356);
            this.btnAile.Name = "btnAile";
            this.btnAile.Size = new System.Drawing.Size(140, 40);
            this.btnAile.TabIndex = 1;
            this.btnAile.Text = "Aile Bilgileri";
            this.btnAile.UseVisualStyleBackColor = true;
            this.btnAile.MouseLeave += new System.EventHandler(this.btnAile_MouseLeave);
            this.btnAile.MouseHover += new System.EventHandler(this.btnAile_MouseHover);
            // 
            // btnHobi
            // 
            this.btnHobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHobi.Location = new System.Drawing.Point(320, 356);
            this.btnHobi.Name = "btnHobi";
            this.btnHobi.Size = new System.Drawing.Size(140, 40);
            this.btnHobi.TabIndex = 1;
            this.btnHobi.Text = "Hobi Bilgileri";
            this.btnHobi.UseVisualStyleBackColor = true;
            this.btnHobi.MouseHover += new System.EventHandler(this.btnHobi_MouseHover);
            // 
            // btnEgitim
            // 
            this.btnEgitim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgitim.Location = new System.Drawing.Point(612, 356);
            this.btnEgitim.Name = "btnEgitim";
            this.btnEgitim.Size = new System.Drawing.Size(140, 40);
            this.btnEgitim.TabIndex = 1;
            this.btnEgitim.Text = "Eğitim Bilgileri";
            this.btnEgitim.UseVisualStyleBackColor = true;
            this.btnEgitim.MouseHover += new System.EventHandler(this.btnEgitim_MouseHover);
            // 
            // FormKisiGörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 408);
            this.Controls.Add(this.btnEgitim);
            this.Controls.Add(this.btnHobi);
            this.Controls.Add(this.btnAile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKisiGörüntüle";
            this.Text = "Kişi Bilgileri";
            this.Load += new System.EventHandler(this.FormKisiGörüntüle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAile;
        private System.Windows.Forms.Button btnHobi;
        private System.Windows.Forms.Button btnEgitim;
    }
}