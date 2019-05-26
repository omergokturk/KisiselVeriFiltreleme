using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DTO
{
    public class AileBilgileriDTO
    {
        public int KisiID { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public byte? KardesSayisi { get; set; }

    }
}
