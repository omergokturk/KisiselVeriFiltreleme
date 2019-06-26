using KisiselVeriler.DAL.KisiselVerilerDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DAL
{
    public class KisiManagement
    {
        KisiselVerilerDBContext1 _db;
        public KisiManagement()
        {
            _db = DBHelper.Context;
        }


        public List<KisiselBilgiler> KisiselBilgileriGetir()
        {
            return _db.KisiselBilgiler.ToList();
        }

        
        
        public int kisiEkleManagement(KisiselBilgiler kisi)
        {
            _db.Entry(kisi).State = EntityState.Modified;
            _db.Entry(kisi).State = EntityState.Added;


            try
            {
                return _db.SaveChanges();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            

        }

        public int kisiGuncelle(KisiselBilgiler kisi)
        {
            _db.Entry(kisi).State = EntityState.Modified;
            try
            {
                return _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }


        }
        public KisiselBilgiler IddenKisiNesnesiGetirManagement(int kisiID)
        {
            return _db.KisiselBilgiler.Where(x => x.KisiID == kisiID).FirstOrDefault();
        }

        public KisiselBilgiler kisiGetirManagement(string _bulunacakTc)
        {
            return _db.KisiselBilgiler.Where(x => x.KisiTCNo == _bulunacakTc).FirstOrDefault(); 
        }
        public KisiselBilgiler kisiGetirManagement(int _kisiId)
        {
            return _db.KisiselBilgiler.Where(x => x.KisiID == _kisiId).FirstOrDefault();


        }
    }
}
