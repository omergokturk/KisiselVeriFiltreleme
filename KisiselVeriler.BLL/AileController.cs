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
    public class AileController
    {
        AileManagement _abm;
   

        public AileController()
        {
            _abm = new AileManagement();
        }

        public bool AileEkleController(AileBilgileriDTO aileDTO )
        {

            AileBilgileri aileBilgileri = AileDTOtoEntityMapping(aileDTO);
            if (_abm.AileEkleManagement(aileBilgileri) > 0)
            {
                return true;
            }
            return false;
        }

        public bool AileGuncelle(AileBilgileriDTO aileDTO)
        {
           AileBilgileri ab= _abm.aileGetirManagement(aileDTO.KisiID);
            ab=AileDTOtoEntityMapping(aileDTO, ab);
            if (_abm.AileGuncelleManagement(ab) > 0)
            {
                return true;
            }
            return false;
        }

        public AileBilgileri AileDTOtoEntityMapping(AileBilgileriDTO aileDTO)
        {
            AileBilgileri aileBilgileri = new AileBilgileri();
            aileBilgileri.KisiID = aileDTO.KisiID;
            aileBilgileri.AnneAdi = aileDTO.AnneAdi;
            aileBilgileri.BabaAdi = aileDTO.BabaAdi;
            aileBilgileri.KardesSayisi = aileDTO.KardesSayisi;
            return aileBilgileri;
        }

        public AileBilgileri AileDTOtoEntityMapping(AileBilgileriDTO aileDTO, AileBilgileri aileBilgileri)
        {

            aileBilgileri.AnneAdi = aileDTO.AnneAdi;
            aileBilgileri.BabaAdi = aileDTO.BabaAdi;
            aileBilgileri.KardesSayisi = aileDTO.KardesSayisi;
            return aileBilgileri;


        }

        public AileBilgileriDTO aileGetirController(int idYegoreAileGetirilecek)
        {
            AileBilgileri bulunanKisi = new AileBilgileri();
            bulunanKisi = _abm.aileGetirManagement(idYegoreAileGetirilecek);
            return aileBilgileriEntityToDToMapping(bulunanKisi);
        }

        private AileBilgileriDTO aileBilgileriEntityToDToMapping(AileBilgileri bulunanKisi)
        {
            AileBilgileriDTO kisininAilesi1 = new AileBilgileriDTO();
            kisininAilesi1.AnneAdi = bulunanKisi.AnneAdi;
            kisininAilesi1.BabaAdi = bulunanKisi.BabaAdi;
            kisininAilesi1.KardesSayisi = bulunanKisi.KardesSayisi;
            kisininAilesi1.KisiID = bulunanKisi.KisiID;
            return kisininAilesi1;
        }
    }

}
