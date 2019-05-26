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
    public class IletisimController
    {
        IletisimManagement _im;
        public IletisimController()
        {
            _im = new IletisimManagement();
        }

        public bool IletisimEkleController(IletisimBilgileriDTO iletisimDTO)
        {
            IletisimBilgileri iletisimEntity1 = IletisimDTOtoEntityMapping(iletisimDTO);
           
            try
            {
                if (_im.IletisimBilgisiEkleManagement(iletisimEntity1) > 0)
                {

                    return true;
                }
            }
            catch (Exception)
            {

            }
            return false;
        }
        
        private IletisimBilgileri IletisimDTOtoEntityMapping(IletisimBilgileriDTO iletisimDTO)
        {
            IletisimBilgileri iletisimBilgileri = new IletisimBilgileri();

            iletisimBilgileri.Adres = iletisimDTO.Adres;
            iletisimBilgileri.KisiID = iletisimDTO.KisiID;
            iletisimBilgileri.Mail = iletisimDTO.Mail;
            iletisimBilgileri.Telefon = iletisimDTO.Telefon;

            return iletisimBilgileri;

        }

        public IletisimBilgileriDTO iletisimGetirController(int _bulunacakID )
        {
            IletisimBilgileri bulunanKisi = new IletisimBilgileri();
            bulunanKisi = _im.iletisimGetirManagement(_bulunacakID);
            return iletisimBilgileriEntityToDToMapping(bulunanKisi);
        }
       

        private IletisimBilgileriDTO iletisimBilgileriEntityToDToMapping(IletisimBilgileri bulunanKisi)
        {
            IletisimBilgileriDTO kisininIletisim = new IletisimBilgileriDTO();
           
            kisininIletisim.Telefon = bulunanKisi.Telefon;
            kisininIletisim.Mail = bulunanKisi.Mail;
            kisininIletisim.Adres = bulunanKisi.Adres;
            kisininIletisim.KisiID = bulunanKisi.KisiID;
            return kisininIletisim;
        }
    }
}
