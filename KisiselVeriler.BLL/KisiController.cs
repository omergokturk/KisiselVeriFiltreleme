using KisiselVeriler.DAL;
using KisiselVeriler.DAL.KisiselVerilerDB;
using KisiselVeriler.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.BLL
{
    public class KisiController
    {
        KisiManagement _km;
        KisiHobileriManagement _khm;
        HobilerManagement _hm;
        public KisiController()
        {
            _khm = new KisiHobileriManagement();
            _km = new KisiManagement();
            _hm = new HobilerManagement();
        }
        public List<KisiBilgileriDTO> KisiselBilgileriGetir()
        {
            List<KisiselBilgiler> kisiselBilgiler = _km.KisiselBilgileriGetir();//dal katmanından kisisel bilgiler cekildi.
            return KisiBilgileriDTOMapping(kisiselBilgiler);
        }
        private KisiBilgileriDTO KisiBilgileriDTOMapping(KisiselBilgiler kisiselBilgiler)
        {
            KisiBilgileriDTO kisiBilgileriDTO = new KisiBilgileriDTO();
            kisiBilgileriDTO.kisiAdi = kisiselBilgiler.KisiAdi;
            kisiBilgileriDTO.kisiSoyAdi = kisiselBilgiler.KisiSoyadi;
            kisiBilgileriDTO.kisiTcNo = kisiselBilgiler.KisiTCNo;
            kisiBilgileriDTO.kisiDogumYeri = kisiselBilgiler.KisiDogumYeri;
            kisiBilgileriDTO.kisiDogumTarihi = (DateTime)kisiselBilgiler.KisiDogumTarihi;
            kisiBilgileriDTO.kisiAylikGelir = (decimal)kisiselBilgiler.KisiAylikGelir;
            kisiBilgileriDTO.kisiID = kisiselBilgiler.KisiID;
            kisiBilgileriDTO.kisiUyruk = kisiselBilgiler.KisiUyruk;
            kisiBilgileriDTO.AnneAdi = kisiselBilgiler.AileBilgileri.Select(p => p.AnneAdi).FirstOrDefault();
            kisiBilgileriDTO.BabaAdi = kisiselBilgiler.AileBilgileri.Select(p => p.BabaAdi).FirstOrDefault();
            kisiBilgileriDTO.KardesSayisi = kisiselBilgiler.AileBilgileri.Select(p => (byte)p.KardesSayisi).FirstOrDefault();
            kisiBilgileriDTO.Telefon = kisiselBilgiler.IletisimBilgileri.Select(p => p.Telefon).FirstOrDefault();
            kisiBilgileriDTO.Mail = kisiselBilgiler.IletisimBilgileri.Select(p => p.Mail).FirstOrDefault();
            kisiBilgileriDTO.Adres = kisiselBilgiler.IletisimBilgileri.Select(p => p.Adres).FirstOrDefault();

            return kisiBilgileriDTO;
        }
        public List<KisiBilgileriDTO> KisiBilgileriDTOMapping(List<KisiselBilgiler> kisiBilgileri)
        {
            List<KisiBilgileriDTO> listKisibilgileri = new List<KisiBilgileriDTO>();
            foreach (var item in kisiBilgileri)
            {
                KisiBilgileriDTO yeni = KisiBilgileriDTOMapping(item);
                listKisibilgileri.Add(yeni);
            }
            return listKisibilgileri;
        }

        public int KisiGuncelle(KisiBilgileriDTO kisiDTO)
        {
            KisiselBilgiler kb = _km.kisiGetirManagement(kisiDTO.kisiID);
            kb = KisiDTOtoEntityMapping(kisiDTO, kb);
            if (_km.kisiGuncelle(kb) > 0)
            {
                return kisiDTO.kisiID;
            }
            return 0;
        }
        public int kisiEkleController(KisiBilgileriDTO kisiDTO)
        {
            KisiselBilgiler kisiEntity = KisiDTOtoEntityMapping(kisiDTO);
            kisiEntity.IletisimBilgileri.Select(p => p.KisiID);
            try
            {
                if (_km.kisiEkleManagement(kisiEntity) > 0)
                {

                    return kisiEntity.KisiID;
                }
            }
            catch (Exception)
            {

            }
            return 0;

        }

        //public void kisiHobiEkleController(KisiHobiDTO kisiHobiDTO)
        //{
        //    int kisiID = kisiHobiDTO.KisiID;
        //    KisiselBilgiler secilenkisi = _km.IddenKisiNesnesiGetirManagement(kisiID);
        //    List<Hobiler> hobiler = KisiHobiDTOtoEntityMapping(kisiHobiDTO);

        //    foreach (var hobi in hobiler)
        //    {
        //        // secilenkisi.Hobiler.Add(hobi);

        //    }
        //    _km.kisiGuncelle(secilenkisi);
        //}

        public bool KisiHobileriEkle(KisiHobiDTO kisiHobiDTO)
        {
            int sonuc =0;
            List<KisiHobileri> kisiHobileriEntityList = KisiHobileriMapping(kisiHobiDTO);
            foreach (var kisiHobi in kisiHobileriEntityList)
            {
                sonuc = _khm.KisiHobileriEkle(kisiHobi);
            }
            if (sonuc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<KisiHobileri> KisiHobileriMapping(KisiHobiDTO kisiHobiDTO)
        {
            List<KisiHobileri> kisiHobiList = new List<KisiHobileri>();
            foreach (var hobiID in kisiHobiDTO.HobiIdList)
            {
                KisiHobileri kisiHobileri = new KisiHobileri();
                kisiHobileri.KisiID = kisiHobiDTO.KisiID;
                kisiHobileri.HobiID = hobiID;
                kisiHobiList.Add(kisiHobileri);
            }
            return kisiHobiList;
        }
        //public List<Hobiler> KisiHobiDTOtoEntityMapping(KisiHobiDTO kisiHobiDTO)
        //{
        //    List<Hobiler> hobiler = new List<Hobiler>();
        //    foreach (var hobiId in kisiHobiDTO.HobiIdList)
        //    {
        //        Hobiler hobi = _hm.GetHobiById(hobiId);
        //        hobiler.Add(hobi);
        //    }
        //    return hobiler;
        //}
        public KisiselBilgiler KisiDTOtoEntityMapping(KisiBilgileriDTO kisiDTO,KisiselBilgiler kisiselBilgiler)
        {

            kisiselBilgiler.KisiAdi = kisiDTO.kisiAdi;
            kisiselBilgiler.KisiSoyadi = kisiDTO.kisiSoyAdi;
            kisiselBilgiler.KisiTCNo = kisiDTO.kisiTcNo;
            kisiselBilgiler.KisiUyruk = kisiDTO.kisiUyruk;
            kisiselBilgiler.KisiDogumYeri = kisiDTO.kisiDogumYeri;
            kisiselBilgiler.KisiAylikGelir = kisiDTO.kisiAylikGelir;
            kisiselBilgiler.KisiDogumTarihi = kisiDTO.kisiDogumTarihi;

            foreach (var ab in kisiselBilgiler.AileBilgileri)
            {
                ab.AnneAdi = kisiDTO.AnneAdi;
                ab.BabaAdi = kisiDTO.BabaAdi;
                ab.KardesSayisi = kisiDTO.KardesSayisi; 
            }
            foreach (var ab in kisiselBilgiler.IletisimBilgileri)
            {
                ab.Telefon = kisiDTO.Telefon;
                ab.Mail = kisiDTO.Mail;
                ab.Adres = kisiDTO.Adres;
            }



            return kisiselBilgiler;
        }
        public KisiselBilgiler KisiDTOtoEntityMapping(KisiBilgileriDTO kisiDTO)
        {
            KisiselBilgiler kisiEntityNesnesi = new KisiselBilgiler();
            kisiEntityNesnesi.KisiAdi = kisiDTO.kisiAdi;
            kisiEntityNesnesi.KisiSoyadi = kisiDTO.kisiSoyAdi;
            kisiEntityNesnesi.KisiTCNo = kisiDTO.kisiTcNo;
            kisiEntityNesnesi.KisiUyruk = kisiDTO.kisiUyruk;
            kisiEntityNesnesi.KisiDogumYeri = kisiDTO.kisiDogumYeri;
            kisiEntityNesnesi.KisiAylikGelir = kisiDTO.kisiAylikGelir;
            kisiEntityNesnesi.KisiDogumTarihi = kisiDTO.kisiDogumTarihi;
            return kisiEntityNesnesi;
        }
        public KisiBilgileriDTO kisiGetirController(int _kisiId)
        {
            KisiselBilgiler bulunanKisi = new KisiselBilgiler();
            bulunanKisi = _km.kisiGetirManagement(_kisiId);
            return kisiEntityToDTOmapping(bulunanKisi);
        }
        public KisiBilgileriDTO kisiGetirController(string _bulunacakTc)
        {
            KisiselBilgiler bulunanKisi = new KisiselBilgiler();
            bulunanKisi = _km.kisiGetirManagement(_bulunacakTc);
            return kisiEntityToDTOmapping(bulunanKisi);
        }
        private KisiBilgileriDTO kisiEntityToDTOmapping(KisiselBilgiler bulunanKisi)
        {
            KisiBilgileriDTO kisi = new KisiBilgileriDTO();
            if (bulunanKisi != null)
            {

                kisi.kisiAdi = bulunanKisi.KisiAdi;
                kisi.kisiSoyAdi = bulunanKisi.KisiSoyadi;
                kisi.kisiTcNo = bulunanKisi.KisiTCNo;
                kisi.kisiAylikGelir = bulunanKisi.KisiAylikGelir;
                kisi.kisiDogumTarihi = bulunanKisi.KisiDogumTarihi;
                kisi.kisiDogumYeri = bulunanKisi.KisiDogumYeri;
                kisi.kisiID = bulunanKisi.KisiID;
                kisi.kisiUyruk = bulunanKisi.KisiUyruk;
                kisi.AnneAdi = bulunanKisi.AileBilgileri.Select(x => x.AnneAdi).FirstOrDefault();
                kisi.BabaAdi= bulunanKisi.AileBilgileri.Select(x => x.BabaAdi).FirstOrDefault();
                kisi.KardesSayisi= bulunanKisi.AileBilgileri.Select(x => x.KardesSayisi).FirstOrDefault();
                kisi.Mail= bulunanKisi.IletisimBilgileri.Select(x => x.Mail).FirstOrDefault();
                kisi.Telefon = bulunanKisi.IletisimBilgileri.Select(x => x.Telefon).FirstOrDefault();
                kisi.Adres = bulunanKisi.IletisimBilgileri.Select(x => x.Adres).FirstOrDefault();
                return kisi;
            }
            else
            {
                kisi.kisiAdi = null;
                kisi.kisiSoyAdi = null;
                kisi.kisiTcNo = null;
                kisi.kisiAylikGelir = null;
                kisi.kisiDogumTarihi = DateTime.Now;
                kisi.kisiDogumYeri = null;
                kisi.kisiUyruk = null;
                return kisi;
            }

        }
    }
}
