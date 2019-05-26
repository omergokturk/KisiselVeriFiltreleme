using KisiselVeriler.DAL.KisiselVerilerDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DAL
{
    public class AileManagement
    {
        KisiselVerilerDBContext _db;
        public AileManagement()
        {
            _db = DBHelper.Context;
        }
        public int AileEkleManagement(AileBilgileri aileBilgileri)
        {
            _db.Entry(aileBilgileri).State = EntityState.Added;
            return _db.SaveChanges();
        }
        public int AileGuncelleManagement(AileBilgileri aileBilgileri)
        {
            _db.Entry(aileBilgileri).State = EntityState.Modified;
            return _db.SaveChanges();
        }
        public AileBilgileri aileGetirManagement(int _id)
        {
            return _db.AileBilgileri.Where(x => x.KisiID == _id).FirstOrDefault();
        }
    }
}
