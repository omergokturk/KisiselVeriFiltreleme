using KisiselVeriler.BLL;
using KisiselVeriler.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KisiselVerilerUI
{
    public partial class KisiBilgiKayıt : Form
    {
        KisiController _kisiControler;
        AileController _aileController;
        IletisimController _iletisimController;
        HobilerController _hc;
        KisiBilgileriDTO _kisiDTO;
        IletisimBilgileriDTO _iletisimDTO;
        AileBilgileriDTO _aileDTO;
        ErrorProvider errorProvider;
        bool _validationGecerliMi = false;
        KisiHobiDTO _kisiHobi;
        List<TreeNode> _treeNodesList;
        List<TreeNode> _tiklananTreeNodes;
        List<TreeNode> _secilenTreeNodes;
        string _tcSorgula;

        public KisiBilgiKayıt()
        {
            errorProvider = new ErrorProvider();
            _aileController = new AileController();
            _kisiControler = new KisiController();
            _iletisimController = new IletisimController();
            _hc = new HobilerController();
            _kisiDTO = new KisiBilgileriDTO();
            _aileDTO = new AileBilgileriDTO();
            _iletisimDTO = new IletisimBilgileriDTO();
            _kisiHobi = new KisiHobiDTO();
            _treeNodesList = new List<TreeNode>();
            _tiklananTreeNodes = new List<TreeNode>();
            _secilenTreeNodes = new List<TreeNode>();

            InitializeComponent();
        }
        private void KisiBilgiKayıt_Load(object sender, EventArgs e)
        {
            HobiTreeViewListele();
        }
        private void HobiTreeViewListele()
        {
            List<HobilerDTO> hobiler = _hc.HobileriGetir();
            foreach (var hobi in hobiler)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = hobi.HobiAdi;
                treeNode.Tag = hobi.HobiID;
                trvHobiler.Nodes.Add(treeNode);

                List<HobilerDTO> altHobiler = _hc.AltHobileriGetir(hobi.HobiID);
                foreach (var altHobi in altHobiler)
                {
                    TreeNode altTreeNode = new TreeNode();
                    altTreeNode.Text = altHobi.HobiAdi;
                    altTreeNode.Tag = altHobi.HobiID;
                    treeNode.Nodes.Add(altTreeNode);
                }
            }

        }
        private void trvHobiler_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Checked = true;
            if (!_treeNodesList.Contains(e.Node))
            {
                _treeNodesList.Add(e.Node);
                TreeNode expandedNode = e.Node;
                foreach (TreeNode node in expandedNode.Nodes)
                {
                    try
                    {
                        List<HobilerDTO> altHobiler = _hc.AltHobileriGetir((int)node.Tag);
                        foreach (var altHobi in altHobiler)
                        {
                            TreeNode altNode = new TreeNode();
                            altNode.Text = altHobi.HobiAdi;
                            altNode.Tag = altHobi.HobiID;
                            node.Nodes.Add(altNode);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
        private void trvHobiler_AfterCheck(object sender, TreeViewEventArgs e)
        {
            _tiklananTreeNodes.Add(e.Node);
        }

        private void btnHobiKaydet_Click(object sender, EventArgs e)
        {
            bool hobiKaydedildiMi = false;
            List<int> hobiIdleri = new List<int>();
            foreach (var tiklananNode in _tiklananTreeNodes)
            {
                if (tiklananNode.Checked == true)
                {
                    _secilenTreeNodes.Add(tiklananNode);
                }
            }
            _kisiHobi.KisiID = _kisiDTO.kisiID;
            foreach (TreeNode node in _secilenTreeNodes)
            {
                int nodeId = (int)node.Tag;
                //KisHobileri tablosundaki bu iddeki hobiden kisininID si ile kisi tablosundaki kisileri getir
                //list box at
                hobiIdleri.Add(nodeId);
            }
            _kisiHobi.HobiIdList = hobiIdleri;
            hobiKaydedildiMi = _kisiControler.KisiHobileriEkle(_kisiHobi);
            if (hobiKaydedildiMi)
            {
                MessageBox.Show("Hobiler kaydedildi.");
            }
            else
            {
                MessageBox.Show("Hobiler kaydedilemedi.");
            }
        }

        private void btnKisiKaydet_Click(object sender, EventArgs e)
        {

            _kisiDTO.kisiAdi = txtAd.Text;
            _kisiDTO.kisiSoyAdi = txtSoyad.Text;
            _kisiDTO.kisiTcNo = txtTc.Text;
            _kisiDTO.kisiUyruk = txtUyruk.Text;
            _kisiDTO.kisiDogumTarihi = dtpDogumTarihi.Value;
            if (txtAylikGelir.Text.Length != 0)
            {
                _kisiDTO.kisiAylikGelir = Convert.ToDecimal(txtAylikGelir.Text);
            }
            else
            {
                errorProvider.SetError(txtAylikGelir, "Aylık gelir alanı boş bırakılamaz.");
                // MessageBox.Show("Bu alan boş bırakılamaz.");
            }
            _kisiDTO.kisiDogumYeri = txtDogumYeri.Text;
            if (_validationGecerliMi)
            {
                _kisiDTO.kisiID = _kisiControler.kisiEkleController(_kisiDTO);
            }
            else
            {
                MessageBox.Show("Girdiginiz alanları kontrol ediniz");
                return;
            }
            

            if (_kisiDTO.kisiID > 0)
            {
                MessageBox.Show("Kişinin bilgileri eklendi.");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız.");
            }
            grbAileBilgileri.Visible = true;
        }
        private void btnAileKaydet_Click(object sender, EventArgs e)
        {
            _aileDTO.KisiID = _kisiDTO.kisiID;
            _aileDTO.AnneAdi = txtAnneAdi.Text;
            _aileDTO.BabaAdi = txtBabaAdi.Text;
            _aileDTO.KardesSayisi = (byte)nudKardesSayisi.Value;
            if (_validationGecerliMi)
            {
                if (_aileController.AileEkleController(_aileDTO))
                {
                    MessageBox.Show("Kişinin aile bilgileri eklendi.");
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız.");
                }
            }
            else
            {
                MessageBox.Show("Girdiginiz alanları kontrol ediniz");
                return;
            }

            grbIletisim.Visible = true;
            //kisiDTO.kisiID;== Kaydedilen Kisi ID dir.
        }
        private void btnIletisimKaydet_Click(object sender, EventArgs e)
        {
            //kisiDTO.kisiID;== Kaydedilen Kisi ID dir.

            _iletisimDTO.Telefon = txtTelNo.Text;
            _iletisimDTO.Mail = txtMail.Text;
            _iletisimDTO.KisiID = _kisiDTO.kisiID;
            _iletisimDTO.Adres = txtAdres.Text;
            if (_validationGecerliMi)
            {
                if (_iletisimController.IletisimEkleController(_iletisimDTO))
                {
                    MessageBox.Show("Kişinin İletisim bilgileri eklendi.");
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız.");
                }
            }
            else
            {
                MessageBox.Show("Girdiginiz alanları kontrol ediniz");
                return;
            }


            grbHobiEkle.Visible = true;

        }
        private void btnTcAra_Click(object sender, EventArgs e)
        {
            KisiBilgileriDTO bulunanKisi = new KisiBilgileriDTO();
            if (txtIDara.Text != null)
            {
                _tcSorgula = txtIDara.Text;
                bulunanKisi = _kisiControler.kisiGetirController(_tcSorgula);

                if (bulunanKisi.kisiID > 0)
                {
                    btnAileKaydet.Visible = false;
                    btnIletisimKaydet.Visible = false;
                    btnKisiKaydet.Visible = false;
                    btnHobiKaydet.Visible = false;
                    txtAd.Text = bulunanKisi.kisiAdi;
                    txtSoyad.Text = bulunanKisi.kisiSoyAdi;
                    txtAylikGelir.Text = Convert.ToString(bulunanKisi.kisiAylikGelir);
                    txtUyruk.Text = bulunanKisi.kisiUyruk;
                    txtTc.Text = bulunanKisi.kisiTcNo;
                    txtDogumYeri.Text = bulunanKisi.kisiDogumYeri;
                    dtpDogumTarihi.Value = bulunanKisi.kisiDogumTarihi;
                    grbAileBilgileri.Visible = true;
                    grbIletisim.Visible = true;
                    grbHobiEkle.Visible = true;
                    AileBilgileriDTO kisininAilesi = new AileBilgileriDTO();
                    kisininAilesi = _aileController.aileGetirController(bulunanKisi.kisiID);
                    txtAnneAdi.Text = kisininAilesi.AnneAdi;
                    txtBabaAdi.Text = kisininAilesi.BabaAdi;
                    nudKardesSayisi.Value = (byte)kisininAilesi.KardesSayisi;
                    IletisimBilgileriDTO kisininIletisimBilgileri = new IletisimBilgileriDTO();
                    kisininIletisimBilgileri = _iletisimController.iletisimGetirController(bulunanKisi.kisiID);
                    txtAdres.Text = kisininIletisimBilgileri.Adres;
                    txtTelNo.Text = kisininIletisimBilgileri.Telefon;
                    txtMail.Text = kisininIletisimBilgileri.Mail;
                }
                else
                {
                    txtTc.Text = _tcSorgula;
                }
            }
        }

        #region Validations
        private void txtIDara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            try
            {
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (!re.IsMatch(txtMail.Text))
                {
                    errorProvider.SetError(txtMail, "Geçerli mail adresi giriniz.");
                    _validationGecerliMi = false;
                }
                else if (txtMail.Text.Length == 0)
                {
                    errorProvider.SetError(txtMail, "Geçerli mail adresi giriniz.");
                    _validationGecerliMi = false;
                }
                else
                {
                    errorProvider.Clear();
                    _validationGecerliMi = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
        }
        private void txtTc_Leave(object sender, EventArgs e)
        {
            if (txtTc.Text.Length != 11)
            {
                errorProvider.SetError(txtTc, "TC No bilgisini doğru giriniz.");
                _validationGecerliMi = false;
            }
            else
            {
                errorProvider.Clear();
                _validationGecerliMi = true;
            }
        }
        private void txtAd_Leave(object sender, EventArgs e)
        {
            if (txtAd.Text.Length == 0)
            {
                errorProvider.SetError(txtAd, "Ad alanı boş bırakılamaz.");
                _validationGecerliMi = false;
            }
            else
            {
                errorProvider.Clear();
                _validationGecerliMi = true;
            }
        }
        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            if (txtSoyad.Text.Length == 0)
            {
                errorProvider.SetError(txtSoyad, "Ad alanı boş bırakılamaz.");
                _validationGecerliMi = false;
            }
            else
            {
                errorProvider.Clear();
                _validationGecerliMi = true;
            }
        }
        private void txtTelNo_Leave(object sender, EventArgs e)
        {
            if (txtTelNo.Text.Length == 10 || txtTelNo.Text.Length == 11)
            {
                errorProvider.Clear();
                _validationGecerliMi = true;

            }
            else
            {
                errorProvider.SetError(txtTelNo, "Telefon alanını kontrol ediniz.");
                _validationGecerliMi = false;
            }
        }
        private void txtAylikGelir_Leave(object sender, EventArgs e)
        {
            if (txtAylikGelir.Text.Length == 0)
            {
                errorProvider.SetError(txtAylikGelir, "Aylık gelir alanı boş bırakılamaz.");
                _validationGecerliMi = false;
            }
            else
            {
                errorProvider.Clear();
                _validationGecerliMi = true;
            }
        }
        #endregion

        
    }
}