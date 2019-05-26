using KisiselVeriler.BLL;
using KisiselVeriler.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselVerilerUI
{
    public partial class FormKisiGuncelle : Form
    {
        KisiController _kc;
        KisiController _kisiControler;
        AileController _aileController;
        IletisimController _iletisimController;
        //KisiBilgileriDTO _kisiDTO;
        //AileBilgileriDTO _aileDTO;
        //IletisimBilgileriDTO _iletisimDTO;
        KisiBilgileriDTO _bulunanKisi;
        AileBilgileriDTO _kisininAilesi;
        IletisimBilgileriDTO _kisininIletisimBilgileri;
        public FormKisiGuncelle()
        {
            _kc = new KisiController();
            _kisiControler = new KisiController();
            _aileController = new AileController();
            _iletisimController = new IletisimController();
            //_kisiDTO = new KisiBilgileriDTO();
            //_aileDTO = new AileBilgileriDTO();
            //_iletisimDTO = new IletisimBilgileriDTO()
                _bulunanKisi = new KisiBilgileriDTO();
            _kisininAilesi= new AileBilgileriDTO();
            _kisininIletisimBilgileri = new IletisimBilgileriDTO();
            InitializeComponent();
        }

        private void FormKisiGuncelle_Load(object sender, EventArgs e)
        {
            List<KisiBilgileriDTO> kisiler = _kc.KisiselBilgileriGetir();
            lstGuncelle.DisplayMember = "KisiAdi";
            lstGuncelle.ValueMember = "KisiId";
            lstGuncelle.DataSource = kisiler;
        }

        private void lstGuncelle_DoubleClick(object sender, EventArgs e)
        {
            int secilisatir = (int)lstGuncelle.SelectedValue;
           
            _bulunanKisi = _kisiControler.kisiGetirController(secilisatir);
            textBox1.Text = _bulunanKisi.kisiID.ToString();



            if (_bulunanKisi.kisiID != null)
            {

                txtAd.Text = _bulunanKisi.kisiAdi;
                txtSoyad.Text = _bulunanKisi.kisiSoyAdi;
                txtAylikGelir.Text = Convert.ToString(_bulunanKisi.kisiAylikGelir);
                txtUyruk.Text = _bulunanKisi.kisiUyruk;
                txtTc.Text = _bulunanKisi.kisiTcNo;
                txtDogumYeri.Text = _bulunanKisi.kisiDogumYeri;
                dtpDogumTarihi.Value = _bulunanKisi.kisiDogumTarihi;
                txtAnneAdi.Text = _bulunanKisi.AnneAdi;
                txtBabaAdi.Text = _bulunanKisi.BabaAdi;
                nudKardesSayisi.Value = (byte)_bulunanKisi.KardesSayisi;
                txtTelNo.Text = _bulunanKisi.Telefon;
                txtMail.Text = _bulunanKisi.Mail;
                txtAdres.Text = _bulunanKisi.Adres;

                //_kisininAilesi = _aileController.aileGetirController(_bulunanKisi.kisiID);
                //txtAnneAdi.Text = _kisininAilesi.AnneAdi;
                //txtBabaAdi.Text = _kisininAilesi.BabaAdi;
                //nudKardesSayisi.Value = (byte)_kisininAilesi.KardesSayisi;


                //_kisininIletisimBilgileri = _iletisimController.iletisimGetirController(_bulunanKisi.kisiID);
                //txtAdres.Text = _kisininIletisimBilgileri.Adres;
                //txtTelNo.Text = _kisininIletisimBilgileri.Telefon;
                //txtMail.Text = _kisininIletisimBilgileri.Mail;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _bulunanKisi.kisiAdi = txtAd.Text;
            _bulunanKisi.kisiSoyAdi = txtSoyad.Text;
            _bulunanKisi.kisiTcNo = txtTc.Text;
            _bulunanKisi.kisiUyruk = txtUyruk.Text;
            _bulunanKisi.kisiDogumTarihi = dtpDogumTarihi.Value;
            _bulunanKisi.kisiAylikGelir = Convert.ToDecimal(txtAylikGelir.Text);
            _bulunanKisi.kisiDogumYeri = txtDogumYeri.Text;


            _bulunanKisi.AnneAdi = txtAnneAdi.Text;
            _bulunanKisi.BabaAdi = txtBabaAdi.Text;
            _bulunanKisi.KardesSayisi = (byte)nudKardesSayisi.Value;

            _bulunanKisi.Adres = txtAdres.Text;
            _bulunanKisi.Telefon = txtTelNo.Text;
            _bulunanKisi.Mail = txtMail.Text;


            _bulunanKisi.kisiID = _kisiControler.KisiGuncelle(_bulunanKisi);

            //_kisininAilesi.KisiID = _bulunanKisi.kisiID;
            //_kisininAilesi.AnneAdi = txtAnneAdi.Text;
            //_kisininAilesi.BabaAdi = txtBabaAdi.Text;
            //_kisininAilesi.KardesSayisi = (byte)nudKardesSayisi.Value;

            //bool ailekayitOldumu = _aileController.AileGuncelle(_kisininAilesi);


            //_kisininIletisimBilgileri.Telefon = txtTelNo.Text;
            //_kisininIletisimBilgileri.Mail = txtMail.Text;
            //_kisininIletisimBilgileri.KisiID = _bulunanKisi.kisiID;
            //_kisininIletisimBilgileri.Adres = txtAdres.Text;

            

            //bool iletisimbilgisiEklendimi = _iletisimController.IletisimEkleController(_kisininIletisimBilgileri);



            if (_bulunanKisi.kisiID > 0 /*&& ailekayitOldumu && iletisimbilgisiEklendim*/)
            {
                MessageBox.Show("Kişinin bilgileri eklendi.");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız.");
            }
        }
    }
}
