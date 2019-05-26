using KisiselVeriler.DAL.KisiselVerilerDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DAL
{
    public class IletisimManagement
    {
        
        public int IletisimBilgisiEkleManagement(IletisimBilgileri iletisimBilgileri)
        {
            DBHelper.Context.Entry(iletisimBilgileri).State = EntityState.Added;

            return DBHelper.Context.SaveChanges();
        }

        public IletisimBilgileri iletisimGetirManagement(int idYegoreIletisimGetirilecek)
        {
            
            return DBHelper.Context.IletisimBilgileri.Where(x => x.KisiID == idYegoreIletisimGetirilecek).FirstOrDefault();
        }
    }
}
