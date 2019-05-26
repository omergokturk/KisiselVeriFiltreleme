using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KisiselVeriler.DTO;
using KisiselVeriler.BLL;

namespace KisiselVerilerUI
{
    public partial class FormHobiler : Form
    {
        HobilerController _hc;
        public FormHobiler()
        {
            InitializeComponent();
            _hc = new HobilerController();
        }

        private void FormIlgiAlanlari_Load(object sender, EventArgs e)
        {
            UstKategoriListele();
        }
        private void UstKategoriListele()
        {
            lstUstKategoriler.DataSource = null;
            List <HobilerDTO> hobiler = _hc.HobileriGetir();            
            lstUstKategoriler.DisplayMember = "HobiAdi";
            lstUstKategoriler.ValueMember = "HobiID";
            lstUstKategoriler.DataSource = hobiler;
        }
        private void lstUstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUstKategoriler.SelectedIndex == -1)
            {
                return;                
            }
            int secilenUstKategoriID = (int)lstUstKategoriler.SelectedValue;
            List<HobilerDTO> hobiler = _hc.AltHobileriGetir(secilenUstKategoriID);
            lstAltKategoriler.DisplayMember = "HobiAdi";
            lstAltKategoriler.ValueMember = "HobiID";
            lstAltKategoriler.DataSource = hobiler;
        }

        private void btnUstKatEkle_Click(object sender, EventArgs e)
        {
            HobilerDTO hobilerDTO = new HobilerDTO();
            hobilerDTO.HobiAdi = txtUstKatAdi.Text;
            hobilerDTO.HobiUstKategoriID = null;
            if (_hc.HobiEkle(hobilerDTO))
            {
                MessageBox.Show("Kayıt başarılı");
                UstKategoriListele();
            }
            else
            {
                MessageBox.Show("Kayıt başarısız");
            }
            
        }

        private void btnAltKatEkle_Click(object sender, EventArgs e)
        {
            if (lstUstKategoriler.SelectedIndex == -1)
            {
                MessageBox.Show("Eklemek istediğiniz Hobinin Üst Hobisini seçiniz.");
                return;
            }
            HobilerDTO hobilerDTO = new HobilerDTO();
            hobilerDTO.HobiAdi = txtAltKatAdi.Text;
            hobilerDTO.HobiUstKategoriID = (int)lstUstKategoriler.SelectedValue; //secilen ust kategorinin id si
            if (_hc.HobiEkle(hobilerDTO))
            {
                MessageBox.Show("Kayıt başarılı");
                UstKategoriListele();
            }
            else
            {
                MessageBox.Show("Kayıt başarısız");
            }
        }
    }
}
