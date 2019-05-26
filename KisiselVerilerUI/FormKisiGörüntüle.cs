using KisiselVeriler.BLL;
using KisiselVeriler.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KisiselVerilerUI
{
    public partial class FormKisiGörüntüle : Form
    {
        KisiController _kc;
        AileController _aileController;
        int _seciliId;

        public FormKisiGörüntüle()
        {
            InitializeComponent();
            _kc = new KisiController();
            _aileController = new AileController();

        }

        private void FormKisiGörüntüle_Load(object sender, EventArgs e)
        {
            List<KisiBilgileriDTO> kisiler = _kc.KisiselBilgileriGetir();
            dataGridView1.DataSource = kisiler;
            
          

        }



        private void btnAile_MouseHover(object sender, EventArgs e)
        {
            //ToolTip aileBilgileri = new ToolTip();
            //aileBilgileri.ToolTipIcon = ToolTipIcon.Info;
            //aileBilgileri.ToolTipTitle = "... ID'li Kişinin Aile Bilgileri !";
            //aileBilgileri.IsBalloon = true;
            //aileBilgileri.SetToolTip(btnAile, "Aile Bilgileri bla bla bla");

            AileBilgileriDTO aileDTO = new AileBilgileriDTO();
            _seciliId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["kisiId"].Value);
            aileDTO = _aileController.aileGetirController(_seciliId);


            btnAile.Location = new Point(12, 188);
            btnAile.Width = 286;
            btnAile.Height = 208;
            // btnAile.Location = btnAile.Location;
            btnAile.Text = "Anne Adı: "+aileDTO.AnneAdi+"\n\nBaba Adı: "+aileDTO.BabaAdi+"\n\nKardeş Sayısı: "+aileDTO.KardesSayisi;

        }
        private void btnAile_MouseLeave(object sender, EventArgs e)
        {
            btnAile.Width = 140;
            btnAile.Height = 40;
            btnAile.Text = "Aile Bilgileri";
            btnAile.Location = new Point(12, 356);
        }

        private void btnHobi_MouseHover(object sender, EventArgs e)
        {
            ToolTip hobiBilgileri = new ToolTip();
            hobiBilgileri.ToolTipIcon = ToolTipIcon.Info;
            hobiBilgileri.ToolTipTitle = "... ID'li Kişinin Hobi Bilgileri !";
            hobiBilgileri.IsBalloon = true;
            hobiBilgileri.SetToolTip(btnHobi, "Hobi Bilgileri bla bla bla");
        }

        private void btnEgitim_MouseHover(object sender, EventArgs e)
        {
            ToolTip egitimBilgileri = new ToolTip();
            egitimBilgileri.ToolTipIcon = ToolTipIcon.Info;
            egitimBilgileri.ToolTipTitle = "... ID'li Kişinin Eğitim Bilgileri !";
            egitimBilgileri.IsBalloon = true;
            egitimBilgileri.SetToolTip(btnEgitim, "Eğitim Bilgileri bla bla bla");
        }

     
     

       
    }
}
