using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DTO
{
    public class KisiBilgileriDTO
    {
        public int kisiID { get; set; }
        public string kisiAdi { get; set; }
        public string kisiSoyAdi { get; set; }
        public string kisiTcNo { get; set; }
        public DateTime kisiDogumTarihi { get; set; }
        public string kisiDogumYeri { get; set; }
        public string kisiUyruk { get; set; }
        public decimal? kisiAylikGelir { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public byte? KardesSayisi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public List<int> Hobiler { get; set; }
  
    }
}
