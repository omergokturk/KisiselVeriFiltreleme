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
    public class HobilerController
    {
        HobilerManagement _hm;
        KisiHobileriManagement _khm;
        KisiManagement _km;
        KisiController _kc;
        List<int> _kisiIDleri;
        public HobilerController()
        {
            _kisiIDleri = new List<int>();
            _hm = new HobilerManagement();
            _khm = new KisiHobileriManagement();
            _km = new KisiManagement();
            _kc = new KisiController();
        }

        public bool HobiEkle(HobilerDTO dto)
        {
            Hobiler hobi = HobilerMapping(dto);
            try
            {
                if (_hm.HobiEkle(hobi) > 0)
                {

                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public List<KisiBilgileriDTO>  HobiIDdenKisiGetir(int hobiID)
        {
            List<KisiselBilgiler> kisiListesi = new List<KisiselBilgiler>();
            
            _kisiIDleri = _khm.HobiIDdenKisiIDGetir(hobiID);
            foreach (var kisiID in _kisiIDleri)
            {
                KisiselBilgiler kisisel = new KisiselBilgiler();
                kisisel = _km.IddenKisiNesnesiGetirManagement(kisiID);
                kisiListesi.Add(kisisel);
            }
            return _kc.KisiBilgileriDTOMapping(kisiListesi);
        }

        public List<HobilerDTO> HobileriGetir()
        {
            List<Hobiler> hobiler = _hm.HobileriGetir();
            List<Hobiler> UstHobiler = _hm.UstHobileriGetir();
            return HobilerDTOMapping(UstHobiler);
        }
        public List<HobilerDTO> AltHobileriGetir(int kategoriID)
        {
            List<Hobiler> hobiler = _hm.HobileriGetir(kategoriID);
            //List<IlgiAlanlari> UstIlgiAlanlari = _km.UstIlgiAlanlariniGetir();
            return HobilerDTOMapping(hobiler);
        }
        public List<HobilerDTO> HobileriGetir(string hobiAdi)
        {
            List<Hobiler> hobiler = _hm.HobileriGetir(hobiAdi);
            return HobilerDTOMapping(hobiler);
        }  
        public HobilerDTO HobilerDTOMapping(Hobiler hobiler)
        {
            HobilerDTO dto = new HobilerDTO();
            dto.HobiAdi = hobiler.HobiAdi;
            dto.HobiID = hobiler.HobiID;
            dto.HobiUstKategoriID = hobiler.HobiUstKategoriID;
            return dto;

        }
        private List<HobilerDTO> HobilerDTOMapping(List<Hobiler> ılgiAlanlari)
        {
            List<HobilerDTO> dtoList = new List<HobilerDTO>();
            foreach (var item in ılgiAlanlari)
            {
                dtoList.Add(HobilerDTOMapping(item));

            }
            return dtoList;
        }
        public Hobiler HobilerMapping(HobilerDTO hobilerDTO)
        {
            Hobiler hobi = new Hobiler();
            hobi.HobiAdi = hobilerDTO.HobiAdi; ;
            hobi.HobiUstKategoriID = hobilerDTO.HobiUstKategoriID;
            return hobi;
        }
    }
}
