using KisiselVeriler.DAL.KisiselVerilerDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DAL
{
    public class HobilerManagement
    {
        KisiselVerilerDBContext _db;
        public HobilerManagement()
        {
            // _db = new KisiselVerilerDBContext();
            _db = DBHelper.Context;
        }

        public List<Hobiler> HobileriGetir()
        {
            return _db.Hobiler.ToList();
        }
        public List<Hobiler> HobileriGetir(int kategoriID)
        {
            return _db.Hobiler.Where(x => x.HobiUstKategoriID == kategoriID).ToList();
        }

        public Hobiler GetHobiById(int id)
        {
            return _db.Hobiler.Find(id);
        }

        public List<Hobiler> HobileriGetir(string hobiAdi)
        {
            int ustHobiId = _db.Hobiler.Where(x => x.HobiAdi == hobiAdi).Select(x => x.HobiID).First();
            return HobileriGetir(ustHobiId);
        }

        //public Hobiler UstHobiGetir(int secilenHobiID)
        //{
        //    //return _db.Hobiler.Where(x => x.HobiID == secilenHobiID).Select(x => x.HobiUstKategoriID).First();
        //}

        public List<Hobiler> UstHobileriGetir()
        {
            return _db.Hobiler.Where(x => x.HobiUstKategoriID == null).ToList();
        }
        public int HobiEkle(Hobiler hobi)
        {
            _db.Entry(hobi).State = EntityState.Added;
            return _db.SaveChanges();
        }
    }
}
