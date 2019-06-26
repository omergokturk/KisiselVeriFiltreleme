using KisiselVeriler.DAL.KisiselVerilerDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DAL
{
    public class KisiHobileriManagement
    {
        KisiselVerilerDBContext1 _db;
        public KisiHobileriManagement()
        {
            _db = DBHelper.Context;
        }
        public int KisiHobileriEkle(KisiHobileri kisiHobileri)
        {
            _db.KisiHobileri.Add(kisiHobileri);
            try
            {
                return _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public List<int> HobiIDdenKisiIDGetir(int hobiID)
        {
           return _db.KisiHobileri.Where(x => x.HobiID == hobiID).Select(x => x.KisiID).ToList();
        }
    }
}
